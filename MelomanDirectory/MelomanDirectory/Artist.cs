using System;

namespace MelomanDirectory
{
    /// <summary>
    /// Клас Artist представляє музичного виконавця або групу.
    /// Використовується як базова сутність для зв'язку з піснями та альбомами.
    /// </summary>
    public class Artist
    {
        /// <summary>
        /// Назва групи або ім'я виконавця.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Основний музичний жанр, у якому працює виконавець.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Конструктор для створення нового об'єкта виконавця.
        /// </summary>
        /// <param name="name">Ім'я або назва.</param>
        /// <param name="genre">Жанр.</param>
        public Artist(string name, string genre)
        {
            Name = name;
            Genre = genre;
        }

        /// <summary>
        /// Перевизначення методу для зручного відображення імені в інтерфейсі програми.
        /// </summary>
        public override string ToString()
        {
            return Name;
        }
    }
}