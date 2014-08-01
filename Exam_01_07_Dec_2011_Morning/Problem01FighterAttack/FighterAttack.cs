namespace Problem01FighterAttack
{
    using System;

    public class FighterAttack
    {
        public static void Main(string[] args)
        {
            int px1, py1, px2, py2;
            int fx, fy;
            int d;
            int hitX, hitY;
            int dmg = 0;

            px1 = NewData();
            py1 = NewData();
            px2 = NewData();
            py2 = NewData();

            fx = NewData();
            fy = NewData();

            d = NewData();

            int rectangleLeft = 0;
            int rectangleRight = 0;
            int rectangleTop = 0;
            int rectangleBottom = 0;
            
            if(px1 > px2)
            {
                rectangleRight = px1;
                rectangleLeft = px2;
            }
            else
            {
                rectangleRight = px2;
                rectangleLeft = px1;
            }
            if(py1 > py2)
            {
                rectangleTop = py1;
                rectangleBottom = py2;
            }
            else
            {
                rectangleTop = py2;
                rectangleBottom = py1;
            }

            hitX = fx + d;
            hitY = fy;

            if(hitX >= rectangleLeft && hitX <= rectangleRight)
            {
                if(hitY <= rectangleTop && hitY >= rectangleBottom)
                {
                    dmg += 100;

                    if(hitX < rectangleRight)
                    {
                        dmg += 75;
                    }

                    if(hitY < rectangleTop)
                    {
                        dmg += 50;
                    }

                    if(hitY > rectangleBottom)
                    {
                        dmg += 50;
                    }
                }
                else if(hitY == (rectangleTop + 1) || hitY == (rectangleBottom - 1))
                {
                    dmg += 50;
                }
            }
            else if(hitX == (rectangleLeft - 1) && hitY <= rectangleTop && hitY >= rectangleBottom)
            {
                dmg += 75;
            }    

            Console.WriteLine(dmg + "%");
        }

        private static int NewData()
        {
            int d = 0;

            d = int.Parse(Console.ReadLine());

            return d;
        }

                        
    }
}
