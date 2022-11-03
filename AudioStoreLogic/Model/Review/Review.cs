namespace AudioStoreLogic.Model.Review;

public struct Review
{
   internal Review(string content, Guid authorId, ReviewStars stars) 
        => (Content, AuthorID, Stars) = (content, authorId, stars);
   
    public string Content { get; internal set; }
    public Guid AuthorID { get; internal init; }
    public ReviewStars Stars { get; internal set; } 
}