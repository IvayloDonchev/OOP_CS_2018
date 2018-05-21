using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect_14
{
    public class SampleCollection<T> :IEnumerable<T>
    {
        private T[] buffer = new T[100];
        public T this[int i]    //indexer
        {
            get => buffer[i];
            set => buffer[i] = value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < 100; i++)
                yield return buffer[i];
            //return ((IEnumerable<T>)buffer).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < 100; i++)
                yield return buffer[i];
           // return ((IEnumerable<T>)buffer).GetEnumerator();
        }
    }
}
