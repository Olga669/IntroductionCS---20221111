using System.Linq;


c='\x0064';
c='\u0064';
char b='a';
System.Console.WriteLine((int)b);
System.Console.WriteLine(c.ToString()+b.ToString());
if (b>='0' && b<='9') System.Console.WriteLine("it's digit");
if (b>='A' && b<='Z') System.Console.WriteLine("it's big Latin");
if (b>='a' && b<='z' || b>='A' && b<='Z') System.Console.WriteLine("it's digit");

if (Char.IsDigit(b)) System.Console.WriteLine("it's digit");

string s="qadsd";
//immutable string (не изменяемые строки)
System.Console.WriteLine(s[0]);
for(int i=0;i<s.Length;i++)
    System.Console.WriteLine(s[i]);
//s[0]='S';
char[] cc=s.ToCharArray();
cc[0]='S';
s=new String(cc);

System.Text.StringBuilder sb=new System.Text.StringBuilder("asaas");
sb[0]='s';

s=sb.ToString();

for(int i=0;i<10000;i++)
    s=s+"1";//создаётся новая строка
for(int i=0;i<10000;i++)
    sb.Append("1");
    
string s1="Hello";
string s2="Hello";
System.Console.WriteLine(s1==s2);
System.Console.WriteLine(s1.CompareTo(s2));
System.Console.WriteLine(String.Compare(s1,2,s2,3,4,true));

//s1.Length - длина строчкт

s2=s1.Substring(2,4);
System.Console.WriteLine(s1.IndexOf("as"));
s2=s1.Replace("ab,","ba");

Random random1=new Random();
Random random2=new Random();
random2=random1;
System.Console.WriteLine(random1==random2);