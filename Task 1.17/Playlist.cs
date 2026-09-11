namespace CSharpAdvancedConcepts.FeatureApp
{
    public class Playlist
    {
        private string[] song;

        public Playlist(int size)
        {
            song = new string[size];
        }
        public int Length => song.Length;

        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= song.Length)
                {
                    throw new IndexOutOfRangeException(
                        "Playlist index is out of range."
                    );
                }

                return song[index];
            }

            set
            {
                if (index < 0 || index >= song.Length)
                {
                    throw new IndexOutOfRangeException(
                        "Playlist index is out of range."
                    );
                }

                song[index] = value;
            }
        }
    }
}
