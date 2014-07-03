using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContrFlowConditStatemLoop
{
    class Program
    {
        static void Main (string[] args)
        {
            // Refactor the following if statements: 
            Vegetable potato = new Vegetable ("potato");
            //... 
            int x = 0;
            int MIN_X = int.MinValue;
            int MAX_X = int.MaxValue;

            int y = 0;
            int MIN_Y = int.MinValue;
            int MAX_Y = int.MaxValue;

            if (potato != null)
            {
                if (!(potato.isPeeled || potato.IsRotten))
                {
                    Cook (potato);
                }
            }

            bool inRange = ((x >= MIN_X && x <= MAX_X) && (y >= MIN_Y && y <= MAX_Y));
            bool shouldVisitCell = true;

            if (inRange && shouldVisitCell)
            {
                VisitCell ();
            }


            // Refactor the following loop: 
            const int expectedValue = 666;

            int[] array = new int[100];

            for (int index = 0; index < array.Length; index++)
            {
                if (index % 10 == 0)
                {
                    Console.WriteLine (array[index]);

                    if (array[index] == expectedValue)
                    {
                        Console.WriteLine ("Value Found");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine (array[index]);
                }
            }
            // More code here


        }

        private static void VisitCell ()
        {
            throw new NotImplementedException ();
        }

        private static void Cook (Vegetable potato)
        {
            throw new NotImplementedException ();
        }        
    }
}

// Refactor the following class
public class Chef
{

    public void Cook ()
    {
        Vegetable potato = GetPotato ();
        Vegetable carrot = GetCarrot ();
        KitchenUtensil bowl;
        bowl = GetBowl ();

        Peel (potato);
        Peel (carrot);

        Cut (potato);
        Cut (carrot);

        bowl.Add (carrot);
        bowl.Add (potato);
    }

    private Vegetable GetPotato ()
    {
        return new Vegetable ("potato");
    }

    private Vegetable GetCarrot ()
    {
        return new Vegetable ("carrot");
    }

    private KitchenUtensil GetBowl ()
    {
        return new KitchenUtensil ("bowl");
    }

    private void Peel (Vegetable vegetableObject)
    {
        Console.WriteLine ("Peel {0}.", vegetableObject);
    }

    private void Cut (Vegetable vegetableObject)
    {
        Console.WriteLine ("Cut {0}.", vegetableObject);
    }
}

public class Vegetable
{
    private string name;
    public bool isPeeled = false;
    public bool IsRotten = false;

    public Vegetable (string name)
    {
        this.name = name;
    }
}


public class KitchenUtensil : List<Vegetable>
{
    private string name;

    public KitchenUtensil (string name)
    {
        this.name = name;
    }
}
