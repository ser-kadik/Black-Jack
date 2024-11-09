using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Black_Jack
{
    public partial class Form1 : Form
    {
        short[] cards = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11, 1 };
        short[] card_suit = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        short sum = 0;
        int current = 0;
        const short max = 21;
        Random rnd = new Random();
        int op_cards;
        int op_sum;

        public Form1()
        {
            InitializeComponent();
            op_sum = rnd.Next(14,28);
            if(op_sum > max) 
            {
                op_cards = rnd.Next(3,7);
            }

            else 
            {
                op_cards = rnd.Next(2, 7);
            }

            label3.Text = op_sum + "";
            
        }

        short stop(short sum, int op_sum)
        {
            op_cards_label.Text = op_cards + "";

            if (op_sum > sum && op_sum <= max)
            {
                return 0;

            }

            else if (sum > max && op_sum <= max)
            {
                return 0;
            }

            else if (op_sum == sum)
            {
                return 1;
            }

            else if (op_sum > max && sum > max)
            {
                return 1;
            }

            else
            {
                return 2;

            }
        }

        void check(short sum, int op_sum)
        {
            if (sum == max)
            {
                stop(sum, op_sum);
            }

            if (sum > max)
            {
                stop(sum, op_sum);
            }

            switch (stop(sum, op_sum))
            {
                case 0:
                    {
                        MessageBox.Show("Ты лузер, лох, дебил, казино и азартные игры плохо, это для дебилов, а ты хороший пример идиота!", "ПРОИГРАЛ");
                        Application.Exit(); break;

                    }

                case 1:
                    {
                        MessageBox.Show("Ничья", "Странно...");
                        Application.Exit(); break;
                    }

                case 2:
                    {
                        MessageBox.Show("Победа, все мани твои!", "греби мани лопатой");
                        Application.Exit(); break;
                    }
            }
        }

        int add_card() 
        {

            current = rnd.Next(0,14);

            card_suit[current]++;

            if (int.Parse(op_cards_label.Text) != op_cards)
            {
                op_cards_label.Text = int.Parse(op_cards_label.Text) + 1 + "";
            }

            if (card_suit[current] != 4 && current != 12 || current != 13)
            {
                sum += cards[current];
                label4.Text = sum + "";
                return current;
            }

            else if (card_suit[current] != 4 && (current == 12 || current == 13)) 
            {
                if (sum + 11 > max)
                {
                    current = 13;
                    sum += cards[current];
                    label4.Text = sum + "";
                    return current;
                }

                else 
                {
                    current = 12;
                    sum += cards[current];
                    label4.Text = sum + "";
                    return current;
                }

            }

            else
            {
                card_suit[current]--;
                op_cards_label.Text = int.Parse(op_cards_label.Text) - 1 + "";
                add_card();
            }

           

            return 0;
        }

       

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (!(sum > 21)) 
            {
                switch (add_card())
                {
                    case 0:
                        {
                            card_box.Items.Add("Двойка"); break;
                        }

                    case 1:
                        {
                            card_box.Items.Add("Тройка"); break;
                        }

                    case 2:
                        {
                            card_box.Items.Add("Четверка"); break;
                        }

                    case 3:
                        {
                            card_box.Items.Add("Пятерка"); break;
                        }

                    case 4:
                        {
                            card_box.Items.Add("Шестерка"); break;
                        }

                    case 5:
                        {
                            card_box.Items.Add("Семерка"); break;
                        }

                    case 6:
                        {
                            card_box.Items.Add("Восьмерка"); break;
                        }

                    case 7:
                        {
                            card_box.Items.Add("Девятка"); break;
                        }

                    case 8:
                        {
                            card_box.Items.Add("Десятка"); break;
                        }

                    case 9:
                        {
                            card_box.Items.Add("Валет"); break;
                        }

                    case 10:
                        {
                            card_box.Items.Add("Дама"); break;
                        }

                    case 11:
                        {
                            card_box.Items.Add("Король"); break;
                        }

                    case 12:
                        {
                            card_box.Items.Add("Туз 11"); break;
                        }

                    case 13:
                        {
                            card_box.Items.Add("Туз 1"); break;
                        }
                }
            }

            else 
            {
                MessageBox.Show("И зачем тебе ещё карта?");
            }
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            check(sum, op_sum);
        }
    }
}
