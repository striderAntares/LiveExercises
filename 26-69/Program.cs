string txt = "9669";
int i = 0;
while (i < 4)
{
    txt = txt.Replace(6.ToString(), "9");
    i++;
}
Console.WriteLine("Purged= " + txt);


