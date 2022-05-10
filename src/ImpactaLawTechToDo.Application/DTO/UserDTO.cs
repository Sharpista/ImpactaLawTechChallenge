using System.Collections;

namespace ImpactaLawTechToDo.Application.DTO
{
    public  class UserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int UserType { get; set; }
        public IList Tasks { get; set; }
    }
}
