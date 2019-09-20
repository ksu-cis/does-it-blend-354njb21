using System;
using System.Collections.Generic;
namespace DoesItBlend
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IBlendables> blendables = new List<IBlendables>();
            blendables.Add(new Strawberry());
            blendables.Add(new Banana());
            blendables.Add(new CellPhone());
            blendables.Add(new IceCubes());
            for (int i =0; i < 10; i++)
            {
                blendables.Add(new Mango());
            }

            Banana b = new Banana();
            Console.WriteLine(b.Blend());
            blendables.Add(b);
            string mess = "";
            foreach( dynamic blendable in blendables)
            {
                mess += blendable.Blend(); 
            }

            
            Console.WriteLine(mess);
        }
    }
}
