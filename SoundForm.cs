using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace _2
{
    public partial class SoundForm : Form
    {
        Playlist playlist = new Playlist();
        public SoundForm()
        {
            InitializeComponent();
        }

        private void AddMusic_Click_1(object sender, EventArgs e)//Функция показывающая/скрывающая панель добавления песни
        {
            if (panelMusic.Visible)
            {
                panelMusic.Visible = false;
            }
            else
            {
                panelMusic.Visible = true;
            }
        }

        private void StartAddMusic_Click_1(object sender, EventArgs e)//кнопка для добавления песни в лист
        {
            if (!string.IsNullOrEmpty(TextAuthor.Text))
            {
                Song song = new Song();
                song.Author = TextAuthor.Text;
                song.Title = TextTitle.Text;
                song.Filename = TextFilename.Text;
                if (!string.IsNullOrEmpty(TextAuthor.Text) &&
                    !string.IsNullOrEmpty(TextTitle.Text) &&
                    !string.IsNullOrEmpty(TextFilename.Text))
                {
                    playlist.AddSong(TextAuthor.Text, TextTitle.Text, TextFilename.Text);
                }
                else if (!string.IsNullOrEmpty(TextAuthor.Text) &&
                    !string.IsNullOrEmpty(TextTitle.Text))
                {
                    playlist.AddSong(TextAuthor.Text, TextTitle.Text);
                }
                else if (!string.IsNullOrEmpty(TextAuthor.Text))
                {
                    playlist.AddSong(TextAuthor.Text);
                }
            }

            playlist.PrintList(listBoxAllMusic);
        }

        private void past_Click_1(object sender, EventArgs e)//кнопка отмотки на 1 песню назад
        {
            if (listBoxAllMusic.SelectedIndex > 0)
            {
                listBoxAllMusic.SelectedIndex -= 1;
                listBoxMusic.Items.Clear();
                listBoxMusic.Items.Add(listBoxAllMusic.SelectedItem.ToString());
            }
        }

        private void start_Click_1(object sender, EventArgs e)//кнопка проигрывания выбранной песни
        {
            if (listBoxAllMusic.SelectedItems.Count == 0)
            {
                MessageBox.Show("Вы не выбрали элемент");
            }
            else
            {
                listBoxMusic.Items.Clear();
                listBoxMusic.Items.Add(listBoxAllMusic.SelectedItem.ToString());
            }
        }

        private void Next_Click_1(object sender, EventArgs e)//кнопка перемотки на 1 песню вперёд
        {
            if (listBoxAllMusic.SelectedIndex < listBoxAllMusic.Items.Count - 1)
            {
                listBoxAllMusic.SelectedIndex += 1;
                listBoxMusic.Items.Clear();
                listBoxMusic.Items.Add(listBoxAllMusic.SelectedItem.ToString());
            }
        }

        private void GoToStart_Click_1(object sender, EventArgs e)//кнопка перемотки плейлиста в начало
        {
            listBoxAllMusic.SelectedIndex = 0;
            listBoxMusic.Items.Clear();
        }

        private void Deleate_Click_1(object sender, EventArgs e)//кнопка удаления песни
        {
            if (listBoxAllMusic.SelectedItems.Count != 0)
            {
                playlist.DelSong(listBoxAllMusic.SelectedIndex, listBoxAllMusic);
                //listBoxAllMusic.SelectedIndex = 0;

            }
            else if (!string.IsNullOrEmpty(DelSongText.Text))
            {
                playlist.DelSong(DelSongText.Text, listBoxAllMusic);
            }
        }

        private void DellAllBtn_Click(object sender, EventArgs e)//кнопка аннигиляции плейлиста
        {
            playlist.DELLALL(listBoxAllMusic);
        }
    }
}
