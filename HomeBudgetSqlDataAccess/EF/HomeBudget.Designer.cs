﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("HomeBudget", "AccountReceipt", "Account", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(HomeBudget.SqlDataAccess.EF.Account), "Receipt", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HomeBudget.SqlDataAccess.EF.Receipt), true)]

#endregion

namespace HomeBudget.SqlDataAccess.EF
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class HomeBudgetContainer : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new HomeBudgetContainer object using the connection string found in the 'HomeBudgetContainer' section of the application configuration file.
        /// </summary>
        public HomeBudgetContainer() : base("name=HomeBudgetContainer", "HomeBudgetContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new HomeBudgetContainer object.
        /// </summary>
        public HomeBudgetContainer(string connectionString) : base(connectionString, "HomeBudgetContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new HomeBudgetContainer object.
        /// </summary>
        public HomeBudgetContainer(EntityConnection connection) : base(connection, "HomeBudgetContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Account> Accounts
        {
            get
            {
                if ((_Accounts == null))
                {
                    _Accounts = base.CreateObjectSet<Account>("Accounts");
                }
                return _Accounts;
            }
        }
        private ObjectSet<Account> _Accounts;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Receipt> Receipts
        {
            get
            {
                if ((_Receipts == null))
                {
                    _Receipts = base.CreateObjectSet<Receipt>("Receipts");
                }
                return _Receipts;
            }
        }
        private ObjectSet<Receipt> _Receipts;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Accounts EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToAccounts(Account account)
        {
            base.AddObject("Accounts", account);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Receipts EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToReceipts(Receipt receipt)
        {
            base.AddObject("Receipts", receipt);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="HomeBudget", Name="Account")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Account : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Account object.
        /// </summary>
        /// <param name="accountId">Initial value of the AccountId property.</param>
        /// <param name="accountName">Initial value of the AccountName property.</param>
        public static Account CreateAccount(global::System.Int64 accountId, global::System.String accountName)
        {
            Account account = new Account();
            account.AccountId = accountId;
            account.AccountName = accountName;
            return account;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 AccountId
        {
            get
            {
                return _AccountId;
            }
            set
            {
                if (_AccountId != value)
                {
                    OnAccountIdChanging(value);
                    ReportPropertyChanging("AccountId");
                    _AccountId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("AccountId");
                    OnAccountIdChanged();
                }
            }
        }
        private global::System.Int64 _AccountId;
        partial void OnAccountIdChanging(global::System.Int64 value);
        partial void OnAccountIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String AccountName
        {
            get
            {
                return _AccountName;
            }
            set
            {
                OnAccountNameChanging(value);
                ReportPropertyChanging("AccountName");
                _AccountName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("AccountName");
                OnAccountNameChanged();
            }
        }
        private global::System.String _AccountName;
        partial void OnAccountNameChanging(global::System.String value);
        partial void OnAccountNameChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("HomeBudget", "AccountReceipt", "Receipt")]
        public EntityCollection<Receipt> Receipts
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Receipt>("HomeBudget.AccountReceipt", "Receipt");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Receipt>("HomeBudget.AccountReceipt", "Receipt", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="HomeBudget", Name="Receipt")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Receipt : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Receipt object.
        /// </summary>
        /// <param name="receiptId">Initial value of the ReceiptId property.</param>
        /// <param name="amount">Initial value of the Amount property.</param>
        /// <param name="description">Initial value of the Description property.</param>
        /// <param name="accountAccountId">Initial value of the AccountAccountId property.</param>
        public static Receipt CreateReceipt(global::System.Int64 receiptId, global::System.Decimal amount, global::System.String description, global::System.Int64 accountAccountId)
        {
            Receipt receipt = new Receipt();
            receipt.ReceiptId = receiptId;
            receipt.Amount = amount;
            receipt.Description = description;
            receipt.AccountAccountId = accountAccountId;
            return receipt;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 ReceiptId
        {
            get
            {
                return _ReceiptId;
            }
            set
            {
                if (_ReceiptId != value)
                {
                    OnReceiptIdChanging(value);
                    ReportPropertyChanging("ReceiptId");
                    _ReceiptId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ReceiptId");
                    OnReceiptIdChanged();
                }
            }
        }
        private global::System.Int64 _ReceiptId;
        partial void OnReceiptIdChanging(global::System.Int64 value);
        partial void OnReceiptIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal Amount
        {
            get
            {
                return _Amount;
            }
            set
            {
                OnAmountChanging(value);
                ReportPropertyChanging("Amount");
                _Amount = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Amount");
                OnAmountChanged();
            }
        }
        private global::System.Decimal _Amount;
        partial void OnAmountChanging(global::System.Decimal value);
        partial void OnAmountChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 AccountAccountId
        {
            get
            {
                return _AccountAccountId;
            }
            set
            {
                OnAccountAccountIdChanging(value);
                ReportPropertyChanging("AccountAccountId");
                _AccountAccountId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("AccountAccountId");
                OnAccountAccountIdChanged();
            }
        }
        private global::System.Int64 _AccountAccountId;
        partial void OnAccountAccountIdChanging(global::System.Int64 value);
        partial void OnAccountAccountIdChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("HomeBudget", "AccountReceipt", "Account")]
        public Account Account
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Account>("HomeBudget.AccountReceipt", "Account").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Account>("HomeBudget.AccountReceipt", "Account").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Account> AccountReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Account>("HomeBudget.AccountReceipt", "Account");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Account>("HomeBudget.AccountReceipt", "Account", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
