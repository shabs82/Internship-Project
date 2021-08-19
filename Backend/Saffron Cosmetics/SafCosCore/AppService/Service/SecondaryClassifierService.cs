using SafCos.Core.AppService.ServiceInterface;
using SafCos.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafCos.Core.AppService.Service
{
    public class SecondaryClassifierService : ISecondaryClassifierService
    {
        public SecondaryClassifier CreateSecClass(int Id, string Name, int PrimaryClassifierId)
        {
            throw new NotImplementedException();
        }

        public SecondaryClassifier DeleteSecClass(int id)
        {
            throw new NotImplementedException();
        }

        public List<SecondaryClassifier> ReadAllSecClass()
        {
            throw new NotImplementedException();
        }

        public SecondaryClassifier ReadSecClass(int id)
        {
            throw new NotImplementedException();
        }

        public SecondaryClassifier UpdateSecClass(int id)
        {
            throw new NotImplementedException();
        }
    }
}
