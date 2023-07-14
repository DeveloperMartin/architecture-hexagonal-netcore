namespace AH_DDD_ASP.book_management.domain
{
    public class Book
    {
        public int IdBook { get; private set; }
        private string title = string.Empty;
        public string Title
        {
            get { return title; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("El titulo no puede estar vacio");
                }

                title = value;
            }
        }
        public string Sinopsis { get; set; }
        private int score = 0;
        public int Score 
        { 
            get { return score; }
            private set
            {
                if(value > 5)
                {
                    throw new ArgumentException("El puntaje no puede ser mayor a 5");
                } else if (value < 0) 
                {
                    throw new ArgumentException("El puntaje no puede ser menor a 0");
                }
                score = value;
            }
        }
        public int State { get; set; }

        public Book(int idBook, string title, string sinopsis, int score, int state) 
        {
            IdBook = idBook;
            Title = title;
            Sinopsis = sinopsis;
            Score = score;
            State = state;
        }

        public void UpdateId(int newId)
        {
            if (IdBook != 0) 
            {
                throw new InvalidOperationException("No se puede cambiar el Id si ya fue cambiado anteriormente");
            }
        }

        public void UpdateTitle(string newTitle) 
        {
            Title = newTitle;
        }

        public void UpdateScore(int newScore)
        {
            Score = newScore;
        }

        public void UpdateState(int newState)
        {
            State = newState;
        }
    }
}
