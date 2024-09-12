namespace CS221.Lecture2
{
    public class Movie
    {
        private string title;
        private int year;
        private double rating;
        private int year1 { get; set; }

        public Movie(string title, int year, double rating)
        {
            Title = title;
            Year = year;
            Rating = rating;
        }

        public override string ToString()
        {
            return $"{Title} ({Year}) {Rating} / 5.0";
        }

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Title cannot be null or empty");
                }
                title = value;
            }
        }

        public int Year
        {
            get => year;
            set
            {
                if (value < 1888 || value > DateTime.Now.Year+1)
                {
                    throw new Exception($"Year must be between 1888 and {DateTime.Now.Year+1}");
                }

                year = value;
            }
        }

        public double Rating 
        {
            get => rating;
            set
            {
                if(value < 0d || value > 5d)
                {
                    throw new Exception("The rating must be between 0 and 5");
                }

                rating = value;
            }
        }
    }
}