using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_und_4
{
    public partial class Form1 : Form
    {


        List<int> L1 = new List<int>() { 7, 7, 7, 7, 8, 8, 8, 8, 9, 9, 9, 9, 10, 10, 10, 10, 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4 };
        List<int> L2 = new List<int>();
        List<int> L3 = new List<int>();

        int p1_Card = 0;     //Deklariert die Karten des Spieler
        int com_Card = 0;      //Deklariert die Karten des Computers

        int p1_cardValue = 0;       //Deklariert die Zufällige Karte des Spielers
        int com_cardValue = 0;     //Deklariert die Zufällige Karte des Computers

        string show_P1Card = "Karten: ";      //deklarierung des Textes der einzelnen Spielerkarten
        string show_ComCard = "karten: ";       //deklarierung des Textes der einzelnen Dealerkarten

        bool p1_ass = false;     //Prüft, ob der Spieler ein Ass gezogen hat
        bool com_ass = false;        //Prüft, ob der Computer ein Ass gezogen hatt

        public Form1()
        {
             InitializeComponent();
            Random zufallsZahl = new Random();
            p1_cardValue = zufallsZahl.Next(0, 
                
            L1.Count());     //Wählen einer zufälligen Karte, aus dem Stapel "L1"

            L2.Add(L1[p1_cardValue]);      //diese zufällige Karte wird auf die Spielerhand hinzugefügt
            show_P1Card += L1[p1_cardValue];        //Die Karte wird dem Spieler bei seinen einzelnen karten angerechnet
            lbl_spielereinzelkarten.Text = show_P1Card;       //Die einzeilkarte wird dem Label hinzugefügt
            p1_Card += L1[p1_cardValue];       //der Wert der Karte wird dem Spieler auf seine insgesammten Punkte angerechnet
            L1.RemoveAt(p1_cardValue);        //diese zufällige Karte wird von dem Kartenstapel entfernt

            p1_cardValue = zufallsZahl.Next(0, L1.Count());     //das ganze nochmal, da man mit 2 karten startet
            L2.Add(L1[p1_cardValue]);
            show_P1Card += ", " + L1[p1_cardValue];
            lbl_spielereinzelkarten.Text = show_P1Card;
            p1_Card += L1[p1_cardValue];
            L1.RemoveAt(p1_cardValue);

            lbl_spieler.Text = "Spieler: " + p1_Card;        //der insgesammte Kartenwert des Spielers wird dem label hinzugefügt



            com_cardValue = zufallsZahl.Next(0, 

               L1.Count());       //Das gesammte wird nochmal für den  Dealer gemacht

            L3.Add(L1[com_cardValue]);
            show_ComCard += L1[com_cardValue];
            lbl_dealereinzelkarten.Text = show_ComCard;
            com_Card += L1[com_cardValue];
            L1.RemoveAt(com_cardValue);

            com_cardValue = zufallsZahl.Next(0, L1.Count());
            L3.Add(L1[com_cardValue]);
            show_ComCard += ", " + L1[com_cardValue];
            lbl_dealereinzelkarten.Text = show_ComCard;
            com_Card += L1[com_cardValue];
            L1.RemoveAt(com_cardValue);

            lbl_dealer.Text = "Dealer: " + com_Card;
        }


        private void btn_wkarte_Click(object sender, EventArgs e)
        {
            Random randomCard = new Random();
            p1_cardValue = randomCard.Next(0, L1.Count());     //eine zufällige Karte aus derdem Kartenstapel wird gewählt

            L2.Add(L1[p1_cardValue]);      //diese zufällige Karte wird auf die Spielerhand hinzugefügt
            if (p1_cardValue == 1)      //wenn ein ass gezogen wird, wird spielerass auf true gesetzt
            {
                p1_ass = true;
            }
            show_P1Card += ", " + L1[p1_cardValue];     //Die Karte wird dem Spieler bei seinen einzelnen karten angerechnet
            lbl_spielereinzelkarten.Text = show_P1Card;       //Die einzeilkarte wird dem Label hinzugefügt
            p1_Card += L1[p1_cardValue];       //der Wert der Karte wird dem Spieler auf seine insgesammten Punkte angerechnet
            L1.RemoveAt(p1_cardValue);        //diese zufällige Karte wird von dem Kartenstapel entfernt

            lbl_spieler.Text = "Spieler: " + p1_Card;        //der insgesammte Kartenwert des Spielers wird dem label hinzugefügt


            if (com_Card < tb_risk.Value)      //solange der insgesammte Kartenwert des Dealers unter dem Risikowert liegt, werden die folgebefehle (dieselben wie beim Spieler nur für den Dealer) ausgeführt
            {
                Random randomCom = new Random();
                com_cardValue = randomCom.Next(0, L1.Count());

                L3.Add(L1[com_cardValue]);
                if (com_cardValue == 1)
                {
                    com_ass = true;
                }
                show_ComCard += ", " + L1[com_cardValue];
                lbl_dealereinzelkarten.Text = show_ComCard;
                com_Card += L1[com_cardValue];
                L1.RemoveAt(com_cardValue);

                lbl_dealer.Text = "Dealer: " + com_Card;
                               
            }
            else        //wenn die Bedingung nicht zutrifft wird angezeigt das der Dealer nichtmehr ziehen möchte
            {
                lbl_dealerende.Visible = true;
            }

            if (p1_Card > 21 || com_Card <= 21 && L3.Count == 5)      //wenn der Spieler über 21 Punkte hat oder der dealer 5 karten hat und trozdem under oder gleich 21 Punkte hat, wird:
            {
                btn_wkarte.Enabled = false;     // die möglichkeit weitere Karten zu ziehen wird entzogen
                btn_ende.Enabled = false;       // die möglichkeit ende zu drücken wird entzogen
                lbl_sieger.Text = "Der Dealer hat gewonnen";        // Siegesanzeige 
            
            }
            if (com_Card > 21 || p1_Card <= 21 && L2.Count == 5)     //wenn der Dealer über 21 Punkte hat oder der Spieler 5 karten hat und trozdem under oder gleich 21 Punkte hat, wird:
            {
                btn_wkarte.Enabled = false;     // die möglichkeit weitere Karten zu ziehen wird entzogen
                btn_ende.Enabled = false;       // die möglichkeit ende zu drücken wird entzogen
                lbl_sieger.Text = "Der Spieler hat gewonnen";       // Siegesanzeige

            }

        }

        private void btn_ende_Click(object sender, EventArgs e)
        {
            btn_wkarte.Enabled = false;     // die möglichkeit ende zu drücken wird entzogen

            if (p1_ass == true)     // wenn der Spieler ein ass hat wird ihm 10 hinzugefügt, esseiden der Spieler würde dann über 21 kommen
            {
                p1_Card += 10;
                if (p1_Card > 21)
                {
                    p1_Card -= 10;
                }
                p1_ass = false;
            }

            while (com_cardValue < tb_risk.Value)
            {
                Random randomCom = new Random();
                com_cardValue = randomCom.Next(0, L1.Count());     // der Dealer zieht solange karten wie der Kartenwert unter dem Risikowert liegt

                L3.Add(L1[com_cardValue]);     //der Rest ist wieder wie bei jedem anderen codeblock bei dem karten gezogen werden für den Dealer
                show_ComCard += ", " + L1[com_cardValue];
                lbl_dealereinzelkarten.Text = show_ComCard;
                com_Card+= L1[com_cardValue];
                L1.RemoveAt(com_cardValue);

                if (com_ass == true)      // wenn der Dealer ein ass hat wird ihm 10 hinzugefügt, esseiden der Dealer würde dann über 21 kommen
                {
                    com_Card+= 10;
                    if (com_Card> 21)
                    {
                        com_Card -= 10;
                    }
                    com_ass = false;
                }

                lbl_dealer.Text = "Dealer: " + show_ComCard;       //der insgesammte Kartenwert des Dealer wird dem label hinzugefügt
            }

            lbl_dealer.Visible = true;      //da das Spiel jetzt vorbei ist, wird der Punktestand vom Dealer sichtbar gemacht
            lbl_dealereinzelkarten.Visible = true;

            if (p1_Card <= 21 && p1_Card > com_Card) { lbl_sieger.Text = "Der Spieler hat gewonnen"; }       // alle möglichen Siegesanzeigen, jenachdem wieviele Punkte der Spieler und der Dealer hat
            if (com_Card <= 21 && p1_Card < com_Card) { lbl_sieger.Text = "Der Dealer hat gewonnen"; }
            if (com_Card > 21) { lbl_sieger.Text = "Der Spieler hat gewonnen"; }
            if (p1_Card > 21) { lbl_sieger.Text = "Der Dealer hat gewonnen"; }
            if (com_Card == p1_Card || com_Card > 21 && p1_Card > 21) { lbl_sieger.Text = "Niemand hat gewonnen"; }
        }

        private void btn_show_Click(object sender, EventArgs e)     //bietet die möglichkeit wärend der Runde die Karten des Dealers sichtbar oder unsichtbar zu schalten (für die cheater ;) )
        {
            lbl_dealer.Visible = !lbl_dealer.Visible;
            lbl_dealereinzelkarten.Visible = !lbl_dealereinzelkarten.Visible;
        }

        private void lbl_risk2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tb_risk_Scroll(object sender, EventArgs e)
        {

        }

        private void lbl_risk_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
