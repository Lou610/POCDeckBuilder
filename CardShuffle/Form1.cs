using CardShuffle.Helpers;
using CardShuffle.Models;

namespace CardShuffle
{
    public partial class MyForm : Form
    {
        private Game game;

        public MyForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game();

            // You can also call other game methods here if needed
            // For example, displaying the initial hand, etc.
            DisplayHand();

        }

        private void DisplayHand()
        {
            lstCards.Items.Clear(); // Clear existing items

            foreach (var card in game.Hand)
            {
                string cardDescription = $"{card.Value} of {card.Suit}";
                lstCards.Items.Add(cardDescription);
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            game.DrawNewHand();
            DisplayHand(); // Update ListBox after drawing a new hand
        }

        private void ReShuffle_Click(object sender, EventArgs e)
        {

            int selectedCardIndex = lstCards.SelectedIndex;

            if (selectedCardIndex != -1)
            {
                game.RemoveCardFromHandAndSendToGraveyard(selectedCardIndex);
                DisplayHand(); // Refresh the ListBox and card count
            }
            else
            {
                MessageBox.Show("Please select a card to remove.");
            }

            game.ReshuffleHand();
            DisplayHand(); // Update ListBox after reshuffling
        }
    }
}
