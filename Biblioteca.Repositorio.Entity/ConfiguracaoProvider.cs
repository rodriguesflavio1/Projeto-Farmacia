using System.Data.Entity;

namespace Biblioteca.Repositorio.Entity
{
    class ConfiguracaoProvider:DbConfiguration
    {
        public ConfiguracaoProvider()
        {
            SetProviderServices(
                System.Data.Entity.SqlServer.SqlProviderServices.ProviderInvariantName,
                System.Data.Entity.SqlServer.SqlProviderServices.Instance
                );
        }
    }
}
