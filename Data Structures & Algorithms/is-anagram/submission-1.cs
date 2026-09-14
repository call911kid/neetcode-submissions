public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] oc= new int[26];

        if(s.Length!=t.Length) return false;

        for(int i=0;i<s.Length;i++){
            oc[s[i]-'a']++;
            oc[t[i]-'a']--;
        }

        bool ok=true;
        for(int i=0;i<26;i++){
            if(oc[i]!=0) ok=false;
        }
        return ok;
    }
}
