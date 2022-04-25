int CoutingValleys(int steps, string path)
{
    int valleys = 0;
    int position = 0; // sea level
    foreach(char c in path)
    {
        if(c == 'D')
            position--;
        else
        {
            position++;
            if(position == 0)
                valleys++;
        }
    }
    return valleys;
}

string path1 = "UDDDUDUU";
string path2 = "DDUUDDUDUUUD";
Console.WriteLine(CoutingValleys(8, path1));
Console.WriteLine(CoutingValleys(12, path2));