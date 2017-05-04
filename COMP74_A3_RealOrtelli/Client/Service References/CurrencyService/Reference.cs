﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.CurrencyService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CurrencyService.ICurrencyService")]
    public interface ICurrencyService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICurrencyService/getCurrencies", ReplyAction="http://tempuri.org/ICurrencyService/getCurrenciesResponse")]
        string[] getCurrencies();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICurrencyService/getCurrencies", ReplyAction="http://tempuri.org/ICurrencyService/getCurrenciesResponse")]
        System.Threading.Tasks.Task<string[]> getCurrenciesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICurrencyService/getCountries", ReplyAction="http://tempuri.org/ICurrencyService/getCountriesResponse")]
        string[] getCountries();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICurrencyService/getCountries", ReplyAction="http://tempuri.org/ICurrencyService/getCountriesResponse")]
        System.Threading.Tasks.Task<string[]> getCountriesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICurrencyService/getCurrencyCodes", ReplyAction="http://tempuri.org/ICurrencyService/getCurrencyCodesResponse")]
        string[] getCurrencyCodes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICurrencyService/getCurrencyCodes", ReplyAction="http://tempuri.org/ICurrencyService/getCurrencyCodesResponse")]
        System.Threading.Tasks.Task<string[]> getCurrencyCodesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICurrencyServiceChannel : Client.CurrencyService.ICurrencyService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CurrencyServiceClient : System.ServiceModel.ClientBase<Client.CurrencyService.ICurrencyService>, Client.CurrencyService.ICurrencyService {
        
        public CurrencyServiceClient() {
        }
        
        public CurrencyServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CurrencyServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CurrencyServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CurrencyServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] getCurrencies() {
            return base.Channel.getCurrencies();
        }
        
        public System.Threading.Tasks.Task<string[]> getCurrenciesAsync() {
            return base.Channel.getCurrenciesAsync();
        }
        
        public string[] getCountries() {
            return base.Channel.getCountries();
        }
        
        public System.Threading.Tasks.Task<string[]> getCountriesAsync() {
            return base.Channel.getCountriesAsync();
        }
        
        public string[] getCurrencyCodes() {
            return base.Channel.getCurrencyCodes();
        }
        
        public System.Threading.Tasks.Task<string[]> getCurrencyCodesAsync() {
            return base.Channel.getCurrencyCodesAsync();
        }
    }
}
