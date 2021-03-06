﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.1008
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.1008.
// 
#pragma warning disable 1591

namespace SOAPWebService.net.webservicex.www {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="CurrencyConvertorSoap", Namespace="http://www.webserviceX.NET/")]
    public partial class CurrencyConvertor : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ConversionRateOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public CurrencyConvertor() {
            this.Url = global::SOAPWebService.Properties.Settings.Default.SOAPWebService_net_webservicex_www_CurrencyConvertor;
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
        public event ConversionRateCompletedEventHandler ConversionRateCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.webserviceX.NET/ConversionRate", RequestNamespace="http://www.webserviceX.NET/", ResponseNamespace="http://www.webserviceX.NET/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public double ConversionRate(Currency FromCurrency, Currency ToCurrency) {
            object[] results = this.Invoke("ConversionRate", new object[] {
                        FromCurrency,
                        ToCurrency});
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public void ConversionRateAsync(Currency FromCurrency, Currency ToCurrency) {
            this.ConversionRateAsync(FromCurrency, ToCurrency, null);
        }
        
        /// <remarks/>
        public void ConversionRateAsync(Currency FromCurrency, Currency ToCurrency, object userState) {
            if ((this.ConversionRateOperationCompleted == null)) {
                this.ConversionRateOperationCompleted = new System.Threading.SendOrPostCallback(this.OnConversionRateOperationCompleted);
            }
            this.InvokeAsync("ConversionRate", new object[] {
                        FromCurrency,
                        ToCurrency}, this.ConversionRateOperationCompleted, userState);
        }
        
        private void OnConversionRateOperationCompleted(object arg) {
            if ((this.ConversionRateCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ConversionRateCompleted(this, new ConversionRateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1015")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.webserviceX.NET/")]
    public enum Currency {
        
        /// <comentarios/>
        AFA,
        
        /// <comentarios/>
        ALL,
        
        /// <comentarios/>
        DZD,
        
        /// <comentarios/>
        ARS,
        
        /// <comentarios/>
        AWG,
        
        /// <comentarios/>
        AUD,
        
        /// <comentarios/>
        BSD,
        
        /// <comentarios/>
        BHD,
        
        /// <comentarios/>
        BDT,
        
        /// <comentarios/>
        BBD,
        
        /// <comentarios/>
        BZD,
        
        /// <comentarios/>
        BMD,
        
        /// <comentarios/>
        BTN,
        
        /// <comentarios/>
        BOB,
        
        /// <comentarios/>
        BWP,
        
        /// <comentarios/>
        BRL,
        
        /// <comentarios/>
        GBP,
        
        /// <comentarios/>
        BND,
        
        /// <comentarios/>
        BIF,
        
        /// <comentarios/>
        XOF,
        
        /// <comentarios/>
        XAF,
        
        /// <comentarios/>
        KHR,
        
        /// <comentarios/>
        CAD,
        
        /// <comentarios/>
        CVE,
        
        /// <comentarios/>
        KYD,
        
        /// <comentarios/>
        CLP,
        
        /// <comentarios/>
        CNY,
        
        /// <comentarios/>
        COP,
        
        /// <comentarios/>
        KMF,
        
        /// <comentarios/>
        CRC,
        
        /// <comentarios/>
        HRK,
        
        /// <comentarios/>
        CUP,
        
        /// <comentarios/>
        CYP,
        
        /// <comentarios/>
        CZK,
        
        /// <comentarios/>
        DKK,
        
        /// <comentarios/>
        DJF,
        
        /// <comentarios/>
        DOP,
        
        /// <comentarios/>
        XCD,
        
        /// <comentarios/>
        EGP,
        
        /// <comentarios/>
        SVC,
        
        /// <comentarios/>
        EEK,
        
        /// <comentarios/>
        ETB,
        
        /// <comentarios/>
        EUR,
        
        /// <comentarios/>
        FKP,
        
        /// <comentarios/>
        GMD,
        
        /// <comentarios/>
        GHC,
        
        /// <comentarios/>
        GIP,
        
        /// <comentarios/>
        XAU,
        
        /// <comentarios/>
        GTQ,
        
        /// <comentarios/>
        GNF,
        
        /// <comentarios/>
        GYD,
        
        /// <comentarios/>
        HTG,
        
        /// <comentarios/>
        HNL,
        
        /// <comentarios/>
        HKD,
        
        /// <comentarios/>
        HUF,
        
        /// <comentarios/>
        ISK,
        
        /// <comentarios/>
        INR,
        
        /// <comentarios/>
        IDR,
        
        /// <comentarios/>
        IQD,
        
        /// <comentarios/>
        ILS,
        
        /// <comentarios/>
        JMD,
        
        /// <comentarios/>
        JPY,
        
        /// <comentarios/>
        JOD,
        
        /// <comentarios/>
        KZT,
        
        /// <comentarios/>
        KES,
        
        /// <comentarios/>
        KRW,
        
        /// <comentarios/>
        KWD,
        
        /// <comentarios/>
        LAK,
        
        /// <comentarios/>
        LVL,
        
        /// <comentarios/>
        LBP,
        
        /// <comentarios/>
        LSL,
        
        /// <comentarios/>
        LRD,
        
        /// <comentarios/>
        LYD,
        
        /// <comentarios/>
        LTL,
        
        /// <comentarios/>
        MOP,
        
        /// <comentarios/>
        MKD,
        
        /// <comentarios/>
        MGF,
        
        /// <comentarios/>
        MWK,
        
        /// <comentarios/>
        MYR,
        
        /// <comentarios/>
        MVR,
        
        /// <comentarios/>
        MTL,
        
        /// <comentarios/>
        MRO,
        
        /// <comentarios/>
        MUR,
        
        /// <comentarios/>
        MXN,
        
        /// <comentarios/>
        MDL,
        
        /// <comentarios/>
        MNT,
        
        /// <comentarios/>
        MAD,
        
        /// <comentarios/>
        MZM,
        
        /// <comentarios/>
        MMK,
        
        /// <comentarios/>
        NAD,
        
        /// <comentarios/>
        NPR,
        
        /// <comentarios/>
        ANG,
        
        /// <comentarios/>
        NZD,
        
        /// <comentarios/>
        NIO,
        
        /// <comentarios/>
        NGN,
        
        /// <comentarios/>
        KPW,
        
        /// <comentarios/>
        NOK,
        
        /// <comentarios/>
        OMR,
        
        /// <comentarios/>
        XPF,
        
        /// <comentarios/>
        PKR,
        
        /// <comentarios/>
        XPD,
        
        /// <comentarios/>
        PAB,
        
        /// <comentarios/>
        PGK,
        
        /// <comentarios/>
        PYG,
        
        /// <comentarios/>
        PEN,
        
        /// <comentarios/>
        PHP,
        
        /// <comentarios/>
        XPT,
        
        /// <comentarios/>
        PLN,
        
        /// <comentarios/>
        QAR,
        
        /// <comentarios/>
        ROL,
        
        /// <comentarios/>
        RUB,
        
        /// <comentarios/>
        WST,
        
        /// <comentarios/>
        STD,
        
        /// <comentarios/>
        SAR,
        
        /// <comentarios/>
        SCR,
        
        /// <comentarios/>
        SLL,
        
        /// <comentarios/>
        XAG,
        
        /// <comentarios/>
        SGD,
        
        /// <comentarios/>
        SKK,
        
        /// <comentarios/>
        SIT,
        
        /// <comentarios/>
        SBD,
        
        /// <comentarios/>
        SOS,
        
        /// <comentarios/>
        ZAR,
        
        /// <comentarios/>
        LKR,
        
        /// <comentarios/>
        SHP,
        
        /// <comentarios/>
        SDD,
        
        /// <comentarios/>
        SRG,
        
        /// <comentarios/>
        SZL,
        
        /// <comentarios/>
        SEK,
        
        /// <comentarios/>
        CHF,
        
        /// <comentarios/>
        SYP,
        
        /// <comentarios/>
        TWD,
        
        /// <comentarios/>
        TZS,
        
        /// <comentarios/>
        THB,
        
        /// <comentarios/>
        TOP,
        
        /// <comentarios/>
        TTD,
        
        /// <comentarios/>
        TND,
        
        /// <comentarios/>
        TRL,
        
        /// <comentarios/>
        USD,
        
        /// <comentarios/>
        AED,
        
        /// <comentarios/>
        UGX,
        
        /// <comentarios/>
        UAH,
        
        /// <comentarios/>
        UYU,
        
        /// <comentarios/>
        VUV,
        
        /// <comentarios/>
        VEB,
        
        /// <comentarios/>
        VND,
        
        /// <comentarios/>
        YER,
        
        /// <comentarios/>
        YUM,
        
        /// <comentarios/>
        ZMK,
        
        /// <comentarios/>
        ZWD,
        
        /// <comentarios/>
        TRY,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void ConversionRateCompletedEventHandler(object sender, ConversionRateCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ConversionRateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ConversionRateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public double Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591