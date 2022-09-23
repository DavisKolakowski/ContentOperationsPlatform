namespace COP.WebAPI.Core.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IMediaFileService<T> where T : class
    {
        IQueryable<T> FindFiles(string key);
    }
}
