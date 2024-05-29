using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lecture12
{
    /// Joshua Saetern
    /// 05.29.2024
    /// Computer Programming II
    /// Lecture 12
    public partial class MainWindow : Window
    {
        //List to hold Characters
        List<Character> characters = new List<Character>();
        public MainWindow()
        {
            InitializeComponent();

            //Default Characters
            characters.Add(new Character("Will", "McDurken", 14, 9));
            characters.Add(new Character("Rafael", "Ragavan Quicksmith", 18, 16));
            characters.Add(new Character("Charles", "Conan", 10, 0));

            listViewCharacters.ItemsSource = characters;
        }

        private void btnDisplay_Click(object sender, RoutedEventArgs e)
        {
            if (listViewCharacters.SelectedIndex < 0)
            {
                MessageBox.Show("Select an item from the list");
            }
            else
            {
                //Using as keyword
                Character tempCharacter = listViewCharacters.SelectedItem as Character;

                //Check if as keyword worked
                if (tempCharacter != null) {
                    runDisplay.Text = tempCharacter.ToString();
                }
            }
        }

        private void btnCreateCharacter_Click(object sender, RoutedEventArgs e)
        {
            createCharacter();
            listViewCharacters.Items.Refresh();
        }

        private bool createCharacter()
        {
            //Checks if the user has inputted text
            if (String.IsNullOrEmpty(txtBoxUserPlayerName.Text))
            {
                MessageBox.Show("Please enter a Player Name");
                return false;
            }
            if (String.IsNullOrEmpty(txtBoxUserCharacterName.Text))
            {
                MessageBox.Show("Please enter a Character Name");
                return false;
            }
            else
            {
                characters.Add(new Character(txtBoxUserPlayerName.Text, txtBoxUserCharacterName.Text));
                MessageBox.Show("Character Created");
                return true;
            }
        }
    }
}