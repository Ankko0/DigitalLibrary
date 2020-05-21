using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalLibrary.DataAccess
{
    class Helper
    {
        public string ConnectionString { get; }
        public Helper()
        {
            var entityBuilder = new EntityConnectionStringBuilder();
            String datasource = @"data source=.\sqlexpress;initial catalog=Library;integrated security=True;";
            entityBuilder.Provider = "System.Data.SqlClient";
            entityBuilder.ProviderConnectionString = datasource + ";MultipleActiveResultSets=True;App=EntityFramework;";
            entityBuilder.Metadata = @"res://*/Models.LibraryDataModel.csdl|res://*/Models.LibraryDataModel.ssdl|res://*/Models.LibraryDataModel.msl";

            ConnectionString = entityBuilder.ToString();
        }
    }
}
