using LeetCodeConsoleApp5;

namespace TestProject_Longest_Palindromic_Substring
{
    public class TestLongestPalindromicSubString
    {
        private string teststring = "babad";
        private string teststring1 = "cbbd";

        [Fact]
        public void Test1()
        {

             MySolution s = new MySolution();
             var r = s.LongestPalindrome(teststring);

             Assert.Equal("bab", r);
        }
        
        
        [Fact]
        public void Test2()
        {

            MySolution s = new MySolution();
            var r = s.LongestPalindrome(teststring1);

            Assert.Equal("bb", r);
        }
    }
}
