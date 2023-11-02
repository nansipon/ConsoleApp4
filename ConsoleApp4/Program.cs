
internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        bool check = true;
        for (int i = 0; i < n; i++) ;
        {
            a[n] = int.Parse(Console.ReadLine());
            if (!(a[n] % 5 == 0 && a[n] % 2 != 0)) ;
            {
                check = false;
                return;
            }

            else

            {
                check = true;
            }
        }
        Console.WriteLine(check);
    }
}