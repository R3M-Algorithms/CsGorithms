namespace CsGorithms.Sorting
{
    public static class InsertionSort
    {
        public static IEnumerable<T> Sort<T, TKey>(IEnumerable<T> target
            , Func<T, TKey> keySelector
            , SortingOrder sortingOrder = SortingOrder.Ascending)
        {
            var result = new List<T>(target);
            var isSorted = SortHelpers.IsOrdered(sortingOrder);
            var comparer = Comparer<TKey>.Default.Compare;
            for (int i = 1; i < result.Count; i++)
            {
                int j = i - 1;
                var pivot = result[i];
                while (j >= 0 && !isSorted(comparer(keySelector(result[j]), keySelector(pivot))))
                {
                    result[j+1] = result[j];
                    j--;
                }
                result[j + 1] = pivot;
            }

            return result;
        }

        public static IEnumerable<T> Sort<T>(IEnumerable<T> target, SortingOrder sortingOrder = SortingOrder.Ascending)
        {
            return Sort(target, (x) => x, sortingOrder);
        }
    }
}
