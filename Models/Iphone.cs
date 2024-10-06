namespace DesafioPOO.Models
{
    // Aplicada herança da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }

        // Método "InstalarAplicativo" sobreescrito
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"AppStore instalando o aplicativo: {nomeApp}");
        }
    }
}