using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Counter
    {
        public event EventHandler ThresholdReached;
        protected virtual void OnThresholdReached(EventArgs e)
        {
            EventHandler handler = ThresholdReached;
            if (handler != null)
            {
                handler(this, e);
            }
        }
        private int count = 0;
        public void Inc() => count++;
        public void Dec() => count--;
        
    }
}
