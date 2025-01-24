namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) :
        base(numero, modelo, imei, memoria)
        { }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        // Sobrepor o metodo InstalarAplicativo da classe Smartphone
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no Nokia");
        }
    }
}