using System;
using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
    public class VanRange
    {
        private IVehicle[] vans;

        public VanRange()
        {
            vans = new IVehicle[3];

            // Define the range of van models available
            vans[0] = new BoxVan(new StandardEngine(1600));
            vans[1] = new BoxVan(new StandardEngine(200));
            vans[2] = new Pickup(new TurboEngine(2800));
        }

        public virtual IVehicle[] Range
        {
            get
            {
                return vans;
            }
        }

        public virtual IEnumerator<IVehicle> GetEnumerator()
        {
            return ((IEnumerable<IVehicle>)vans).GetEnumerator();
        }
    }
}
