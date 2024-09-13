﻿using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {

        // Atamma ve işlemli atama 
        Console.WriteLine("Atamma ve işlemli atama");
        int x = 3;
        int y = 3;
        
        y = y+2;
        Console.WriteLine(y);
        
        y += 2;
        Console.WriteLine(y);
        y/=1;
        Console.WriteLine(y);
        x*=2;
        Console.WriteLine(x);
        
        Console.WriteLine("Mantıksal Operatörler");
        // Mantıksal Operatörler
        // ||, &&, !

        bool isSuccess = true;
        bool isCompleted = false;

        if(isSuccess && isCompleted)
            Console.WriteLine("Perfecy!!");

        if(isSuccess || isCompleted)
            Console.WriteLine("Great!!");

        if(isSuccess && !isCompleted)
            Console.WriteLine("Fine!!");            

        // İlişkisel operatörler

        // <, >, <=, >=, ==, !=
         Console.WriteLine("İlişkisel Operatörler");
        int a = 3;
        int b = 4;
        bool sonuc = a<b;
        Console.WriteLine(sonuc);

        sonuc = a>b;
        Console.WriteLine(sonuc);

        sonuc = a>=b;
        Console.WriteLine(sonuc);

        sonuc = a<=b;
        Console.WriteLine(sonuc);

        sonuc = a==b;
        Console.WriteLine(sonuc);
        
        sonuc = a!=b;
        Console.WriteLine(sonuc);


        //Aritmetik Operatörler
        // +, -, *, /
        Console.WriteLine("Aritmetik Operatörler");

        int sayi1 = 10;
        int sayi2 = 5;
        int sonuc1 = sayi1/sayi2;
        Console.WriteLine(sonuc1);
        sonuc1 = sayi1*sayi2;
        Console.WriteLine(sonuc1);
        sonuc1=sayi1+sayi2;
        Console.WriteLine(sonuc1);
        sonuc1 = ++sayi1;
        Console.WriteLine(sonuc1);

        // % mod alır
        int sonuc2 = 20%3;
        Console.WriteLine(sonuc2);




        }

    }
}