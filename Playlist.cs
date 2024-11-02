using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    struct Song
    {
        public Song(string Author, string Title, string Filename)
        {
            this.Author = Author;
            this.Title = Title;
            this.Filename = Filename;
        }
        public string Author;
        public string Title;
        public string Filename;
    }
    class Playlist
    {
        private List<Song> list;
        private int currentIndex;

        public Playlist()//конструктор класса Playlist
        {
            list = new List<Song>();
            currentIndex = 0;
        }
        public void AddSong(string TextAuthor)// перегрузка функции AddSong
        {
            Song song = new Song(TextAuthor, "___", "___");
            list.Add(song);
            currentIndex = list.Count();
        }
        public void AddSong(string TextAuthor, string TextTitle)// перегрузка функции AddSong
        {
            Song song = new Song(TextAuthor, TextTitle, "___");
            list.Add(song);
            currentIndex = list.Count();
        }
        public void AddSong(string TextAuthor, string TextTitle, string TextFilename)// функция AddSong
        {
            Song song = new Song(TextAuthor, TextTitle, TextFilename);
            list.Add(song);
            currentIndex = list.Count();
        }
        public void PrintList(ListBox songlist)//функция для вывода всех песен в listbox
        {
            songlist.Items.Clear();
            foreach (Song song in list)
            {
                songlist.Items.Add($"{song.Author}-{song.Title}-{song.Filename}");
            }
        }
        public void DelSong(int index, ListBox songlist)//функция DelSong, удаляет выбранный ил listbox элемент
        {
            list.RemoveAt(index);
            PrintList(songlist);
        }
        public void DelSong(string name, ListBox songlist)//перегрузка функции DelSong, удаляет введённую песню
        {
            foreach (Song s in list)
            {
                if (s.Filename == name)
                {
                    list.Remove(s);
                    break;
                }
            }
            PrintList(songlist);
        }
        public Song CurrentSong() // функция возвращения списка
        {
            if (list.Count > 0)
                return list[currentIndex];
            else
                throw new IndexOutOfRangeException(
                    "Невозможно получить текущую аудиозапись для пустого плейлиста!");
        }
        public void DELLALL(ListBox songlist)//функция удаления ВСЕХ песен
        {
            list.Clear();
            PrintList(songlist);
        }

    }
}
