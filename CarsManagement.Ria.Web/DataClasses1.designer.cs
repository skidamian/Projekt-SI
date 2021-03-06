﻿#pragma warning disable 1591
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
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="baza1")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertprodukty(produkty instance);
    partial void Updateprodukty(produkty instance);
    partial void Deleteprodukty(produkty instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::CarsManagement.Ria.Web.Properties.Settings.Default.baza1ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<produkty> produkties
		{
			get
			{
				return this.GetTable<produkty>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.produkty")]
	public partial class produkty : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ID_produktu;
		
		private string _nazwa;
		
		private string _producent;
		
		private string _info;
		
		private System.Nullable<decimal> _cena;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnID_produktuChanging(string value);
    partial void OnID_produktuChanged();
    partial void OnnazwaChanging(string value);
    partial void OnnazwaChanged();
    partial void OnproducentChanging(string value);
    partial void OnproducentChanged();
    partial void OninfoChanging(string value);
    partial void OninfoChanged();
    partial void OncenaChanging(System.Nullable<decimal> value);
    partial void OncenaChanged();
    #endregion
		
		public produkty()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_produktu", DbType="VarChar(7) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ID_produktu
		{
			get
			{
				return this._ID_produktu;
			}
			set
			{
				if ((this._ID_produktu != value))
				{
					this.OnID_produktuChanging(value);
					this.SendPropertyChanging();
					this._ID_produktu = value;
					this.SendPropertyChanged("ID_produktu");
					this.OnID_produktuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nazwa", DbType="VarChar(50)")]
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
					this.SendPropertyChanging();
					this._nazwa = value;
					this.SendPropertyChanged("nazwa");
					this.OnnazwaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_producent", DbType="VarChar(50)")]
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
					this.SendPropertyChanging();
					this._producent = value;
					this.SendPropertyChanged("producent");
					this.OnproducentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_info", DbType="VarChar(200)")]
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
					this.SendPropertyChanging();
					this._info = value;
					this.SendPropertyChanged("info");
					this.OninfoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cena", DbType="Money")]
		public System.Nullable<decimal> cena
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
					this.SendPropertyChanging();
					this._cena = value;
					this.SendPropertyChanged("cena");
					this.OncenaChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
