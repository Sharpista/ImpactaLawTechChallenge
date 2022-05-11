using ImpactaLawTech.ToDo.Domain.Entities;
using ImpactaLawTech.ToDo.Domain.Interfaces;
using ImpactaLawTechToDo.Infra.Data.Context;

namespace ImpactaLawTechToDo.Infra.Data.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDBContext applicationDBContext) : base(applicationDBContext)
        {
        }

       
    }
}
