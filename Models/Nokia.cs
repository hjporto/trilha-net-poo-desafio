namespace DesafioPOO.Models
{
    // plicada herança da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // Método "InstalarAplicativo" sobreescrito
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"PlayStore instalando o aplicativo: {nomeApp}");
        }
    }
}