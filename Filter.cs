using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD6503BenchmarkAppAssignment1
{
    // This class provides methods to filter and sort a list of MyClass objects
    class Filter
    {
        // Method to sort a list of MyClass objects in ascending order by Name
        public List<MyClass> SortAZ(List<MyClass> sList)
        {
            // Use LINQ to order the list by Name in ascending order
            sList = sList.OrderBy(x => x.Name).ToList();

            // Return the sorted list
            return sList;
        }

        // Method to sort a list of MyClass objects in descending order by Name
        public List<MyClass> SortZA(List<MyClass> sList)
        {
            // Use LINQ to order the list by Name in descending order
            sList = (from x in sList
                     orderby x.Name descending
                     select x).ToList();

            // Return the sorted list
            return sList;
        }

        // Method to search for MyClass objects that contain a specified term in their Name
        public List<MyClass> Search(List<MyClass> sList, string term)
        {
            // Create a new list to store the search results
            List<MyClass> results = new List<MyClass>();

            // Iterate through each MyClass object in the provided list
            foreach (MyClass sf in sList)
            {
                // Check if the Name contains the search term (case-insensitive)
                if (sf.Name.ToLower().Contains(term.ToLower()))
                {
                    // If it does, add the object to the results list
                    results.Add(sf);
                }
            }

            // Return the list of search results
            return results;
        }
    }
}
