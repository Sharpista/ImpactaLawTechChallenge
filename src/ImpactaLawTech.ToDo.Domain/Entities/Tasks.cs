using ImpactaLawTech.ToDo.Domain.Validation;

namespace ImpactaLawTech.ToDo.Domain.Entities
{
    public class Tasks : EntityBase
    {
        public string  Description { get; private set; }
        public bool IsDone { get; private set; }

        public Tasks()
        {

        }
        public Tasks(int id, string description, bool isDone)
        {
            DomainExceptionValidation.When(id < 0, "Invalid Id value");
            ValidateDomain(description);
            Id = id;
            IsDone = isDone;
        
        }
        public Tasks(string description, bool isDone)
        {
            ValidateDomain(description);
            IsDone = isDone;
          
        }

        public void Update(string description, bool isDone)
        {
            ValidateDomain(description);
            IsDone = isDone;
        }
        private void ValidateDomain(string description)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(description), "Invalid Description. Description is required");
            Description = description;
        }
    }

}
