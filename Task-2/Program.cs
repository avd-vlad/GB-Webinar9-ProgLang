/*------------------------------------------------------------------------------------------------------------------
Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
------------------------------------------------------------------------------------------------------------------*/

void ShowNums(int m, int n)
{
    Console.Write(Math.Min(m,n)+" ");
    if( Math.Min(m,n) < Math.Max(m,n) ) ShowNums(Math.Min(m,n)+1,Math.Max(m,n));
}

void ShowNums1(int m, int n)
{
    if(m!=n)
        if(m<n)
        {
            Console.Write(m+" ");
            ShowNums(m+1,n);
        }
        else
        {
            ShowNums(m+1,n);
            Console.Write(m+" ");
        }
}


ShowNums1(-15,3);