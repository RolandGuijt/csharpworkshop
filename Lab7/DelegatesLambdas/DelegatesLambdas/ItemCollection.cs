namespace DelegatesLambdas
{
    public class ItemCollection
    {
        private int[] _items = { 12, 34, 23, 25, 54 };
        public IEnumerable<int> FilterItems(FilterDelegate filterFunction)
        {
            var result = new List<int>();
            foreach (var item in _items)
            {
                if (filterFunction(item))
                    result.Add(item);
            }
            return result;
        }
    }
}
