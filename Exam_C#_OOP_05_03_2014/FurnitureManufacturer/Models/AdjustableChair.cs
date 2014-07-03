namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;


    public class AdjustableChair : Chair, IAdjustableChair, IChair, IFurniture
    {
        public AdjustableChair (string model, MaterialType initialMaterial, decimal price, decimal height,
            int numberOfLegs)
            : base (model, initialMaterial, price, height, numberOfLegs)
        {
        }

        public void SetHeight(decimal height)
        {
            this.Height = height;
        }
    }
}
