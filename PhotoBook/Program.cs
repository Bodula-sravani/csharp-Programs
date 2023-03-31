namespace PhotoBook
{
    public class PhotoBookClass
    {

        public int album;
        public PhotoBookClass() 
        {
            this.album = 16; ;
            Console.WriteLine("in default constructor");
        }

        public PhotoBookClass(int pages)
        {
            this.album=pages;
            Console.WriteLine("in parameterised constructor");
        }
        public int GetnumberPages()
        {
            return this.album;
        }
        static void Main(string[] args)
        {
            PhotoBookClass p = new PhotoBookClass();  //default constructor
           Console.WriteLine($"Total no of pages: {p.GetnumberPages()}");

        }
    }

    public class AddPhotoBook:PhotoBookClass
    {
        public AddPhotoBook()
        {

            this.album = 64;
        }

    }
}