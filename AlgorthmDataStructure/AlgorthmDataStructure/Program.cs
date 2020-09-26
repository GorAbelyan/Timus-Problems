//using System;
//using System.Globalization;

//namespace AlgorthmDataStructure
//{
//    public class MyClass
//    {
//        static void Main(string[] args)
//        {
//            var n = (Console.ReadLine());

//            var t = n.Split(' ');
//            var tt = new int[2];
//            tt[0] = Convert.ToInt32(t[0]);
//            tt[1] = Convert.ToInt32(t[1]);
//            if ((tt[0] * tt[1]) % 2 == 0)
//            {
//                Console.WriteLine("[:=[first]");
//            }
//            else
//            {
//                Console.WriteLine("[second]=:]");
//            }
//        }


//    } 
//}

//using System;
//using System.Globalization;

//namespace AlgorthmDataStructure
//{
//    public class MyClass
//    {

//        static void Main(string[] args)
//        {

//            var n = Console.ReadLine();
//            var m = n.Split(' ');
//            int[] a = new int[2];
//            a[0] = Convert.ToInt32(m[0]);
//            a[1] = Convert.ToInt32(m[1]);
//            Console.WriteLine(a[0]+a[1]);


//        }




//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Globalization;

//namespace AlgorthmDataStructure
//{
//    public class MyClass
//    {

//        static void Main(string[] args)
//        {

//            var n = Convert.ToInt32(Console.ReadLine());
//            var MMM = Console.ReadLine();
//            var m = MMM.Split(' ');
//            int[] arr = new int[n];
//            int count = 0;
//            int j = 1;
//            List<int> list = new List<int>();
//            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
//            for (int i = 0; i < n; i++)
//            {
//                arr[i] = Convert.ToInt32(m[i]);
//            }
//            for (int i = 1; i < n; i++)
//            {
//                count=0;
//                var t = arr[i];
//                if (arr[i] == arr[i - 1])
//                {
//                    j++;
//                    count++;

//                }
//                else
//                {
//                    j++;
//                }

//                list.Add(count);
//                list.Add(t);
//            }


//        }

//    }




//}

//using System;
//using System.Collections.Generic;
//using System.Globalization;

//namespace AlgorthmDataStructure
//{
//    public class MyClass
//    {
//        static void ProductofDigits()
//        {
//            var input = Console.ReadLine();
//            var n = Convert.ToInt64(input);
//            if (n == 4)
//            {
//                Console.WriteLine(22);
//                return;
//            }
//            if (n == 5)
//            {
//                Console.WriteLine(-1);
//                return;
//            }
//            if (n == 6)
//            {
//                Console.WriteLine(23);
//                return;
//            }
//            if (n == 7)
//            {
//                Console.WriteLine(-1);
//                return;
//            }
//            if (n == 8)
//            {
//                Console.WriteLine(24);
//                return;
//            }
//            if (n == 9)
//            {
//                Console.WriteLine(33);
//                return;
//            }
//            if (n >= 0 && n <= 3)
//            {
//                Console.WriteLine(n);
//                return;
//            }
//            var dig = new Stack<int>();
//            long ans = 0;
//            for (int i = 9; i >= 2; i--)
//            {
//                while (n > 1 && n % i == 0)
//                {
//                    dig.Push(i);
//                    n /= i;
//                }
//            }
//            if (n != 1)
//            {
//                Console.WriteLine(-1);
//                return;
//            }
//            while (dig.Count > 0)
//            {
//                ans = 10 * ans + dig.Pop();
//            }
//            Console.WriteLine(ans);
//        }
//        static void Main(string[] args)
//        {

//            ProductofDigits();
//        }

//    }




//}
//using System;
//using System.Collections.Generic;
//using System.Globalization;

//namespace AlgorthmDataStructure
//{
//    public class MyClass
//    {


//        static void ProductofDigits()
//        {

//            var t = Console.ReadLine();
//            var m = t.Split();
//            int[] a = new int[2];
//            a[0] = Convert.ToInt32(m[0]);
//            a[1] = Convert.ToInt32(m[1]);
//            Console.Write((a[1]-1)+" "+(a[0]-1));


//        }
//        static void Main(string[] args)
//        {

//            ProductofDigits();
//        }

//    }
//}
//using System;
//using System.Collections.Generic;
//using System.Globalization;

//namespace AlgorthmDataStructure
//{
//    public class MyClass
//    {


//        static void ProductofDigits()
//        {

//        }
//        static void Main(string[] args)
//        {
//            var t= Console.ReadLine();
//            var m = t.Split(' ');
//            int[] a = new int[3];
//            int[] b = new int[3];
//            a[0] = Convert.ToInt32(m[0]);
//            b[0] = Convert.ToInt32(m[1]);
//             t = Console.ReadLine();
//             m = t.Split(' ');
//            a[1] = Convert.ToInt32(m[0]);
//            b[1] = Convert.ToInt32(m[1]);
//            t = Console.ReadLine();
//            m = t.Split(' ');
//            a[2] = Convert.ToInt32(m[0]);
//            b[2] = Convert.ToInt32(m[1]);
//            Console.Write((a[0]-a[2]).ToString()+" "+(b[0]-b[1]).ToString());
//        }

//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Globalization;

//namespace AlgorthmDataStructure
//{
//    public class MyClass
//    {

//        static void Main(string[] args)
//        {
//            LongestPalindrome();
//        }
//        static void LongestPalindrome()
//        {
//            var s = Console.ReadLine();
//            var resultStart = 0;
//            var length = s.Length;
//            var dp = new int[length];
//            dp[0] = 1;
//            for (var i = 1; i < length; i++)
//            {
//                var previous = dp[i - 1];
//                if (IsPalindrome(s, i - previous - 1, i))
//                {
//                    dp[i] = dp[i - 1] + 2;
//                    resultStart = i - previous - 1;
//                }
//                else if (IsPalindrome(s, i - previous, i))
//                {
//                    dp[i] = dp[i - 1] + 1;
//                    resultStart = i - previous;
//                }
//                else
//                {
//                    dp[i] = dp[i - 1];
//                }
//            }
//            Console.WriteLine(s.Substring(resultStart, dp[length - 1]));
//        }
//        private static bool IsPalindrome(string s, int start, int end)
//        {
//            while (start >= 0 && start < end && s[start] == s[end])
//            {
//                start++;
//                end--;
//            }
//            return start >= end;
//        }
//    }






//using System;
//using System.Collections.Generic;
//using System.Globalization;

//namespace AlgorthmDataStructure
//{
//    public class MyClass
//    {

//        static void Main(string[] args)
//        {

//            var n = Console.ReadLine();
//            var m = n.Split(' ');
//            long sum = 0;
//            int tt = 0;
//            var kk = "abcdefghijklmnopqrstuvwxyz";
//            Dictionary<string, int> keyValuePairs = new System.Collections.Generic.Dictionary<string, int>();
//            for (int i = 0; i < 26; i++)
//            {
//                if (tt >= 3)
//                {
//                    tt = 0;
//                }
//                tt++;

//                keyValuePairs.Add(kk[i].ToString(),tt);
//            }
//            keyValuePairs.Add("!", 3);
//            keyValuePairs.Add(".", 1);
//            keyValuePairs.Add(",", 2);

//            keyValuePairs.Add(" ", 1);

//            for (int i = 0; i < n.Length; i++)
//            {
//                if (keyValuePairs.ContainsKey(n[i].ToString()))
//                {
//                    int t = 0;
//                    keyValuePairs.TryGetValue(n[i].ToString(),out t);
//                    sum += t;
//                }
//            }
//            Console.WriteLine(sum);

//        }




//    }
//}


//using System;
//namespace TimusProblems
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var input = Console.ReadLine().Split(' ');
//            var n = Convert.ToInt32(input[0]);
//            Console.WriteLine(Fib(n));
//        }
//        static long Fib(int n)
//        {
//            if (n == 1)
//            {
//                return 2;
//            }
//            else if (n==2)
//            {
//                return 2;
//            }
//            long[] arr = new long[n];
//            arr[0] = arr[1] = 2;
//            for (int i = 2; i < n; i++)
//            {
//                arr[i] = arr[i - 1] + arr[i - 2];
//            }
//            return arr[n-1];
//        }
//    }
//}
#region MaxMinPrime

//class Program
//{
//    public static bool isPrime(int p)
//    {
//        for (int i = 2; i <= Math.Sqrt(p); i++)
//        {
//            if (p % i == 0)
//            {
//                return false;
//            }
//        }
//        if (p == 1)
//        {
//            return false;
//        }
//        return true;
//    }

//    static void Main(string[] args)
//    {
//        var n = Convert.ToInt32(Console.ReadLine());
//        var arr = Console.ReadLine();
//        var arrr = arr.Split(' ');
//        int[] realarr = new int[n];

//        for (int i = 0; i < arrr.Length; i++)
//        {
//            realarr[i] = Convert.ToInt32(arrr[i]);
//        }

//        int maxPrime = 0;
//        int minPrime = 0;
//        Array.Sort(realarr);
//        for (int i = 0; i < realarr.Length; i++)
//        {
//            if (isPrime(realarr[i]))
//            {
//                if (minPrime == 0)
//                    minPrime = realarr[i];
//            }


//            if (isPrime(realarr[realarr.Length - i - 1]))
//            {
//                if (maxPrime == 0)
//                    maxPrime = realarr[realarr.Length - i - 1];
//            }
//        }
//        if (minPrime != 0 || maxPrime != 0)
//        {
//            Console.WriteLine(maxPrime - minPrime);
//        }
//        else
//        {
//            Console.WriteLine(1);
//        }
//    }

//}

#endregion
#region  Babochki

//class Program
//{
//    public static bool BinarySearch(int floor,int ceel,int num,int[] arr)
//    {
//        if (num > arr[ceel] || num < arr[floor])
//        {
//            return false;
//        }

//        if( num==arr[(ceel+floor)/2])
//        {
//            return true;
//        }
//        if ((arr[(ceel + floor)/ 2]> num))
//        {
//            ceel = (ceel + floor) / 2;
//            BinarySearch(floor, ceel-1, num, arr);
//        }
//        else
//        {
//            floor = (ceel + floor) / 2;
//            BinarySearch(floor, ceel-1, num, arr);

//        }

//        return false;
//    }

//    static void Main(string[] args)
//    {
//        var n = Convert.ToInt32(Console.ReadLine());
//        var arr = Console.ReadLine();
//        var number= Convert.ToInt32(Console.ReadLine());
//        var arrr = arr.Split(' ');
//        int[] realarr = new int[n];

//        for (int i = 0; i < arrr.Length; i++)
//        {
//            realarr[i] = Convert.ToInt32(arrr[i]);
//        }



//        if (BinarySearch(0, realarr.Length-1, number, realarr))
//        {
//            Console.WriteLine("YES");
//        }
//        else
//        {
//            Console.WriteLine("No");
//        }
//    }

//}

#endregion
#region Tasks

//class Program
//{


//    static void Main(string[] args)
//    {
//        int t = 0;

//        var arr = Console.ReadLine();
//        int mnacord = arr[0] - '0';
//        var mmm = arr[0];

//        for (int i = 1; i < arr.Length; i++)
//        {
//             t = Convert.ToInt32(mnacord.ToString() + arr[i]);
//             mnacord = t % 7;

//        }

//        Console.WriteLine(mnacord);

//    }

//}

#endregion
#region 
//using System;
//using System.Collections.Generic;
//using System.Globalization;

//namespace AlgorthmDataStructure
//{
//    public class MyClass
//    {


//        static void ProductofDigits()
//        {
//            var t=Console.ReadLine();
//            var m = t.Split(' ');
//            int[] x = new int[2];
//            x[0] = Convert.ToInt32(m[0]);
//            x[1] = Convert.ToInt32(m[1]);
//            Console.WriteLine(x[0]*(x[1]+1));



//        }
//        static void Main(string[] args)
//        {
//            ProductofDigits();
//        }

//    }
//}
#endregion

#region 1820
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//namespace RefactoringGuru.DesignPatterns.FactoryMethod.Conceptual
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var n = Console.ReadLine();
//            var t = n.Split(' ');
//            int[] ab = new int[2];
//            ab[0] = Convert.ToInt32(t[0]);
//            ab[1] = Convert.ToInt32(t[1]);
//            if (ab[0] <= ab[1]) { Console.WriteLine(2);return; }
//            if(ab[0] * 2 % ab[1]==0)
//            Console.WriteLine(ab[0]*2/ab[1]);
//            else
//            {
//                Console.WriteLine(ab[0] * 2 / ab[1]+1);

//            }
//        }
//    }
//}
#endregion
#region 2066
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//namespace RefactoringGuru.DesignPatterns.FactoryMethod.Conceptual
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var a = Convert.ToInt32(Console.ReadLine());
//            var b = Convert.ToInt32(Console.ReadLine());
//            var c = Convert.ToInt32(Console.ReadLine());
//            if (a == 0 && b == 0 && c == 0)
//            {
//                Console.WriteLine(a - b - c);
//                return;
//            }
//            if (b == 1 && c != 1)
//            {
//                Console.WriteLine(a - b - c);
//                return;
//            }
//            if (a == 1 && b == 1 && c == 1)
//            {
//                Console.WriteLine(a - b - c);
//                return;
//            }
//            if (a == 0 && b == 0 && c != 0)
//            {
//                Console.WriteLine(a - b - c);
//                return;
//            }
//            if (a == 0 && b == 1 && c == 1)
//            {
//                Console.WriteLine(a - b - c);
//                return;
//            }
//            if (b == 0)
//            {
//                Console.WriteLine(a - b - c);
//                return;
//            }
//            Console.WriteLine(a - (b * c));
//        }
//    }
//}
#endregion
#region 2100
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//namespace RefactoringGuru.DesignPatterns.FactoryMethod.Conceptual
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var t = Convert.ToInt32(Console.ReadLine());
//            string[] ss = new string[t];
//            int count = 2;
//            for (int i = 0; i < t; i++)
//            {
//                ss[i] = Console.ReadLine();
//                if (ss[i].Contains("+one"))
//                {
//                    count += 2;
//                }
//                else { count++; }
//            }
//            if (count  == 13)
//            {
//                Console.WriteLine(14*100);
//            }
//            else
//            {
//                Console.WriteLine((count)*100);
//            }

//        }
//    }
//}
#endregion
#region 1880
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//namespace RefactoringGuru.DesignPatterns.FactoryMethod.Conceptual
//{
//    class Program   
//    {
//        static void Main(string[] args)
//        {
//            var n =Convert.ToInt32(Console.ReadLine());
//            var aa = Console.ReadLine();
//            var oo = aa.Split(' ');
//            int[] a = new int[n];
//            var nn = Convert.ToInt32(Console.ReadLine());
//            var aaa = Console.ReadLine();
//            var ooo = aaa.Split(' ');
//            int[] b = new int[nn];
//            var nnn = Convert.ToInt32(Console.ReadLine());
//            var aaaa = Console.ReadLine();
//            var oooo = aaaa.Split(' ');
//            int[] c = new int[nnn];
//            int j = 0;
//            int k = 0;
//            int l = 0;
//            int count = 0;
//            int[] vla = new int[n + nn + nnn];
//            List<int> list = new List<int>();
//            for (int i = 0; i < n; i++)
//            {
//                list.Add(Convert.ToInt32(oo[i]));
//            }
//            for (int i = n; i < nn; i++)
//            {
//                list.Add(Convert.ToInt32(ooo[j]));
//                j++;
//            }
//            for (int i = nn; i < nnn; i++)
//            {
//             list.Add(Convert.ToInt32(oooo[k]));
//                k++;

//            }
//            list.Sort();
//            for (int i = 2; i < list.Count; i++)
//            {
//                if(list[i]==list[i-1])
//            }
//            Console.WriteLine(count);

//        }
//    }
//}
#endregion
#region 1209
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace T1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            //List<int> n = new List<int>();

//            List<long> ans = new List<long>();

//            long s = System.Int64.Parse(Console.ReadLine());

//            for (int i = 0; i < s; i++)
//            {
//                int x = int.Parse(Console.ReadLine());
//                ans.Add(Find(x));
//            }

//            for (int i = 0; i < s; i++)
//            {
//                Console.Write(ans[i]);
//                Console.Write(" ");
//            }



//            //Console.ReadKey();
//        }

//        static long Find(long x)
//        {

//            // (a)n^2 + (b)n - (c)2x = 0
//            // a = 1
//            // b = 1
//            // c = 2 * x

//            double a = 1, b = 1, c = -2 * x + 2;
//            double d = b * b - 4 * a * c;
//            double p = (-b + Math.Sqrt(d)) / 2 * a;

//            return (p - (long)p) > 0 ? 0 : 1;

//        }
//    }
//}
#endregion
#region 2023
//using System;

//namespace T1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string[] first = {"Alice","Ariel","Aurora","Phil","Peter","Olaf","Phoebus","Ralph","Robin"};
//            string[] second = { "Bambi", "Belle", "Bolt", "Mulan", "Mowgli", "Mickey", "Silver", "Simba", "Stitch"};
//            string[] three = { "Dumbo", "Genie", "Jiminy", "Kuzko", "Kida", "Kenai", "Tarzan", "Tiana", "Winnie" };
//            var n = Convert.ToInt32(Console.ReadLine());
//            int state = 1;
//            int endState = 1;
//            bool havvv = false;
//            int Step = 0;
//            for (int i = 0; i < n; i++)
//            {
//                havvv = false;
//                var t = Console.ReadLine();
//                for (int j = 0; j < first.Length; j++)
//                {
//                    if (t == first[j])
//                    {
//                        havvv = true;
//                        Step += Math.Abs( state - 1);
//                        state = 1;
//                        break;
//                    }
//                }
//                if (havvv) { continue; }
//                for (int m = 0; m < second.Length; m++)
//                {
//                    if (t == second[m])
//                    {
//                        havvv = true;
//                        Step +=Math.Abs( state - 2);
//                        state = 2;
//                        break;
//                    }
//                }
//                if (havvv) { continue; }

//                for (int k = 0; k< three.Length; k++)
//                {
//                    if (t == three[k])
//                    {
//                        Step +=Math.Abs( state - 3);
//                        state = 3;
//                        break;

//                    }
//                }
//            }
//            Console.WriteLine(Step);
//        }
//    }
//}

#endregion
#region 1924
//using System;

//namespace T1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var n = Convert.ToInt32( Console.ReadLine());
//            if (n == 1) { Console.WriteLine("grimy"); return; }
//            int sum = 0;
//            for (int i = 1; i <= n; i++)
//            {
//                sum += i;
//            }
//            if (sum % 2 == 0)
//            {
//                Console.WriteLine("black");
//            }
//            else
//            {
//                Console.WriteLine("grimy");
//            }

//        }
//    }
//}
#endregion
#region 1910
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        int n = int.Parse(Console.ReadLine());
//        string[] a = Console.ReadLine().Split(' ');

//        int[] a_sum = new int[a.Length - 2];

//        for (int i = 0; i < a_sum.Length; i++)
//        {
//            a_sum[i] = int.Parse(a[i]) + int.Parse(a[i + 1]) + int.Parse(a[i + 2]);
//        }

//        for (int i = 0; i < a_sum.Length; i++)
//        {
//            if (a_sum[i] == a_sum.Max())
//            {
//                Console.WriteLine("{0} {1}", a_sum.Max(), i + 2);
//            }
//        }
//    }
//}
#endregion
#region 1263
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        var ns = (Console.ReadLine());
//        var mmmm = ns.Split(' ');
//        int n = int.Parse(mmmm[0]);
//        int m = int.Parse(mmmm[1]);


//        int[] nn = new int[n];
//        for (int i = 0; i < m; i++)
//        {
//            int mlak = Convert.ToInt32(Console.ReadLine());
//            nn[mlak-1]++;
//        }
//        for (int i = 0; i < n; i++)
//        {
//            var t = ((float)((float)nn[i] / m * 100)).ToString("0.00");

//            Console.WriteLine(t+"%");
//        }


//    }
//}
#endregion
#region 1349
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        var n = Convert.ToInt32(Console.ReadLine());
//        if (n == 0)
//        {
//            Console.Write(-1);

//        }
//        else if(n==1)
//        {
//            Console.Write("1"+" "+"2"+" "+"3");
//        }
//        else if(n==2)
//        {
//            Console.Write("3" + " " + "4" + " " + "5");

//        }
//        else
//        {
//            Console.WriteLine(-1);
//        }


//    }
//}
#endregion
#region 1110

//using System;
//using System.Collections.Generic;
//namespace TimusProblems
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var input = Console.ReadLine().Split(' ');
//            Power(Convert.ToInt32(input[0]), Convert.ToInt32(input[1]), Convert.ToInt32(input[2]));
//        }
//        static void Power(int N, int M, int Y)
//        {
//            var interval = M - 1;
//            var res = new List<int>();
//            for (int i = 0; i <= interval; i++)
//            {
//                if (power(i, N, M) == Y)
//                {
//                    res.Add(i);
//                }
//            }
//            if (res.Count == 0)
//            {
//                Console.WriteLine(-1);
//            }
//            else
//            {
//                foreach (var r in res)
//                {
//                    Console.Write(r + " ");
//                }
//            }
//        }
//        static int power(int x, int y, int p)
//        {
//            int res = 1;
//            x = x % p;
//            while (y > 0)
//            {
//                if ((y & 1) == 1)
//                    res = (res * x) % p;
//                y = y >> 1;
//                x = (x * x) % p;
//            }
//            return res;
//        }
//    }
//}
#endregion
#region 1607
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static int dig = 1;

//    static void Main()
//    {
//        var nn = Console.ReadLine();
//        var sp = nn.Split(' ');
//        var a = Convert.ToInt32(sp[0]);
//        var b = Convert.ToInt32(sp[1]);
//        var c = Convert.ToInt32(sp[2]);
//        var d = Convert.ToInt32(sp[3]);
//        int e = 0;

//        if (a<=c)
//        {
//            while (a <= c)
//            {


//                if (a + b <= c)
//                {
//                    a = a + b;
//                    e = a;
//                }
//                else
//                {
//                    e = c;
//                    break;
//                }
//                if (c - d >= a)
//                {
//                    c = c - d;
//                    e = c;
//                }
//                else
//                {
//                    e = a;
//                    break;
//                }

//            } 
//        }
//        else
//        {
//            Console.WriteLine(a);
//            return;
//        }
//        Console.WriteLine(e);
//    }
//}
#endregion{
#region 1313 
//using System;
//using System.Collections.Generic;
//namespace TimusProblems
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var n = Convert.ToInt32(Console.ReadLine());
//            int[,] matric = new int[n, n];
//            for (int i = 0; i < n; i++)
//            {
//                var sp = Console.ReadLine().Split(' ');
//                for (int j = 0; j < n; j++)
//                {
//                    matric[i, j] = Convert.ToInt32(sp[j]);
//                }
//            }
//            int k = 0;
//            int l = k;
//            int d = 0;

//            while (k!=n)
//            {
//                while (l>=0)
//                {
//                    Console.Write(matric[l--,d++]+" ");
//                }
//                k++;
//                d = 0;
//                l = k;
//            }
//            k = 1;
//            l = n-1;
//            d = k;

//            while (k != n)
//            {
//                while (l > 0&&d!=n)
//                {
//                    Console.Write(matric[l--, d++]+ " ");
//                }
//                k++;
//                l = n-1;
//                d = k;
//            }
//        }

//    }
//}
#endregion
#region 2141
//using System;
//namespace TimusProblems
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var n = (Console.ReadLine());
//            var m = n.Split(' ');
//            long[] aaa = new long[3];
//            long a, b, c;
//            long x, y, z;
//            for (int i = 0; i < aaa.Length; i++)
//            {
//                aaa[i] = Convert.ToInt64(m[i]);
//            }
//            a = aaa[0];
//            b = aaa[1];
//            c = aaa[2];
//            var nn = (Console.ReadLine());
//            var mm = nn.Split(' ');
//            long[] aaaa = new long[3];
//            for (int i = 0; i < aaaa.Length; i++)
//            {
//                aaaa[i] = Convert.ToInt64(mm[i]);
//            }
//            x = aaaa[0];
//            y = aaaa[1];
//            z = aaaa[2];


//            if (x - a >= 0)
//            {
//                if (x - a <= c)
//                {
//                    c -= x - a;
//                    a += x - a;
//                }
//                else
//                {
//                    Console.WriteLine("There are no miracles in life");

//                    return;
//                }
//            }

//            if (y - b >= 0)
//            {
//                if (y - b <= c)
//                {
//                    c -= y - b;
//                    b += y - b;
//                }
//                else
//                {
//                    Console.WriteLine("There are no miracles in life");

//                    return;
//                }
//            }

//            if (c < z)
//            {
//                if (a - x >= 0)
//                {
//                    z -= a - x;
//                }

//                if (b - y >= 0)
//                {
//                    z -= b - y;
//                }
//            }
//            if (c >= z)
//            {
//                Console.WriteLine("It is a kind of magic");
//                return;
//            }
//            Console.WriteLine("There are no miracles in life");

//            return;
//        }
//    }

//}

#endregion
#region 1319
//using System;
//using System.Collections.Generic;
//namespace TimusProblems
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var n = Convert.ToInt32(Console.ReadLine());
//            int[,] matric = new int[n, n];
//            int count = 1;

//            int k = n-1;
//            int l = 0;
//            int d = n-1;

//            while (k >= 0)
//            {
//                while (l <= n-1)
//                {
//                    matric[l, d] = count;
//                    if (d + 1 >= n) { count++; break; }
//                    d++;
//                    l++;
//                    count++;
//                }
//                k--;
//                d = k;
//                l = 0;
//            }
//              k = 1;
//              l = 1;
//              d = 0;

//            while (k < n)
//            {
//                while (l < n )
//                {
//                    matric[l++, d] = count;
//                    if (d + 1 >= n) { count++; break; }
//                    d++;
//                    count++;
//                }
//                k++;
//                d = 0;
//                l = k;
//            }
//            for (int i = 0; i < n; i++)
//            {
//                for (int j = 0; j < n; j++)
//                {
//                    Console.Write(matric[i,j]+" ");
//                }
//                Console.WriteLine();
//            }
//        }


//    }
//}
#endregion
#region 1581
//using System;
//using System.Collections.Generic;
//namespace TimusProblems
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var n = Convert.ToInt32(Console.ReadLine());
//            var m = Console.ReadLine().Split(' ');
//            int[] arrLength = new int[n];
//            for (int j = 0; j < n; j++)
//            {
//                arrLength[j] = Convert.ToInt32(m[j]);
//            }
//            int count = 1;
//            int start = arrLength[0];

//            for (int i = 1; i < arrLength.Length; i++)
//            {
//                start = arrLength[i];
//                if (start == arrLength[i - 1])
//                {
//                    count++;
//                }
//                else
//                {
//                    Console.Write(count + " " + arrLength[i - 1] + " ");
//                    count = 1;
//                }
//            }
//            Console.Write(count + " " + arrLength[n - 1] + " ");

//        }
//    }
//}
#endregion
#region 1585
//using System;
//using System.Collections.Generic;
//namespace TimusProblems
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var n = Convert.ToInt32(Console.ReadLine());

//            int[] E_M_L = new int[3];
//            for (int i = 0; i < n; i++)
//            {
//               var s= Console.ReadLine();
//                if (s.Substring(0,1)=="E")
//                {
//                    E_M_L[0]++;
//                }
//                else if (s.Substring(0, 1) == "M")
//                {
//                    E_M_L[1]++;
//                }
//                else if (s.Substring(0, 1) == "L")
//                {
//                    E_M_L[2]++;
//                }
//            }
//            if (E_M_L[0] > E_M_L[1])
//            {
//                if (E_M_L[0] > E_M_L[2])
//                {
//                    Console.WriteLine("Emperor Penguin");
//                }
//                else
//                {
//                    Console.WriteLine("Little Penguin");
//                }
//            }
//            else if (E_M_L[1]>E_M_L[2])
//            {
//                Console.WriteLine("Macaroni Penguin");

//            }
//            else
//            {
//                Console.WriteLine("Little Penguin");
//            }
//        }
//    }
//}
#endregion
#region 1876
//using System;
//using System.Collections.Generic;
//namespace TimusProblems
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var n = (Console.ReadLine().Split(' '));


//            int[] dd = new int[2];
//            dd[0] = Convert.ToInt32(n[0]);
//            dd[1] = Convert.ToInt32(n[1]);
//            if (39 + 2 * dd[0] > 40 + 2 * dd[1])

//            {
//                Console.WriteLine(2 * dd[0] + 39);
//            }
//            else
//            {
//                Console.WriteLine(2 * dd[1] + 40);

//            }
//        }
//    }
//}
#endregion
#region 1496
//using System;
//using System.Collections.Generic;
//namespace TimusProblems
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var n = Convert.ToInt32(Console.ReadLine());
//            string[] spamerList = new string[n];
//            List<string> list = new List<string>();
//            for (int i = 0; i < spamerList.Length; i++)
//            {
//                spamerList[i] = Console.ReadLine();
//            }
//            for (int i = 0; i < spamerList.Length; i++)
//            {
//                var t = spamerList[i];
//                for (int j = 1; j < spamerList.Length; j++)
//                {
//                    if (t == spamerList[j]&&i!=j)
//                    {
//                       if( !list.Contains(t))
//                        {
//                            list.Add(t);
//                        }
//                    }
//                }
//            }
//            for (int i = 0; i < list.Count; i++)
//            {
//                Console.WriteLine(list[i]);
//            }

//        }
//    }
//}
#endregion
#region 1545
//using System;
//using System.Collections.Generic;
//namespace TimusProblems
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            ushort n = ushort.Parse(Console.ReadLine());
//            string[] a = new string[n];
//            for (ushort i = 0; i <= n - 1; i++)
//            {
//                a[i] = Console.ReadLine();
//            }
//            string b = Console.ReadLine();

//            foreach (string d in a)
//            {
//                if (d.Substring(0, 1) == b) 
//                    Console.WriteLine(d);
//            }
//            Console.ReadLine();
//        }
//    }

//}
#endregion
#region 1100 
//using System;

//namespace TimusProblems
//{
//    class Program
//    {

//        static void Main(string[] args)
//        {
//            var n = Convert.ToInt32(Console.ReadLine());
//            var firstArr = new long[n];
//            long[] secondArr = new long[n];
//            for (int i = 0; i < n; i++)
//            {
//                var tt = Console.ReadLine().Split(' ');
//                firstArr[i] = Convert.ToInt64(tt[0]);
//                secondArr[i] = Convert.ToInt64(tt[1]);
//            }
//            for (int i = 100; i >= 0; i--)
//            {
//                for (int j = 0; j < n; j++)
//                {
//                    if (secondArr[j] == i)
//                        Console.WriteLine(firstArr[j] + " " + secondArr[j]);
//                }
//            }
//        }
//    }
//}






#endregion
#region 1493
//using System;

//namespace TimusProblems
//{
//    class Program
//    {

//        static void Main(string[] args)
//        {

//          var n= Convert.ToInt32(Console.ReadLine());
//            int a, b, c;

//                c = (n - 1) % 10;
//                b = (n - 1) / 10 % 10;
//                a = (n - 1) / 100 % 10;
//                int x, y, z;
//                z = (n - 1) / 1000 % 10;
//                y = (n - 1) / 10000 % 10;
//                x = (n - 1) / 100000 % 10;
//            if ((x + y + z - (c + b + a)) == 0)
//            {
//                Console.WriteLine("Yes");
//                return;
//            }
//            else
//            {
//                int a1, b1, c1;
//                c1 = (n + 1) % 10;
//                b1 = (n + 1) / 10 % 10;
//                a1 = (n + 1) / 100 % 10;
//                int x1, y1, z1;
//                z1 = (n + 1) / 1000 % 10;
//                y1 = (n + 1) / 10000 % 10;
//                x1 = (n + 1) / 100000 % 10;
//                if (x1 + y1 + z1 == a1 + b1 + c1)
//                {
//                    Console.WriteLine("Yes");
//                    return;
//                }
//                else
//                {
//                    Console.WriteLine("No");
//                    return;
//                }
//            }



//        }

//    }
//}
#endregion
#region 2056
//using System;

//namespace TimusProblems
//{
//    class Program
//    {

//        static void Main(string[] args)
//        {

//            var n = Convert.ToInt32(Console.ReadLine());
//            int[] states = new int[n];
//            bool tt = false;
//            float sum = 0;
//            for (int i = 0; i < n; i++)
//            {
//                states[i] = Convert.ToInt32(Console.ReadLine());
//                if (states[i] == 3)
//                {
//                    tt = true;
//                }

//                sum += states[i];
//            }
//            if (tt == true)
//            {
//                Console.WriteLine("None");
//                return;
//            }
//            if (sum/n==5)
//            {
//                Console.WriteLine("Named");
//                return;
//            }

//            if (sum / n >= 4.5)
//            {
//                Console.WriteLine("High");
//                return;
//            }

//            Console.WriteLine("Common");

//        }

//    }
//}
#endregion
#region 1327
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace TimusProblems
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var A = Convert.ToInt32(Console.ReadLine());
//            var B = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine((B-A+(A%2)+(B%2))/2);
//        }


//    }
//}
#endregion
#region 1991
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace TimusProblems
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var nn = Console.ReadLine().Split(' ');
//            var n = Convert.ToInt32(nn[0]);
//            var k = Convert.ToInt32(nn[1]);
//            long[] a = new long[n];
//            long ans1=0;
//            long ans2=0;

//            var mmm = (Console.ReadLine().Split(' '));
//            for (int i = 0; i < n; i++)
//            {
//                a[i] = Convert.ToInt64(mmm[i]);
//            }

//            for (int i = 0; i < n; i++)
//            {
//                if (a[i] > k)
//                {
//                    ans1 += (a[i] - k);
//                }
//                else
//                {
//                    ans2 += k - a[i];
//                }
//            }
//            Console.WriteLine(ans1+" "+ans2);

//        }
//    }
//}
#endregion
#region 2031
//using System;

//namespace TimusProblems
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var n =Convert.ToInt32(Console.ReadLine());
//            string[] arr = new string[]{ "16", "06", "68", "88" };
//            if (n <= 4)
//                for (int i = 0; i < n; i++)
//                {
//                    Console.WriteLine(arr[i]);

//                }
//            else
//            Console.WriteLine("Glupenky Pierre");

//        }
//    }
//}
#endregion
#region 1120
//using System;

//namespace TimusProblems
//{
//    class Program
//    {
//        public static bool isPrime(int p)
//        {
//            for (int i = 2; i <= Math.Sqrt(p); i++)
//            {
//                if (p % i == 0)
//                {
//                    return false;
//                }
//            }
//            if (p == 1)
//            {
//                return false;
//            }
//            return true;
//        }
//        static void Main(string[] args)
//        {
//            long sum = Convert.ToInt32(Console.ReadLine());
//            long n = (int)(1 + Math.Sqrt(1 + (4 * sum)) / 2)*2;
//            var sec = 0;
//            long i = 0;
//            int j = 1;
//            double nnn = 0;
//            int dd = 0;
//            if (sum <= 2)
//            {
//                Console.WriteLine(sum + " " + 1);
//                return;
//            }

//            while (sum != sec)
//            {
//                n--;

//                sec = 0;
//                dd = 0;
//                nnn = (double)((2 * sum) - (n * n) + n) / (2 * n);

//                if (Math.Floor(nnn) == nnn&&nnn>0)
//                {
//                    break;
//                }

//            }
//            var lll = 1 + (nnn - 1) ;
//            Console.WriteLine(nnn + " " + (n));
//        }
//    }
//}
#endregion
#region 1005
//using System;

//namespace TimusProblems
//{
//    class Program
//    {
//        // int x[23], a = 0, y[23], s = 1 << 30;
//      public static long sum(long[] x, int n,long[] y)
//        {
//            long s1 = 0, s2 = 0;
//            for (int i = 0; i < n; i++)
//                if (x[i] == 1) s1 += y[i];
//                else s2 += y[i];
//            return Math.Abs(s1 - s2);
//        }
//        static void Main(string[] args)
//        {
//            long s=1<<30;
//            var n = Convert.ToInt32(Console.ReadLine());
//            long[] x = new long[n];
//            long[] y = new long[n];
//            long v = 0;
//            long a = 0;
//            var m = Console.ReadLine().Split(' ');
//            for (int i = 0; i < n; i++) y[i] = Convert.ToInt32(m[i]);

//            for (int i = 1; i < (1 << n); i++)
//            {
//                v = i; a = 0;
//                while (v > 0)
//                {
//                    x[a++] = v % 2;
//                    v /= 2;
//                }
//                s = Math.Min(s, sum(x, n,y));
//            }
//            Console.WriteLine(s);
//        }
//    }
//}
#endregion
#region 1935
//using System;
//using System.Collections.Generic;

//namespace TimusProblems
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var n = Convert.ToInt32(Console.ReadLine());
//            var mm = Console.ReadLine().Split(' ');
//            List<long> array = new List<long>();
//            List<long> list = new List<long>();

//            for (int i = 0; i < n; i++)
//            {
//                array.Add(Convert.ToInt32(mm[i])) ;
//            }
//            array.Sort();

//            list.Add(array[0]);

//            for (int i = 1; i < n; i++)
//            {
//                if (array[i - 1] < array[i])
//                {
//                    list.Add(array[i]);
//                }
//                else
//                {
//                    list.Add(array[i - 1]);
//                }
//            }

//            list.Add(array[n - 1]);
//            long sum = 0;
//            for (int i = 0; i < list.Count; i++)
//            {
//                sum += list[i];
//            }
//            Console.WriteLine(sum);
//        }
//    }
//}
#endregion
#region 1638
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace TimusProblems
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var mm = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
//            long a, b, c, d;
//            a = mm[0];
//            b = mm[1];
//            c = mm[2];
//            d = mm[3];
//            if(c<d)
//            Console.WriteLine(Math.Abs(c-d)*2*b+((Math.Abs(c-d)-1)*a));
//            else Console.WriteLine((2*a)+Math.Abs(c - d) * 2 * b + ((Math.Abs(c - d) - 1) * a));
//        }
//    }
//}
#endregion
#region 2070 
//using System;
//using System.Collections.Generic;
//using System.Linq;
//namespace TimusProblems
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            InterestingNumbers();
//        }
//        static void InterestingNumbers()
//        {
//            long[] PrimeNumbers = MakeSieve(1000000);
//            PrimeNumbers[78498] = 1000003;
//            var LR = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
//            long l = LR[0];
//            long r = LR[1];
//            long ans = r - l + 1;
//            for (long i = 0; PrimeNumbers[i] * PrimeNumbers[i] <= r && i < PrimeNumbers.Length; i++)
//            {
//                long exp = 0;
//                long mul = 1;
//                long j = 1;
//                while (mul < r)
//                {
//                    while (j < PrimeNumbers.Length && exp++ < PrimeNumbers[j] - 1)
//                    {
//                        mul *= PrimeNumbers[i];
//                        if (mul > r)
//                            break;
//                    }
//                    if (mul >= l && mul <= r)
//                        ans--;
//                    else if (mul > r)
//                        break;
//                    j++;
//                    mul *= PrimeNumbers[i];
//                }
//            }
//            Console.WriteLine(ans);
//        }
//        static long[] MakeSieve(int max)
//        {
//            long N = 0;
//            var is_prime = new Dictionary<long, bool>();
//            var primes = new long[1000000];
//            for (long i = 1; i <= max; i++) is_prime[i] = true;
//            for (long i = 2; i <= max; i++)
//            {
//                if (is_prime[i])
//                {
//                    primes[N++] = i;
//                    for (long j = i * i; j <= max; j += i)
//                    {
//                        is_prime[j] = false;
//                    }
//                }
//            }
//            return primes;
//        }
//    }
//}
#endregion
#region 1083
//using System;
//namespace ConsoleApp32
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string[] vvod = Console.In.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
//            int n = int.Parse(vvod[0]);
//            string k1 = vvod[1];
//            int k = k1.Length;
//            int q = 1;

//            for (int i = k + 7; i >= 0; i--)
//            {
//                int t;
//                t = n - i * k;
//                if (t > 0) q *= t;
//            }
//            Console.WriteLine(q);
//        }
//    }
//}
#endregion
#region 1180
//using System;
//namespace ConsoleApp32
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var s = Console.In.ReadToEnd().Trim();

//            long ans = 0;
//            for (int i = 0; i < s.Length; i++)
//            {
//                ans += s[i] - '0';
//            }
//            if (ans % 3 == 0) Console.WriteLine("2");
//            else Console.WriteLine("1" + "\n" + ans % 3);
//        }
//    }
//}
#endregion
#region 1203
//using System;
//using System.Linq;

//namespace ConsoleApp32
//{
//    class Program
//    {
//        static void heapify(long[] arr, int n, int i,long[] arr1)
//        {
//            int largest = i;
//            int left = 2 * i + 1;
//            int right = 2 * i + 2;
//            if (left < n && arr[left] > arr[largest])
//                largest = left;
//            if (right < n && arr[right] > arr[largest])
//                largest = right;
//            if (largest != i)
//            {
//                long swap = arr[i];
//                arr[i] = arr[largest];
//                arr[largest] = swap;
//                long sw = arr1[i];
//                arr1[i] = arr1[largest];
//                arr1[largest] = sw;
//                heapify(arr, n, largest,arr1);
//            }
//        }
//        static void Main(string[] args)
//        {
//            var n = Convert.ToInt32(Console.ReadLine());
//            var firstArr = new long[n];
//            long[] secondArr = new long[n];
//            var start = new long[n];
//            long[] end = new long[n];
//            int k = 0, m = 0;
//            for (int i = 0; i < n; i++)
//            {
//                var tt = Console.ReadLine().Split(' ');
//                start[i] = Convert.ToInt64(tt[0]);
//                end[i] = Convert.ToInt64(tt[1]);
//            }

//            for (int i = n / 2 - 1; i >= 0; i--)
//                heapify(end, n, i,start);
//            for (int i = n - 1; i >= 0; i--)
//            {
//                long temp = end[0];
//                end[0] = end[i];
//                end[i] = temp;
//                long ss = start[0];
//                start[0] = start[i];
//                start[i] = ss;
//                heapify(end, i, 0,start);
//            }


//            var bla = 0;
//            int ii = 0;
//            var count = 1;
//            while (ii < n)
//            {
//                while (bla < n && end[ii] >= start[bla])
//                {
//                    bla++;
//                }
//                ii = bla;
//                count++;
//            }
//            Console.WriteLine(count-1);

//        }
//    }
//}
#endregion
#region 1893
//using System;
//using System.Linq;

//namespace ConsoleApp32
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var n = (Console.ReadLine());
//            string number = "";
//            string state = "";
//            if (n.Length == 2)
//            {
//                number = n.Substring(0, 1);
//                state = n.Substring(1, 1);
//            }
//            else
//            {
//                number = n.Substring(0, 2);
//                state = n.Substring(2, 1);
//            }
//            if (Convert.ToInt32(number) > 0 && Convert.ToInt32(number) <= 2)
//            {
//                if (state == "B" || state == "C")
//                {
//                    Console.WriteLine("aisle");
//                }
//                else if (state == "A" || state == "D")
//                {
//                    Console.WriteLine("window");
//                }
//                else
//                {
//                    Console.WriteLine("neither");
//                }
//            }
//            else if (Convert.ToInt32(number) >= 3 && Convert.ToInt32(number) <= 20)
//            {


//                if (state == "A" || state == "F")
//                {
//                    Console.WriteLine("window");
//                }
//                else
//                {
//                    Console.WriteLine("aisle");
//                }
//            }
//            else if (Convert.ToInt32(number) >= 21 && Convert.ToInt32(number) <= 65)
//            {
//                if (state == "D" || state == "C" || state == "G" || state == "H")
//                {
//                    Console.WriteLine("aisle");
//                }
//                else if (state == "A" || state == "K")
//                {
//                    Console.WriteLine("window");
//                }
//                else
//                {
//                    Console.WriteLine("neither");

//                }
//            }
//            else
//            {
//                Console.WriteLine("neither");
//            }
//        }
//    }
//}
#endregion
#region 1354 
//using System;
//using System.Globalization;

//namespace AlgorthmDataStructure
//{
//    public class MyClass
//    {
//        static void Main(string[] args)
//        {
//            var StringLine = (Console.ReadLine());
//            var k = 1;
//            var n = StringLine.Length - 1;
//            string s1 = StringLine[0].ToString(); ;
//            int i = 0;
//            while (true)
//            {
//                i = 0;
//                while ((n - i >= k + i) && (StringLine[k + i] == StringLine[n - i]))
//                {
//                    i++;
//                }
//                if (n - i <= k + i)
//                {
//                    Console.WriteLine((StringLine + s1));
//                    return;
//                }
//                s1 = StringLine[k] + s1;
//                k++;
//            }
//        }

//    }
//}
#endregion
#region 1224
//using System;
//using System.Globalization;
//using System.Linq;

//namespace AlgorthmDataStructure
//{
//    public class MyClass
//    {
//        static void Main(string[] args)
//        {
//            var nn = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
//            long N = nn[0];
//            long M = nn[1];
//            if (N > M)
//            {
//                Console.WriteLine((2 * (M - 1))+1);

//            }
//            else
//            {
//                Console.WriteLine(2*(N-1));
//            }

//        }
//    }
//}
#endregion
#region  1563                            Bayan
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;

//namespace AlgorthmDataStructure
//{
//    public class MyClass
//    {
//        static void Main(string[] args)
//        {
//            var nn = Convert.ToInt32(Console.ReadLine());
//            int count = 0;
//            string[] arrayString = new string[nn];
//            arrayString[0] = Console.ReadLine(); ;
//            for (int i = 1; i < nn; i++)
//            {
//                int j = i-1;
//                arrayString[i] = Console.ReadLine();
//                while (j >= 0)
//                {
//                    if (arrayString[i] == arrayString[j])
//                    {
//                        count++;
//                        break;
//                    }
//                    j--;
//                }

//            }
//            Console.WriteLine(count); ;
//        }
//    }
//}
#endregion
#region 1881                    Long problem Statement
//using System;
//using System.Linq;

//namespace AlgorthmDataStructure
//{
//    public class MyClass
//    {
//        static void Main(string[] args)
//        {
//            var nn = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
//            int count = 1;
//            long h = nn[0];
//            long w = nn[1];
//            long n = nn[2];
//            long line = 0;
//            int tt = 0;
//            long lineChekerToend = 0;

//            for (int i = 0; i < n; i++)
//            {

//                tt = Console.ReadLine().Length + 1;
//                lineChekerToend += tt;
//                if (w >= lineChekerToend-1)
//                {
//                }
//                else
//                {
//                    lineChekerToend = tt;
//                    line++;
//                }
//                if (line == h)
//                {
//                    count++;
//                    line = 0;

//                }

//            }
//            Console.WriteLine(count);

//        }
//    }
//}
#endregion
#region 1837                    Isenbaev's Number ?
//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;

//namespace AlgorthmDataStructure
//{
//    public class MyClass
//    {
//        static void Main(string[] args)
//        {
//            Dictionary<string, int> dict = new Dictionary<string, int>();
//            var n = Convert.ToInt32(Console.ReadLine());
//            string[] groupisa = new string[n];
//            dict.Add("Isenbaev",0);
//            for (int i = 0; i < n; i++)
//            {
//                groupisa[i] = Console.ReadLine();
//                var t = groupisa[i].Split(' ');
//                if (!dict.ContainsKey(t[0]))
//                {
//                    dict.Add(t[0], 0);
//                }
//                if (!dict.ContainsKey(t[1]))
//                {
//                    dict.Add(t[1], 0);
//                }
//                if (!dict.ContainsKey(t[2]))
//                {
//                    dict.Add(t[2], 0);
//                }
//            }
//            for (int i = 0; i < n; i++)
//            {

//            }

//        }
//    }
//}
#endregion
#region 1149.                    Sinus Dances ?

#endregion
#region 1925                British Scientists Save the World
//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;

//namespace AlgorthmDataStructure
//{
//    public class MyClass
//    {
//        static void Main(string[] args)
//        {
//            var n = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
//            var nn = n[0];
//            var k = n[1];
//            long sum1=0;
//            long sum2=0;
//            for (int i = 0; i < nn; i++)
//            {
//                var ns = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
//                sum1 += ns[0];
//                sum2 += ns[1];
//            }
//            sum1 =sum1+k-(2*(nn+1));
//           var x = sum1 - sum2;
//            if (x > 0)
//            {
//                Console.WriteLine(x);
//            }
//            else
//            {
//                Console.WriteLine("Big Bang!");
//            }

//        }
//    }
//}
#endregion
#region 1617                 Flat Sports
//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;

//namespace AlgorthmDataStructure
//{
//    public class MyClass
//    {
//        static void Main(string[] args)
//        {
//            var n =Convert.ToInt32(Console.ReadLine());
//            List<long> list = new List<long>();
//            int count = 0;
//            for (int i = 0; i < n; i++)
//            {
//                list.Add(Convert.ToInt64(Console.ReadLine()));
//            }
//            list.Sort();
//            for (int i = 0; i < n-3; i++)
//            {
//                if (list[i] ==list[i + 3])
//                {
//                    count++;
//                    if (i+3<n)
//                    {
//                        i += 3;
//                    }
//                }
//            }
//            Console.WriteLine(count); ;

//        }
//    }
//}
#endregion
#region 2035                            Another Dress Rehearsal
//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;

//namespace AlgorthmDataStructure
//{
//    public class MyClass
//    {
//        static void Main(string[] args)
//        {
//            var n = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
//            var X = n[0];
//            var Y = n[1];
//            var C = n[2];
//            //if (C == 0)
//            //{
//            //    Console.WriteLine(0+" "+0);
//            //    return;
//            //}
//            if (X >= C && Y >= C)
//            {
//                Console.WriteLine(0+" "+C);
//                    return;
//            }
//            if (X+Y<C)
//            {
//                Console.WriteLine("Impossible");
//                return;
//            }
//            else if (X < Y)
//            {
//                Console.WriteLine(X+" "+(C-X));
//            }
//            else if(X>Y)
//            {
//                Console.WriteLine((C-Y)+" "+Y);
//            }
//            else
//            {
//                Console.WriteLine(C+" "+0);
//            }
//        }
//    }
//}
#endregion
#region 1723.                           Sandro's Book
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace AlgorthmDataStructure
//{
//    public class MyClass
//    {
//        static void Main(string[] args)
//        {


//            Console.WriteLine((from u in Console.ReadLine().ToArray()
//                               group u by u into gg
//                               orderby gg.Count() descending
//                               select gg.Key).ToList()[0]);
//        }
//    }
//}
#endregion
#region 1457.                   Heating Main
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace AlgorthmDataStructure
//{
//    public class MyClass
//    {
//        static void Main(string[] args)
//        {
//            var n = Convert.ToInt32(Console.ReadLine());
//            var mm = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
//            double[] buffer = new double[n];
//            double sum = 0;
//            for (int i = 0; i < mm.Length; i++)
//            {
//                buffer[i] = mm[i];
//            }
//            for (int i = 0; i < n; i++)
//            {
//                sum += buffer[i] / n;
//            }
//            var sumt = String.Format("{0:0.000000}", sum);
//            Console.WriteLine(sumt);
//        }
//    }
//}
#endregion
#region 1025.                   Democracy in Danger
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace AlgorthmDataStructure
//{
//    public class MyClass
//    {
//        static void Main(string[] args)
//        {
//            var n = Convert.ToInt32(Console.ReadLine());
//            var buffer = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
//            List<long> list = new List<long>();
//            for (int i = 0; i < n; i++)
//            {
//                list.Add(buffer[i]);
//            }
//            list.Sort();
//            long sum = 0;
//            for (int i = 0; i < n/2+1; i++)
//            {
//                sum += (list[i] + 1) / 2;
//            }
//            Console.WriteLine(sum);

//        }
//    }
//}
#endregion
#region 1654.                   Cipher Message
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace AlgorthmDataStructure
//{
//    public class MyClass
//    {
//        static void Main(string[] args)
//        {
//            var n = (Console.ReadLine());
//            Stack<char> stack = new Stack<char>();

//            int j = 1;

//            for (int i = 0; i < n.Length; i++)
//            {
//                var temp = stack.Count == 0 ? '0' : stack.Peek();

//                if (temp != n[i])
//                {
//                    stack.Push(n[i]);
//                }
//                else
//                {
//                    stack.Pop();
//                }
//            }
//            var t = stack.Count;
//            char[] result = new char[t];

//            for (int i = t-1; i >=0; i--)
//            {
//                result[i] = stack.Pop();
//            }
//            Console.WriteLine(new string(result));


//        }
//    }
//}
#endregion
#region 1134.                   Cards  
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace AlgorthmDataStructure
//{
//    public class MyClass
//    {
//        static void Main(string[] args)
//        {
//            var nn = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//            int n = nn[0];
//            int m = nn[1];
//            var cards = Console.In.ReadToEnd().Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
//            cards.Sort();
//            if (m > n)
//            {
//                Console.WriteLine("NO");
//                return;
//            }
//            int[] count = new int[n + 1000];
//            count[0] = 1;
//            count[n] = 1;

//            for (int i = 1; i <= n - 1; i++)
//            {
//                count[i] = 2;
//            }
//            if (cards[0] != 0)
//                count[cards[0] - 1] = 1;

//            for (int i = 0; i < cards.Count; i++)
//            {
//                if (cards[i] == 0)
//                {
//                    if (count[i] <= 0)
//                    {
//                        Console.WriteLine("NO");
//                        return;
//                    }
//                    else
//                    {
//                        --count[i];
//                        --count[i + 1];
//                        continue;
//                    }
//                }
//                if (cards[i] == n)
//                {
//                    if (count[cards[i]] <= 0 )
//                    {
//                        Console.WriteLine("NO");
//                        return;
//                    }
//                    else
//                    {
//                        --count[cards[i]];
//                        continue;
//                    }                                    //1 2 3 3 4
//                }                                       // 1 2 2 2 1
//                if (count[cards[i]] > 0 && (count[cards[i] + 1] > 0 || count[cards[i] - 1] > 0))
//                {
//                    --count[cards[i]];
//                    if (count[cards[i] - 1] > 0)
//                    {
//                        --count[cards[i] - 1];
//                    }
//                    else if (count[cards[i] + 1] > 0)
//                    {
//                        --count[cards[i] + 1];
//                    }
//                    else
//                    {
//                        Console.WriteLine("NO");
//                        return;

//                    }
//                }
//                else
//                {
//                    Console.WriteLine("NO");
//                    return;
//                }
//            }
//            Console.WriteLine("YES");
//        }
//    }
//}
#endregion
#region 2002.               Test Task
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace AlgorthmDataStructure
//{
//    public class MyClass
//    {
//        static void Main(string[] args)
//        {
//            List<string> Registr = new List<string>();
//            List<string> LogIn = new List<string>();
//            List<string> pass = new List<string>();
//            List<string> username = new List<string>();
//            List<string> drel = new List<string>();
//            List<string> logout = new List<string>();

//            var n = Convert.ToInt32(Console.ReadLine());
//            for (int i = 0; i < n; i++)
//            {
//                var tt = Console.ReadLine();
//                if (tt.Split(' ')[0] == "register")
//                {
//                    if (username.Contains(tt.Split(' ')[1]))
//                    {
//                        Console.WriteLine("fail: user already exists");
//                        continue;
//                    }
//                    else
//                    {

//                        Registr.Add(tt.Split(' ')[1] + " " + tt.Split(' ')[2]);
//                        pass.Add(tt.Split(' ')[2]);
//                        username.Add(tt.Split(' ')[1]);
//                        Console.WriteLine("success: new user added");
//                        continue;
//                    }
//                }
//                else if (tt.Split(' ')[0] == "login")
//                {
//                    if (username.Contains(tt.Split(' ')[1]))
//                    {
//                        if (pass.Contains(tt.Split(' ')[2]))
//                        {
//                            if (Registr.Contains(tt.Split(' ')[1] + " " + tt.Split(' ')[2]))
//                            {
//                                if (!LogIn.Contains(tt.Split(' ')[1]))
//                                {
//                                    LogIn.Add((tt.Split(' ')[1]));
//                                    drel.Add(tt.Split(' ')[1]);
//                                    if (logout.Contains(tt.Split(' ')[1]))
//                                    {
//                                        logout.Remove(tt.Split(' ')[1]);
//                                    }
//                                    Console.WriteLine("success: user logged in");
//                                    continue;
//                                }
//                                else
//                                {
//                                    Console.WriteLine("fail: already logged in");
//                                    continue;
//                                }
//                            }
//                            else
//                            {
//                                Console.WriteLine("fail: incorrect password");
//                                continue;
//                            }
//                        }
//                        else
//                        {
//                            Console.WriteLine("fail: incorrect password");
//                            continue;
//                        }
//                    }
//                    else
//                    {
//                        Console.WriteLine("fail: no such user");
//                        continue;
//                    }
//                }
//                else if (tt.Split(' ')[0] == "logout")
//                {
//                    if (username.Contains(tt.Split(' ')[1]))
//                    {
//                        if (drel.Contains(tt.Split(' ')[1]))
//                        {
//                            if (logout.Contains(tt.Split(' ')[1]))
//                            {
//                                Console.WriteLine("fail: already logged out");
//                                continue;
//                            }
//                            else
//                            {
//                                Console.WriteLine("success: user logged out");
//                                logout.Add(tt.Split(' ')[1]);
//                                LogIn.Remove(tt.Split(' ')[1]);
//                                continue;
//                            }

//                        }
//                        else
//                        {
//                            Console.WriteLine("fail: already logged out");
//                            continue;
//                        }
//                    }
//                    else
//                    {
//                        Console.WriteLine("fail: no such user");
//                        continue;
//                    }
//                }
//            }
//        }
//    }
//}
#endregion
#region 1636.                   Penalty Time
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace AlgorthmDataStructure
//{
//    public class MyClass
//    {
//        static void Main(string[] args)
//        {
//            var n = (Console.ReadLine()).Split(' ').Select(long.Parse).ToArray();
//            var t1 = n[0];
//            var t2 = n[1];
//            var nn = (Console.ReadLine()).Split(' ').Select(long.Parse).ToArray();
//            long sum = 0;
//            for (int i = 0; i < 10; i++)
//            {
//                sum += nn[i] * 20;
//            }
//            if (sum+t1<=t2)
//            {
//                Console.WriteLine("No chance.");
//            }
//            else
//            {
//                Console.WriteLine("Dirty debug :(");
//            }
//        }
//    }
//}
#endregion
#region 1196.          History Exam  
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace AlgorthmDataStructure
//{
//    public class MyClass
//    {
//        public static int binarySearch(int[] A, int n, int x)
//        {
//            int low, high, mid;
//            low = 0;
//            high = n - 1;

//            while (low <= high)
//            {
//                mid = (low + high) / 2;
//                if (x == A[mid]) return (mid);
//                else if (x < A[mid]) high = mid - 1;
//                else low = mid + 1;
//            }
//            return (-1);
//        }
//        static void Main(string[] args)
//        {
//            int n;
//            int[] a = new int[100000];
//            int m, counter = 0;
//            int b;
//            n = Convert.ToInt32(Console.ReadLine());
//            for (int i = 0; i < n; i++)
//                a[i] = Convert.ToInt32(Console.ReadLine());
//            m = Convert.ToInt32(Console.ReadLine());
//            for (int i = 0; i < m; i++)
//            {
//                b = Convert.ToInt32(Console.ReadLine());
//                if (binarySearch(a, n, b) != -1)
//                    counter++;
//            }
//            Console.WriteLine(counter); ;
//        }
//    }
//}
#endregion
#region 2025.               Line Fighting
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace AlgorthmDataStructure
//{
//    public class MyClass
//    {
//        static void Main(string[] args)
//        {

//            int N, n, k, i, a, b, x, res;
//             N= Convert.ToInt32(Console.ReadLine());
//            for (i = 0; i < N; i++)
//            {
//                var tt = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//                n=tt[0];
//                k = tt[1];
//                if (n % k == 0)
//                {
//                    x = n / k;
//                    res = n * (n - x) / 2;
//                    Console.WriteLine(res);
//                }
//                else
//                {
//                    x = n / k;
//                    b = n - k * x;
//                    a = k - b;
//                    res = ((n - x) * a * x + (n - x - 1) * (x + 1) * b) / 2;
//                    Console.WriteLine(res);
//                }
//            }
//        }
//    }
//}
#endregion
#region 1786.                                    Sandro's Biography
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace AlgorthmDataStructure
//{
//    public class MyClass
//    {
//        static void Main(string[] args)
//        {
//            var name = Console.ReadLine();
//            int count = 0;
//            int indexer = 0;
//            int position = 1000;
//            int gold = 1000;
//            int[] buffer = new int[name.Length / 6 + 5];
//            for (int i = 0; i <= name.Length-6; i++)
//            {
//                gold = 0;
//                var temString = name.Substring(i, 6);
//                for (int j = 0; j < temString.Length; j++)
//                {
//                    if (j == 0)
//                    {
//                        if (temString[j] == 'S')
//                        {

//                        }
//                        else if (temString[j] == 's')
//                        {
//                            gold += 5;
//                        }
//                        else
//                        {
//                            if (char.IsLower(temString[j]))
//                            {
//                                gold += 10;

//                            }
//                            else
//                            {
//                                gold += 5;
//                            }
//                        }
//                    }
//                    else if (j == 1)
//                    {
//                        if (temString[j] == 'a')
//                        {

//                        }
//                        else if (char.IsLower(temString[j])|| temString[j]=='A')
//                        {
//                            gold += 5;
//                        }
//                        else
//                        {
//                            gold += 10;
//                        }
//                    }
//                    else if (j == 2)
//                    {
//                        if (temString[j] == 'n')
//                        {

//                        }
//                        else if (char.IsLower(temString[j]) || temString[j] == 'N')
//                        {
//                            gold += 5;
//                        }
//                        else
//                        {
//                            gold += 10;
//                        }
//                    }
//                    else if (j == 3)
//                    {
//                        if (temString[j] == 'd')
//                        {

//                        }
//                        else if (char.IsLower(temString[j]) || temString[j] == 'D')
//                        {
//                            gold += 5;
//                        }
//                        else
//                        {
//                            gold += 10;
//                        }
//                    }
//                    else if (j == 4)
//                    {
//                        if (temString[j] == 'r')
//                        {

//                        }
//                        else if (char.IsLower(temString[j]) || temString[j] == 'R')
//                        {
//                            gold += 5;
//                        }
//                        else
//                        {
//                            gold += 10;
//                        }
//                    }
//                    else if (j == 5)
//                    {
//                        if (temString[j] == 'o')
//                        {

//                        }
//                        else if (char.IsLower(temString[j]) || temString[j] == 'O')
//                        {
//                            gold += 5;
//                        }
//                        else
//                        {
//                            gold += 10;
//                        }
//                    }
//                }
//                position = Math.Min(position, gold);
//            }
//            Console.WriteLine(position);
//        }
//    }
//}
#endregion
#region 1902.                    Neo-Venice
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace AlgorthmDataStructure
//{
//    public class MyClass
//    {
//        static void Main(string[] args)
//        {
//            var df = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
//            var n = df[0];
//            var t = df[1];
//            var s = df[2];
//            double sum = 0;
//            var buffer = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
//            for (int i = 0; i < n; i++)
//            {
//                sum = 0;
//                if (s > buffer[i])
//                {
//                    var ssss = s - buffer[i];
//                    ssss = (t - ssss)/2;
//                    sum = ssss+s;
//                }
//                else
//                {
//                    var ssss = buffer[i] - s;
//                    ssss = (t - ssss) / 2;
//                    sum = ssss + buffer[i];
//                }


//                var sumt = String.Format("{0:0.000000}", sum);
//                Console.WriteLine(sumt);
//            }
//        }
//    }
//}
#endregion
#region 2033.                    Devices
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace AlgorthmDataStructure
//{
//    public class MyClass
//    {
//        static void Main(string[] args)
//        {

//            List<string> list = new List<string>();
//            for (int i = 0; i < 6; i++)
//            {
//                list.Add(Console.ReadLine() + " " + Console.ReadLine() + " " + Console.ReadLine());
//            }
//            var TempName = list[0].Split(' ')[1];
//            var TempPrice = Convert.ToInt64(list[0].Split(' ')[2]);
//            long Price = 0;

//            int count = 0;
//            int tempCount = 0;
//            string Name = "";
//            for (int i = 0; i < 6; i++)
//            {
//                tempCount = 0;
//                TempName= list[i].Split(' ')[1];
//                TempPrice = Convert.ToInt64(list[i].Split(' ')[2]);

//                for (int j = 0; j <6; j++)
//                {
//                    if (TempName == list[j].Split(' ')[1])
//                    {
//                        TempPrice = Math.Min(Convert.ToInt64(list[i].Split(' ')[2]),Convert.ToInt64(list[j].Split(' ')[2]));
//                        tempCount++;
//                    }
//                }
//                if (tempCount > count)
//                {
//                    Name = TempName;
//                    count = tempCount;
//                    Price = TempPrice;
//                }
//                else if(count==tempCount)
//                {
//                    if (TempPrice<Price)
//                    {
//                        Name = TempName;
//                        count = tempCount;
//                        Price = TempPrice;
//                    }
//                }

//            }
//            Console.WriteLine(Name);

//        }
//    }
//}
#endregion
#region 1214.             Strange Procedure
//using System;
//using System.Collections.Generic;
//using System.Linq;
//namespace AlgorthmDataStructure
//{
//    public class MyClass
//    {
//        static void Main(string[] args)
//        {
//            long x, y;
//            var ss = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
//            x = ss[0];
//            y = ss[1];
//            if (x <= 0 || y <= 0)
//                Console.WriteLine(x + " " + y);
//            else if ((x + y) % 2 != 0)
//                Console.WriteLine(y + " " + x);

//            else
//                Console.WriteLine(x + " " + y);

//        }
//    }
//}
#endregion
#region 2011.                    Long Statement
//using System;
//using System.Collections.Generic;
//using System.Linq;
//namespace AlgorthmDataStructure
//{
//    public class MyClass
//    {
//        public static void Main(string[] args)
//        {
//            var n = Convert.ToDouble(Console.ReadLine());
//            var buffer = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
//            double countA = 0;
//            double countB = 0;
//            double countC = 0;

//            for (int i = 0; i < buffer.Length; i++)
//            {
//                if (buffer[i] == 1)
//                {
//                        countA++;
//                }
//                else if (buffer[i] == 2)
//                {
//                        countB++;
//                }
//                else if (buffer[i] == 3)
//                {
//                        countC++;
//                }
//            }
//            var t = factorial_Recursion(n);
//            t = t / factorial_Recursion(countA);
//            t = t / factorial_Recursion(countB);
//            t = t / factorial_Recursion(countC);
//            if (t>=6)
//            {
//                Console.WriteLine("Yes");
//            }
//            else
//            {
//                Console.WriteLine("No");
//            }



//        }
//        public static double factorial_Recursion(double number)
//        {
//            double i, fact = 1;
//            for (i = 1; i <= number; i++)
//            {
//                fact = fact * i;
//            }
//            return fact;
//        }
//    }

//}
#endregion
#region 1796.             Amusement Park
//using System;
//using System.Collections.Generic;
//using System.Linq;
//namespace AlgorthmDataStructure
//{
//    public class MyClass
//    {
//        public static void Main(string[] args)
//        {
//            var n = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

//            var PriceTicket = Convert.ToInt64(Console.ReadLine());
//            var BankNotes = new int[] { 10, 50, 100, 500, 1000, 5000 };
//            long MinNotesIndex = 0;
//            long min = 0;
//            var minFirst = true;
//            long Money = 0;
//            for (int i = 0; i < 6; i++)
//            {
//                Money = Money + n[i] * BankNotes[i];
//                if (n[i] * BankNotes[i] != 0)
//                {
//                    if (minFirst)
//                    {
//                        MinNotesIndex = i;
//                        minFirst = false;
//                    }
//                }

//            }
//            long HowTicketTicherCanTake = Money / PriceTicket;
//            Money = 0;
//            n[MinNotesIndex] = n[MinNotesIndex] - 1;
//            for (int i = 0; i < 6; i++)
//            {
//                Money = Money + n[i] * BankNotes[i];
//                if (min > n[i] * BankNotes[i])
//                {
//                    min = n[i] * BankNotes[i];
//                }
//            }
//            long MinTicketTicherCanTake = Money / PriceTicket;
//            Console.WriteLine(HowTicketTicherCanTake - MinTicketTicherCanTake);
//            for (double i = MinTicketTicherCanTake + 1; i <= HowTicketTicherCanTake; i++)
//            {
//                Console.Write(i + " ");
//            }


//        }
//    }

//}
#endregion
#region 2068.           Game of Nuts
//using System;
//using System.Collections.Generic;
//using System.Linq;
//namespace AlgorthmDataStructure
//{
//    public class MyClass
//    {
//        public static void Main(string[] args)
//        {
//            bool WinerDaenerys = true;

//            var n = Convert.ToInt32(Console.ReadLine());
//            var Nants = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//            for (int i = 0; i < n; i++)
//            {
//                int temp = Nants[i] / 2;

//                if (temp % 2 == 0)
//                {
//                    WinerDaenerys = !WinerDaenerys;
//                }
//            }


//            if (!WinerDaenerys)
//            {
//                Console.WriteLine("Stannis");
//            }
//            else
//            {
//                Console.WriteLine("Daenerys");
//            }
//        }
//    }

//}
#endregion
#region 1404.               Easy to Hack!
//using System;
//using System.Collections.Generic;
//using System.Linq;
//namespace AlgorthmDataStructure
//{
//    public class MyClass
//    {
//        public static void Main(string[] args)
//        {
//            string letters = "abcdefghijklmnopqrstuvwxyz";
//            var n = Console.ReadLine();
//            var printIndex = "";
//            int t = 0;
//            int d = 0;
//            var m = 0;
//            bool first = true;
//            for (int i = 0; i < n.Length; i++)
//            {
//                for (int j = 0; j < letters.Length; j++)
//                {
//                    if (n[i] == letters[j])
//                    {
//                        if (first)
//                        {
//                            if (j < 5)
//                            {
//                                t = j;
//                                m = j + 26 - 5;
//                                first = false;
//                                Console.Write(letters[m]);
//                                continue;
//                            }
//                            else
//                            {
//                                t = j;
//                                m = t - 5;
//                                first = false;
//                                Console.Write(letters[m]);
//                                continue;
//                            }
//                        }
//                        if (t > j)
//                        {
//                            m = j + 26 - t;

//                            while (m < 0)
//                            {
//                                m += 26;
//                            }
//                            t = j + 26;
//                            d = j;
//                        }
//                        else
//                        {
//                            m = j + 26 - t;

//                            while (m < 0 || m > 25)
//                            {
//                                if (m < 0)
//                                {
//                                    m += 26;
//                                }
//                                else
//                                {
//                                    m -= 26;
//                                }
//                            }
//                            t = j;
//                        }




//                        Console.Write(letters[m]);
//                    }
//                }
//            }

//        }
//    }

//}



#endregion
#region 1731.                            Dilll
//using System;
//using System.Collections.Generic;
//using System.Linq;
//namespace AlgorthmDataStructure
//{
//    public class MyClass
//    {
//        public static void Main(string[] args)
//        {
//            var nm = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
//            var n = nm[0];
//            var m = nm[1];
//            for (int i = 1; i <= n; i++)
//            {
//                Console.Write(i + " ");
//            }
//            Console.WriteLine();
//            for (int i = 1; i <= m; i++)
//            {
//                Console.Write(i * (n + 1) + " ");
//            }


//        }
//    }

//}
#endregion
#region 1044.                  Lucky Tickets. Easy!
//using System;
//using System.Collections.Generic;
//using System.Linq;
//namespace AlgorthmDataStructure
//{
//    public class MyClass
//    {
//        static int N(int n, int k)
//        {
//            if (n == 1) return k < 10 ? 1 : 0;

//            int sum = 0;
//            for (int i = 0; i <= 9 && i <= k; i++)
//            {
//                sum += N(n - 1, k - i);
//            }
//            return sum;
//        }
//        public static void Main(string[] args)
//        {
//            int n, sum = 0, temp;
//            n = Convert.ToInt32(Console.ReadLine());
//            n /= 2;

//            for (int i = 0; i <= n * 9; i++)
//            {
//                temp = N(n, i);
//                sum += (temp * temp);
//            }

//            Console.WriteLine(sum);
//        }
//    }

//}
#endregion
#region 1139.                City Blocks
//using System;
//using System.Collections.Generic;
//using System.Linq;
//namespace AlgorthmDataStructure
//{
//    public class MyClass
//    {
//        static int GCD(int M,int N)
//        {
//            if (N == 0) return M;
//            if (M % N != 1)
//            {
//                M = M % N;
//                var t= GCD(N, M);
//                return t;
//            }
//            else
//            {
//                return GCD(1,0);
//            }
//        }
//        static int GCDD(int num1, int num2)
//        {
//            int Remainder;

//            while (num2 != 0)
//            {
//                Remainder = num1 % num2;
//                num1 = num2;
//                num2 = Remainder;
//            }

//            return num1;
//        }

//        public static void Main(string[] args)
//        {
//            var x1y1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//            var t = GCDD(x1y1[0]>x1y1[1]?x1y1[0]-1:x1y1[1]-1, x1y1[0] < x1y1[1] ? x1y1[0]-1 : x1y1[1]-1);
//            Console.WriteLine((x1y1[0]-1)+(x1y1[1]-1)-t);
//        }
//    }

//}
#endregion
#region 1792           Hamming Code
//using System;
//using System.Collections.Generic;
//using System.Linq;
//namespace AlgorthmDataStructure
//{
//    public class MyClass
//    {
//        public static void Main(string[] args)
//        {
//            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//            var petals = new bool[3] { true, true, true };
//            int count = 0;
//            if ((arr[0] + arr[1] + arr[3]) % 2 != arr[6])
//            {
//                petals[2] = false;
//                count++;

//            }
//            if ((arr[1] + arr[2] + arr[3]) % 2 != arr[4])
//            {
//                petals[0] = false;
//                count++;

//            }
//            if ((arr[0] + arr[2] + arr[3]) % 2 != arr[5])
//            {
//                petals[1] = false;
//                count++;
//            }
//            if (count == 0)
//            {
//                for (int i = 0; i < arr.Length; i++)
//                {
//                    Console.Write(arr[i] + " ");
//                }
//                return;
//            }
//            if (count == 3)
//            {
//                arr[3] = arr[3] == 0 ? 1 : 0;
//                for (int i = 0; i < arr.Length; i++)
//                {
//                    Console.Write(arr[i] + " ");
//                }
//                return;
//            }
//            int bla = 0; ;
//            if (count == 2)
//            {
//                for (int i = 0; i < 3; i++)
//                {
//                    if (petals[i] == true)
//                    {
//                        bla = i;
//                    }
//                }
//                arr[bla] = arr[bla] == 1 ? 0 : 1;
//                for (int i = 0; i < arr.Length; i++)
//                {
//                    Console.Write(arr[i] + " ");
//                }
//                return;
//            }
//            if (count == 1)
//            {
//                for (int i = 0; i < 3; i++)
//                {
//                    if (petals[i] == false)
//                    {
//                        bla = i + 4;
//                    }
//                }
//                arr[bla] = arr[bla] == 1 ? 0 : 1;
//                for (int i = 0; i < arr.Length; i++)
//                {
//                    Console.Write(arr[i] + " ");
//                }
//                return;
//            }



//        }
//    }
//}
#endregion
#region 1423.            String Tale 
//using System;

//class GFG
//{

//    void KMPSearch(string pat, string txt)
//    {
//        long M = pat.Length;
//        long N = txt.Length;

//        long[] lps = new long[M];
//        long j = 0; // index for pat[] 

//        computeLPSArray(pat, M, lps);
//        bool t = true;
//        long i = 0;
//        while (i < N)
//        {
//            if (pat[(int)j] == txt[(int)i])
//            {
//                j++;
//                i++;
//            }
//            if (j == M)
//            {
//                Console.Write((i - j));
//                t = false;
//                break;
//                j = lps[j - 1];
//            }

//            else if (i < N && pat[(int)j] != txt[(int)i])
//            {

//                if (j != 0)
//                    j = lps[j - 1];
//                else
//                    i = i + 1;
//            }
//        }
//        if (t == true)
//        {
//            Console.WriteLine(-1);
//        }
//    }

//    void computeLPSArray(string pat, long M, long[] lps)
//    {
//        long len = 0;
//        long i = 1;
//        lps[0] = 0;

//        while (i < M)
//        {
//            if (pat[(int)i] == pat[(int)len])
//            {
//                len++;
//                lps[i] = len;
//                i++;
//            }
//            else
//            {
//                if (len != 0)
//                {
//                    len = lps[len - 1];

//                }
//                else
//                {
//                    lps[i] = len;
//                    i++;
//                }
//            }
//        }
//    }

//    public static void Main()
//    {
//        var n = Convert.ToInt32(Console.ReadLine());
//        var S = Console.ReadLine();
//        var T = Console.ReadLine();
//        new GFG().KMPSearch(S, T + T);
//    }
//}

#endregion
#region 1194.                  Handshakes
//using System;
//using System.Text;
//using System.Collections.Generic;
//using System.Linq;

//public class Example
//{
//    public static void Main()
//    {
//        var nk = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
//        Console.WriteLine((nk[0]*(nk[0]-1))/2-nk[1]);

//    }
//}

#endregion
#region 1119.              Metro    ?????????????????????????????????????????????????????????????????
//using System;
//using System.Text;
//using System.Collections.Generic;
//using System.Linq;

//public class Example
//{
//    public static void Main()
//    {
//        var nk = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
//        var Ndiagonalscount = Convert.ToDouble(Console.ReadLine());

//        int count = 0;
//        var firstArr = new long[(int)Ndiagonalscount];
//        long[] secondArr = new long[(int)Ndiagonalscount];
//        long[] secondArr1 = new long[(int)Ndiagonalscount];
//        int k = 0;
//        bool t = false;
//        for (int i = 0; i < firstArr.Length; i++)
//        {
//            var tt = Console.ReadLine().Split(' ');
//            firstArr[i] = Convert.ToInt64(tt[0]);
//            secondArr[i] = Convert.ToInt64(tt[1]);
//        }
//        for (int i = 2; i < 100; i++)
//        {
//            t = false;

//            for (int j = 0; j < firstArr.Length; j++)
//            {

//                if (secondArr[j] == i)
//                {
//                    if (secondArr[j] == 1 && firstArr[j] == secondArr[j])
//                    {

//                    }
//                    else
//                    {
//                        secondArr1[k] = secondArr[j];
//                        k++;
//                    }
//                    if (secondArr.Length > 1)
//                    {
//                        if (secondArr1[k] != secondArr1[k - 1])
//                        {
//                            count++;
//                        }

//                        if (firstArr[j - 1] < secondArr1[k] && !t)
//                        {
//                            count++;
//                            i++;
//                            t = true;
//                            break;
//                        }
//                    }
//                }
//            }
//        }
//        var result = ((nk[0] + nk[1] - (count * 2)) * 100) + count * 100 * Math.Sqrt(2);
//        Console.WriteLine(Math.Round(result));

//    }
//}
#endregion
#region 2005.              Taxi for Programmers
//using System;
//using System.Text;
//using System.Collections.Generic;
//using System.Linq;

//public class Example
//{
//    public static void Main()
//    {
//        int[,] vec = new int[5, 5];
//        for (int i = 0; i < 5; i++)
//        {

//            var ss = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//            vec[i, 0] = ss[0];
//            vec[i, 1] = ss[1];
//            vec[i, 2] = ss[2];
//            vec[i, 3] = ss[3];
//            vec[i, 4] = ss[4];



//        }
//        Console.WriteLine(Math.Min(Math.Min(Math.Min(vec[0, 0] + vec[1, 0] + vec[2, 1] + vec[2, 3] + vec[3, 4],
//                vec[0, 0] + vec[3, 0] + vec[2, 3] + vec[1, 2] + vec[1, 4]),
//                vec[0, 0] + vec[0, 2] + vec[1, 2] + vec[1, 3] + vec[3, 4]),
//                vec[0, 0] + vec[0, 2] + vec[2, 3] + vec[1, 3] + vec[1, 4]));

//        if (Math.Min(Math.Min(Math.Min(vec[0, 0] + vec[1, 0] + vec[2, 1] + vec[2, 3] + vec[3, 4],
//            vec[0, 0] + vec[3, 0] + vec[2, 3] + vec[1, 2] + vec[1, 4]),
//            vec[0, 0] + vec[0, 2] + vec[1, 2] + vec[1, 3] + vec[3, 4]),
//            vec[0, 0] + vec[0, 2] + vec[2, 3] + vec[1, 3] + vec[1, 4]) ==
//            vec[0, 0] + vec[1, 0] + vec[2, 1] + vec[2, 3] + vec[3, 4])
//        {
//            Console.Write("1" + " " + "2" + " " + "3" + " " + "4" + " " + "5");
//        }
//        else if (Math.Min(Math.Min(Math.Min(vec[0, 0] + vec[1, 0] + vec[2, 1] + vec[2, 3] + vec[3, 4],
//            vec[0, 0] + vec[3, 0] + vec[2, 3] + vec[1, 2] + vec[1, 4]),
//            vec[0, 0] + vec[0, 2] + vec[1, 2] + vec[1, 3] + vec[3, 4]),
//            vec[0, 0] + vec[0, 2] + vec[2, 3] + vec[1, 3] + vec[1, 4]) ==
//            vec[0, 0] + vec[3, 0] + vec[2, 3] + vec[1, 2] + vec[1, 4])
//        {
//            Console.Write("1" + " " + "4" + " " + "3" + " " + "2" + " " + "5");

//        }
//        else if (Math.Min(Math.Min(Math.Min(vec[0, 0] + vec[1, 0] + vec[2, 1] + vec[2, 3] + vec[3, 4],
//            vec[0, 0] + vec[3, 0] + vec[2, 3] + vec[1, 2] + vec[1, 4]),
//            vec[0, 0] + vec[0, 2] + vec[1, 2] + vec[1, 3] + vec[3, 4]),
//            vec[0, 0] + vec[0, 2] + vec[2, 3] + vec[1, 3] + vec[1, 4]) ==
//            vec[0, 0] + vec[0, 2] + vec[1, 2] + vec[1, 3] + vec[3, 4])
//        {
//            Console.Write("1" + " " + "3" + " " + "2" + " " + "4" + " " + "5");

//        }
//        else
//        {
//            Console.Write("1" + " " + "3" + " " + "4" + " " + "2" + " " + "5");

//        }
//    }
//}
#endregion
#region 1712.             Cipher Grille
//using System;
//using System.Text;
//using System.Collections.Generic;
//using System.Linq;

//public class Example
//{
//    public static void Main()
//    {
//        char[,] vec = new char[4, 4];
//        for (int i = 0; i < 4; i++)
//        {

//            var ss = Console.ReadLine().ToCharArray();
//            vec[i, 0] = ss[0];
//            vec[i, 1] = ss[1];
//            vec[i, 2] = ss[2];
//            vec[i, 3] = ss[3];

//        }
//        char[,] buffer = new  char[4, 4];
//        for (int i = 0; i < 4; i++)
//        {

//            var ss = Console.ReadLine().ToCharArray();
//            buffer[i, 0] = ss[0];
//            buffer[i, 1] = ss[1];
//            buffer[i, 2] = ss[2];
//            buffer[i, 3] = ss[3];
//        }
//        for (int i = 0; i < 4; i++)
//        {
//            for (int j = 0;  j < 4;  j++)
//            {
//                if (vec[i, j] == 'X')
//                {
//                    Console.Write(buffer[i,j]);
//                }
//            }
//        }
//        for (int i = 0; i < 4; i++)
//        {
//            for (int j = 3; j >= 0; j--)
//            {

//                if (vec[j, i] == 'X')
//                {
//                    Console.Write(buffer[i, 3-j]);
//                }
//            }
//        }
//        for (int i = 3; i >= 0; i--)
//        {
//            for (int j = 3; j >= 0; j--)
//            {
//                if (vec[i, j] == 'X')
//                {
//                    Console.Write(buffer[3-i, 3-j]);
//                }
//            }
//        }
//        for (int i = 3; i >= 0; i--)
//        {
//            for (int j = 0; j < 4; j++)
//            {
//                if (vec[j, i] == 'X')
//                {
//                    Console.Write(buffer[3-i, j]);
//                }
//            }
//        }
//    }
//}
#endregion
#region 1502.                 Domino Dots
//using System;
//using System.Text;
//using System.Collections.Generic;
//using System.Linq;

//public class Example
//{
//    public static void Main()
//    {
//        long sum = 0;
//        var n = Convert.ToInt64(Console.ReadLine());
//        for (int i = 0; i <= n; i++)
//        {
//            for (int j = i; j <= n; j++)
//            {
//                sum += i + j; ;
//            }
//        }
//        Console.WriteLine(sum);
//    }
//}
#endregion
#region 2111.               Plato
//using System;
//using System.Text;
//using System.Collections.Generic;
//using System.Linq;

//public class Example
//{
//    public static void Main()
//    {
//        long sum = 0;
//        var n = Convert.ToInt32(Console.ReadLine());
//        long price = 0;
//        var nn = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//        MergeSort(nn, 0, nn.Length - 1);

//        for (int i = 0; i < n; i++)
//        {
//            sum += nn[i];
//        }
//        for (int i = 0; i < n; i++)
//        {
//            price = price + sum * nn[i] + (nn[i] * (sum - nn[i]));
//            sum = sum - nn[i];
//        }
//        Console.WriteLine(price);

//    }


//    private static void Merge(int[] input, int left, int middle, int right)
//    {
//        int[] leftArray = new int[middle - left + 1];
//        int[] rightArray = new int[right - middle];

//        Array.Copy(input, left, leftArray, 0, middle - left + 1);
//        Array.Copy(input, middle + 1, rightArray, 0, right - middle);

//        int i = 0;
//        int j = 0;
//        for (int k = left; k < right + 1; k++)
//        {
//            if (i == leftArray.Length)
//            {
//                input[k] = rightArray[j];
//                j++;
//            }
//            else if (j == rightArray.Length)
//            {
//                input[k] = leftArray[i];
//                i++;
//            }
//            else if (leftArray[i] <= rightArray[j])
//            {
//                input[k] = leftArray[i];
//                i++;
//            }
//            else
//            {
//                input[k] = rightArray[j];
//                j++;
//            }
//        }
//    }

//    static private void MergeSort(int[] input, int left, int right)
//    {
//        if (left < right)
//        {
//            int middle = (left + right) / 2;

//            MergeSort(input, left, middle);
//            MergeSort(input, middle + 1, right);

//            Merge(input, left, middle, right);
//        }
//    }

//}
#endregion
#region 1020              Rope
//using System;
//using System.Collections.Generic;

//namespace ds
//{
//    public class Program
//    {
//        private struct Point
//        {
//            public double X { get; set; }
//            public double Y { get; set; }
//        }
//        public static void Main()
//        {
//            Point nR = Read();
//            double n = nR.X;
//            double r = nR.Y;

//            var points = new List<Point>((int)n);
//            for (int i = 0; i < n; i++)
//            {
//                points.Add(Read());
//            }

//            double l = 2 * Math.PI * r;

//            if (n == 1)
//            {
//                Console.Write(String.Format("{0:f2}", l).Replace(',', '.'));
//            }
//            else
//            {
//                l += ComputeLength(points[0], points[(int)(n - 1)]);

//                for (int i = 0; i < n - 1; i++)
//                {
//                    l += ComputeLength(points[i], points[i + 1]);
//                }
//                Console.Write("{0:F2}", l);
//            }

//        }

//        private static double ComputeLength(Point p1, Point p2)
//        {
//            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2)
//                + Math.Pow(p1.Y - p2.Y, 2));
//        }

//        private static Point Read()
//        {
//            var twoNum = Console.ReadLine().Split(' ');
//            twoNum[0] = twoNum[0];
//            twoNum[1] = twoNum[1];
//            return new Point { X = Double.Parse(twoNum[0]), Y = Double.Parse(twoNum[1]) };
//        }
//    }
//}
#endregion
#region 1086.              Cryptography
//using System;
//using System.Collections.Generic;

//namespace ds
//{
//    public class Program
//    {

//        public static void Main()
//        {
//            var n = Convert.ToInt32(Console.ReadLine());
//            var m = Convert.ToInt32(Console.ReadLine());
//            int k = 0;
//            int[] num = new int[n];
//            int[] prime_num = new int[15001];
//            while (!isPrime(m + 1))
//            {
//                m++;
//            }
//            Console.WriteLine(m + 1);
//            for (int nnn = 3, i = 2; i <= 15000; nnn += 2)
//                if (isPrime(nnn)) prime_num[i++] = nnn;



//            num = new int[n];

//            for (int i = 0; i < n - 1; i++)
//                num[i] = Convert.ToInt32(Console.ReadLine());

//            for (int i = 0; i < n - 1; i++)
//                Console.WriteLine(prime_num[num[i]]);


//        }

//        static bool isPrime(int p)
//        {
//            for (int i = 2; i <= Math.Sqrt(p); i++)
//            {
//                if (p % i == 0)
//                {
//                    return false;
//                }
//            }
//            if (p == 1)
//            {
//                return false;
//            }
//            return true;
//        }
//    }
//}

#endregion
#region 1079         Maximum
//using System;
//using System.Collections.Generic;

//namespace ss
//{
//    public class Program
//    {

//        public static void Main()
//        {
//            List<int> buffer = new List<int>();
//            buffer.Add(0);
//            buffer.Add(1);
//            for (int i = 0; i < 15; i++)
//            {

//                buffer.Clear();
//                buffer.Add(0);
//                buffer.Add(1);
//               var  max = buffer[0];
//                var n = Convert.ToInt32(Console.ReadLine());
//                if (n == 0) return;
//                if (n==1)
//                {
//                    Console.WriteLine(1);
//                    continue;
//                }
//                for (int j = 2; j <= n; j++)
//                {
//                    if (j % 2 == 0)
//                    {
//                        if (max<buffer[j/2])
//                        {
//                            max = buffer[j / 2];
//                        }
//                        buffer.Add(buffer[j / 2]);
//                    }
//                    else
//                    {
//                        if (max < buffer[(j - 1) / 2] + buffer[(j - 1) / 2 + 1])
//                        {
//                            max = buffer[(j - 1) / 2] + buffer[(j - 1) / 2 + 1];
//                        }
//                        buffer.Add(buffer[(j - 1) / 2] + buffer[(j - 1) / 2 + 1]);
//                    }
//                }
//                Console.WriteLine(max);
//            }
//        }
//    }
//}

#endregion
#region 1484.              Film Rating        ?????????????????????????????
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Task_1020
//{
//    public class Program
//    {

//        public static void Main()
//        {
//            var xyn = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
//            var x = xyn[0];
//            var y = xyn[1];
//            var n = xyn[2];

//            if (x < y)
//            {
//                Console.WriteLine(0);
//                return;
//            }
//            if (x >= 10)
//            {
//                var count = (n*(y-x) + (0.0500000000002 * n)) / (1 - 0.0500000000002 - y);
//                Console.WriteLine(Math.Round(count + 1));
//            }
//            else
//            {
//                var count = ((y * n) - (n * x) + (0.04999999 * n)) / (1 - 0.04999999 - y);
//                Console.WriteLine((int)(count + 1));
//            }

//        }


//    }
//}

#endregion
#region 1131.               Copying
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace ss
//{
//    public class Program
//    {

//        public static void Main()
//        {
//            var xyn = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//            double n = xyn[0];
//            double comp = n - 1;
//            double howComp = 1;
//            var k = xyn[1];
//            int i = 1;
//            double hour = 0;
//            while (howComp < n)
//            {

//                while (howComp < k)
//                {
//                    howComp = howComp * 2;
//                    hour++;

//                    if (howComp >= n )
//                    {
//                        Console.WriteLine(hour);
//                        return;
//                    }
//                }

//                hour = hour + Math.Ceiling((n - howComp) / k);
//                break;
//            }
//            Console.WriteLine(hour);
//        }


//    }
//}

#endregion
#region 1146.                Maximum Sum
//using System;
//using System.Collections.Generic;
//using System.Linq;
//namespace TimusProblems
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            MaximumSum();
//        }
//        static int MaxArraySum(int[] a)
//        {
//            int max_so_far = a[0];
//            int curr_max = a[0];
//            for (int i = 1; i < a.Length; i++)
//            {
//                curr_max = Math.Max(a[i], curr_max + a[i]);
//                max_so_far = Math.Max(max_so_far, curr_max);
//            }
//            return max_so_far;
//        }
//        static void MaximumSum()
//        {
//            int n = Convert.ToInt32(Console.ReadLine());
//            int[,] Rec = new int[n, n];
//            for (int i = 0; i < n; i++)
//            {
//                var input = Console.ReadLine()?.
//                    Split(' ').Select(int.Parse).ToArray();
//                for (int j = 0; j < n; j++)
//                {
//                    Rec[i, j] = input[j];
//                }
//            }
//            int ans = int.MinValue;
//            for (int l = 0; l < n; l++)
//            {
//                int[] Sum = new int[n];
//                for (int r = l; r < n; r++)
//                {
//                    for (int i = 0; i < n; i++)
//                    {
//                        Sum[i] += Rec[i, r];
//                    }
//                    var temp = MaxArraySum(Sum);
//                    if (temp > ans) ans = temp;
//                }
//            }
//            Console.WriteLine(ans);
//        }
//    }
//}
#endregion
#region 1126.        Magnetic Storms
//using System;
//using System.Collections.Generic;
//using System.Linq;
//namespace TimusProblems
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var n = Convert.ToInt32(Console.ReadLine());
//            List<int> list = new List<int>();

//            while (true)
//            {
//                var nn = Convert.ToInt32(Console.ReadLine());
//                if (nn != -1)
//                {
//                    list.Add(nn);
//                    if (list.Count == n)
//                    {
//                        var max = list[0];
//                        for (int i = 0; i < list.Count; i++)
//                        {
//                            if (list[i] > max)
//                            {
//                                max = list[i];
//                            }
//                        }
//                        list.Remove(list[0]);
//                        Console.WriteLine(max);
//                    }

//                }
//                else break;
//            }

//        }
//    }
//}
#endregion
#region 1136.              Parliament
//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BTree
//{
//    public class Node
//    {
//        public int Data { get; set; }
//        public Node Left { get; set; }
//        public Node Right { get; set; }
//        public Node()
//        {

//        }
//        public Node(int data)
//        {
//            this.Data = data;
//        }
//    }
//    public class BinaryTree
//    {
//        private Node _root;
//        public BinaryTree()
//        {
//            _root = null;
//        }
//        public void Insert(int data)
//        {
//            // 1. If the tree is empty, return a new, single node 
//            if (_root == null)
//            {
//                _root = new Node(data);
//                return;
//            }
//            // 2. Otherwise, recur down the tree 
//            InsertRec(_root, new Node(data));
//        }
//        private void InsertRec(Node root, Node newNode)
//        {
//            if (root == null)
//                root = newNode;

//            if (newNode.Data < root.Data)
//            {
//                if (root.Left == null)
//                    root.Left = newNode;
//                else
//                    InsertRec(root.Left, newNode);

//            }
//            else
//            {
//                if (root.Right == null)
//                    root.Right = newNode;
//                else
//                    InsertRec(root.Right, newNode);
//            }
//        }
//        private void DisplayTree(Node root)
//        {
//            if (root == null) return;
//            DisplayTree(root.Right);
//            if (root.Left==null)
//            {
//                Console.WriteLine(root.Data);
//            }
//            else
//            {
//                DisplayTree(root.Left);
//                Console.WriteLine(root.Data);
//            }


//        }
//        private void DisplayLeft(Node root)
//        {
//            DisplayLeft(root.Left);
//            Console.WriteLine(root.Data);
//        }
//        public void DisplayTree()
//        {
//            DisplayTree(_root.Right);
//            DisplayTree(_root.Left);
//            Console.WriteLine(_root.Data);
//        }

//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            BinaryTree tree = new BinaryTree();
//            var n = Convert.ToInt32(Console.ReadLine());
//            var list = new List<int>();
//            for (int i = 0; i < n; i++)
//            {
//                list.Add(Convert.ToInt32(Console.ReadLine()));
//            }
//            for (int i = list.Count - 1; i >= 0; i--)
//            {
//                tree.Insert(list[i]);
//            }

//            tree.DisplayTree();
//        }
//    }
//}
#endregion
#region 1290.              Sabotage
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        var n = Convert.ToInt32(Console.ReadLine());
//        if (n == 0) return;
//        var buffer = new int[n];
//        for (int i = 0; i < n; i++)
//        {
//            buffer[i] = Convert.ToInt32(Console.ReadLine());
//        }
//        Array.Sort(buffer);
//        for (int i = n - 1; i >= 0; i--)
//        {
//            Console.WriteLine(buffer[i]);
//        }

//    }
//}
#endregion
#region 1149.        Sinus Dances
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        var n = Convert.ToInt32(Console.ReadLine());
//        string[] a = new string[n + 1];
//        string[] s = new string[n];
//        if (n == 1)
//        {
//            Console.WriteLine("sin(1)+1");
//            return;
//        }
//        a[1] = "sin(1)";
//        int bg = 2;
//        for (int i = 2; i <= n; i++)
//        {
//            if (i <= 10)
//                a[i] = a[i - 1].Substring(0, a[i - 1].Length - i);
//            else if (i <= 100)
//                a[i] = a[i - 1].Substring(0, a[i - 1].Length - i - 1);
//            else if (i >100)
//                a[i] = a[i - 1].Substring(0, a[i - 1].Length - i - 2);
//            if (i % 2 == 0)
//            {
//                a[i] = a[i] + (bg - 1) + "-";
//            }
//            else
//            {
//                a[i] = a[i] + (bg - 1) + "+";
//            }
//            a[i] = a[i] + "sin(" + bg;
//            for (int j = 0; j < i; j++)
//            {
//                a[i] = a[i] + ")";
//            }
//            bg++;
//        }
//        string Resalt = "";
//        for (int i = 1; i <= n; i++)
//        {
//            if (i == 1)
//            {
//                for (int j = 0; j < n - 2; j++)
//                {
//                    Resalt += "(";
//                }
//                Resalt += "(" + a[i] + "+" + (n - i + 1) + ")";
//            }
//            else if (i == n)
//            {
//                Resalt += a[i] + "+" + 1;

//            }
//            else
//            {
//                Resalt += a[i] + "+" + (n - i + 1) + ")";

//            }

//        }
//        Console.WriteLine(Resalt);
//    }
//}
#endregion
#region 1510.     Order
//using System;
//using System.Linq;

//class Program
//{
//    static void Main(string[] args)
//    {

//        var n = Convert.ToInt32(Console.ReadLine());
//        var buffer = new long[n + 1];
//        for (int i = 0; i < n; i++)
//        {
//            buffer[i] = Convert.ToInt64(Console.ReadLine());

//        }
//        long mm = 0;
//        long t = 0;
//        Array.Sort(buffer);
//        if (n == 1)
//        {
//            Console.WriteLine(buffer[n ]);
//            return;
//        }
//        if (n==2)
//        {
//            Console.WriteLine(buffer[n ]);
//            return;
//        }
//        long max = 0;
//        long currIndex = 1;
//        int j = 0;
//        max = buffer[0];
//        for (int i = 1; i < n; i++)
//        {
//            while (i<=n&&buffer[i]==buffer[i-1])
//            {
//                currIndex++;
//                i++;
//            }

//            if (currIndex > t)
//            {
//                t = currIndex;
//                mm = buffer[i-1];
//            }
//            currIndex = 0;

//        }

//        Console.WriteLine(mm);


//    }
//}
#endregion
#region 1601.            AntiCAPS
//using System;
//using System.Linq;

//class Program
//{
//    static void Main(string[] args)
//    {
//        bool t = false;
//        var str = Console.In.ReadToEnd().Trim();

//        var m = str.ToCharArray();
//        int j = 0;
//        if (str[j] < 'A')
//        {
//            while (str[j] < 'A')
//            {

//                Console.Write(char.ToLower(str[j]));
//                j++;

//            }
//            if (j < str.Length)
//            {
//                Console.Write(char.ToUpper(str[j]));

//            }
//        }
//        else
//        {
//            Console.Write(char.ToUpper(str[0]));

//        }



//        for (int i = j + 1; i < str.Length; i++)
//        {
//            if (str[i] == '?' || str[i] == '!' || str[i] == '.')
//            {
//                // Console.Write(char.ToUpper(str[i]));
//                Console.Write(char.ToUpper(str[i]));
//                t = true;
//                continue;
//            }
//            else
//            {
//                if (!t)
//                {
//                    if (str[i] == '.' || str[i] == '!' || str[i] == '?')
//                    {
//                        while (i < str.Length && (str[i].ToString() == " " || str[i].ToString() == "!" || str[i].ToString() == "?" || str[i].ToString() == "."))
//                        {

//                            Console.Write(char.ToLower(str[i]));
//                            i++;

//                        }
//                        if (i < str.Length)
//                        {
//                            Console.Write(char.ToUpper(str[i]));
//                            continue;

//                        }
//                    }
//                    if (i < str.Length)
//                    {
//                        Console.Write(char.ToLower(str[i]));

//                    }
//                }
//                else
//                {

//                    if (str[i] >= 'A' && str[i] <= 'Z')
//                        Console.Write(char.ToUpper(str[i]));
//                    else
//                    {
//                        Console.Write(char.ToLower(str[i]));
//                        continue;

//                    }


//                }
//                t = false;
//            }
//        }

//    }
//}
#endregion
#region 1370.         Magician 
//using System;
//using System.Linq;

//class Program
//{
//    static void Main(string[] args)
//    {
//        var NM = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//        var n = NM[0];
//        var m = NM[1];
//        var buffer = new int[1000];
//        for (int i = 0; i < n; i++)
//        {
//            buffer[i] = Convert.ToInt32(Console.ReadLine());
//        }
//        for (int i = m; i < m+10; i++)
//        {
//            Console.Write(buffer[i % n]);
//        }

//    }
//}
#endregion
#region 1161.                 Stripies
//using System;
//using System.Linq;

//class Program
//{
//    static void Main(string[] args)
//    {
//        var n = Convert.ToInt32(Console.ReadLine());
//        var buffer = new double[n];
//        double sum = 1;

//        for (int i = 0; i <n; i++)
//        {
//            buffer[i] = Convert.ToInt32(Console.ReadLine());
//        }
//        Array.Sort(buffer);
//        sum = buffer[n-1];
//        for (int i = n - 2; i >= 0; i--)
//        {
//            sum = 2 * Math.Sqrt(sum * buffer[i]);
//        }
//        var sumt = String.Format("{0:0.00}", sum);
//        Console.WriteLine(sumt);

//    }
//}
#endregion
#region 1296.          Hyperjump
//using System;
//using System.Linq;

//class Program
//{
//    static void Main(string[] args)
//    {

//        var n = Convert.ToInt32(Console.ReadLine());
//        var buffer = new long[n];
//        for (int i = 0; i < n; i++)
//        {
//            buffer[i] = Convert.ToInt32(Console.ReadLine());
//        }
//        if (n == 0) 
//        {
//            Console.WriteLine(0);

//            return;
//        }
//        if (n == 1)
//        {
//            if (buffer[0] <= 0)
//            {
//                Console.WriteLine(0);
//                return;
//            }
//            else
//            {
//                Console.WriteLine(buffer[0]);
//                return;
//            }
//        }
//        Console.WriteLine(MaxArraySum(buffer));

//    }
//    static long MaxArraySum(long[] a)
//    {
//        long max_so_far = a[0];
//        long curr_max = a[0];
//        for (int i = 1; i < a.Length; i++)
//        {
//            curr_max = Math.Max(a[i], curr_max + a[i]);
//            max_so_far = Math.Max(max_so_far, curr_max);
//        }
//        if (max_so_far <= 0)
//        {
//            return 0;
//        }
//        return max_so_far;
//    }
//}
#endregion
#region 1343.          Fairy Tale
//using System;
//using System.Linq;

//class Program
//{
//    static void Main(string[] args)
//    {
//        var n = Convert.ToDouble(Console.ReadLine());
//        if (n.ToString() == "0")
//        {
//            Console.WriteLine("000000000003");
//            return;
//        }
//        var st = Console.ReadLine();

//        if (st == "000000000000")
//        {
//            Console.WriteLine("000000000003");
//            return;
//        }
//        int i = 0;
//        while (i != n && st[i].ToString() == "0")
//        {
//            if(st[i].ToString() != "0")
//            {
//                break;
//            }
//            i++;
//        }
//        var newSt = st.Substring(i, (int)n - i);
//        for (int j = newSt.Length + i; j < 12; j++)
//        {
//            newSt = newSt + "0";
//        }

//        var number = Convert.ToDouble(newSt);
//        if (number == 0)
//        {
//            Console.WriteLine("000000000003");
//            return;
//        }
//        while (!isPrime(number))
//        {
//            number++;
//        }
//        var strr = new string('0', i);
//        Console.WriteLine(strr + number); ;



//    }
//    public static bool isPrime(double p)
//    {
//        for (int i = 2; i <= Math.Sqrt(p); i++)
//        {
//            if (p % i == 0)
//            {
//                return false;
//            }
//        }
//        if (p == 1)
//        {
//            return false;
//        }
//        return true;
//    }
//}
#endregion
#region 1261.                Tips
//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static List<long> ternaryList;
//    static void Main(string[] args)
//    {
//        var n = Convert.ToInt64(Console.ReadLine());
//        if (n == 1)
//        {
//            Console.WriteLine(4 + " " + 3);
//            return;
//        }
//        ternaryList = new List<long>();
//        var t = true;

//        convert(n);
//        ternaryList.Insert(0, 0);
//        ternaryList.Insert(0, 0);

//        for (int i = ternaryList.Count - 1; i > 0; i--)
//        {
//            if (ternaryList[i] > 1)
//            {
//                t = false;
//                ternaryList[i - 1]++;
//                ternaryList[i] = 0;
//            }
//        }
//        if (ternaryList[0] > 1)
//        {
//            ternaryList[0] = 0;
//            ternaryList.Insert(0, 1);
//        }

//        long result = 0;
//        for (int i = 0; i < ternaryList.Count; i++)
//        {
//            result += ternaryList[i] * (long)Math.Pow(3, ternaryList.Count - 1 - i);
//        }
//        if (result==n)
//        {
//            result = 0;
//            for (int i = ternaryList.Count - 1; i >= 0; i--)
//            {
//                if (ternaryList[i] == 0)
//                {
//                    ternaryList[i] = 1;
//                    break;
//                }
//            }
//            for (int i = 0; i < ternaryList.Count; i++)
//            {
//                result += ternaryList[i] * (long)Math.Pow(3, ternaryList.Count - 1 - i);
//            }
//        }
//        if (result> 4294967291)
//        {
//            Console.WriteLine(0);
//            return;
//        }
//        Console.Write(result + " " + (result - n));
//    }

//    static void convertToTernary(long N)
//    {
//        if (N == 0)
//            return;

//        long x = N % 3;
//        N /= 3;
//        if (x < 0)
//            N += 1;

//        convertToTernary(N);

//        if (x < 0)
//            ternaryList.Add(x + (3 * -1));
//        else
//            ternaryList.Add(x);
//    }

//    static void convert(long Decimal)
//    {

//        if (Decimal != 0)
//        {
//            convertToTernary(Decimal);
//        }
//        else
//            ternaryList.Add(0);
//    }
//}
#endregion
#region 1963.          Kite
//using System;
//using System.Drawing;
//using System.Linq;

//class Program
//{
//    static void Main(string[] args)
//    {
//        var aa = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//        var a = new Point(aa[0], aa[1]);
//        var bb = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//        var b = new Point(bb[0], bb[1]);
//        var cc = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//        var c = new Point(cc[0], cc[1]);
//        var dd = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//        var d = new Point(dd[0], dd[1]);


//        var ab = PointsLength(a, b);
//        var bc = PointsLength(b, c);
//        var cd = PointsLength(c, d);
//        var da = PointsLength(d, a);
//        var ac = PointsLength(a, c);
//        var bd = PointsLength(b, d);


//        if ((ab == bc && da == cd && ab != da) || (ab == da && bc == cd && bc != ab))
//        {
//            Console.WriteLine(2);
//            return;
//        }


//        if (bd == ac)
//        {
//            if ((bc == da && ab != cd) || (ab == cd && bc != da))
//            {
//                Console.WriteLine(2);
//                return;
//            }
//        }

//        if (ab == bc)
//        {
//            if (bc == cd)
//            {
//                if (cd == da)
//                {
//                    if (ac == bd)
//                    {
//                        Console.WriteLine(8);
//                        return;

//                    }
//                }
//            }
//        }

//        if (ab == cd)
//        {
//            if (bc == da)
//            {
//                if (ab != bc)
//                {
//                    if (ac == bd)
//                    {
//                        Console.WriteLine(4);
//                        return;
//                    }
//                }
//            }
//        }

//        if (ac != bd)
//        {
//            if (ab == bc)
//            {
//                if (bc == cd)
//                {
//                    if (cd == da)
//                    {
//                        Console.WriteLine(4);
//                        return;
//                    }
//                }
//            }
//        }

//        Console.WriteLine(0);

//    }

//    private static double PointsLength(Point a, Point b)
//    {
//        return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
//    }
//}
#endregion
#region 1875.            Angry Birds ?
//using System;
//using System.Collections.Generic;
//using System.Linq;
//class GFG
//{

//    public static void Main()
//    {
//        var nm = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
//        var nm1 = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
//        var nm2 = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
//        var nm12 = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
//        var nm222 = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
//        List<decimal> listX = new List<decimal>();
//        List<decimal> listY = new List<decimal>();
//        listX.Add(nm[0]);
//        listX.Add(nm1[0]);
//        listX.Add(nm2[0]);
//        listX.Add(nm12[0]);
//        listX.Add(nm222[0]);
//        listY.Add(nm[1]);
//        listY.Add(nm1[1]);
//        listY.Add(nm2[1]);
//        listY.Add(nm12[1]);
//        listY.Add(nm222[1]);
//        List<decimal> listnotX = new List<decimal>();
//        List<decimal> listnotY = new List<decimal>();
//        bool mg = false;
//        int count = 1;
//        int currentCount = 0;
//        int drel = 1;
//        bool[] buffer = new bool[5] { true, true, true, true, true };
//        bool[] buffer1 = new bool[5] { true, true, true, true, true };
//        if (listX[1]== listX[2])
//        {
//            if (listX[2]== listX[3])
//            {
//                if (listX[3]== listX[4])
//                {
//                    if (listX[4]== listX[0])
//                    {
//                        Console.WriteLine(1);
//                        return;
//                    }
//                }
//            }
//        }
//        int m = 0;
//        while (listX.Count >= 1)
//        {
//            m = 0;
//            if (listX.Count == 1)
//            {
//                Console.WriteLine(drel);
//                return;
//            }
//            if (drel >= 5)
//            {
//                Console.WriteLine(5);
//                return;
//            }
//            for (int j = 0; j < listX.Count - 1; j++)
//            {
//                if (count == 5)
//                {
//                    Console.WriteLine(1);
//                    return;
//                }
//                decimal k = listX[j] * listX[j + 1] * (listX[j + 1] - listX[j]);
//                decimal a = listY[j + 1] * listX[j] - (listY[j] * listX[j + 1]);
//                decimal b = listY[j] * listX[j + 1] * (listX[j + 1] - listX[j]) - (a * listX[j]);

//                if (k != 0 && a < 0)
//                {
//                    for (int i = 0; i < listX.Count; i++)
//                    {
//                        if (listY[i] * k == a * listX[i] * listX[i] + (b * listX[i]))
//                        {
//                            buffer[i] = false;
//                            currentCount++;
//                        }

//                    }
//                    if (currentCount == 5)
//                    {
//                        Console.WriteLine(1);
//                        return;
//                    }
//                    if (currentCount > count)
//                    {
//                        for (int l = 0; l < 5; l++)
//                        {
//                            buffer1[l] = buffer[l];
//                        }
//                        count = currentCount;
//                    }
//                    currentCount = 0;
//                    for (int i = 0; i < 5; i++)
//                    {
//                        buffer[i] = true;
//                    }
//                }
//                else
//                {
//                    continue;
//                }
//                count = 0;
//                m++;
//            }
//            int dl = 0;
//            for (int k = 0; k < 5; k++)
//            {
//                if (k + dl >= 5)
//                {
//                    break;
//                }
//                if (buffer1[k + dl] == false)
//                {

//                    listX.Remove(listX[k]);
//                    listY.Remove(listY[k]);
//                    k--;
//                    dl++;
//                }
//            }
//            currentCount = 0;
//            for (int i = 0; i < 5; i++)
//            {
//                buffer1[i] = true;
//            }
//            drel++;
//        }
//        Console.WriteLine(drel);
//    }
//}
#endregion
#region 1875.            Angry Birds
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Numerics;

//class gfg
//{
//    public static void Main()
//    {
//        AngryBirds();
//    }
//    static void AngryBirds()
//    {
//        var points = new List<KeyValuePair<BigInteger, BigInteger>>();
//        for (int i = 0; i < 5; i++)
//        {
//            var xy = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
//            points.Add(new KeyValuePair<BigInteger, BigInteger>(new BigInteger(xy[0]), new BigInteger(xy[1])));
//        }
//        Console.WriteLine(Parabol(points));
//    }
//    static int Parabol(List<KeyValuePair<BigInteger, BigInteger>> points)
//    {
//        if (points.Count == 0)
//            return 0;
//        int ans = points.Count;
//        for (int i = 0; i < points.Count; i++)
//        {
//            for (int j = i + 1; j < points.Count; j++)
//            {
//                var x1 = points[i].Key;
//                var y1 = points[i].Value;
//                var x2 = points[j].Key;
//                var y2 = points[j].Value;
//                var temp = new List<KeyValuePair<BigInteger, BigInteger>>();
//                temp.AddRange(points);
//                var l = 0;
//                while (l < temp.Count && temp.Count > 0)
//                {
//                    var x = temp[l].Key;
//                    var y = temp[l].Value;
//                    if (BigInteger.Multiply(y, BigInteger.Subtract(BigInteger.Multiply(BigInteger.Multiply(x1, x1), x2), BigInteger.Multiply(BigInteger.Multiply(x2, x2), x1)))
//                        == BigInteger.Add(BigInteger.Multiply(BigInteger.Multiply(x, x), BigInteger.Subtract(BigInteger.Multiply(x2, y1), BigInteger.Multiply(x1, y2))),
//                            BigInteger.Multiply(x, BigInteger.Subtract(BigInteger.Multiply(BigInteger.Multiply(x1, x1), y2),
//                            BigInteger.Multiply(BigInteger.Multiply(x2, x2), y1))))
//                        && CompareAandB(x2 * y1 - y2 * x1, BigInteger.Subtract(BigInteger.Multiply(BigInteger.Multiply(x1, x1), x2), BigInteger.Multiply(BigInteger.Multiply(x2, x2), x1))))
//                        temp.Remove(temp[l]);
//                    else
//                        l++;
//                }
//                if (temp.Count == points.Count)
//                    continue;
//                ans = Math.Min(ans, 1 + Parabol(temp));
//            }
//        }
//        return ans;
//    }
//    static bool CompareAandB(BigInteger a, BigInteger b)
//    {
//        return a > 0 ? b < 0 : b > 0;
//    }
//}
#endregion
#region 1330.           Intervals
//using System;
//using System.Collections.Generic;
//using System.Linq;
//class GFG
//{

//    public static void Main()
//    {
//        var n = Convert.ToInt32(Console.ReadLine());
//        long[] buffer = new long[n];
//        long[] sumt = new long[n+1];
//        long sum = 0;
//        for (int i = 0; i < n; i++)
//        {
//            buffer[i] = Convert.ToInt64(Console.ReadLine());
//            sum += buffer[i];
//            sumt[i+1] = sum;
//        }

//        var m = Convert.ToInt32(Console.ReadLine());

//        for (int i = 0; i < m; i++)
//        {
//            var elem = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//            Console.WriteLine(sumt[elem[1]]- sumt[elem[0]-1]);
//        }
//    }
//}
#endregion
#region 1446.           Sorting Hat
//using System;
//using System.Collections.Generic;
//using System.Linq;
//class GFG
//{

//    public static void Main()
//    {
//        var n = Convert.ToInt32(Console.ReadLine());
//        List<string> list1 = new List<string>();
//        List<string> list = new List<string>();

//        list1.Add("Slytherin:");
//        List<string> list2 = new List<string>();
//        list2.Add("Hufflepuff:");
//        List<string> list3 = new List<string>();
//        list3.Add("Gryffindor:");
//        List<string> list4 = new List<string>();
//        list4.Add("Ravenclaw:");
//        for (int i = 0; i < 2 * n; i++)
//        {
//            list.Add(Console.ReadLine());
//        }
//        Console.WriteLine("Slytherin:");

//        for (int i = 0; i < list.Count; i++)
//        {
//            if (list[i] == "Slytherin")
//            {
//                int k = i;
//                while (i > 0 && (list[i - 1] != "Hufflepuff" && list[i - 1] != "Gryffindor" && list[i - 1] != "Ravenclaw" && list[i - 1] != "Slytherin"))
//                {
//                    Console.WriteLine(list[i - 1]);
//                    list1.Add(list[--i]);
//                }
//                i = k;
//            }
//        }
//        Console.WriteLine();
//        Console.WriteLine("Hufflepuff:");

//        for (int i = 0; i < list.Count; i++)
//        {
//            if (list[i] == "Hufflepuff")
//            {
//                int k = i;
//                while (i > 0 && (list[i - 1] != "Hufflepuff" && list[i - 1] != "Gryffindor" && list[i - 1] != "Ravenclaw" && list[i - 1] != "Slytherin"))
//                {
//                    Console.WriteLine(list[i - 1]);
//                    list2.Add(list[--i]);
//                }
//                i = k;
//            }
//        }
//        Console.WriteLine();
//        Console.WriteLine("Gryffindor:");
//        for (int i = 0; i < list.Count; i++)
//        {
//            if (list[i] == "Gryffindor")
//            {
//                int k = i;
//                while (i > 0 && (list[i - 1] != "Hufflepuff" && list[i - 1] != "Gryffindor" && list[i - 1] != "Ravenclaw" && list[i - 1] != "Slytherin"))
//                {
//                    Console.WriteLine(list[i - 1]);
//                    list3.Add(list[--i]);
//                }
//                i = k;
//            }
//        }
//        Console.WriteLine();
//        Console.WriteLine("Ravenclaw:");
//        for (int i = 0; i < list.Count; i++)
//        {
//            if (list[i] == "Ravenclaw")
//            {
//                int k = i;
//                while (i > 0 && (list[i - 1] != "Hufflepuff" && list[i - 1] != "Gryffindor" && list[i - 1] != "Ravenclaw" && list[i - 1] != "Slytherin"))
//                {
//                    Console.WriteLine(list[i - 1]);
//                    list4.Add(list[--i]);
//                }
//                i = k;
//            }
//        }
//    }
//}
#endregion
#region 1104.            Don’t Ask Woman about Her Age
//using System;
//using System.Collections.Generic;
//using System.Linq;
//class GFG
//{

//    public static void Main()
//    {
//        string a;
//        long p = 0;
//        int max = 0;
//        int i = 0;
//        a = Console.ReadLine();

//        for (i = 0; i < a.Length; i++)
//        {
//            if (a[i] >= '0' && a[i] <= '9')
//            {
//                p = p + (a[i] - '0');
//                if (a[i] - '0' > max)
//                    max = a[i] - '0';
//            }
//            else
//            {
//                p = p + (a[i] - 'A' + 10);
//                if (a[i] - 'A' + 10 > max)
//                    max = a[i] - 'A' + 10;
//            }
//        }
//        if (max == 0) { i = 0; Console.WriteLine(2); }
//        else
//        {
//            for (i = max + 1; i <= 36; i++)
//                if (p % (i - 1) == 0) { Console.WriteLine(i); ; break; }
//        }
//        if (i == 37) Console.WriteLine("No solution.");
//    }
//}
#endregion
#region 1192.          Ball in a Dream
//using System;
//using System.Collections.Generic;
//using System.Linq;
//class GFG
//{

//    public static void Main()
//    {
//        var pi = 3.1415926535;
//        var vak = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
//        var x = vak[0] * vak[0] * vak[2] * Math.Sin(vak[1] * pi / 90) / (10 * (vak[2] - 1));
//        var sumt = String.Format("{0:0.00}", x);
//        Console.WriteLine(sumt);
//    }
//}
#endregion
#region 1398.       Bishop and Pawn
//using System;
//using System.Collections.Generic;
//using System.Linq;
//class GFG
//{
//    public static void Main()
//    {
//        var bishop = Console.ReadLine();
//        var zinvor = Console.ReadLine();
//        var dict = new Dictionary<string, string>();
//        string s = "abcdefgh";
//        if ((bishop == "g1" && zinvor == "h3") || (bishop == "b1" && zinvor == "a3") ||
//            (bishop == "a2" && zinvor == "b2") || (bishop == "h2" && zinvor == "g2"))
//        {
//            Console.WriteLine("DRAW");
//            return;
//        }
//        string t = "f";
//        //false sev vandak 
//        //true spitka vandak

//        for (int i = 1; i <= 8; i++)
//        {
//            for (int j = 1; j <= 8; j++)
//            {
//                dict.Add((s[i - 1] + j.ToString()), (t.ToString() + " " + i.ToString() + " " + j.ToString() + " ").ToString());
//                t = t == "f" ? "t" : "f";
//            }
//            t = t == "f" ? "t" : "f";

//        }
//        var bishPos = dict[bishop];
//        var zinPos = dict[zinvor];
//        var x1 = bishPos[2];
//        var y1 = bishPos[4];
//        var x2 = zinPos[2];
//        var y2 = zinPos[4];

//        while (x1 != 9 & y1 != 9)
//        {
//            if (++x1 == x2 & ++y1 == y2)
//            {
//                Console.WriteLine("WHITE");
//                return;
//            }
//        }
//        x1 = bishPos[2];
//        y1 = bishPos[4];
//        x2 = zinPos[2];
//        y2 = zinPos[4];
//        while (x1 != 0 & y1 != 0)
//        {
//            if (--x1 == x2 & --y1 == y2)
//            {
//                Console.WriteLine("WHITE");
//                return;
//            }
//        }
//        x1 = bishPos[2];
//        y1 = bishPos[4];
//        x2 = zinPos[2];
//        y2 = zinPos[4];
//        while (x1 != 9 & y1 != 0)
//        {
//            if (++x1 == x2 & --y1 == y2)
//            {
//                Console.WriteLine("WHITE");
//                return;
//            }
//        }
//        x1 = bishPos[2];
//        y1 = bishPos[4];
//        x2 = zinPos[2];
//        y2 = zinPos[4];
//        while (x1 != 0 & y1 != 9)
//        {
//            if (--x1 == x2 & ++y1 == y2)
//            {
//                Console.WriteLine("WHITE");
//                return;
//            }
//        }
//        x1 = bishPos[2];
//        y1 = bishPos[4];
//        x2 = zinPos[2];
//        y2 = zinPos[4];

//        if (Convert.ToInt32(zinvor[1].ToString()) == 2)
//        {
//            if (zinvor[1].ToString() == "2")
//            {
//                if ((zinPos[0].ToString() == "t" && bishPos[0].ToString() == "f")
//                    ||(zinPos[0].ToString() == "f" && bishPos[0].ToString() == "t"))
//                {
//                    Console.WriteLine("WHITE");
//                    return;
//                }
//                else
//                {
//                    Console.WriteLine("BLACK");
//                    return;
//                }
//            }
//        }


//        if (Convert.ToInt32(zinvor[1].ToString()) > 2)
//        {
//            Console.WriteLine("WHITE");
//            return;
//        }
//    }
//}
#endregion
#region 1428.     Jedi Riddle
//using System;
//using System.Collections.Generic;
//using System.Linq;
//class GFG
//{
//    public static void Main()
//    {
//        var abc = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//        var a = abc[0];
//        var b = abc[1];
//        var c = abc[2];
//        Console.WriteLine(Math.Pow(2,(c-1)/a));
//        Console.WriteLine(Math.Pow(2,(c-1)/b));
//        Console.WriteLine(2);
//    }
//}
#endregion
#region 1456.             Jedi Riddle 2 ????
//using System;
//using System.Collections.Generic;
//using System.Linq;
//class GFG
//{
//    public static void Main()
//    {
//        var abc = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//        var a = abc[0];
//        var n = abc[1];
//        var d = 0;
//        int i = 1; 
//        var fist = true;
//        while (d != 1)
//        {
//            if (fist)
//            {
//                d = 1 * a % n;
//                fist = false;
//            }
//            d = (d * a) % n;
//            i+=;
//        }
//        Console.WriteLine(i);
//    }
//}
#endregion
#region 1226.          esreveR redrO    
//using System;
//using System.Collections.Generic;
//using System.Linq;
//class GFG
//{

//    public static void Main()
//    {
//        {
//            var text = Console.In.ReadToEnd();
//            var stack = new Stack<char>();
//            for (int i = 0; i < text.Length; i++)
//            {
//                if (char.IsLetter(text[i]))
//                    stack.Push(text[i]);
//                else
//                {
//                    while (stack.Count > 0)
//                    {
//                        Console.Write(stack.Pop());
//                    }
//                    Console.Write(text[i]);
//                }
//            }
//            while (stack.Count > 0)
//            {
//                Console.Write(stack.Pop());
//            }
//        }
//    }
//}
#endregion
#region 2010.           Sasha the Young Grandmaster 
//using System;
//using System.Collections.Generic;
//using System.Linq;
//class GFG
//{
//    public static void Main()
//    {

//        var n = Convert.ToInt32(Console.ReadLine());
//        var xy = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
//        if (n==0)
//        {
//            Console.WriteLine("King: " + 0);
//            Console.WriteLine("Knight: " + 0);
//            Console.WriteLine("Bishop: " + 0);
//            Console.WriteLine("Rook: " + 0);
//            Console.WriteLine("Queen: " + 0);
//            return;

//        }
//        var x = xy[0];
//        var y = xy[1];
//        kingStep(n, x, y);
//        knightStep(n, x, y);
//        var bish = bishopStep(n, x, y);
//        var rook = rookStep(n, x, y);
//        long queen = bish + rook;
//        Console.WriteLine("Queen: " + queen);

//    }
//    static void kingStep(int n, long x, long y)
//    {
//        long countKing = 0;
//        if ((x - 1) > 0) countKing++;
//        if ((x - 1) > 0 && y + 1 <= n) countKing++;
//        if ((y + 1) <= n) countKing++;
//        if ((x + 1) <= n && (y + 1) <= n) countKing++;
//        if ((x + 1) <= n) countKing++;
//        if ((x + 1) <= n && (y - 1) > 0) countKing++;
//        if ((y - 1) > 0) countKing++;
//        if ((x - 1) > 0 && (y - 1) > 0) countKing++;
//        Console.WriteLine("King: " + countKing);
//    }
//    static void knightStep(int n, long x, long y)
//    {
//        long countKnight = 0;
//        if ((x - 2) > 0 && (y + 1) <= n) countKnight++;
//        if ((x - 2) > 0 && (y - 1) > 0) countKnight++;
//        if ((y + 2) <= n && (x - 1) > 0) countKnight++;
//        if ((y + 2) <= n && (x + 1) <= n) countKnight++;
//        if ((x + 2) <= n && (y + 1) <= n) countKnight++;
//        if ((x + 2) <= n && (y - 1) > 0) countKnight++;
//        if ((y - 2) > 0 && (x + 1) <= n) countKnight++;
//        if ((y - 2) > 0 && (x - 1) > 0) countKnight++;

//        Console.WriteLine("Knight: " + countKnight);
//    }
//    static long bishopStep(int n, long x, long y)
//    {
//        long countBishop = 0;
//        long left = x - 1;
//        long right = n - x;
//        if (y + left <= n)
//        {
//            countBishop += left;
//        }
//        else countBishop += n - y;
//        if (y + right <= n)
//        {
//            countBishop += right;
//        }
//        else countBishop += n - y;
//        if (y - left > 0)
//        {
//            countBishop += left;
//        }
//        else countBishop += y - 1;
//        if (y - right > 0)
//        {
//            countBishop += right;
//        }
//        else countBishop += y - 1;
//        Console.WriteLine("Bishop: " + countBishop);
//        return countBishop;
//    }
//    static long rookStep(int n, long x, long y)
//    {
//        long countRook = (x - 1) + (n - x) + (y - 1) + (n - y);
//        Console.WriteLine("Rook: " + countRook);
//        return countRook;

//    }
//}
#endregion
#region 1644. A Whole Lot of Walnuts
//using System;
//using System.Collections.Generic;
//using System.Linq;
//class GFG
//{
//    public static void Main()
//    {
//        var n = Convert.ToInt32(Console.ReadLine());
//        int hun = 2;
//        int sat = 10;
//        string s;
//        for (int i = 0, num; i < n; i++)
//        {
//            var nums = Console.ReadLine().Split(' '); ;
//            num = Convert.ToInt32(nums[0]);
//            s = nums[1].ToString();
//            if (s == "hungry")
//                if (num > hun)
//                    hun = num;
//            if (s == "satisfied")
//                if (num < sat)
//                    sat = num;
//        }
//        if (hun >= sat)
//            Console.WriteLine("Inconsistent");
//        else
//            Console.WriteLine(sat);
//    }
//}
#endregion
#region 1572.          Yekaterinozavodsk Great Well
//using System;
//using System.Collections.Generic;
//using System.Linq;
//class GFG
//{
//    public static void Main()
//    {
//        var kol = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
//        var chekType = kol[0];
//        var line = kol[1];
//        var n = Convert.ToInt32(Console.ReadLine());
//        double bound = 1;
//        if (chekType==1)
//        {
//            bound = 2*line;
//        }
//        else if (chekType==2)
//        {
//            bound = line * Math.Sqrt(2);
//        }
//        else if(chekType==3)
//        {
//            bound = line;
//        }
//        int count = 0;
//        for (int i = 0; i < n; i++)
//        {
//            var TypeAndLine = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
//            var typ = TypeAndLine[0];
//            var lin = TypeAndLine[1];

//            if (typ == 1)
//            {
//                if (bound>=2*lin)
//                {
//                    count++;
//                }
//            }
//            else if (typ == 2)
//            {
//                if (bound>=lin)
//                {
//                    count++;
//                }
//            }
//            else if (typ == 3)
//            {
//                if (bound>=(Math.Sqrt(3)*lin)/2)
//                {
//                    count++;
//                }
//            }
//        }
//        Console.WriteLine(count);
//    }
//}
#endregion
#region 1206.       Sum of Digits of the Sum of Numbers
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Numerics;

//class GFG
//{

//    public static void Main()
//    {
//        var xnz = Convert.ToInt32(Console.ReadLine());
//        var n = xnz;
//        BigInteger ans1 = 0;
//        BigInteger ans2 = 0;
//        for (int i = 1; i < 10; i++)
//        {
//            for (int j = 1; j < 10; j++)
//            {
//                if (i + j < 10)
//                {
//                  ans1=  BigInteger.Add(ans1, 1);

//                }
//            }
//        }
//        for (int i = 0; i < 10; i++)
//        {
//            for (int j = 0; j < 10; j++)
//            {
//                if (i + j < 10)
//                {
//                   ans2= BigInteger.Add(ans2, 1);
//                }
//            }
//        }
//        for (int i = 1; i < n; i++)
//        {
//            ans1 = BigInteger.Multiply(ans1, ans2);
//        }
//        Console.WriteLine(ans1);
//    }
//}
#endregion
#region 1021.       Sacrament of the Sum

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Numerics;

//class GFG
//{
//    public static void Main()
//    {
//        int n1, n2;
//        n1 = Convert.ToInt32(Console.ReadLine());
//        int[] a1 = new int[100000];

//        for (int i = 0; i < n1; i++) a1[i] = Convert.ToInt32(Console.ReadLine());
//        n2 = Convert.ToInt32(Console.ReadLine());
//        int[] a2 = new int[100000];

//        for (int i = 0; i < n2; i++) a2[i] = Convert.ToInt32(Console.ReadLine());
//        int m = 0;
//        int n = 0;
//        bool bk = false;
//        while (m < n1 || n < n2)
//        {
//            if (a1[m] + a2[n] == 10000)
//            {
//                bk = true;
//                break;
//            }
//            if (a1[m] + a2[n] < 10000)
//                if (m == n1-1) break; else m++;
//            else
//              if (n == n2-1) break; else n++;
//        }
//        if (bk == false) Console.WriteLine("NO");
//        else Console.WriteLine("YES");
//    }
//}

#endregion
#region 1613.   For Fans of Statistics  
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Numerics;
//using System.Reflection.Metadata.Ecma335;

//class GFG
//{
//    public static void Main()
//    {
//        var n = Convert.ToInt32(Console.ReadLine());

//        int[] a = new int[n];
//        int[] b = new int[n];
//        int forward;
//        int backward;
//        int from;
//        int to;
//        int index;
//        var ss = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//        for (int i = 0; i < n; i++)
//        {
//            a[i] = ss[i];
//            b[i] = i;
//        }
//        sort(a, 0, a.Length - 1, b);
//        int q = Convert.ToInt32(Console.ReadLine());

//        for (int i = 0; i < q; i++)
//        {
//            var line = Console.ReadLine().Split(' ');
//            int l = 0;

//            from = Convert.ToInt32(line[0]) - 1;
//            to = Convert.ToInt32(line[1]) - 1;
//            var val = Convert.ToInt32(line[2]);
//            if (from == to)
//            {
//                if (ss[from] == val)
//                {
//                    Console.Write(1);
//                    continue;
//                }
//                else
//                {
//                    Console.Write(0);
//                    continue;
//                }
//            }
//            else if (ss[from] == val)
//            {
//                Console.Write(1);
//                continue;
//            }
//            else if (ss[to] == val)
//            {
//                Console.Write(1);
//                continue;

//            }


//            index = search(a, Convert.ToInt32(line[2]));
//            forward = index;

//            while (forward >= 0 && forward < a.Length && (a[forward] == a[index]))
//            {
//                int realPlace = b[forward++];
//                if (realPlace <= to && realPlace >= from)
//                {
//                    l = 1; break;
//                }
//            }
//            Console.Write(l);
//        }
//    }
//    public static int search(int[] a, int find)
//    {
//        int low = 0;
//        int high = a.Length - 1;

//        if (a.Length == 0) return -1;

//        while (low <= high)
//        {
//            int mid = (low + high) / 2;
//            if (find > a[mid])
//            {
//                low = mid + 1;
//            }
//            else if (find < a[mid])
//            {
//                high = mid - 1;
//            }
//            else if (low != mid)
//            {
//                high = mid;
//            }
//            else
//            {
//                return mid;
//            }
//        }
//        return -1;
//    }

//    public static void sort(int[] a, int left, int right, int[] b)
//    {
//        int i = left;
//        int j = right;
//        int tmp;
//        int pivot = a[(left + right) / 2];
//        do
//        {
//            while (i < right && a[i] < pivot) i++;
//            while (j > left && a[j] > pivot) j--;
//            if (i <= j)
//            {
//                tmp = a[i];
//                a[i] = a[j];
//                a[j] = tmp;
//                int bb = b[i];
//                b[i] = b[j];
//                b[j] = bb;
//                i++;
//                j--;
//            }
//        } while (i <= j);

//        if (left < j) sort(a, left, j, b);
//        if (i < right) sort(a, i, right, b);
//    }
//}
#endregion
#region 1082.       Gaby Ivanushka
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Numerics;

//class GFG
//{

//    public static void Main()
//    {
//        var n = Convert.ToInt32(Console.ReadLine());
//        for (int i = 1; i <= n; i++)
//        {
//            Console.Write(" " + i);
//        }
//    }
//}
#endregion
#region 1084.     Goat in the Garden
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Numerics;

//class GFG
//{

//    public static void Main()
//    {

//        var squareLine = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
//        var square = squareLine[0];
//        var line = squareLine[1];
//        if (square * Math.Sqrt(2) / 2 <= line)
//        {
//            var sum = square * square;
//            var sumt = String.Format("{0:0.000}", sum);
//            Console.WriteLine(sumt);
//            return;
//        }
//        if (square / 2 >= line)
//        {
//            var sum = Math.PI * Math.Pow(line, 2);
//            var sumt = String.Format("{0:0.000}", sum);
//            Console.WriteLine(sumt);
//            return;
//        }

//        double cosx = (square / 2) / line;
//        double sinx = Math.Sqrt(1 - cosx * cosx);
//        double cosA = 2 * sinx * cosx;
//        double theta = Math.Acos(cosA);
//        var sumsd = line * line * 0.5 * theta * 4 + Math.Sqrt(line * line- (square/ 2) * (square/ 2)) * (square/ 2) * 4;
//        var sumts = String.Format("{0:0.000}", sumsd);
//        Console.WriteLine(sumts);
//    }
//}
#endregion
#region 1123.       Salary
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Numerics;

//class GFG
//{
//    static void Main()
//    {
//        var salary = Console.ReadLine().ToArray();
//        int j = salary.Length - 1;
//        for (int i = 0; i < salary.Length / 2; i++, j--)
//        {
//            if (salary[i] >= salary[j])
//            {
//                salary[j] = salary[i];
//            }
//            else
//            {
//                int l = j - 1;
//                while (salary[l] == '9')
//                {
//                    salary[l--] = '0';
//                }
//                salary[l]++;
//                salary[j] = salary[i];
//            }
//        }
//        Console.WriteLine(salary);
//    }
//}
#endregion
#region 1283.        Dwarf
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Numerics;

//class GFG
//{

//    public static void Main()
//    {
//        var abc = Console.ReadLine().Split(' ').Select(float.Parse).ToArray();
//        var a = abc[0];
//        var b = abc[1];
//        var c = abc[2];

//        c = (100 - c) / 100;
//        int ans = 0;
//        while (a > b)
//        {
//            a *= c;
//            ++ans;
//        }
//        Console.WriteLine(ans);
//    }
//}

#endregion
#region 1052. Rabbit Hunt   
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Numerics;

//class GFG
//{

//    public static void Main()
//    {
//        var n = Convert.ToInt32(Console.ReadLine());
//        double[] arrX = new double[n];
//        double[] arrY = new double[n];

//        for (int i = 0; i < n; i++)
//        {
//            var xy = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
//            arrX[i] = xy[0];
//            arrY[i] = xy[1];
//        }

//        float max = 1;
//        int kk = 1; double coef, b;
//        int currentMax = 1;
//        for (int i = 0; i < n; i++)
//        {
//            double x1 = arrX[i];
//            double y1 = arrY[i];
//            kk = 1;
//            for (int j = i; j < n; j++)
//            {
//                if (j == i)
//                {
//                    continue;
//                }
//                currentMax = 1;
//                double x2 = arrX[j];
//                double y2 = arrY[j];
//                if (x2 - x1 == 0)
//                {
//                    coef = 1;
//                    b = x1;
//                    for (int k = 0; k < n; k++)
//                    {
//                        if (j == k || j == i)
//                        {
//                            continue;
//                        }
//                        if (Math.Abs(arrX[k] -arrX[j])   < 0.000000001)
//                        {
//                            currentMax++;
//                        }
//                    }
//                }
//                else
//                {
//                    coef = (y2 - y1) / (x2 - x1);
//                    b = y1 - coef * x1;
//                    for (int k = 0; k < n; k++)
//                    {
//                        if (j == k||j==i)
//                        {
//                            continue;
//                        }
//                        if (Math.Abs((arrY[k] - (coef * arrX[k]) - b ) )< 0.000000001)
//                        {
//                            currentMax++;
//                        }
//                    }
//                }

//                kk = Math.Max(currentMax, kk);
//            }
//            max = Math.Max(max, kk);

//        }
//        Console.Write(max);

//    }
//}
#endregion
#region 1642. 1D Maze
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Numerics;
//class GFG
//{

//    public static void Main()
//    {
//        var nm = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
//        var n = nm[0];
//        var ex = nm[1];

//        if (n == 0 && ex == 0)
//        {
//            Console.WriteLine("0 0");
//            return;
//        }
//        if (n == 0 && ex != 0)
//        {
//            Console.WriteLine("Impossible");
//            return;
//        }
//        if (ex == 0)
//        {
//            Console.WriteLine("0 0");
//            return;
//        }
//        var mass = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
//        int left = 0;
//        int right = 0;
//        int pos = 0;

//        //if (ex == 1 && n == 1)
//        //{
//        //    if (mass[0] == -1)
//        //    {
//        //        Console.WriteLine(1 + " " + 3);
//        //        return;
//        //    }
//        //    else
//        //    {

//        //    }

//        //}
//        mass.Add(0);
//        mass.Sort();

//        var ind = mass.IndexOf(0);
//        if (ind == 0 && ex > 0)
//        {
//            Console.WriteLine("Impossible");
//            return;
//        }
//        if (ind == mass.Count - 1 && ex < 0)
//        {
//            Console.WriteLine("Impossible");
//            return;
//        }
//        if (ex > 0)
//        {
//            if (ind == mass.Count - 1)
//            {
//                right = (int)ex;
//                left = (int)ex + 2*(int)Math.Abs(mass[ind - 1]);
//                Console.WriteLine(right + " " + left);
//                return;
//            }
//            if (ind <= mass.Count - 1)
//            {
//                if (mass[ind + 1] < ex)
//                {
//                    Console.WriteLine("Impossible");
//                    return;
//                }
//                else
//                {
//                    if (ind - 1 >= 0)
//                    {
//                        right = (int)ex;
//                        left = (int)ex + 2 * (int)Math.Abs(mass[ind - 1]);
//                        Console.WriteLine(right + " " + left);
//                        return;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Impossible");
//                        return;
//                    }

//                }
//            }
//        }
//        if (ex < 0)
//        {
//            if (ind == 0)
//            {
//                left = Math.Abs((int)ex);
//                right = (int)left + 2 * (int)Math.Abs(mass[ind + 1]);
//                Console.WriteLine(right + " " + left);
//                return;
//            }
//            if (ind > 0)
//            {
//                if (mass[ind - 1] > ex)
//                {
//                    Console.WriteLine("Impossible");
//                    return;
//                }
//                else
//                {
//                    if (ind - 1 >= 0)
//                    {
//                        left = Math.Abs((int)ex);
//                        right = (int)left + 2 * (int)Math.Abs(mass[ind + 1]);
//                        Console.WriteLine(right + " " + left);
//                        return;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Impossible");
//                        return;
//                    }

//                }
//            }
//        }



//    }
//}
#endregion
#region 1612. Tram Forum
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Numerics;

//class GFG
//{

//    static void Main()
//    {
//        string[] ss = Console.In.ReadToEnd().Split(new char[] { ' ', '\t', '\n', '\r', '.', ',', '!', '?', '-', ':' },
//            StringSplitOptions.RemoveEmptyEntries);

//        var r = (from u in ss
//                 where u == "tram" || u == "trolleybus"
//                 group u by u into uu
//                 orderby uu.Key
//                 select new { key = uu.Key, count = uu.Count() }).ToList();
//        if (r.Count == 0) Console.WriteLine("Bus driver");
//        else
//            if (r.Count == 1) Console.WriteLine("{0}", r[0].key == "tram" ? "Tram driver" : "Trolleybus driver");
//        else if (r[0].count > r[1].count) Console.WriteLine("Tram driver");
//        else
//            if (r[0].count < r[1].count) Console.WriteLine("Trolleybus driver"); else Console.WriteLine("Bus driver");
//    }
//}
#endregion
#region 1402. Cocktails
//using System;
//using System.Numerics;

//class GFG
//{

//    static void Main()
//    {
//        var n = Convert.ToInt32(Console.ReadLine());
//        if (n==1)
//        {
//            Console.WriteLine(0);
//            return;
//        }
//        if (n==2)
//        {
//            Console.WriteLine(2);
//            return;
//        }
//        BigInteger bigInteger = new BigInteger();
//        for (int i = 2; i <= n; i++)
//        {
//            bigInteger = BigInteger.Add(bigInteger, A(n, i));

//        }
//        Console.WriteLine(bigInteger);
//    }

//    private static BigInteger A(int n, int ii)
//    {
//        BigInteger big1 = new BigInteger(1);
//        BigInteger big2 = new BigInteger(1);

//        for (int i = 1; i <= n; i++)
//        {
//            big1 = BigInteger.Multiply(new BigInteger(i), big1);
//        }
//        for (int i = 1; i <= n-ii; i++)
//        {
//            if (n-ii==0)
//            {
//                big2 = new BigInteger(1);
//            }
//            else
//            {
//                big2 = BigInteger.Multiply(new BigInteger(i), big2);
//            }
//        }
//        return BigInteger.Divide(big1, big2);

//    }
//    //An^2>n
//}
#endregion
#region 1874. Football Goal 
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Numerics;

//class GFG
//{

//    static void Main()
//    {
//        var ab = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
//        var a = ab[0];
//        var b = ab[1];
//        var Area = (Math.Pow(a, 2) + Math.Pow(b, 2)) / 4 + a * b / Math.Sqrt(2);
//        var sumt = String.Format("{0:0.000000000}", Area);

//        Console.WriteLine(sumt);
//    }
//}
#endregion
#region 2000.  Grand Theft Array V
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Numerics;

//class GFG
//{

//    static void Main()
//    {
//        var n = Convert.ToInt32(Console.ReadLine());
//        var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//        var x1x2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//        var x1 = x1x2[0] - 1;
//        var x2 = x1x2[1] - 1;
//        long sum1 = 0;
//        long sum2 = 0;

//        if (x1 == x2)
//        {
//            int sum11 = 0, sum22 = 0;
//            for (int i = 0; i < x1; i++)
//            {
//                sum11 += arr[i];
//            }
//            for (int j = x1 + 1; j < n; ++j) sum22 += arr[j];
//            Console.WriteLine(Math.Max(sum11, sum22) + arr[x1] + " " + Math.Min(sum11, sum22));
//            return;
//        }
//        if (x1 == x2)
//        {
//            x2 = x2 - 1;
//            for (int i = 0; i < arr.Length; i++)
//            {
//                sum1 += arr[i];
//            }
//            for (int i = x2; i >= 0; i--)
//            {
//                sum2 += arr[i];
//            }
//            Console.WriteLine(sum1 + " " + sum2);
//            return;
//        }
//        if (x1 < x2)
//        {
//            for (int i = 0; i <= x1; i++)
//            {
//                sum1 += arr[i];
//            }
//            for (int i = x2; i < arr.Length; i++)
//            {
//                sum2 += arr[i];
//            }
//            int j = x1;
//            int k = x2;
//            while (true)
//            {
//                if (++j == k)
//                {
//                    break;
//                }
//                else
//                {
//                    sum1 += arr[j];
//                }
//                if (j == --k)
//                {
//                    break;
//                }
//                else
//                {
//                    sum2 += arr[k];
//                }
//            }
//            Console.WriteLine(sum1 + " " + sum2);
//        }
//        else if (x1 > x2)
//        {
//            for (int i = 0; i <= x2; i++)
//            {
//                sum2 += arr[i];
//            }
//            for (int i = x1; i < arr.Length; i++)
//            {
//                sum1 += arr[i];
//            }
//            int j = x2;
//            int k = x1;
//            while (true)
//            {
//                if (j == --k)
//                {
//                    break;
//                }
//                else
//                {
//                    sum1 += arr[k];
//                }
//                if (++j == k)
//                {
//                    break;
//                }
//                else
//                {
//                    sum2 += arr[j];
//                }

//            }
//            Console.WriteLine(sum1 + " " + sum2);
//        }
//        else
//        {
//            for (int i = 0; i <= x1; i++)
//            {
//                sum1 += arr[i];
//            }
//            for (int i = x2; i < arr.Length; i++)
//            {
//                sum2 += arr[i];
//            }
//            Console.WriteLine(sum1 + " " + sum2);
//        }


//    }
//}
#endregion
#region 1118. Nontrivial Numbers   
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Numerics;
//class GFG
//{
//    static void Main()
//    {
//        var nm = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//        var a = nm[0];
//        var b = nm[1];
//        var min = double.MaxValue;
//        var result = 0;
//        if (a == b)
//        {
//            Console.WriteLine(a);
//            return;
//        }
//        if (a == 1)
//        {
//            Console.WriteLine(1);
//            return;
//        }
//        for (int i = b; i >= a; i--)
//        {
//            double t = Trivial(i);
//            if (t == -2)
//            {
//                Console.WriteLine(i);
//                return;
//            }
//            if (min > t)
//            {
//                min = t;
//                result = i;
//            }
//        }
//        Console.WriteLine(result);
//    }
//    public static double Trivial(int n)
//    {
//        var sum = 1;
//        for (int i = 2; i * i < n; i++)
//        {
//            if (n % i == 0)
//            {
//                sum += (i + n / i);
//            }
//        }
//        if (sum == 1)
//        {
//            return -2;
//        }
//        return (double)sum / n;
//    }
//}
#endregion
#region 2020. Traffic Jam in Flower Town
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Numerics;

//class GFG
//{

//    static void Main()
//    {
//        var bottom = Console.ReadLine();
//        var top = Console.ReadLine();
//        int bottomLength = bottom.Length; ;
//        int topLength = top.Length;
//        int i = 0;
//        int j = 0;
//        int sec = 0;
//        int index = 0;
//        bool isTop = false;
//        bool isButtom = false;

//        while (i < bottomLength && j < topLength)
//        {

//            if ((top[j] == 'F' && bottom[i] == 'F') ||
//                (top[j] == 'L' && bottom[i] == 'L') || (top[j] == 'R' && bottom[i] == 'R') || (top[j] == 'F' && bottom[i] == 'R')
//                || (top[j] == 'R' && bottom[i] == 'F'))
//            {
//                i++;
//                j++;
//                sec++;
//                if (i == bottomLength)
//                {
//                    isButtom = true;
//                    index = j;
//                    break;
//                }
//                if (j == topLength)
//                {
//                    isTop = true;
//                    index = i;

//                    break;
//                }
//            }
//            else if (top[j] == 'L')
//            {
//                i++;
//                sec++;

//                if (i == bottomLength)
//                {
//                    isButtom = true;
//                    index = j;
//                    break;
//                }
//                if (j == topLength)
//                {
//                    isTop = true;
//                    index = i;

//                    break;
//                }
//            }
//            else
//            {
//                j++;
//                sec++;

//                if (i == bottomLength)
//                {
//                    isButtom = true;
//                    index = j;
//                    break;
//                }
//                if (j == topLength)
//                {
//                    isTop = true;
//                    index = i;

//                    break;
//                }
//            }

//        }
//        if (isTop)
//        {
//            for (int m = index; m < bottomLength; m++)
//            {
//                sec++;
//            }
//        }
//        else if (isButtom)
//        {
//            for (int m = index; m < topLength; m++)
//            {
//                sec++;
//            }

//        }


//        Console.WriteLine(sec);

//    }
//}
#endregion
#region 1353. 1740. Deer is Better!
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Numerics;

//class GFG
//{
//    static void Main()
//    {
//        var s = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//        int l = s[0];
//        int r = s[1];
//        int t = s[2];
//        if (l % r == 0)
//        {
//            Console.WriteLine(String.Format("{0:0.00000000}", t * (l / r)) + " " + String.Format("{0:0.00000000}", (t * (l / r))));

//        }
//        else
//        {
//            Console.WriteLine(String.Format("{0:0.00000000}", t * (l / r)) + " " + (String.Format("{0:0.00000000}", (t * ((l / r)+1)) )));

//        }

//    }
//}
#endregion
#region 1336.  Problem of Ben Betsalel
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Numerics;

//class GFG
//{
//    static void Main()
//    {
//        var n = Convert.ToInt64(Console.ReadLine());
//        Console.WriteLine(n * n + " " + n);
//    }
//}
#endregion
#region 1711.  Code Names
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Numerics;

//class GFG
//{
//    static void Main()
//    {
//        var n = Convert.ToInt32(Console.ReadLine());
//        var t = new Dictionary<int, SortedList<string, int>>();
//        int j = 1;
//        int jj = 1;

//        for (int i = 0; i < n; i++)
//        {
//            var tt = Console.ReadLine().Split();
//            var m = new SortedList<string, int>() { };
//            for (int k = 0; k < 3; k++)
//            {
//                m.Add(tt[k], j++);
//            }
//            t.Add(jj++, m);

//        }
//        var buff = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//        var list = new List<string>() { };
//        bool ttt = true;
//        var Laststate = 0;
//        var mm = t[buff[0]].Keys[0];
//        list.Add(mm);

//        for (int i = 1; i < buff.Length; i++)
//        {

//            for (int jjj = 0; jjj < 3; jjj++)
//            {
//                if (String.Compare(list.Last(), t[buff[i]].Keys[jjj]) < 0)
//                {
//                    list.Add(t[buff[i]].Keys[jjj]);
//                    break;
//                }

//            }
//        }
//        if (list.Count!=n)
//        {
//            Console.WriteLine("IMPOSSIBLE");
//            return;

//        }
//        for (int i = 0; i < list.Count; i++)
//        {
//            Console.WriteLine(list[i]);

//        }
//    }
//}
#endregion
#region 2102. Michael and Cryptography
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Numerics;

//class GFG
//{
//    static void Main()
//    {
//        var n = Convert.ToInt64(Console.ReadLine());
//        int sum = 0;

//        while (n % 2 == 0)
//        {
//            n = n / 2;
//            sum++;
//            if (sum > 20)
//            {
//                Console.WriteLine("No");
//                return;
//            }
//        }

//        for (int i = 3; i < 10000000; i += 2)
//        {
//            while (n % i == 0)
//            {
//                n = n/i;
//                sum++;
//            }
//            if (sum > 20)
//            {
//                Console.WriteLine("No");
//                return;
//            }
//        }

//        if (n > 2)
//        {
//            sum++;
//        }

//        if (sum == 20)
//        {
//            Console.WriteLine("Yes");
//        }
//        else
//        {
//            Console.WriteLine("No");
//        }
//    }
//}

#endregion
#region 1688. Team.GOV!
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Numerics;

//class GFG
//{
//    static void Main()
//    {
//        var nm = Console.ReadLine().Split().Select(long.Parse).ToArray();
//        var n = nm[0];
//        var m = nm[1];

//        n *= 3;
//        for (int i = 0; i < m; i++)
//        {
//          var  x = Convert.ToInt64(Console.ReadLine());
//            n -= x;
//            if (n < 0)
//            {
//                Console.WriteLine("Free after " + (i + 1) + " times.");
//                return;
//            }
//        }

//        Console.WriteLine("Team.GOV!");
//    }
//}
#endregion
#region 1582. Bookmakers
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Numerics;

//class GFG
//{
//    static void Main()
//    {
//        var k1k2k3 = Console.ReadLine().Split().Select(float.Parse).ToArray();
//        Console.WriteLine(Math.Round(1000*k1k2k3[0]* k1k2k3[1]* k1k2k3[2]/(k1k2k3[0]* k1k2k3[1] + k1k2k3[0]*k1k2k3[2]+ k1k2k3[2]* k1k2k3[1])));
//    }
//}
#endregion
#region 1219. Symbolic Sequence
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Numerics;

//class GFG
//{
//    static void Main()
//    {
//        Random rands=new Random();
//        for (int i = 0; i < 1000000; i++)
//        {
//            var k = rands.Next() % 26;
//            k += 97;
//            Console.Write((char)k);
//        }
//    }
//}
#endregion
#region 1777. Anindilyakwa
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Numerics;

//class GFG
//{
//    static void Main()
//    {

//        long[] r = new long[200];
//        long a = 3;
//        long min;
//        var x = new List<long>();
//        var t= Console.ReadLine().Split().Select(long.Parse).ToArray();
//        bool z = false;
//        for (int i = 0; i < 3; i++)
//        {
//            x.Add(t[i]);
//        }
//        for (; ; )
//        {
//            x.Sort();
//            min = long.MaxValue;
//            for (int i = 1; i < a ; i++)
//            {
//                r[i] = Math.Abs(x[i-1] - x[i]);
//                if (r[i] < min)
//                    min = r[i];
//            }
//            x.Add(min);
//            for (int j = 0; j < a; j++)
//            {
//                if (x[j] == min)
//                {
//                    z = true;
//                    break;
//                }
//            }
//            if (z == true) break;
//            a++;
//        }
//        Console.WriteLine(a - 1);
//    }
//}
#endregion
#region 1562. GM-pineapple
//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.Linq;
//using System.Numerics;
//namespace Geometry
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            GMPineapple();
//        }
//        private static double a;
//        private static double b;
//        private static double n;
//        static void GMPineapple()
//        {
//            var abn = Console.ReadLine().Split().Select(double.Parse).ToArray();
//            a = abn[0];
//            b = abn[1];
//            n = abn[2];
//            var step = b / n;
//            a /= 2;
//            b /= 2;
//            var x = b;
//            for (int i = 1; i <= n; i++)
//            {
//                var temp = F(step * i) - F(step * (i - 1));
//                Console.WriteLine($"{Math.Abs(temp):0.000000}");
//            }
//        }
//        static double F(double x)
//        {
//            return Math.PI * a * a * (x * x / b - (x * x * x) / (3 * b * b));
//        }
//    }
//}
#endregion
#region 1348. Goat in the Garden 2
//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.Linq;
//using System.Numerics;
//namespace Geometry
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            GoatintheGarden2();
//        }
//        static void GoatintheGarden2()
//        {
//            var input = Console.In.ReadToEnd()
//                .Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse)
//                .ToList();
//            var ax = input[0];
//            var ay = input[1];
//            var bx = input[2];
//            var by = input[3];
//            var cx = input[4];
//            var cy = input[5];
//            var l = input[6];
//            var ac = Math.Sqrt(Math.Pow(ax - cx, 2) + Math.Pow(ay - cy, 2));
//            var bc = Math.Sqrt(Math.Pow(bx - cx, 2) + Math.Pow(by - cy, 2));
//            var ab = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2));
//            var p = (ac + bc + ab) / 2;
//            var s = Math.Sqrt(p * (p - ac) * (p - ab) * (p - bc));
//            double mindif = 0;
//            if (ab == 0)
//            {
//                mindif = ac;
//                Console.WriteLine($"{Math.Max(mindif - l, 0):0.00}");
//                Console.WriteLine($"{Math.Max(Math.Max(ac, bc) - l, 0):0.00}");
//                return;
//            }
//            var ch = 2 * s / ab;
//            var hb = Math.Sqrt(Math.Pow(Math.Max(bc, ac), 2) - Math.Pow(ch, 2));
//            if (hb <= ab)
//            {
//                mindif = ch;
//            }
//            else if (hb > ab)
//            {
//                mindif = Math.Min(ac, bc);
//            }
//            Console.WriteLine($"{Math.Max(mindif - l, 0):0.00}");
//            Console.WriteLine($"{Math.Max(Math.Max(ac, bc) - l, 0):0.00}");
//        }
//    }
//}
#endregion
#region 1111. Squares ??????????????
//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.Linq;
//using System.Numerics;
//namespace Geometry
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var n = Convert.ToInt32(Console.ReadLine());
//            var sortList = new SortedList<double, int>();
//            List<List<Point>> listPoints = new List<List<Point>>();
//            for (int i = 0; i < n; i++)
//            {
//                listPoints.Add(new List<Point>());
//                var t = Console.ReadLine().Split().Select(int.Parse).ToArray();
//                listPoints[i].Add(new Point(t[0], t[1]));
//                listPoints[i].Add(new Point(t[0]+t[2]/2-(t[3]-t[1]/2),t[1]+t[3]/2+(t[2]-t[0])/2 ));
//                listPoints[i].Add(new Point(t[2], t[3]));
//                listPoints[i].Add(new Point(t[0] + t[2] / 2 + (t[3] - t[1] / 2), t[1] + t[3] / 2 - (t[2] - t[0]) / 2));
//            }
//            var tt = Console.ReadLine().Split().Select(int.Parse).ToArray();
//            var StartPoint = new Point(tt[0], tt[1]);
//            for (int i = 0; i < n; i++)
//            {
//                var min = 1000000000000.0;

//                if (listPoints[i][0].X > StartPoint.X && listPoints[i][1].X < StartPoint.X)
//                {
//                    min = Math.Min(min, Math.Abs(StartPoint.Y - listPoints[i][1].Y));
//                }
//                if (listPoints[i][0].Y > StartPoint.Y && listPoints[i][1].Y < StartPoint.Y)
//                {
//                    min = Math.Min(min, Math.Abs(StartPoint.X - listPoints[i][1].X));
//                }
//                if (listPoints[i][1].X > StartPoint.X && listPoints[i][2].X < StartPoint.X)
//                {
//                    min = Math.Min(min, Math.Abs(StartPoint.Y - listPoints[i][2].Y));
//                }
//                if (listPoints[i][1].Y > StartPoint.Y && listPoints[i][2].Y < StartPoint.Y)
//                {
//                    min = Math.Min(min, Math.Abs(StartPoint.X - listPoints[i][2].X));

//                }
//                if (listPoints[i][2].X > StartPoint.X && listPoints[i][3].X < StartPoint.X)
//                {
//                    min = Math.Min(min, Math.Abs(StartPoint.Y - listPoints[i][3].Y));
//                }
//                if (listPoints[i][2].Y > StartPoint.Y && listPoints[i][3].Y < StartPoint.Y)
//                {
//                    min = Math.Min(min, Math.Abs(listPoints[i][3].X - StartPoint.X));

//                }
//                if (listPoints[i][3].X > StartPoint.X && listPoints[i][0].X < StartPoint.X)
//                {
//                    min = Math.Min(min, Math.Abs(StartPoint.Y - listPoints[i][0].Y));
//                }
//                if (listPoints[i][3].Y > StartPoint.Y && listPoints[i][0].Y < StartPoint.Y)
//                {
//                    min = Math.Min(min, Math.Abs(StartPoint.X - listPoints[i][0].X));
//                }
//                if(min< 1000000000000.0)
//                {
//                    sortList.Add(min, i+1);
//                    continue;
//                }
//                for (int j = 0; j < 4; j++)
//                {

//                    var bla = distance(listPoints[i][j].X, listPoints[i][j].Y, StartPoint);
//                    if (min > bla)
//                    {
//                        min = bla;
//                    }
//                }
//                sortList.Add(min, i+1);
//            }
//            for (int i = 0; i < n; i++)
//            {
//                Console.Write(sortList.Values[i]+" ");
//            }
//        }

//        private static double distance(int x, int y, Point startPoint)
//        {
//            return Math.Sqrt(Math.Pow(x - startPoint.X, 2) + Math.Pow(y - startPoint.Y, 2));
//        }
//    }
//}
#endregion
#region 1506. Columns of Numbers
//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.Linq;
//using System.Numerics;
//namespace Geometry
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var nk= Console.ReadLine().Split().Select(double.Parse).ToArray();
//            var bla = Console.ReadLine().Split().Select(double.Parse).ToArray();
//            for (int i = 0; i < (int)Math.Ceiling(nk[0] / nk[1]); i++)
//            {
//                for (int j = i; j < nk[0]; j+=(int)Math.Ceiling(nk[0]/nk[1]))
//                {
//                    if (bla[j]<=9)
//                    {
//                        Console.Write("   " + bla[j]);
//                    } 
//                    else if(bla[j] > 9&&bla[j]<=99)
//                    {
//                        Console.Write("  " + bla[j]);
//                    }
//                    else  
//                    {
//                        Console.Write(" " + bla[j]);
//                    }
//                    if (j+ (int)Math.Ceiling(nk[0] / nk[1]) >= nk[0])
//                    {
//                        Console.WriteLine();
//                        break;
//                    }
//                }
//            }
//        }
//    }
//}
#endregion
#region 1352. Mersenne Primes
//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.Linq;
//using System.Numerics;
//namespace Geometry
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var t = new int[] { 2, 3, 5, 7, 13, 17, 19, 31, 61, 89, 107, 127, 521, 607, 1279, 2203, 2281, 3217, 4253, 4423,
//                                9689, 9941, 11213, 19937, 21701, 23209, 44497, 86243, 110503, 132049, 216091, 756839, 859433, 1257787,
//                                1398269, 2976221, 3021377, 6972593, 13466917, 20996011, 24036583, 25964951, 30402457, 32582657, 37156667, 42643801, 43112609, 57885161 };

//            var n = Convert.ToInt32(Console.ReadLine());
//            for (int i = 0; i < n; i++)
//            {
//                var m = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine(t[m-1]);
//            }
//        }

//    }
//}
#endregion
#region 1683. Fridge
//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.Linq;
//using System.Numerics;
//namespace Geometry
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var n = Convert.ToDouble(Console.ReadLine());
//            n = n ;
//            int count = 0;
//            List<int> list = new List<int>();
//            while (n > 1)
//            {

//                n = n / 2;
//                list.Add((int)n);
//               n= Math.Ceiling(n);
//                count++;
//            }
//            Console.WriteLine(count);
//            foreach (var item in list)
//            {
//                Console.Write(item + " ");

//            }

//        }

//    }
//}
#endregion
#region 1576. Telephone Tariffs
//using System;
//using System.Linq;
//namespace Geometry
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var n1c1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
//            var n1 = n1c1[0];
//            var c1 = n1c1[1];
//            var n2tc2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
//            var n2 = n2tc2[0];
//            var t = n2tc2[1];
//            var c2 = n2tc2[2];
//            var n3 = Convert.ToInt32(Console.ReadLine());
//            var n = Convert.ToInt32(Console.ReadLine());
//            int ans = 0;
//            for (int i = 0; i < n; i++)
//            {
//                var item = Console.ReadLine();
//                int tt = 0;
//                if (item[0] != '0')
//                {
//                    tt = Convert.ToInt32((item[0].ToString() + item[1].ToString()).ToString());
//                }
//                else if (item[1] != '0')
//                {
//                    tt = Convert.ToInt32(item[1].ToString());
//                }
//                else
//                {
//                    tt = 0;
//                }
//                if (item[3] != '0')
//                {
//                    tt++;
//                }
//                else if (item[4] != '0')
//                {
//                    if (Convert.ToInt32(item[4].ToString()) <= 6 && tt == 0)
//                    {
//                        continue;
//                    }
//                    else
//                    {
//                        tt++;
//                    }
//                }
//                ans += tt;
//            }
//            Console.WriteLine("Basic:     " + (n1 + (ans * c1)));
//            Console.WriteLine("Combined:  " + (n2 + Math.Max(0, ans - t) * c2));
//            Console.WriteLine("Unlimited: " + n3);
//        }
//    }
//}
#endregion
#region 1788. On the Benefits of Umbrellas
//using System;
//using System.Linq;
//namespace Geometry
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var nm = Console.ReadLine().Split().Select(int.Parse).ToArray();
//            var n = nm[0];
//            var m = nm[1];
//            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
//            var b = Console.ReadLine().Split().Select(int.Parse).ToArray();

//            Array.Sort(a);
//            Array.Sort(b);
//            Array.Reverse(a);
//            Array.Reverse(b);
//            int ans = (int)1e9, cur;
//            for (int i = 0; i < Math.Min(n, m)+1; i++)
//            {
//                cur = 0;
//                for (int j = i; j < n; ++j) cur += a[j];
//                for (int j = i; j < m; ++j) cur += b[j] * i;
//                ans = Math.Min(ans, cur);
//            }
//            Console.WriteLine(ans);

//        }
//    }
//}
#endregion
#region 1964. Chinese Dialects
//using System;
//using System.Linq;
//namespace Geometry
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //var nk = Console.ReadLine().Split().Select(long.Parse).ToArray();
//            //var n = nk[0];
//            //var k = nk[1];

//            string[] a = Console.In.ReadToEnd().Split(
//         new char[] { ' ', '\t', '\n', '\r' },
//         StringSplitOptions.RemoveEmptyEntries);

//            long sum = 0;
//            for (int i = 2; i < 2 + Convert.ToInt64(a[1]); i++)
//            {
//                sum += Convert.ToInt64(a[i]);
//            }
//            var t = sum - Convert.ToInt64(a[0]) * (Convert.ToInt64(a[1]) - 1);
//            Console.WriteLine(t<0?0:t);
//        }
//    }
//}
#endregion
#region 1940. Not So Simple Years ????????????????????
//using System;
//using System.Collections.Generic;
//using System.Linq;
//namespace Geometry
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var abk = Console.ReadLine().Split().Select(int.Parse).ToArray();
//            var a = abk[0];
//            var b = abk[1];
//            var k = abk[2];
//            var count = 0;
//            var t = a;
//            a++;
//            if ((a) % 2 == 0)
//            {
//                a++;
//            }
//            for (int i = a; i <= t + b; i += 2)
//            {
//                if (isPrime(i, k))
//                {
//                    count++;
//                }
//            }
//            Console.WriteLine(count);
//        }
//        public static bool isPrime(int p, int k)
//        {
//          //  var m = 1;
//            for (int i = 2; i <= Math.Sqrt(p); i++)
//            {
//                if (p % i == 0)
//                {
//                    return false;
//                }
//                if (i == k)
//                {
//                    return true;
//                }
//               // m = m + 2;
//            }
//            return true;
//        }
//        public static void SieveOfEratosthenes(int n)
//        {
//            bool[] prime = new bool[n + 1];

//            for (int i = 0; i < n; i++)
//                prime[i] = true;

//            for (int p = 2; p * p <= n; p++)
//            {
//                if (prime[p] == true)
//                {
//                    for (int i = p * p; i <= n; i += p)
//                        prime[i] = false;
//                }
//            }

//            for (int i = 2; i <= n; i++)
//            {
//                if (prime[i] == true)
//                    Console.Write(i + " ");
//            }

//        }
//    }
//}
#endregion
#region 1142 ????????????????
//using System;
//using System.Collections.Generic;
//using System.Linq;
//namespace Geometry
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var ans = new int[11];
//            var dp = new int[11, 11];
//            dp[1, 1] = 1;

//            for (int i = 2; i <= 10; i++)
//            {
//                for (int j = 1; j <=i; j++)
//                {
//                    dp[i, j] = (dp[i - 1, j] + dp[i - 1, j - 1]) * j;
//                    ans[i] += dp[i, j];
//                }
//            }
//        }
//    }
//}
#endregion
#region 1295. Crazy Notions
//using System;
//using System.Collections.Generic;
//using System.Linq;
//namespace Geometry
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var n = Convert.ToInt32(Console.ReadLine());
//            if (n == 1)
//            {
//                Console.WriteLine(1);
//                return;
//            }
//            else if (n % 4 == 0)
//            {
//                Console.WriteLine(0);
//                return;
//            }
//            else if (n % 4 == 3 || n == 5 || n == 25)
//            {
//                Console.WriteLine(2);
//                return;

//            }
//            else if (n % 4 == 1 && n % 5 == 0)
//            {
//                Console.WriteLine(2);
//            }
//            else
//            {
//                Console.WriteLine(1);

//            }
//        }
//    }
//}
#endregion
#region 	1868. Prediction Contest
//using System;
//using System.Collections.Generic;
//using System.Linq;
//namespace Geometry
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var result = 0;
//            Dictionary<string, string> dict = new Dictionary<string, string>();
//            for (int i = 0; i < 4; i++)
//            {
//                dict.Add(Console.ReadLine(), "gold");
//            }
//            for (int i = 0; i < 4; i++)
//            {
//                dict.Add(Console.ReadLine(), "silver");
//            }
//            for (int i = 0; i < 4; i++)
//            {
//                dict.Add(Console.ReadLine(), "bronze");
//            }
//            var n = Convert.ToInt32(Console.ReadLine());
//            var answer = new int[n];

//            for (int i = 0; i < n; i++)
//            {
//                var count = 0;
//                var m = Convert.ToInt32(Console.ReadLine());
//                for (int j = 0; j < m; j++)
//                {
//                    var rp = Console.ReadLine().Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
//                    if (dict.ContainsKey(rp[0]))
//                        if (dict[rp[0]] == rp[1])
//                            count++;
//                }
//                answer[i] = count;
//            }
//            var max = answer.Max();
//            var counts = answer.Count(x => x == max);
//            Console.WriteLine(counts*5);
//        }
//    }
//}
#endregion
#region 1573. Alchemy
//using System;
//using System.Collections.Generic;
//using System.Linq;
//namespace Geometry
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var color = Console.ReadLine().Split();
//            var colors = new Dictionary<string, int>
//            {
//                {"Blue", int.Parse(color[0])},
//                {"Red", int.Parse(color[1])},
//                {"Yellow", int.Parse(color[2])}
//            };
//            var k = int.Parse(Console.ReadLine());
//            var w = 1;
//            for (int i = 0; i < k; i++)
//            {
//                var c = Console.ReadLine();
//                w *= colors[c];
//            }
//            Console.WriteLine(w);
//        }
//    }
//}
#endregion
#region 1228. Array
//using System;
//using System.Collections.Generic;
//using System.Linq;
//namespace Geometry
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var ns = Console.ReadLine().Split().Select(int.Parse).ToArray();
//            var n = ns[0];
//            var s = ns[1];
//            for (int i = 0; i < n; i++)
//            {
//                var m = Convert.ToInt32(Console.ReadLine());
//                Console.Write(((s / m) - 1) + " ");
//                s = m;
//            }

//        }
//    }
//}
#endregion
#region 1430. Crime and Punishment 
//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Linq;
//namespace Geometry
//{
//    class Program
//    {

//        static long gcd(long a, long b)
//        {

//            if (a == 0)
//                return b;
//            if (b == 0)
//                return a;

//            if (a == b)
//                return a;

//            if (a > b)
//                return gcd(a - b, b);

//            return gcd(a, b - a);
//        }
//        static void Main(string[] args)
//        {
//            var abn = Console.ReadLine().Split().Select(long.Parse).ToArray();
//            var a = abn[0];
//            var b = abn[1];
//            var n = abn[2];
//            long aa = 0;
//            long bb = 0;
//            var tabu = long.MaxValue;

//            //var d = gcd(a, b);
//            //a /= d;
//            //b /= d;
//            //n -= (n % d);
//            //n /= d;

//            if (a == 1)
//            {
//                Console.WriteLine((n - b) + " " + 1);
//                return;
//            }
//            if (b == 1)
//            {
//                Console.WriteLine(1 + " " + (n - a));
//                return;
//            }


//            if (a > b)
//            {
//                if (b > n || a > n)
//                {
//                    Console.WriteLine(0 + " " + 0);
//                    return;
//                }
//                for (int i = 0; i * a <= n; i++)
//                {
//                    if (tabu > (n - (i * a)) % b)
//                    {
//                        tabu = (n - (i * a)) % b;
//                        aa = i;
//                        bb = (n - (i * a)) / b;
//                    }
//                    else if ((n - (i * a)) % b == 0 && i > 1)
//                    {
//                        Console.Write(i + " " + (n - (i * a)) / b);
//                        return;
//                    }

//                }
//                Console.Write(aa + " " + bb);
//                return;

//            }
//            else
//            {
//                if (b > n || a > n)
//                {
//                    Console.WriteLine(0 + " " + 0);
//                    return;
//                }
//                for (int i = 0; i * b <= n; i++)
//                {
//                    if (tabu > (n - (i * b)) % a)
//                    {

//                        tabu = (n - (i * b)) % a;
//                        aa = (n - (i * b)) / a;
//                        bb = i;

//                    }
//                    else if ((n - (i * b)) % a == 0 && i > 1)
//                    {
//                        Console.Write((n - (i * b)) / a + " " + i);
//                        return;
//                    }


//                }
//                Console.Write(aa + " " + bb);
//                return;
//            }
//        }
//    }
//}
#endregion
#region 1201. Which Day Is It?
//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Globalization;
//using System.Linq;
//namespace Geometry
//{
//    class Program
//    {
//        static bool IsLeapYear(int y)
//        {
//            return y % 4 == 0 && (y % 100 != 0 || y % 400 == 0);
//        }
//        static int YearDayesCount(int y)
//        {
//            if (IsLeapYear(y))
//                return 366;
//            else
//                return 365;
//        }

//        static int MonthDayes(int m, int y)
//        {
//             int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
//            if (m != 2)
//                return days[m - 1];
//            else if (IsLeapYear(y))
//                return 29;
//            else
//                return 28;
//        }
//        static int WeekDayes(int m, int d, int y)
//        {
//            int day = 4;
//            int i;
//            for (i = 1600; i < y; i++)
//                day += YearDayesCount(i);
//            for (i = 1; i < m; i++)
//                day += MonthDayes(i, y);
//            day += d;
//            return day % 7;
//        }
//        static void Calculate(int m, int d, int y)
//        {
//            List<string> day_name = new List<string> { "mon", "tue", "wed", "thu", "fri", "sat", "sun" };
//            int days = MonthDayes(m, y);
//            int day_begin = 1 - WeekDayes(m, 1, y);
//            for (int i = 0; i < 7; i++)
//            {
//                Console.Write(day_name[i]);
//                for (int j = day_begin + i; j <= days; j += 7)
//                    if (j < 1 || j > days)
//                        Console.Write("     ");
//                    else if (j == d)
//                    {
//                        if (j < 10)
//                            Console.Write(" [ " + j + "]");
//                        else
//                            Console.Write(" [" + j + "]");
//                    }
//                    else
//                    {
//                        if (j < 10)
//                            Console.Write("   " + j + " ");
//                        else
//                            Console.Write("  " + j + " ");
//                    }
//                Console.WriteLine();

//            }
//        }
//        static void Main(string[] args)
//        {
//            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
//            var d = input[0];
//            var m = input[1];
//            var y = input[2];
//            Calculate(m, d, y);
//        }
//    }
//}
#endregion
#region 1528. Sequence ????????????????????
//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Globalization;
//using System.Linq;
//namespace Geometry
//{

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var Fn = CarculateN(10000);

//            for (int i = 0; ; i++)
//            {
//                var np = Console.ReadLine().Split().Select(int.Parse).ToArray();
//                if (np[0] == 0 || np[1] == 0)
//                {
//                    return;
//                }

//                Console.WriteLine(Fn);
//            }
//        }

//        private static long CarculateN(long n)
//        {
//            List<long> ListOfG = new List<long>();
//            ListOfG = CalculateTheGList(n);

//            return CalculateFn(ListOfG, n, p);
//        }
//        //f(n) = 1 + f(1)g(1) + f(2)g(2) + … + f(n−1)g(n−1),
//        //g(n) = 1 + 2g(1) + 2g(2) + 2g(3) + … + 2g(n−1) − g(n−1)g(n−1).

//        private static List<long> CalculateTheGList(long n)
//        {
//            var Glist = new List<long>();
//            Glist.Add(1);
//            Glist.Add(2);
//            Glist.Add(4);


//            for (int i = 0; i < n; i++)
//            {

//            }
//            return Glist;

//        }
//        private static List<long> CalculateFn(List<long> listOfG, long n, long p)
//        {

//        }


//    }
//}
#endregion
#region 1586. Threeprime Numbers
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace ThreeprimeNumbers
//{
//    public static class IntExtensions
//    {
//        public static bool IsPrime(this int number)
//        {
//            for (var divisor = 2; divisor < number; divisor++)
//                if (number % divisor == 0)
//                    return false;
//            return true;
//        }
//    }
//    internal static class Solver
//    {
//        private static Func<IEnumerable<int>> ThreeDigitPrimeNumbers =
//            () => Enumerable.Range(100, 900).Where(number => number.IsPrime());
//        private static Dictionary<int, IEnumerable<int>> PrefixCorrespondance(IEnumerable<int> primeNumbers)
//        {
//            return primeNumbers
//                .GroupBy(number => number / 10)
//                .ToDictionary(group => group.Key, group => group.Select(item => item));
//        }
//        internal static long Solve(int digitCount)
//        {
//            var table = new long[digitCount - 2, 90];
//            var prefixes = PrefixCorrespondance(ThreeDigitPrimeNumbers());
//            for (var counter = 10; counter < 100; counter++)
//                table[0, counter - 10] = (prefixes.TryGetValue(counter, out var collection)) ? collection.Count() : 0;
//            for (var counter = 1; counter <= digitCount - 3; counter++)
//                foreach (var pair in prefixes)
//                    foreach (var primeNumber in pair.Value)
//                    {
//                        var suffix = primeNumber % 100 - 10;
//                        table[counter, pair.Key - 10] += (suffix < 0) ? 0 : table[counter - 1, suffix];
//                        table[counter, pair.Key - 10] %= 1000000009;
//                    }
//            long sum = 0;
//            for (var counter = 0; counter < 90; counter++)
//                sum = (sum + table[digitCount - 3, counter]) % 1000000009;
//            return sum;

//        }
//        public static void Main()
//        {
//            int.TryParse(Console.ReadLine(), out int digitCount);
//            Console.Write(Solve(digitCount));
//        }
//    }
//}
#endregion
#region 1009.    K-based Numbers
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace ThreeprimeNumbers
//{
//    internal static class Solver
//    {
//        public static void Main()
//        {
//            //N=2,K=10;
//            var F = new long[2000];
//            var n = Convert.ToInt32(Console.ReadLine());
//            var k = Convert.ToInt32(Console.ReadLine());
//            F[0] = 1;
//            F[1] = k-1;
//            for (int i = 2; i <= n; i++)
//            {
//                F[i] = (k - 1) * (F[i - 1] + F[i - 2]);
//            }
//            Console.WriteLine(F[n]);
//        }
//    }
//}
#endregion
#region 1002.    Phone Numbers ?????
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;

//namespace ThreeprimeNumbers
//{
//    internal static class Solver
//    {
//        public static void Main()
//        {
//            var dict = new Dictionary<int, string>();
//            dict.Add(1, "ij");
//            dict.Add(2, "abc");
//            dict.Add(3, "def");
//            dict.Add(4, "gh");
//            dict.Add(5, "kl");
//            dict.Add(6, "mn");
//            dict.Add(7, "prs");
//            dict.Add(8, "tuv");
//            dict.Add(9, "wxy");
//            dict.Add(0, "oqz");

//            for (; ; )
//            {
//                var result = "";
//                var line = Console.ReadLine();
//                if (line == "-1") break;
//                var n = Convert.ToInt32(Console.ReadLine());
//                var list = new List<string>();
//                for (int i = 0; i < n; i++)
//                {
//                    list.Add(Console.ReadLine());
//                }
//                int dl = 0;
//                for (int i = 0; i < line.Length; i++)
//                {
//                    var m = dict[Convert.ToInt32(line[i].ToString())];
//                    var t = false;

//                    for (int j = 0; j < list.Count; j++)
//                    {
//                        for (int k = 0; k < m.Length; k++)
//                        {
//                            try
//                            {
//                                if (m[k].ToString() == list[j][dl].ToString())
//                                {
//                                    t = true;
//                                }
//                            }
//                            catch (Exception)
//                            {

//                                 list.Remove(list[j]);
//                                t = true;
//                                break;
//                            }

//                        }
//                        if (!t)
//                        {
//                            list.Remove(list[j]);
//                        }
//                    }
//                    dl++;

//                }
//            }

//        }

//    }
//}
#endregion
#region 1012. 1864. Get-Together at Den's
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Numerics;

//namespace ThreeprimeNumbers
//{
//    internal static class Solver
//    {
//        public static void Main()
//        {
//            //N=2,K=10;
//            var F = new BigInteger[2000];
//            var n = Convert.ToInt64(Console.ReadLine());
//            var k = Convert.ToInt64(Console.ReadLine());
//            F[0] = 1;
//            F[1] = k - 1;
//            for (int i = 2; i <= n; i++)
//            {
//                F[i] = (k - 1) * (F[i - 1] + F[i - 2]);
//            }
//            Console.WriteLine(F[n]);
//        }
//    }
//}
#endregion
#region 1864. Get-Together at Den's
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Numerics;

//namespace ThreeprimeNumbers
//{
//    internal static class Solver
//    {
//        public static void Main()
//        {
//            //5 3 3 3 3
//            var n = Convert.ToInt32(Console.ReadLine());
//            var buff = Console.ReadLine().Split().Select(float.Parse).ToArray();
//            var sum = 0f;
//            for (int i = 0; i < n; i++)
//            {
//                sum += buff[i];
//            }
//            var someOne = sum / (n + 1);
//            double p = 0;
//            for (int i = 0; i < n; i++) if (buff[i] > someOne) { p += buff[i] - someOne; }

//            for (int i = 0; i < n; i++)
//            {
//                var t = (Math.Floor(100.0 * (buff[i] - someOne) / (p + 0.00001)));

//                if (buff[i] > someOne)
//                    Console.WriteLine((Math.Floor(100.0 * (buff[i] - someOne) / (p - 0.001))));
//                else
//                    Console.WriteLine(0);

//            }
//        }
//    }
//}
#endregion
#region MyRegion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ThreeprimeNumbers
{
    internal static class Solver
    {
        public static void Main()
        {
            //5 3 3 3 3
            var n = Convert.ToInt32(Console.ReadLine());
            var buff = Console.ReadLine().Split().Select(float.Parse).ToArray();
            var sum = 0f;
            for (int i = 0; i < n; i++)
            {
                sum += buff[i];
            }
            var someOne = sum / (n + 1);
            double p = 0;
            for (int i = 0; i < n; i++) if (buff[i] > someOne) { p += buff[i] - someOne; }

            for (int i = 0; i < n; i++)
            {
                var t = (Math.Floor(100.0 * (buff[i] - someOne) / (p + 0.00001)));

                if (buff[i] > someOne)
                    Console.WriteLine((Math.Floor(100.0 * (buff[i] - someOne) / (p - 0.001))));
                else
                    Console.WriteLine(0);

            }
        }
    }
}
#endregion