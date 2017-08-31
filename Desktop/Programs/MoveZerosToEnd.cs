//Here is the solution for move zeros to the end of the array without distrubing 
//order of the non zero elements and in space!!!


public class Solution {
    public void MoveZeroes(int[] nums) {
        int i;
        int j=0;;
        for(i=0;i<nums.Length;i++)
        {
             if(nums[i]!=0)
             {
                 nums[j]=nums[i];
                 j++;
             }
        }
        for(int k=j;k<nums.Length;k++)
        {
            nums[k]=0;
        }
        
    }
}

