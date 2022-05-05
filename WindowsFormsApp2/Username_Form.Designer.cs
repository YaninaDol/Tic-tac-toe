
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    partial class Username_Form
    {
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
            this.Text = "Players";
            this.BackColor = Color.Orange;
            this.ForeColor = Color.Black;

            this.player1_name = new Label();
            this.player1_name.Size = new Size(200, 50);
            this.player1_name.Location = new Point(50, 50);
            this.player1_name.BackColor = Color.White;
            this.player1_name.ForeColor = Color.DeepPink;
            this.player1_name.Text = "   Enter player1 name:";
            this.player1_name.Font = new System.Drawing.Font("Times New Roman", 15, System.Drawing.FontStyle.Regular);



            this.player1_name_text = new TextBox();  
            this.player1_name_text.MaxLength = 20;
            this.player1_name_text.AcceptsTab = true;
            this.player1_name_text.Size = new Size(200, 200);
            this.player1_name_text.ForeColor = Color.DeepPink;
            this.player1_name_text.Location = new Point(250, 50);         
            this.player1_name_text.Font = new System.Drawing.Font("Times New Roman", 15, System.Drawing.FontStyle.Regular);
           


            this.player2_name = new Label();
            this.player2_name.Size = new Size(200, 50);
            this.player2_name.Location = new Point(50, 150);
           
            this.player2_name.BackColor = Color.White;
            this.player2_name.Font = new System.Drawing.Font("Times New Roman", 15, System.Drawing.FontStyle.Regular);
            this.player2_name.ForeColor = Color.DeepPink;
            this.player2_name.Text = "   Enter player2 name:";



            this.player2_name_text = new TextBox();
            this.player2_name_text.Size = new Size(200, 200);
            this.player2_name_text.AcceptsTab = true;
            this.player2_name_text.Location = new Point(250, 150);
            this.player2_name_text.MaxLength = 20;
            this.player2_name_text.Font = new System.Drawing.Font("Times New Roman", 15, System.Drawing.FontStyle.Regular);
            this.player2_name_text.ForeColor = Color.DeepPink;


            this.Continue = new Button();
            this.Continue.Name = " Continue ";
            this.Continue.Text = " LETS PLAY! ";
            this.Continue.Location = new Point(320, 380);
            this.Continue.Size = new Size(150, 50);
            this.Continue.BackColor = Color.White;

            this.Continue.ForeColor = Color.HotPink;
            this.Continue.Font = new Font("Comic Sans MS", 15, FontStyle.Bold);
            this.Continue.Click += Button_Click;
          

            this.Controls.Add(player1_name);
            this.Controls.Add(player2_name);
            this.Controls.Add(Continue);
            this.Controls.Add(player1_name_text);
            this.Controls.Add(player2_name_text);
          
        }
        private void Button_Click(object sender, System.EventArgs e)
        {
            Form1_Game game = new Form1_Game(player1_name_text.Text, player2_name_text.Text);
            game.Show();
        }

        Label player1_name;
        TextBox player1_name_text;

        Label player2_name;
        TextBox player2_name_text;
        Button Continue;
        #endregion
    }
}