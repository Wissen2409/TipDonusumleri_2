// See https://aka.ms/new-console-template for more information


// Kitap önerisi : Sefer Algan - Her Yönüyle C#
#region Convert Tip Dönüşümü

// Bool tipinde bir değişkeni, int tipine çevirmek
//bool boolDegisken = false;
//int intDegisken = Convert.ToInt32(boolDegisken);
//Console.WriteLine(intDegisken);

// bool tipinde bir değişkeni int tipine çevirebiliriz.
// int tipine çevirilen true değeri : 1 
// int tipine çevirilen false değeri : 0 olarak çevrilecektir.

// int tipinde bir değişkeni bool tipine çevirebilir miyiz ?

// int tipinde bir değişken bool tipine dönüştürülebilir.
// int tipi, 0 değerini taşıyorsa, bool tipine dönüşten sonra false değerine dönüşür.
// 0 harici herhangi bir değer taşıyorsa, bool tipine dönüştüren sonra true değeri taşır.


//int intDegisken = -100;
//bool boolDegisken = Convert.ToBoolean(intDegisken);
//Console.WriteLine(boolDegisken);

// Char tipini, int tipine convert ile dönüştürelim
//char charDegisken = 'Z';
//int intDegisken = Convert.ToInt32(charDegisken);
//Console.WriteLine(intDegisken);
// char tipi int tipine dönüştürüldüğünde, her bir harfe karışık gelen bir rakama dönüşür. 

// Örnek : büyük A ile küçük A arasındaki sayı, 32 dir, aynı şey, büyük Z ve küçük z arasındaki sayı farkıda 32 dir.

// int tipini char tipine çevirmek 
//int intDegisken  = 50;
//char charDegisken = Convert.ToChar(intDegisken);
//Console.WriteLine(charDegisken);

// int tipi char tipine dönüştürüldüğünde, 0 ile 255 arasında farklı karakterler dönüşmektedir.


// bir string ifadenin içerisindeki rakamları alıp, int tipine dönüştürme!!!!
//string stringDegisken = "aaaa44433299sdsds";
//string newString = stringDegisken.Substring(4, 8);
//int intDegisken = Convert.ToInt32(newString);
//Console.WriteLine(intDegisken);
#endregion

#region Parse

// Convert tip dönüşümü tekrar bir hatırlayalım

// C#'da kullanılan build-in (önceden tanımlı) 15 adet tanımlı tipi, birbirine çevirmek için kullanılır.


// tip dönüşümleri hangileriydi : 

// Convert 
// Cast
// Parse
// ToString
 
 // Parse : Parse bir tip için özelleşmiş bir tip dönüşümüdür.
 // Parse, string tipindeki verileri, diğer tiplere çevirmek için kullanılır. Yani parse sadece string alır.
 // string değişken tipi c#da çok fazla kullanıldığı için, parse string tipine özel olarak üretilmiştir.
 // amacı, hızlı bir şekilde, string tipini farklı tiplere çevirmektir.
 // başka bir sebebide, kullanıcıdan alınan değerler string'dir. Bu yüzden de string'e özel bir dönüştürme mekanizması vardır.

 // Örnek ve Syntax

// string tipini int tipine dönüştürelim
 //string metin = "10";
 //int intDegisken = int.Parse(metin);
 //Console.WriteLine(intDegisken);


// string tipini char tipine dönüştürelim
//string metin = "a";
//char charDegisken = char.Parse(metin);
//Console.WriteLine(charDegisken);


// string değeri bool tipine çevirelim
string metin ="false";
bool boolDegisken = bool.Parse(metin);
Console.WriteLine(boolDegisken);


// 

#endregion