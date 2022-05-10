using ImpactaLawTech.ToDo.Domain.Enumerators;
using ImpactaLawTech.ToDo.Domain.Validation;
using System.Collections.Generic;

namespace ImpactaLawTech.ToDo.Domain.Entities
{
    public sealed class User : EntityBase
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public UserTypeEnumerator UserType { get; private set; }
        public IList<Tasks> Tasks { get; set; }

        public User()
        {

        }
        public User(int id, string name, string email, string password, UserTypeEnumerator userType)
        {
            DomainExceptionValidation.When(id < 0, "Invalid Id value");
            Id = id;
            UserType = userType;
            Tasks = new List<Tasks>();
            ValidateDomain(name, password, email);
        }
        public void Update(string name, string email, string password, UserTypeEnumerator userType)
        {
            ValidateDomain(name, password, email);
            UserType = userType;
        }
        

        private void ValidateDomain(string name, string password, string email)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid Name. Name is required");
            DomainExceptionValidation.When(name.Length < 3, "Invalid name, too short minimum 3 characters");
            DomainExceptionValidation.When(string.IsNullOrEmpty(password), "Invalid Password. Password is required");
            DomainExceptionValidation.When(string.IsNullOrEmpty(email), "Invalid Email. Email is required");

            Name = name;
            Email = email;
            Password = password;
         
        }
    }
}
