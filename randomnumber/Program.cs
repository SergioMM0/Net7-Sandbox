namespace randomnumber;
class Program
{
    static void Main(string[] args)
    {
        var cajon = new Cajon();

        var nombres = new List<string>();

        Console.WriteLine("¡Hola! Bienvenido a la caja de números aleatorios");
        Console.WriteLine("¿Cuántos generadores de números aleatorios quieres?");

        var numberOfRNG = Console.ReadLine();


        for (int i = 0; i < Convert.ToInt32(numberOfRNG); i++)
        {
            Console.WriteLine($"¿Cómo quieres llamar al generador de números aleatorios {i + 1}?");
            var name = Console.ReadLine();
            while (name == "" || nombres.Contains(name))
            {
                Console.WriteLine("El nombre no puede estar vacío o repetido");
                Console.WriteLine($"¿Cómo quieres llamar al generador de números aleatorios {i + 1}?");
                name = Console.ReadLine();
            }
            nombres.Add(name);
        }
        foreach(string nombre in nombres){
            Console.WriteLine("Los nombres son: " + nombre);
        }

        for (int i = 0; i < Convert.ToInt32(numberOfRNG); i++)
        {
            var rng = new RandomNumberGenerator(nombres[i]);
            cajon.addRandomNumberGenerator(rng);
        }

        Console.WriteLine("¡Genial! Ahora, ¿cuántos números quieres sacar?");

        var numberOfRGNToTakeOut = Console.ReadLine();

        for (int i = 0; i < Convert.ToInt32(numberOfRGNToTakeOut)-1; i++)
        {
            var RNGName = cajon.randomList.First().name;
            var randomNumber = cajon.takeOutRandomNumberGenerator();
            Console.WriteLine($"Hemos sacado el RNG {RNGName}y parece que está diciendo algo: {randomNumber}");
        }

        Console.ReadLine();

        Console.WriteLine("¡Eso es todo!");

        Console.ReadLine();

        Console.WriteLine("Ah! Parece que me he olvidado de un RGN en el cajón!!");

        Console.WriteLine("Creo que su nombre era... " + cajon.randomList.First().name + " ,¿cierto?");

        Console.WriteLine("El RGN dice que su número es... " + cajon.randomList.First().randomNumber() + "!!");

        Console.WriteLine("¡Eso es todo!");

        waitForKeyPress();
    }

    private static void waitForKeyPress()
    {
        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}