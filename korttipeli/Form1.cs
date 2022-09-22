using korttipeli.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
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

        // nostaa kortin ja käynnistää käyttöliittymän päivityksen
        private void button1_Click(object sender, EventArgs e)
        {
            Card temp = deck.drawCard();
            playerCards.Cards.Add(temp);
            // lisätään uusi label talteen
            addLabel(temp, playerCards.Cards.Count);          
            updateScene(); // update UI
        }

        // Suorittaa kaikki käyttöliittymän päivitykset
        private void updateScene()
        {
            int countCards = 0;
            

            pictureBox1.Image = korttipeli.CardPictures.ResourceManager.GetObject("C1") as Bitmap;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Size = new Size(100, 200);

        }

        private void addLabel(Card c, int countCards)
        {
            const int spacing = 25;

            Label temp = new Label(); // luodaan label objekti
                                      //temp.Location = new Point(12, 13); // objektin sijainti
                                      // objektin arvo
            temp.Text = c.Value.ToString();
            temp.Size = new Size(19, 15);
            // siirrytään oikealla
            // mones kortti menossa + minkä verran siirretään
            temp.Location = new Point(12 + (countCards * spacing), 13);
            // lisätään tämän (this) formin "Controls"
            this.Controls.Add(temp);

            playerCards.Labels.Add(temp);
        }

    }
}
