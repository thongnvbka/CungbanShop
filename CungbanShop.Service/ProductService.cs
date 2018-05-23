using CungbanShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CungbanShop.Data.Infrastructure;
using CungbanShop.Data.Repositories;

namespace CungbanShop.Service
{
    public interface IProductService
    {
        void Add(Product post);

        void Update(Product post);

        void Delete(int id);

        IEnumerable<Product> GetAll();

        IEnumerable<Product> GetAllPaging(int page, int pageSize, out int totalRow);

        IEnumerable<Product> GetAllByCategoryPaging(int categoryId, int page, int pageSize, out int totalRow);

        Post GetById(int id);

        IEnumerable<Product> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow);

        void SaveChanges();
    }
    public class ProductService : IProductService
    {
        IProductRepository _ProductRepository;
        IUnitOfWork _UnitOfWork;

        public ProductService(IProductRepository productRepository,IUnitOfWork unitOfWork)
        {
            this._ProductRepository = productRepository;
            this._UnitOfWork = unitOfWork;
        }
        void Add(Product product)
        {
            _ProductRepository.Add(product);
        }

        public void Delete(int id)
        {
            _ProductRepository.Delete(id);
        }

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAllByCategoryPaging(int categoryId, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }

        public Post GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(Product post)
        {
            throw new NotImplementedException();
        }

        void IProductService.Add(Product post)
        {
            throw new NotImplementedException();
        }
    }
   
}
