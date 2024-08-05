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
        List<MyClass> staffs = new List<MyClass>();
        FileManager fileManager = new FileManager();
        Filter filter = new Filter();
        public Form1()
        {
            InitializeComponent();

           
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs before adding
                if (ValidateInputs())
                {
                    MyClass newStaff = new MyClass
                    {
                        StaffId = int.Parse(tbxID.Text),
                        Name = tbxName.Text,
                        DateOfBirth = DateTime.Parse(dateSelect.Text),
                        Email = tbxEmail.Text,
                        AnnualSalary = decimal.Parse(tbxSalary.Text)
                    };

                    staffs.Add(newStaff);
                    lstStaff.Items.Add(newStaff);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding staff: {ex.Message}", "Input Error");
            }
        }

        private bool ValidateInputs()
        {
            // Implement validation logic
            if (string.IsNullOrWhiteSpace(tbxID.Text) ||
                string.IsNullOrWhiteSpace(tbxName.Text) ||
                string.IsNullOrWhiteSpace(dateSelect.Text) ||
                string.IsNullOrWhiteSpace(tbxEmail.Text) ||
                string.IsNullOrWhiteSpace(tbxSalary.Text))
            {
                MessageBox.Show("All fields must be filled out.", "Validation Error");
                return false;
            }

            if (!int.TryParse(tbxID.Text, out _) ||
                !DateTime.TryParse(dateSelect.Text, out _) ||
                !decimal.TryParse(tbxSalary.Text, out _))
            {
                MessageBox.Show("Invalid data format.", "Validation Error");
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lstStaff.SelectedItem != null)
            {
                MyClass sf = (MyClass)lstStaff.SelectedItem;
                string filename = "staffData.txt";

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
            staffs.Clear();
            FileManager fm = new FileManager();
            staffs = fm.LoadStaff();

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
            Filter sFilter = new Filter();
            staffs = sFilter.SortAZ(staffs);

            lstStaff.Items.Clear();
            lstStaff.Items.AddRange(staffs.ToArray());
        }

        private void btnSortZA_Click(object sender, EventArgs e)
        {
            Filter sFilter = new Filter();
            staffs = sFilter.SortZA(staffs);

            lstStaff.Items.Clear();
            lstStaff.Items.AddRange(staffs.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<MyClass> results = new List<MyClass>();
             Filter sFilter = new Filter();
            string term = tbxSearch.Text;
            results = sFilter.Search(staffs, term);

            lstSearch.Items.Clear();
            lstSearch.Items.AddRange(results.ToArray());
        }
        private void lstStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstStaff.SelectedItem != null)
            {
                MyClass selectedStaff = (MyClass)lstStaff.SelectedItem;
                staffs.Remove(selectedStaff);
                lstStaff.Items.Remove(selectedStaff);
            }
            else
            {
                MessageBox.Show("Please select a staff member to delete.", "Selection Error");
            }
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate and append all staff members to the file
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
                MessageBox.Show($"Error appending staff data: {ex.Message}", "File IO Error");
            }
        }
    }
}
