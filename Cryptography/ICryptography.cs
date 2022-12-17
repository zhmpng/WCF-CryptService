using System.ServiceModel;

namespace Cryptography
{
    [ServiceContract(SessionMode = SessionMode.Required, CallbackContract = typeof(IClientCallback))]
    public interface ICryptography
    {
        [OperationContract]
        string EncryptToMD5(string input);

        [OperationContract]
        string EncryptToSHA1(string input);

        [OperationContract]
        string EncryptToSHA256(string input);

        [OperationContract]
        string EncryptToSHA512(string input);

        [OperationContract]
        void WriteResult(string result);

        [OperationContract(IsOneWay = true)]
        void Connection();

        [OperationContract(IsOneWay = true)]
        void Disconnection();
    }
}
