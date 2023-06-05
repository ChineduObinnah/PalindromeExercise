using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            //    var backwards = "";
            //    for( int i =word.Length -1; i >= 0; i--)
            //    {
            //        backwards += word[i];   
            //    }
            var wordCharArr = word.ToCharArray();
            Array.Reverse(wordCharArr);
            var backwards = new string(wordCharArr);

            if (word.ToLower() == backwards.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }

}
