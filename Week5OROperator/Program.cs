//Math => 90 OR Chemistry => 90 OR Biologu >= 90

//math && chemistry || math && biology || chemisrty && biology >=90

using System;

int math, biology, chemistry;

Console.WriteLine("Enter your Math resault:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your biology resault");
biology = Int32.Parse(Console.ReadLine());  

Console.WriteLine("Enter your Chemistry resault:");
chemistry = Int32.Parse(Console.ReadLine());

if(math >= 90 && chemistry >= 90 || (math >= 90 && biology >= 90) || (chemistry >= 90 && biology >= 90))

{
    Console.WriteLine("Congratulation! You are accepted");
}
else
{
   Console.WriteLine("Your application cannot be approved");
}