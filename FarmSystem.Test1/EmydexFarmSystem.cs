using System;
using System.Collections.Generic;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {
        //TEST 1
        public void Enter(object animal)
        {
            //TODO Modify the code so that we can display the type of animal (cow, sheep etc) 
            //Hold all the animals so it is available for future activities
            string name = (string)animal.GetType().GetProperty("Name").GetValue(animal);
            Console.WriteLine(name + " has entered the Emydex farm");
        }

        //TEST 2
        public void MakeNoise()
        {
            //Test 2 : Modify this method to make the animals talk
            Cow cow = new Cow();
            cow.Talk();

            Hen hen = new Hen();
            hen.Talk();

            Horse horse = new Horse();
            horse.Talk();

            Sheep sheep = new Sheep();
            sheep.Talk();
        }

        //TEST 3
        public void MilkAnimals()
        {
            Cow cow = new Cow();
            cow.ProduceMilk();
        }

        //TEST 4
        public void ReleaseAllAnimals(List<Animal> animals)
        {
            animals.Clear();
        }
    }
}