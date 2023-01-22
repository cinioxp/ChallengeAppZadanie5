Console.WriteLine("Zadanie dzien 5");
Console.WriteLine("podaj liczbe do Anallizy:, zatwierdz enter");
bool isNumber = false;
string numberString = Console.ReadLine();
int numberInt;


isNumber = int.TryParse(numberString, out numberInt);

string numberIntToString = numberInt.ToString();
char[] letters = numberIntToString.ToCharArray();

List<char> cyfry = new List<char>();
cyfry.Add('0');
cyfry.Add('1');
cyfry.Add('2');
cyfry.Add('3');
cyfry.Add('4');
cyfry.Add('5');
cyfry.Add('6');
cyfry.Add('7');
cyfry.Add('8');
cyfry.Add('9');


Console.WriteLine("liczba Analizowana:" + numberInt);
foreach (var singular in cyfry)
{
    int count = 0;
    foreach (var x in letters)
    {
        if (singular == x) count++;
    }
    Console.WriteLine(singular + "=>" + count);
}


