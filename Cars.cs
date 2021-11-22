using System;
using System.Collections.Generic;

namespace multifabriken_MarcusR91
{
    class Car
    {
        private string color;
        private string licensePlate;
        private string brand;

        public Car(string color, string licensePlate, string brand)
        {
            this.color = color;
            this.brand = brand;
            this.licensePlate = licensePlate;
        }

        public string getBrand()
        {
            return this.brand;

        }
         public string getColor()
        {
            return this.color;

        }
         public string getLicense()
        {
            return this.licensePlate;

        }
    }
}