
public class Persona
{
    //Atributos o parámetros:

    public string Nombre { get; set; }

    public string Apellido { get; set; }

    public double Estatura { get; set; }

    public int Edad { get; set; }

    public string Genero { get; set; }

    //Métodos o acciones:

    public void Caminar()
    {
        Console.WriteLine($"{Nombre} {Apellido} puede caminar");
    }

    public void Comer()
    {
        Console.WriteLine($"{Nombre} {Apellido} come hamburguesa");
    }

    public void Correr()
    {
        Console.WriteLine($"{Nombre} {Apellido} puede correr");
    }
}

class Program
{
    static void Main()
    {
        // Crear una instancia de Persona
        Persona persona = new Persona
        {
            Nombre = "Mariana",
            Apellido = "Charry",
            Estatura = 1.70,
            Edad = 18,
            Genero = "Femenino"
        };

        // Mostrar información de la persona
        Console.WriteLine($"Nombre: {persona.Nombre} {persona.Apellido}");
        Console.WriteLine($"Estatura: {persona.Estatura} metros");
        Console.WriteLine($"Edad: {persona.Edad} años");
        Console.WriteLine($"Género: {persona.Genero}");

        // Llamar a los métodos de la persona
        persona.Caminar();
        persona.Comer();
        persona.Correr();
    }
}

