namespace COP.WebAPI.Core.Services
{
    using COP.WebAPI.Core.Configurations;
    using COP.WebAPI.Core.Interfaces;

    using Microsoft.Extensions.Configuration;

    using System.Collections.Generic;

    public class MediaFileService<T> : IMediaFileService<T> where T : class
    {
        private readonly IMediaLibraryConfigurationManager _configuration;

        public MediaFileService(IMediaLibraryConfigurationManager configuration)
        {
            this._configuration = configuration;
        }          

        public IQueryable<T> FindFiles(string key)
        {
            var directoryKey = this._configuration.GetConfigurationSection(key);
        }
    }
}