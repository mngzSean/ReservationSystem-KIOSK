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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TicketKiosk
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //List<TicketViewModel> TicketList { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            List<TicketViewModel> TicketList = new();
            TicketList.Add(new TicketViewModel(new Ticket("성인", 1500)));
            TicketList.Add(new TicketViewModel(new Ticket("학생", 1200)));
            lstTicket.ItemsSource = TicketList;
        }
    }
}
