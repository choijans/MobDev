﻿namespace ToDo
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Optionally register routes (useful if you plan to use relative routing)
            Routing.RegisterRoute(nameof(Views.SignInPage), typeof(Views.SignInPage));
            Routing.RegisterRoute(nameof(Views.SignUpPage), typeof(Views.SignUpPage));
            Routing.RegisterRoute(nameof(Views.ToDoTab), typeof(Views.ToDoTab));
            Routing.RegisterRoute(nameof(Views.Completed), typeof(Views.Completed));
        }
    }
}
