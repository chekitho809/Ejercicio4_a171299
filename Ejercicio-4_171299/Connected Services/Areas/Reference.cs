//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ejercicio_4_171299.Areas {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Areas.AreasWebServiceSoap")]
    public interface AreasWebServiceSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento HelloWorldResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        Ejercicio_4_171299.Areas.HelloWorldResponse HelloWorld(Ejercicio_4_171299.Areas.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<Ejercicio_4_171299.Areas.HelloWorldResponse> HelloWorldAsync(Ejercicio_4_171299.Areas.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/cuadro", ReplyAction="*")]
        decimal cuadro(decimal lado1, decimal lado2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/cuadro", ReplyAction="*")]
        System.Threading.Tasks.Task<decimal> cuadroAsync(decimal lado1, decimal lado2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/triangulo", ReplyAction="*")]
        decimal triangulo(decimal base1, decimal altura2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/triangulo", ReplyAction="*")]
        System.Threading.Tasks.Task<decimal> trianguloAsync(decimal base1, decimal altura2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/circulo", ReplyAction="*")]
        double circulo(double radio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/circulo", ReplyAction="*")]
        System.Threading.Tasks.Task<double> circuloAsync(double radio);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public Ejercicio_4_171299.Areas.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(Ejercicio_4_171299.Areas.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public Ejercicio_4_171299.Areas.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(Ejercicio_4_171299.Areas.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AreasWebServiceSoapChannel : Ejercicio_4_171299.Areas.AreasWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AreasWebServiceSoapClient : System.ServiceModel.ClientBase<Ejercicio_4_171299.Areas.AreasWebServiceSoap>, Ejercicio_4_171299.Areas.AreasWebServiceSoap {
        
        public AreasWebServiceSoapClient() {
        }
        
        public AreasWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AreasWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AreasWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AreasWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Ejercicio_4_171299.Areas.HelloWorldResponse Ejercicio_4_171299.Areas.AreasWebServiceSoap.HelloWorld(Ejercicio_4_171299.Areas.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            Ejercicio_4_171299.Areas.HelloWorldRequest inValue = new Ejercicio_4_171299.Areas.HelloWorldRequest();
            inValue.Body = new Ejercicio_4_171299.Areas.HelloWorldRequestBody();
            Ejercicio_4_171299.Areas.HelloWorldResponse retVal = ((Ejercicio_4_171299.Areas.AreasWebServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Ejercicio_4_171299.Areas.HelloWorldResponse> Ejercicio_4_171299.Areas.AreasWebServiceSoap.HelloWorldAsync(Ejercicio_4_171299.Areas.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<Ejercicio_4_171299.Areas.HelloWorldResponse> HelloWorldAsync() {
            Ejercicio_4_171299.Areas.HelloWorldRequest inValue = new Ejercicio_4_171299.Areas.HelloWorldRequest();
            inValue.Body = new Ejercicio_4_171299.Areas.HelloWorldRequestBody();
            return ((Ejercicio_4_171299.Areas.AreasWebServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        public decimal cuadro(decimal lado1, decimal lado2) {
            return base.Channel.cuadro(lado1, lado2);
        }
        
        public System.Threading.Tasks.Task<decimal> cuadroAsync(decimal lado1, decimal lado2) {
            return base.Channel.cuadroAsync(lado1, lado2);
        }
        
        public decimal triangulo(decimal base1, decimal altura2) {
            return base.Channel.triangulo(base1, altura2);
        }
        
        public System.Threading.Tasks.Task<decimal> trianguloAsync(decimal base1, decimal altura2) {
            return base.Channel.trianguloAsync(base1, altura2);
        }
        
        public double circulo(double radio) {
            return base.Channel.circulo(radio);
        }
        
        public System.Threading.Tasks.Task<double> circuloAsync(double radio) {
            return base.Channel.circuloAsync(radio);
        }
    }
}
