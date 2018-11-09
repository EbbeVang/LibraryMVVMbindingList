using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using LibraryMVVMbindingList.Annotations;

namespace LibraryMVVMbindingList
{
    class ViewModel : INotifyPropertyChanged
    {
        // her huskes den valgte bog :-)
        private Book _selectedBook;

        // Her gemmes alle bøger - observable coolection betyder at den kan notificere GUI om ændringer
        private ObservableCollection<Book> _books = new ObservableCollection<Book>();

        public ViewModel()
        {
            _books.Add(new Book("1234567654321-1234", "Ebbe Vang", "Flæskesteg for begyndere"));
            _books.Add(new Book("2345-76543-123", "Lars trOlesen", "Frokost på nye måder"));
            _books.Add(new Book("123456-76543-432", "Lasse Coinbæk", "Bitcoin i Vipperød"));
            _books.Add(new Book("12345-765432-12345", "Michael Kærgården", "Den der smører godt, kører godt - Glæden ved at CYKLE"));
        }

        public Book SelectedBook
        {
            get { return _selectedBook; }
            set
            {
                _selectedBook = value;
                OnPropertyChanged(); // fortæller XAML at property er opdateret
            }
        }

        public ObservableCollection<Book> Books
        {
            get { return _books; }
            set { _books = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
