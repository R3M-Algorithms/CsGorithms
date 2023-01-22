namespace CsGorithms.Sorting
{
    public static class BubbleSort
    {
        public static IEnumerable<T> Sort<T, TKey>(IEnumerable<T> target
            , Func<T, TKey> keySelector
            , SortingOrder sortingOrder = SortingOrder.Ascending)
        {
            var result = new List<T>(target);
            var isSorted = SortHelpers.IsOrdered(sortingOrder);
            var comparer = Comparer<TKey>.Default.Compare;
            bool swapped;
            do
            {
                swapped = false;
                for(int i = 0; i < result.Count - 1; i++)
                {
                    var comparisonResult = comparer(keySelector(result[i]), keySelector(result[i + 1]));
                    if (!isSorted(comparisonResult))
                    {
                        (result[i], result[i + 1]) = (result[i + 1], result[i]);
                        swapped =true;
                    }
                }
            } while(swapped);


            return result;
        }

        public static IEnumerable<T> Sort<T>(IEnumerable<T> target, SortingOrder sortingOrder = SortingOrder.Ascending)
        {
            return Sort(target, (x) => x, sortingOrder);
        }
    }
}
