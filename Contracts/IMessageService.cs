﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using ChatApp.Contracts.Domain;
using System.Collections.ObjectModel;

namespace ChatApp.Contracts.Contracts
{
    [ServiceContract(CallbackContract =typeof(IMessageServiceCallback),SessionMode = SessionMode.Required)]
    public interface IMessageService
    {
        [OperationContract(IsOneWay = true)]
        void Connect(User user);

        [OperationContract(IsOneWay = true)]
        void SendMessage(Message message);

        [OperationContract(IsOneWay = false)]
        ObservableCollection<User> GetConnectedUsers();
    }
}
