namespace ParticleSystem
{
    using System;
    using System.Collections.Generic;


    public class RepellerParticleUpdater : ParticleUpdater
    {
        List<RepellerParticle> repellers = new List<RepellerParticle> ();
        List<Particle> particles = new List<Particle> ();


        public override IEnumerable<Particle> OperateOn (Particle part)
        {
            var repellerCandidate = part as RepellerParticle;

            if (repellerCandidate == null)
            {
                this.particles.Add (part);
            }
            else
            {
                this.repellers.Add (repellerCandidate);
            }

            return base.OperateOn (part);
        }

        public override void TickEnded ()
        {
            foreach (var repeller in this.repellers)
            {
                foreach (var particle in this.particles)
                {
                    if (IsParticleInRepellerArea (particle, repeller))
                    {                           
                        particle.Accelerate (InvertSpeed (particle));                        
                    }
                    
                }
            }

            this.repellers.Clear ();
            this.particles.Clear ();
            base.TickEnded ();
        }

        private bool IsParticleInRepellerArea (Particle particle, RepellerParticle repeller)
        {
            var distance = (Math.Sqrt (Math.Pow ((repeller.Position.Row - particle.Position.Row), 2) +
                (Math.Pow ((repeller.Position.Col - particle.Position.Col), 2))));

            if (distance <= repeller.RepelAreaRadius)
            {
                Console.Write ("\r{0}", distance);
                return true;
            }

            return false;
        }

        private MatrixCoords InvertSpeed (Particle particle)
        {
            int singRow = -2;
            int singCol = -2;

                        
            int reverseRow = particle.Speed.Row * singRow;
            int reverseCol = particle.Speed.Col * singCol;

            return new MatrixCoords (reverseRow, reverseCol);
        }


       
    }
}
