namespace randomnumber;
class Program
{
    static void Main(string[] args)
    {
        var cajon = new Cajon();

        var numberOfRNG = Console.ReadLine();
        List<String> nombres = new List<String>();

        Console.WriteLine("¡Hola! Bienvenido a la caja de números aleatorios");
        Console.WriteLine("¿Cuántos generadores de números aleatorios quieres?");

        for (int i = 0; i < Convert.ToInt32(numberOfRNG); i++)
        {
            Console.WriteLine($"¿Cómo quieres llamar al generador de números aleatorios {i + 1}?");
            var name = Console.ReadLine();
            while(name == "" || nombres.Contains(name)){
                Console.WriteLine("El nombre no puede estar vacío o repetido");
                Console.WriteLine($"¿Cómo quieres llamar al generador de números aleatorios {i + 1}?");
                name = Console.ReadLine();
            }
            nombres.Add(name);
        }

        Console.WriteLine("¡Genial! Ahora, ¿cuántos números quieres sacar?");

        var numberOfRGNToTakeOut = Console.ReadLine();

        for (int i = 0; i < Convert.ToInt32(numberOfRGNToTakeOut); i++)
        {
            var randomNumber = cajon.takeOutRandomNumberGenerator();
            Console.WriteLine($"Número aleatorio: {randomNumber}");
        }

        Console.WriteLine("¡Gracias por usar la caja de números aleatorios!");

        waitForKeyPress();
    }

    private static void waitForKeyPress()
    {
        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}