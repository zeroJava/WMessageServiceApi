﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WMessageServiceApi.Authentication {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AccessRequest", Namespace="http://schemas.datacontract.org/2004/07/AuthorisationServer.Access")]
    [System.SerializableAttribute()]
    public partial class AccessRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AuthenticationCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string KeyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] ScopeField;
        
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
        public string AuthenticationCode {
            get {
                return this.AuthenticationCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthenticationCodeField, value) != true)) {
                    this.AuthenticationCodeField = value;
                    this.RaisePropertyChanged("AuthenticationCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Key {
            get {
                return this.KeyField;
            }
            set {
                if ((object.ReferenceEquals(this.KeyField, value) != true)) {
                    this.KeyField = value;
                    this.RaisePropertyChanged("Key");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] Scope {
            get {
                return this.ScopeField;
            }
            set {
                if ((object.ReferenceEquals(this.ScopeField, value) != true)) {
                    this.ScopeField = value;
                    this.RaisePropertyChanged("Scope");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="AccessToken", Namespace="http://schemas.datacontract.org/2004/07/AuthorisationServer.Access")]
    [System.SerializableAttribute()]
    public partial class AccessToken : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime EndTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OrganisationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] ScopeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime StartTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TokenField;
        
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
        public System.DateTime EndTime {
            get {
                return this.EndTimeField;
            }
            set {
                if ((this.EndTimeField.Equals(value) != true)) {
                    this.EndTimeField = value;
                    this.RaisePropertyChanged("EndTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Organisation {
            get {
                return this.OrganisationField;
            }
            set {
                if ((object.ReferenceEquals(this.OrganisationField, value) != true)) {
                    this.OrganisationField = value;
                    this.RaisePropertyChanged("Organisation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] Scope {
            get {
                return this.ScopeField;
            }
            set {
                if ((object.ReferenceEquals(this.ScopeField, value) != true)) {
                    this.ScopeField = value;
                    this.RaisePropertyChanged("Scope");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime StartTime {
            get {
                return this.StartTimeField;
            }
            set {
                if ((this.StartTimeField.Equals(value) != true)) {
                    this.StartTimeField = value;
                    this.RaisePropertyChanged("StartTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Token {
            get {
                return this.TokenField;
            }
            set {
                if ((object.ReferenceEquals(this.TokenField, value) != true)) {
                    this.TokenField = value;
                    this.RaisePropertyChanged("Token");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ValidationResult", Namespace="http://schemas.datacontract.org/2004/07/AuthorisationServer.Access")]
    [System.SerializableAttribute()]
    public partial class ValidationResult : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsTokenValidField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ReasonField;
        
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
        public bool IsTokenValid {
            get {
                return this.IsTokenValidField;
            }
            set {
                if ((this.IsTokenValidField.Equals(value) != true)) {
                    this.IsTokenValidField = value;
                    this.RaisePropertyChanged("IsTokenValid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Reason {
            get {
                return this.ReasonField;
            }
            set {
                if ((object.ReferenceEquals(this.ReasonField, value) != true)) {
                    this.ReasonField = value;
                    this.RaisePropertyChanged("Reason");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Authentication.IAccessService")]
    public interface IAccessService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccessService/GetAccessToken", ReplyAction="http://tempuri.org/IAccessService/GetAccessTokenResponse")]
        WMessageServiceApi.Authentication.AccessToken GetAccessToken(WMessageServiceApi.Authentication.AccessRequest accessRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccessService/GetAccessToken", ReplyAction="http://tempuri.org/IAccessService/GetAccessTokenResponse")]
        System.Threading.Tasks.Task<WMessageServiceApi.Authentication.AccessToken> GetAccessTokenAsync(WMessageServiceApi.Authentication.AccessRequest accessRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccessService/CheckAccessTokenValid", ReplyAction="http://tempuri.org/IAccessService/CheckAccessTokenValidResponse")]
        WMessageServiceApi.Authentication.ValidationResult CheckAccessTokenValid(string encryptedToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccessService/CheckAccessTokenValid", ReplyAction="http://tempuri.org/IAccessService/CheckAccessTokenValidResponse")]
        System.Threading.Tasks.Task<WMessageServiceApi.Authentication.ValidationResult> CheckAccessTokenValidAsync(string encryptedToken);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAccessServiceChannel : WMessageServiceApi.Authentication.IAccessService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AccessServiceClient : System.ServiceModel.ClientBase<WMessageServiceApi.Authentication.IAccessService>, WMessageServiceApi.Authentication.IAccessService {
        
        public AccessServiceClient() {
        }
        
        public AccessServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AccessServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccessServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccessServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WMessageServiceApi.Authentication.AccessToken GetAccessToken(WMessageServiceApi.Authentication.AccessRequest accessRequest) {
            return base.Channel.GetAccessToken(accessRequest);
        }
        
        public System.Threading.Tasks.Task<WMessageServiceApi.Authentication.AccessToken> GetAccessTokenAsync(WMessageServiceApi.Authentication.AccessRequest accessRequest) {
            return base.Channel.GetAccessTokenAsync(accessRequest);
        }
        
        public WMessageServiceApi.Authentication.ValidationResult CheckAccessTokenValid(string encryptedToken) {
            return base.Channel.CheckAccessTokenValid(encryptedToken);
        }
        
        public System.Threading.Tasks.Task<WMessageServiceApi.Authentication.ValidationResult> CheckAccessTokenValidAsync(string encryptedToken) {
            return base.Channel.CheckAccessTokenValidAsync(encryptedToken);
        }
    }
}
