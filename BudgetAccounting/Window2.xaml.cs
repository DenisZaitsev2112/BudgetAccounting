using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace BudgetTracker
{
    public partial class EditRecordWindow : Window
    {
        public string EditedRecord { get; private set; }

        public EditRecordWindow(string selectedRecord)
        {
            InitializeComponent();
            editedRecordTextBox.Text = selectedRecord;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            EditedRecord = editedRecordTextBox.Text;
            DialogResult = true;
            Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}

