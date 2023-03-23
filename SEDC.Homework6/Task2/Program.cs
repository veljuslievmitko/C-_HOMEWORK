#region text
/*
Create a list of ten numbers.
Use LINQ to select in a list of the squares of all the numbers in the list from above.
*/
#endregion

List<int> listWithTenNumbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

 List<int> newList = listWithTenNumbers.Select(x => x*x).ToList();

listWithTenNumbers.ForEach(x=> Console.WriteLine(x));
Console.ReadLine();
newList.ForEach(x => Console.WriteLine(x));
