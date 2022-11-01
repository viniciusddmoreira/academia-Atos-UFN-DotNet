function ExemploCondicionais() {

    var numero = 1;
    //Comparação normal (compara apenas os valores)
    if (numero == "1") { //resultado: true
        alert("== compara apenas os valores");
    }

    //Comparação restrita (compara valores e tipos das variáveis)
    var mensagem;
    if (numero === "1") { //resultado: false
        mensagem = "Nunca executa";
    } else {
        mensagem = "Number é diferente de String com o ==="
    }
    alert(mensagem);
    /*
    Operador ternário (versão reduzida do IF)
    condição ? se_verdadeiro : se_falso;
    */
    var x = (numero === "1") ? "Nunca executa" : "Number é diferente de String com o ===";
    alert(x);
}

function ExemploSwithCase() {

    var laranja = 6;
    switch (laranja) {
        case 3:
            alert('Fazer um copo de suco');
            break;
        case 6:
            alert('Fazer dois copos de suco');
            break;
        case 9:
            alert('Fazer uma jarra de suco');
            break;
        default:
            alert('Fazer quanto suco for possível');
    }
}

function ExemploLacoRepeticaoFor() {

    // FOR - executa um laço um determinado numero de vezes
    var pessoas = ["João", "José", "Maria", "Sebastião", "Antônio"];

    for (var i = 0; i < pessoas.length; i++) {
        alert(pessoas[i]);
    }

    // FOR IN - executa um laço nas propriedades de um objeto
    var nome = "";
    var pessoas = { nome: "Iara", sobrenome: "Almeida" };
    for (x in pessoas) {
        nome += pessoas[x] + " ";
    }
    alert(nome);
}

function ExemploLacoRepeticaoWhile() {

    var resultado = "";
    var numero = 1;

    while (numero <= 10) {
        resultado += numero + " ";
        numero++;
    }
    alert(resultado);

    var resultado = "";
    var numero = 10;

    do {
        resultado += numero + " ";
        numero--;
    } while (numero >= 1);
    alert(resultado);
}

function exercicio01() {
    //Exercício 1
    //Escreva um código que mostre os números ímpares entre 1 e 10.

    for (var i = 0; i < 11; i++) {
        if (i % 2 != 0) {
            alert(i);
        }
    }
}

function exercicio02() {
    //Exercício 2 
    //Escreva um código que calcule a soma de 1 até 100 (PS: a resposta é 5050)

    var soma = 0;
    for (var i = 0; i < 101; i++) {
        soma += i;
    }
    alert(soma);
}

function ExemploNomeEmCaixaAlta() {

    var nome = document.getElementById("nome");
    nome.value = nome.value.toUpperCase();
}

function ExemploAlertComNomeDigitado() {

    var nome = document.getElementById("nome");
    alert(nome.value);
}

function exercicio03() {
    //Exercício 03
    //Construa uma página com dois inputs do tipo Text (um para nome e outro para idade) e um botão. Ao clicar no botão, mostre uma mensagem como esta: "Juarez tem 22 anos".

    var nome = document.getElementById("nome");
    var idade = document.getElementById("idade");
    alert(nome.value + " tem " + idade.value + " anos.");
}

function exercicio04() {
    //Exercício 04
    //Construa uma pagina com dois inputs do tipo Text (um para nome e outro para idade) e um botão. Ao clicar no botão, mostre uma mensagem como esta: "Juarez é maior de idade".

    var nome = document.getElementById("nome");
    var idade = document.getElementById("idade");
    (idade.value >= 18) ? alert(nome.value + " é maior de idade.") : alert(nome.value + " é menor de idade.");
}

function exercicio05() {
    //Exercício 05
    //Construa uma pagina com dois inputs do tipo Text e um botão. Ao clicar no botão, mostre o resultado da soma dos valores atribuídos aos inputs.

    var valor1 = document.getElementById("valor1");
    var valor2 = document.getElementById("valor2");
    var soma = parseInt(valor1.value) + parseInt(valor2.value);
    alert(soma);
}

function exercicio06() {
    //Exercício 06
    //Continuando o exercício anterior, mude a cor do botão para azul se o resultado for par e para verde se for ímpar.

    var soma = parseInt(valor1.value) + parseInt(valor2.value);
    if (soma % 2 == 0) {
        btnEnviar.style.backgroundColor = "blue";
    } else {
        btnEnviar.style.backgroundColor = "green";
    }

    alert(soma);
}