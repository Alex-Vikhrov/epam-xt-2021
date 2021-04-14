using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _3._2._1._DYNAMIC_ARRAY
{
    public class DynamicArray<T> : ICollection<T>
    {
        private  T[] _array;
        private int _length;
        private int _capacity;

        /// <summary>
        /// 1. Конструктор без параметров (создаётся массив ёмкостью 8 элементов).
        /// </summary>
        public DynamicArray()
        {
            _array = new T[8];
        }

        /// <summary>
        /// 2. Конструктор с одним целочисленным параметром (создаётся массив указанной ёмкости).
        /// </summary>
        public DynamicArray(int _capacity)
        {
            _array = new T[_capacity];
        }

        /// <summary>
        /// 3. Конструктор, который в качестве параметра принимает коллекцию, реализующую интерфейс IEnumerable<T>,
        ///    создаёт массив нужного размера и копирует в него все элементы из коллекции.
        /// </summary>
        public DynamicArray(IEnumerable<T> enumerable)
        {
            _array = enumerable.ToArray();
            Capacity = _length * 2;
        }

        /// <summary>
        /// 4. Метод Add, добавляющий в конец массива один элемент. При нехватке места для 
        /// добавления элемента, ёмкость массива должна удваиваться.
        /// </summary>
        public void Add(T item)
        {
           if (_length == Capacity)
            {
                Capacity *= 2;
            }
            _array[_length++] = item;
        }

        /// <summary>
        /// 5. Метод AddRange, добавляющий в конец массива содержимое коллекции, реализующей 
        /// интерфейс IEnumerable<T>.
        /// </summary>
        public void AddRange(IEnumemerable<T> coll)
        {
            int countColl = coll.Count();
            while (Capacity < _length + countColl) Capacity *= 2;
            _length = _length + countColl;
            Array.Copy(coll.ToArrat(), 0, _array, _length, countColl);
        }

        /// <summary>
        /// 6. Метод Remove, удаляющий из коллекции указанный элемент. 
        /// </summary>
        public bool Remove(T item)
        {
            for (int i = 0; i < _length; i++)
            {
                if (_array[i].Equals(item))
                {
                    Remove(i);
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 7. Метод Insert, позволяющий добавить элемент в произвольную позицию массива
        /// </summary>
        public bool Insert()
        {
            return false;
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _length; i++)
            {
                yield return _array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        /// <summary>
        /// 8. Свойство Length — получение количества элементов.
        /// </summary>
        public int Length { get => _length; }

        /// <summary>
        /// 9. Свойство Capacity — получение ёмкости: длины внутреннего массива.
        /// </summary>
        public int Capacity 
        {
            get => _capacity;
            set
            {
                T[] newArray = new T[value];
                if (_length > 0)
                {
                    Array.Copy(_array, 0, newArray, 0, _length);
                }
                _array = newArray;
                _capacity = value;
            }
        }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        #region 10. Методы, реализующие интерфейсы IEnumerable и IEnumerable<T>.
        /// <summary>
        /// 10. Методы, реализующие интерфейсы IEnumerable и IEnumerable<T>.
        /// </summary>
        public interface IEnumemerable
        {

        }

        public interface IEnumerable<out T> : IEnumemerable
        {
            T[] ToArray();
        }
        #endregion
    }
}
