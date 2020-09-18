using System;

namespace WinFormUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Accueil";

            // buttonOk
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonOk.Text = "Clique moi";
            this.buttonOk.Size = new System.Drawing.Size(80, 50);
            this.buttonOk.Location = new System.Drawing.Point(200, 50);
            this.buttonOk.Click += new System.EventHandler(buttonOkClicked);
            this.buttonOk.MouseHover += new EventHandler(ButtonOkMouseHover);
            this.Controls.Add(this.buttonOk);
        }

        public System.Windows.Forms.Button buttonOk;

        #endregion
    }
}

