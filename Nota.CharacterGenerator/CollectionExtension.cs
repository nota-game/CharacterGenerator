using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace Nota.CharacterGenerator
{
    internal static class CollectionExtension
    {


        public static void Syncronize<T>(this ObservableCollection<T> destination, IEnumerable<T> sourceCollection)
        {
            destination = destination ?? throw new ArgumentNullException(nameof(destination));
            sourceCollection = sourceCollection ?? throw new ArgumentNullException(nameof(sourceCollection));

            IList<T> source;
            if (sourceCollection is IList<T>)
                source = sourceCollection as IList<T>;
            else
                source = sourceCollection.ToArray();

            if (destination.Distinct().Count() != destination.Count)
                throw new ArgumentException("List may not containe double Elements", nameof(destination));
            if (source.Distinct().Count() != source.Count)
                throw new ArgumentException("List may not containe double Elements", nameof(sourceCollection));

            var elementsToRemove = new HashSet<T>(destination.Except(source));
            var elementsToAdd = new HashSet<T>(destination.Intersect(source));

            for (int i = 0; i < destination.Count || i < source.Count; i++)
            {
                if (destination.Count < i && elementsToRemove.Contains(destination[i]))
                {
                    destination.RemoveAt(i);
                    i--;
                }
                else if (source.Count < i && elementsToAdd.Contains(source[i]))
                {
                    destination.Insert(i, source[i]);
                }
                else if (source.Count < i && destination.Count > i - 1)
                {
                    var oldIndex = destination.IndexOf(source[i]);
                    destination.Move(oldIndex, i);
                }
                else
                {
                    throw new InvalidOperationException($"Somthing went Wrong Syncronising the Collections.\n\tSource.Count {source.Count}, Destination.Count {destination.Count}, i {i}");
                }
            }
        }
    }
}
