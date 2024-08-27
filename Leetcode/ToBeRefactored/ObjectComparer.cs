using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Leetcode
{
    public class ObjectComparer
    {
        public static bool Compare<T>(T obj1, T obj2)
        {
            if (obj1 == null && obj2 == null)
                return true;
            if (obj1 != null && obj2 == null)
                return false;
            if (obj1 == null && obj2 != null)
                return false;

            var type = obj1.GetType();
            if (type.IsPrimitive)
                return obj1.Equals(obj2);
            if (type == typeof(string))
                return obj1.Equals(obj2);
            if (type == typeof(DateTime))
                return obj1.Equals(obj2);
            if (typeof(IComparable).IsAssignableFrom(type))
            {
                var obj1Comparable = obj1 as IComparable;
                return obj1Comparable.CompareTo(obj2) == 0;
            }
            if (typeof(IEnumerable).IsAssignableFrom(type))
            {
                var obj1Comparable = obj1 as IComparable;
                return obj1Comparable.CompareTo(obj2) == 0;
            }
            foreach (var propertyInfo in type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
            {
                object value1 = propertyInfo.GetValue(obj1, null);
                object value2 = propertyInfo.GetValue(obj2, null);
                if (!Compare(value1, value2)) return false;
            }
            foreach (var fieldInfo in type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
            {
                if (!Compare(fieldInfo.GetValue(obj1), fieldInfo.GetValue(obj2))) return false;
            }
            return true;
        }
    }
}
