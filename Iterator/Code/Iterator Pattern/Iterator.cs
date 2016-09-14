using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator_Pattern
{
    public abstract class Iterator
    {
        public abstract String first(String listName);
        public abstract String next(String listName);
        public abstract bool isDone(String listName);
        public abstract String currentItem(String listName);
    }
}
