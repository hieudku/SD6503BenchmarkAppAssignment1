using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SD6503BenchmarkAppAssignment1
{
    public partial class Form1 : Form
    {
        // List to hold staff objects
        List<MyClass> staffs = new List<MyClass>();

        // Instances of FileManager and Filter classes
        FileManager fileManager = new FileManager();
        Filter filter = new Filter();

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // Placeholder for any actions when group box is entered
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs before adding a new staff member
                if (ValidateInputs())
                {
                    // Create a new staff object with the provided inputs
                    MyClass newStaff = new MyClass
                    {
                        StaffId = int.Parse(tbxID.Text),
                        Name = tbxName.Text,
                        DateOfBirth = DateTime.Parse(dateSelect.Text),
                        Email = tbxEmail.Text,
                        AnnualSalary = decimal.Parse(tbxSalary.Text)
                    };

                    // Add the new staff object to the list and ListBox
                    staffs.Add(newStaff);
                    lstStaff.Items.Add(newStaff);
                }
            }
            catch (Exception ex)
            {
                // Display error message if any exception occurs
                MessageBox.Show($"Error adding staff: {ex.Message}", "Input Error");
            }
        }

        private bool ValidateInputs()
        {
            // Validate input fields to ensure they are filled and properly formatted
            if (string.IsNullOrWhiteSpace(tbxID.Text) ||
                string.IsNullOrWhiteSpace(tbxName.Text) ||
                string.IsNullOrWhiteSpace(dateSelect.Text) ||
                string.IsNullOrWhiteSpace(tbxEmail.Text) ||
                string.IsNullOrWhiteSpace(tbxSalary.Text))
            {
                MessageBox.Show("All fields must be filled out.", "Validation Error");
                return false;
            }
            // Validate if ID, Date of Birth, and Salary are in correct format
            if (!int.TryParse(tbxID.Text, out int staffId) ||
                !DateTime.TryParse(dateSelect.Text, out _) ||
                !decimal.TryParse(tbxSalary.Text, out decimal salary) ||
                !IsValidSalary(salary) ||
                !IsPositiveStaffId(staffId))
            {
                MessageBox.Show("Invalid data format, salary out of range, or staff ID is not positive.", "Validation Error");
                return false;
            }
            return true;
        }

        // Method to validate if staff id value is positive
        private bool IsPositiveStaffId(int staffId)
        {
            if (staffId < 0)
            {
                MessageBox.Show("Staff ID must be a non-negative value.", "Validation Error");
                return false;
            }

            return true;
        }
        private bool IsValidSalary(decimal salary)
        {
            // Define the minimum and maximum salary range
            decimal minSalary = 30000m;
            decimal maxSalary = 200000m;

            // Check if the salary is within the range
            if (salary < minSalary || salary > maxSalary)
            {
                MessageBox.Show($"Salary must be between {minSalary:C} and {maxSalary:C}.", "Validation Error");
                return false;
            }

            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in the ListBox
            if (lstStaff.SelectedItem != null)
            {
                MyClass sf = (MyClass)lstStaff.SelectedItem;
                string filename = "staffData.txt";

                // Save the selected staff details to the file
                bool success = fileManager.SaveStaff(sf, filename);
                if (success)
                {
                    MessageBox.Show("Staff details saved successfully.", "Success");
                }
                else
                {
                    MessageBox.Show("Error saving staff details.", "File IO Error");
                }
            }
            else
            {
                MessageBox.Show("Please select a staff member to save.", "Selection Error");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // Clear current staff list and load staff from the file
            staffs.Clear();
            staffs = fileManager.LoadStaff();

            if (staffs == null)
            {
                MessageBox.Show("Error loading staff details", "File IO Error");
            }
            else
            {
                lstStaff.Items.Clear();
                lstStaff.Items.AddRange(staffs.ToArray());
            }
        }

        private void btnSortAZ_Click(object sender, EventArgs e)
        {
            // Sort the staff list in ascending order by name and update the ListBox
            staffs = filter.SortAZ(staffs);
            lstStaff.Items.Clear();
            lstStaff.Items.AddRange(staffs.ToArray());
        }

        private void btnSortZA_Click(object sender, EventArgs e)
        {
            // Sort the staff list in descending order by name and update the ListBox
            staffs = filter.SortZA(staffs);
            lstStaff.Items.Clear();
            lstStaff.Items.AddRange(staffs.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Search for staff members based on the search term and update the search results ListBox
            string term = tbxSearch.Text;
            List<MyClass> results = filter.Search(staffs, term);

            lstSearch.Items.Clear();
            lstSearch.Items.AddRange(results.ToArray());
        }

        private void lstStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Placeholder for actions when a staff item is selected in the ListBox
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in the ListBox
            if (lstStaff.SelectedItem != null)
            {
                // Get the selected staff object
                MyClass selectedStaff = (MyClass)lstStaff.SelectedItem;

                // Remove the item from the ListBox
                lstStaff.Items.Remove(selectedStaff);

                // Remove the item from the internal list
                staffs.Remove(selectedStaff);

                // Delete the item from the file
                DeleteFromFile(selectedStaff);
            }
            else
            {
                MessageBox.Show("Please select a staff member to delete.", "Selection Error");
            }
        }

        private void DeleteFromFile(MyClass staffToDelete)
        {
            try
            {
                // Read all lines from the file
                var lines = File.ReadAllLines("staffData.txt").ToList();

                // Remove the line matching the staff member to delete
                lines = lines.Where(line => !line.Contains(staffToDelete.StaffId.ToString())).ToList();

                // Write the remaining lines back to the file
                File.WriteAllLines("staffData.txt", lines);
            }
            catch (Exception ex)
            {
                // Display error message if any exception occurs
                MessageBox.Show($"Error deleting staff details: {ex.Message}", "File IO Error");
            }
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            try
            {
                // Append all staff members to the file
                string filename = "staffData.txt";
                using (StreamWriter sw = new StreamWriter(filename, true))
                {
                    foreach (var staff in staffs)
                    {
                        sw.WriteLine($"{staff.StaffId},{staff.Name},{staff.DateOfBirth:yyyy-MM-dd},{staff.Email},{staff.AnnualSalary}");
                    }
                }
                MessageBox.Show("Staff data appended to file successfully.", "Success");
            }
            catch (Exception ex)
            {
                // Display error message if any exception occurs
                MessageBox.Show($"Error appending staff data: {ex.Message}", "File IO Error");
            }
        }

        private void tbxID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
