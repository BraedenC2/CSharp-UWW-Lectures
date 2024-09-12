namespace CS221.Lecture2
{
    public class Movie
    {
        private string title;
        private int year;
        private double rating;
        private int year1 { get; set; }

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public int Year
        {
            get => year;
            set => year = value;
        }

        public double Rating { get; private set; }
    }
}