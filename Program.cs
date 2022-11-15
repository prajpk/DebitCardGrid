int rowCount = 5;
int columnCount = 26;
List<int> gridNums;
string grid;
int randNum = 0;

for (int r = 0; r < rowCount; r++)
{
    grid = "";
    gridNums = new List<int>();
    for (int c = 0; c < columnCount; c++)
    {
    again:
        randNum = new Random().Next(1, 99);
        if (!gridNums.Contains(randNum))
        {
            gridNums.Add(randNum);
        }
        else
        {
            goto again;
        }
        if (c < columnCount - 1)
        {
            grid += randNum + ", ";
        }
        else
        {
            grid += randNum;
        }
    }
    Console.WriteLine(grid);
}