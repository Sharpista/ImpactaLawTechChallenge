using ImpactaLawTech.ToDo.Domain.Validation;

namespace ImpactaLawTech.ToDo.Domain.Entities
{
    public class Tasks : EntityBase
    {
        public string  Description { get; private set; }
        public bool IsDone { get; private set; }
        public User User { get; private set; }
        public int UserId { get; private set; }

        public Tasks()
        {

        }
        public Tasks(int id, string description, bool isDone, User user, int userId)
        {
            DomainExceptionValidation.When(id < 0, "Invalid Id value");
            ValidateDomain(description);
            IsDone = isDone;
            User = user;
            UserId = userId;
        }
        public Tasks(string description, bool isDone, User user, int userId)
        {
            ValidateDomain(description);
            IsDone = isDone;
            User = user;
            UserId = userId;
        }

        public void Update(string description, bool isDone, int userId)
        {
            ValidateDomain(description);
            IsDone = isDone;
            UserId = userId;
        }
        private void ValidateDomain(string description)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(description), "Invalid Description. Description is required");
            Description = description;
        }
    }

}
