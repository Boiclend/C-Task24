// дополнение к прошлой задаче Task23 , только здесь сортировка слов.

string path = @"C:\Users\РомаиЛиля\Desktop\C#Task24\Task24\words.txt";
string text = File.ReadAllText(path); // чтение файла

string temp = text.ToLower(); // привожу к нижнему регистру, потому что если будут символы верхнего регистра, то они не будут удалены как дубликаты.
char[] txt = temp.ToArray();
string[] s = new string[text.Length];
int count = 0;
for (int i = 0; i < text.Length; i++)
{
    if(txt[i] == ' ')
    {
        count++;
    }
    if(txt[i] != ' ') 
    {
        s[count] = s[count] + txt[i].ToString();
    }
    
}
s = s.Distinct().ToArray();
Array.Sort(s);

for (int i = 0; i < s.Length; i++)
{
    Console.WriteLine(s[i]);   
}


