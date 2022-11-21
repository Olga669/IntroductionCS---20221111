//15. С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что ее нет.
//(Вывести: NO).
int n=Convert.ToInt32(Console.ReadLine());

if (n<100) System.Console.WriteLine("NO");
else System.Console.WriteLine(n/100%10);