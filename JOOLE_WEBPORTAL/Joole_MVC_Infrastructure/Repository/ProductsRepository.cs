using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Joole_MVC_Core;
using Joole_MVC_Core.POCOClasses;

namespace Joole_MVC_Infrastructure.Repository
{
    public class ProductsRepository : IProductRepository
    {
        JooleDataBaseEntities _entities;

        public List<ProductsUI> GetAllProucts()
        {
            _entities = new JooleDataBaseEntities();
            var _ProductTable = _entities.tblProducts.ToList();
            var _ProductsList = new List<ProductsUI>();

            foreach (var product in _ProductTable)
            {
                _ProductsList.Add(new ProductsUI
                {

                    ProductID = product.ProductID,
                    ProductName = product.ProductName,
                    Series = product.Series,
                    Model = product.Model,
                    ModelYear = product.ModelYear,
                    SubCategoryID = product.SubCategoryID
                });
            }

            return _ProductsList;
        }
        public List<ProductsUI> GetFans()
        {
            _entities = new JooleDataBaseEntities();
            var _ProductTable = _entities.tblProducts.Where(a => a.SubCategoryID == 1).ToList();
            var _ProductsList = new List<ProductsUI>();

            foreach (var product in _ProductTable)
            {
                _ProductsList.Add(new ProductsUI
                {

                    ProductID = product.ProductID,
                    ProductName = product.ProductName,
                    Series = product.Series,
                    Model = product.Model,
                    ModelYear = product.ModelYear,
                    SubCategoryID = product.SubCategoryID
                });
            }
            return _ProductsList;
        }
        public List<ProductsUI> GetVacuums()
        {
            _entities = new JooleDataBaseEntities();
            var _ProductTable = _entities.tblProducts.Where(a => a.SubCategoryID == 2).ToList();
            var _ProductsList = new List<ProductsUI>();

            foreach (var product in _ProductTable)
            {
                _ProductsList.Add(new ProductsUI
                {

                    ProductID = product.ProductID,
                    ProductName = product.ProductName,
                    Series = product.Series,
                    Model = product.Model,
                    ModelYear = product.ModelYear,
                    SubCategoryID = product.SubCategoryID
                });
            }
            return _ProductsList;
        }
        public List<ProductsUI> GetToasters()
        {
            _entities = new JooleDataBaseEntities();
            var _ProductTable = _entities.tblProducts.Where(a => a.SubCategoryID == 3).ToList();
            var _ProductsList = new List<ProductsUI>();

            foreach (var product in _ProductTable)
            {
                _ProductsList.Add(new ProductsUI
                {

                    ProductID = product.ProductID,
                    ProductName = product.ProductName,
                    Series = product.Series,
                    Model = product.Model,
                    ModelYear = product.ModelYear,
                    SubCategoryID = product.SubCategoryID
                });
            }
            return _ProductsList;
        }
    }
    }
