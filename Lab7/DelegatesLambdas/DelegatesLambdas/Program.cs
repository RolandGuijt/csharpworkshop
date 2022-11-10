namespace DelegatesLambdas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var collection = new ItemCollection();
            var results = collection.FilterItems(x => x % 2 == 0);

            foreach (var item in results)
            {
                Console.WriteLine(item);
            }
        }
    }
}