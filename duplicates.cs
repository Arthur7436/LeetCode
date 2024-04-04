using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            //turn array into string
            //loop through string to see if there are any duplicates
            //if there are duplicates then remove the duplicate
            //count how many duplicates have been removed
            //return output

            string array = nums.ToString();
            string newArray = [];
            int duplicateRemovalCount = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; i < array.Length; j++)
                {
                    //Find any duplicates 
                    if (array[i] == array[j])
                    {
                        //remove j
                        if (array[k] != array[l])
                        {
                            array[l++] = array[k];
                            int indexToRemoveAt = j;
                            duplicateRemovalCount++;

                        }
                    }
                }

                for (int i = 0; i < duplicateRemovalCount; i++)
                {
                    array = array.Add("_");
                }

                int count = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    count++;
                }

                return $"{count} ,nums = {array}";
            }
        }
    }
}