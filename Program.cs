using System;

class Animal
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al zoológico virtual!");

        
        Leon leon = new Leon("Domador", "macho");
        Elefante elefante = new Elefante("Orejon", "macho");
        Jirafa jirafa = new Jirafa("macaqui", "macho");
        Tigre tigre = new   Tigre("sexy", "macho");
        Mono mono = new Mono("colon", "macho");
        Oso oso = new Oso("madriguero", "macho");
        Cocodrilo cocodrilo = new Cocodrilo("Raptor", "macho");
        Serpiente serpiente = new Serpiente("ANlR", "macho");
        Pinguino pinguino = new Pinguino("jack", "macho");
        Lobo lobo = new Lobo("fiel", "macho");
        Cebra cebra = new Cebra("rayas", "macho");
        Rinoceronte rinoceronte = new Rinoceronte("puf", "macho");
        Panda panda= new  Panda("sina", "macho");
        PavoReal pavo = new Elefante("asombroso", "macho");
        Tortuga tortuga = new Tortuga("jinebra", "macho");

        


        Console.WriteLine("Selecciona un animal para visitar:");
        Console.WriteLine("1. León");
        Console.WriteLine("2. Elefante");
        Console.WriteLine("2. Jirafa");
        Console.WriteLine("4. Tigre");
        Console.WriteLine("5. Mono");
        Console.WriteLine("6. Oso");
        Console.WriteLine("7. Cocodrilo");
        Console.WriteLine("8. Serpiente");
        Console.WriteLine("9. Pinguino");
        Console.WriteLine("10. Lobo");
        Console.WriteLine("11. Cebra");
        Console.WriteLine("12. Rinoceronte");
        Console.WriteLine("13. Panda");
        Console.WriteLine("14. Pavo Real");
        Console.WriteLine("15. Tortuga");




        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                InteractuarConAnimal(leon);
                break;
            case 2:
                InteractuarConAnimal(elefante);
                break;
            case 3:
                InteractuarConAnimal(jirafa);
                break;
            case 4:
                InteractuarConAnimal(tigre);
                break;
            case 5:
                InteractuarConAnimal(mono);
                break;
            case 6:
                InteractuarConAnimal(oso);
                break;
            case 7:
                InteractuarConAnimal(cocodrilo);
                break;
            case 8:
                InteractuarConAnimal(serpiente);
                break;
            case 9:
                InteractuarConAnimal(pinguino);
                break;
            case 10:
                InteractuarConAnimal(lobo);
                break;
            case 11:
                InteractuarConAnimal(cebra);
                break;
            case 12:
                InteractuarConAnimal(rinoceronte);
                break;
            case 13:
                InteractuarConAnimal(panda);
                break;
            case 14:
                InteractuarConAnimal(pavo);
                break;
            case 15:
                InteractuarConAnimal(tortuga);
                break;
            








            default:
                Console.WriteLine("Opción inválida");
                break;
        }

        Console.WriteLine("Gracias por tu visita al zoológico!");
    }

    static void InteractuarConAnimal(Animal animal)
    {
        Console.WriteLine($"Has seleccionado al {animal.ToString()}");

        Console.WriteLine("¿Qué acción deseas realizar?");
        Console.WriteLine("1. Alimentar al animal");
        Console.WriteLine("2. Escuchar el sonido del animal");

        int accion = int.Parse(Console.ReadLine());

        switch (accion)
        {
            case 1:
                animal.alimentar();
                break;
            case 2:
                animal.ruido();
                break;
            default:
                Console.WriteLine("Opción inválida");
                break;
        }
    }
}
