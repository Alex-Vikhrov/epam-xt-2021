using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _3._2._1._DYNAMIC_ARRAY
{
    class MyEnumeratorDynamicArray<T> : IEnumerator<T>
    {
        public T Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {
            //TODO
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
