﻿//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenETaxBill.WcfSigner {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.odinsoftware.co.kr/open/etaxbill/signer/2016/07", ConfigurationName="WcfSigner.ISignerService")]
    public interface ISignerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.odinsoftware.co.kr/open/etaxbill/signer/2016/07/ISignerService/WriteLo" +
            "g", ReplyAction="http://www.odinsoftware.co.kr/open/etaxbill/signer/2016/07/ISignerService/WriteLo" +
            "gResponse")]
        void WriteLog(System.Guid p_certapp, string p_exception, string p_message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.odinsoftware.co.kr/open/etaxbill/signer/2016/07/ISignerService/WriteLo" +
            "g", ReplyAction="http://www.odinsoftware.co.kr/open/etaxbill/signer/2016/07/ISignerService/WriteLo" +
            "gResponse")]
        System.Threading.Tasks.Task WriteLogAsync(System.Guid p_certapp, string p_exception, string p_message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.odinsoftware.co.kr/open/etaxbill/signer/2016/07/ISignerService/Signatu" +
            "reWithDateRange", ReplyAction="http://www.odinsoftware.co.kr/open/etaxbill/signer/2016/07/ISignerService/Signatu" +
            "reWithDateRangeResponse")]
        int SignatureWithDateRange(System.Guid p_certapp, string[] p_certifier, string p_invoicerId, System.DateTime p_fromDay, System.DateTime p_tillDay);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.odinsoftware.co.kr/open/etaxbill/signer/2016/07/ISignerService/Signatu" +
            "reWithDateRange", ReplyAction="http://www.odinsoftware.co.kr/open/etaxbill/signer/2016/07/ISignerService/Signatu" +
            "reWithDateRangeResponse")]
        System.Threading.Tasks.Task<int> SignatureWithDateRangeAsync(System.Guid p_certapp, string[] p_certifier, string p_invoicerId, System.DateTime p_fromDay, System.DateTime p_tillDay);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.odinsoftware.co.kr/open/etaxbill/signer/2016/07/ISignerService/Signatu" +
            "reWithIDs", ReplyAction="http://www.odinsoftware.co.kr/open/etaxbill/signer/2016/07/ISignerService/Signatu" +
            "reWithIDsResponse")]
        int SignatureWithIDs(System.Guid p_certapp, string[] p_certifier, string p_invoicerId, string[] p_issueIds);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.odinsoftware.co.kr/open/etaxbill/signer/2016/07/ISignerService/Signatu" +
            "reWithIDs", ReplyAction="http://www.odinsoftware.co.kr/open/etaxbill/signer/2016/07/ISignerService/Signatu" +
            "reWithIDsResponse")]
        System.Threading.Tasks.Task<int> SignatureWithIDsAsync(System.Guid p_certapp, string[] p_certifier, string p_invoicerId, string[] p_issueIds);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.odinsoftware.co.kr/open/etaxbill/signer/2016/07/ISignerService/ClearXF" +
            "lag", ReplyAction="http://www.odinsoftware.co.kr/open/etaxbill/signer/2016/07/ISignerService/ClearXF" +
            "lagResponse")]
        int ClearXFlag(System.Guid p_certapp, string p_invoicerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.odinsoftware.co.kr/open/etaxbill/signer/2016/07/ISignerService/ClearXF" +
            "lag", ReplyAction="http://www.odinsoftware.co.kr/open/etaxbill/signer/2016/07/ISignerService/ClearXF" +
            "lagResponse")]
        System.Threading.Tasks.Task<int> ClearXFlagAsync(System.Guid p_certapp, string p_invoicerId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISignerServiceChannel : OpenETaxBill.WcfSigner.ISignerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SignerServiceClient : System.ServiceModel.ClientBase<OpenETaxBill.WcfSigner.ISignerService>, OpenETaxBill.WcfSigner.ISignerService {
        
        public SignerServiceClient() {
        }
        
        public SignerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SignerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SignerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SignerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void WriteLog(System.Guid p_certapp, string p_exception, string p_message) {
            base.Channel.WriteLog(p_certapp, p_exception, p_message);
        }
        
        public System.Threading.Tasks.Task WriteLogAsync(System.Guid p_certapp, string p_exception, string p_message) {
            return base.Channel.WriteLogAsync(p_certapp, p_exception, p_message);
        }
        
        public int SignatureWithDateRange(System.Guid p_certapp, string[] p_certifier, string p_invoicerId, System.DateTime p_fromDay, System.DateTime p_tillDay) {
            return base.Channel.SignatureWithDateRange(p_certapp, p_certifier, p_invoicerId, p_fromDay, p_tillDay);
        }
        
        public System.Threading.Tasks.Task<int> SignatureWithDateRangeAsync(System.Guid p_certapp, string[] p_certifier, string p_invoicerId, System.DateTime p_fromDay, System.DateTime p_tillDay) {
            return base.Channel.SignatureWithDateRangeAsync(p_certapp, p_certifier, p_invoicerId, p_fromDay, p_tillDay);
        }
        
        public int SignatureWithIDs(System.Guid p_certapp, string[] p_certifier, string p_invoicerId, string[] p_issueIds) {
            return base.Channel.SignatureWithIDs(p_certapp, p_certifier, p_invoicerId, p_issueIds);
        }
        
        public System.Threading.Tasks.Task<int> SignatureWithIDsAsync(System.Guid p_certapp, string[] p_certifier, string p_invoicerId, string[] p_issueIds) {
            return base.Channel.SignatureWithIDsAsync(p_certapp, p_certifier, p_invoicerId, p_issueIds);
        }
        
        public int ClearXFlag(System.Guid p_certapp, string p_invoicerId) {
            return base.Channel.ClearXFlag(p_certapp, p_invoicerId);
        }
        
        public System.Threading.Tasks.Task<int> ClearXFlagAsync(System.Guid p_certapp, string p_invoicerId) {
            return base.Channel.ClearXFlagAsync(p_certapp, p_invoicerId);
        }
    }
}
