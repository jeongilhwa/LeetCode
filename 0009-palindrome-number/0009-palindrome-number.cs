public class Solution {
    public bool IsPalindrome(int x) {
        if(x < 0)
        {
            return false;
        }
        string originalstring = x.ToString(); 
        char[] reversechar = new char[originalstring.Length];

        for(int i = 0 ; i < originalstring.Length ;i++)
        {
            reversechar[i] = originalstring[originalstring.Length -1 -i];
            if(reversechar[i] != originalstring[i])
            {return false;}
        }

        return true;

    }
}