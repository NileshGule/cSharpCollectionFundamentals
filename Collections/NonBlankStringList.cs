using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Collections
{
    class NonBlankStringList : Collection<string>
    {
        static void Main(string[] args)
        {
            NonBlankStringList nonBlankList = new NonBlankStringList();
            nonBlankList.Add("Item added at index 0");
            nonBlankList[0] = "item changed at index 0";
            nonBlankList.Add("Item added at index 1");
            nonBlankList.Add("Item inserted at index 2");

            nonBlankList.ToList()
                        .ForEach(x => Console.WriteLine(x));
        }

        protected override void InsertItem(int index, string item)
        {
            if (ValidateInput(item))
            {
                base.InsertItem(index, item);
            }
        }

        protected override void SetItem(int index, string item) 
        {
            if(ValidateInput(item))
            {
                base.SetItem(index, item);
            }
        }

        private static bool ValidateInput(string item)
        {
            if (string.IsNullOrWhiteSpace(item))
            {
                throw new ArgumentException("Element of NonBlankStringList must not be null or whitespace");
            }

            return true;
        }
    }
}