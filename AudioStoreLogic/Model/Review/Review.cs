namespace AudioStoreLogic.Model.Review;

internal struct Review
{
   public Review(string content, string authorId, ReviewStars stars) 
        => (Content, AuthorID, Stars) = (content, authorId, stars);

    internal string Content { get; set; }
    internal string AuthorID { get; init; }
    internal ReviewStars Stars { get; set; } 
}