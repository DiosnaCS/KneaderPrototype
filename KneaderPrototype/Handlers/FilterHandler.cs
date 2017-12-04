using System.Collections.Generic;

namespace KneaderPrototype.Handlers
{
    public class FilterHandler
    {
        public List<T> filterArray<T>(T value, IList<T> array) {
            List<T> list = new List<T>();
            foreach (T item in array) {
                if (item.ToString().Contains(value.ToString()))
                {
                    list.Add(item);
                }
            }
            return list;
        }

    }
}