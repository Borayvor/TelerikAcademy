namespace FurnitureManufacturer.Models
{
    using System;
    using FurnitureManufacturer.Interfaces;


    public abstract class Furniture : IFurniture
    {
        private string privateModel;
        private string privateMaterial;        
        private decimal privatePrice;
        private decimal privateHeight;

        protected Furniture (string initialModel, MaterialType initialMaterial, decimal initialPrice, decimal initialHeight)
        {
            this.Model = initialModel;
            this.Material = initialMaterial.ToString();
            this.Price = initialPrice;
            this.Height = initialHeight;
        }

        public string Model
        {
            get 
            {
                return this.privateModel;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    throw new ArgumentException("Model cannot be empty, null or with less than 3 symbols !");
                }
                this.privateModel = value;
            }
        }

        public string Material 
        {
            get
            {
                return this.privateMaterial;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Material cannot be empty or null !");
                }

                this.privateMaterial = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.privatePrice;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be less or equal to $0.00 !");
                }
                this.privatePrice = value;
            }
        }

        public decimal Height
        {
            get 
            { 
                return this.privateHeight; 
            }

            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Height cannot be less or equal to 0.00 m !");
                }
                this.privateHeight = value;
            }
        }

        public override string ToString()
        {
            string stringOutput = string.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, " + 
                "Height: {4}", this.GetType().Name, this.Model, this.Material, this.Price, this.Height);

            return stringOutput;
        }
    }
}
