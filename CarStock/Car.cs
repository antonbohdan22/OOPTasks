using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStock
{
    class Car
    {
        private string manufacturer;
        private string model;
        private string color;
        private int releaseYear;
        private int price;

        public Car() { }

        public Car(string manufacturer, string model, string color, int releaseYear, int price)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.color = color;
            this.releaseYear = releaseYear;
            this.price = price;
        }

        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }
        
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        
        public int ReleaseYear
        {
            get { return releaseYear; }
            set { releaseYear = value; }
        }
        
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
