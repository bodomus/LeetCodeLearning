namespace LeetCodeConsoleApp5;

public class MySolution {
    public string LongestPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s) || s.Length == 1)
                    return s;
        
                var start = 0;
                var maxLen = 1;
        
                for (var i = 0; i < s.Length; i++)
                {
                    // Палиндром нечётной длины (центр на символе i)
                    ExpandAroundCenter(i, i);
        
                    // Палиндром чётной длины (центр между i и i + 1)
                    ExpandAroundCenter(i, i + 1);
                }
        
                return s.Substring(start, maxLen);
        
                void ExpandAroundCenter(int left, int right)
                {
                    while (left >= 0 && right < s.Length && s[left] == s[right])
                    {
                        var currentLen = right - left + 1;
                        if (currentLen > maxLen)
                        {
                            maxLen = currentLen;
                            start = left;
                        }
        
                        left--;
                        right++;
                    }
                }
       }
}