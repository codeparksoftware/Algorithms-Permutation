using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruteForce
{
    class Permutation
    {
        public static List<string> GetPermutation(string text)
        {
            char[] array = text.ToCharArray();
            List<string> list = new List<string>();
            //list is created to store all  subset
            for (int i = 0; i < array.Length; i++)
            {
                //If first element of Set add directly and there is no operation
                string val = array[i].ToString();
                if (list.Count == 0)
                {
                    list.Add(val);
                }
                else
                {
                    //If there are elements 
                    list.Add(val);
                    //Firstly add without action
                    int tmpCount = list.Count - 1;
                    //This section is Cartesian product of the last element with other elements
                    for (int j = 0; j < tmpCount; j++)
                    {
                        string tmp2, tmp = "" + list[j];
                        for (int n = 0; n <= tmp.Length; n++)
                        {
                            //Here cartesian for example let's assume that tmp="ab", list[j]='c'
                            //It would be {case n=0 "cab", case n=1 "acb" , case n=2 "abc" }
                            tmp2 = tmp;
                            tmp2 = tmp.Insert(n, val);
                            list.Add(tmp2);
                        }
                    }
                }

            }
            return list;

        }

    }
}
