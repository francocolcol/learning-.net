using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Clases
{
    public static class ExtensionMethods
    {
        public delegate T2 ClassConverter<T1,T2>(T1 element);
        public static List<T2> MapColletion<T1,T2>(this List<T1> inList, ClassConverter<T1,T2> classConverter)
        {
            List<T2> convertedList = new List<T2>();
            foreach(var element in inList)
            {
                var convertedElement = classConverter(element);
                convertedList.Add(convertedElement);
            }
            return convertedList;
        }
    }
}
