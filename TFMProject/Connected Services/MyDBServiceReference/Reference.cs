﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TFMProject.MyDBServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/MyDBService")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Group", Namespace="http://schemas.datacontract.org/2004/07/MyDBService.Entity")]
    [System.SerializableAttribute()]
    public partial class Group : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreatedAtField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DeletedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RoleListField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserListField;
        
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
        public System.DateTime CreatedAt {
            get {
                return this.CreatedAtField;
            }
            set {
                if ((this.CreatedAtField.Equals(value) != true)) {
                    this.CreatedAtField = value;
                    this.RaisePropertyChanged("CreatedAt");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Deleted {
            get {
                return this.DeletedField;
            }
            set {
                if ((object.ReferenceEquals(this.DeletedField, value) != true)) {
                    this.DeletedField = value;
                    this.RaisePropertyChanged("Deleted");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RoleList {
            get {
                return this.RoleListField;
            }
            set {
                if ((object.ReferenceEquals(this.RoleListField, value) != true)) {
                    this.RoleListField = value;
                    this.RaisePropertyChanged("RoleList");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserList {
            get {
                return this.UserListField;
            }
            set {
                if ((object.ReferenceEquals(this.UserListField, value) != true)) {
                    this.UserListField = value;
                    this.RaisePropertyChanged("UserList");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyDBServiceReference.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        TFMProject.MyDBServiceReference.CompositeType GetDataUsingDataContract(TFMProject.MyDBServiceReference.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<TFMProject.MyDBServiceReference.CompositeType> GetDataUsingDataContractAsync(TFMProject.MyDBServiceReference.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetGroupById", ReplyAction="http://tempuri.org/IService1/GetGroupByIdResponse")]
        TFMProject.MyDBServiceReference.Group GetGroupById(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetGroupById", ReplyAction="http://tempuri.org/IService1/GetGroupByIdResponse")]
        System.Threading.Tasks.Task<TFMProject.MyDBServiceReference.Group> GetGroupByIdAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllGroup", ReplyAction="http://tempuri.org/IService1/GetAllGroupResponse")]
        TFMProject.MyDBServiceReference.Group[] GetAllGroup();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllGroup", ReplyAction="http://tempuri.org/IService1/GetAllGroupResponse")]
        System.Threading.Tasks.Task<TFMProject.MyDBServiceReference.Group[]> GetAllGroupAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateGroup", ReplyAction="http://tempuri.org/IService1/CreateGroupResponse")]
        int CreateGroup(string name, string description);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateGroup", ReplyAction="http://tempuri.org/IService1/CreateGroupResponse")]
        System.Threading.Tasks.Task<int> CreateGroupAsync(string name, string description);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : TFMProject.MyDBServiceReference.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<TFMProject.MyDBServiceReference.IService1>, TFMProject.MyDBServiceReference.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public TFMProject.MyDBServiceReference.CompositeType GetDataUsingDataContract(TFMProject.MyDBServiceReference.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<TFMProject.MyDBServiceReference.CompositeType> GetDataUsingDataContractAsync(TFMProject.MyDBServiceReference.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public TFMProject.MyDBServiceReference.Group GetGroupById(string id) {
            return base.Channel.GetGroupById(id);
        }
        
        public System.Threading.Tasks.Task<TFMProject.MyDBServiceReference.Group> GetGroupByIdAsync(string id) {
            return base.Channel.GetGroupByIdAsync(id);
        }
        
        public TFMProject.MyDBServiceReference.Group[] GetAllGroup() {
            return base.Channel.GetAllGroup();
        }
        
        public System.Threading.Tasks.Task<TFMProject.MyDBServiceReference.Group[]> GetAllGroupAsync() {
            return base.Channel.GetAllGroupAsync();
        }
        
        public int CreateGroup(string name, string description) {
            return base.Channel.CreateGroup(name, description);
        }
        
        public System.Threading.Tasks.Task<int> CreateGroupAsync(string name, string description) {
            return base.Channel.CreateGroupAsync(name, description);
        }
    }
}