using System;

namespace Exer01
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Exercício 1
            Exercicio1();

            // Adiciona uma linha em branco
            Console.WriteLine();

            // Exercício 2
            Exercicio2();

            // Adiciona uma linha em branco
            Console.WriteLine();

            // Exercício 3
            Exercicio3();

            // Adiciona uma linha em branco
            Console.WriteLine();

            // Exercício 4
            Exercicio4();

            // Adiciona uma linha em branco
            Console.WriteLine();

            // Exercício 5
            Exercicio5();

            // Adiciona uma linha em branco
            Console.WriteLine();

            // Exercício 6
            Exercicio6();

            // Adiciona uma linha em branco
            Console.WriteLine();

            // Exercício 7
            Exercicio7();

            // Adiciona uma linha em branco
            Console.WriteLine();

            // Exercício 8
            Exercicio8();

            // Adiciona uma linha em branco
            Console.WriteLine();

            // Exercício 9
            Exercicio9();

            // Adiciona uma linha em branco
            Console.WriteLine();

            // Exercício 10
            Exercicio10();

            // Adiciona uma linha em branco
            Console.WriteLine();

            // Exercício 11
            Exercicio11();

            // Adiciona uma linha em branco
            Console.WriteLine();

            // Exercício 12
            Exercicio12();

            // Adiciona uma linha em branco
            Console.WriteLine();

            // Exercício 13
            Exercicio13();

            // Adiciona uma linha em branco
            Console.WriteLine();

            // Exercício 14
            Exercicio14();

            // Adiciona uma linha em branco
            Console.WriteLine();

            // Exercício 15
            Exercicio15();


        }

        public static void Exercicio1()
        {
            Console.WriteLine("Digite um número:");
            string? entrada = Console.ReadLine();
            int numero = Convert.ToInt32(entrada);
            if (numero % 2 == 0)
            {
                Console.WriteLine("Seu número é par!");
            }
            else
            {
                Console.WriteLine("Seu número é ímpar!");
            }
        }

        public static void Exercicio2()
        {
            Console.WriteLine("Digite um número e será informado se é positivo, negativo, ou neutro");
            int entrada = Convert.ToInt32(Console.ReadLine());

            if (entrada > 0)
            {
                Console.WriteLine("O número é positivo.");
            }
            else if (entrada == 0)
            {
                Console.WriteLine("O número é neutro.");
            }
            else
            {
                Console.WriteLine("O número é negativo.");
            }
        }

        public static void Exercicio3()
        {
            Console.WriteLine("Digite dois números e eu vou te falar qual é o maior");
            Console.WriteLine("Digite o primeiro número:");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            if (numero1 > numero2)
            {
                Console.WriteLine("O 1° número é o maior.");
            }
            else if (numero2 > numero1)
            {
                Console.WriteLine("O 2° número é o maior.");
            }
            else
            {
                Console.WriteLine("Nenhum número é maior.");
            }
        }
        public static void Exercicio4()
        {
            Console.WriteLine("Vamos verificar se um triângulo é válido!");
            Console.WriteLine("Digite o valor do primeiro lado:");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor do segundo lado:");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor do terceiro lado:");
            int numero3 = Convert.ToInt32(Console.ReadLine());
            if (numero1 + numero2 > numero3 && numero1 + numero3 > numero2 && numero2 + numero3 > numero1)
            {
                Console.WriteLine("Este triângulo é válido.");
            }
            else
            {
                Console.WriteLine("Este triângulo não é válido");
            }
        }
        public static void Exercicio5()
        {
            Console.WriteLine("Vamos calcular sua média de notas!");
            Console.WriteLine("Digite sua primeira nota:");
            int nota1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite sua segunda nota:");
            int nota2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite sua terceira nota:");
            int nota3 = Convert.ToInt32(Console.ReadLine());
            int soma = nota1 + nota2 + nota3;
            if (soma / 3 >= 7)
            {
                Console.WriteLine("Está aprovado.");
            }
            else if (soma / 3 >= 5)
            {
                Console.WriteLine("Está em recuperação.");
            }
            else
            {
                Console.WriteLine("Está reprovado.");
            }
        }

        public static void Exercicio6()
        {
            Console.WriteLine("Digite um ano para verificar se é bissexto:");
            int ano = Convert.ToInt32(Console.ReadLine());

            if ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0))
            {
                Console.WriteLine("O ano " + ano + " é bissexto.");
            }
            else
            {
                Console.WriteLine("O ano " + ano + " não é bissexto.");
            }
        }
        public static void Exercicio7()
        {
            Console.WriteLine("Vamos te dizer se você é criança, adolescente, adulto ou idoso!");
            Console.WriteLine("Digite sua idade:");
            int idade = Convert.ToInt32(Console.ReadLine());
            if (idade <= 12)
            {
                Console.WriteLine("Você é uma criança.");
            }
            else if (idade <= 17)
            {
                Console.WriteLine("Você é um adolescente.");
            }
            else if (idade <= 59)
            {
                Console.WriteLine("Você é um adulto.");
            }
            else
            {
                Console.WriteLine("Você é um idoso.");
            }
        }

        public static void Exercicio8()
        {
            Console.WriteLine("Digite sua nota em número, e eu vou converter para letras!");
            int nota = Convert.ToInt32(Console.ReadLine());
            if (nota >= 9)
            {
                Console.WriteLine("Sua nota vale A.");
            }
            else if (nota >= 7)
            {
                Console.WriteLine("Sua nota vale B.");
            }
            else if (nota >= 5)
            {
                Console.WriteLine("Sua nota vale C.");
            }
            else if (nota >= 3)
            {
                Console.WriteLine("Sua nota vale D.");
            }
            else
            {
                Console.WriteLine("Sua nota vale F.");
            }
        }
        public static void Exercicio9()
        {
            Console.WriteLine("Me diga o código do produto de 1 a 40, e vou te informar sua categoria!");
            int produto = Convert.ToInt32(Console.ReadLine());
            if ((produto > 0) && (produto <= 10))
            {
                Console.WriteLine("Este produto é um alimento não perecível.");
            }
            else if ((produto >= 10) && (produto <= 20))
            {
                Console.WriteLine("Este produto é um alimento perecível.");
            }
            else if ((produto >= 20) && (produto <= 30))
            {
                Console.WriteLine("Este produto é de vestuário.");
            }
            else if ((produto >= 30) && (produto <= 40))
            {
                Console.WriteLine("Este produto é um eletrônico.");
            }
            else
            {
                Console.WriteLine("Este é um código inválido");
            }
        }
        public static void Exercicio10()
        {
            Console.WriteLine("Vamos digitar 2 números e uma operação, para dizer o resultado!");
            Console.WriteLine("Digite o primeiro número:");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o primeiro número:");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escolha a operação matemática: ( + , - , * , /) ");
            string? operacao = (Console.ReadLine());

            if (operacao == "+")
            {
                int soma = numero1 + numero2;
                Console.WriteLine("A soma dos dois números é:" + soma);
            }
            else if (operacao == "-")
            {
                int subtracao = numero1 - numero2;
                Console.WriteLine("A subtração dos dois números é:" + subtracao);
            }
            else if (operacao == "*")
            {
                int multiplicacao = numero1 * numero2;
                Console.WriteLine("A multiplicação dos dois números é:" + multiplicacao);
            }
            else if (operacao == "/")
            {
                int divisao = numero1 / numero2;
                Console.WriteLine("A divisão dos dois números é:" + divisao);
            }
        }

        public static void Exercicio11()
        {
            Console.WriteLine("Escreva um número para saber se ele está no intervalo entre 10 e 20.");
            int numero = Convert.ToInt32(Console.ReadLine());
            if ((numero >= 10) && (numero <= 20))
            {
                Console.WriteLine("O número está no intervalo de 10 a 20.");
            }
            else
            {
                Console.WriteLine("O número passa ou não chega entre 10 e 20.");
            }
        }

        public static void Exercicio12()
        {
            Console.WriteLine("Digite um número, se for menor que 100, ele será dobrado!");
            int numero = Convert.ToInt32(Console.ReadLine());
            if (numero <= 100)
            {
                int soma = numero * 2;
                Console.WriteLine("O número agora é " + soma + " pois o valor era menor ou igual a 100, então foi dobrado.");
            }
            else
            {
                int soma = numero;
                Console.WriteLine("o número " + soma + " é maior que 100, então sem alterações.");
            }
        }

        public static void Exercicio13()
        {
            Console.WriteLine("Vamos fazer um conta baseado no valor do produto, e no seu perfil!");
            Console.WriteLine("Qual é o seu perfil? ( 1 = comum | 2 = associado | 3 = VIP)");
            int perfil = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("E qual é o valor do produto?");
            double valor = Convert.ToDouble(Console.ReadLine());

            double conta = valor;

            if (perfil == 1)
            {
                conta = valor;
                Console.WriteLine("O valor do seu produto é cheio: " + conta);
            }
            else if (perfil == 2)
            {
                conta = valor - (valor * 0.1);
                Console.WriteLine("O valor do seu produto teve um desconto de 10%: " + conta);
            }
            else if (perfil == 3)
            {
                conta = valor - (valor * 0.2);
                Console.WriteLine("O valor do seu produto teve um desconto de 20%: " + conta);
            }
        }

        public static void Exercicio14()
        {
            Console.WriteLine("Digite um número positivo ou negativo... Positivo = raíz quadrada do valor | Negativo = o valor ao quadrado.");
            double valor = Convert.ToDouble(Console.ReadLine());
            if (valor >= 0)
            {
                double conta = Math.Sqrt(valor);
                Console.WriteLine("Como o valor é positivo, sua raíz quadrada é: " + conta);
            }
            else if (valor <= 0)
            {
                double conta = valor * valor;
                Console.WriteLine("Como o valor é negativo, ele ao quadrado é: " + conta);
            }
        }

        public static void Exercicio15()
        {
            Console.WriteLine("Vamos calcular seu IMC!");
            Console.WriteLine("Digite sua altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Agora digite seu peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());


            double imc = (peso / (altura * altura));

            string categoria;
            if (imc < 18.5)
            {
                categoria = "Abaixo do peso";
            }
            else if (imc >= 18.5 && imc < 24.9)
            {
                categoria = "Peso normal";
            }
            else if (imc >= 25 && imc < 29.9)
            {
                categoria = "Sobrepeso";
            }
            else if (imc >= 30 && imc < 34.9)
            {
                categoria = "Obesidade grau I";
            }
            else if (imc >= 35 && imc < 39.9)
            {
                categoria = "Obesidade grau II";
            }
            else
            {
                categoria = "Obesidade grau III";
            }
            Console.WriteLine("Seu IMC é de: " + imc.ToString("F4") + " você está na categoria: " + categoria);
        }
    }
}
