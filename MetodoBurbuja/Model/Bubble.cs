using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoBurbuja.Model
{
    internal class Bubble
    {
        public void BubbleSort(int[] array)
        {
            try
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[j] < array[1])
                        {
                            int temp = array[j];
                            array[j] = array[1];
                            array[1] = temp;
                        }
                    }
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
