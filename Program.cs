
public class program
{
    public static string Subtraction(string firstNum, string secondNum, string firstSysNumeration, string secondSysNumeration)
    {
        char[] alp = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C' ,'D','E','F'};
        string result = "";
        int firstLenght = firstNum.Length - 1;
        int secondLenght = secondNum.Length - 1;
        char timeSpace;
        int supportVariable = 0;
        int supportLenght = firstLenght;
        while (firstLenght >= 0)
        {
            if (secondLenght >= 0)
            {
                if ((Array.IndexOf(alp, firstNum[firstLenght]) - supportVariable) >= Array.IndexOf(alp, secondNum[secondLenght]))
                {
                    timeSpace = Convert.ToChar(alp[Array.IndexOf(alp, firstNum[firstLenght]) - Array.IndexOf(alp, secondNum[secondLenght]) - supportVariable]);
                    result = Convert.ToString(timeSpace) + result;
                    supportVariable = 0;

                }
                else
                {
                     timeSpace = Convert.ToChar(alp[int.Parse(firstSysNumeration) + Array.IndexOf(alp, firstNum[firstLenght]) - Array.IndexOf(alp, secondNum[secondLenght]) - supportVariable]);
                    result = Convert.ToString(timeSpace) + result;
                    supportVariable = 1;

                }
                secondLenght--;
            }
            else
            {
                try
                {
                    if (firstLenght >= supportLenght) { supportVariable = 1; }
                    timeSpace = Convert.ToChar(alp[Array.IndexOf(alp, (firstNum[firstLenght])) - supportVariable]);
                    result = Convert.ToString(timeSpace) + result;
                    supportVariable = 0;
                }
                catch
                {
                    supportLenght = firstLenght;
                    while (firstNum[supportLenght] == '0')
                    {
                        supportLenght--;
                    }
                    string supportList = "";
                    for (int fastTimeLenght = supportLenght; fastTimeLenght < firstLenght; fastTimeLenght++)
                    {
                        supportList = Convert.ToString(alp[int.Parse(firstSysNumeration)]) + supportList;
                    }
                    firstNum = firstNum[0..(supportLenght + 1)] + supportList;
                    firstLenght++;
                    supportVariable = 0;
                    
                }

            }
            firstLenght--;
        }
        return result;
    }
    public static void Main()
    {
        Console.WriteLine("приветствуем в отделе вычитание чисел одной системе счисления");
        Console.WriteLine("введите первое число с системой счисления от 2 до 35 (включая)");
        string first_num = Console.ReadLine();
        Console.WriteLine("введите систему счисления");
        string first_sys_numeration = Console.ReadLine();
        Console.WriteLine("введите второе число с системой счисления от 2 до 35 (включая)");
        string second_num = Console.ReadLine();
        Console.WriteLine("введите систему счисления");
        string second_sys_numeration = Console.ReadLine();
        string finish = Subtraction(first_num, second_num, first_sys_numeration, second_sys_numeration);
        Console.WriteLine($"итог - {finish}");
    }
}
// check