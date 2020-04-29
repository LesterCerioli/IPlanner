using System;
using System.Collections.Generic;
using System.Text;

namespace IPlanner.Domain.Entities
{
    public class CategoriaPlano : Entity
    {

        public int Id { get; set; }
        public string CategoriaNome { get; set; }
        public int SeguradoId { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(CategoriaNome))
                AddCritical("O Nome da Categoria deve ser informado!");
        }
    }
}
