using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogo_da_velha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string[,] velha = new string[3, 3]; // o "mapa"
        bool jogador = false; // false = vez do X, true = vez do O

        private void btn1_Click(object sender, EventArgs e) //  os botões de jogo, de 1 a 9 os botões do X, de 10 a 18 os botões do O
        {
            if (jogador == false)                           //  so pode jogar se for sua vez, quando joga passa a vez pro outro
            {
                velha[0, 0] = "X";                          //  X|_|_
                btn10.Enabled = false;                      //  _|_|_
                jogador = true;                             //   | |
                (sender as Button).Enabled = false;         //  para impedir que o X e o O coloquem uma letra 2 vezes no mesmo lugar ou que coloque uma letra numa casa ocupada o botão do X e o equivalente do O são desativados e vice-versa
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (jogador == false)
            {
                velha[0, 1] = "X";                          //  _|X|_ 
                btn11.Enabled = false;                      //  _|_|_
                jogador = true;                             //   | |
                (sender as Button).Enabled = false;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (jogador == false)
            {
                velha[0, 2] = "X";                          //  _|_|X
                btn12.Enabled = false;                      //  _|_|_
                jogador = true;                             //   | |
                (sender as Button).Enabled = false;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (jogador == false)
            {
                velha[1, 0] = "X";                          //  _|_|_
                btn13.Enabled = false;                      //  X|_|_
                jogador = true;                             //   | |
                (sender as Button).Enabled = false;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (jogador == false)
            {
                velha[1, 1] = "X";                          //  _|_|_
                btn14.Enabled = false;                      //  _|X|_
                jogador = true;                             //   | |
                (sender as Button).Enabled = false;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (jogador == false)
            {
                velha[1, 2] = "X";                          //  _|_|_
                btn15.Enabled = false;                      //  _|_|X
                jogador = true;                             //   | |
                (sender as Button).Enabled = false;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (jogador == false)
            {
                velha[2, 0] = "X";                          //  _|_|_
                btn16.Enabled = false;                      //  _|_|_
                jogador = true;                             //  X| |
                (sender as Button).Enabled = false;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (jogador == false)
            {
                velha[2, 1] = "X";                          //  _|_|_
                btn17.Enabled = false;                      //  _|_|_
                jogador = true;                             //   |X|
                (sender as Button).Enabled = false;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (jogador == false)
            {
                velha[2, 2] = "X";                          //  _|_|_
                btn18.Enabled = false;                      //  _|_|_
                jogador = true;                             //   | |X
                (sender as Button).Enabled = false;
            }
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            if (jogador == true)
            {
                velha[0, 0] = "O";                          //  O|_|_
                btn1.Enabled = false;                       //  _|_|_
                jogador = false;                            //   | |
                (sender as Button).Enabled = false;
            }
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            if (jogador == true)
            {
                velha[0, 1] = "O";                          //  _|O|_
                btn2.Enabled = false;                       //  _|_|_
                jogador = false;                            //   | |
                (sender as Button).Enabled = false;
            }
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            if (jogador == true)
            {
                velha[0, 2] = "O";                          //  _|_|O
                btn3.Enabled = false;                       //  _|_|_
                jogador = false;                            //   | |
                (sender as Button).Enabled = false;
            }
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            if (jogador == true)
            {
                velha[1, 0] = "O";                          //  _|_|_
                btn4.Enabled = false;                       //  O|_|_
                jogador = false;                            //   | |
                (sender as Button).Enabled = false;
            }
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            if (jogador == true)
            {
                velha[1, 1] = "O";                          //  _|_|_
                btn5.Enabled = false;                       //  _|O|_
                jogador = false;                            //   | |
                (sender as Button).Enabled = false;
            }
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            if (jogador == true)
            {
                velha[1, 2] = "O";                          //  _|_|_
                btn6.Enabled = false;                       //  _|_|O
                jogador = false;                            //   | |
                (sender as Button).Enabled = false;
            }
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            if (jogador == true)
            {
                velha[2, 0] = "O";                          //  _|_|_
                btn7.Enabled = false;                       //  _|_|_
                jogador = false;                            //  O| |
                (sender as Button).Enabled = false;
            }
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            if (jogador == true)
            {
                velha[2, 1] = "O";                          //  _|_|_
                btn8.Enabled = false;                       //  _|_|_
                jogador = false;                            //   |O|
                (sender as Button).Enabled = false;
            }
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            if (jogador == true)
            {
                velha[2, 2] = "O";                          //  _|_|_
                btn9.Enabled = false;                       //  _|_|_
                jogador = false;                            //   | |O
                (sender as Button).Enabled = false;
            }
        }

        private void click(object sender, MouseEventArgs e) //  evento do click de qualquer botão acima
        {
            lbl1.Text = velha[0, 0]; // mostra na tela a localização do X ou O
            lbl2.Text = velha[0, 1]; // 1|2|3
            lbl3.Text = velha[0, 2]; // 4|5|6
            lbl4.Text = velha[1, 0]; // 7|8|9 
            lbl5.Text = velha[1, 1];
            lbl6.Text = velha[1, 2];
            lbl7.Text = velha[2, 0];
            lbl8.Text = velha[2, 1];
            lbl9.Text = velha[2, 2];

            // checa se alguém ganhou
            if (velha[0, 0] == velha[0, 1] && velha[0, 0] == velha[0, 2] && velha[0, 0] == "X") //  X|X|X
            {                                                                                   //  _|_|_
                resultado.Text = "X venceu";                                                    //   | |
            }

            if (velha[1, 0] == velha[1, 1] && velha[1, 0] == velha[1, 2] && velha[1, 0] == "X") //  _|_|_
            {                                                                                   //  X|X|X
                resultado.Text = "X venceu";                                                    //   | |
            }

            if (velha[2, 0] == velha[2, 1] && velha[2, 0] == velha[2, 2] && velha[2, 0] == "X") //  _|_|_
            {                                                                                   //  _|_|_
                resultado.Text = "X venceu";                                                    //  X|X|X
            }

            if (velha[0, 0] == velha[1, 0] && velha[0, 0] == velha[2, 0] && velha[0, 0] == "X") //  X|_|_
            {                                                                                   //  X|_|_
                resultado.Text = "X venceu";                                                    //  X| |
            }

            if (velha[0, 1] == velha[1, 1] && velha[0, 1] == velha[2, 1] && velha[0, 1] == "X") //  _|X|_
            {                                                                                   //  _|X|_
                resultado.Text = "X venceu";                                                    //   |X|
            }

            if (velha[0, 2] == velha[1, 2] && velha[0, 2] == velha[2, 2] && velha[0, 2] == "X") //  _|_|X
            {                                                                                   //  _|_|X
                resultado.Text = "X venceu";                                                    //   | |X
            }

            if (velha[0, 0] == velha[1, 1] && velha[0, 0] == velha[2, 2] && velha[0, 0] == "X") //  X|_|_
            {                                                                                   //  _|X|_
                resultado.Text = "X venceu";                                                    //   | |X
            }

            if (velha[2, 0] == velha[1, 1] && velha[2, 0] == velha[0, 2] && velha[2, 0] == "X") //  _|_|X
            {                                                                                   //  _|X|_
                resultado.Text = "X venceu";                                                    //  X| |
            }

            if (velha[0, 0] == velha[0, 1] && velha[0, 0] == velha[0, 2] && velha[0, 0] == "O") //  O|O|O
            {                                                                                   //  _|_|_
                resultado.Text = "O venceu";                                                    //   | |
            }

            if (velha[1, 0] == velha[1, 1] && velha[1, 0] == velha[1, 2] && velha[1, 0] == "O") //  _|_|_
            {                                                                                   //  O|O|O
                resultado.Text = "O venceu";                                                    //   | |
            }

            if (velha[2, 0] == velha[2, 1] && velha[2, 0] == velha[2, 2] && velha[2, 0] == "O") //  _|_|_
            {                                                                                   //  _|_|_
                resultado.Text = "O venceu";                                                    //  O|O|O
            }

            if (velha[0, 0] == velha[1, 0] && velha[0, 0] == velha[2, 0] && velha[0, 0] == "O") //  O|_|_
            {                                                                                   //  O|_|_
                resultado.Text = "O venceu";                                                    //  O| |
            }

            if (velha[0, 1] == velha[1, 1] && velha[0, 1] == velha[2, 1] && velha[0, 1] == "O") //  _|O|_
            {                                                                                   //  _|O|_
                resultado.Text = "O venceu";                                                    //   |O|
            }

            if (velha[0, 2] == velha[1, 2] && velha[0, 2] == velha[2, 2] && velha[0, 2] == "O") //  _|_|O
            {                                                                                   //  _|_|O
                resultado.Text = "O venceu";                                                    //   | |O
            }

            if (velha[0, 0] == velha[1, 1] && velha[0, 0] == velha[2, 2] && velha[0, 0] == "O") //  O|_|_
            {                                                                                   //  _|O|_
                resultado.Text = "O venceu";                                                    //   | |O
            }

            if (velha[2, 0] == velha[1, 1] && velha[2, 0] == velha[0, 2] && velha[2, 0] == "O") //  _|_|O
            {                                                                                   //  _|O|_
                resultado.Text = "O venceu";                                                    //  O| |
            }

            if (btn1.Enabled == false && btn2.Enabled == false && btn3.Enabled == false && btn4.Enabled == false && btn5.Enabled == false && btn6.Enabled == false && btn7.Enabled == false && btn8.Enabled == false && btn9.Enabled == false) 
                resultado.Text = "deu velha";   // se todos os botões do X foram desativados então não tem como colocar nada no mapa e deu velha

            VezdeQuem();
        }

        private void reiniciar_Click(object sender, EventArgs e)    //  evento de click do botão de reiniciar
        {
            Array.Clear(velha, 0, velha.Length);    //  limpa o mapa
            lbl1.Text = ""; //  limpa a telinha
            lbl2.Text = "";
            lbl3.Text = "";
            lbl4.Text = "";
            lbl5.Text = "";
            lbl6.Text = "";
            lbl7.Text = "";
            lbl8.Text = "";
            lbl9.Text = "";
            btn1.Enabled = true;    // reativa todos os botões de jogo (código ruim, não sei como melhorar)
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btn10.Enabled = true;
            btn11.Enabled = true;
            btn12.Enabled = true;
            btn13.Enabled = true;
            btn14.Enabled = true;
            btn15.Enabled = true;
            btn16.Enabled = true;
            btn17.Enabled = true;
            btn18.Enabled = true;
            jogador = false;    //  passa a vez pro X, que sempre começa
            resultado.Text = "";    //  limpa a tela de resultado
            VezdeQuem();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VezdeQuem();
        }

        private void VezdeQuem()    // desativa e reativa as labels acima dos botões conforme a vez
        {
            if (jogador == false)   //  vez do X
            {
                lbl_O.Enabled = false;
                lbl_X.Enabled = true;
            }
            else                    // vez do O
            {
                lbl_X.Enabled = false;
                lbl_O.Enabled = true;
            }
        }
    }
}