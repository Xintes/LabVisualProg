
namespace Lab6VisualProg
{
    using System;
    using System.Collections;
    using System.Collections.Generic;


    public class DynamicArray<T> : IEnumerable<T> where T: IComparable<T>
    {
        private T[] array;
        private int count;

        public int Count => count;
        public int Capacity => array.Length;

        public DynamicArray()
        {
            int deff = 20;
            array = new T[deff];
        }

        public DynamicArray(int capacity)
        {
            array = new T[capacity];
        }
      
        /////////////////////////// 6
        
        public void Filter(Func<T, bool> filterFunc)
        {
            int currentIndex = 0;
            for (int i = 0; i < count; i++)
            {
                if (filterFunc(array[i]))
                {
                    array[currentIndex] = array[i];
                    currentIndex++;
                }
            }

            count = currentIndex;
        }

        public void Sort(Func<T, T, int> comparer)
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < count - 1; i++)
                {
                    if (comparer(array[i], array[i + 1]) > 0)
                    {
                
                        T temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);
        }

        /////////////////////////////

        public void Add(T element)
        {
            if (count == array.Length)
                IncreaseCapacity();

            array[count] = element;
            count++;
        }

        public void Add(IEnumerable<T> elements)
        {
            int elementsCount = CountElements(elements);

            if (count + elementsCount > array.Length)
                IncreaseCapacity();

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
                IncreaseCapacity();

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

        public void IncreaseCapacity()
        {
            int newCapacity = array.Length * 2;
            T[] newArray = new T[newCapacity];
            for (int i = 0; i < count; i++)
                newArray[i] = array[i];

            array = newArray;
        }

        //Доп

        public void Sort()
        {
            Array.Sort(array, 0, count);
        }

        public List<int> BinarySearch(T obj)
        {
            List<int> indexes = new List<int>();

            int left = 0;
            int right = count - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                int comparisonResult = obj.CompareTo(array[mid]);

                if (comparisonResult == 0)
                {
                    indexes.Add(mid); // Добавляем индекс найденного элемента
                                      // Проверяем элементы слева от найденного элемента
                    int temp = mid - 1;
                    while (temp >= 0 && obj.CompareTo(array[temp]) == 0)
                    {
                        indexes.Add(temp);
                        temp--;
                    }
                    // Проверяем элементы справа от найденного элемента
                    temp = mid + 1;
                    while (temp < count && obj.CompareTo(array[temp]) == 0)
                    {
                        indexes.Add(temp);
                        temp++;
                    }
                    return indexes;
                }
                else if (comparisonResult < 0)
                {
                    right = mid - 1; // Искомый элемент находится слева от mid
                }
                else
                {
                    left = mid + 1; // Искомый элемент находится справа от mid
                }
            }

            return indexes; // Элемент не найден
        }


        public IEnumerator<T> GetEnumerator()
        {
            return new DynamicArrayEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator() //метод просто вызывает метод GetEnumerator(), который является неявной реализацией IEnumerable<T>.GetEnumerator(), и возвращает тот же объект перечислителя.
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

            public T Current => dynamicArray.array[currentIndex]; //возвращает текущий элемент коллекции DynamicArray<T>

            object IEnumerator.Current => Current; //возвращает текущий элемент коллекции в виде объекта типа object

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
