using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSystem
{
    class ParticleSystemMain
    {
        // Create a ChaoticParticle class, which is a Particle, randomly changing its movement (Speed). You are 
        // not allowed to edit any existing class.
        // Test the ChaoticParticle through the ParticleSystemMain class
        // Create a ChickenParticle class. The ChickenParticle class moves like a ChaoticParticle, but randomly 
        // stops at different positions for several simulation ticks and, for each of those stops, creates (lays) 
        // a new ChickenParticle. You are not allowed to edit any existing class.
        // Test the ChickenParticle class through the ParcticleSystemMain class.
        // Implement a ParticleRepeller class. A ParticleRepeller is a Particle, which pushes other particles away 
        // from it (i.e. accelerates them in a direction, opposite of the direction in which the repeller is). 
        // The repeller has an effect only on particles within a certain radius (see Euclidean distance)
        // Test the ParticleRepeller class through the ParticleSystemMain class


        static Random randomGenerator = new Random ();

        const int rows = 28;
        const int cols = 90;    

        static void Main()
        {    
            var renderer = new ConsoleRenderer (rows, cols);

            var particleOperator = new RepellerParticleUpdater ();

            var engine = new Engine (renderer, particleOperator, null, 100);

            GenerateOriginData (engine);

            engine.Run ();
        }



        private static void GenerateOriginData (Engine engine)
        {
            var chickenPos = new MatrixCoords (10, 40);
            var chickenSpeed = new MatrixCoords (0, 0);
            var chicken = new ChickenParticle (chickenPos, chickenSpeed,
                randomGenerator);

            engine.AddParticle (chicken);

            var repellerPos = new MatrixCoords (15, 40);
            var repellerSpeed = new MatrixCoords (0, 0);
            var repeller = new RepellerParticle (repellerPos, repellerSpeed, 6);

            engine.AddParticle (repeller);
        }


        
        
    }
}
