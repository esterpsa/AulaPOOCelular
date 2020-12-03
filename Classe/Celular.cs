namespace POO.Classe
{
    public class Celular
    {
        public string modelo;

        public string tamanho; 

        public string cor;

        public string ligado; 

        public int enviar;

        public string ligar(){
            return "O celular está ligado";
        }

        public string Desligar(){
            return "O celular está desligando";
        }

        public string EnviarMensagem(){
            return "Enviando mensagem.....";
        }

        public string Ligando(){
            return "Chamando....";
        }
    }
}