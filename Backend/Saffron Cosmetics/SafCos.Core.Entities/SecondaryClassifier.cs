using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafCos.Core.Entities
{
    public class SecondaryClassifier
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string PrimaryClassifier { get; set; }
        public string PrimaryClassifierId { get; set; }
       
        
    }
}
