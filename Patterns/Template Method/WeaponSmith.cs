using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Template_Method
{
    class WeaponSmith : GearCreate
    {
        public override void CreateGear()
        {
            throw new NotImplementedException();
        }

        public override void ForgingMaterial()
        {
            throw new NotImplementedException();
        }

        public override void PrepereMaterial()
        {
            throw new NotImplementedException();
        }
    }
}
