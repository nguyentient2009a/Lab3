using System;

namespace Lab3
{
    public class Car
    {
        public string make;
        public string model;
        public string color;
        public int yearBuilt;
// define the methods
        public void Start()
        {
            Console.WriteLine(model + " started");
        }
        public void Stop()
        {
            Console.WriteLine(model + " stopped");
        }

    }
}