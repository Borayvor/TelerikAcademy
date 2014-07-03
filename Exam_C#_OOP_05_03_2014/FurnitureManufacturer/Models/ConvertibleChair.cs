namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;
    using System.Text;


    public class ConvertibleChair : Chair, IConvertibleChair, IChair, IFurniture
    {
        private const decimal ConvertedHeight = 0.10m;

        private readonly decimal initialHeight;

        public ConvertibleChair (string model, MaterialType initialMaterial, decimal price, decimal height,
            int numberOfLegs)
            : base (model, initialMaterial, price, height, numberOfLegs)
        {
            this.initialHeight = height;
        }

        public bool IsConverted { get; protected set; }

        public void Convert()
        {
            if (!IsConverted)
            {
                this.Height = ConvertedHeight;                
            }
            else
            {
                this.Height = initialHeight;                
            }
            IsConverted = !IsConverted;
        }

        public override string ToString()
        {
            StringBuilder convertibleChairStringOutput = new StringBuilder ();

            string state = this.IsConverted ? "Converted" : "Normal";

            string stringOutput = string.Format(", State: {0}", state);

            convertibleChairStringOutput.Append (base.ToString ());
            convertibleChairStringOutput.Append (stringOutput);

            return convertibleChairStringOutput.ToString();
        }
    }
}
