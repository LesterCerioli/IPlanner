using System;
using System.Collections.Generic;
using System.Text;

namespace IPlanner.Domain.Entities
{
    public class Estado : Entity
    {
        public int Id { get; set; }
        public string EstadoNome { get; set; }
        public string UF { get; set; }


        public override void Validate()
        {
            if (string.IsNullOrEmpty(UF))
                AddCritical("A UF deve ser informada!");
        }
    }
}
