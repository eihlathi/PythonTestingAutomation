Console.WriteLine("LINQ demo starting...");

int[] numbers = [6, 12, 8, 4, 2, 3, 1, 7, 9, 5, 10];

// classic programming: display the numbers larger than five in ascending order
List<int> largeNumbers = [];
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 5) {
        largeNumbers.Add(numbers[i]);
    }
}

largeNumbers.Sort();

foreach (int largeNumber in largeNumbers)
{
    Console.WriteLine(largeNumber);
}


Console.WriteLine("---------------------");

// LINQ programming (query syntax): display the numbers larger than five in ascending order
List<int> largerThanFive = (from n in numbers
                            where n > 5
                            orderby n
                            select n).ToList();

foreach (int largeNumber in largerThanFive)
{
    Console.WriteLine(largeNumber);
}
