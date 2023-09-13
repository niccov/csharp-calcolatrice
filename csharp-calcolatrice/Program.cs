// See https://aka.ms/new-console-template for more information
using csharp_calcolatrice;

//somma di due interi
Console.WriteLine("Somma di due interi");
int sommaInt = CalcoliHelper.SumOfTwoInt(2, 4);

Console.WriteLine(sommaInt);
Console.WriteLine();

//somma di due double
Console.WriteLine("Somma di due double");
double sommaDouble = CalcoliHelper.SumOfTwoDouble(1.2, 0.4);

Console.WriteLine(sommaDouble);
Console.WriteLine();

//differenza tra due interi
Console.WriteLine("Differenza tra due interi");
int differenzaInt = CalcoliHelper.DifferenceOfTwoInt(10, 2);

Console.WriteLine(differenzaInt);
Console.WriteLine();

//differenza tra due double
Console.WriteLine("Differenza tra due double");
double differenzaDouble = CalcoliHelper.DifferenceOfTwoDouble(22.12, 10.1);

Console.WriteLine(differenzaDouble);
Console.WriteLine();

//moltiplicazione di due interi
Console.WriteLine("Moltiplicazione di due interi");
int moltiplicazioneInt = CalcoliHelper.MultiplicationOfTwoInt(12, 3);

Console.WriteLine(moltiplicazioneInt);
Console.WriteLine();

//moltiplicazione di due double
Console.WriteLine("Moltiplicazione di due double");
double moltiplicazioneDouble = CalcoliHelper.MultiplicationOfTwoDouble(9.2, 2.3);

Console.WriteLine(moltiplicazioneDouble);
Console.WriteLine();

//valore assoluto di un numero intero
Console.WriteLine("Valore assoluto di un intero");
int valoreAssolutoInt = CalcoliHelper.AbsoluteValueOfInt(5);

Console.WriteLine(valoreAssolutoInt);
Console.WriteLine();

//valore assoluto di un double
Console.WriteLine("Valore assoluto di un double");
double valoreAssolutoDouble = CalcoliHelper.AbsoluteValueOfDouble(4.2);

Console.WriteLine(valoreAssolutoDouble);
Console.WriteLine();

//valore minimo tra due interi
Console.WriteLine("Valore minimo tra due interi");
int minimoInt = CalcoliHelper.MinimumValueInt(5,8);

Console.WriteLine(minimoInt);
Console.WriteLine();

//valore minimo tra due double
Console.WriteLine("Valore minimo tra due double");
double minimoDouble = CalcoliHelper.MinimumValueDouble(7.2, 10.5);

Console.WriteLine(minimoDouble);
Console.WriteLine();

//valore massimo tra due interi
Console.WriteLine("Valore massimo tra due interi");
int massimoInt = CalcoliHelper.MaximumValueInt(3, 9);

Console.WriteLine(massimoInt);
Console.WriteLine();

//valore massimo tra due double
Console.WriteLine("Valore massimo tra due double");
double massimoDouble = CalcoliHelper.MaximumValueDouble(2.4, 2.7);

Console.WriteLine(massimoDouble);
