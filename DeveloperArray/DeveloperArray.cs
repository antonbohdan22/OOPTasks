using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperArray
{
    public class DeveloperArray<T>
    {

        private T[] devArray;

        public DeveloperArray()
        {
            devArray = new T[] { };
        }

        public T[] DevArray
        {
            get { return devArray; }
            set { devArray = value; }
        }

        public void AddFirst(T value)
        {
            Array.Resize<T>(ref devArray, devArray.Length + 1);

            if (devArray.Length > 1)
            {
                for (int i = devArray.Length - 1; i > 0; i--)
                {
                    devArray[i] = devArray[i - 1];
                }
            }

            devArray[0] = value;
        }

        public void AddLast(T value)
        {
            Array.Resize<T>(ref devArray, devArray.Length + 1);
            devArray[devArray.Length - 1] = value;
        }

        public void InsertAt(T value, int insertionIndex)
        {
            Array.Resize<T>(ref devArray, devArray.Length + 1);
            for (int i = devArray.Length - 1; i > insertionIndex; i--) devArray[i] = devArray[i - 1];

            devArray[insertionIndex] = value;
        }

        public bool Contains(T value)
        {
            foreach (T element in devArray)
                if (element.Equals(value)) return true;
            return false;
        }
    }
}
