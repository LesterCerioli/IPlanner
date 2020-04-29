using System;
using System.Collections.Generic;
using System.Text;

namespace IPlanner.Domain.Entities
{
    public class Pais : Entity
    {
        public int Id { get; set; }
        public string PaisNome { get; set; }



        public override void Validate()
        {
            if (string.IsNullOrEmpty(PaisNome))
                AddCritical("O Nome do País deve ser informado!");
        }
    }
}
