using System;
using System.Net.Configuration;
using System.Security.Cryptography;

namespace DataStructure
{
    public class ArrayDataStruct
    {
        public int[] Arr = new int[5] {12, 34, 51, 5, 9};

        // O(1)
        private void ArrPush() 
        {
            Console.Clear();
            Console.WriteLine("This will remove the last item of the array and insert the new one");
            bool whileMenu = true;
            while (whileMenu)
            {
                Console.WriteLine("Type a new integer for array insertion.");
                Int32.TryParse(Console.ReadLine(), out int NewNum);
                
                Arr[Arr.Length - 1] = NewNum;
                whileMenu = false;
            }
        }

        private void ArrPeak()
        {
            Console.Clear();
            Console.WriteLine("Array.");
            // O(n)
            for(int i = 0; i < Arr.Length; i++)
            { 
                object j = Arr[i];
                Console.WriteLine($"ArrayIndex->{i} Value->{j}");
            }

            Console.ReadLine();
        }

        private void ArrPop()
        {
            bool arrdelmenu = true;
            
            while (arrdelmenu)
            {
                Console.WriteLine("What index would you like to delete.");
                Int32.TryParse(Console.ReadLine(), out int choice);

                try
                {
                    // Since we can't delete array elements we will just set them to zero.
                    // We could create a new array and transfer the elements over but that is for next time.
                    Arr[choice] = 0;

                    if (Arr.Length - 1 == choice)
                    {
                        Console.WriteLine("We don't have to move anything since we are 'removing' the last element");
                        // Since we can't delete array elements we will just set them to zero.
                        // We could create a new array and transfer the elements over but that is for next time.
                        Arr[choice] = 0;
                    }
                    else
                    {
                        // O(n)
                        for (int i = choice; i < Arr.Length - 1; i++)
                        {
                            // Checks so the we are not on the last, will would cause an error.
                            if (i != 4)
                            {
                                Arr[i] = Arr[i + 1];
                            }
                            else
                            {
                                // Changes the last value of the array to error.
                                // Equivalent to 'removing' the element.
                                Arr[Arr.Length - 1] = 0;
                            } 
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: You tried to delete something that didnt exist.");
                }
                arrdelmenu = false;
                Console.ReadLine();
            }
            // ReSharper disable once FunctionNeverReturns
        }

        private void ArrSearch()
        {
            Console.WriteLine("Enter search key");
            Int32.TryParse(Console.ReadLine(), out int searchkey);
            
            // Linear Search O(n)
            for (int i = 0; i < Arr.Length - 1; i++)
            {
                if (Arr[i] == searchkey)
                {
                    Console.WriteLine($"Key found -> {i}");
                    break;
                }
                // Should do some printing for not found but, dont have time.   
            }
            Console.ReadLine();
        }

        private void ArrSortBubble()
        {
            // O(n2)
            int max = Arr.Length - 1;
            for (int i = 0; i < max; i++)
            {
                int submax = - i;
                for (int j = 0; j < submax ; j++)
                {
                    if (Arr[j] > Arr[j + 1])
                    {
                        Console.WriteLine($"{Arr[j]} -> {Arr[j + 1]}");
                        int temp = Arr[j];
                        Arr[j] = Arr[j + 1];
                        Arr[j + 1] = temp;
                    }
                }
            }

            Console.ReadLine();
        }

        /*
         
        list_of_heights = [192, 12, 22, 25, 11]
         
        Selection sort works like this. Let's say we have a line of 6 people that we wanted sorted by height. Three of them are already sorted. Index 1 is not sorted.
            So let's use selection-sort.
         
        Steps -> (every object has two values the string value and the index value.
        (192, 0) this object has the str value of 192, and it sits a index value 0
         
        - object1 = (192, 0)
        - note = (192, 0)
        - object2 = (12, 1)
        - object3 = (22, 2)
        - object4 = (11, 4)
         
         
        1. object1 is also the current note(192, 0).
        2. Check if object1 is less or greater then object2
        3. if object2 is less then object1. object2 becomes the note.
            1. note = (12, 1)
        4. Check if object3 is less or greater then the note
        5. In our example the note eventually becomes
            1. note = (11, 4)
        6. Then we perform the swap.
        6. object1 has taken the spot of note
            1. object1 = (192, 4)
            2. object1 = (11, 0)
            3. note = null
         
        End. So the array looks like this.
         
        list_of_heights = [11, 12, 22, 25, 192]
        
        */
        private void ArrSortSelection()
        {
            // max index value
            int max = Arr.Length - 1;
            // First for loop.
            for (int i = 0; i < max; i++)
            {
                // smallest integer
                int note = i;
                // Second for loop
                for (int j = i + 1; j < i; j++)
                {
                    // if the current element j is less then i.
                    // note is now element j
                    if (Arr[j] < Arr[note])
                    {
                        note = Arr[j];
                    }
                }
                // When the second for loop is done.
                // Insert the smallest value in the last j-loop iteration into temp
                int temp = Arr[note];
                // Smallest value in the last j-loop is now swapped with the inital smallest value of the last j-loop iteration.
                Arr[note] = Arr[i];
                // inital smallst value is now current smallest
                Arr[i] = temp;
            }
        }
        public void Main()
        {
            bool arrmenu = true;
            while (arrmenu)
            {
                Console.Clear();
                // Printing out some options.
                Console.WriteLine("\t[0]Insert into Array \n\t[1]View array" +
                                  "\n\t[2]Delete Element \n\t[3]Search Array" +
                                  "\n\t[4]Bubble Sort. \n\t[5]Selection Sort" );

                Int32.TryParse(Console.ReadLine(), out int menu);
                switch (menu)
                {
                    case 0:
                        this.ArrPush();
                        break;
                    case 1:
                        this.ArrPeak();
                        break;
                    case 2:
                        this.ArrPop();
                        break;
                    case 3:
                        this.ArrSearch();
                        break;
                    case 4:
                        this.ArrSortBubble();
                        break;
                    case 5:
                        this.ArrSortSelection();
                        break;

                }
            }
        }
    }
}