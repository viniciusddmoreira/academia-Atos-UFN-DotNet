using Newtonsoft.Json;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SerializacaoWinForms
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSerializar_Click(object sender, EventArgs e)
        {
            try
            {
                string serializar = txbSerializar.Text;
                FileStream fs = new FileStream(@"C:\temp\Vinicius.data", FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, serializar);
                fs.Close();

                MessageBox.Show("Serializado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnDesserializar_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\temp\Vinicius.data", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            string dadosDesserializados = (string)bf.Deserialize(fs);
            fs.Close();

            txbDesserializar.Text = dadosDesserializados;
        }

        private void btnSerializar2_Click(object sender, EventArgs e)
        {
            try
            {
                Pessoa p = new Pessoa();
                p.idade = 27;
                p.nome = "Vinicius";
                p.salario = 10000;

                FileStream stream = new FileStream(@"C:\temp\pessoa1.data", FileMode.Create);
                SoapFormatter soap = new SoapFormatter();

                soap.Serialize(stream, p);
                stream.Close();

                MessageBox.Show("Sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnDesserializar2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\temp\pessoa1.data", FileMode.Open);
            Pessoa p = new Pessoa();
            SoapFormatter soap = new SoapFormatter();
            p = (Pessoa)soap.Deserialize(fs);

            fs.Close();
        }

        private void btnSerializarXML_Click(object sender, EventArgs e)
        {
            try
            {
                Pessoa p = new Pessoa();
                p.idade = 27;
                p.nome = "Vinicius";
                p.salario = 10000;

                FileStream stream = new FileStream(@"C:\temp\pessoa1.xml", FileMode.Create);
                XmlSerializer xml = new XmlSerializer(typeof(Pessoa));

                xml.Serialize(stream, p);
                stream.Close();

                MessageBox.Show("Sucesso 1");

                XmlSerializer serializer = new XmlSerializer(typeof(Pessoa));
                StreamWriter writer = new StreamWriter(@"C:\temp\pessoa2.xml");
                serializer.Serialize(writer.BaseStream, p);
                writer.Close();

                MessageBox.Show("Sucesso 2");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnDesserializarXML_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Pessoa));
            StreamReader reader = new StreamReader(@"C:\temp\pessoa1.xml");
            Pessoa deserialized = (Pessoa)serializer.Deserialize(reader.BaseStream);
            reader.Close();
        }

        private void btnSerializarJson_Click(object sender, EventArgs e)
        {
            try
            {
                Pessoa p = new Pessoa();
                p.idade = 27;
                p.nome = "Vinicius";
                p.salario = 10000;

                JsonSerializer serializer = new JsonSerializer();
                StreamWriter sw = new StreamWriter(@"C:\temp\pessoa.json");
                JsonWriter writer = new JsonTextWriter(sw);
                serializer.Serialize(writer, p);
                sw.Close();
                writer.Close();

                MessageBox.Show("Sucesso");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnDesserializarJson_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText(@"C:\temp\pessoa.json");

            Pessoa p = JsonConvert.DeserializeObject<Pessoa>(json);
            
        }
    }
}
