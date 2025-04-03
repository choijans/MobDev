using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace ToDo.Views
{
    public partial class ToDoTab : ContentPage
    {
        public ObservableCollection<TodoItem> TodoItems { get; set; }

        public ToDoTab()
        {
            InitializeComponent();
            
            // Initialize with static data
            TodoItems = new ObservableCollection<TodoItem>
            {
                new TodoItem { Title = "title 1" },
                new TodoItem { Title = "title 2" },
                new TodoItem { Title = "title 3" },
                new TodoItem { Title = "title 4" },
                new TodoItem { Title = "title 5" }
            };
            
            BindingContext = this;
        }
        
        private async void OnCompleteTapped(object? sender, EventArgs e)
        {
            await Navigation.PushAsync(new Completed());
        }
    }
    
    // Simple model for TodoItem
    public class TodoItem
    {
        public string Title { get; set; }
    }

}