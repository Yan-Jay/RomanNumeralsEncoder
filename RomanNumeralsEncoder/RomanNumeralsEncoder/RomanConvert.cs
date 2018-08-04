using System;
using System.Collections.Generic;

namespace RomanNumeralsEncoder
{
    public class RomanConvert
    {
        public static string Solution(int n)
        {
            var temp = n.ToString();
            var ans = "";
            var dic = new Dictionary<int, string>()
            {
                {1, "I"},
                {5, "V"},
                {10, "X"},
                {50, "L"},
                {100, "C"},
                {500, "D"},
                {1000, "M"},
                {4, "IV"},
                {9, "IX"},
                {40,"XL"},
                {90, "XC"},
                {400,"CD"},
                {900, "CM"},
            };
            while (temp.Length > 0)
            {
                var target = Int32.Parse(temp.Substring(0, 1));
                var carry = (int)Math.Pow(10, temp.Length - 1);
                if (temp.Length == 4 || target == 0)
                {
                    for (int i = 0; i < target; i++)
                    {
                        ans += dic[1000];
                    }
                    temp = temp.Substring(1);
                    continue;
                }
                if (target == 4 || target == 9)
                {
                    ans += dic[target * carry];
                }
                else
                {
                    var flag = 0;
                    foreach (var data in dic)
                    {
                        if (data.Key / carry > 0 && data.Key / carry < 10)
                        {
                            if (target * carry == data.Key)
                            {
                                ans += data.Value;
                                flag = 0;
                                break;
                            }

                            if (((target < 4 && target > 1) || (target > 5 && target < 9)) && (target - (data.Key / carry) > 0))
                            {
                                if (target < 4 || flag > 0)
                                {
                                    flag = data.Key;
                                    break;
                                }
                                flag++;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }

                    if (flag != 0)
                    {
                        ans += dic[flag];
                        target -= (flag / carry);
                        for (int i = 0; i < target; i++)
                        {
                            ans += dic[carry];
                        }
                    }
                }
                temp = temp.Substring(1);
            }

            return ans;
        }
    }
}