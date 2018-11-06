using JiraConnecter.Programmability.Interfaces;

namespace JiraConnecter.Factories.Interfaces
{
    internal interface IConnectorFactory
    {
        IFunctionType Create(string boardType);
    }
}
