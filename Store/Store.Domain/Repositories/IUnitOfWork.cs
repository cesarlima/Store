﻿namespace Store.Domain.Repositories
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
