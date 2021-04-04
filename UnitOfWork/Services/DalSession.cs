using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Common.Configuration;
using Common.Data;
using Microsoft.Extensions.Options;

namespace UnitOfWork.Services
{
    public sealed class DalSession : IDisposable
    {
        public DalSession(IOptions<AppConfiguration> options)
        {
            _connection = new ConnectionManager(options).Create();
            _connection.Open();
            _unitOfWork = new UnitOfWork(_connection);
        }

        IDbConnection _connection = null;
        UnitOfWork _unitOfWork = null;

        public UnitOfWork UnitOfWork
        {
            get { return _unitOfWork; }
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
            _connection.Dispose();
        }
    }
}
