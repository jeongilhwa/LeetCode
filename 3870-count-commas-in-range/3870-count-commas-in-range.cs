public class Solution {
    public int CountCommas(int n) {
        if(n <1000)
        {
            return 0;

        }
        int resultnum = n- 1000;
        
        return resultnum+1;
    }
}