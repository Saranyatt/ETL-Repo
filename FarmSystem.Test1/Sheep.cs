using System;

namespace FarmSystem.Test1
{
    public class Sheep : IAnimalName
    {

        private string _id;
        private int _noOfLegs;
        private string name;

        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }


        public int NoOfLegs
        {
            get
            {
                return _noOfLegs;
            }
            set
            {
                _noOfLegs = 4;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }


        public void Talk()
        {
            Console.WriteLine("Sheep says baa!");
        }

        public void Run()
        {
            Console.WriteLine("Sheep is running");
        }
    }

}