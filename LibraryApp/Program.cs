using LibraryNotebook;
using LibraryNotebook.BookForm;
using LibraryNotebook.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using LibraryNotebook.StudentForm;


namespace LibraryApp
{
    internal static class Program
    {

        public static IServiceProvider ServiceProvider { get; private set; }

        [STAThread]

        
        static void Main()
        {
            ApplicationConfiguration.Initialize();


            var services = new ServiceCollection();
            services.AddLibraryNotebookDataServices();
            services.AddTransient<DashboardForm>();
            services.AddTransient<AddBookForm>(); 
            services.AddTransient<ViewBook>();
            services.AddTransient<IssueBooks>();
            services.AddTransient<ReturnBook>();
            services.AddTransient<AddStudent>();
            services.AddTransient<ViewStudentInfo>();
            ServiceProvider = services.BuildServiceProvider();
            //ServiceProvider.ApplyMigrationsForLibraryNotebookDataService();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var dashboardForm = ServiceProvider.GetRequiredService<DashboardForm>();

            // Démarrage de l'application avec la fenêtre principale
            Application.Run(dashboardForm);
        }
    }
} 