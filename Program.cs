internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("STRINGS!\n");
        Console.WriteLine("\"Different ways to create strings\"\n");
        string MyName = "Olamide";
        string MyClub = "Manchester United";
        Console.WriteLine(MyName);
        Console.WriteLine(" ");
        string FirstName = "Ihsan - " + "Ahmad";
        Console.WriteLine(FirstName + "\n");
        string FullName = string.Format("{0} {1} {2}", FirstName, MyName, "Sodeko");
        Console.WriteLine(FullName + "\n");
        var Addition = new int[3] { 1, 2, 3 };
        string JointAdd = string.Join(" + ", Addition);
        Console.WriteLine(JointAdd + "\n");
        Console.WriteLine(@"\This is a verbatim string");
        string MySister = string.Format("{0}{1} {2} {3}", "Bushrah", "-Sodiq", "Sodeko", 5);
        Console.WriteLine(MySister);
        var BirthNames = new string[5] { "Ihsan-Ahmad", "Olamide", "Ayomide", "Oyinlola", "Abolaji" };
        var AllMyNames = string.Join(" ", BirthNames);
        Console.WriteLine(AllMyNames);
        Console.WriteLine("{0} {1} {4}", BirthNames);
        var Comparison = string.Compare(MyClub, MyName);
        Console.WriteLine(Comparison);
        var MailSent = @"
Hello, My name is Ihsan, and I'd like to learn coding.
I want to join your academy because I have the passion to learn this skill.
I am a fresh graduate of the University of Lagos with a first class in Marine biology. My resume is located in the folder
c:\Ihsan\c:\IH files\General Resume\IHSAN-AHMAD OLAMIDE SODEKO.
You can also find it at c:\Resume Folder\Writing Resume\Ihsan-Ahmad Olamide Sodeko.
Yours Truly.
Best regards.";
        Console.WriteLine(MailSent + "\n"); Console.WriteLine("The above code is clean");
    }
}