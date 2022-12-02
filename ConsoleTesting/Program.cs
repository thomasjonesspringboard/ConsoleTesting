

// See https://aka.ms/new-console-template for more information
using ConsoleTesting;
using System.Diagnostics;

Console.WriteLine("Hello, World!");

//StringReplacer.

//StringReplacer.
var liststr = new List<string> { "123", "456", "123 456  ", "this has whitespace", "              l", "      1"};
var strippedWhitespace = StringReplacer.StripWhitespace(liststr);
Debug.Print(strippedWhitespace.ToString());