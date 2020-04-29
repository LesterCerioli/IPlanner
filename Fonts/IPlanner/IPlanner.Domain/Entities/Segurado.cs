using System;
using System.Collections.Generic;
using System.Text;

namespace IPlanner.Domain.Entities
{
    public class Segurado : Entity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NomeMeio { get; set; }
        public string SobreNome { get; set; }
        public string Email { get; set; }
        public string Idade { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usurio Usuario { get; set; }



        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
                AddCritical("O Nome deve ser informado!");

            if (string.IsNullOrEmpty(NomeMeio))
                AddCritical("O Nome do Meio deve ser informado!");

            if (string.IsNullOrEmpty(SobreNome))
                AddCritical("O SobreNome deve ser informado!");

            if (string.IsNullOrEmpty(Email))
                AddCritical("O Email deve ser informado!");


        }
    }
}
