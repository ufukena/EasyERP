﻿using EasyERP.Enum.Database;

namespace EasyERP.Contract.Infrastructure
{
    public interface IFilterRepository<T, T2> 
    {        
        IEnumerable<T> GetAll(ColumnEnum columnenum, string datefilter, T2 trnTypeEnum);       
    }


    public interface IFilterRepository<T>
    {
        IEnumerable<T> GetAll(ColumnEnum columnenum, string datefilter);        
    }


}