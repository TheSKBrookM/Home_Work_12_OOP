namespace ДР_12_1
{
    public delegate void MyDelegate(string str);
    internal class Program
    {
        public static event MyDelegate TextAdd;

        static void Main(string[] args)
        {
            new Presenter();
            string str = "";
            while (true)
            {
                str = Console.ReadLine(); 
                if (!string.IsNullOrEmpty(str)) 
                {
                    TextAdd.Invoke(str);
                }
            }
        }
    }
}  