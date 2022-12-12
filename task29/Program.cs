int[] arr = new int[8];

Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(100); 
    Console.WriteLine(arr[i]);
}