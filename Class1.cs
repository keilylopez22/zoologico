class Leon
{
    private string nombre { get; set; }

    private int altura { get; set; }

    private int peso { get; set; }

    private string sexo { get; set; }


    private int edad { get; set; }


    private string especie { get; set; }

    public Leon(string nombre, int altura, int peso, string sexo, int edad, string especie)
    {
        this.nombre = nombre;
        this.altura = altura;
        this.peso = peso;
        this.sexo = sexo;
        this.edad = edad;
        this.especie = especie;
    }

    public Leon(string nombre, string sexo)
    {
        this.nombre = nombre;
        this.sexo = sexo;
    }



    public void alimentar()
    {
        Console.WriteLine("Come carne");
    }



    public void ruido()
    {
        Console.WriteLine("GRRRRRRR");
    }



    public override string ToString()
    {
        return "Nombre: " + "\n" + this.nombre + "\n" + "Especie: " + this.especie;
    }
}


class Elefante
{
    private string nombre { get; set; }

    private int altura { get; set; }

    private int peso { get; set; }

    private string sexo { get; set; }


    private int edad { get; set; }


    private string especie { get; set; }

    public Elefante(string nombre, int altura, int peso, string sexo, int edad, string especie)
    {
        this.nombre = nombre;
        this.altura = altura;
        this.peso = peso;
        this.sexo = sexo;
        this.edad = edad;
        this.especie = especie;
    }

    public Elefante(string nombre, string sexo)
    {
        this.nombre = nombre;
        this.sexo = sexo;
    }



    public void alimentar()
    {
        Console.WriteLine("Come hojas");
    }



    public void ruido()
    {
        Console.WriteLine("UHHH");
    }



    public override string ToString()
    {
        return "Nombre: " + "\n" + this.nombre + "\n" + "Especie: " + this.especie;
    }
}

class Jirafa
{
    private string nombre { get; set; }

    private int altura { get; set; }

    private int peso { get; set; }

    private string sexo { get; set; }


    private int edad { get; set; }


    private string especie { get; set; }

    public Jirafa(string nombre, int altura, int peso, string sexo, int edad, string especie)
    {
        this.nombre = nombre;
        this.altura = altura;
        this.peso = peso;
        this.sexo = sexo;
        this.edad = edad;
        this.especie = especie;
    }

    public Jirafa(string nombre, string sexo)
    {
        this.nombre = nombre;
        this.sexo = sexo;
    }



    public void alimentar()
    {
        Console.WriteLine("Come hojas");
    }



    public void ruido()
    {
        Console.WriteLine("aaahhhhhhhhhhh");
    }



    public override string ToString()
    {
        return "Nombre: " + "\n" + this.nombre + "\n" + "Especie: " + this.especie;
    }
}

class Tigre
{
    private string nombre { get; set; }

    private int altura { get; set; }

    private int peso { get; set; }

    private string sexo { get; set; }


    private int edad { get; set; }


    private string especie { get; set; }

    public Tigre(string nombre, int altura, int peso, string sexo, int edad, string especie)
    {
        this.nombre = nombre;
        this.altura = altura;
        this.peso = peso;
        this.sexo = sexo;
        this.edad = edad;
        this.especie = especie;
    }

    public Tigre(string nombre, string sexo)
    {
        this.nombre = nombre;
        this.sexo = sexo;
    }



    public void alimentar()
    {
        Console.WriteLine("Come carne");
    }



    public void ruido()
    {
        Console.WriteLine("GARRRRRRR");
    }



    public override string ToString()
    {
        return "Nombre: " + "\n" + this.nombre + "\n" + "Especie: " + this.especie;
    }
}
class Mono
{
    private string nombre { get; set; }

    private int altura { get; set; }

    private int peso { get; set; }

    private string sexo { get; set; }


    private int edad { get; set; }


    private string especie { get; set; }

    public Mono(string nombre, int altura, int peso, string sexo, int edad, string especie)
    {
        this.nombre = nombre;
        this.altura = altura;
        this.peso = peso;
        this.sexo = sexo;
        this.edad = edad;
        this.especie = especie;
    }

    public Mono(string nombre, string sexo)
    {
        this.nombre = nombre;
        this.sexo = sexo;
    }



    public void alimentar()
    {
        Console.WriteLine("Come carne");
    }



    public void ruido()
    {
        Console.WriteLine("UUUUAAAAAAH");
    }



    public override string ToString()
    {
        return "Nombre: " + "\n" + this.nombre + "\n" + "Especie: " + this.especie;
    }
}
class Oso
{
    private string nombre { get; set; }

    private int altura { get; set; }

    private int peso { get; set; }

    private string sexo { get; set; }


    private int edad { get; set; }


    private string especie { get; set; }

    public Oso(string nombre, int altura, int peso, string sexo, int edad, string especie)
    {
        this.nombre = nombre;
        this.altura = altura;
        this.peso = peso;
        this.sexo = sexo;
        this.edad = edad;
        this.especie = especie;
    }

    public Oso(string nombre, string sexo)
    {
        this.nombre = nombre;
        this.sexo = sexo;
    }



    public void alimentar()
    {
        Console.WriteLine("Come carne");
    }



    public void ruido()
    {
        Console.WriteLine("ARR");
    }



    public override string ToString()
    {
        return "Nombre: " + "\n" + this.nombre + "\n" + "Especie: " + this.especie;
    }
}
class Cocodrilo
{
    private string nombre { get; set; }

    private int altura { get; set; }

    private int peso { get; set; }

    private string sexo { get; set; }


    private int edad { get; set; }


    private string especie { get; set; }

    public Cocodrilo(string nombre, int altura, int peso, string sexo, int edad, string especie)
    {
        this.nombre = nombre;
        this.altura = altura;
        this.peso = peso;
        this.sexo = sexo;
        this.edad = edad;
        this.especie = especie;
    }

    public Cocodrilo(string nombre, string sexo)
    {
        this.nombre = nombre;
        this.sexo = sexo;
    }



    public void alimentar()
    {
        Console.WriteLine("Come carne");
    }



    public void ruido()
    {
        Console.WriteLine("HHHHHHHRRRRRR");
    }



    public override string ToString()
    {
        return "Nombre: " + "\n" + this.nombre + "\n" + "Especie: " + this.especie;
    }
}
class serpiente
{
    private string nombre { get; set; }

    private int altura { get; set; }

    private int peso { get; set; }

    private string sexo { get; set; }


    private int edad { get; set; }


    private string especie { get; set; }

    public Serpiente(string nombre, int altura, int peso, string sexo, int edad, string especie)
    {
        this.nombre = nombre;
        this.altura = altura;
        this.peso = peso;
        this.sexo = sexo;
        this.edad = edad;
        this.especie = especie;
    }

    public Serpiente(string nombre, string sexo)
    {
        this.nombre = nombre;
        this.sexo = sexo;
    }



    public void alimentar()
    {
        Console.WriteLine("Come Ratones de todo");
    }



    public void ruido()
    {
        Console.WriteLine("shhhhhshshhsh");
    }



    public override string ToString()
    {
        return "Nombre: " + "\n" + this.nombre + "\n" + "Especie: " + this.especie;
    }
}
class Pinguino
{
    private string nombre { get; set; }

    private int altura { get; set; }

    private int peso { get; set; }

    private string sexo { get; set; }


    private int edad { get; set; }


    private string especie { get; set; }

    public Pinguino(string nombre, int altura, int peso, string sexo, int edad, string especie)
    {
        this.nombre = nombre;
        this.altura = altura;
        this.peso = peso;
        this.sexo = sexo;
        this.edad = edad;
        this.especie = especie;
    }

    public Pinguino(string nombre, string sexo)
    {
        this.nombre = nombre;
        this.sexo = sexo;
    }



    public void alimentar()
    {
        Console.WriteLine("Come pez");
    }



    public void ruido()
    {
        Console.WriteLine("AH AH AH AH AH");
    }



    public override string ToString()
    {
        return "Nombre: " + "\n" + this.nombre + "\n" + "Especie: " + this.especie;
    }
}
class Lobo
{
    private string nombre { get; set; }

    private int altura { get; set; }

    private int peso { get; set; }

    private string sexo { get; set; }


    private int edad { get; set; }


    private string especie { get; set; }

    public Lobo(string nombre, int altura, int peso, string sexo, int edad, string especie)
    {
        this.nombre = nombre;
        this.altura = altura;
        this.peso = peso;
        this.sexo = sexo;
        this.edad = edad;
        this.especie = especie;
    }

    public Lobo(string nombre, string sexo)
    {
        this.nombre = nombre;
        this.sexo = sexo;
    }



    public void alimentar()
    {
        Console.WriteLine("Come carne");
    }



    public void ruido()
    {
        Console.WriteLine("AUUUUUUUUUUUUU");
    }



    public override string ToString()
    {
        return "Nombre: " + "\n" + this.nombre + "\n" + "Especie: " + this.especie;
    }
}
class Cebra
{
    private string nombre { get; set; }

    private int altura { get; set; }

    private int peso { get; set; }

    private string sexo { get; set; }


    private int edad { get; set; }


    private string especie { get; set; }

    public Cebra(string nombre, int altura, int peso, string sexo, int edad, string especie)
    {
        this.nombre = nombre;
        this.altura = altura;
        this.peso = peso;
        this.sexo = sexo;
        this.edad = edad;
        this.especie = especie;
    }

    public Cebra(string nombre, string sexo)
    {
        this.nombre = nombre;
        this.sexo = sexo;
    }



    public void alimentar()
    {
        Console.WriteLine("Come carne");
    }



    public void ruido()
    {
        Console.WriteLine("GUGUGUGU");
    }



    public override string ToString()
    {
        return "Nombre: " + "\n" + this.nombre + "\n" + "Especie: " + this.especie;
    }
}
class Rinoceronte
{
    private string nombre { get; set; }

    private int altura { get; set; }

    private int peso { get; set; }

    private string sexo { get; set; }


    private int edad { get; set; }


    private string especie { get; set; }

    public Rinoceronte(string nombre, int altura, int peso, string sexo, int edad, string especie)
    {
        this.nombre = nombre;
        this.altura = altura;
        this.peso = peso;
        this.sexo = sexo;
        this.edad = edad;
        this.especie = especie;
    }

    public Rinoceronte(string nombre, string sexo)
    {
        this.nombre = nombre;
        this.sexo = sexo;
    }



    public void alimentar()
    {
        Console.WriteLine("Come carne");
    }



    public void ruido()
    {
        Console.WriteLine("grrrrrrrrr");
    }



    public override string ToString()
    {
        return "Nombre: " + "\n" + this.nombre + "\n" + "Especie: " + this.especie;
    }
}
class Panda
{
    private string nombre { get; set; }

    private int altura { get; set; }

    private int peso { get; set; }

    private string sexo { get; set; }


    private int edad { get; set; }


    private string especie { get; set; }

    public Panda(string nombre, int altura, int peso, string sexo, int edad, string especie)
    {
        this.nombre = nombre;
        this.altura = altura;
        this.peso = peso;
        this.sexo = sexo;
        this.edad = edad;
        this.especie = especie;
    }

    public Panda(string nombre, string sexo)
    {
        this.nombre = nombre;
        this.sexo = sexo;
    }



    public void alimentar()
    {
        Console.WriteLine("Come bambu");
    }



    public void ruido()
    {
        Console.WriteLine("ja ja ja");
    }



    public override string ToString()
    {
        return "Nombre: " + "\n" + this.nombre + "\n" + "Especie: " + this.especie;
    }
}
class PavoReal
{
    private string nombre { get; set; }

    private int altura { get; set; }

    private int peso { get; set; }

    private string sexo { get; set; }


    private int edad { get; set; }


    private string especie { get; set; }

    public PavoReal(string nombre, int altura, int peso, string sexo, int edad, string especie)
    {
        this.nombre = nombre;
        this.altura = altura;
        this.peso = peso;
        this.sexo = sexo;
        this.edad = edad;
        this.especie = especie;
    }

    public PavoReal(string nombre, string sexo)
    {
        this.nombre = nombre;
        this.sexo = sexo;
    }



    public void alimentar()
    {
        Console.WriteLine("Come hojas");
    }



    public void ruido()
    {
        Console.WriteLine("MA MA MA MA");
    }



    public override string ToString()
    {
        return "Nombre: " + "\n" + this.nombre + "\n" + "Especie: " + this.especie;
    }
}
class Tortuga
{
    private string nombre { get; set; }

    private int altura { get; set; }

    private int peso { get; set; }

    private string sexo { get; set; }


    private int edad { get; set; }


    private string especie { get; set; }

    public Tortuga(string nombre, int altura, int peso, string sexo, int edad, string especie)
    {
        this.nombre = nombre;
        this.altura = altura;
        this.peso = peso;
        this.sexo = sexo;
        this.edad = edad;
        this.especie = especie;
    }

    public Tortuga(string nombre, string sexo)
    {
        this.nombre = nombre;
        this.sexo = sexo;
    }



    public void alimentar()
    {
        Console.WriteLine("Come plantas");
    }



    public void ruido()
    {
        Console.WriteLine("ah ah ah ah");
    }



    public override string ToString()
    {
        return "Nombre: " + "\n" + this.nombre + "\n" + "Especie: " + this.especie;
        Console.WriteLine("gracias por su visita");
    }

}

