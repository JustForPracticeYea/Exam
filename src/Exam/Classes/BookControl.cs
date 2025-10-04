using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Classes
{
    public class BookControl
    {
        public List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void ShowAllBooks()
        {
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine($"{i + 1}| Жанр книги: {books[i].Genre} | Автор книги: {books[i].Author} | Название книги: {books[i].Title}");
            }
        }

        public void SortDescending()
        {
            for (int i = 0; i < books.Count - 1; i++)
            {
                for (int j = 0; j < books.Count - i - 1; j++)
                {
                    if (ShouldSwap(books[j], books[j + 1]))
                    {
                        Book temp = books[j];
                        books[j] = books[j + 1];
                        books[j + 1] = temp;
                    }
                }
            }
        }
        private bool ShouldSwap(Book firstBook, Book secondBook)
        {
            if (firstBook.Genre != secondBook.Genre)
            {
                return IsStringGreater(secondBook.Genre, firstBook.Genre);
            }
            if (firstBook.Author != secondBook.Author)
            {
                return IsStringGreater(secondBook.Author, firstBook.Author);
            }
            return IsStringGreater(secondBook.Title, firstBook.Title);
        }

        private bool IsStringGreater(string firstBookStr, string secondBookStr)
        {
            int minLength = Math.Min(firstBookStr.Length, secondBookStr.Length);

            for (int i = 0; i < minLength; i++)
            {
                if (firstBookStr[i] != secondBookStr[i])
                {
                    return firstBookStr[i] > secondBookStr[i];
                }
            }   
            return false;
        }

        public void SaveToFile(string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                for (int i = 0; i < books.Count; i++)
                {
                    sw.WriteLine($"{i + 1}| Жанр книги: {books[i].Genre} | Автор книги: {books[i].Author} | Название книги: {books[i].Title}");
                }
            }
            Console.WriteLine($"Данные успешно записаны в файл {path}");
        }
    }
}
