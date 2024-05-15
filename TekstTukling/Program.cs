using System.Runtime.InteropServices;

Console.WriteLine("WELCOME! WELCOME! ONE AND ALL!");
Console.WriteLine("TO MADAM MIMS WORDPLAY PALACE");
Console.WriteLine("Choose your fate:");
Console.WriteLine("1. Rotate Text");
Console.WriteLine("2. Change Word");
string answer = Console.ReadLine();
if (answer == "1")
{
    Console.WriteLine("Enter Word:");
    string word = Console.ReadLine();
    string drow = "";
    for (int i = word.Length-1; i >= 0; i--)
    {
        drow += word[i];
        
    }Console.Write(drow);
}
else if (answer == "2")
{
    Console.WriteLine("Enter Word:");
    string word = Console.ReadLine();
    string ward = "";
    for (int i = 0; i < word.Length; i++)
    {
        if (word[i] == 'e')
        {
            ward += 'a';
        }
        else
        {
            ward += word[i];
        }
    }

    Console.WriteLine(ward);
}
