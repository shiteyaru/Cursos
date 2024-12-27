using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio.Entities {
    internal class User {

        public int Id { get; set; }

        public User (int id) {

            Id = id;

        }

        public override int GetHashCode() {

            return Id.GetHashCode();

        }

        public override bool Equals(object? obj) {

            if (!(obj is User)) {
                return false;
            }
            else {
                User other = obj as User;
                return Id.Equals(other.Id);
            }
        }

    }
}
