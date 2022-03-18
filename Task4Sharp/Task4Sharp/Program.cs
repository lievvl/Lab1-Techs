using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Running;

namespace Task4Sharp
{
    [MemoryDiagnoser]
    public class BenchmarkBubble
    {
        private int N = 10000;
        private int[] array;
        private int[] arrayStd;
        private int[] arrayMerge;
        public BenchmarkBubble()
        {
            var random = new Random(0);
            array = new int[N];
            arrayMerge = new int[N];
            arrayStd = new int[N];
            for (int i = 0; i < N; i++)
                array[i] = arrayStd[i] = arrayMerge[i] = random.Next(256);
        }

        [Benchmark]
        public bool SortBubble()
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        (array[j + 1], array[j]) = (array[j], array[j + 1]);
                    }
                }
            }

            return true;
        }

        [Benchmark]
        public bool SortStd()
        {
            Array.Sort(arrayStd);
            return false;
        }

        static void Merge(int[] array, int lowIndex, int middleIndex, int highIndex)
        {
            var left = lowIndex;
            var right = middleIndex + 1;
            var tempArray = new int[highIndex - lowIndex + 1];
            var index = 0;

            while ((left <= middleIndex) && (right <= highIndex))
            {
                if (array[left] < array[right])
                {
                    tempArray[index] = array[left];
                    left++;
                }
                else
                {
                    tempArray[index] = array[right];
                    right++;
                }

                index++;
            }

            for (var i = left; i <= middleIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            for (var i = right; i <= highIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            for (var i = 0; i < tempArray.Length; i++)
            {
                array[lowIndex + i] = tempArray[i];
            }
        }
        
        public int[] MergeSort1(int[] array, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                MergeSort1(array, lowIndex, middleIndex);
                MergeSort1(array, middleIndex + 1, highIndex);
                Merge(array, lowIndex, middleIndex, highIndex);
            }

            return array;
        }

        [Benchmark]
        public int[] MergeSort()
        {
            return MergeSort1(arrayMerge, 0, arrayMerge.Length - 1);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var b = new BenchmarkBubble();
            b.SortBubble();
            Console.WriteLine("End");
        }
    }
}