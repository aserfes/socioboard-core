﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace Socioboard.Api.GooglePlus {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="GooglePlusSoap", Namespace="http://tempuri.org/")]
    public partial class GooglePlus : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback AddGPlusAccountOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetGPusDataOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetGooglePlusCommentsOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public GooglePlus() {
            this.Url = global::Socioboard.Properties.Settings.Default.Socioboard_Api_GooglePlus_GooglePlus;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event AddGPlusAccountCompletedEventHandler AddGPlusAccountCompleted;
        
        /// <remarks/>
        public event GetGPusDataCompletedEventHandler GetGPusDataCompleted;
        
        /// <remarks/>
        public event GetGooglePlusCommentsCompletedEventHandler GetGooglePlusCommentsCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddGPlusAccount", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string AddGPlusAccount(string client_id, string client_secret, string redirect_uri, string UserId, string GroupId, string code) {
            object[] results = this.Invoke("AddGPlusAccount", new object[] {
                        client_id,
                        client_secret,
                        redirect_uri,
                        UserId,
                        GroupId,
                        code});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void AddGPlusAccountAsync(string client_id, string client_secret, string redirect_uri, string UserId, string GroupId, string code) {
            this.AddGPlusAccountAsync(client_id, client_secret, redirect_uri, UserId, GroupId, code, null);
        }
        
        /// <remarks/>
        public void AddGPlusAccountAsync(string client_id, string client_secret, string redirect_uri, string UserId, string GroupId, string code, object userState) {
            if ((this.AddGPlusAccountOperationCompleted == null)) {
                this.AddGPlusAccountOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddGPlusAccountOperationCompleted);
            }
            this.InvokeAsync("AddGPlusAccount", new object[] {
                        client_id,
                        client_secret,
                        redirect_uri,
                        UserId,
                        GroupId,
                        code}, this.AddGPlusAccountOperationCompleted, userState);
        }
        
        private void OnAddGPlusAccountOperationCompleted(object arg) {
            if ((this.AddGPlusAccountCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddGPlusAccountCompleted(this, new AddGPlusAccountCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetGPusData", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetGPusData(string UserId, string ProfileId) {
            object[] results = this.Invoke("GetGPusData", new object[] {
                        UserId,
                        ProfileId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetGPusDataAsync(string UserId, string ProfileId) {
            this.GetGPusDataAsync(UserId, ProfileId, null);
        }
        
        /// <remarks/>
        public void GetGPusDataAsync(string UserId, string ProfileId, object userState) {
            if ((this.GetGPusDataOperationCompleted == null)) {
                this.GetGPusDataOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetGPusDataOperationCompleted);
            }
            this.InvokeAsync("GetGPusData", new object[] {
                        UserId,
                        ProfileId}, this.GetGPusDataOperationCompleted, userState);
        }
        
        private void OnGetGPusDataOperationCompleted(object arg) {
            if ((this.GetGPusDataCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetGPusDataCompleted(this, new GetGPusDataCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetGooglePlusComments", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void GetGooglePlusComments(string feedId, string AccessToken, string profileId) {
            this.Invoke("GetGooglePlusComments", new object[] {
                        feedId,
                        AccessToken,
                        profileId});
        }
        
        /// <remarks/>
        public void GetGooglePlusCommentsAsync(string feedId, string AccessToken, string profileId) {
            this.GetGooglePlusCommentsAsync(feedId, AccessToken, profileId, null);
        }
        
        /// <remarks/>
        public void GetGooglePlusCommentsAsync(string feedId, string AccessToken, string profileId, object userState) {
            if ((this.GetGooglePlusCommentsOperationCompleted == null)) {
                this.GetGooglePlusCommentsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetGooglePlusCommentsOperationCompleted);
            }
            this.InvokeAsync("GetGooglePlusComments", new object[] {
                        feedId,
                        AccessToken,
                        profileId}, this.GetGooglePlusCommentsOperationCompleted, userState);
        }
        
        private void OnGetGooglePlusCommentsOperationCompleted(object arg) {
            if ((this.GetGooglePlusCommentsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetGooglePlusCommentsCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void AddGPlusAccountCompletedEventHandler(object sender, AddGPlusAccountCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddGPlusAccountCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddGPlusAccountCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void GetGPusDataCompletedEventHandler(object sender, GetGPusDataCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetGPusDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetGPusDataCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void GetGooglePlusCommentsCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591