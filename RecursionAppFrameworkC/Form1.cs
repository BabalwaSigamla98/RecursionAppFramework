using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;

namespace RecursionAppFrameworkC
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
        private string xmlFilePath = string.Empty;

        private void cmdOpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                   xmlFilePath = openFileDialog.FileName; // Store the selected file path
                     txtFileName.Text = xmlFilePath; // Update the text box with the selected file's path
                }
            }
        }


        //Function 1
        private void cmdCountUsingRecursion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(xmlFilePath))
            {
                MessageBox.Show("Please select an XML file first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if no file is selected
            }

            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlFilePath);

                int occurrences = CountOccurrencesUsingDOM(xmlDoc.DocumentElement, "Bond");

                MessageBox.Show($"Occurrences of 'Bond': {occurrences}", "XML Parsing Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading XML file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private int CountOccurrencesUsingDOM(XmlNode node, string targetSurname)
        {
            int count = 0;

            if (node is XmlElement element && element.HasAttribute("Surname") && element.GetAttribute("Surname") == targetSurname)
            {
                count++;
            }

            foreach (XmlNode childNode in node.ChildNodes)
            {
                count += CountOccurrencesUsingDOM(childNode, targetSurname);
            }

            return count;
        }


        private void cmdCountUsingXSLT_Click(object sender, EventArgs e)
		{

            if (string.IsNullOrWhiteSpace(xmlFilePath))
            {
                MessageBox.Show("Please select an XML file first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if no file is selected
            }
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlFilePath);

                int occurrences = CountOccurrencesWithXslt(xmlDoc, "Bond");

                MessageBox.Show($"Occurrences of 'Bond': {occurrences}", "XML Parsing Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading XML file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
              
            
        }

        //Function 2 f

      
        private int CountOccurrencesWithXslt(XmlDocument xmlDoc, string targetSurname)
        {
            string xsltQuery = $@"
                <xsl:stylesheet xmlns:xsl='http://www.w3.org/1999/XSL/Transform' version='1.0'>
                    <xsl:template match='/'>
                        <xsl:value-of select='count(//Person[Surname=""{targetSurname}""])'/>
                    </xsl:template>
                </xsl:stylesheet>";
           
        
                XmlNodeList nodes = xmlDoc.SelectNodes($"//Person[@Surname='{targetSurname}']");

                return nodes.Count;
            


        }


        //Function 3
        private void cmdCountUsingString_Click(object sender, EventArgs e)
		{

            if (string.IsNullOrWhiteSpace(xmlFilePath))
            {
                MessageBox.Show("Please select an XML file first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if no file is selected
            }

            try
            {
                string xmlContent = System.IO.File.ReadAllText(xmlFilePath);

                int occurrences = CountOccurrencesWithStringMethods(xmlContent, "Bond");

                MessageBox.Show($"Occurrences of 'Bond': {occurrences}", "XML Parsing Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading XML file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //string xmlFilePath = "C:/Users/sigamlab/OneDrive - Ovations Technologies/Documents/4_5861817295961067893 - Copy/RecursionAppFrameworkC/RecursionAppFrameworkC/data.xml"; // no need to use you file path, but you can simply call cmdOpenFile_Click method
           
        }

        private int CountOccurrencesWithStringMethods(string xmlContent, string targetSurname)
        {
            int index = xmlContent.IndexOf("Surname='Bond'"); int count = 0;
            while (index != -1)
            {
                count++;
                index = xmlContent.IndexOf("Surname='Bond'", index + 1);
            }
            return count;
        }
    }
}
