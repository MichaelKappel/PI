using System;
using VariableBase.Mathematics;

namespace MichaelKappel.PI
{
    public class PI
    {
        public Number Get()
        {
            //  (4 / 1) - (4 / 3) 
            //+ (4 / 5) - (4 / 7) 
            //+ (4 / 9) - (4 / 11) 
            //+ (4 / 13) - (4 / 15)
            
            var mathEnvironment = new MathEnvironment("0123456789");

            Int32 denominator = 1;

            Number c1 = mathEnvironment.BottomNumber;

            while (denominator < 10000)
            {

                Number a1 = mathEnvironment.GetNumber("0", "4", denominator.ToString());
                denominator += 2;
                Number b1 = mathEnvironment.GetNumber("0", "4", denominator.ToString());
                c1  += a1 - b1;
                denominator += 2;
            }

            return c1;
        }
    }
}
