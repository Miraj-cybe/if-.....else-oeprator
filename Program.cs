using System;
class UserInput
{
public static void Main(string[] args)
{ 
string myName="Miraj";
Console.WriteLine(myName[0]);


//For Length we use (.length)
//For Uppercase WE use -----(.ToUpper)
//For lower Cse ---->(.ToLower)

string txt="Hello";
Console.WriteLine(txt.Length);


string myTxt="absjhdsdsjhdjsdjsjd";
Console.WriteLine("This Txt Length: " + myTxt.Length);


//numbers are added
//strings are concated (+)
string Name1="Miraj ";
string Name2="Mondol";
string Name=string.Concat(Name1,Name2);
Console.WriteLine(Name);


//comparison Operator
int x=10;
int y=20;
Console.WriteLine(x>y);
Console.WriteLine(x<y);
Console.WriteLine(x==y);
Console.WriteLine(x!=y);
Console.WriteLine(x>=y);
Console.WriteLine(x<=y);

//logical operator

 int p = 5;
      Console.WriteLine(p> 3 && p< 10);
 Console.WriteLine(p> 3 || p< 10);
 Console.WriteLine(!(p> 3 && p< 10));

//unary operator(increment) (decrement)

int Number=15;
Console.WriteLine(++Number);   //16
Console.WriteLine(Number--);   //16
Console.WriteLine(++Number);   //16
Console.WriteLine(--Number);   //15

int num=0;
if (num>0)
{
     Console.WriteLine("Positive number");    //if ----> true
}
else if(num<0)
{

Console.WriteLine("Negative Number");          //else------> false
}
else 
{
Console.WriteLine("Eual Zero");
}

///short hand Methood if...else
//variable = (condition) ? expressionTrue :  expressionFalse;

int Num=10;
string result=(Num<0) ? "good day." : "bad day.";
Console.WriteLine(result);

       //Data Spelling 
       //0---zero
       //1--one
      //2--two---- this kind

Console.Write("Enter a Digit between 0 to 9: ");
int digit=Convert.ToInt32(Console.ReadLine());

if(digit==0)
{
     Console.WriteLine("Zero");
}

 else if(digit==1)
{
     Console.WriteLine("One");
}

else if(digit==2)
{
     Console.WriteLine("Two");
}

else if(digit==3)
{
     Console.WriteLine("Three");
}

else if(digit==4)
{
     Console.WriteLine("Four");
}

else if(digit==5)
{
     Console.WriteLine("Five");
}

else if(digit==6)
{
     Console.WriteLine("Six");
}

else if(digit==7)
{
     Console.WriteLine("Seven");
}

else if(digit==8)
{
     Console.WriteLine("Eight");
}

else if(digit==9)
{
     Console.WriteLine("Nine");
}

else
{
     Console.WriteLine("Invaild Digit Number");
}
}

}