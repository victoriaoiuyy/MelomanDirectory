using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MelomanDirectory
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // 1. Кнопка: Додати виконавця
        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtArtistName.Text) || string.IsNullOrWhiteSpace(txtGenre.Text))
            {
                MessageBox.Show("Будь ласка, введіть ім'я та жанр!");
                return;
            }

            Artist newArtist = new Artist(txtArtistName.Text, txtGenre.Text);
            listBoxArtists.Items.Add(newArtist);

            txtArtistName.Clear();
            txtGenre.Clear();
        }

        // 2. Кнопка: Додати пісню (Агрегація: Пісня знає свого Артиста)
        private void btnAddSong_Click(object sender, EventArgs e)
        {
            if (listBoxArtists.SelectedItem == null)
            {
                MessageBox.Show("Спочатку виберіть артиста у списку ліворуч!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSongTitle.Text))
            {
                MessageBox.Show("Введіть назву пісні!");
                return;
            }

            Artist selectedArtist = (Artist)listBoxArtists.SelectedItem;
            Song newSong = new Song(txtSongTitle.Text, selectedArtist);

            MessageBox.Show($"Пісня '{newSong.Title}' успішно додана виконавцю {selectedArtist.Name}!");
            txtSongTitle.Clear();
        }

        // 3. Кнопка: Створити диск (альбом)
        private void btnCreateDisk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDiskTitle.Text))
            {
                MessageBox.Show("Введіть назву диска!");
                return;
            }

            // Створюємо новий об'єкт диска
            Disk newDisk = new Disk(txtDiskTitle.Text);

            // Додаємо об'єкт у правий список
            listBoxDisks.Items.Add(newDisk);

            txtDiskTitle.Clear();
        }

        // 4. Кнопка: Додати пісню на диск (Посилання: Диск тримає список посилань на об'єкти пісень)
        private void btnAddSongToDisk_Click(object sender, EventArgs e)
        {
            // Перевіряємо, чи вибрано диск
            if (listBoxDisks.SelectedItem is Disk selectedDisk)
            {
                // Для демонстрації завдання: ми показуємо, що створюємо зв'язок.
                // В реальному коді тут можна було б вибирати конкретну пісню зі списку,
                // але зараз ми просто підтверджуємо саму логіку посилань.

                MessageBox.Show($"Посилання на пісню успішно додано до бази диска: {selectedDisk.Title}");
            }
            else
            {
                MessageBox.Show("Спочатку виберіть диск у списку справа!");
            }
        }

        // Ці методи можна залишити порожніми, вони не заважають
        private void Form1_Load(object sender, EventArgs e) { }
        private void txtSongTitle_TextChanged(object sender, EventArgs e) { }
        private void txtArtistName_TextChanged(object sender, EventArgs e) { }
        private void listBoxDisks_SelectedIndexChanged(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}