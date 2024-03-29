﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectCShaft
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ProjectCShaft")]
	public partial class ProjectCShaftDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAccount(Account instance);
    partial void UpdateAccount(Account instance);
    partial void DeleteAccount(Account instance);
    partial void InsertMenu(Menu instance);
    partial void UpdateMenu(Menu instance);
    partial void DeleteMenu(Menu instance);
    partial void InsertTable_Bida(Table_Bida instance);
    partial void UpdateTable_Bida(Table_Bida instance);
    partial void DeleteTable_Bida(Table_Bida instance);
    partial void InsertOrder_Table(Order_Table instance);
    partial void UpdateOrder_Table(Order_Table instance);
    partial void DeleteOrder_Table(Order_Table instance);
    partial void InsertOrderMenu(OrderMenu instance);
    partial void UpdateOrderMenu(OrderMenu instance);
    partial void DeleteOrderMenu(OrderMenu instance);
    #endregion
		
		public ProjectCShaftDataContext() : 
				base(global::ProjectCShaft.Properties.Settings.Default.ProjectCShaftConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ProjectCShaftDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProjectCShaftDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProjectCShaftDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProjectCShaftDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Account> Accounts
		{
			get
			{
				return this.GetTable<Account>();
			}
		}
		
		public System.Data.Linq.Table<Menu> Menus
		{
			get
			{
				return this.GetTable<Menu>();
			}
		}
		
		public System.Data.Linq.Table<Table_Bida> Table_Bidas
		{
			get
			{
				return this.GetTable<Table_Bida>();
			}
		}
		
		public System.Data.Linq.Table<Order_Table> Order_Tables
		{
			get
			{
				return this.GetTable<Order_Table>();
			}
		}
		
		public System.Data.Linq.Table<OrderMenu> OrderMenus
		{
			get
			{
				return this.GetTable<OrderMenu>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Account")]
	public partial class Account : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _username;
		
		private string _password;
		
		private System.Nullable<bool> _status;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void OnstatusChanging(System.Nullable<bool> value);
    partial void OnstatusChanged();
    #endregion
		
		public Account()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="Bit")]
		public System.Nullable<bool> status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Menu")]
	public partial class Menu : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idMenu;
		
		private string _nameMenu;
		
		private string _unitMenu;
		
		private System.Nullable<double> _priceMenu;
		
		private string _descriptionMenu;
		
		private System.Nullable<bool> _status;
		
		private EntitySet<OrderMenu> _OrderMenus;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidMenuChanging(int value);
    partial void OnidMenuChanged();
    partial void OnnameMenuChanging(string value);
    partial void OnnameMenuChanged();
    partial void OnunitMenuChanging(string value);
    partial void OnunitMenuChanged();
    partial void OnpriceMenuChanging(System.Nullable<double> value);
    partial void OnpriceMenuChanged();
    partial void OndescriptionMenuChanging(string value);
    partial void OndescriptionMenuChanged();
    partial void OnstatusChanging(System.Nullable<bool> value);
    partial void OnstatusChanged();
    #endregion
		
		public Menu()
		{
			this._OrderMenus = new EntitySet<OrderMenu>(new Action<OrderMenu>(this.attach_OrderMenus), new Action<OrderMenu>(this.detach_OrderMenus));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idMenu", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idMenu
		{
			get
			{
				return this._idMenu;
			}
			set
			{
				if ((this._idMenu != value))
				{
					this.OnidMenuChanging(value);
					this.SendPropertyChanging();
					this._idMenu = value;
					this.SendPropertyChanged("idMenu");
					this.OnidMenuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nameMenu", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string nameMenu
		{
			get
			{
				return this._nameMenu;
			}
			set
			{
				if ((this._nameMenu != value))
				{
					this.OnnameMenuChanging(value);
					this.SendPropertyChanging();
					this._nameMenu = value;
					this.SendPropertyChanged("nameMenu");
					this.OnnameMenuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_unitMenu", DbType="NVarChar(20)")]
		public string unitMenu
		{
			get
			{
				return this._unitMenu;
			}
			set
			{
				if ((this._unitMenu != value))
				{
					this.OnunitMenuChanging(value);
					this.SendPropertyChanging();
					this._unitMenu = value;
					this.SendPropertyChanged("unitMenu");
					this.OnunitMenuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_priceMenu", DbType="Float")]
		public System.Nullable<double> priceMenu
		{
			get
			{
				return this._priceMenu;
			}
			set
			{
				if ((this._priceMenu != value))
				{
					this.OnpriceMenuChanging(value);
					this.SendPropertyChanging();
					this._priceMenu = value;
					this.SendPropertyChanged("priceMenu");
					this.OnpriceMenuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_descriptionMenu", DbType="NVarChar(255)")]
		public string descriptionMenu
		{
			get
			{
				return this._descriptionMenu;
			}
			set
			{
				if ((this._descriptionMenu != value))
				{
					this.OndescriptionMenuChanging(value);
					this.SendPropertyChanging();
					this._descriptionMenu = value;
					this.SendPropertyChanged("descriptionMenu");
					this.OndescriptionMenuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="Bit")]
		public System.Nullable<bool> status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Menu_OrderMenu", Storage="_OrderMenus", ThisKey="idMenu", OtherKey="idMenuOrder")]
		public EntitySet<OrderMenu> OrderMenus
		{
			get
			{
				return this._OrderMenus;
			}
			set
			{
				this._OrderMenus.Assign(value);
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
		
		private void attach_OrderMenus(OrderMenu entity)
		{
			this.SendPropertyChanging();
			entity.Menu = this;
		}
		
		private void detach_OrderMenus(OrderMenu entity)
		{
			this.SendPropertyChanging();
			entity.Menu = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Table_Bida")]
	public partial class Table_Bida : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idTable;
		
		private string _nameTable;
		
		private string _typeTable;
		
		private double _priceTable;
		
		private System.Nullable<bool> _statusTable;
		
		private string _description;
		
		private EntitySet<Order_Table> _Order_Tables;
		
		private EntitySet<OrderMenu> _OrderMenus;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidTableChanging(int value);
    partial void OnidTableChanged();
    partial void OnnameTableChanging(string value);
    partial void OnnameTableChanged();
    partial void OntypeTableChanging(string value);
    partial void OntypeTableChanged();
    partial void OnpriceTableChanging(double value);
    partial void OnpriceTableChanged();
    partial void OnstatusTableChanging(System.Nullable<bool> value);
    partial void OnstatusTableChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    #endregion
		
		public Table_Bida()
		{
			this._Order_Tables = new EntitySet<Order_Table>(new Action<Order_Table>(this.attach_Order_Tables), new Action<Order_Table>(this.detach_Order_Tables));
			this._OrderMenus = new EntitySet<OrderMenu>(new Action<OrderMenu>(this.attach_OrderMenus), new Action<OrderMenu>(this.detach_OrderMenus));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idTable", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idTable
		{
			get
			{
				return this._idTable;
			}
			set
			{
				if ((this._idTable != value))
				{
					this.OnidTableChanging(value);
					this.SendPropertyChanging();
					this._idTable = value;
					this.SendPropertyChanged("idTable");
					this.OnidTableChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nameTable", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string nameTable
		{
			get
			{
				return this._nameTable;
			}
			set
			{
				if ((this._nameTable != value))
				{
					this.OnnameTableChanging(value);
					this.SendPropertyChanging();
					this._nameTable = value;
					this.SendPropertyChanged("nameTable");
					this.OnnameTableChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_typeTable", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string typeTable
		{
			get
			{
				return this._typeTable;
			}
			set
			{
				if ((this._typeTable != value))
				{
					this.OntypeTableChanging(value);
					this.SendPropertyChanging();
					this._typeTable = value;
					this.SendPropertyChanged("typeTable");
					this.OntypeTableChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_priceTable", DbType="Float NOT NULL")]
		public double priceTable
		{
			get
			{
				return this._priceTable;
			}
			set
			{
				if ((this._priceTable != value))
				{
					this.OnpriceTableChanging(value);
					this.SendPropertyChanging();
					this._priceTable = value;
					this.SendPropertyChanged("priceTable");
					this.OnpriceTableChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_statusTable", DbType="Bit")]
		public System.Nullable<bool> statusTable
		{
			get
			{
				return this._statusTable;
			}
			set
			{
				if ((this._statusTable != value))
				{
					this.OnstatusTableChanging(value);
					this.SendPropertyChanging();
					this._statusTable = value;
					this.SendPropertyChanged("statusTable");
					this.OnstatusTableChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="NVarChar(255)")]
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this.OndescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("description");
					this.OndescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Table_Bida_Order_Table", Storage="_Order_Tables", ThisKey="idTable", OtherKey="idTable")]
		public EntitySet<Order_Table> Order_Tables
		{
			get
			{
				return this._Order_Tables;
			}
			set
			{
				this._Order_Tables.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Table_Bida_OrderMenu", Storage="_OrderMenus", ThisKey="idTable", OtherKey="idTable")]
		public EntitySet<OrderMenu> OrderMenus
		{
			get
			{
				return this._OrderMenus;
			}
			set
			{
				this._OrderMenus.Assign(value);
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
		
		private void attach_Order_Tables(Order_Table entity)
		{
			this.SendPropertyChanging();
			entity.Table_Bida = this;
		}
		
		private void detach_Order_Tables(Order_Table entity)
		{
			this.SendPropertyChanging();
			entity.Table_Bida = null;
		}
		
		private void attach_OrderMenus(OrderMenu entity)
		{
			this.SendPropertyChanging();
			entity.Table_Bida = this;
		}
		
		private void detach_OrderMenus(OrderMenu entity)
		{
			this.SendPropertyChanging();
			entity.Table_Bida = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Order_Table")]
	public partial class Order_Table : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idOrder;
		
		private System.Nullable<int> _idTable;
		
		private System.Nullable<System.DateTime> _timeStart;
		
		private System.Nullable<System.DateTime> _timeEnd;
		
		private System.Nullable<double> _sumPriceTable;
		
		private System.Nullable<bool> _status;
		
		private EntitySet<OrderMenu> _OrderMenus;
		
		private EntityRef<Table_Bida> _Table_Bida;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidOrderChanging(int value);
    partial void OnidOrderChanged();
    partial void OnidTableChanging(System.Nullable<int> value);
    partial void OnidTableChanged();
    partial void OntimeStartChanging(System.Nullable<System.DateTime> value);
    partial void OntimeStartChanged();
    partial void OntimeEndChanging(System.Nullable<System.DateTime> value);
    partial void OntimeEndChanged();
    partial void OnsumPriceTableChanging(System.Nullable<double> value);
    partial void OnsumPriceTableChanged();
    partial void OnstatusChanging(System.Nullable<bool> value);
    partial void OnstatusChanged();
    #endregion
		
		public Order_Table()
		{
			this._OrderMenus = new EntitySet<OrderMenu>(new Action<OrderMenu>(this.attach_OrderMenus), new Action<OrderMenu>(this.detach_OrderMenus));
			this._Table_Bida = default(EntityRef<Table_Bida>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idOrder", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idOrder
		{
			get
			{
				return this._idOrder;
			}
			set
			{
				if ((this._idOrder != value))
				{
					this.OnidOrderChanging(value);
					this.SendPropertyChanging();
					this._idOrder = value;
					this.SendPropertyChanged("idOrder");
					this.OnidOrderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idTable", DbType="Int")]
		public System.Nullable<int> idTable
		{
			get
			{
				return this._idTable;
			}
			set
			{
				if ((this._idTable != value))
				{
					if (this._Table_Bida.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidTableChanging(value);
					this.SendPropertyChanging();
					this._idTable = value;
					this.SendPropertyChanged("idTable");
					this.OnidTableChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_timeStart", DbType="DateTime")]
		public System.Nullable<System.DateTime> timeStart
		{
			get
			{
				return this._timeStart;
			}
			set
			{
				if ((this._timeStart != value))
				{
					this.OntimeStartChanging(value);
					this.SendPropertyChanging();
					this._timeStart = value;
					this.SendPropertyChanged("timeStart");
					this.OntimeStartChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_timeEnd", DbType="DateTime")]
		public System.Nullable<System.DateTime> timeEnd
		{
			get
			{
				return this._timeEnd;
			}
			set
			{
				if ((this._timeEnd != value))
				{
					this.OntimeEndChanging(value);
					this.SendPropertyChanging();
					this._timeEnd = value;
					this.SendPropertyChanged("timeEnd");
					this.OntimeEndChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sumPriceTable", DbType="Float")]
		public System.Nullable<double> sumPriceTable
		{
			get
			{
				return this._sumPriceTable;
			}
			set
			{
				if ((this._sumPriceTable != value))
				{
					this.OnsumPriceTableChanging(value);
					this.SendPropertyChanging();
					this._sumPriceTable = value;
					this.SendPropertyChanged("sumPriceTable");
					this.OnsumPriceTableChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="Bit")]
		public System.Nullable<bool> status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Order_Table_OrderMenu", Storage="_OrderMenus", ThisKey="idOrder", OtherKey="idOrder")]
		public EntitySet<OrderMenu> OrderMenus
		{
			get
			{
				return this._OrderMenus;
			}
			set
			{
				this._OrderMenus.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Table_Bida_Order_Table", Storage="_Table_Bida", ThisKey="idTable", OtherKey="idTable", IsForeignKey=true)]
		public Table_Bida Table_Bida
		{
			get
			{
				return this._Table_Bida.Entity;
			}
			set
			{
				Table_Bida previousValue = this._Table_Bida.Entity;
				if (((previousValue != value) 
							|| (this._Table_Bida.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Table_Bida.Entity = null;
						previousValue.Order_Tables.Remove(this);
					}
					this._Table_Bida.Entity = value;
					if ((value != null))
					{
						value.Order_Tables.Add(this);
						this._idTable = value.idTable;
					}
					else
					{
						this._idTable = default(Nullable<int>);
					}
					this.SendPropertyChanged("Table_Bida");
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
		
		private void attach_OrderMenus(OrderMenu entity)
		{
			this.SendPropertyChanging();
			entity.Order_Table = this;
		}
		
		private void detach_OrderMenus(OrderMenu entity)
		{
			this.SendPropertyChanging();
			entity.Order_Table = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.OrderMenu")]
	public partial class OrderMenu : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idOrderMenu;
		
		private int _idTable;
		
		private int _idMenuOrder;
		
		private int _idOrder;
		
		private string _nameMenuOrder;
		
		private string _unitMenuOrder;
		
		private System.Nullable<double> _priceMenuOrder;
		
		private System.Nullable<int> _quantity;
		
		private System.Nullable<double> _sumPrice;
		
		private EntityRef<Menu> _Menu;
		
		private EntityRef<Order_Table> _Order_Table;
		
		private EntityRef<Table_Bida> _Table_Bida;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidOrderMenuChanging(int value);
    partial void OnidOrderMenuChanged();
    partial void OnidTableChanging(int value);
    partial void OnidTableChanged();
    partial void OnidMenuOrderChanging(int value);
    partial void OnidMenuOrderChanged();
    partial void OnidOrderChanging(int value);
    partial void OnidOrderChanged();
    partial void OnnameMenuOrderChanging(string value);
    partial void OnnameMenuOrderChanged();
    partial void OnunitMenuOrderChanging(string value);
    partial void OnunitMenuOrderChanged();
    partial void OnpriceMenuOrderChanging(System.Nullable<double> value);
    partial void OnpriceMenuOrderChanged();
    partial void OnquantityChanging(System.Nullable<int> value);
    partial void OnquantityChanged();
    partial void OnsumPriceChanging(System.Nullable<double> value);
    partial void OnsumPriceChanged();
    #endregion
		
		public OrderMenu()
		{
			this._Menu = default(EntityRef<Menu>);
			this._Order_Table = default(EntityRef<Order_Table>);
			this._Table_Bida = default(EntityRef<Table_Bida>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idOrderMenu", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idOrderMenu
		{
			get
			{
				return this._idOrderMenu;
			}
			set
			{
				if ((this._idOrderMenu != value))
				{
					this.OnidOrderMenuChanging(value);
					this.SendPropertyChanging();
					this._idOrderMenu = value;
					this.SendPropertyChanged("idOrderMenu");
					this.OnidOrderMenuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idTable", DbType="Int NOT NULL")]
		public int idTable
		{
			get
			{
				return this._idTable;
			}
			set
			{
				if ((this._idTable != value))
				{
					if (this._Table_Bida.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidTableChanging(value);
					this.SendPropertyChanging();
					this._idTable = value;
					this.SendPropertyChanged("idTable");
					this.OnidTableChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idMenuOrder", DbType="Int NOT NULL")]
		public int idMenuOrder
		{
			get
			{
				return this._idMenuOrder;
			}
			set
			{
				if ((this._idMenuOrder != value))
				{
					if (this._Menu.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidMenuOrderChanging(value);
					this.SendPropertyChanging();
					this._idMenuOrder = value;
					this.SendPropertyChanged("idMenuOrder");
					this.OnidMenuOrderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idOrder", DbType="Int NOT NULL")]
		public int idOrder
		{
			get
			{
				return this._idOrder;
			}
			set
			{
				if ((this._idOrder != value))
				{
					if (this._Order_Table.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidOrderChanging(value);
					this.SendPropertyChanging();
					this._idOrder = value;
					this.SendPropertyChanged("idOrder");
					this.OnidOrderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nameMenuOrder", DbType="NVarChar(100)")]
		public string nameMenuOrder
		{
			get
			{
				return this._nameMenuOrder;
			}
			set
			{
				if ((this._nameMenuOrder != value))
				{
					this.OnnameMenuOrderChanging(value);
					this.SendPropertyChanging();
					this._nameMenuOrder = value;
					this.SendPropertyChanged("nameMenuOrder");
					this.OnnameMenuOrderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_unitMenuOrder", DbType="NVarChar(20)")]
		public string unitMenuOrder
		{
			get
			{
				return this._unitMenuOrder;
			}
			set
			{
				if ((this._unitMenuOrder != value))
				{
					this.OnunitMenuOrderChanging(value);
					this.SendPropertyChanging();
					this._unitMenuOrder = value;
					this.SendPropertyChanged("unitMenuOrder");
					this.OnunitMenuOrderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_priceMenuOrder", DbType="Float")]
		public System.Nullable<double> priceMenuOrder
		{
			get
			{
				return this._priceMenuOrder;
			}
			set
			{
				if ((this._priceMenuOrder != value))
				{
					this.OnpriceMenuOrderChanging(value);
					this.SendPropertyChanging();
					this._priceMenuOrder = value;
					this.SendPropertyChanged("priceMenuOrder");
					this.OnpriceMenuOrderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_quantity", DbType="Int")]
		public System.Nullable<int> quantity
		{
			get
			{
				return this._quantity;
			}
			set
			{
				if ((this._quantity != value))
				{
					this.OnquantityChanging(value);
					this.SendPropertyChanging();
					this._quantity = value;
					this.SendPropertyChanged("quantity");
					this.OnquantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sumPrice", DbType="Float")]
		public System.Nullable<double> sumPrice
		{
			get
			{
				return this._sumPrice;
			}
			set
			{
				if ((this._sumPrice != value))
				{
					this.OnsumPriceChanging(value);
					this.SendPropertyChanging();
					this._sumPrice = value;
					this.SendPropertyChanged("sumPrice");
					this.OnsumPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Menu_OrderMenu", Storage="_Menu", ThisKey="idMenuOrder", OtherKey="idMenu", IsForeignKey=true)]
		public Menu Menu
		{
			get
			{
				return this._Menu.Entity;
			}
			set
			{
				Menu previousValue = this._Menu.Entity;
				if (((previousValue != value) 
							|| (this._Menu.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Menu.Entity = null;
						previousValue.OrderMenus.Remove(this);
					}
					this._Menu.Entity = value;
					if ((value != null))
					{
						value.OrderMenus.Add(this);
						this._idMenuOrder = value.idMenu;
					}
					else
					{
						this._idMenuOrder = default(int);
					}
					this.SendPropertyChanged("Menu");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Order_Table_OrderMenu", Storage="_Order_Table", ThisKey="idOrder", OtherKey="idOrder", IsForeignKey=true)]
		public Order_Table Order_Table
		{
			get
			{
				return this._Order_Table.Entity;
			}
			set
			{
				Order_Table previousValue = this._Order_Table.Entity;
				if (((previousValue != value) 
							|| (this._Order_Table.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Order_Table.Entity = null;
						previousValue.OrderMenus.Remove(this);
					}
					this._Order_Table.Entity = value;
					if ((value != null))
					{
						value.OrderMenus.Add(this);
						this._idOrder = value.idOrder;
					}
					else
					{
						this._idOrder = default(int);
					}
					this.SendPropertyChanged("Order_Table");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Table_Bida_OrderMenu", Storage="_Table_Bida", ThisKey="idTable", OtherKey="idTable", IsForeignKey=true)]
		public Table_Bida Table_Bida
		{
			get
			{
				return this._Table_Bida.Entity;
			}
			set
			{
				Table_Bida previousValue = this._Table_Bida.Entity;
				if (((previousValue != value) 
							|| (this._Table_Bida.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Table_Bida.Entity = null;
						previousValue.OrderMenus.Remove(this);
					}
					this._Table_Bida.Entity = value;
					if ((value != null))
					{
						value.OrderMenus.Add(this);
						this._idTable = value.idTable;
					}
					else
					{
						this._idTable = default(int);
					}
					this.SendPropertyChanged("Table_Bida");
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
