//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.237
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarsManagement.Ria.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using System.ServiceModel.DomainServices;
    using System.ServiceModel.DomainServices.Client;
    using System.ServiceModel.DomainServices.Client.ApplicationServices;
    using System.ServiceModel.Web;
    
    
    /// <summary>
    /// The DomainContext corresponding to the 'DomainService1' DomainService.
    /// </summary>
    public sealed partial class DomainService1 : DomainContext
    {
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainService1"/> class.
        /// </summary>
        public DomainService1() : 
                this(new WebDomainClient<IDomainService1Contract>(new Uri("CarsManagement-Ria-Web-DomainService1.svc", UriKind.Relative)))
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainService1"/> class with the specified service URI.
        /// </summary>
        /// <param name="serviceUri">The DomainService1 service URI.</param>
        public DomainService1(Uri serviceUri) : 
                this(new WebDomainClient<IDomainService1Contract>(serviceUri))
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainService1"/> class with the specified <paramref name="domainClient"/>.
        /// </summary>
        /// <param name="domainClient">The DomainClient instance to use for this DomainContext.</param>
        public DomainService1(DomainClient domainClient) : 
                base(domainClient)
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets the set of <see cref="produkty"/> entity instances that have been loaded into this <see cref="DomainService1"/> instance.
        /// </summary>
        public EntitySet<produkty> produkties
        {
            get
            {
                return base.EntityContainer.GetEntitySet<produkty>();
            }
        }
        
        /// <summary>
        /// Gets an EntityQuery instance that can be used to load <see cref="produkty"/> entity instances using the 'GetProdukties' query.
        /// </summary>
        /// <returns>An EntityQuery that can be loaded to retrieve <see cref="produkty"/> entity instances.</returns>
        public EntityQuery<produkty> GetProduktiesQuery()
        {
            this.ValidateMethod("GetProduktiesQuery", null);
            return base.CreateQuery<produkty>("GetProdukties", null, false, true);
        }
        
        /// <summary>
        /// Creates a new EntityContainer for this DomainContext's EntitySets.
        /// </summary>
        /// <returns>A new container instance.</returns>
        protected override EntityContainer CreateEntityContainer()
        {
            return new DomainService1EntityContainer();
        }
        
        /// <summary>
        /// Service contract for the 'DomainService1' DomainService.
        /// </summary>
        [ServiceContract()]
        public interface IDomainService1Contract
        {
            
            /// <summary>
            /// Asynchronously invokes the 'GetProdukties' operation.
            /// </summary>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [FaultContract(typeof(DomainServiceFault), Action="http://tempuri.org/DomainService1/GetProduktiesDomainServiceFault", Name="DomainServiceFault", Namespace="DomainServices")]
            [OperationContract(AsyncPattern=true, Action="http://tempuri.org/DomainService1/GetProdukties", ReplyAction="http://tempuri.org/DomainService1/GetProduktiesResponse")]
            [WebGet()]
            IAsyncResult BeginGetProdukties(AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginGetProdukties'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginGetProdukties'.</param>
            /// <returns>The 'QueryResult' returned from the 'GetProdukties' operation.</returns>
            QueryResult<produkty> EndGetProdukties(IAsyncResult result);
        }
        
        internal sealed class DomainService1EntityContainer : EntityContainer
        {
            
            public DomainService1EntityContainer()
            {
                this.CreateEntitySet<produkty>(EntitySetOperations.None);
            }
        }
    }
    
    /// <summary>
    /// The 'produkty' entity class.
    /// </summary>
    [DataContract(Namespace="http://schemas.datacontract.org/2004/07/CarsManagement.Ria.Web")]
    public sealed partial class produkty : Entity
    {
        
        private Nullable<decimal> _cena;
        
        private string _id_produktu;
        
        private string _info;
        
        private string _nazwa;
        
        private string _producent;
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();
        partial void OncenaChanging(Nullable<decimal> value);
        partial void OncenaChanged();
        partial void OnID_produktuChanging(string value);
        partial void OnID_produktuChanged();
        partial void OninfoChanging(string value);
        partial void OninfoChanged();
        partial void OnnazwaChanging(string value);
        partial void OnnazwaChanged();
        partial void OnproducentChanging(string value);
        partial void OnproducentChanged();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="produkty"/> class.
        /// </summary>
        public produkty()
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets or sets the 'cena' value.
        /// </summary>
        [ConcurrencyCheck()]
        [DataMember()]
        [RoundtripOriginal()]
        public Nullable<decimal> cena
        {
            get
            {
                return this._cena;
            }
            set
            {
                if ((this._cena != value))
                {
                    this.OncenaChanging(value);
                    this.RaiseDataMemberChanging("cena");
                    this.ValidateProperty("cena", value);
                    this._cena = value;
                    this.RaiseDataMemberChanged("cena");
                    this.OncenaChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'ID_produktu' value.
        /// </summary>
        [ConcurrencyCheck()]
        [DataMember()]
        [Editable(false, AllowInitialValue=true)]
        [Key()]
        [Required()]
        [RoundtripOriginal()]
        [StringLength(7)]
        public string ID_produktu
        {
            get
            {
                return this._id_produktu;
            }
            set
            {
                if ((this._id_produktu != value))
                {
                    this.OnID_produktuChanging(value);
                    this.ValidateProperty("ID_produktu", value);
                    this._id_produktu = value;
                    this.RaisePropertyChanged("ID_produktu");
                    this.OnID_produktuChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'info' value.
        /// </summary>
        [ConcurrencyCheck()]
        [DataMember()]
        [RoundtripOriginal()]
        [StringLength(200)]
        public string info
        {
            get
            {
                return this._info;
            }
            set
            {
                if ((this._info != value))
                {
                    this.OninfoChanging(value);
                    this.RaiseDataMemberChanging("info");
                    this.ValidateProperty("info", value);
                    this._info = value;
                    this.RaiseDataMemberChanged("info");
                    this.OninfoChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'nazwa' value.
        /// </summary>
        [ConcurrencyCheck()]
        [DataMember()]
        [RoundtripOriginal()]
        [StringLength(50)]
        public string nazwa
        {
            get
            {
                return this._nazwa;
            }
            set
            {
                if ((this._nazwa != value))
                {
                    this.OnnazwaChanging(value);
                    this.RaiseDataMemberChanging("nazwa");
                    this.ValidateProperty("nazwa", value);
                    this._nazwa = value;
                    this.RaiseDataMemberChanged("nazwa");
                    this.OnnazwaChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'producent' value.
        /// </summary>
        [ConcurrencyCheck()]
        [DataMember()]
        [RoundtripOriginal()]
        [StringLength(50)]
        public string producent
        {
            get
            {
                return this._producent;
            }
            set
            {
                if ((this._producent != value))
                {
                    this.OnproducentChanging(value);
                    this.RaiseDataMemberChanging("producent");
                    this.ValidateProperty("producent", value);
                    this._producent = value;
                    this.RaiseDataMemberChanged("producent");
                    this.OnproducentChanged();
                }
            }
        }
        
        /// <summary>
        /// Computes a value from the key fields that uniquely identifies this entity instance.
        /// </summary>
        /// <returns>An object instance that uniquely identifies this entity instance.</returns>
        public override object GetIdentity()
        {
            return this._id_produktu;
        }
    }
}
namespace Shell
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices;
    using System.ServiceModel.DomainServices.Client;
    using System.ServiceModel.DomainServices.Client.ApplicationServices;
    
    
    /// <summary>
    /// Context for the RIA application.
    /// </summary>
    /// <remarks>
    /// This context extends the base to make application services and types available
    /// for consumption from code and xaml.
    /// </remarks>
    public sealed partial class WebContext : WebContextBase
    {
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the WebContext class.
        /// </summary>
        public WebContext()
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets the context that is registered as a lifetime object with the current application.
        /// </summary>
        /// <exception cref="InvalidOperationException"> is thrown if there is no current application,
        /// no contexts have been added, or more than one context has been added.
        /// </exception>
        /// <seealso cref="System.Windows.Application.ApplicationLifetimeObjects"/>
        public new static WebContext Current
        {
            get
            {
                return ((WebContext)(WebContextBase.Current));
            }
        }
    }
}