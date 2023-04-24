using System;

namespace Lb13
{
    class Program
    {
        interface IBook //интерфейс
        {
            void publish_date_info();
            void number_page_info();
        }
        interface IUser //интерфейс
        {
            void login_info();
            void password_info();
        }

        class Book<T> : IBook //реализация интерфейса бук
        {
            string name;
            string autor;
            T date;
            int pages;
            public Book(string name, string autor, T date, int pages)
            {
                this.name = name;
                this.autor = autor;
                this.date = date;
                this.pages = pages;

            }
            public void book_info() //инфа о названии книги и авторе
            {
                Console.WriteLine($"Книга: {name}. Автор: {autor}");
            }
            public void publish_date_info() //инфа о дате публикации
            {
                Console.WriteLine($"Дата публикации: {date}");
            }
            public void number_page_info() //инфа о колве стр
            {
                Console.WriteLine($"Количество страниц: {pages}");
            }
        }

        class User<T> : IUser //реализация интерфейса юзера
        {
            T login; 
            string password; 

            public User(T login, string password)
            {
                this.login = login;
                this.password = password;
            }

            public void login_info() //инфа о логине
            {
                Console.WriteLine($"Логин: {login}");
            }
            public void password_info() //инфа о пароле
            {
                Console.WriteLine($"Пароль: {password}");
            }
        }
        class Magazine : IUser, IBook
        {
            string user_name;
            string book_name;

            public Magazine(string user_name, string book_name)
            {
                this.user_name = user_name;
                this.book_name = book_name;
            }

            public void buy()
            {
                Console.WriteLine($"Пользователь {user_name} купил книгу {book_name}");
            }
            public void login_info()
            {
            }
            public void password_info()
            {
            }
            public void publish_date_info()
            {
            }
            public void number_page_info()
            {
            }
        }
      
        static void Main(string[] args)
        {

            Book<int> book_int = new Book<int>("Лесной утёс", "Бутыльков А. В.", 27042001, 250); //дата число
            Book<string> book_string = new Book<string>("Опаздун", "Шершенников П. В.", "21 марта 2000 года", 350); //дата строка

            User<string> user_string = new User<string>("Georide", "l43FG343J"); //у первого юзера объект строка
            User<int> user_int = new User<int>(777, "Gre9Gee8"); //у другого число

            Magazine shop = new Magazine("Бобоня", "Вовоня");
            shop.buy();

        }
    }
}