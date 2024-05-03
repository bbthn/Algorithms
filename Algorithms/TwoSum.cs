

namespace Algorithms
{
    //Time COmplexity =O(n^2)  
    public static  class TwoSum
    {
        static int[] TwoSumInt(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[0];
        }

    }
}
