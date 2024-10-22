using static CelesteMountain.Models.StoryPost;

namespace CelesteMountain.Models
{
    public class StoryViewModel
    {
        public StoryPost.StoryPost NewStory { get; set; } = new StoryPost.StoryPost();
        public List<StoryPost.StoryPost> Stories { get; set; } = new List<StoryPost.StoryPost>();
    }
}
