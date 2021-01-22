using System.ServiceModel;
using ChatApp.Contracts.Domain;
using System.Collections.ObjectModel;

namespace ChatApp.Contracts.Contracts
{
    public interface IMessageServiceCallback
    {
        [OperationContract(IsOneWay = true)]
        void ForwardToClient(Message message);

        [OperationContract(IsOneWay = true)]
        void UserConnected(ObservableCollection<User> users);

    }
}
