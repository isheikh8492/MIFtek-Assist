using System.Collections.ObjectModel;

namespace MIFtek_Assist.Models
{
    public class Procedure
    {
        public string Title { get; set; } // Title of the procedure
        public ObservableCollection<string> Steps { get; set; } // Steps in the procedure

        public Procedure(string title)
        {
            Title = title;
            Steps = new ObservableCollection<string>();
        }
    }
}
