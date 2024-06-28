namespace RecordsStructureTask1
{
    internal class Program
    {
        struct Film
        {
            public string title;
            public string certificate;
            public int year;
            public bool beingShown;

            public Film(string title, string certificate, int year, bool beingShown)
            {
                this.title = title;
                this.certificate = certificate;
                this.year = year;
                this.beingShown = beingShown;

            }
        }
        static void Main(string[] args)
        {
            Film hulk = new Film("Hulk", "12A", 2005, false);
            Film ironMan = new Film("Iron Man","12A",2008,false);
            Film antMan = new Film("Ant-Man", "12A", 2015, false);
            Film[] filmCollection = new Film[] { antMan,hulk,ironMan };
            int year = 0;
            int position = 0;

            //  Write the code to do the following
            // Loop through the array of films and check for the newest film
            // Produce one output to say the name of the newest film

            // Write the code to update the andMan record to show the film is currently being shown


        }
    }
}
