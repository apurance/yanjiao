using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yanjiao
{

    public partial class Form1 : Form
    {
        private MyDeck deck;
        private MyDeck deckA;
        private MyDeck deckB;
        
        
        public Form1()
        {
            deck = new MyDeck();
            deckA = new MyDeck();
            deckB = new MyDeck();

            InitializeComponent();
            textBoxDeck.DataBindings.Add("Text", deck, "TheValue",false,DataSourceUpdateMode.Never);
            textBoxDeckA.DataBindings.Add("Text", deckA, "TheValue", false, DataSourceUpdateMode.Never);
            textBoxDeckB.DataBindings.Add("Text", deckB, "TheValue", false, DataSourceUpdateMode.Never);
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            deck.Add(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deck.Add(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            deck.Add(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            deck.Add(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            deck.Add(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            deck.Add(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            deck.Add(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            deck.Add(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            deck.Add(9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            deck.Add(10);
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            deck.Add(11);
        }

        private void buttonQ_Click(object sender, EventArgs e)
        {
            deck.Add(12);
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            deck.Add(13);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            deck.Back();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            deck.Clear();
            deckA.Clear();
            deckB.Clear();
        }

        private void buttonCompute_Click(object sender, EventArgs e)
        {

            List<int> al, bl;
            (al,bl) = Yanjiao.Violent(deck.ToArray());
            deckA.Update(al);
            deckB.Update(bl);
        }
    }
}
