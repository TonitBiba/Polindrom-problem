/******************************************************
*  Program to find largest polindrom in input string
*  Author: Tonit Biba
*  Date: 17.07.2022
*  Example: abcracecarabcd
******************************************************/
Console.Write("Input text to find largest polindrom: ");
string? inputString = Console.ReadLine();

if (inputString == null)
{
   Console.WriteLine("Input string must have value!");
   return;
}

List<string> polindroms = new();
string reverse = "";
int firstLength = inputString.Length;
for (int k = 0; k < firstLength; k++)
{
   int inputStringLength = inputString.Substring(0, firstLength - k).Length;
   inputString = inputString.Substring(0, firstLength - k);

   for (int i = 0; i < inputStringLength; i++)
   {
      reverse = new string(inputString.Substring(i).Reverse().ToArray());
      for (int j = 0; j < reverse.Length; j++)
      {
         if (inputString.Substring(i) == reverse.Substring(j))
         {
            polindroms.Add(inputString.Substring(i));
         }
      }
   }
}

Console.WriteLine(polindroms.OrderByDescending(b => b.Length).FirstOrDefault());