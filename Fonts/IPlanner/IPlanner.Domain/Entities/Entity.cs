using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IPlanner.Domain.Entities
{
    public abstract class Entity
    {
        private List<string> _messageValidation { get; set; }
        private List<string> messageValidation
        {
            get { return _messageValidation ?? (_messageValidation = new List<string>()); }
        }

        protected void CleanMessageValidation()
        {
            messageValidation.Clear();
        }

        protected void AddCritical(string message)
        {
            messageValidation.Add(message);
        }

        public string GetValidationMessage()
        {
            return string.Join(". ", messageValidation);
        }
        public abstract void Validate();
        public bool ItValid
        {
            get { return !messageValidation.Any(); }
        }
    }
}
