using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task4.Dynamic_Array
{
    public class DinamicArray<T> : IEnumerable, IEnumerable<T>, ICloneable
    {
        private T[] array;
        private int capacity = 8;

        public DinamicArray()
        {
            this.Array = new T[this.Capacity];
        }

        public DinamicArray(int n)
        {
            this.Capacity = n;
            this.Array = new T[this.Capacity];
        }

        public DinamicArray(IEnumerable<T> collect)
        {
            this.Count = collect.Count();
            this.Array = new T[this.Capacity];
            this.IncreaseCapacity();

            collect.ToArray().CopyTo(this.Array, 0);
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }

            set
            {
                if (value < this.capacity)
                {
                    this.NewCapacity(value);
                }

                this.capacity = value;
            }
        }

        public int Count { get; private set; } ////Count==Length

        private T[] Array
        {
            get
            {
                return this.array;
            }

            set
            {
                this.array = value;
            }
        }

        public T this[int index]
        {
            get
            {
                if (index > this.Count - 1)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else if ((index < 0) && (index >= -this.Count))
                {
                    return this.Array[this.Count + index];
                }
                else
                {
                    return this.Array[index];
                }
            }

            set
            {
                this.Array[index] = value;
            }
        }

        public void Add(T elem)
        {
            this.Count++;
            this.IncreaseCapacity();

            this.Array[this.Count - 1] = elem;
        }

        public void AddRange(IEnumerable<T> collect)
        {
            int c = this.Count;
            this.Count += collect.Count();
            this.IncreaseCapacity();
            collect.ToArray().CopyTo(this.Array, c);
        }

        public bool Remove(int index)
        {
            if (index >= this.Count)
            {
                return false;
            }
            else
            {
                for (int i = index; i < this.Count - 1; i++)
                {
                    this.Array[i] = this.Array[i + 1];
                }

                this.ReduceLength();
                return true;
            }
        }

        public void Insert(T elem, int index)
        {
            if (index > this.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                this.Count++;
                this.IncreaseCapacity();
                for (int i = this.Count - 1; i > index; i--)
                {
                    this.Array[i] = this.Array[i - 1];
                }

                this.Array[index] = elem;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                yield return this.Array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public object Clone()
        {
            return new DinamicArray<T> { Array = this.Array, Capacity = this.Capacity, Count = this.Count };
        }

        public T[] ToArray()
        {
            T[] arr = new T[this.Count];

            System.Array.Copy(this.Array, arr, this.Count);

            return arr;
        }

        private void NewCapacity(int newValue)
        {
            this.Count = newValue;
            T[] arrInter = new T[newValue];
            System.Array.Copy(this.Array, arrInter, this.Count);
            this.Array = arrInter;
        }

        private void ReduceLength()
        {
            this.Count--;
            System.Array.Copy(this.Array, this.Array, this.Count);  
        }

        private bool IncreaseCapacity()
        {
            if (this.Count > this.Capacity)
            {
                this.Capacity *= (int)((this.Count - 1) / this.Capacity) + 1;
                T[] arrInter = new T[this.Capacity];
                this.Array.CopyTo(arrInter, 0);
                this.Array = new T[this.Capacity];
                this.Array = arrInter;
                return true;
            }

            return false;
        }
    }
}
