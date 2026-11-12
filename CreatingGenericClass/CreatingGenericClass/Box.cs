using System;
using System.Collections.Generic;
using System.Text;

namespace CreatingGenericClass
{
    internal class Box<T>
    {
        public T Content { get; set; }
        public string Log()
        {
            return $"Box contains {Content}";
        }
    }
}
