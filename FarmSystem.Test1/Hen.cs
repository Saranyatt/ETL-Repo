using System;

namespace FarmSystem.Test1
{
    public class Hen : IAnimalName
    {
        private string _id;
        private int _noOfLegs = 4;
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
            Console.WriteLine("Hen say CLUCKAAAAAWWWWK!");
        }

        public void Run()
        {
            Console.WriteLine("Hen is running");
        }
    }
}