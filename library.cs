class Library{

    public string Name { get; set; }
    public string Address { get; set; }
    public List<Book> Books { get; set; }
    public List<MediaItem> MediaItems { get; set; }

    public Library(string name, string address)
    {
        Name = name;
        Address = address;
        Books = new List<Book>();
        MediaItems = new List<MediaItem>();
    }

    public void AddBook(Book book){

        Books.Add(book);
        
    } 

    public void RemoveBook(Book book){

        if (Books.Contains(book)){
            Books.Remove(book);
            Console.WriteLine("The item you added is succesfully removed.");

        }
        else{

            Console.WriteLine("Couldn't find the item you want to delete.");

        }

    }
    public void AddMediaItem(MediaItem mediaItem){

        MediaItems.Add(mediaItem);
    }

    public void RemoveMediaItem(MediaItem mediaItem){

        if (MediaItems.Contains(mediaItem)){
                
                MediaItems.Remove(mediaItem);
                Console.WriteLine("The item you added is succesfully removed.");

        }
        else{

                Console.WriteLine("Couldn't find the item you want to delete.");
            
        }

    }

    public void PrintCatalog(){

        Console.WriteLine(MediaItems);
        foreach (Book book in Books){
            Console.WriteLine(book.Title);
        }
        foreach (MediaItem mediaItem in MediaItems){
            Console.WriteLine(mediaItem.Title);
        }
    }


}

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public int PublicationYear { get; set; }

    public Book(string title, string author, string isbn, int publicationYear)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        PublicationYear = publicationYear;
    }
}

class MediaItem
{
    public string Title { get; set; }
    public string MediaType { get; set; }
    public int Duration { get; set; }

    public MediaItem(string title, string mediaType, int duration)
    {
        Title = title;
        MediaType = mediaType;
        Duration = duration;
    }
}

// the main method is in the program.cs file in this repo.