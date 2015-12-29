﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client_Config.InventoryServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Item", Namespace="http://schemas.datacontract.org/2004/07/ServerConfig.Models")]
    [System.SerializableAttribute()]
    public partial class Item : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ItemIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ItemNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QuantityField;
        
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
        public int ItemId {
            get {
                return this.ItemIdField;
            }
            set {
                if ((this.ItemIdField.Equals(value) != true)) {
                    this.ItemIdField = value;
                    this.RaisePropertyChanged("ItemId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ItemName {
            get {
                return this.ItemNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ItemNameField, value) != true)) {
                    this.ItemNameField = value;
                    this.RaisePropertyChanged("ItemName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Quantity {
            get {
                return this.QuantityField;
            }
            set {
                if ((this.QuantityField.Equals(value) != true)) {
                    this.QuantityField = value;
                    this.RaisePropertyChanged("Quantity");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="InventoryServiceReference.IInventory")]
    public interface IInventory {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventory/DbAddItem", ReplyAction="http://tempuri.org/IInventory/DbAddItemResponse")]
        int DbAddItem(string name, int quantity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventory/DbAddItem", ReplyAction="http://tempuri.org/IInventory/DbAddItemResponse")]
        System.Threading.Tasks.Task<int> DbAddItemAsync(string name, int quantity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventory/DbAddQuantity", ReplyAction="http://tempuri.org/IInventory/DbAddQuantityResponse")]
        int DbAddQuantity(int itemId, int quantity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventory/DbAddQuantity", ReplyAction="http://tempuri.org/IInventory/DbAddQuantityResponse")]
        System.Threading.Tasks.Task<int> DbAddQuantityAsync(int itemId, int quantity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventory/DbSubtractQuantity", ReplyAction="http://tempuri.org/IInventory/DbSubtractQuantityResponse")]
        int DbSubtractQuantity(int itemId, int quantity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventory/DbSubtractQuantity", ReplyAction="http://tempuri.org/IInventory/DbSubtractQuantityResponse")]
        System.Threading.Tasks.Task<int> DbSubtractQuantityAsync(int itemId, int quantity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventory/DbGetItems", ReplyAction="http://tempuri.org/IInventory/DbGetItemsResponse")]
        Client_Config.InventoryServiceReference.Item[] DbGetItems();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventory/DbGetItems", ReplyAction="http://tempuri.org/IInventory/DbGetItemsResponse")]
        System.Threading.Tasks.Task<Client_Config.InventoryServiceReference.Item[]> DbGetItemsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventory/DbRemoveItem", ReplyAction="http://tempuri.org/IInventory/DbRemoveItemResponse")]
        void DbRemoveItem(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventory/DbRemoveItem", ReplyAction="http://tempuri.org/IInventory/DbRemoveItemResponse")]
        System.Threading.Tasks.Task DbRemoveItemAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventory/DbGetItem", ReplyAction="http://tempuri.org/IInventory/DbGetItemResponse")]
        Client_Config.InventoryServiceReference.Item DbGetItem(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventory/DbGetItem", ReplyAction="http://tempuri.org/IInventory/DbGetItemResponse")]
        System.Threading.Tasks.Task<Client_Config.InventoryServiceReference.Item> DbGetItemAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventory/DbSaveItem", ReplyAction="http://tempuri.org/IInventory/DbSaveItemResponse")]
        void DbSaveItem(Client_Config.InventoryServiceReference.Item newItem);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventory/DbSaveItem", ReplyAction="http://tempuri.org/IInventory/DbSaveItemResponse")]
        System.Threading.Tasks.Task DbSaveItemAsync(Client_Config.InventoryServiceReference.Item newItem);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventory/DbClearItems", ReplyAction="http://tempuri.org/IInventory/DbClearItemsResponse")]
        void DbClearItems();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventory/DbClearItems", ReplyAction="http://tempuri.org/IInventory/DbClearItemsResponse")]
        System.Threading.Tasks.Task DbClearItemsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IInventoryChannel : Client_Config.InventoryServiceReference.IInventory, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class InventoryClient : System.ServiceModel.ClientBase<Client_Config.InventoryServiceReference.IInventory>, Client_Config.InventoryServiceReference.IInventory {
        
        public InventoryClient() {
        }
        
        public InventoryClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public InventoryClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InventoryClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InventoryClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int DbAddItem(string name, int quantity) {
            return base.Channel.DbAddItem(name, quantity);
        }
        
        public System.Threading.Tasks.Task<int> DbAddItemAsync(string name, int quantity) {
            return base.Channel.DbAddItemAsync(name, quantity);
        }
        
        public int DbAddQuantity(int itemId, int quantity) {
            return base.Channel.DbAddQuantity(itemId, quantity);
        }
        
        public System.Threading.Tasks.Task<int> DbAddQuantityAsync(int itemId, int quantity) {
            return base.Channel.DbAddQuantityAsync(itemId, quantity);
        }
        
        public int DbSubtractQuantity(int itemId, int quantity) {
            return base.Channel.DbSubtractQuantity(itemId, quantity);
        }
        
        public System.Threading.Tasks.Task<int> DbSubtractQuantityAsync(int itemId, int quantity) {
            return base.Channel.DbSubtractQuantityAsync(itemId, quantity);
        }
        
        public Client_Config.InventoryServiceReference.Item[] DbGetItems() {
            return base.Channel.DbGetItems();
        }
        
        public System.Threading.Tasks.Task<Client_Config.InventoryServiceReference.Item[]> DbGetItemsAsync() {
            return base.Channel.DbGetItemsAsync();
        }
        
        public void DbRemoveItem(int id) {
            base.Channel.DbRemoveItem(id);
        }
        
        public System.Threading.Tasks.Task DbRemoveItemAsync(int id) {
            return base.Channel.DbRemoveItemAsync(id);
        }
        
        public Client_Config.InventoryServiceReference.Item DbGetItem(int id) {
            return base.Channel.DbGetItem(id);
        }
        
        public System.Threading.Tasks.Task<Client_Config.InventoryServiceReference.Item> DbGetItemAsync(int id) {
            return base.Channel.DbGetItemAsync(id);
        }
        
        public void DbSaveItem(Client_Config.InventoryServiceReference.Item newItem) {
            base.Channel.DbSaveItem(newItem);
        }
        
        public System.Threading.Tasks.Task DbSaveItemAsync(Client_Config.InventoryServiceReference.Item newItem) {
            return base.Channel.DbSaveItemAsync(newItem);
        }
        
        public void DbClearItems() {
            base.Channel.DbClearItems();
        }
        
        public System.Threading.Tasks.Task DbClearItemsAsync() {
            return base.Channel.DbClearItemsAsync();
        }
    }
}