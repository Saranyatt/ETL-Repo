using System;
using System.Collections.Generic;

namespace FarmSystem.Test1
{
    public delegate void DelEventHandler();
    internal class Program
    {

        public static event DelEventHandler empty;
        private static void Main(string[] args)
        {
            Excercise1();
            Excercise2();
            Excercise3();
            Excercise4();
            empty += new DelEventHandler(Cow);
            empty += new DelEventHandler(Hen);
            empty += new DelEventHandler(Horse);
            empty += new DelEventHandler(Sheep);
            empty += new DelEventHandler(Emydex);
            empty.Invoke();
            Console.ReadKey();
        }
        static void Cow()
        {
            Console.WriteLine("Cow has left the farm");
        }

        static void Hen()
        {
            Console.WriteLine("Hen has left the farm");
        }

        static void Horse()
        {
            Console.WriteLine("Horse has left the farm");
        }

        static void Sheep()
        {
            Console.WriteLine("Sheep has left the farm");
        }
        static void Emydex()
        {
            Console.WriteLine("Emydex farm is now empty");
            Console.ReadKey();
        }

        /************************************************************************************************************
        Exercise 1 : Apply OOP concepts (abstraction and encapsulation) to the classes 
        modify the code to get the output below
        Cow has entered the farm
        Hen has entered the farm
        Horse has entered the farm
        Sheep has entered the farm
        ***************************************************************************************************************/
        private static void Excercise1()
        {
            Console.WriteLine("Exercise 1 : Press any key when it is time to open the Farm to animals");
            Console.ReadKey();
            var farm = new EmydexFarmSystem();
            Cow cow = new Cow();
            cow.Id = Guid.NewGuid().ToString();
            cow.NoOfLegs = 4;
            cow.Name = "Cow";
            farm.Enter(cow);

            Hen hen = new Hen();
            hen.Id = Guid.NewGuid().ToString();
            hen.NoOfLegs = 4;
            hen.Name = "Hen";
            farm.Enter(hen);

            Horse horse = new Horse();
            horse.Id = Guid.NewGuid().ToString();
            horse.NoOfLegs = 4;
            horse.Name = "Horse";
            farm.Enter(horse);

            Sheep sheep = new Sheep();
            sheep.Id = Guid.NewGuid().ToString();
            sheep.NoOfLegs = 4;
            sheep.Name = "Sheep";
            farm.Enter(sheep);
            Console.ReadKey();
        }

        /***************************************************************************************************************
         Test Excercise 2
         If you have completed the first test excercise, you can continue with the second one
         Modify the program and EmydexFarmSystem.MakeNoise() method to get the below output
         Expected Test 2 Program Output

         Exercise 2 : Press any key to scare the animals in the farm
            Cow has entered the farm
            Hen has entered the farm
            Horse has entered the farm
            Sheep has entered the farm
            Cow says Moo!
            Hen says CLUCKAAAAAWWWWK!
            Horse says Neigh!
            Sheep says baa!
         *****************************************************************************************************************/
        private static void Excercise2()
        {
            //TODO : Apply OOP concepts and modify the code below to get the required output 
            Console.WriteLine("Exercise 2 : Press any key to scare the animals in the farm");
            Console.ReadKey();
            var farm = new EmydexFarmSystem();
            Cow cow = new Cow();
            cow.Id = Guid.NewGuid().ToString();
            cow.NoOfLegs = 4;
            cow.Name = "Cow";
            farm.Enter(cow);

            Hen hen = new Hen();
            hen.Id = Guid.NewGuid().ToString();
            hen.NoOfLegs = 4;
            hen.Name = "Hen";
            farm.Enter(hen);

            Horse horse = new Horse();
            horse.Id = Guid.NewGuid().ToString();
            horse.NoOfLegs = 4;
            horse.Name = "Horse";
            farm.Enter(horse);

            Sheep sheep = new Sheep();
            sheep.Id = Guid.NewGuid().ToString();
            sheep.NoOfLegs = 4;
            sheep.Name = "Sheep";
            farm.Enter(sheep);

            farm.MakeNoise();
            Console.ReadKey();
        }

        /*****************************************************************************************************************
        Test Excercise 3
        If you have completed the previous test excercise, you can continue with this one 
        The project includes an interface IMilkableAnimal. Make use of this interface to implement on the relevant classes
        so that calling the EmydexFarmSystem.MilkAnimals() method to get the below output

        Expected Test 3 Program Output

        Exercise 3 : Press any key when it is time to milk animals
        Cow has entered the farm
        Hen has entered the farm
        Horse has entered the farm
        Sheep has entered the farm
        Cow was milked!
        ************************************************************************************************************/
        private static void Excercise3()
        {
            //TODO : Apply OOP concepts and modify the code below to get the required output 
            Console.WriteLine("Exercise 3 : Press any key when it is time to milk animals");
            Console.ReadKey();
            var farm = new EmydexFarmSystem();
            Cow cow = new Cow();
            cow.Id = Guid.NewGuid().ToString();
            cow.NoOfLegs = 4;
            cow.Name = "Cow";
            farm.Enter(cow);

            Hen hen = new Hen();
            hen.Id = Guid.NewGuid().ToString();
            hen.NoOfLegs = 4;
            hen.Name = "Hen";
            farm.Enter(hen);

            Horse horse = new Horse();
            horse.Id = Guid.NewGuid().ToString();
            horse.NoOfLegs = 4;
            horse.Name = "Horse";
            farm.Enter(horse);

            Sheep sheep = new Sheep();
            sheep.Id = Guid.NewGuid().ToString();
            sheep.NoOfLegs = 4;
            sheep.Name = "Sheep";
            farm.Enter(sheep);

            farm.MilkAnimals();
            Console.ReadKey();
        }

        /****************************************************************************************************
        Test Excercise 4
        Modify the EmydexFarmSystem.ReleaseAllAnimals() so that all animals are released (simply clear the collection )
        Expose an event on the FarmSystem FarmEmpty which is invoked once all the animals are released
        Subscribe to that event in the main to get the expected output

        Expected Test 4 Program Output

        Exercise 4: Press any key to free all animals
        Cow has entered the farm
        Hen has entered the farm
        Horse has entered the farm
        Sheep has entered the farm
        Cow has left the farm
        Hen has left the farm
        Horse has left the farm
        Sheep has left the farm
        Emydex Farm is now empty
        ********************************************************************************************************************/
        private static void Excercise4()
        {
            //TODO : Apply OOP concepts and modify the code below to get the required output 
            Console.WriteLine("Exercise 4: Press any key to free all animals");
            Console.ReadKey();
            var farm = new EmydexFarmSystem();
            Cow cow = new Cow();
            cow.Id = Guid.NewGuid().ToString();
            cow.NoOfLegs = 4;
            cow.Name = "Cow";
            farm.Enter(cow);

            Hen hen = new Hen();
            hen.Id = Guid.NewGuid().ToString();
            hen.NoOfLegs = 4;
            hen.Name = "Hen";
            farm.Enter(hen);

            Horse horse = new Horse();
            horse.Id = Guid.NewGuid().ToString();
            horse.NoOfLegs = 4;
            horse.Name = "Horse";
            farm.Enter(horse);

            Sheep sheep = new Sheep();
            sheep.Id = Guid.NewGuid().ToString();
            sheep.NoOfLegs = 4;
            sheep.Name = "Sheep";
            farm.Enter(sheep);

            Animal animal1 = new Animal { Id = cow.Id };
            Animal animal2 = new Animal { Id = hen.Id };
            Animal animal3 = new Animal { Id = horse.Id };
            Animal animal4 = new Animal { Id = sheep.Id };

            List<Animal> listOfAnimals = new List<Animal>();
            listOfAnimals.Add(animal1);
            listOfAnimals.Add(animal2);
            listOfAnimals.Add(animal3);
            listOfAnimals.Add(animal4);
            farm.ReleaseAllAnimals(listOfAnimals);

        }

    }
}