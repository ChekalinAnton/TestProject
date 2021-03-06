﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApplication1.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Contact", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary2")]
    [System.SerializableAttribute()]
    public partial class Contact : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FIOField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FIO {
            get {
                return this.FIOField;
            }
            set {
                if ((object.ReferenceEquals(this.FIOField, value) != true)) {
                    this.FIOField = value;
                    this.RaisePropertyChanged("FIO");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IAddressBook")]
    public interface IAddressBook {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAddressBook/CreateContract", ReplyAction="http://tempuri.org/IAddressBook/CreateContractResponse")]
        WpfApplication1.ServiceReference1.Contact CreateContract(string FIO, string phone);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAddressBook/CreateContract", ReplyAction="http://tempuri.org/IAddressBook/CreateContractResponse")]
        System.Threading.Tasks.Task<WpfApplication1.ServiceReference1.Contact> CreateContractAsync(string FIO, string phone);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAddressBook/AddContact", ReplyAction="http://tempuri.org/IAddressBook/AddContactResponse")]
        bool AddContact(WpfApplication1.ServiceReference1.Contact cont);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAddressBook/AddContact", ReplyAction="http://tempuri.org/IAddressBook/AddContactResponse")]
        System.Threading.Tasks.Task<bool> AddContactAsync(WpfApplication1.ServiceReference1.Contact cont);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAddressBook/GetContacts", ReplyAction="http://tempuri.org/IAddressBook/GetContactsResponse")]
        WpfApplication1.ServiceReference1.Contact[] GetContacts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAddressBook/GetContacts", ReplyAction="http://tempuri.org/IAddressBook/GetContactsResponse")]
        System.Threading.Tasks.Task<WpfApplication1.ServiceReference1.Contact[]> GetContactsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAddressBook/GetContactsByPhone", ReplyAction="http://tempuri.org/IAddressBook/GetContactsByPhoneResponse")]
        WpfApplication1.ServiceReference1.Contact[] GetContactsByPhone(string phone);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAddressBook/GetContactsByPhone", ReplyAction="http://tempuri.org/IAddressBook/GetContactsByPhoneResponse")]
        System.Threading.Tasks.Task<WpfApplication1.ServiceReference1.Contact[]> GetContactsByPhoneAsync(string phone);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAddressBook/GetContactsByName", ReplyAction="http://tempuri.org/IAddressBook/GetContactsByNameResponse")]
        WpfApplication1.ServiceReference1.Contact[] GetContactsByName(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAddressBook/GetContactsByName", ReplyAction="http://tempuri.org/IAddressBook/GetContactsByNameResponse")]
        System.Threading.Tasks.Task<WpfApplication1.ServiceReference1.Contact[]> GetContactsByNameAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAddressBook/ChangPhoneByContact", ReplyAction="http://tempuri.org/IAddressBook/ChangPhoneByContactResponse")]
        bool ChangPhoneByContact(WpfApplication1.ServiceReference1.Contact contact, string newPhone);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAddressBook/ChangPhoneByContact", ReplyAction="http://tempuri.org/IAddressBook/ChangPhoneByContactResponse")]
        System.Threading.Tasks.Task<bool> ChangPhoneByContactAsync(WpfApplication1.ServiceReference1.Contact contact, string newPhone);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAddressBook/ChangePhoneByIndex", ReplyAction="http://tempuri.org/IAddressBook/ChangePhoneByIndexResponse")]
        bool ChangePhoneByIndex(int index, string newPhone);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAddressBook/ChangePhoneByIndex", ReplyAction="http://tempuri.org/IAddressBook/ChangePhoneByIndexResponse")]
        System.Threading.Tasks.Task<bool> ChangePhoneByIndexAsync(int index, string newPhone);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAddressBook/DeleteByContact", ReplyAction="http://tempuri.org/IAddressBook/DeleteByContactResponse")]
        bool DeleteByContact(WpfApplication1.ServiceReference1.Contact contact);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAddressBook/DeleteByContact", ReplyAction="http://tempuri.org/IAddressBook/DeleteByContactResponse")]
        System.Threading.Tasks.Task<bool> DeleteByContactAsync(WpfApplication1.ServiceReference1.Contact contact);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAddressBook/DeleteByIndex", ReplyAction="http://tempuri.org/IAddressBook/DeleteByIndexResponse")]
        bool DeleteByIndex(int index);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAddressBook/DeleteByIndex", ReplyAction="http://tempuri.org/IAddressBook/DeleteByIndexResponse")]
        System.Threading.Tasks.Task<bool> DeleteByIndexAsync(int index);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAddressBookChannel : WpfApplication1.ServiceReference1.IAddressBook, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AddressBookClient : System.ServiceModel.ClientBase<WpfApplication1.ServiceReference1.IAddressBook>, WpfApplication1.ServiceReference1.IAddressBook {
        
        public AddressBookClient() {
        }
        
        public AddressBookClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AddressBookClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AddressBookClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AddressBookClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WpfApplication1.ServiceReference1.Contact CreateContract(string FIO, string phone) {
            return base.Channel.CreateContract(FIO, phone);
        }
        
        public System.Threading.Tasks.Task<WpfApplication1.ServiceReference1.Contact> CreateContractAsync(string FIO, string phone) {
            return base.Channel.CreateContractAsync(FIO, phone);
        }
        
        public bool AddContact(WpfApplication1.ServiceReference1.Contact cont) {
            return base.Channel.AddContact(cont);
        }
        
        public System.Threading.Tasks.Task<bool> AddContactAsync(WpfApplication1.ServiceReference1.Contact cont) {
            return base.Channel.AddContactAsync(cont);
        }
        
        public WpfApplication1.ServiceReference1.Contact[] GetContacts() {
            return base.Channel.GetContacts();
        }
        
        public System.Threading.Tasks.Task<WpfApplication1.ServiceReference1.Contact[]> GetContactsAsync() {
            return base.Channel.GetContactsAsync();
        }
        
        public WpfApplication1.ServiceReference1.Contact[] GetContactsByPhone(string phone) {
            return base.Channel.GetContactsByPhone(phone);
        }
        
        public System.Threading.Tasks.Task<WpfApplication1.ServiceReference1.Contact[]> GetContactsByPhoneAsync(string phone) {
            return base.Channel.GetContactsByPhoneAsync(phone);
        }
        
        public WpfApplication1.ServiceReference1.Contact[] GetContactsByName(string name) {
            return base.Channel.GetContactsByName(name);
        }
        
        public System.Threading.Tasks.Task<WpfApplication1.ServiceReference1.Contact[]> GetContactsByNameAsync(string name) {
            return base.Channel.GetContactsByNameAsync(name);
        }
        
        public bool ChangPhoneByContact(WpfApplication1.ServiceReference1.Contact contact, string newPhone) {
            return base.Channel.ChangPhoneByContact(contact, newPhone);
        }
        
        public System.Threading.Tasks.Task<bool> ChangPhoneByContactAsync(WpfApplication1.ServiceReference1.Contact contact, string newPhone) {
            return base.Channel.ChangPhoneByContactAsync(contact, newPhone);
        }
        
        public bool ChangePhoneByIndex(int index, string newPhone) {
            return base.Channel.ChangePhoneByIndex(index, newPhone);
        }
        
        public System.Threading.Tasks.Task<bool> ChangePhoneByIndexAsync(int index, string newPhone) {
            return base.Channel.ChangePhoneByIndexAsync(index, newPhone);
        }
        
        public bool DeleteByContact(WpfApplication1.ServiceReference1.Contact contact) {
            return base.Channel.DeleteByContact(contact);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteByContactAsync(WpfApplication1.ServiceReference1.Contact contact) {
            return base.Channel.DeleteByContactAsync(contact);
        }
        
        public bool DeleteByIndex(int index) {
            return base.Channel.DeleteByIndex(index);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteByIndexAsync(int index) {
            return base.Channel.DeleteByIndexAsync(index);
        }
    }
}
