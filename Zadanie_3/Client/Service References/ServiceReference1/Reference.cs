﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CMatrix", Namespace="http://schemas.datacontract.org/2004/07/serviceCommon")]
    [System.SerializableAttribute()]
    public partial class CMatrix : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int XField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int YField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int[] m_aMatrixField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int m_iIDField;
        
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
        public int X {
            get {
                return this.XField;
            }
            set {
                if ((this.XField.Equals(value) != true)) {
                    this.XField = value;
                    this.RaisePropertyChanged("X");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Y {
            get {
                return this.YField;
            }
            set {
                if ((this.YField.Equals(value) != true)) {
                    this.YField = value;
                    this.RaisePropertyChanged("Y");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int[] m_aMatrix {
            get {
                return this.m_aMatrixField;
            }
            set {
                if ((object.ReferenceEquals(this.m_aMatrixField, value) != true)) {
                    this.m_aMatrixField = value;
                    this.RaisePropertyChanged("m_aMatrix");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int m_iID {
            get {
                return this.m_iIDField;
            }
            set {
                if ((this.m_iIDField.Equals(value) != true)) {
                    this.m_iIDField = value;
                    this.RaisePropertyChanged("m_iID");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="sServiceResp", Namespace="http://schemas.datacontract.org/2004/07/serviceCommon")]
    [System.SerializableAttribute()]
    public partial struct sServiceResp : System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double m_dElapsedTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int m_iErrCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string m_strMessageField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double m_dElapsedTime {
            get {
                return this.m_dElapsedTimeField;
            }
            set {
                if ((this.m_dElapsedTimeField.Equals(value) != true)) {
                    this.m_dElapsedTimeField = value;
                    this.RaisePropertyChanged("m_dElapsedTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int m_iErrCode {
            get {
                return this.m_iErrCodeField;
            }
            set {
                if ((this.m_iErrCodeField.Equals(value) != true)) {
                    this.m_iErrCodeField = value;
                    this.RaisePropertyChanged("m_iErrCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string m_strMessage {
            get {
                return this.m_strMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.m_strMessageField, value) != true)) {
                    this.m_strMessageField = value;
                    this.RaisePropertyChanged("m_strMessage");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="sServiceRespExt", Namespace="http://schemas.datacontract.org/2004/07/serviceCommon")]
    [System.SerializableAttribute()]
    public partial struct sServiceRespExt : System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client.ServiceReference1.CMatrix m_oMatrixResField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client.ServiceReference1.sServiceResp m_sServiceRespField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client.ServiceReference1.CMatrix m_oMatrixRes {
            get {
                return this.m_oMatrixResField;
            }
            set {
                if ((object.ReferenceEquals(this.m_oMatrixResField, value) != true)) {
                    this.m_oMatrixResField = value;
                    this.RaisePropertyChanged("m_oMatrixRes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client.ServiceReference1.sServiceResp m_sServiceResp {
            get {
                return this.m_sServiceRespField;
            }
            set {
                if ((this.m_sServiceRespField.Equals(value) != true)) {
                    this.m_sServiceRespField = value;
                    this.RaisePropertyChanged("m_sServiceResp");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="eParallel", Namespace="http://schemas.datacontract.org/2004/07/Zadanie_3")]
    public enum eParallel : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        EP_NO = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        EP_YES = 1,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IMatrixService")]
    public interface IMatrixService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatrixService/generateMatrixM", ReplyAction="http://tempuri.org/IMatrixService/generateMatrixMResponse")]
        Client.ServiceReference1.generateMatrixMResponse generateMatrixM(Client.ServiceReference1.generateMatrixMRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatrixService/generateMatrixM", ReplyAction="http://tempuri.org/IMatrixService/generateMatrixMResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference1.generateMatrixMResponse> generateMatrixMAsync(Client.ServiceReference1.generateMatrixMRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatrixService/generateMatrixID", ReplyAction="http://tempuri.org/IMatrixService/generateMatrixIDResponse")]
        Client.ServiceReference1.sServiceRespExt generateMatrixID(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatrixService/generateMatrixID", ReplyAction="http://tempuri.org/IMatrixService/generateMatrixIDResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference1.sServiceRespExt> generateMatrixIDAsync(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatrixService/multipleMatrixM", ReplyAction="http://tempuri.org/IMatrixService/multipleMatrixMResponse")]
        Client.ServiceReference1.multipleMatrixMResponse multipleMatrixM(Client.ServiceReference1.multipleMatrixMRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatrixService/multipleMatrixM", ReplyAction="http://tempuri.org/IMatrixService/multipleMatrixMResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference1.multipleMatrixMResponse> multipleMatrixMAsync(Client.ServiceReference1.multipleMatrixMRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatrixService/multipleMatrixID", ReplyAction="http://tempuri.org/IMatrixService/multipleMatrixIDResponse")]
        Client.ServiceReference1.sServiceRespExt multipleMatrixID(int a_iID1, int a_iID2, Client.ServiceReference1.eParallel a_fFlag);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatrixService/multipleMatrixID", ReplyAction="http://tempuri.org/IMatrixService/multipleMatrixIDResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference1.sServiceRespExt> multipleMatrixIDAsync(int a_iID1, int a_iID2, Client.ServiceReference1.eParallel a_fFlag);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="generateMatrixM", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class generateMatrixMRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public Client.ServiceReference1.CMatrix a_out_Matrix;
        
        public generateMatrixMRequest() {
        }
        
        public generateMatrixMRequest(Client.ServiceReference1.CMatrix a_out_Matrix) {
            this.a_out_Matrix = a_out_Matrix;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="generateMatrixMResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class generateMatrixMResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public Client.ServiceReference1.sServiceResp generateMatrixMResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public Client.ServiceReference1.CMatrix a_out_Matrix;
        
        public generateMatrixMResponse() {
        }
        
        public generateMatrixMResponse(Client.ServiceReference1.sServiceResp generateMatrixMResult, Client.ServiceReference1.CMatrix a_out_Matrix) {
            this.generateMatrixMResult = generateMatrixMResult;
            this.a_out_Matrix = a_out_Matrix;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="multipleMatrixM", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class multipleMatrixMRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public Client.ServiceReference1.CMatrix a_oMatrix1;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public Client.ServiceReference1.CMatrix a_oMatrix2;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public Client.ServiceReference1.CMatrix a_outMatrixRes;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public Client.ServiceReference1.eParallel a_fFlag;
        
        public multipleMatrixMRequest() {
        }
        
        public multipleMatrixMRequest(Client.ServiceReference1.CMatrix a_oMatrix1, Client.ServiceReference1.CMatrix a_oMatrix2, Client.ServiceReference1.CMatrix a_outMatrixRes, Client.ServiceReference1.eParallel a_fFlag) {
            this.a_oMatrix1 = a_oMatrix1;
            this.a_oMatrix2 = a_oMatrix2;
            this.a_outMatrixRes = a_outMatrixRes;
            this.a_fFlag = a_fFlag;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="multipleMatrixMResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class multipleMatrixMResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public Client.ServiceReference1.sServiceResp multipleMatrixMResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public Client.ServiceReference1.CMatrix a_outMatrixRes;
        
        public multipleMatrixMResponse() {
        }
        
        public multipleMatrixMResponse(Client.ServiceReference1.sServiceResp multipleMatrixMResult, Client.ServiceReference1.CMatrix a_outMatrixRes) {
            this.multipleMatrixMResult = multipleMatrixMResult;
            this.a_outMatrixRes = a_outMatrixRes;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMatrixServiceChannel : Client.ServiceReference1.IMatrixService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MatrixServiceClient : System.ServiceModel.ClientBase<Client.ServiceReference1.IMatrixService>, Client.ServiceReference1.IMatrixService {
        
        public MatrixServiceClient() {
        }
        
        public MatrixServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MatrixServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MatrixServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MatrixServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Client.ServiceReference1.generateMatrixMResponse Client.ServiceReference1.IMatrixService.generateMatrixM(Client.ServiceReference1.generateMatrixMRequest request) {
            return base.Channel.generateMatrixM(request);
        }
        
        public Client.ServiceReference1.sServiceResp generateMatrixM(ref Client.ServiceReference1.CMatrix a_out_Matrix) {
            Client.ServiceReference1.generateMatrixMRequest inValue = new Client.ServiceReference1.generateMatrixMRequest();
            inValue.a_out_Matrix = a_out_Matrix;
            Client.ServiceReference1.generateMatrixMResponse retVal = ((Client.ServiceReference1.IMatrixService)(this)).generateMatrixM(inValue);
            a_out_Matrix = retVal.a_out_Matrix;
            return retVal.generateMatrixMResult;
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference1.generateMatrixMResponse> generateMatrixMAsync(Client.ServiceReference1.generateMatrixMRequest request) {
            return base.Channel.generateMatrixMAsync(request);
        }
        
        public Client.ServiceReference1.sServiceRespExt generateMatrixID(int x, int y) {
            return base.Channel.generateMatrixID(x, y);
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference1.sServiceRespExt> generateMatrixIDAsync(int x, int y) {
            return base.Channel.generateMatrixIDAsync(x, y);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Client.ServiceReference1.multipleMatrixMResponse Client.ServiceReference1.IMatrixService.multipleMatrixM(Client.ServiceReference1.multipleMatrixMRequest request) {
            return base.Channel.multipleMatrixM(request);
        }
        
        public Client.ServiceReference1.sServiceResp multipleMatrixM(Client.ServiceReference1.CMatrix a_oMatrix1, Client.ServiceReference1.CMatrix a_oMatrix2, ref Client.ServiceReference1.CMatrix a_outMatrixRes, Client.ServiceReference1.eParallel a_fFlag) {
            Client.ServiceReference1.multipleMatrixMRequest inValue = new Client.ServiceReference1.multipleMatrixMRequest();
            inValue.a_oMatrix1 = a_oMatrix1;
            inValue.a_oMatrix2 = a_oMatrix2;
            inValue.a_outMatrixRes = a_outMatrixRes;
            inValue.a_fFlag = a_fFlag;
            Client.ServiceReference1.multipleMatrixMResponse retVal = ((Client.ServiceReference1.IMatrixService)(this)).multipleMatrixM(inValue);
            a_outMatrixRes = retVal.a_outMatrixRes;
            return retVal.multipleMatrixMResult;
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference1.multipleMatrixMResponse> multipleMatrixMAsync(Client.ServiceReference1.multipleMatrixMRequest request) {
            return base.Channel.multipleMatrixMAsync(request);
        }
        
        public Client.ServiceReference1.sServiceRespExt multipleMatrixID(int a_iID1, int a_iID2, Client.ServiceReference1.eParallel a_fFlag) {
            return base.Channel.multipleMatrixID(a_iID1, a_iID2, a_fFlag);
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference1.sServiceRespExt> multipleMatrixIDAsync(int a_iID1, int a_iID2, Client.ServiceReference1.eParallel a_fFlag) {
            return base.Channel.multipleMatrixIDAsync(a_iID1, a_iID2, a_fFlag);
        }
    }
}