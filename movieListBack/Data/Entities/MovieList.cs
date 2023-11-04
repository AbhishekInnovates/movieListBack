namespace movieListBack.Data.Entities
{
    public class MovieList
    {
        public int Id { get; set; }
        public string? movieName { get; set; }
        public string? actorName { get; set;}
        public string? actressName { get; set; }
        public string? posterUrl { get; set; }
    }
}