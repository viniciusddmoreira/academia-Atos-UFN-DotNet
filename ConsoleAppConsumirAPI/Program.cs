using Newtonsoft.Json;
using System.Net.Http.Json;

namespace ConsoleAppConsumirAPI
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string BaseUrl = "http://localhost:5291/";
            int opcao = 0;

            do
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("1 - Efeturar Consulta");
                Console.WriteLine("2 - Efeturar Cadastro");
                Console.WriteLine("0 - Sair");

                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");

                switch (opcao)
                {
                    case 1:
                        List<Pessoa>? pessoas = new List<Pessoa>();

                        HttpClient client = new HttpClient();
                        client.BaseAddress = new Uri(BaseUrl);
                        client.DefaultRequestHeaders.Clear();
                        client.DefaultRequestHeaders.Accept.Add(
                            new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                        HttpResponseMessage response = await client.GetAsync("api/pessoas");

                        if (response.IsSuccessStatusCode)
                        {
                            var dados = response.Content.ReadAsStringAsync().Result;
                            pessoas = JsonConvert.DeserializeObject<List<Pessoa>>(dados);

                            foreach (Pessoa item in pessoas)
                            {
                                Console.WriteLine(item.Id + " - " + item.Nome);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Erro: " + response.StatusCode.ToString());
                        }
                        break;
                    case 2:
                        Pessoa p = new Pessoa();
                        Console.WriteLine("Informe o nome da pessoa:");
                        p.Nome = Console.ReadLine();

                        try
                        {
                            HttpClient clientPost = new HttpClient();
                            HttpResponseMessage responsePost = await clientPost.PostAsJsonAsync(
                                BaseUrl + "api/pessoas", p);
                            Console.WriteLine("Response: " + responsePost.StatusCode);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Erro: " + e.Message);
                        }
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opção inválida, tente novamente!");
                        break;
                }
            } while (opcao != 0);         
        }
    }
}