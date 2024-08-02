public class Animal
{
    public virtual void HacerSonido()
    {
        Console.WriteLine("Un animal hace algún sonido");
    }
}

public class Perro : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine("El perro ladra, hace ¡guau, guau!");
    }
}

public class Gato : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine("El gato maulla, hace ¡miau, miau!");
    }
}

class Program
{
    static void Main()
    {
        Animal miAnimal = new Animal();
        Animal miPerro = new Perro();
        Animal miGato= new Gato();

        miAnimal.HacerSonido(); // Salida: El animal hace algún sonido
        miPerro.HacerSonido(); // Salida: El perro ladra
        miGato.HacerSonido();
    }
}
