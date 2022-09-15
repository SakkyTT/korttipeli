using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace korttipeli
{
    public partial class Form1 : Form
    {
        Deck deck = new Deck();
        Deck playerCards = new Deck();
        public Form1() // constructor
        {
            InitializeComponent();
            // luodaan "Card" luokasta objekti "c1"
            //Card c1 = new Card(5, (Card.Suites)(1));
            //Card c2 = new Card(7, (Card.Suites)(3));

            //List<Card> deck = new List<Card>();

            // Player player1 = new Player();
            deck.fillDeck();
            deck.Shuffle();
            //playerCards.Cards.Add(deck.drawCard());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int countCards = 0;
            const int spacing = 25;

            playerCards.Cards.Add(deck.drawCard());

            foreach (Card c in playerCards.Cards)
            {
                Label temp = new Label(); // luodaan label objekti
                //temp.Location = new Point(12, 13); // objektin sijainti
                                                   // objektin arvo
                temp.Text = c.Value.ToString();
                temp.Size = new Size(19,15);
                // siirrytään oikealla
                // mones kortti menossa + minkä verran siirretään
                temp.Location = new Point(12+(countCards*spacing), 13);
                // lisätään tämän (this) formin "Controls"
                this.Controls.Add(temp);
                countCards++;
            }

        }
        // lisätään uudet luokat "Table" ja "Player".
        // "Table"-luokalla on property "Player", joka on lista pelaajia.
        // Kun luodaan "Table"-luokasta luodaan objekti, sille annetaan
        //      parametrinä listan pelaajia, jotka tallennetaan objektiin.
        // "Table"-luokalla on metodi "RemovePlayer", joka poistaa
        // "Table"-objektin listasta indeksin perusteella pelaajan.

    }
}
