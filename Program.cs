// See https://aka.ms/new-console-template for more information

Random rnd = new();
List<int> IDList = new();
List<int> Contactee = new();
// int[] IDList = new int[16];
// int[] Contactee = new int[16];
while (IDList.Count() < 16)
{
    int temp = rnd.Next(0, 16);
    if (!IDList.Contains(temp))
    {
        IDList.Add(temp);
    }
}
while (Contactee.Count() < 16)
{
    int temp = rnd.Next(0, 16);
    if (!Contactee.Contains(temp)) Contactee.Add(temp);
}


int InputPserson = 3;
List<int> Result = new();
int[] res_temp = Contactee.ToArray();
while (!Result.Contains(InputPserson))
{
    Result.Add(InputPserson);
    InputPserson = res_temp[IDList.IndexOf(InputPserson)];
}
Console.WriteLine(String.Join(",", IDList.ToArray()));
Console.WriteLine(String.Join(",", res_temp));
Console.WriteLine(String.Join(",", Result.ToArray()));

// int[] ID = IDList.ToArray();
// int[] Con = Contactee.ToArray();
// Console.WriteLine("Enter id of infected citizen:");
// int InputPserson = 3;
// List<int> Result = new();

// while (!Result.Contains(InputPserson))
// {
//     Result.Add(InputPserson);
//     InputPserson = Con[InputPserson];
// }
// Console.WriteLine(String.Join(",", Result.ToArray()));
// Console.WriteLine("End");