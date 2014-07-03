namespace FurnitureManufacturer.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using FurnitureManufacturer.Interfaces;
    using System.Text;      


    public class Company : ICompany
    {
        private string privateName;
        private string privateRegistrationNumber;
        private bool isNumber;
        private ulong tempRegistrationNumber;

        private ICollection<IFurniture> initialFurnitures;

        public Company(string initialName, string initialRegistrationNumber)
        {
            this.Name = initialName;
            this.RegistrationNumber = initialRegistrationNumber;
            this.initialFurnitures = new List<IFurniture> ();
        }

        public string Name
        {
            get
            {
                return this.privateName;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new ArgumentException("Model cannot be empty, null or with less than 5 symbols !");
                }
                
                this.privateName = value;
            }
        }

        public string RegistrationNumber
        {
            get
            {
                return this.privateRegistrationNumber;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Registration Number cannot be empty or null !");
                }                                
                else if (value.Length != 10)
                {
                    throw new ArgumentException("The length of Registration Number must be 10 symbols !");
                }

                isNumber = ulong.TryParse(value, out tempRegistrationNumber);

                if (isNumber)
                {
                    this.privateRegistrationNumber = value;
                }
                else
                {
                    throw new ArgumentException("Registration Number must contain only digits !");
                }
            }
        }

        public ICollection<IFurniture> Furnitures
        {
            get { return new List<IFurniture> (this.initialFurnitures); }
        }

        public void Add(IFurniture furniture)
        {
            this.initialFurnitures.Add (furniture);  
        }

        public void Remove(IFurniture furniture)
        {
            if (this.initialFurnitures.Contains (furniture))
            {
                this.initialFurnitures.Remove (furniture);
            }
        }

        public IFurniture Find(string model)
        {
            foreach (var furniture in this.initialFurnitures)
            {
                if (furniture.Model.ToLower() == model.ToLower())
                {
                    return furniture;                   
                }               
            }
            return null;
        }

        public string Catalog()
        {
            StringBuilder catalog = new StringBuilder();

            string numberOfFurniture;
            string furnitureWord;            

            numberOfFurniture = this.initialFurnitures.Count != 0 ? this.initialFurnitures.Count.ToString () : "no";

            furnitureWord = this.initialFurnitures.Count != 1 ? "furnitures" : "furniture";

            var orderedFurnitures = this.initialFurnitures.OrderBy (x => x.Price).ThenBy (x => x.Model);
           
            string companyInfo = string.Format("{0} - {1} - {2} {3}", this.Name, this.RegistrationNumber,
                numberOfFurniture, furnitureWord);

            catalog.Append (companyInfo);

            if (this.initialFurnitures.Count != 0)
            {
                catalog.AppendLine ();

                foreach (var furniture in orderedFurnitures)
                {
                    catalog.AppendLine (furniture.ToString ());
                }                
            }
            
            return catalog.ToString().TrimEnd();
        }
    }
}
