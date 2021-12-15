// See https://aka.ms/new-console-template for more information
using System;

Start();

void Start()
{
    Console.Clear();
    Console.WriteLine("Intercepting millitary satellites\n");
    LoadingBar();

    Console.WriteLine("\nDecrypting intercepted information\n");
    LoadingBar();

    Console.WriteLine("\nBreaking super secure passwords\n");
    LoadingBar();

    Menu();
}

void Menu()
{
    Console.WriteLine("\nDo you really want to Hack NASA and steal data ? (Y/n)");
    char? answer = char.Parse(Console.ReadLine().ToLower());

    if (answer == 'n') System.Environment.Exit(0);

    Console.WriteLine("\nHacking Nasa, please wait\n");
    LoadingBar();

    Console.WriteLine("\nNASA SUCCESSFULLY HACKED, YOU HAVE 1 HOUR TO RUNAWAY FROM YOUR COUNTRY");
    Console.ReadLine();
}

void LoadingBar()
{
    Thread.Sleep(200);
    string LoadingBar = "#";
    for (int i = 0; i < 50; i++)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(0, Console.CursorTop - 1);
        LoadingBar += "#";
        Console.WriteLine(LoadingBar);
        Thread.Sleep(100);
    }
    Console.ForegroundColor = ConsoleColor.White;
}
