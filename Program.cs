// See https://aka.ms/new-console-template for more information
int[] IDList = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
int[] Contactee = { 2, 0, 7, 11, 15, 4, 14, 1, 8, 13, 3, 5, 12, 9, 6, 10 };
Console.WriteLine("Enter id of infected citizen:");
string temp_str = Console.ReadLine();
int InputPserson = int.Parse(temp_str);
List<int> Result = new();
while (!Result.Contains(InputPserson))
{
    Result.Add(InputPserson);
    InputPserson = Contactee[InputPserson];
}
Console.WriteLine(String.Join(",", Result.ToArray()));
Console.WriteLine("End");