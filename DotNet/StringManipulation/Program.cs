using System.Text;

Console.WriteLine("Starting string manipulations...");

DateTime start = DateTime.Now;

// string s = "";
// for (int i = 0; i < 600_000; i++)
// {
//     s = s + "A";
// }

StringBuilder builder = new();
for (int i = 0; i < 500_000; i++)
{
    builder.Append('A');
}
string s = builder.ToString();

DateTime stop = DateTime.Now;

TimeSpan timeTaken = stop - start;


Console.WriteLine("Completed string manipulations.");
Console.WriteLine("Time taken: " + timeTaken.TotalSeconds);
