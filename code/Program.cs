Console.OutputEncoding = System.Text.Encoding.UTF8;

string [] arrayCharsAndDigits = new string [new Random().Next(5,20)]; 


string [] FillArray (string [] array) 
{
    int size = array.Length;
    for (int i = 0; i < size; i ++)
    {
        char [] CharsForString = new char [new Random().Next(5,15)];
        for (int n = 0; n < CharsForString.Length; n ++)
        {
            CharsForString[n] = Convert.ToChar(new Random().Next(33, 123));
        }
        string someString = new string (CharsForString);
        array[i] = someString;
    }
    return array;
}


string [] DeleteDigits (string [] array)
{
    int size = array.Length;
    string [] arrayWithoutDigits = new string [size];
    for (int i = 0; i < size; i ++)
    {
        string stringWithoutDigits ="";
        for (int n = 0; n < array[i].Length; n ++)
        {
            if (!(Convert.ToInt32(array[i][n]) >= 48 && Convert.ToInt32(array[i][n]) <=57)) // 48 and 57 - decimal code of characters 0 and 9 in UTF-8
            {
                stringWithoutDigits += array[i][n];
            }
        }
        arrayWithoutDigits[i] = stringWithoutDigits;
    }
    return arrayWithoutDigits;
}


void PrintArray (string [] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i ++)
    {
        Console.WriteLine(array[i]);
    }
}

FillArray(arrayCharsAndDigits);
PrintArray(arrayCharsAndDigits);
Console.WriteLine();
string [] arrayWithoutDigits = DeleteDigits(arrayCharsAndDigits);
PrintArray (arrayWithoutDigits);
