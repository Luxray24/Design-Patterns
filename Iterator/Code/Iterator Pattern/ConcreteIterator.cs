using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    class ConcreteIterator : Iterator
    {
        public int currentItemPosition;
        ConcreteAggregate aggregate;
        public ConcreteIterator(ConcreteAggregate cAggregate)
        {
            aggregate = cAggregate;
        }
        public override String first(String listName)
        {
            currentItemPosition = 0;
            return currentItem(listName);
        }

        public override String next(String listName)
        {
            currentItemPosition++;
            return currentItem(listName);
        }

        public override bool isDone(String listName)
        {
            if(listName == "Albums")
                return (aggregate.albums.Count - 1 == currentItemPosition);
            else
                return (aggregate.bands.Count - 1 == currentItemPosition);
        }

        public override String currentItem(String listName)
        {
            if (listName == "Albums")
                return aggregate.albums[currentItemPosition];
            else
                return aggregate.bands[currentItemPosition];
        }
    }
}
