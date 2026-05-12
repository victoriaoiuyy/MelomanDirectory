namespace MelomanDirectory
{
    public class Disk
    {
        public string Title { get; set; }
        public List<Song> Songs { get; set; } = new List<Song>();

        public Disk(string title)
        {
            Title = title;
        }

        public override string ToString() => Title;
    }
} 
