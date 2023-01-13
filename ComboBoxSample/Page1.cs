
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using Wisej.Web;

namespace ComboBoxSample
{
    public partial class Page1 : Page
    {
        private string fileName = Application.MapPath(@".\sampleData.json");
        public Page1()
        {
            InitializeComponent();
        }

        private void Page1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(fileName))
            {
                MessageBox.Show("Sample data file not found");
                return;
            }
            string fileContent = File.ReadAllText(fileName);
            List<SampleData> sampleData = JsonConvert.DeserializeObject<List<SampleData>>(fileContent);
            sampleData.Insert(0, new SampleData { Id = 0, Value = "" });
            sampleComboBox.DisplayMember = "Value";
            sampleComboBox.ValueMember = "Id";
            sampleComboBox.DataSource = sampleData;
        }
    }
}
