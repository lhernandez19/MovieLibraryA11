using System.Collections.Generic;

namespace MovieLibraryA11.DataModels
{
    public class Genre
    {
        public long Id { get; set; }
        public string Name { get; set; }  
        //A genre can belong to many movies
        public virtual ICollection<MovieGenre>  MovieGenres {get; set;} 
    }
}