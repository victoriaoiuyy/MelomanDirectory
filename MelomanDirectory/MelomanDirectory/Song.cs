using System;

namespace MelomanDirectory
{
    /// <summary>
    /// Клас Song представляє музичну композицію.
    /// Містить посилання на об'єкт класу Artist.
    /// </summary>
    public class Song
    {
        /// <summary>
        /// Назва пісні.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Посилання на об'єкт виконавця (агрегація).
        /// </summary>
        public Artist Performer { get; set; }

        /// <summary>
        /// Конструктор класу Пісня.
        /// </summary>
        /// <param name="title">Назва пісні.</param>
        /// <param name="performer">Об'єкт виконавця.</param>
        public Song(string title, Artist performer)
        {
            Title = title;
            Performer = performer;
        }

        /// <summary>
        /// Повертає назву пісні для відображення.
        /// </summary>
        public override string ToString()
        {
            return Title;
        }
    }
}