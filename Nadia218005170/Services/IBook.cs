using Nadia218005170.Models;

namespace Nadia218005170.Services
{
    public interface IBook
    {
        Books RedterBooks(int id , string ISBN ,string BookTitle)
        Books UpdateBooks(Books books);
        Books DeleteBooks(Books books);


    }
}