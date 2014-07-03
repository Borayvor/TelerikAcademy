namespace ParticleSystem
{
    using System;


    public class RepellerParticle : Particle
    {        
        public RepellerParticle (MatrixCoords position, MatrixCoords speed, uint repelAreaRadius)
            : base (position, speed)
        {
            this.RepelAreaRadius = repelAreaRadius;
        }
        

        public uint RepelAreaRadius { get; private set; }


        public override char[,] GetImage ()
        {
            return new char[,] { { (char)3 } };
        }
    }
}
