using Exam.Classes;

BookControl bookControl = new BookControl();
int size;

while (true)
{
    Console.Write("Введите количество элементов массива: ");
    if (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
    {
        Console.WriteLine("Пожалуйста, введите положительное число.");
    }
    else
        break;
}

for (int i = 0; i < size; i++)
{
    string Title;
    string Author;
    string Genre;
    while (true)
    {
        Console.Write($"Введите жанр {i + 1}-й книги: ");
        Genre = Console.ReadLine();
        if (string.IsNullOrEmpty(Genre))
        {
            Console.WriteLine("Введите не пустое значение");
        }
        else
            break;
    }
    while (true)
    {
        Console.Write($"Введите автора {i + 1}-й книги: ");
        Author = Console.ReadLine();
        if (string.IsNullOrEmpty(Author))
        {
            Console.WriteLine("Введите не пустое значение");
        }
        else
            break;
    }
    while (true)
    {
        Console.Write($"Введите название {i + 1}-й книги: ");
        Title = Console.ReadLine();
        if (string.IsNullOrEmpty(Title))
        {
            Console.WriteLine("Введите не пустое значение");
        }
        else
            break;
    }


    Book book = new Book(Title,Author,Genre);
    bookControl.AddBook(book);
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Массив с заполненными данными:");
bookControl.ShowAllBooks();

Console.WriteLine();
Console.WriteLine("Данные после сортировки по убыванию\n" +
    "(по сочетанию трёх значений: жанра, автора и названия, длина строки не учитывается)");
bookControl.SortDescending();
bookControl.ShowAllBooks();

Console.WriteLine();
bookControl.SaveToFile("BooksControl.txt");