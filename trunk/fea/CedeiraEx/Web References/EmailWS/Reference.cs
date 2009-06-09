﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión del motor en tiempo de ejecución:2.0.50727.42
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=2.0.50727.42.
// 
#pragma warning disable 1591

namespace Cedeira.Ex.EmailWS {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="EmailSoap", Namespace="http://www.cedeira.com.ar/webservices/")]
    public partial class Email : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback EnviarEmailSinAdjuntoOperationCompleted;
        
        private System.Threading.SendOrPostCallback EnviarEmailConAdjuntoOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Email() {
            this.Url = global::Cedeira.Ex.Properties.Settings.Default.CedeiraEx_EmailWS_Email;
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
        public event EnviarEmailSinAdjuntoCompletedEventHandler EnviarEmailSinAdjuntoCompleted;
        
        /// <remarks/>
        public event EnviarEmailConAdjuntoCompletedEventHandler EnviarEmailConAdjuntoCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.cedeira.com.ar/webservices/EnviarEmailSinAdjunto", RequestNamespace="http://www.cedeira.com.ar/webservices/", ResponseNamespace="http://www.cedeira.com.ar/webservices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void EnviarEmailSinAdjunto(string De, string Para, string CC, string CCO, string Asunto, string Body, string SmtpServer) {
            this.Invoke("EnviarEmailSinAdjunto", new object[] {
                        De,
                        Para,
                        CC,
                        CCO,
                        Asunto,
                        Body,
                        SmtpServer});
        }
        
        /// <remarks/>
        public void EnviarEmailSinAdjuntoAsync(string De, string Para, string CC, string CCO, string Asunto, string Body, string SmtpServer) {
            this.EnviarEmailSinAdjuntoAsync(De, Para, CC, CCO, Asunto, Body, SmtpServer, null);
        }
        
        /// <remarks/>
        public void EnviarEmailSinAdjuntoAsync(string De, string Para, string CC, string CCO, string Asunto, string Body, string SmtpServer, object userState) {
            if ((this.EnviarEmailSinAdjuntoOperationCompleted == null)) {
                this.EnviarEmailSinAdjuntoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnEnviarEmailSinAdjuntoOperationCompleted);
            }
            this.InvokeAsync("EnviarEmailSinAdjunto", new object[] {
                        De,
                        Para,
                        CC,
                        CCO,
                        Asunto,
                        Body,
                        SmtpServer}, this.EnviarEmailSinAdjuntoOperationCompleted, userState);
        }
        
        private void OnEnviarEmailSinAdjuntoOperationCompleted(object arg) {
            if ((this.EnviarEmailSinAdjuntoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.EnviarEmailSinAdjuntoCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.cedeira.com.ar/webservices/EnviarEmailConAdjunto", RequestNamespace="http://www.cedeira.com.ar/webservices/", ResponseNamespace="http://www.cedeira.com.ar/webservices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void EnviarEmailConAdjunto(string De, string Para, string CC, string CCO, string Asunto, string Body, string SmtpServer, [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")] byte[] f, string fileName) {
            this.Invoke("EnviarEmailConAdjunto", new object[] {
                        De,
                        Para,
                        CC,
                        CCO,
                        Asunto,
                        Body,
                        SmtpServer,
                        f,
                        fileName});
        }
        
        /// <remarks/>
        public void EnviarEmailConAdjuntoAsync(string De, string Para, string CC, string CCO, string Asunto, string Body, string SmtpServer, byte[] f, string fileName) {
            this.EnviarEmailConAdjuntoAsync(De, Para, CC, CCO, Asunto, Body, SmtpServer, f, fileName, null);
        }
        
        /// <remarks/>
        public void EnviarEmailConAdjuntoAsync(string De, string Para, string CC, string CCO, string Asunto, string Body, string SmtpServer, byte[] f, string fileName, object userState) {
            if ((this.EnviarEmailConAdjuntoOperationCompleted == null)) {
                this.EnviarEmailConAdjuntoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnEnviarEmailConAdjuntoOperationCompleted);
            }
            this.InvokeAsync("EnviarEmailConAdjunto", new object[] {
                        De,
                        Para,
                        CC,
                        CCO,
                        Asunto,
                        Body,
                        SmtpServer,
                        f,
                        fileName}, this.EnviarEmailConAdjuntoOperationCompleted, userState);
        }
        
        private void OnEnviarEmailConAdjuntoOperationCompleted(object arg) {
            if ((this.EnviarEmailConAdjuntoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.EnviarEmailConAdjuntoCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    public delegate void EnviarEmailSinAdjuntoCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    public delegate void EnviarEmailConAdjuntoCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591