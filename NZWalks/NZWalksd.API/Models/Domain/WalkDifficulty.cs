namespace NZWalksd.API.Models.Domain
{
    public class WalkDifficulty
    {
        public Guid Id { get; set; }
        public string Code { get; set; }

        //Navigattion Property
        public IEnumerable<Walk> Walks { get; set; }
    }
}
