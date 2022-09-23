namespace COP.WebAPI.Core.Configurations
{
    using COP.WebAPI.Core.Interfaces;
    using Microsoft.Extensions.Configuration;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MediaLibraryConfigurationManager : IMediaLibraryConfigurationManager
    {
        private readonly IConfiguration _configuration;

        public MediaLibraryConfigurationManager(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        public string AlticeAssetsFolder
        {
            get
            {
                return this._configuration["MediaLibraryDirectoryPaths:AlticeAssetsFolder"];
            }
        }

        public string CharterMediaContentFolder
        {
            get
            {
                return this._configuration["MediaLibraryDirectoryPaths:CharterMediaContentFolder"];
            }
        }

        public IConfigurationSection GetConfigurationSection(string key)
        {
            return this._configuration.GetSection(key);
        }
    }
}
