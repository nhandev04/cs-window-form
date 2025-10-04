using System.Windows.Forms;

namespace Example06
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private ListBox lstSongs;
        private ListBox lstFavorite;
        private Button btnToFavorite;
        private Button btnToList;
        private Label lblSongs;
        private Label lblFavorite;

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
            this.lstSongs = new ListBox();
            this.lstFavorite = new ListBox();
            this.btnToFavorite = new Button();
            this.btnToList = new Button();
            this.lblSongs = new Label();
            this.lblFavorite = new Label();
            this.SuspendLayout();
            // lblSongs
            this.lblSongs.Location = new System.Drawing.Point(20, 20);
            this.lblSongs.Size = new System.Drawing.Size(200, 20);
            this.lblSongs.Text = "Danh sách bài hát";
            // lstSongs
            this.lstSongs.Location = new System.Drawing.Point(20, 45);
            this.lstSongs.Size = new System.Drawing.Size(220, 250);
            this.lstSongs.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom;
            // lblFavorite
            this.lblFavorite.Location = new System.Drawing.Point(340, 20);
            this.lblFavorite.Size = new System.Drawing.Size(200, 20);
            this.lblFavorite.Text = "Danh sách bài hát ưa thích";
            // lstFavorite
            this.lstFavorite.Location = new System.Drawing.Point(340, 45);
            this.lstFavorite.Size = new System.Drawing.Size(220, 250);
            this.lstFavorite.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
            // btnToFavorite
            this.btnToFavorite.Location = new System.Drawing.Point(260, 120);
            this.btnToFavorite.Size = new System.Drawing.Size(50, 35);
            this.btnToFavorite.Text = ">";
            this.btnToFavorite.Anchor = AnchorStyles.Top;
            // btnToList
            this.btnToList.Location = new System.Drawing.Point(260, 170);
            this.btnToList.Size = new System.Drawing.Size(50, 35);
            this.btnToList.Text = "<";
            this.btnToList.Anchor = AnchorStyles.Top;
            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 320);
            this.Controls.Add(this.lblSongs);
            this.Controls.Add(this.lstSongs);
            this.Controls.Add(this.lblFavorite);
            this.Controls.Add(this.lstFavorite);
            this.Controls.Add(this.btnToFavorite);
            this.Controls.Add(this.btnToList);
            this.Name = "Form1";
            this.Text = "Music";
            this.ResumeLayout(false);
        }

        #endregion
    }
}

