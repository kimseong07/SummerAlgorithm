using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace ConsoleApp1
{
    public class Solution
    {
        
        //6번
        public int[] solution1(int n, int m)
        {
            int val = value(n, m);
            int[] result = new int[] { val, n * m / val };

            return result;
        }

        int value(int a, int b)
        {
            return (a % b == 0 ? b : value(b, a % b));
        }
        

        
        //7번
        public long[] solution2(int x, int n)
        {
            long[] result = new long[n];

            for(int i = 0; i < n; i++)
            {
                result[i] = (long)x * (i + 1);
            }

            return result;
        }


        //8번
        /*
        public int solution3(int n)
        {
            int val = value2(n);

            return val;
        }

        int value2(int a)
        {
            if(a == 1)
            {
                return 0;
            }
            return (a % 2 == 0 ? (value2(a / 2)) : (value2(a * 3 + 1)));
        }
        */

        public int solution3(int n)
        {

            long num = n;

            int result = -1;

            for(int i = 0; i < 500; i++)
            {
                if (num == 1)
                {
                    return i;
                }

                num = num % 2 == 0 ? num / 2 : (num * 3) + 1;
            }

            return result;
        }


        //9번
        public int solution4(int n)
        {
            int result = 0;
            char[] a = n.ToString().ToCharArray();

            Array.Sort(a);
            Array.Reverse(a);

            result = int.Parse(a);

            return result;
        }


        //10번
        /*
        public int solution5(int n)
        {
            int[] result = new int[] { };

            char[] a = n.ToString().ToCharArray();

            Array.Reverse(a);

            resul = 

            return result;
        }
        */


        //11번 
        public int solution6(int n)
        {
            int result = 0;
            string a = n.ToString();

            for(int i = 0; i < a.Length; i++)
            {
                result += int.Parse(a.Substring(i, 1));
            }

            return result;
        }


        //12번
        public int solution7(int n, int m)
        {
            int result = 0;

            while( n != m)
            {
                result += n;
                n = (n > m) ? n - 1 : n + 1;
            }

            return result + m;
        }

        //13번
        public int solution8(string s, int n)
        {
            int result = 0;
            int a = int.Parse(s);

            return result;
        }

        //14번
        public int solution9(string s)
        {
            int result = int.Parse(s);

            return result;
        }

        //15번
        public string solution10(int n)
        {
            string result = "";

            for(int i = 0; i <= n; i++)
            {
                result += i % 2 == 0 ? "수" : "박";
            }

            return result;
        }

        //16번
        public int solution16(int n)
        {
            int result = 0;

            int[] a = new int[n + 1];

            for (int i = 2; i <= n; ++i)
            {
                a[i] = i;
            }

            for (int i = 2; i <= (int)Math.Sqrt(n); ++i)
            {
                if (a[i] == 0)
                {
                    continue;
                }

                for (int j = i * 2; j <= n; j += i)
                {
                    if (a[j] == 0)
                    {
                        continue;
                    }

                    a[j] = 0;
                }
            }

            foreach (var num in a)
            {
                if (num != 0)
                {
                    result++;
                }
            }

            return result;
        }

        //17번
        public bool solution17(string s)
        {
            bool result = false;

            if(s.Length == 4 || s.Length == 6)
            {
                result = int.TryParse(s, out int temp);
            }

            return result;
        }

        //18번
        public string solution18(string s)
        {
            int n = (s.Length + 1) % 2;

            int m = s.Length / 2 - n;

            return s.Substring(m, n + 1);
        }

        //19번
        public string solution19(string s)
        {
            string result = "";

            char[] a = s.ToCharArray();

            Array.Sort(a);
            Array.Reverse(a);

            result = new string(a);

            return result;
        }

        //20번
        public string[] solution20(string[] strings, int n)
        {
            string[] result = new string[] { };

            Array.Sort(strings, (str1, str2) =>
            {
                var _str1 = str1.Substring(n, 1);
                var _str2 = str2.Substring(n, 1);

                if (_str1 == _str2)
                {
                    return str1.CompareTo(str2);
                }
                else
                {
                    return str2.CompareTo(str1);
                }
            });

            result = strings;

            return result;

            //strings.ToList().OrderBy(x => x).OrderBy(x => x[n]).ToArray();

            //return strings;
        }

        //21번 
        public int[] solution21(int[] numbers)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Length - 1; ++i)
            {
                for (int j = i + 1; j < numbers.Length; ++j)
                {
                    if (!result.Contains(numbers[i] + numbers[j]))
                    {
                        result.Add(numbers[i] + numbers[j]);
                    }
                }
            }

            result.Sort();

            return result.ToArray();
        }

        //22번
        public string solution22(string s)
        {
            string result = "";

            string[] a = s.Split();

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].ToString().Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        result += a[i][j].ToString().ToUpper(); //대
                    }
                    else
                    {
                        result += a[i][j].ToString().ToLower(); //소
                    }
                }

                if (i != a.Length - 1)
                {
                    result += " ";
                }
            }
            return result;
        }


        //23번
        public static string solution23(int a, int b)
        { 
            string result = ""; 
            
            DateTime date = new DateTime(2024, a, b);

            result = date.DayOfWeek.ToString().Substring(0, 3).ToUpper();

            return result;
        }

        //24번
        public int[] solution24(int[] answers)
        {
            List<int> result = new List<int>();
            int[][] student = new int[3][];

            student[0] = new int[] { 1, 2, 3, 4, 5 };
            student[1] = new int[] { 2, 1, 2, 3, 2, 4, 2, 5 };
            student[2] = new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };
            int[] a = new int[3] { 0, 0, 0 };

            for(int i = 0; i < answers.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if(student[j][i % student[j].Length] == answers[i])
                    {
                        a[j]++;
                    }
                }
            }

            for(int i = 0; i < a.Length; i++)
            {
                if(a[i] == a.Max())
                {
                    result.Add(i + 1);
                }
            }

            return result.ToArray();
        }

        //25번
        public int solution25(int n, int[] lost, int[] reserve)
        {
            int result = 0;

            List<int> Lost = new List<int>(lost);
            List<int> Reserve = new List<int>(reserve);

            Reserve = Reserve.Where(p => !lost.Contains(p)).ToList();
            Lost = Lost.Where(p => !reserve.Contains(p)).ToList();

            result = n - Lost.Count;

            for(int i = 0; i < Lost.Count; i++)
            {
                if (Reserve.Contains(Lost[i] - 1))
                {
                    Reserve.Remove(Lost[i] - 1);

                    result++;
                }
                else if (Reserve.Contains(Lost[i] + 1))
                {
                    Reserve.Remove(Lost[i] + 1);

                    result++;
                }
            }

            return result;
        }

        //26번
        public int solution26(string s)
        {
            int result = 0;

            string[] a = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            for(int i = 0; i < a.Length; i++)
            {
                s = s.Replace();
            }



            return result;
        }

        //27번
        public string solution27(string s)
        {
            string result = "";

            string[] a = s.Split(' ');

            for(int i = 0; i < a.Length; ++i)
            {
                if(a[i] == " ")
                {
                    continue;
                }

                a[i] = a[i].ToLower();

                if(int.TryParse(a[i].First().ToString(), out int temp) == false)
                {
                    a[i] = char.ToUpper(a[i].First()) + a[i].Substring(1);
                }

                result = string.Join(" ", a);

                return result;
            }

            return result;
        }


        //28번
        public int[] solution28(int[] prices)
        {
            int[] result = new int[] { };



            return result;
        }
    }

}
