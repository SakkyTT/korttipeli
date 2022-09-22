using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace korttipeli
{
    class Card
    {
        // Tästä luokasta generoidaan yksittäisiä objektejä
        // eli kortteja, yksi pakka on 52 "Card"-objektiä.

        public enum Suites // voi tallentaa vakio arvoja
        {
            Hearts,     // 0
            Diamonds,   // 1
            Clubs,      // 2
            Spades      // 3
        }

        // properties => dataa
        public int Value { get; set; } // 1-13

        public Suites Suite { get; set; }


        // methods => toiminnallisuus

        // constructor, erikois-metodi, joka suoritetaan
        // kun luokasta luodaan objekti
        public Card(int value, Suites suite)
        {
            Value = value;
            Suite = suite;
        }

        // metodi "GetPictureKey"
        public string GetPictureKey() // 'C' + "7" == key => "C7"
        {
            string returnValue = "";

            char suite = getSuiteId(); // 'C' / 'H' jne
            string value = getValueId(); // "9" / "13" jne

            returnValue = suite + value;

            return returnValue;
        }

        // ja metodi "GetPictureResourceX"

        public static Image GetPictureResourceX(string key)
        {
            return korttipeli.CardPictures.ResourceManager.GetObject(key) as Image;
        }

        private char getSuiteId()
        {
            char returnValue = ' ';

            switch (Suite.ToString())
            {
                // Suite[0]
                case "Hearts":
                    returnValue = 'H';
                    break;
                case "Diamonds":
                    returnValue = 'D';
                    break;
                case "Clubs":
                    returnValue = 'C';
                    break;
                case "Spades":
                    returnValue = 'S';
                    break;
            }

            return returnValue;
        }

        private string getValueId() { // "1"-"10" / "J" "Q" "K"
            string returnValue = "";

            switch (Value)
            {
                case 11:
                    returnValue = "J";
                    break;
                case 12:
                    returnValue = "Q";
                    break;
                case 13:
                    returnValue = "K";
                    break;
                default:
                    returnValue = Value.ToString(); // "1" - "10"
                    break;
            }

            return returnValue;
        }

    }
}
