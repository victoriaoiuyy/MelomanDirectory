namespace MelomanDirectory
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnAddArtist = new Button();
            txtSongTitle = new TextBox();
            btnAddSong = new Button();
            txtGenre = new TextBox();
            txtArtistName = new TextBox();
            listBoxArtists = new ListBox();
            listBoxDisks = new ListBox();
            txtDiskTitle = new TextBox();
            btnAddSongToDisk = new Button();
            btnCreateDisk = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnAddArtist
            // 
            btnAddArtist.Location = new Point(272, 148);
            btnAddArtist.Name = "btnAddArtist";
            btnAddArtist.Size = new Size(201, 56);
            btnAddArtist.TabIndex = 2;
            btnAddArtist.Text = "Додати виконавця";
            btnAddArtist.UseVisualStyleBackColor = true;
            btnAddArtist.Click += btnAddArtist_Click;
            // 
            // txtSongTitle
            // 
            txtSongTitle.Location = new Point(272, 225);
            txtSongTitle.Name = "txtSongTitle";
            txtSongTitle.Size = new Size(201, 23);
            txtSongTitle.TabIndex = 7;
            txtSongTitle.TextChanged += txtSongTitle_TextChanged;
            // 
            // btnAddSong
            // 
            btnAddSong.Location = new Point(290, 254);
            btnAddSong.Name = "btnAddSong";
            btnAddSong.Size = new Size(166, 50);
            btnAddSong.TabIndex = 9;
            btnAddSong.Text = "Додати пісню";
            btnAddSong.UseVisualStyleBackColor = true;
            btnAddSong.Click += btnAddSong_Click;
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(272, 109);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(201, 23);
            txtGenre.TabIndex = 10;
            // 
            // txtArtistName
            // 
            txtArtistName.BackColor = Color.White;
            txtArtistName.Location = new Point(272, 63);
            txtArtistName.Name = "txtArtistName";
            txtArtistName.Size = new Size(201, 23);
            txtArtistName.TabIndex = 11;
            txtArtistName.TextChanged += txtArtistName_TextChanged;
            // 
            // listBoxArtists
            // 
            listBoxArtists.FormattingEnabled = true;
            listBoxArtists.Location = new Point(12, 28);
            listBoxArtists.Name = "listBoxArtists";
            listBoxArtists.Size = new Size(159, 379);
            listBoxArtists.TabIndex = 12;
            // 
            // listBoxDisks
            // 
            listBoxDisks.FormattingEnabled = true;
            listBoxDisks.Location = new Point(625, 148);
            listBoxDisks.Name = "listBoxDisks";
            listBoxDisks.Size = new Size(156, 259);
            listBoxDisks.TabIndex = 13;
            listBoxDisks.SelectedIndexChanged += listBoxDisks_SelectedIndexChanged;
            // 
            // txtDiskTitle
            // 
            txtDiskTitle.Location = new Point(625, 109);
            txtDiskTitle.Name = "txtDiskTitle";
            txtDiskTitle.Size = new Size(156, 23);
            txtDiskTitle.TabIndex = 14;
            // 
            // btnAddSongToDisk
            // 
            btnAddSongToDisk.Location = new Point(301, 369);
            btnAddSongToDisk.Name = "btnAddSongToDisk";
            btnAddSongToDisk.Size = new Size(142, 38);
            btnAddSongToDisk.TabIndex = 15;
            btnAddSongToDisk.Text = "Додати пісню на диск";
            btnAddSongToDisk.UseVisualStyleBackColor = true;
            btnAddSongToDisk.Click += btnAddSongToDisk_Click;
            // 
            // btnCreateDisk
            // 
            btnCreateDisk.Location = new Point(625, 62);
            btnCreateDisk.Name = "btnCreateDisk";
            btnCreateDisk.Size = new Size(156, 23);
            btnCreateDisk.TabIndex = 16;
            btnCreateDisk.Text = "Створити диск";
            btnCreateDisk.UseVisualStyleBackColor = true;
            btnCreateDisk.Click += btnCreateDisk_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(272, 45);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 17;
            label1.Text = "Ім'я виконавця";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(272, 89);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 18;
            label2.Text = "Жанр:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(625, 89);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 19;
            label3.Text = "Назва диска:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(272, 207);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 20;
            label4.Text = "Назва пісні:";
            label4.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(793, 447);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCreateDisk);
            Controls.Add(btnAddSongToDisk);
            Controls.Add(txtDiskTitle);
            Controls.Add(listBoxDisks);
            Controls.Add(listBoxArtists);
            Controls.Add(txtArtistName);
            Controls.Add(txtGenre);
            Controls.Add(btnAddSong);
            Controls.Add(txtSongTitle);
            Controls.Add(btnAddArtist);
            Name = "Form1";
            Text = "Музичний Каталог";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnAddArtist;
        private TextBox txtSongTitle;
        private Button btnAddSong;
        private TextBox txtGenre;
        private TextBox txtArtistName;
        private ListBox listBoxArtists;
        private ListBox listBoxDisks;
        private TextBox txtDiskTitle;
        private Button btnAddSongToDisk;
        private Button btnCreateDisk;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}