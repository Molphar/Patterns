using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.TemplateMethod
{
    abstract class GearCreate
    {
        public virtual void ForgeGear()
        {
            PrepereMaterials();
            ForgingMaterials();
            CombineMaterials();
        }

        public abstract void PrepereMaterials();
        public abstract void ForgingMaterials();
        public abstract void CombineMaterials();
    }
}
