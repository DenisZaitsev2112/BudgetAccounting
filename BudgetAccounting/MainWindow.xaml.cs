using BudgetAccounting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;




namespace BudgetTracker
{
    public partial class MainWindow : Window
    {
        private List<string> records = new List<string>();
        private List<string> recordTypes = new List<string> { };
        private decimal totalAmount = 0;

        public MainWindow()
        {
            InitializeComponent();
            datePicker.SelectedDate = DateTime.Now;
            recordTypesComboBox.ItemsSource = recordTypes;

            //LoadAppState(); // Загрузка данных при запуске приложения
        }

        private void CreateRecord_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string entryName = entryNameTextBox.Text;
                string selectedType = recordTypesComboBox.SelectedItem as string;
                DateTime selectedDate = datePicker.SelectedDate ?? DateTime.Now;
                string moneyText = moneyTextBox.Text;

                if (!string.IsNullOrEmpty(entryName) && !string.IsNullOrEmpty(selectedType))
                {
                    if (decimal.TryParse(moneyText, out decimal money))
                    {
                        string sign = money < 0 ? "-" : "";
                        money = Math.Abs(money);
                        string record = $"{selectedDate.ToShortDateString()} - {selectedType}: {entryName}, Деньги: {sign}{money:C2}";
                        records.Add(record);
                        recordsListView.Items.Add(record);

                        if (sign == "-") // Если число отрицательное, вычитаем его из общей суммы
                        {
                            money = -money;
                        }

                        UpdateTotal(money);
                    }
                    else
                    {
                        MessageBox.Show("Неверный формат ввода для суммы.");
                    }
                }
                else
                {
                    MessageBox.Show("Пожалуйста, введите имя записи и выберите тип записи.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"1: {ex.Message}");
            }
        }

        private void UpdateTotal(decimal money)
        {
            try
            {
                totalAmount += money;
                UpdateTotalTextBlock();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"2 {ex.Message}");
            }
        }

        private void UpdateTotalTextBlock()
        {
            totalTextBlock.Text = totalAmount.ToString("C2", CultureInfo.CurrentCulture);
        }




        private void CreateNewRecordType_Click(object sender, RoutedEventArgs e)
        {
            // Open a window to create a new record type
            {
                try
                {
                    CreateRecordTypeWindow createRecordTypeWindow = new CreateRecordTypeWindow();
                    createRecordTypeWindow.ShowDialog();

                    if (createRecordTypeWindow.DialogResult == true)
                    {
                        string newType = createRecordTypeWindow.NewRecordType;
                        if (!string.IsNullOrEmpty(newType))
                        {
                            recordTypes.Add(newType);
                            recordTypesComboBox.ItemsSource = null;
                            recordTypesComboBox.ItemsSource = recordTypes;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"3 {ex.Message}");
                }
            }

        }


        private void EditRecord_Click(object sender, RoutedEventArgs e)
        {
            {
                try
                {
                    if (recordsListView.SelectedIndex >= 0)
                    {
                        // Получаем выбранную запись
                        string selectedRecord = recordsListView.SelectedItem as string;

                        // Открываем окно для редактирования записи
                        EditRecordWindow editRecordWindow = new EditRecordWindow(selectedRecord);
                        editRecordWindow.ShowDialog();

                        if (editRecordWindow.DialogResult == true)
                        {
                            // Получаем измененную запись из окна редактирования
                            string editedRecord = editRecordWindow.EditedRecord;

                            // Обновляем запись в списке и ListView
                            int selectedIndex = recordsListView.SelectedIndex;
                            records[selectedIndex] = editedRecord;
                            recordsListView.Items[selectedIndex] = editedRecord;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"4 {ex.Message}");
                }
            }

        }

        private void DeleteRecord_Click(object sender, RoutedEventArgs e)
        {
            {
                try
                {
                    if (recordsListView.SelectedIndex >= 0)
                    {
                        // Удаляем выбранную запись из списка и ListView
                        int selectedIndex = recordsListView.SelectedIndex;
                        records.RemoveAt(selectedIndex);
                        recordsListView.Items.RemoveAt(selectedIndex);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"5 {ex.Message}");
                }
            }

        }

/*        private void SaveAppState()
        {
            try
            {
                AppState appState = new AppState
                {
                    Records = records,
                    TotalAmount = totalAmount,
                    RecordTypes = recordTypes
                };

                string json = JsonConvert.SerializeObject(appState);
                File.WriteAllText("appState.json", json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}");
            }
        }

        private void LoadAppState()
        {
            try
            {
                if (File.Exists("appState.json"))
                {
                    string json = File.ReadAllText("appState.json");
                    AppState loadedState = JsonConvert.DeserializeObject<AppState>(json);

                    records = loadedState.Records;
                    totalAmount = loadedState.TotalAmount;
                    recordTypes = loadedState.RecordTypes;

                    // Обновите UI, если необходимо
                    UpdateUI();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}");
            }
        }

        private void UpdateUI()
        {
            // Обновите UI, используя данные из records, totalAmount и recordTypes
            // Например, обновите ListView и totalTextBlock
            recordsListView.Items.Clear();
            foreach (string record in records)
            {
                recordsListView.Items.Add(record);
            }

            totalTextBlock.Text = totalAmount.ToString("C2", CultureInfo.CurrentCulture);

            recordTypesComboBox.ItemsSource = null;
            recordTypesComboBox.ItemsSource = recordTypes;
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SaveAppState();
        }*/





    }
}