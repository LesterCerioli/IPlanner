using System;
using System.Collections.Generic;
using System.Text;

namespace IPlanner.Domain.Entities
{
    public class Usuario : Entity
    {
        public int Id {get; set;}
        public string Email { get; set; }
        public string Senha { get; set; }

        public virtual ICollection<Segurado> Segurados { get; set; }


        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
                AddCritical("O Email deve ser inoformado!");
        }
    }
}
