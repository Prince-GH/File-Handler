using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq.Expressions;

namespace fileCreationOpr
{
    public partial class FileHandler : Form
    {
        public FileHandler()
        {
            InitializeComponent();
            new listCustom(drivers, this);
            new listCustom(Folders, this);
            new listCustom(Files, this);

        }

        private void FileHandler_Load(object sender, EventArgs e)
        {

            // fetch all the drive from the system 
            foreach (DriveInfo dir in DriveInfo.GetDrives())
            {
                drivers.Items.Add(dir);
            }
            // Show previous button or not
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the file path is empty
                if (string.IsNullOrWhiteSpace(path.Text))
                {
                    MessageBox.Show("The file path is empty. Please enter a valid file path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if the text box is empty
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("The text box is empty. Please enter some text to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Append the text to the file
                using (StreamWriter write = new StreamWriter(path.Text, append: true))
                {
                    write.WriteLine(textBox1.Text);
                }

                // Clear the text box after saving
                textBox1.Text = "";

                MessageBox.Show("File saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handle exceptions and show an error message
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void CREATE_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure only one checkbox is selected
                if (createFile.Checked && createFolder.Checked)
                {
                    MessageBox.Show("Please select only one option: File or Folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Ensure the file name textbox is not empty
                if (string.IsNullOrWhiteSpace(FileTextName.Text))
                {
                    throw new ArgumentNullException("File name cannot be empty.");
                }

                // Ensure the folder path is not empty
                if (string.IsNullOrWhiteSpace(path.Text))
                {
                    throw new ArgumentNullException("Folder path cannot be empty.");
                }

                string pathFolder = path.Text;
                string pathFile = FileTextName.Text;
                string pathName = Path.Combine(pathFolder, pathFile);

                // Check if createFile is checked
                if (createFile.Checked)
                {
                    // Ensure the directory exists
                    if (!Directory.Exists(pathFolder))
                    {
                        throw new DirectoryNotFoundException("The specified folder path does not exist.");
                    }

                    // Check if the file already exists
                    if (File.Exists(pathName))
                    {
                        MessageBox.Show("The file already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Create the file
                    using (FileStream fs = File.Create(pathName))
                    {
                        // File created successfully
                    }

                    // Update UI elements
                    path.Text = pathName;
                    MessageBox.Show($"{pathName} file has been successfully created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // Check if createFolder is checked
                else if (createFolder.Checked)
                {
                    // Ensure the folder does not already exist
                    if (Directory.Exists(pathName))
                    {
                        MessageBox.Show("The folder already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Create the folder
                    Directory.CreateDirectory(pathName);

                    // Update UI elements
                    path.Text = pathName;
                    MessageBox.Show($"{pathName} folder has been successfully created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please select whether to create a file or a folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Check if the file path is empty
                if (string.IsNullOrWhiteSpace(path.Text))
                {
                    MessageBox.Show("The file path is empty. Please enter a valid file path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if the file or directory exists
                if (!File.Exists(path.Text) && !Directory.Exists(path.Text))
                {
                    MessageBox.Show("The specified path does not exist. Please enter a valid file or directory path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Display the panel for confirmation
                popDelete.Visible = true;

                // Set the label text to prompt the user
                string name = Path.GetFileName(path.Text);
                deletePrompt.Text = $"To confirm deletion, \ntype the name of the file/folder: {name}";
                deleteText.Text = ""; // Clear any previous input
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //check text box has char or not
            if (textBox1.Text.Length > 0)
            {
                button4.Visible = true;
            }
            else
            {
                button4.Visible = false;
            }
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                // Validate if the file path is empty
                if (string.IsNullOrWhiteSpace(path.Text))
                {
                    throw new ArgumentNullException("File path cannot be empty.");
                }

                // Check if the file exists
                if (!File.Exists(path.Text))
                {
                    throw new FileNotFoundException("The specified file does not exist.");
                }

                // Retrieve file information
                FileInfo fileData = new FileInfo(path.Text);

                // Display the file name in the textbox
                textBox1.Text = $"File Name: {fileData.Name}";
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FileTextName_TextChanged(object sender, EventArgs e)
        {

        }

        private void READ_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the file path is empty
                if (string.IsNullOrWhiteSpace(path.Text))
                {
                    throw new ArgumentException("File path cannot be empty.");
                }

                // Check if the file exists
                if (!File.Exists(path.Text))
                {
                    throw new FileNotFoundException("The specified file does not exist.");
                }

                // Read the file content
                using (StreamReader reader = new StreamReader(path.Text))
                {
                    textBox1.Text = reader.ReadToEnd();
                }

                MessageBox.Show("File content read successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the file path is empty
                if (string.IsNullOrWhiteSpace(path.Text))
                {
                    MessageBox.Show("The file path is empty. Please enter a valid file path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string filePath = path.Text;

                // Check if the file exists
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("The specified file does not exist. Please provide a valid file path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Read lines from the file
                string[] lines = File.ReadAllLines(filePath);

                // Populate the text box with the file content
                textBox1.Lines = lines;

                MessageBox.Show("File content loaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handle exceptions and show an error message
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void done_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the textBox1 or path is empty
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("The text box is empty. Please enter some text.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(path.Text))
                {
                    MessageBox.Show("The file path is empty. Please enter a valid file path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                List<string> updatedLines = new List<string>();

                foreach (string line in textBox1.Lines)
                {
                    updatedLines.Add(line);
                }

                // Write the updated content back to the file
                File.WriteAllLines(path.Text, updatedLines);

                // Clear the text box after writing to the file
                textBox1.Text = "";
                MessageBox.Show("File updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handle exceptions and show error message
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     
        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        Stack<string> PrePath = new Stack<string>();

        private void drivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Folders.Items.Clear(); //clear all the itmes avil in folders list

            try
            {
                DriveInfo drive = (DriveInfo)drivers.SelectedItem;
                PrePath.Push(drive.Name);
                currentPath.Text = drive.Name;
                foreach (DirectoryInfo dirInfo in drive.RootDirectory.GetDirectories())
                {
                    Folders.Items.Add(dirInfo);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void Folders_SelectedIndexChanged(object sender, EventArgs e)
        {
            Files.Items.Clear();

            try
            {

                DirectoryInfo dir = (DirectoryInfo)Folders.SelectedItem;
                PrePath.Push(dir.FullName);
                currentPath.Text = dir.FullName;
                path.Text = dir.FullName;
                foreach (FileInfo fileInfo in dir.GetFiles())
                {
                    Files.Items.Add(fileInfo);
                }

                foreach (DirectoryInfo dirInfo in dir.GetDirectories())
                {
                    Files.Items.Add(dirInfo);
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Files_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                DirectoryInfo dir = (DirectoryInfo)Files.SelectedItem;
                
                PrePath.Push(dir.FullName);
                currentPath.Text = dir.FullName;
                path.Text = dir.FullName;
                Files.Items.Clear();    //clear all unused file / folders
                foreach (FileInfo fileInfo in dir.GetFiles())
                {
                    Files.Items.Add(fileInfo);
                }

                foreach (DirectoryInfo dirInfo in dir.GetDirectories())
                {
                    Files.Items.Add(dirInfo);
                }
        
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void currentPath_Click(object sender, EventArgs e)
        {

        }
        
        private void path_TextChanged(object sender, EventArgs e)
        {

        
        }


        private void color(object sender, MouseEventArgs e)
        {

        }

        private void ToolTip(object sender, EventArgs e)
        {
       

        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                if (PrePath.Count == 0)
                {
                    throw new InvalidOperationException("No previous path in the stack.");
                }

                currentPath.Text = PrePath.Peek();
                path.Text = PrePath.Peek();
                string dir = PrePath.Pop(); 
                Files.Items.Clear();

                foreach (string file in Directory.GetFiles(dir))
                {
                    FileInfo fileinfo = new FileInfo(file);
                    Files.Items.Add(fileinfo.Name);
                }

                foreach (string dirInfo in Directory.GetDirectories(dir))
                {
                    DirectoryInfo dirinfo = new DirectoryInfo(dirInfo);
                    Files.Items.Add(dirinfo.Name);
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show($"Directory not found: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"Access denied: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void button4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
        }

        private void popDelete_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            try
            {
                string inputName = deleteText.Text;
                string pathToDelete = path.Text;

                // Get the name of the file or folder
                string name = Path.GetFileName(pathToDelete);

                // Check if the user typed the correct name
                if (string.IsNullOrWhiteSpace(inputName) || !inputName.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("The name entered does not match the file or folder name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if it's a file or directory and delete accordingly
                if (File.Exists(pathToDelete))
                {
                    File.Delete(pathToDelete);
                    MessageBox.Show($"{name} file has been successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (Directory.Exists(pathToDelete))
                {
                    // Optionally, ensure the directory is empty before deleting (or handle non-empty directories)
                    Directory.Delete(pathToDelete, true);
                    MessageBox.Show($"{name} folder has been successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Close the delete panel after confirmation
                popDelete.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Cancel_Click(object sender, EventArgs e)
        {
            // Hide the confirmation panel
            popDelete.Visible = false;
        }

        private void createFile_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void createFolder_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
