using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_8
{
    public class GenericsClass2<T>
    {
        // define an Array of Generic type with length 5
        T[] obj = new T[5];
        int count = 0;

        // adding items mechanism into generic type
        public void Add(T item)
        {
            //checking length
            if (count + 1 < 6)
            {
                obj[count] = item;

            }
            count++;
        }
        //indexer for foreach statement iteration
        public T this[int index]
        {
            get { return obj[index]; }
            set { obj[index] = value; }
        }
    }
}
