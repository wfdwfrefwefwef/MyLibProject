using System.Collections.ObjectModel;

public class MainViewModel
{
    public ObservableCollection<Book> Books { get; set; }

    public MainViewModel()
    {
        Books = new ObservableCollection<Book>();
    }
}
