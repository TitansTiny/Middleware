﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Logica.ServiceTiendaMil {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Producto", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Producto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreField;
        
        private decimal precio_unitarioField;
        
        private bool ivaField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                if ((object.ReferenceEquals(this.nombreField, value) != true)) {
                    this.nombreField = value;
                    this.RaisePropertyChanged("nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public decimal precio_unitario {
            get {
                return this.precio_unitarioField;
            }
            set {
                if ((this.precio_unitarioField.Equals(value) != true)) {
                    this.precio_unitarioField = value;
                    this.RaisePropertyChanged("precio_unitario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public bool iva {
            get {
                return this.ivaField;
            }
            set {
                if ((this.ivaField.Equals(value) != true)) {
                    this.ivaField = value;
                    this.RaisePropertyChanged("iva");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceTiendaMil.WebServiceVentasSoap")]
    public interface WebServiceVentasSoap {
        
        // CODEGEN: Generating message contract since element name ListarProductoResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListarProducto", ReplyAction="*")]
        Logica.ServiceTiendaMil.ListarProductoResponse ListarProducto(Logica.ServiceTiendaMil.ListarProductoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListarProducto", ReplyAction="*")]
        System.Threading.Tasks.Task<Logica.ServiceTiendaMil.ListarProductoResponse> ListarProductoAsync(Logica.ServiceTiendaMil.ListarProductoRequest request);
        
        // CODEGEN: Generating message contract since element name BuscarIdResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BuscarId", ReplyAction="*")]
        Logica.ServiceTiendaMil.BuscarIdResponse BuscarId(Logica.ServiceTiendaMil.BuscarIdRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BuscarId", ReplyAction="*")]
        System.Threading.Tasks.Task<Logica.ServiceTiendaMil.BuscarIdResponse> BuscarIdAsync(Logica.ServiceTiendaMil.BuscarIdRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListarProductoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListarProducto", Namespace="http://tempuri.org/", Order=0)]
        public Logica.ServiceTiendaMil.ListarProductoRequestBody Body;
        
        public ListarProductoRequest() {
        }
        
        public ListarProductoRequest(Logica.ServiceTiendaMil.ListarProductoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ListarProductoRequestBody {
        
        public ListarProductoRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListarProductoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListarProductoResponse", Namespace="http://tempuri.org/", Order=0)]
        public Logica.ServiceTiendaMil.ListarProductoResponseBody Body;
        
        public ListarProductoResponse() {
        }
        
        public ListarProductoResponse(Logica.ServiceTiendaMil.ListarProductoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ListarProductoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Logica.ServiceTiendaMil.Producto[] ListarProductoResult;
        
        public ListarProductoResponseBody() {
        }
        
        public ListarProductoResponseBody(Logica.ServiceTiendaMil.Producto[] ListarProductoResult) {
            this.ListarProductoResult = ListarProductoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class BuscarIdRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="BuscarId", Namespace="http://tempuri.org/", Order=0)]
        public Logica.ServiceTiendaMil.BuscarIdRequestBody Body;
        
        public BuscarIdRequest() {
        }
        
        public BuscarIdRequest(Logica.ServiceTiendaMil.BuscarIdRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class BuscarIdRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public BuscarIdRequestBody() {
        }
        
        public BuscarIdRequestBody(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class BuscarIdResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="BuscarIdResponse", Namespace="http://tempuri.org/", Order=0)]
        public Logica.ServiceTiendaMil.BuscarIdResponseBody Body;
        
        public BuscarIdResponse() {
        }
        
        public BuscarIdResponse(Logica.ServiceTiendaMil.BuscarIdResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class BuscarIdResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Logica.ServiceTiendaMil.Producto BuscarIdResult;
        
        public BuscarIdResponseBody() {
        }
        
        public BuscarIdResponseBody(Logica.ServiceTiendaMil.Producto BuscarIdResult) {
            this.BuscarIdResult = BuscarIdResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceVentasSoapChannel : Logica.ServiceTiendaMil.WebServiceVentasSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceVentasSoapClient : System.ServiceModel.ClientBase<Logica.ServiceTiendaMil.WebServiceVentasSoap>, Logica.ServiceTiendaMil.WebServiceVentasSoap {
        
        public WebServiceVentasSoapClient() {
        }
        
        public WebServiceVentasSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceVentasSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceVentasSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceVentasSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Logica.ServiceTiendaMil.ListarProductoResponse Logica.ServiceTiendaMil.WebServiceVentasSoap.ListarProducto(Logica.ServiceTiendaMil.ListarProductoRequest request) {
            return base.Channel.ListarProducto(request);
        }
        
        public Logica.ServiceTiendaMil.Producto[] ListarProducto() {
            Logica.ServiceTiendaMil.ListarProductoRequest inValue = new Logica.ServiceTiendaMil.ListarProductoRequest();
            inValue.Body = new Logica.ServiceTiendaMil.ListarProductoRequestBody();
            Logica.ServiceTiendaMil.ListarProductoResponse retVal = ((Logica.ServiceTiendaMil.WebServiceVentasSoap)(this)).ListarProducto(inValue);
            return retVal.Body.ListarProductoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Logica.ServiceTiendaMil.ListarProductoResponse> Logica.ServiceTiendaMil.WebServiceVentasSoap.ListarProductoAsync(Logica.ServiceTiendaMil.ListarProductoRequest request) {
            return base.Channel.ListarProductoAsync(request);
        }
        
        public System.Threading.Tasks.Task<Logica.ServiceTiendaMil.ListarProductoResponse> ListarProductoAsync() {
            Logica.ServiceTiendaMil.ListarProductoRequest inValue = new Logica.ServiceTiendaMil.ListarProductoRequest();
            inValue.Body = new Logica.ServiceTiendaMil.ListarProductoRequestBody();
            return ((Logica.ServiceTiendaMil.WebServiceVentasSoap)(this)).ListarProductoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Logica.ServiceTiendaMil.BuscarIdResponse Logica.ServiceTiendaMil.WebServiceVentasSoap.BuscarId(Logica.ServiceTiendaMil.BuscarIdRequest request) {
            return base.Channel.BuscarId(request);
        }
        
        public Logica.ServiceTiendaMil.Producto BuscarId(int id) {
            Logica.ServiceTiendaMil.BuscarIdRequest inValue = new Logica.ServiceTiendaMil.BuscarIdRequest();
            inValue.Body = new Logica.ServiceTiendaMil.BuscarIdRequestBody();
            inValue.Body.id = id;
            Logica.ServiceTiendaMil.BuscarIdResponse retVal = ((Logica.ServiceTiendaMil.WebServiceVentasSoap)(this)).BuscarId(inValue);
            return retVal.Body.BuscarIdResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Logica.ServiceTiendaMil.BuscarIdResponse> Logica.ServiceTiendaMil.WebServiceVentasSoap.BuscarIdAsync(Logica.ServiceTiendaMil.BuscarIdRequest request) {
            return base.Channel.BuscarIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<Logica.ServiceTiendaMil.BuscarIdResponse> BuscarIdAsync(int id) {
            Logica.ServiceTiendaMil.BuscarIdRequest inValue = new Logica.ServiceTiendaMil.BuscarIdRequest();
            inValue.Body = new Logica.ServiceTiendaMil.BuscarIdRequestBody();
            inValue.Body.id = id;
            return ((Logica.ServiceTiendaMil.WebServiceVentasSoap)(this)).BuscarIdAsync(inValue);
        }
    }
}
