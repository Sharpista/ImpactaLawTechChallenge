using System.ComponentModel.DataAnnotations;

namespace ImpactaLawTechToDo.Application.DTO
{
    public  class TasksDTO
    {
        public int Id { get; set; }
        public string Description { get;  set; }
        public bool IsDone { get;  set; }
        public UserDTO User { get; set; }
        public int UserId { get; set; }
    }
}
