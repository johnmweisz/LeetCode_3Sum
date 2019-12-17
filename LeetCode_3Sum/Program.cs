using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_3Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            var result = solution.ThreeSum(new int[] {0, 0, 0, 0});
            foreach (var intse in result)
            {
                Console.WriteLine();
                foreach (var i in intse)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
    public class Solution
    {
        public List<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            var result = new List<IList<int>>();
            for (int i = 0; i < nums.Length - 2; i++)
            {
                var left = i + 1;
                var right = nums.Length - 1;
                while (left < right)
                {
                    if (nums[i] + nums[left] + nums[right] == 0)
                    {
                        while (left < right - 1 && nums[left] == nums[left + 1]) left++;
                        while (i < left - 1 && nums[i] == nums[i + 1]) i++;
                        while (right > left + 1 && nums[right] == nums[right - 1]) right--;
                        result.Add(new List<int>() {nums[i], nums[left], nums[right]});
                        left++;
                        right--;
                    }

                    while (left < right && nums[i] + nums[left] + nums[right] < 0) left++;
                    while (left < right && nums[i] + nums[left] + nums[right] > 0) right--;
                }
            }

            return result;
        }

    }
}
