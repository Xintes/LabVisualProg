
namespace Lab5VisualProg
{
    using System;
    using System.Collections;
    using System.Collections.Generic;


    public class DynamicArray<T> : IEnumerable<T>
    {
        private T[] array;
        private int count;

        public int Count => count;
        public int Capacity => array.Length;

        public DynamicArray()
        {
            array = new T[20];
        }

        public DynamicArray(int capacity)
        {
            array = new T[capacity];
        }

        public void Add(T element)
        {
            if (count == array.Length)
                IncreaseCapacity(1);

            array[count] = element;
            count++;
        }

        public void Add(IEnumerable<T> elements)
        {
            int elementsCount = CountElements(elements);

            if (count + elementsCount > array.Length)
                IncreaseCapacity(elementsCount);

            foreach (var element in elements)
            {
                array[count] = element;
                count++;
            }
        }

        public void Insert(T element, int position)
        {
            if (position < 0 || position > count)
                throw new ArgumentOutOfRangeException(nameof(position));

            if (count == array.Length)
                IncreaseCapacity(1);

            for (int i = count; i > position; i--)
                array[i] = array[i - 1];

            array[position] = element;
            count++;
        }

        public void RemoveAt(int position)
        {
            if (position < 0 || position >= count)
                throw new ArgumentOutOfRangeException(nameof(position));

            for (int i = position; i < count - 1; i++)
                array[i] = array[i + 1];
            count--;
        }

        public void IncreaseCapacity(int n)
        {
            int newCapacity = array.Length + n;
            T[] newArray = new T[newCapacity];
            for (int i = 0; i < count; i++)
                newArray[i] = array[i];

            array = newArray;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new DynamicArrayEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private int CountElements(IEnumerable<T> elements)
        {
            int count = 0;
            foreach (var element in elements)
                count++;

            return count;
        }

        private class DynamicArrayEnumerator : IEnumerator<T>
        {
            private DynamicArray<T> dynamicArray;
            private int currentIndex;

            public DynamicArrayEnumerator(DynamicArray<T> array)
            {
                dynamicArray = array;
                currentIndex = -1;
            }

            public T Current => dynamicArray.array[currentIndex];

            object IEnumerator.Current => Current;

            public bool MoveNext()
            {
                currentIndex++;
                return currentIndex < dynamicArray.count;
            }

            public void Reset()
            {
                currentIndex = -1;
            }

            public void Dispose()
            {
                // Нет неуправляемых ресурсов для освобождения
            }
        }
    }
}
