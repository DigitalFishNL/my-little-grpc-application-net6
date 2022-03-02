using DigitalFish.My.Little.GRPC.Application.Common.Models;

namespace DigitalFish.My.Little.GRPC.Application.Common.Interfaces
{
    public interface IServer
    {
        IEnumerable<Guid> List();

        void Create(Person person);

        Person Read(Guid id);

        void Update(Guid id, Person person);

        void Delete(Guid id);
    }
}
