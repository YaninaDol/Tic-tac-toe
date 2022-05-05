
using System.Drawing;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApp2
{
    partial class Form1_Game
    {
        int h=0;
        string winner = string.Empty;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Text = "Game";
            this.BackColor = Color.Orange;
            this.ForeColor = Color.Black;


            this.one = new Button();
            this.one.Name = "one";

            one.Size = new Size(90, 90);
            one.BackColor = Color.White;
            one.ForeColor = Color.BlueViolet;
            one.TextAlign = ContentAlignment.TopCenter;
            one.Font = new Font("Times New Roman", 20, FontStyle.Bold);
            one.Location = new System.Drawing.Point(120, 50);


            this.two = new Button();
            this.two.Name = "two";
            two.Size = new Size(90, 90);
            two.BackColor = Color.White;
            two.ForeColor = Color.BlueViolet;
            two.TextAlign = ContentAlignment.TopCenter;
            two.Font = new Font("Times New Roman", 20, FontStyle.Bold);
            two.Location = new System.Drawing.Point(210, 50);



            this.three = new Button();
            this.three.Name = "three";

            three.Size = new Size(90, 90);
            three.BackColor = Color.White;
            three.ForeColor = Color.BlueViolet;
            three.TextAlign = ContentAlignment.TopCenter;
            three.Font = new Font("Times New Roman", 20, FontStyle.Bold);
            three.Location = new System.Drawing.Point(300, 50);

            this.four= new Button();
            this.four.Name = "four";

            four.Size = new Size(90, 90);
            four.BackColor = Color.White;
            four.ForeColor = Color.BlueViolet;
            four.TextAlign = ContentAlignment.TopCenter;
            four.Font = new Font("Times New Roman", 20, FontStyle.Bold);
            four.Location = new System.Drawing.Point(120, 135);

            this.five = new Button();
            this.five.Name = "five";

            five.Size = new Size(90, 90);
            five.BackColor = Color.White;
            five.ForeColor = Color.BlueViolet;
            five.TextAlign = ContentAlignment.TopCenter;
            five.Font = new Font("Times New Roman", 20, FontStyle.Bold);
            five.Location = new System.Drawing.Point(210, 135);

            this.six = new Button();
            this.six.Name = "six";

            six.Size = new Size(90, 90);
            six.BackColor = Color.White;
            six.ForeColor = Color.BlueViolet;
            six.TextAlign = ContentAlignment.TopCenter;
            six.Font = new Font("Times New Roman", 20, FontStyle.Bold);
            six.Location = new System.Drawing.Point(300, 135);

            this.seven = new Button();
            this.seven.Name = "seven";

            seven.Size = new Size(90, 90);
            seven.BackColor = Color.White;
            seven.ForeColor = Color.BlueViolet;
            seven.TextAlign = ContentAlignment.TopCenter;
            seven.Font = new Font("Times New Roman", 20, FontStyle.Bold);
            seven.Location = new System.Drawing.Point(120, 225);


            this.eight = new Button();
            this.eight.Name = "eight";

            eight.Size = new Size(90, 90);
            eight.BackColor = Color.White;
            eight.ForeColor = Color.BlueViolet;
            eight.TextAlign = ContentAlignment.TopCenter;
            eight.Font = new Font("Times New Roman", 20, FontStyle.Bold);
            eight.Location = new System.Drawing.Point(210, 225);

            this.nine = new Button();
            this.nine.Name = "nine";

            nine.Size = new Size(90, 90);
            nine.BackColor = Color.White;
            nine.ForeColor = Color.BlueViolet;
            nine.TextAlign = ContentAlignment.TopCenter;
            nine.Font = new Font("Times New Roman", 20, FontStyle.Bold);
            nine.Location = new System.Drawing.Point(300, 225);

            hod = new Label();
            this.hod.Size = new Size(200, 20);
            this.hod.Location = new Point(170, 0);
            this.hod.BackColor = Color.White;
            this.hod.ForeColor = Color.BlueViolet;
            this.hod.Font = new System.Drawing.Font("Times New Roman", 15, System.Drawing.FontStyle.Regular);
            this.hod.Text = $" Player: {this.Player1}";


            this.one.Click += Button_Click;
            this.two.Click += Button_Click;
            this.three.Click += Button_Click;
            this.four.Click += Button_Click;
            this.five.Click += Button_Click;
            this.six.Click += Button_Click;
            this.seven.Click += Button_Click;
            this.eight.Click += Button_Click;
            this.nine.Click += Button_Click;

            this.Controls.Add(hod);
            this.Controls.Add(this.one);
            this.Controls.Add(this.two);
            this.Controls.Add(this.three);
            this.Controls.Add(this.four);
            this.Controls.Add(this.five);
            this.Controls.Add(this.six);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.nine);

          
        }
        private void Button_Click(object sender, System.EventArgs e)
        {
            if(h==0)
            {
                this.hod.Text = $" Player: {this.Player1}";
                winner = this.Player1;
                h = 1;
            }
            else
            {
                this.hod.Text = $" Player: {this.Player2}";
                winner = this.Player2;
                h = 0;
            }

            
            DialogResult res = MessageBox.Show(" Ставить Х ?", (sender as Button).Name, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {       
               (sender as Button).Text = "X";               
            }
            else

            {            
               (sender as Button).Text = "O";             
            }
            if ((one.Text == "X" && two.Text == "X" && three.Text == "X") || (one.Text == "O" && two.Text == "O" && three.Text == "O") ||
                (four.Text == "X" && five.Text == "X" && six.Text == "X") || (four.Text == "O" && five.Text == "O" && six.Text == "O") ||
                 (seven.Text == "X" && eight.Text == "X" && nine.Text == "X") || (seven.Text == "O" && eight.Text == "O" && nine.Text == "O") ||
                 (one.Text == "X" && four.Text == "X" && seven.Text == "X") || (one.Text == "O" && four.Text == "O" && seven.Text == "O") ||
                 (two.Text == "X" && five.Text == "X" && eight.Text == "X") || (two.Text == "O" && five.Text == "O" && eight.Text == "O") ||
                 (three.Text == "X" && six.Text == "X" && nine.Text == "X") || (three.Text == "O" && six.Text == "O" && nine.Text == "O") ||
                  (one.Text == "X" && five.Text == "X" && nine.Text == "X") || (one.Text == "O" && five.Text == "O" && nine.Text == "O") ||
                    (three.Text == "X" && five.Text == "X" && seven.Text == "X") || (three.Text == "O" && five.Text == "O" && seven.Text == "O"))

            {
                MessageBox.Show("Game over!");
               string str= File.ReadAllText("Tic_tac_toe");
                string[] rez = str.Split('\n');
                if (rez.Length == 11)
                {
                    File.Delete("Tic_tac_toe");
                }
                else
                {
                    File.AppendAllText("Tic_tac_toe", $"Winner : { winner}\n");
                }
                Form_Menu menu = new Form_Menu();
                menu.Show();
            }
          
        }


        Button one;
        Button two;
        Button three;
        Button four;
        Button five;
        Button six;
        Button seven;
        Button eight;
        Button nine;
        Label hod;
        #endregion
    }
}

