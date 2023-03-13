using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3SemOblOpgave1
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int? Price { get; set; }
        public string LicensePlate { get; set; }

        public Car(int id, string model, int? price, string licensePlate)
        {
            Id = id;
            Model = model;
            Price = price;
            LicensePlate = licensePlate;
        }

        public Car(){ }

        public void Validate()
        {
            if (Model == null || Price == null || LicensePlate == null) throw new ArgumentNullException("Property returned null");
            if (Model.Length < 4)
            {
                throw new ArgumentException("Model must be at least 4 characters long");
            }
            if (Price <= 0)
            {
                throw new ArgumentException("Price must be greater than 0");
            }
            if (LicensePlate.Length < 2 || LicensePlate.Length > 7)
            {
                throw new ArgumentException("License plate must be between 2 and 7 characters long");
            }
        }

        public override string ToString()
        {
            return $"{Id}. {Model}, {Price} kr, {LicensePlate}";
        }
    }
}
