using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User
    {
        //User details
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }

        //Science details
        public string Institution { get; set; }
        public string FieldOfStudy { get; set; }
        public string Bio { get; set; }
        public string ORCID { get; set; }

        public ICollection<Post> Posts { get; set; }
    }

}
