using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Harry Potter";

            //1.찾기
            bool found = name.Contains("Harry");
            int index = name.indexOf('P'); // 몇번째 인덱스에 있는지 

            //2.변형
            name = name + "Junior";

            string lowerCaseName = name.ToLower();
            string upperCaseName = name.Toupper();
            string newName = name.Replace('r', 'l');

            //3.분할 
            string[] names = name.Split(new char[] { ' ' });
            string substringName = name.Substring(5);
        }
    }
}