﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace a2pt1console.CalculateTip {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CalculateTip.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CalculateTip", ReplyAction="http://tempuri.org/IService/CalculateTipResponse")]
        a2pt1console.CalculateTip.CalculateTipResponse CalculateTip(a2pt1console.CalculateTip.CalculateTipRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CalculateTip", ReplyAction="http://tempuri.org/IService/CalculateTipResponse")]
        System.Threading.Tasks.Task<a2pt1console.CalculateTip.CalculateTipResponse> CalculateTipAsync(a2pt1console.CalculateTip.CalculateTipRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CalculateTip", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class CalculateTipRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public double sentCheckTotal;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public double sentTipPercentage;
        
        public CalculateTipRequest() {
        }
        
        public CalculateTipRequest(double sentCheckTotal, double sentTipPercentage) {
            this.sentCheckTotal = sentCheckTotal;
            this.sentTipPercentage = sentTipPercentage;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CalculateTipResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class CalculateTipResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public double calculatedTipTotal;
        
        public CalculateTipResponse() {
        }
        
        public CalculateTipResponse(double calculatedTipTotal) {
            this.calculatedTipTotal = calculatedTipTotal;
        }
    }
}