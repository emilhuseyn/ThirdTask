#region task 1
int k = 1;
for(int i = 1; i <= 5; i++)
{
    Console.WriteLine(i*i);
}
#endregion
#region task 2
int sum = 0;
int[] array = { 4, 23, 13, 10, 12, 5, 9, 32 };
for(int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 1)
    {
        sum += array[i];
    }
}
Console.WriteLine(sum); 
#endregion
#region task 3
int cem = 0;
int[] arr = { 2, 41, 23, 41, 32, 91, 5, 67, 94 };
for(int j = 1; j < arr.Length; j=j+2)
{
    cem = cem + arr[j];
}
Console.WriteLine(cem);
#endregion
#region task 4
bool t = true;
string name = "la";
int k, l=name.Length-1;
for(k = 0; k < name.Length/2; k++)
{
    if (name[k] != name[l])
    {
        t=false; 
        break;
    }
    l--;
}
if (t == true)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}
#endregion
