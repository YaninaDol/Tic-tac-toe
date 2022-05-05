
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    partial class Form_Menu
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
            this.Text = "Menu";
            this.BackColor = Color.Orange;
            this.ForeColor = Color.Black;

            this.Game_Name = new Label();
            this.Game_Name.Size = new Size(250, 50);
            this.Game_Name.Location = new Point(140, 60);
            this.Game_Name.ForeColor = Color.DeepPink;
            this.Game_Name.BackColor = Color.White;
            this.Game_Name.Text = "TIC-TAC-TOE";
            this.Game_Name.Font = new Font("Times New Roman", 25, FontStyle.Bold);
          
            


            this.Start = new Button();
            this.Start.Name = "Start";
            this.Start.Text = " START ";
            this.Start.Location = new Point(180, 200);
            this.Start.Size = new Size(150, 50);
            this.Start.BackColor = Color.White;
          
            this.Start.ForeColor = Color.HotPink;
            this.Start.Font = new Font("Comic Sans MS", 15, FontStyle.Bold);
            this.Start.Click += Button_Click;
            this.Controls.Add(Game_Name);
            this.Controls.Add(Start);


            this.Rezult = new Button();
            this.Rezult.Name = "Rezult";
            this.Rezult.Text = " REZULT ";
            this.Rezult.Location = new Point(180, 250);
            this.Rezult.Size = new Size(150, 50);
            this.Rezult.BackColor = Color.White;

            this.Rezult.ForeColor = Color.HotPink;
            this.Rezult.Font = new Font("Comic Sans MS", 15, FontStyle.Bold);
            this.Rezult.Click += Button_Click;
        
            this.Controls.Add(Rezult);


            this.Settings = new Button();
            this.Settings.Name = "Settings";
            this.Settings.Text = " SETTINGS ";
            this.Settings.Location = new Point(180, 300);
            this.Settings.Size = new Size(150, 50);
            this.Settings.BackColor = Color.White;

            this.Settings.ForeColor = Color.HotPink;
            this.Settings.Font = new Font("Comic Sans MS", 15, FontStyle.Bold);
            this.Settings.Click += Button_Click;

            this.Controls.Add(Settings);

            this.Exit = new Button();
            this.Exit.Name = "Exit";
            this.Exit.Text = " EXIT ";
            this.Exit.Location = new Point(180, 350);
            this.Exit.Size = new Size(150, 50);
            this.Exit.BackColor = Color.White;

            this.Exit.ForeColor = Color.HotPink;
            this.Exit.Font = new Font("Comic Sans MS", 15, FontStyle.Bold);
            this.Exit.Click += Button_Click;

            this.Controls.Add(Exit);


        }
        private void Button_Click(object sender, System.EventArgs e)
        {
            if ((sender as Button).Name == "Start")
            {
                Username_Form one = new Username_Form();
                one.Show();
            }
            if ((sender as Button).Name == "Rezult")
            {
                Rezult_form rezult_button = new Rezult_form();
                rezult_button.Show();
            }
            if ((sender as Button).Name == "Settings")
            {
                Setting_form setting = new Setting_form();
                setting.Show();
            }
            if ((sender as Button).Name == "Exit")
            {
                MessageBox.Show(" ARE YOU SHURE?!", " Exit ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }

        }
        Label Game_Name;
        Button Start;
        Button Rezult;
        Button Settings;
        Button Exit;
        #endregion
    }
}