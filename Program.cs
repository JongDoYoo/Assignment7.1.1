namespace Assignment7._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 98, 85, 75, 87, 74, 62, 80 };
            SelectionSort(array);
            Console.WriteLine($"This is the sorted grades");   
            printArray( array );
        }
        static void SelectionSort(int[] array )       //if I use static, I dont have to instantiate
        {
           //int n = array.Length;   how is this possible?
            
            //Outer loop points to dividing line bwteen sorted and unsorted
           for (int i = 0; i < array.Length-1; i++)
            {
                //Find the minimum element in unsorted portion
                int minIndex = i;

                for (int j = i+1; j < array.Length; j++)                   //inner loop swaps number by the if condition. swaps the unsorted and makes it sorted by ascending 
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                   
                }
                //three way swap
                int temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
        }
        static void printArray(int[] array)    //this is just to print the array
        {
            
            for (int i = 0; i<array.Length; i++)
                Console.Write(array[i]+" ");
            Console.WriteLine();
        }
    }
}
