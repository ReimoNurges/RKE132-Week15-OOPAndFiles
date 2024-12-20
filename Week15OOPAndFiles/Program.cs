
List<Movie> myMovie = new List<Movie>();
string[] data = GetDataFromMyFile();
//ReadDataFromArray(data);

foreach (string line in data)
{
    string[] tempArray = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

    Movie newMovie = new Movie(tempArray[0], tempArray[2]);
    myMovie.Add(newMovie);
   
}

foreach (Movie movie in myMovie)
{
    Console.WriteLine($"One of my fav mov {movie.Title} was released in {movie.Year}");
}

static string[] GetDataFromMyFile()
{
    string filePath = @"";
    string[] dataFromFile = File.ReadAllLines(filePath);

    return dataFromFile;
}

static void ReadDataFromArray(string[] someArray)
{
    foreach (string line in someArray)
    {
        Console.WriteLine(line);
    }
}


class Movie
{
    string title;  //fields
    string year;

    public string Title
    {
        get { return year; }
    }
    public Movie(string _title, string _year)
    {
        title = _title;
        year = _year;
    }
}