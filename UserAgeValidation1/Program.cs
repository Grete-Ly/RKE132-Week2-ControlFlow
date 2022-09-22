// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal sisestada tema vanuse
//kui kasutaja vanus on väiksem kui 13, siis konsoolis kuvatakse:
//"You are too young to use Instagram"
//muul juhul
//Konsoolis kuvatakse "Welcome to Instagram"

Console.WriteLine("Enter your age");

int userAge = Int32.Parse(Console.ReadLine()); //"13" - salvestatakse heap, 13 - salvestatakse stack 

if (userAge >= 13)
{
    Console.WriteLine("Welcome to Instagram!");
}
else  //if (userAge < 13)
{
    Console.WriteLine("You are too young to use Instagram");
}