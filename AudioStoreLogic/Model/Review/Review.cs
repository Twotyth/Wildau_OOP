namespace AudioStoreLogic.Model.Review;

public class Review
{
    internal string Content { get; set; }
    internal string AuthorID { get; init; }
    internal ReviewStars Stars { get; set; } 
}