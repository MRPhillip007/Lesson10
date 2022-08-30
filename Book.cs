using System;


namespace LibraryHomeWork
{
    internal class Book
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public DateTime PublicationDate { get; set; }
        public string ISBN { get { return GenerateISBN(); } }

        public Book(string title, string description, string author, DateTime publicationDate)
        {
            Title = title;
            Description = description;
            Author = author;
            PublicationDate = publicationDate;
        }

        static string GenerateISBN(int countryPrefix = 966)
        {
            const int ISBNDIVIDER = 11;
            Random random = new Random();

            int bookPrefix = random.Next(0, 999);
            int publisherID = random.Next(0, 9999);
            int publicationID = random.Next(0, 99);

            string unCalculatedIsb = $"{bookPrefix}{countryPrefix}{publisherID}{publicationID}";

            int position = 0;
            int result = 0;
            for (int i = unCalculatedIsb.Length + 1; i >= 2; i--)
            {
                var index = (i - i) + position;
                var num = int.Parse(unCalculatedIsb[index].ToString());
                result += i * num;

                position++;
            }

            int checkIsbnNumber = ISBNDIVIDER - (result % ISBNDIVIDER);

            string finalIsbn = String.Join("-", bookPrefix, countryPrefix, publisherID, publicationID, checkIsbnNumber);
            return finalIsbn;
        }
    }
}
