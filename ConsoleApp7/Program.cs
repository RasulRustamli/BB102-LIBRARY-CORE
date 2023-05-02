using ConsoleApp7.DAL;
using ConsoleApp7.Model;

namespace ConsoleApp7
{
    internal class Program
    {
        static Context context=new Context();
        static void Main(string[] args)
        {
            Remove(2);

        }

        static void Add(Book book)
        {
            context.Books.Add(book);
            context.SaveChanges();
        }
        static void Remove(int id)
        {
           var oldBook= GetById(id);
            context.Books.Remove(oldBook);
            context.SaveChanges();
        }
        static Book GetById(int id)
        {
            return context.Books.FirstOrDefault(x => x.Id == id);
        }
        static List<Book> GetAll()
        {
            return context.Books.ToList();
        }
    }
}