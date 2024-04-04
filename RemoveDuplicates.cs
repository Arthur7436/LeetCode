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
            List<int> arrayList = nums.ToList();
            int duplicateRemovalCount = 0;

            //find the duplicate and remove it
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; i < array.Length; j++)
                {
                    if (arrayList[i] == arrayList[j])
                    {
                        arrayList.RemoveAt(j);
                        duplicateRemovalCount++;
                    }
                }
            }

            //replace the duplicates with "_"
            for (int i = 0; i < duplicateRemovalCount; i++)
            {
                arrayList.Add("_");
            }

            //count how many are left in the list
            int count = 0;
            for (int i = 0; i < arrayList.Length; i++)
            {
                count++;
            }

            string array = arrayList.ToString();
            return $"{count} ,nums = {array}";
        }
    }
}