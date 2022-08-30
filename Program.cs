using LibraryHomeWork;

Library library = new Library("Washington Library");
Book book1 = new Book(
    "Том Соер", 
    "Том Со́йер — один из главных персонажей романов Марка Твена: «Приключения Тома Сойера»",
    "Марк Твен",
    DateTime.Now);

Book book2 = new Book(
    "Снежная королева",
    "«Снежная королева» — сказка Ханса Кристиана Андерсена в 7 главах. Это одна из самых длинных и самых популярных сказок Андерсена.",
    "Ханс Кристиан Андерсен",
    new DateTime(1844, 12, 21));

library.AddBook(book1);
library.AddBook(book2);
library.ShowBooks();