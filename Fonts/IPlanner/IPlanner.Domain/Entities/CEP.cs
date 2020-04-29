using System;
using System.Collections.Generic;
using System.Text;

namespace IPlanner.Domain.Entities
{
    public class CEP : Entity
    {

        public int Id { get; set; }
        public string CEPNumberCEP { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
