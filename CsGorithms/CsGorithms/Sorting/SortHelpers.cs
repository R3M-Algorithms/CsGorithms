namespace CsGorithms.Sorting
{
    public static class SortHelpers
    {
        public static Func<int, bool> IsOrdered(SortingOrder sortingOrder)
        {
            return new Dictionary<SortingOrder, Func<int, bool>>{
                { SortingOrder.Ascending, (int a) => a <= 0 },
                { SortingOrder.Descending, (int a) => a >= 0 }

            }[sortingOrder];
        }
    }
}
