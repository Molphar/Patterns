using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.TemplateMethod
{
    class WeaponSmith : GearCreate
    {
        public override void PrepereMaterials()
        {
            Console.WriteLine("Mining steel and choping the wood");
        }

        public override void ForgingMaterials()
        {
            Console.WriteLine("Sharping iron and making handle");
        }

        public override void CombineMaterials()
        {
            Console.WriteLine("Making the blade");
        }
    }
}
