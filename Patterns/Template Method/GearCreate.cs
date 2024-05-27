using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Template_Method
{
    abstract class GearCreate
    {
        public virtual void ForgeGear()
        {
            PrepereMaterial();
            ForgingMaterial();
            CreateGear();
        }

        public abstract void PrepereMaterial();
        public abstract void ForgingMaterial();
        public abstract void CreateGear();
    }
}
