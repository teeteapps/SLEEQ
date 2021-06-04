using DBL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private string connString;
        private bool _disposed;

        private IMaintenanceRepository maintenanceRepository;
        private ISecurityRepository securityRepository;

        //private IPostsRepository postsRepository;

        public UnitOfWork(string connectionString)
        {
            connString = connectionString;
        }
        public IMaintenanceRepository MaintenanceRepository
        {
            get { return maintenanceRepository ?? (maintenanceRepository = new MaintenanceRepository(connString)); }
        }

        public ISecurityRepository SecurityRepository
        {
            get { return securityRepository ?? (securityRepository = new SecurityRepository(connString)); }
        }


        //public IPostsRepository PostsRepository
        //{
        //    get { return postsRepository ?? (postsRepository = new PostsRepository(connString)); }
        //}
        public void Reset()
        {
            maintenanceRepository = null;
            securityRepository = null;

            //postsRepository = null;
        }

        public void Dispose()
        {
            dispose(true);
            GC.SuppressFinalize(this);
        }

        private void dispose(bool disposing)
        {
            if (!_disposed)
            {
                _disposed = true;
            }
        }

        ~UnitOfWork()
        {
            dispose(false);
        }
    }
}
