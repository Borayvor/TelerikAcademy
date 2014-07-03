namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;
    using System.Text;


    public class Table : Furniture, ITable, IFurniture
    {
        public Table (string model, MaterialType initialMaterial, decimal price, decimal height, 
            decimal initalLength, decimal initialWidth)
            : base (model, initialMaterial, price, height)
        {
            this.Length = initalLength;
            this.Width = initialWidth;
        }

        public decimal Length { get; private set; }

        public decimal Width { get; private set; }

        public decimal Area
        {
            get 
            { 
                return (this.Length * this.Width); 
            }
        }

        public override string ToString()
        {
            StringBuilder tableStringOutput = new StringBuilder ();

            string stringOutput = string.Format(", Length: {0}, Width: {1}, Area: {2}",
                this.Length, this.Width, this.Area);

            tableStringOutput.Append (base.ToString ());
            tableStringOutput.Append (stringOutput);

            return tableStringOutput.ToString();
        }
    }
}
