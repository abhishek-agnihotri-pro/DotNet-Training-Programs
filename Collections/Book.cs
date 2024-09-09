using System.ComponentModel;

class Book : IComparable
{
    public int ID { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public decimal Price { get; set; }

    // public static Book? BookObj { get; set; }
    // private Book(){
    //     ID = 12;
    //     this.Title = "Sixer Machine";
    //     this.Author = "Chris Gayle";
    //     this.Price = 150;
    // }
    public Book(int id, string Title, string Author, decimal Price)
    {
        ID = id;
        this.Title = Title;
        this.Author = Author;
        this.Price = Price;
    }

    // public static Book? GetBook(){

    //     if(BookObj == null){
    //         BookObj = new Book();
    //     }
    //     return BookObj;
    // }

    public override string ToString()
    {
        return $"Book ID : {ID}, Title : {Title}, Author : {Author}, Price : {Price}Rs";
    }

    public int CompareTo(object? obj)
    {
        Book? s = obj as Book;
        if(s == null) return -1;

        // By ID
        // if(this.ID > s.ID){
        //     return 1;
        // }
        // else return -1;

        // By Author
        // return String.Compare(this.Author, s.Author);

        // By Price
        // if(this.Price > s.Price){
        //     return 1;
        // }
        // else return -1;

        // By Title
        return String.Compare(this.Title, s.Title);

        // for string comparision , can user String.Compare(a,b)
    }
}

class AuthorComparer : IComparer<Book>
{
    public int Compare(Book? x, Book? y)
    {
        if(x == null ||  y == null) return -1;
        return String.Compare(x.Author,y.Author);
    }
}
class TitleComparer : IComparer<Book>
{
    public int Compare(Book? x, Book? y)
    {
        if(x == null ||  y == null) return -1;
        return String.Compare(x.Title,y.Title);
    }
}
class PriceComparer : IComparer<Book>
{
    public int Compare(Book? x, Book? y)
    {
        if(x == null || y == null) return -1;
        if(x.Price > y.Price){
            return 1;
        }
        else return -1;
    }
}