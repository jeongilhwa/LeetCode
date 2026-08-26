public class Solution {
    public int[] TwoSum(int[] nums, int target) {
             int[] result ;
             int firstNum = 0;
             int secondNum = 0;
        for(int i = 0 ; i<nums.Length;i++)
        {
            for(int j = i+1; j < nums.Length ; j++)
            {
           
                
                if((nums[i]+nums[j]) == target){
                    firstNum = i;
                    secondNum = j;
                     return new int[] {i,j};
                     
                }
                
            }
        }
        return result = new int[] {firstNum,secondNum};
       
    }
}