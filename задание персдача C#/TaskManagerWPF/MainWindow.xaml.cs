using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace TaskManagerWPF
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<TaskItem> Tasks { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Tasks = new ObservableCollection<TaskItem>();
            TaskListView.ItemsSource = Tasks;
        }

        private void AddTask_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TaskDescription.Text) || TaskDatePicker.SelectedDate == null)
            {
                MessageBox.Show("Введите описание задачи и выберите дату!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            Tasks.Add(new TaskItem { Description = TaskDescription.Text, DueDate = TaskDatePicker.SelectedDate.Value });
            TaskDescription.Clear();
            TaskDatePicker.SelectedDate = null;
        }
    }

    public class TaskItem
    {
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
    }
}