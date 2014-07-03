namespace ParticleSystem
{
    using System;
    using System.Collections.Generic;    


    public class ChickenParticle : ChaoticParticle
    {
        private const int defaultLayTime = 5;
               
        private uint timeToLays = 0;
        private bool lays;       
        

        public ChickenParticle (MatrixCoords position, MatrixCoords speed, Random randomGenerator)
            : base (position, speed, randomGenerator)
        {                        
            this.lays = false;
        }
   

        public override char[,] GetImage ()
        {
            return new char[,] { { (char)2 } };
        }

        public override IEnumerable<Particle> Update ()
        {
            if (this.lays == true)
            {
                this.timeToLays++;
                if (timeToLays == defaultLayTime)
                {
                    this.timeToLays = 0;
                    lays = false;
                    return this.CloneChicken ();
                }
                return new List<Particle> ();
            }

            if (this.RandomGenerator.Next (9) == 0)
            {
                this.lays = true;
            }

            return base.Update ();
        }

        public IEnumerable<Particle> CloneChicken ()
        {
            return new List<Particle> () { new ChickenParticle (this.Position, this.Speed, this.RandomGenerator) };
        }

        
    }
}
