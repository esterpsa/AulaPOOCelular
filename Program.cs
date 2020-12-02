using System;
using POO.Classe;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular celular1 = new Celular();
            int resposta = 0;
            string mensagem = "";

            Console.WriteLine("Celular");
            Console.WriteLine("-------------");
            
            Console.WriteLine($"Digite o modelo do celular: ");
            celular1.modelo = Console.ReadLine();

            Console.WriteLine("Digite o tamanho do celular, digite apenas númeras: ");
            celular1.tamanho = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a cor do celular: ");
            celular1.cor = Console.ReadLine();

            Console.WriteLine("Selecione uma opção: L - Ligar, D - Desligar");
            celular1.ligado = Console.ReadLine();
            
            Console.WriteLine("Ligue o celular");
            celular1.ligado = Console.ReadLine();

           while(celular1.ligado != "L"){
               Console.WriteLine("Ligue o Celular");
               celular1.ligado = Console.ReadLine();
           }

        
            Console.WriteLine("Selecione uma opção: ");
            Console.WriteLine("[1] - Enviar Mensagem");
            Console.WriteLine("[2] - Fazer ligação");
            resposta = int.Parse(Console.ReadLine());

            if(resposta == 1){
                int opcao = 0;
                Console.WriteLine("Digite a mensagem minímo 300 caracteres: ");
                mensagem = Console.ReadLine();
                 Console.WriteLine("--------------------------------");
                Console.WriteLine("Você digitou: "+mensagem);
            
                Console.WriteLine("Selecione uma opção: ");
                Console.WriteLine("[1] - Editar");
                Console.WriteLine("[2] - Enviar");
                opcao = int.Parse(Console.ReadLine());
    
                switch (opcao)
                {
                    case  1:
                    Console.WriteLine("Digite a mensagem novamente: ");
                    mensagem = Console.ReadLine();
                     Console.WriteLine("Digite o número do destinário: ");
                    int numero = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Aguarde alguns instantes {celular1.EnviarMensagem()} ");
                    break;

                    case 2:
                    Console.WriteLine("Digite o número do destinário: ");
                    numero = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Aguarde alguns instantes {celular1.EnviarMensagem()} ");
                    break;
                    default: 

                    Console.WriteLine("Opção Inválida");
                    break;
                }
            }if(resposta == 2){
                int numero = 0;
                Console.WriteLine("Digite o número: ");
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine($"Aguarde {celular1.Ligando()}"); 
            }
        }
    }
}
