using System.Collections.Generic;
using System.IO;
using System;
using static System.Net.Mime.MediaTypeNames;

namespace SD6503BenchmarkAppAssignment1
{
    public class FileManager
    {
        // File path to store staff data
        private string filePath = "staffData.txt";

        // Method to load all staff data from the text file
        public List<MyClass> LoadStaff()
        {
            List<MyClass> staffList = new List<MyClass>();

            try
            {
                // Use StreamReader to read from the file
                using (StreamReader sr = new StreamReader(filePath))
                {
                    // Read each line until the end of the file
                    while (!sr.EndOfStream)
                    {
                        string temp = sr.ReadLine();
                        string[] values = temp.Split(',');

                        // Create a new MyClass object and populate it with data from the file
                        MyClass sf = new MyClass
                        {
                            StaffId = int.Parse(values[0]),
                            Name = values[1],
                            DateOfBirth = DateTime.Parse(values[2]),
                            Email = values[3],
                            AnnualSalary = decimal.Parse(values[4])
                        };

                        // Add the object to the list
                        staffList.Add(sf);
                    }
                }
            }
            catch (Exception ex)
            {
                // Log an error message if loading fails
                Console.WriteLine($"Error loading staff data: {ex.Message}");
                return null;
            }

            // Return the list of staff objects
            return staffList;
        }

        // Method to save a single staff member's details to a file
        public bool SaveStaff(MyClass sf, string fileName)
        {
            try
            {
                // Use StreamWriter to write data to the file
                using (StreamWriter sw = new StreamWriter(fileName, true))
                {
                    // Write the staff member's data in CSV format
                    sw.WriteLine($"{sf.StaffId},{sf.Name},{sf.DateOfBirth:yyyy-MM-dd},{sf.Email},{sf.AnnualSalary}");
                }
                return true; // Indicate successful save
            }
            catch (Exception ex)
            {
                // Log an error message if saving fails
                Console.WriteLine($"Error saving staff details: {ex.Message}");
                return false; // Indicate failure
            }
        }

        // Method to append a list of staff members to the existing file
        public bool AppendStaff(List<MyClass> staffList)
        {
            try
            {
                // Use StreamWriter with 'true' to append data to the file
                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    // Iterate over each staff member in the list
                    foreach (var sf in staffList)
                    {
                        // Write the staff member's data in CSV format
                        sw.WriteLine($"{sf.StaffId},{sf.Name},{sf.DateOfBirth:yyyy-MM-dd},{sf.Email},{sf.AnnualSalary}");
                    }
                }
                return true; // Indicate successful append
            }
            catch (Exception ex)
            {
                // Log an error message if appending fails
                Console.WriteLine($"Error appending staff data: {ex.Message}");
                return false; // Indicate failure
            }
        }
    }
}