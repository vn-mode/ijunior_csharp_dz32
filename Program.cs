using System;

namespace vn_mode_csharp_dz32
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] userArray = new int[]{ 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Shuffle(userArray);
            foreach (int number in userArray)
            {
                Console.Write(number + " ");
            }

            static void Shuffle(int[] array)
            {
                Random random = new Random();
                for (int i = array.Length -1 ; i >= 1; i--)
                {
                    int j = random.Next(i + 1);
                    int temp = array[j];
                    array[j] = array[i];
                    array[i] = temp;
                }
            }
        }
    }
}

