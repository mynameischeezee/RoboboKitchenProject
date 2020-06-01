using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RoboboKitchenProject.DAL.Abstract;
using RoboboKitchenProject.Entity;
using RoboboKitchenProject.Model;

namespace RoboboKitchenProject.DAL.Impl
{
    public class UnitOfWorkImpl : IUnitOfWork
    {
        private readonly RoboboDataContext _dataContext;
        private CookRepository _CookRepository;
        private DishRepository _DishRepository;
        private CookSpecializationRepository _CookSpecializationRepository;
        private SpecializationRepository _SpecializationRepository;
        private OrderRepository _OrderRepository;
        public UnitOfWorkImpl()
        {
            _dataContext = new RoboboDataContext();
        }
        public CookRepository Cooks
        {
            get
            {
                if (_CookRepository == null)
                    _CookRepository = new CookRepository(_dataContext);
                return _CookRepository;
            }
        }
        public DishRepository Dishes
        {
            get
            {
                if (_DishRepository == null)
                    _DishRepository = new DishRepository(_dataContext);
                return _DishRepository;
            }
        }
        public CookSpecializationRepository CookSpecialization
        {
            get
            {
                if (_CookSpecializationRepository == null)
                    _CookSpecializationRepository = new CookSpecializationRepository(_dataContext);
                return _CookSpecializationRepository;
            }
        }
        public SpecializationRepository Specialization
        {
            get
            {
                if (_SpecializationRepository == null)
                    _SpecializationRepository = new SpecializationRepository(_dataContext);
                return _SpecializationRepository;
            }
        }
        public OrderRepository Orders
        {
            get
            {
                if (_OrderRepository == null)
                    _OrderRepository = new OrderRepository(_dataContext);
                return _OrderRepository;
            }
        }

        public void Save()
        {
            _dataContext.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _dataContext.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
