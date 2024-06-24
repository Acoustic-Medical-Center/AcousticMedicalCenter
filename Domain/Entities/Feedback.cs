using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Feedback : Entity
    {
        public string FeedbackSubject { get; set; }
        public string FeedbackMessage { get; set; }
    }
}
