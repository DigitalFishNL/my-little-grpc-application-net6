namespace DigitalFish.My.Little.GRPC.Application.Common.Models
{
    public class Person
    {
        public Guid ID { get; set; } = Guid.Empty;

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public DateTime? DateOfBirth { get; set; }

    }
}
