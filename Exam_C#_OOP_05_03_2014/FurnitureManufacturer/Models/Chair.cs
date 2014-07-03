namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;
    using System.Text;


    public class Chair : Furniture, IChair, IFurniture
    {
        public Chair (string model, MaterialType initialMaterial, decimal price, decimal height,
            int initialNumberOfLegs)
            : base (model, initialMaterial, price, height)
        {
            this.NumberOfLegs = initialNumberOfLegs;
        }

        public int NumberOfLegs { get; private set; }

        public override string ToString()
        {
            StringBuilder chairStringOutput = new StringBuilder ();

            string stringOutput = string.Format(", Legs: {0}", this.NumberOfLegs);

            chairStringOutput.Append (base.ToString ());
            chairStringOutput.Append (stringOutput);

            return chairStringOutput.ToString();
        }
    }
}
