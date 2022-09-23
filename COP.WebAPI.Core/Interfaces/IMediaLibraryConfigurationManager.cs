namespace COP.WebAPI.Core.Interfaces
{
    using Microsoft.Extensions.Configuration;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IMediaLibraryConfigurationManager
    {
        string AlticeAssetsFolder { get; }

        string CharterMediaContentFolder { get; }

        IConfigurationSection GetConfigurationSection(string Key);
    }
}
