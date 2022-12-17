using System.ServiceModel;

namespace Cryptography
{
    public interface IClientCallback
    {
        [OperationContract(IsOneWay = true)]
        void Count(int count);
    }
}
