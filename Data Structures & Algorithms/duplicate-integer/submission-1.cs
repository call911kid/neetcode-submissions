public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> elements=new HashSet<int>();

        foreach(var x in nums){
            if(!elements.Add(x)){
                return true;
            }
        }
        return false;
    }
}