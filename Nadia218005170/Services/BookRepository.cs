namespace Nadia218005170.Services
{
    public class BookRepository
    {
        
    }
}private readonly BookContext _context;
          
                  public BookRepository(ShopContext context)
                  {
                      _context = context;
                  }
          
                  public IEnumerable<Book> GetAll()
                  {
                      return _context.Book.ToList();
                  }
                  public Book Get(int id)
                  {
                      return _context.Shops.FirstOrDefault(m => m.Id == id);
                  }
          
                  public void Add(Book newBook)
  public void Edit(int id, Shop shop)
        {
            Book hop;
            hop = _context.Shops.FirstOrDefault(m => m.Id == id);
            _context.Update(hop);
            _context.SaveChanges();
        }  public void Edit(int id, Book Book)
{
}