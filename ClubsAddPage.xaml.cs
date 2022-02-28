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

namespace Shebarin_Kval
{
    /// <summary>
    /// Логика взаимодействия для ClubsAddPage.xaml
    /// </summary>
    public partial class ClubsAddPage : Page
    {
        public ClubsAddPage()
        {
            InitializeComponent();
        }

        private void AddClub(object sender, RoutedEventArgs e)
        {
            FitnessEntities DB = new FitnessEntities();
            var context = FitnessEntities.GetContext();

            fitness_clubs club = new fitness_clubs();
            club.club_id = context.fitness_clubs.Count() + 1;
            club.club_name = club_nameBox.Text.Trim();
            club.address = addressBox.Text.Trim();
            club.phone_number = phone_numberBox.Text.Trim();
            club.open_date = open_dateBox.SelectedDate;
            club.site_url = site_urlBox.Text.Trim();
            DB.fitness_clubs.Add(club);
            DB.SaveChanges();

        }
    }
}
