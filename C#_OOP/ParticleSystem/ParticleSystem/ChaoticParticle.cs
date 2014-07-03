namespace ParticleSystem
{
    using System;


    public class ChaoticParticle : Particle
    {
        public ChaoticParticle (MatrixCoords position, MatrixCoords speed, Random randomGenerator)
             : base (position, speed)
        {
            this.RandomGenerator = randomGenerator;
        }

        public Random RandomGenerator { get; protected set; }

        protected override void Move ()
        {
            this.Speed = new MatrixCoords (this.RandomGenerator.Next (-2, 3), this.RandomGenerator.Next (-2, 3));
            this.Position += this.Speed;
        }
    }
}
