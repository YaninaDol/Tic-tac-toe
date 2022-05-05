
using System.Drawing;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApp2
{
    partial class Rezult_form
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
            this.Text = "Rezult";
            this.BackColor = Color.Orange;
            this.ForeColor = Color.Black;

            this.rezult = new Label();
            this.rezult.Size = new Size(200, 300);
            this.rezult.Location = new Point(50, 50);
            this.rezult.ForeColor = Color.White;
            this.rezult.Text = File.ReadAllText("Tic_tac_toe");
            this.rezult.Font = new System.Drawing.Font("Times New Roman", 15, System.Drawing.FontStyle.Regular);


            this.back = new Button();
            this.back.Name = " Continue ";
            this.back.Text = " Back to menu ";
            this.back.Location = new Point(320, 380);
            this.back.Size = new Size(150, 50);
            this.back.BackColor = Color.White;

            this.back.ForeColor = Color.HotPink;
            this.back.Font = new Font("Comic Sans MS", 10, FontStyle.Bold);
            this.back.Click += Button_Click;


            Controls.Add(rezult);
            Controls.Add(back);
        }
        private void Button_Click(object sender, System.EventArgs e)
        {
            Form_Menu menu = new Form_Menu();
            menu.Show();
        }
        Label rezult;
        Button back;
        #endregion
    }
}