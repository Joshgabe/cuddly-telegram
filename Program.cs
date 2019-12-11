using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = new List<int>() { 10,20,30,40 };
            List<int> array2 = new List<int>(); //used to 

            Console.WriteLine("Enter rotation value:");
            int key = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Array before rotation:");

            for (int i = 0; i < array.Count; i++)
            {
                Console.Write(array[i] + " ");
                array2.Add(array[i]);
            }
            array = RotateWithoutBeta(array, key);

            Console.WriteLine("\nArray After rotation:");

            for (int i = 0; i < array.Count; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.ReadLine();
        }

        public static List<int> Rotate(List<int> array,List<int> array2,int key)
        {
            for (int i = 0; i < key; i++)
            {
                for (int j = 0; j < array.Count; j++)
                {
                    array[(j + 1) % array.Count] = array2[j];
                }
                for (int k = 0; k < array.Count; k++)
                {
                    array2[k] = array[k];
                }
            }
            return array;
        }

        public static List<int> RotateWithout(List<int> array,int key)
        {
            //last to first
            int temp;
            for (int i = 0; i<key ; i++)
            {
                temp = array[array.Count - 1];
                for (int j = array.Count-1; j > 0; j--)
                {
                    array[j] = array[j - 1];
                }
                array[0] = temp;
            }
            return array;
        }

        public static List<int> RotateWithoutBeta(List<int> array, int key)
        {
            //first to last
            int temp;
            for (int i = 0; i < key; i++)
            {
                temp = array[0];
                for (int j = 0; j < array.Count; j++)
                {
                    array[j] = array[(j + 1)%array.Count];
                }
                array[array.Count-1] = temp;
            }
            return array;
        }
    }
}
