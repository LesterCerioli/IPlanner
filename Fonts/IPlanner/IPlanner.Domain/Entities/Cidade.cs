using System;
using System.Collections.Generic;
using System.Text;

namespace IPlanner.Domain.Entities
{
    public class Cidade : Entity
    {

        public int Id { get; set; }
        public string NomeCidade { get; set; }


        public override void Validate()
        {
            if (string.IsNullOrEmpty(NomeCidade))
                AddCritical("O Nome da Cidade deve ser informado!");
        }
    }
}
