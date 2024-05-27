using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.TemplateMethod
{
    class ArmorSmith : GearCreate
    {
        public override void PrepereMaterials()
        {
            Console.WriteLine("Mining steel and gathering leather");
        }

        public override void ForgingMaterials()
        {
            Console.WriteLine("Making plates and leather preparing");
        }

        public override void CombineMaterials()
        {
            Console.WriteLine("Combining and making armor");
        }
    }
}
