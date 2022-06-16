using SafCos.Core.AppService.ServiceInterface;
using SafCos.Core.DomainService;
using SafCos.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafCos.Core.AppService.Service
{
    public class SecondaryCategoryService : ISecondaryCategoryService
    {
        private readonly ISecondaryCategoryRepo _secondaryCategoryRepo;

        public SecondaryCategoryService(ISecondaryCategoryRepo secondaryCategoryRepository)
        {
            _secondaryCategoryRepo = secondaryCategoryRepository ?? throw new NullReferenceException("Repository cannot be null");
        }
        public IEnumerable<Product> GetProductsBySecondaryCategoryId(int id)
        {
            return _secondaryCategoryRepo.GetProductsBySecondaryCategoryId(id);
        }

        public SecondaryCategory CreateSecClass(SecondaryCategory secondaryClassifier)
        {
            throw new NotImplementedException();
        }

        public SecondaryCategory DeleteSecClass(int id)
        {
            throw new NotImplementedException();
        }

        public List<SecondaryCategory> ReadAllSecClass()
        {
            throw new NotImplementedException();
        }

        public SecondaryCategory UpdateSecClass(int id)
        {
            throw new NotImplementedException();
        }
    }
}
