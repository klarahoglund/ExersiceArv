
namespace ExersiceArv;
internal class Program
{

   
    static void Main(string[] args)
    {

        string input;
        List<Animal> animals = new List<Animal>();
        List<Dog> dogs = new List<Dog>();


        //Skapar nya objekt
        var bird = new Bird("Pip", 0.4, 1, true);
        var dog = new Dog("Conrad", 7.5, 3, false);
        var flamingo = new Flamingo("Pink", 7, 34, true, 1.2);
        var hedgehog = new Hedgehog("Ludde", 3, 5, 543);
        var horse = new Horse("Ponny", 76, 1, true);
        var pelican = new Pelican("Pippi", 19, 1, true, 5);
        var swan = new Swan("Svans", 2, 1, true, 5);
        var wolf = new Wolf("Ulf", 45, 1, 300);
        var wolfman = new Wolfman("Adam", 79, 12, 35);



        //Lägger till en del objekt till animals-listan
        animals.Add(dog);
        animals.Add(horse);
        animals.Add(flamingo);
        animals.Add(wolf);
        animals.Add(wolfman);

        //Lägger till en hund till dogs-listan
        dogs.Add(dog);

        //Menyval
        do
        {
            ShowMenu();
            Console.Write("Ditt val: ");
            input = Console.ReadLine();
            Console.WriteLine(" ");

            switch (input)
            {
                case "0": //Avsluta
                    Console.WriteLine("Tack och adjö");
                    Environment.Exit(0);
                    break;

                case "1"://Skriv ut alla djur
                    foreach (var Animal in animals)
                    {
                        Animal.PrintAnimal();

                    }
                    break;
                case "2": // Hur låter djuren?
                    foreach (var Animal in animals)
                        if (Animal is IPerson)
                        {
                            IPerson wpers = (IPerson)Animal;
                            wpers.Talk();
                        }
                        else
                        {
                            Animal.DoSound();
                        }
                    break;
                case "3": //Skriv ut Stats
                    foreach (var Animal in animals)
                    {
                        
                        Console.WriteLine("Stats: " + Animal.Stats());
                    }
                    break;
                case "4":
                    {
                        foreach (var Animal in animals)
                            if (Animal is Dog)
                            {
                                Console.WriteLine("Stats: " + Animal.Stats());

                            }
                    }
                    break;
                case "5":
                    foreach (var Animal in animals)
                    {
                        if (Animal is Dog)
                        {
                            var x = (Dog)Animal;
                            Console.WriteLine(x.WiggleTail());
                        }
                    }

                    break;


            }
        } while (input != "0");
      

    }

    private static void ShowMenu()
    {
        Console.WriteLine("*   0. Avsluta                                *");
        Console.WriteLine("*   1. Skriv ut listan animals 3.4.5          *");
        Console.WriteLine("*   2. Hur låter djuren?                      *");
        Console.WriteLine("*   3. Skriv ut Stats                         *");
        Console.WriteLine("*   4. Skriv ut Stats för hundar              *");
        Console.WriteLine("*   5. Vifta på svansen                       *");
    }





    //Frågor på 3.3
    //F:Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt
    //attribut, i vilken klass bör vi lägga det? - VI bör lägga den i Bird

    //F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
    //- Då behöver det läggas i Animal.

    // dogs.Add(horse);
    //F: Försök att lägga till en häst i listan av hundar. Varför fungerar inte det?

    //-För att när listan är specificerad att hålla typen dogs kan inte typen horse läggas till för de är för specifiserade.
    // F: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans?
    //Listan måste hålla typen Animal för att alla typer ska kunna lagrs då det är basen som alla är knutna till.
    //13. F: Förklara vad det är som händer 
    //- det som händer är att foreach-loopen hämtar varje Animal och sedan tar den mest specifiserade av 
    //Stats-metoderna och skriver ut den
    //16->17: Det går inte att använda Dog som en typ dog med det som är knutet till den klassen utan bara de egenskaper
    //och funktioner som är kopplat till klassen animal som den hanteras som här. För att kunna komma åt allt i 
    //Dog behöver vi type-casta till(baka) Dog.


}

