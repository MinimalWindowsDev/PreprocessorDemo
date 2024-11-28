//#define fix_issue_001
//#undef fix_issue_001

using System.ComponentModel;
using System.Windows;

namespace PreprocessorDemo
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private int _clickCount;

        public event PropertyChangedEventHandler PropertyChanged;

        public bool IsOriginalVersion
        {
            get
            {
#if fix_issue_001
                    return false;
#else
                return true;
#endif
            }
        }

        public bool IsNewVersion
        {
            get
            {
#if fix_issue_001
            return true;
#else
                return false;
#endif
            }
        }

        public int ClickCount
        {
            get => _clickCount;
            set
            {
                _clickCount = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ClickCount)));
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
#if fix_issue_001
                // New version: Increment by 2
                ClickCount += 2;
                MessageBox.Show($"Incremented by 2! New count: {ClickCount}");
#else
            // Original version: Increment by 1
            ClickCount += 1;
            MessageBox.Show($"Incremented by 1! New count: {ClickCount}");
#endif
        }
    }
}