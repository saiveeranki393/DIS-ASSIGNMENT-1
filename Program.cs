using System;

namespace DIS_Assignmnet1_SPRING_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Q1: Enter the string:");
            string s = Console.ReadLine();
            string final_string = RemoveVowels(s);
            Console.WriteLine("Final string after removing the Vowels: {0}", final_string);
            Console.WriteLine();

            //Question 2:
            string[] bulls_string1 = new string[] { "Marshall", "Student", "Center" };
            string[] bulls_string2 = new string[] { "MarshallStudent", "Center" };
            bool flag = ArrayStringsAreEqual(bulls_string1, bulls_string2);
            Console.WriteLine("Q2");
            if (flag)
            {
                Console.WriteLine("Yes, Both the array’s represent the same string");
            }
            else
            {
                Console.WriteLine("No, Both the array’s don’t represent the same string ");
            }
            Console.WriteLine();

            //Question 3:
            int[] bull_bucks = new int[] { 1, 2, 3, 2 };
            int unique_sum = SumOfUnique(bull_bucks);
            Console.WriteLine("Q3:");
            Console.WriteLine("Sum of Unique Elements in the array are :{0}", unique_sum);
            Console.WriteLine();


            //Question 4:
            int[,] bulls_grid = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Q4:");
            int diagSum = DiagonalSum(bulls_grid);
            Console.WriteLine("The sum of diagonal elements in the bulls grid is {0}:", diagSum);
            Console.WriteLine();

            //Question 5:
            Console.WriteLine("Q5:");
            String bulls_string = "aiohn";
            int[] indices = { 3, 1, 4, 2, 0 };
            String rotated_string = RestoreString(bulls_string, indices);
            Console.WriteLine("The  Final string after rotation is {0} ", rotated_string);
            Console.WriteLine();

            //Quesiton 6:
            string bulls_string6 = "mumacollegeofbusiness";
            char ch = 'c';
            string reversed_string = ReversePrefix(bulls_string6, ch);
            Console.WriteLine("Q6:");
            Console.WriteLine("Resultant string are reversing the prefix:{0}", reversed_string);
            Console.WriteLine();

        }
        private static string RemoveVowels(string s)
        {
            try
            {
                String final_string = "";
                int length = s.Length;
                if(length>=0 && length <= 10000)
                {
                    foreach (char x in s)
                    //looking for character x in string "s" which are not equal to the vowels and replacing them in "final_string".
                    {
                        if (x != 'a' & x != 'e' & x != 'i' & x != 'o' & x != 'u' & x != 'A' & x != 'E' & x != 'I' & x != 'O' & x != 'U')
                        {
                            final_string = final_string + x;
                        }
                    }
                }
                return final_string;
            }
            catch (Exception)
            {
                throw;
            }

        }
        private static bool ArrayStringsAreEqual(string[] bulls_string1, string[] bulls_string2)
        {
            try
            {
                // using concat function join the strings in array and compare bth arrays
                if (string.Concat("", bulls_string1) == string.Concat("", bulls_string2))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        private static int SumOfUnique(int[] bull_bucks)
        {
            try
            {
                int sum = 0;
                int len = bull_bucks.Length;
                if (len >= 1 && len <= 1000) ;
                {
                    foreach (int z in bull_bucks)
                    {
                        //while loop inside foreach to compare the integers and overwriting the value of "c" if they are equal.
                        for (int i = 0; i < len; i++)
                        {
                            if (z == bull_bucks[i])
                            {
                                c = c + 1;
                            }
                        }
                    }

                }
                    int c = 0;
                
                //"c" value will be 1 when the integers are not equal.
                if (c == 1)
                    {
                        sum = sum + z;
                    }
                return sum;

            }
            catch (Exception)
            {
                throw;
            }
        }
        private static int DiagonalSum(int[,] bulls_grid)
        {
            try
            {
                int d = bulls_grid.Length;
        //sqaure root of total length of array will be the matrix
        int n = Convert.ToInt32(Math.Sqrt(d));
                int diagonal_sum = 0;
                int i = 0;
                while (i < n)
                {
                    diagonal_sum = diagonal_sum + bulls_grid[i, i] + bulls_grid[i, n - i - 1];
                    i++;
                }
        //if its is a odd matrix, need to subtract the repeated integer while adding the two diagonals
        if (n % 2 != 0)
                {
                    return diagonal_sum - bulls_grid[(n - 1) / 2, (n - 1) / 2];
                }
                else
                {
                    return diagonal_sum;
                }

            }
            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }

        }
        private static string RestoreString(string bulls_string, int[] indices)
        {
            try
            {
                string[] v = new string[bulls_string.Length];
                //string array of length same as bulls_string
                string d = "";//string to store result 
                int i = 0;
                int x = indices.Length;
                if (bulls_string.Length >= 1 && bulls_string.Length <= 100 && indices.Length >= 0 && indices.Length <= 100) ;
                {
                    while (i < bulls_string.Length)// travesing throught the string
                    {
                        int y = indices[i];
                        v[y] = Convert.ToString(bulls_string[i]);
                        i++;
                    }
                    i = 0;
                    while (i < bulls_string.Length) //creating output
                    {
                        d = d + v[i];
                        i++;
                    }

                }
               
                return d;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }
        private static string ReversePrefix(string bulls_string6, char ch)
        {
            try
            {
                string[] m = new string[bulls_string6.Length];//string array of length same as bulls_string
        int i = 0; 
                while (i < bulls_string6.Length)
                {
                    if (bulls_string6[i] == ch)// condition to find character ch in given string
                    {
                        m = bulls_string6.Split(ch);
                    }
                    i++;
                }
                string y = "";
                int k = m[0].Length - 1;
                while (k >= 0) //resversing the sub string 
                {
                    y = y + bulls_string6[k];
                    k--;
                }
                string prefix_string = ch + y + m[1];// forming the result string
                return prefix_string;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}


