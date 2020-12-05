using CodeOwls.PowerShell.Provider.PathNodeProcessors;
using System.Management.Automation.Provider;

namespace CodeOwls.PowerShell.Paths
{
    public interface IGetItemContent
    {
        IContentReader GetContentReader(IProviderContext providerContext);
        object GetContentReaderDynamicParameters(IProviderContext providerContext);
    }
}
