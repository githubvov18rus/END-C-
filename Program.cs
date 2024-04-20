string [] array = {"Hello", "2", "world", ":-)"};     // => ["2", ":-)"]
//string [] array = {"1234", "1567", "-2", "computer science"};     // => ["-2"]
//string [] array = {"Russia", "Denmark", "Kazan"};       // => []

int size = 0;
for (int a = 0; a < array.Length; a++)
     if (array[a].Length < 4)
        size++;

string [] result = new string[size];

int j = 0;
for (int i = 0; i < array.Length; i++)
     if (array[i].Length < 4)
        {
            result[j] = array[i];
            j++;
        }

if (result.Length == 0)
    Console.Write("[]");
else
{
    Console.Write("[“");
    Console.Write(string.Join( "”, “" , result));
    Console.Write("”]");
}