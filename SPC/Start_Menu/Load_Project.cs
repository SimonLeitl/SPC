using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace SPC.Start_Menu
{
    public class Load_Project : Form
    {
        private Button selectButton;
        private OpenFileDialog loadProject1;

        public Load_Project()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();
            Application.Run(new Load_Project());

            loadProject1 = new OpenFileDialog()
            {
                FileName = "Wähle eine Datei aus",
                Filter = "Text files (*.txt)|*.txt",
                Title = "Open File"
            };

            selectButton = new Button()
            {
                Size = new Size(100, 20),
                Location = new Point(15, 15),
                Text = "Select file"
            };

            selectButton.Click += new EventHandler(selectButton_Click);
            Controls.Add(selectButton);
        } 

        private void selectButton_Click(object sender, EventArgs e)
        {
            if(loadProject1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = loadProject1.FileName;
                    using (Stream str = loadProject1.OpenFile())
                    {
                        Process.Start("notepad.exe", filePath);
                    }
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error. message: {ex.Message}" + $"Details: {ex.StackTrace}");
                }
            }
        }   
        
        public void test()
        {

        }
    }
    
  
}
