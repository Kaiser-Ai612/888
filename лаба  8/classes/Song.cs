/*Домашнее задание 9.1 В класс Song (из домашнего задания 8.2) добавить следующие
конструкторы:
1) параметры конструктора – название и автор песни, указатель на предыдущую песню
инициализировать null.
2) параметры конструктора – название, автор песни, предыдущая песня. В методе Main
создать объект mySong. Возникнет ли ошибка при инициализации объекта mySong
следующим образом: Song mySong = new Song(); ?
Исправьте ошибку, создав необходимый конструктор.
 */

namespace лаба__8.classes
{
    internal class Song
    {
        private string Name;
        private string Author;
        public Song Connect;

        public Song() { }
        public Song(string name, string author)
        {
            this.Name = name;
            this.Author = author;
        }
        public Song(Song connect, string name, string author)
        {
            this.Name = name;
            this.Author = author;
            this.Connect = connect;
        }
        //чтоб поменять занчение
        public void GiveName(string name)
        {
            this.Name = name;
        }
        //чтоб поменять занчение
        public void GiveAuthor(string author)
        {
            this.Author = author;
        }
        //чтоб поменять занчение
        public void GiveConnect(Song connect)
        {
            this.Connect = connect;
        }
        //    for (int i = 1; i<list.Count; i++)
        //        {
        //            list[i].GiveConnect(list[i - 1]);
        //}
        //print
        public string Title()
        {
            return $"название:{Name} автор:{Author}";
        }
        //сравнение
        public override bool Equals(object d)
        {
            if (d is Song newsong)
            {
                return (this.Name == newsong.Name && this.Author == newsong.Author);
            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Author);
        }
    }
}
