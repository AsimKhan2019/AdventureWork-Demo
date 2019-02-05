namespace Jamuro.AdventureWorks.Data.Entities.Contexts
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AdventureWorksContext : DbContext
    {
        public AdventureWorksContext(string connectionString) : base(connectionString)
        {
        }

        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Employee_Temporal> Employee_Temporal { get; set; }
        public virtual DbSet<EmployeeDepartmentHistory> EmployeeDepartmentHistory { get; set; }
        public virtual DbSet<EmployeePayHistory> EmployeePayHistory { get; set; }
        public virtual DbSet<JobCandidate> JobCandidate { get; set; }
        public virtual DbSet<Shift> Shift { get; set; }
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<AddressType> AddressType { get; set; }
        public virtual DbSet<BusinessEntity> BusinessEntity { get; set; }
        public virtual DbSet<BusinessEntityAddress> BusinessEntityAddress { get; set; }
        public virtual DbSet<BusinessEntityContact> BusinessEntityContact { get; set; }
        public virtual DbSet<ContactType> ContactType { get; set; }
        public virtual DbSet<CountryRegion> CountryRegion { get; set; }
        public virtual DbSet<EmailAddress> EmailAddress { get; set; }
        public virtual DbSet<Password> Password { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Person_json> Person_json { get; set; }
        public virtual DbSet<Person_Temporal> Person_Temporal { get; set; }
        public virtual DbSet<PersonPhone> PersonPhone { get; set; }
        public virtual DbSet<PhoneNumberType> PhoneNumberType { get; set; }
        public virtual DbSet<StateProvince> StateProvince { get; set; }
        public virtual DbSet<BillOfMaterials> BillOfMaterials { get; set; }
        public virtual DbSet<Culture> Culture { get; set; }
        public virtual DbSet<Illustration> Illustration { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Product_inmem> Product_inmem { get; set; }
        public virtual DbSet<Product_ondisk> Product_ondisk { get; set; }
        public virtual DbSet<ProductCategory> ProductCategory { get; set; }
        public virtual DbSet<ProductCostHistory> ProductCostHistory { get; set; }
        public virtual DbSet<ProductDescription> ProductDescription { get; set; }
        public virtual DbSet<ProductInventory> ProductInventory { get; set; }
        public virtual DbSet<ProductListPriceHistory> ProductListPriceHistory { get; set; }
        public virtual DbSet<ProductModel> ProductModel { get; set; }
        public virtual DbSet<ProductModelIllustration> ProductModelIllustration { get; set; }
        public virtual DbSet<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCulture { get; set; }
        public virtual DbSet<ProductPhoto> ProductPhoto { get; set; }
        public virtual DbSet<ProductProductPhoto> ProductProductPhoto { get; set; }
        public virtual DbSet<ProductReview> ProductReview { get; set; }
        public virtual DbSet<ProductSubcategory> ProductSubcategory { get; set; }
        public virtual DbSet<ScrapReason> ScrapReason { get; set; }
        public virtual DbSet<TransactionHistory> TransactionHistory { get; set; }
        public virtual DbSet<TransactionHistoryArchive> TransactionHistoryArchive { get; set; }
        public virtual DbSet<UnitMeasure> UnitMeasure { get; set; }
        public virtual DbSet<WorkOrder> WorkOrder { get; set; }
        public virtual DbSet<WorkOrderRouting> WorkOrderRouting { get; set; }
        public virtual DbSet<ProductVendor> ProductVendor { get; set; }
        public virtual DbSet<PurchaseOrderDetail> PurchaseOrderDetail { get; set; }
        public virtual DbSet<PurchaseOrderHeader> PurchaseOrderHeader { get; set; }
        public virtual DbSet<ShipMethod> ShipMethod { get; set; }
        public virtual DbSet<Vendor> Vendor { get; set; }
        public virtual DbSet<CountryRegionCurrency> CountryRegionCurrency { get; set; }
        public virtual DbSet<CreditCard> CreditCard { get; set; }
        public virtual DbSet<Currency> Currency { get; set; }
        public virtual DbSet<CurrencyRate> CurrencyRate { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<OrderTracking> OrderTracking { get; set; }
        public virtual DbSet<PersonCreditCard> PersonCreditCard { get; set; }
        public virtual DbSet<SalesOrder_json> SalesOrder_json { get; set; }
        public virtual DbSet<SalesOrderDetail> SalesOrderDetail { get; set; }
        public virtual DbSet<SalesOrderDetail_inmem> SalesOrderDetail_inmem { get; set; }
        public virtual DbSet<SalesOrderDetail_ondisk> SalesOrderDetail_ondisk { get; set; }
        public virtual DbSet<SalesOrderHeader> SalesOrderHeader { get; set; }
        public virtual DbSet<SalesOrderHeader_inmem> SalesOrderHeader_inmem { get; set; }
        public virtual DbSet<SalesOrderHeader_ondisk> SalesOrderHeader_ondisk { get; set; }
        public virtual DbSet<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReason { get; set; }
        public virtual DbSet<SalesPerson> SalesPerson { get; set; }
        public virtual DbSet<SalesPersonQuotaHistory> SalesPersonQuotaHistory { get; set; }
        public virtual DbSet<SalesReason> SalesReason { get; set; }
        public virtual DbSet<SalesTaxRate> SalesTaxRate { get; set; }
        public virtual DbSet<SalesTerritory> SalesTerritory { get; set; }
        public virtual DbSet<SalesTerritoryHistory> SalesTerritoryHistory { get; set; }
        public virtual DbSet<ShoppingCartItem> ShoppingCartItem { get; set; }
        public virtual DbSet<SpecialOffer> SpecialOffer { get; set; }
        public virtual DbSet<SpecialOffer_inmem> SpecialOffer_inmem { get; set; }
        public virtual DbSet<SpecialOffer_ondisk> SpecialOffer_ondisk { get; set; }
        public virtual DbSet<SpecialOfferProduct> SpecialOfferProduct { get; set; }
        public virtual DbSet<SpecialOfferProduct_inmem> SpecialOfferProduct_inmem { get; set; }
        public virtual DbSet<SpecialOfferProduct_ondisk> SpecialOfferProduct_ondisk { get; set; }
        public virtual DbSet<Store> Store { get; set; }
        public virtual DbSet<TrackingEvent> TrackingEvent { get; set; }
        public virtual DbSet<Employee_Temporal_History> Employee_Temporal_History { get; set; }
        public virtual DbSet<Person_Temporal_History> Person_Temporal_History { get; set; }
        public virtual DbSet<ProductDocument> ProductDocument { get; set; }
        public virtual DbSet<CustomerPII> CustomerPII { get; set; }
        public virtual DbSet<vEmployee> vEmployee { get; set; }
        public virtual DbSet<vEmployeeDepartment> vEmployeeDepartment { get; set; }
        public virtual DbSet<vEmployeeDepartmentHistory> vEmployeeDepartmentHistory { get; set; }
        public virtual DbSet<vEmployeePersonTemporalInfo> vEmployeePersonTemporalInfo { get; set; }
        public virtual DbSet<vJobCandidate> vJobCandidate { get; set; }
        public virtual DbSet<vJobCandidateEducation> vJobCandidateEducation { get; set; }
        public virtual DbSet<vJobCandidateEmployment> vJobCandidateEmployment { get; set; }
        public virtual DbSet<vAdditionalContactInfo> vAdditionalContactInfo { get; set; }
        public virtual DbSet<vStateProvinceCountryRegion> vStateProvinceCountryRegion { get; set; }
        public virtual DbSet<vProductAndDescription> vProductAndDescription { get; set; }
        public virtual DbSet<vProductModelCatalogDescription> vProductModelCatalogDescription { get; set; }
        public virtual DbSet<vProductModelInstructions> vProductModelInstructions { get; set; }
        public virtual DbSet<vVendorWithAddresses> vVendorWithAddresses { get; set; }
        public virtual DbSet<vVendorWithContacts> vVendorWithContacts { get; set; }
        public virtual DbSet<vIndividualCustomer> vIndividualCustomer { get; set; }
        public virtual DbSet<vPersonDemographics> vPersonDemographics { get; set; }
        public virtual DbSet<vSalesPerson> vSalesPerson { get; set; }
        public virtual DbSet<vSalesPersonSalesByFiscalYears> vSalesPersonSalesByFiscalYears { get; set; }
        public virtual DbSet<vStoreWithAddresses> vStoreWithAddresses { get; set; }
        public virtual DbSet<vStoreWithContacts> vStoreWithContacts { get; set; }
        public virtual DbSet<vStoreWithDemographics> vStoreWithDemographics { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .HasMany(e => e.EmployeeDepartmentHistory)
                .WithRequired(e => e.Department)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.MaritalStatus)
                .IsFixedLength();

            modelBuilder.Entity<Employee>()
                .Property(e => e.Gender)
                .IsFixedLength();

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.EmployeeDepartmentHistory)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.EmployeePayHistory)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.PurchaseOrderHeader)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.EmployeeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasOptional(e => e.SalesPerson)
                .WithRequired(e => e.Employee);

            modelBuilder.Entity<Employee_Temporal>()
                .Property(e => e.MaritalStatus)
                .IsFixedLength();

            modelBuilder.Entity<Employee_Temporal>()
                .Property(e => e.Gender)
                .IsFixedLength();

            modelBuilder.Entity<EmployeePayHistory>()
                .Property(e => e.Rate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Shift>()
                .HasMany(e => e.EmployeeDepartmentHistory)
                .WithRequired(e => e.Shift)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Address>()
                .HasMany(e => e.BusinessEntityAddress)
                .WithRequired(e => e.Address)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Address>()
                .HasMany(e => e.SalesOrderHeader)
                .WithRequired(e => e.Address)
                .HasForeignKey(e => e.BillToAddressID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Address>()
                .HasMany(e => e.SalesOrderHeader1)
                .WithRequired(e => e.Address1)
                .HasForeignKey(e => e.ShipToAddressID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AddressType>()
                .HasMany(e => e.BusinessEntityAddress)
                .WithRequired(e => e.AddressType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BusinessEntity>()
                .HasMany(e => e.BusinessEntityAddress)
                .WithRequired(e => e.BusinessEntity)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BusinessEntity>()
                .HasMany(e => e.BusinessEntityContact)
                .WithRequired(e => e.BusinessEntity)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BusinessEntity>()
                .HasOptional(e => e.Person)
                .WithRequired(e => e.BusinessEntity);

            modelBuilder.Entity<BusinessEntity>()
                .HasOptional(e => e.Store)
                .WithRequired(e => e.BusinessEntity);

            modelBuilder.Entity<BusinessEntity>()
                .HasOptional(e => e.Vendor)
                .WithRequired(e => e.BusinessEntity);

            modelBuilder.Entity<ContactType>()
                .HasMany(e => e.BusinessEntityContact)
                .WithRequired(e => e.ContactType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CountryRegion>()
                .HasMany(e => e.CountryRegionCurrency)
                .WithRequired(e => e.CountryRegion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CountryRegion>()
                .HasMany(e => e.SalesTerritory)
                .WithRequired(e => e.CountryRegion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CountryRegion>()
                .HasMany(e => e.StateProvince)
                .WithRequired(e => e.CountryRegion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Password>()
                .Property(e => e.PasswordHash)
                .IsUnicode(false);

            modelBuilder.Entity<Password>()
                .Property(e => e.PasswordSalt)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.PersonType)
                .IsFixedLength();

            modelBuilder.Entity<Person>()
                .HasOptional(e => e.Employee)
                .WithRequired(e => e.Person);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.BusinessEntityContact)
                .WithRequired(e => e.Person)
                .HasForeignKey(e => e.PersonID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.EmailAddress)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasOptional(e => e.Password)
                .WithRequired(e => e.Person);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.Customer)
                .WithOptional(e => e.Person)
                .HasForeignKey(e => e.PersonID);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.PersonCreditCard)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.PersonPhone)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person_json>()
                .Property(e => e.PersonType)
                .IsFixedLength();

            modelBuilder.Entity<Person_Temporal>()
                .Property(e => e.PersonType)
                .IsFixedLength();

            modelBuilder.Entity<PhoneNumberType>()
                .HasMany(e => e.PersonPhone)
                .WithRequired(e => e.PhoneNumberType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StateProvince>()
                .Property(e => e.StateProvinceCode)
                .IsFixedLength();

            modelBuilder.Entity<StateProvince>()
                .HasMany(e => e.Address)
                .WithRequired(e => e.StateProvince)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StateProvince>()
                .HasMany(e => e.SalesTaxRate)
                .WithRequired(e => e.StateProvince)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BillOfMaterials>()
                .Property(e => e.UnitMeasureCode)
                .IsFixedLength();

            modelBuilder.Entity<BillOfMaterials>()
                .Property(e => e.PerAssemblyQty)
                .HasPrecision(8, 2);

            modelBuilder.Entity<Culture>()
                .Property(e => e.CultureID)
                .IsFixedLength();

            modelBuilder.Entity<Culture>()
                .HasMany(e => e.ProductModelProductDescriptionCulture)
                .WithRequired(e => e.Culture)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Illustration>()
                .HasMany(e => e.ProductModelIllustration)
                .WithRequired(e => e.Illustration)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.CostRate)
                .HasPrecision(10, 4);

            modelBuilder.Entity<Location>()
                .Property(e => e.Availability)
                .HasPrecision(8, 2);

            modelBuilder.Entity<Location>()
                .HasMany(e => e.ProductInventory)
                .WithRequired(e => e.Location)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Location>()
                .HasMany(e => e.WorkOrderRouting)
                .WithRequired(e => e.Location)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.StandardCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.ListPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.SizeUnitMeasureCode)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.WeightUnitMeasureCode)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.Weight)
                .HasPrecision(8, 2);

            modelBuilder.Entity<Product>()
                .Property(e => e.ProductLine)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.Class)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.Style)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .HasMany(e => e.BillOfMaterials)
                .WithRequired(e => e.Product)
                .HasForeignKey(e => e.ComponentID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.BillOfMaterials1)
                .WithOptional(e => e.Product1)
                .HasForeignKey(e => e.ProductAssemblyID);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductCostHistory)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasOptional(e => e.ProductDocument)
                .WithRequired(e => e.Product);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductInventory)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductListPriceHistory)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductProductPhoto)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductReview)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductVendor)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.PurchaseOrderDetail)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ShoppingCartItem)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.SpecialOfferProduct)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.TransactionHistory)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.WorkOrder)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product_inmem>()
                .Property(e => e.StandardCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product_inmem>()
                .Property(e => e.ListPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product_inmem>()
                .Property(e => e.SizeUnitMeasureCode)
                .IsFixedLength();

            modelBuilder.Entity<Product_inmem>()
                .Property(e => e.WeightUnitMeasureCode)
                .IsFixedLength();

            modelBuilder.Entity<Product_inmem>()
                .Property(e => e.Weight)
                .HasPrecision(8, 2);

            modelBuilder.Entity<Product_inmem>()
                .Property(e => e.ProductLine)
                .IsFixedLength();

            modelBuilder.Entity<Product_inmem>()
                .Property(e => e.Class)
                .IsFixedLength();

            modelBuilder.Entity<Product_inmem>()
                .Property(e => e.Style)
                .IsFixedLength();

            modelBuilder.Entity<Product_inmem>()
                .HasMany(e => e.SpecialOfferProduct_inmem)
                .WithRequired(e => e.Product_inmem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product_ondisk>()
                .Property(e => e.StandardCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product_ondisk>()
                .Property(e => e.ListPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product_ondisk>()
                .Property(e => e.SizeUnitMeasureCode)
                .IsFixedLength();

            modelBuilder.Entity<Product_ondisk>()
                .Property(e => e.WeightUnitMeasureCode)
                .IsFixedLength();

            modelBuilder.Entity<Product_ondisk>()
                .Property(e => e.Weight)
                .HasPrecision(8, 2);

            modelBuilder.Entity<Product_ondisk>()
                .Property(e => e.ProductLine)
                .IsFixedLength();

            modelBuilder.Entity<Product_ondisk>()
                .Property(e => e.Class)
                .IsFixedLength();

            modelBuilder.Entity<Product_ondisk>()
                .Property(e => e.Style)
                .IsFixedLength();

            modelBuilder.Entity<Product_ondisk>()
                .HasMany(e => e.SpecialOfferProduct_ondisk)
                .WithRequired(e => e.Product_ondisk)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductCategory>()
                .HasMany(e => e.ProductSubcategory)
                .WithRequired(e => e.ProductCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductCostHistory>()
                .Property(e => e.StandardCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ProductDescription>()
                .HasMany(e => e.ProductModelProductDescriptionCulture)
                .WithRequired(e => e.ProductDescription)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductListPriceHistory>()
                .Property(e => e.ListPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ProductModel>()
                .HasMany(e => e.ProductModelIllustration)
                .WithRequired(e => e.ProductModel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductModel>()
                .HasMany(e => e.ProductModelProductDescriptionCulture)
                .WithRequired(e => e.ProductModel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductModelProductDescriptionCulture>()
                .Property(e => e.CultureID)
                .IsFixedLength();

            modelBuilder.Entity<ProductPhoto>()
                .HasMany(e => e.ProductProductPhoto)
                .WithRequired(e => e.ProductPhoto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TransactionHistory>()
                .Property(e => e.TransactionType)
                .IsFixedLength();

            modelBuilder.Entity<TransactionHistory>()
                .Property(e => e.ActualCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TransactionHistoryArchive>()
                .Property(e => e.TransactionType)
                .IsFixedLength();

            modelBuilder.Entity<TransactionHistoryArchive>()
                .Property(e => e.ActualCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<UnitMeasure>()
                .Property(e => e.UnitMeasureCode)
                .IsFixedLength();

            modelBuilder.Entity<UnitMeasure>()
                .HasMany(e => e.BillOfMaterials)
                .WithRequired(e => e.UnitMeasure)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UnitMeasure>()
                .HasMany(e => e.Product)
                .WithOptional(e => e.UnitMeasure)
                .HasForeignKey(e => e.SizeUnitMeasureCode);

            modelBuilder.Entity<UnitMeasure>()
                .HasMany(e => e.Product1)
                .WithOptional(e => e.UnitMeasure1)
                .HasForeignKey(e => e.WeightUnitMeasureCode);

            modelBuilder.Entity<UnitMeasure>()
                .HasMany(e => e.ProductVendor)
                .WithRequired(e => e.UnitMeasure)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WorkOrder>()
                .HasMany(e => e.WorkOrderRouting)
                .WithRequired(e => e.WorkOrder)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WorkOrderRouting>()
                .Property(e => e.ActualResourceHrs)
                .HasPrecision(9, 4);

            modelBuilder.Entity<WorkOrderRouting>()
                .Property(e => e.PlannedCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<WorkOrderRouting>()
                .Property(e => e.ActualCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ProductVendor>()
                .Property(e => e.StandardPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ProductVendor>()
                .Property(e => e.LastReceiptCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ProductVendor>()
                .Property(e => e.UnitMeasureCode)
                .IsFixedLength();

            modelBuilder.Entity<PurchaseOrderDetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PurchaseOrderDetail>()
                .Property(e => e.LineTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PurchaseOrderDetail>()
                .Property(e => e.ReceivedQty)
                .HasPrecision(8, 2);

            modelBuilder.Entity<PurchaseOrderDetail>()
                .Property(e => e.RejectedQty)
                .HasPrecision(8, 2);

            modelBuilder.Entity<PurchaseOrderDetail>()
                .Property(e => e.StockedQty)
                .HasPrecision(9, 2);

            modelBuilder.Entity<PurchaseOrderHeader>()
                .Property(e => e.SubTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PurchaseOrderHeader>()
                .Property(e => e.TaxAmt)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PurchaseOrderHeader>()
                .Property(e => e.Freight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PurchaseOrderHeader>()
                .Property(e => e.TotalDue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PurchaseOrderHeader>()
                .HasMany(e => e.PurchaseOrderDetail)
                .WithRequired(e => e.PurchaseOrderHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ShipMethod>()
                .Property(e => e.ShipBase)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ShipMethod>()
                .Property(e => e.ShipRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ShipMethod>()
                .HasMany(e => e.PurchaseOrderHeader)
                .WithRequired(e => e.ShipMethod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ShipMethod>()
                .HasMany(e => e.SalesOrderHeader)
                .WithRequired(e => e.ShipMethod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vendor>()
                .HasMany(e => e.ProductVendor)
                .WithRequired(e => e.Vendor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vendor>()
                .HasMany(e => e.PurchaseOrderHeader)
                .WithRequired(e => e.Vendor)
                .HasForeignKey(e => e.VendorID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CountryRegionCurrency>()
                .Property(e => e.CurrencyCode)
                .IsFixedLength();

            modelBuilder.Entity<CreditCard>()
                .HasMany(e => e.PersonCreditCard)
                .WithRequired(e => e.CreditCard)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Currency>()
                .Property(e => e.CurrencyCode)
                .IsFixedLength();

            modelBuilder.Entity<Currency>()
                .HasMany(e => e.CountryRegionCurrency)
                .WithRequired(e => e.Currency)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Currency>()
                .HasMany(e => e.CurrencyRate)
                .WithRequired(e => e.Currency)
                .HasForeignKey(e => e.FromCurrencyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Currency>()
                .HasMany(e => e.CurrencyRate1)
                .WithRequired(e => e.Currency1)
                .HasForeignKey(e => e.ToCurrencyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CurrencyRate>()
                .Property(e => e.FromCurrencyCode)
                .IsFixedLength();

            modelBuilder.Entity<CurrencyRate>()
                .Property(e => e.ToCurrencyCode)
                .IsFixedLength();

            modelBuilder.Entity<CurrencyRate>()
                .Property(e => e.AverageRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CurrencyRate>()
                .Property(e => e.EndOfDayRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Customer>()
                .Property(e => e.AccountNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.SalesOrderHeader)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalesOrder_json>()
                .Property(e => e.CreditCardApprovalCode)
                .IsUnicode(false);

            modelBuilder.Entity<SalesOrder_json>()
                .Property(e => e.SubTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrder_json>()
                .Property(e => e.TaxAmt)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrder_json>()
                .Property(e => e.Freight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrder_json>()
                .Property(e => e.TotalDue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderDetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderDetail>()
                .Property(e => e.UnitPriceDiscount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderDetail>()
                .Property(e => e.LineTotal)
                .HasPrecision(38, 6);

            modelBuilder.Entity<SalesOrderDetail_inmem>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderDetail_inmem>()
                .Property(e => e.UnitPriceDiscount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderDetail_ondisk>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderDetail_ondisk>()
                .Property(e => e.UnitPriceDiscount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderHeader>()
                .Property(e => e.CreditCardApprovalCode)
                .IsUnicode(false);

            modelBuilder.Entity<SalesOrderHeader>()
                .Property(e => e.SubTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderHeader>()
                .Property(e => e.TaxAmt)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderHeader>()
                .Property(e => e.Freight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderHeader>()
                .Property(e => e.TotalDue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderHeader_inmem>()
                .Property(e => e.CreditCardApprovalCode)
                .IsUnicode(false);

            modelBuilder.Entity<SalesOrderHeader_inmem>()
                .Property(e => e.SubTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderHeader_inmem>()
                .Property(e => e.TaxAmt)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderHeader_inmem>()
                .Property(e => e.Freight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderHeader_inmem>()
                .HasMany(e => e.SalesOrderDetail_inmem)
                .WithRequired(e => e.SalesOrderHeader_inmem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalesOrderHeader_ondisk>()
                .Property(e => e.CreditCardApprovalCode)
                .IsUnicode(false);

            modelBuilder.Entity<SalesOrderHeader_ondisk>()
                .Property(e => e.SubTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderHeader_ondisk>()
                .Property(e => e.TaxAmt)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderHeader_ondisk>()
                .Property(e => e.Freight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderHeader_ondisk>()
                .HasMany(e => e.SalesOrderDetail_ondisk)
                .WithRequired(e => e.SalesOrderHeader_ondisk)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalesPerson>()
                .Property(e => e.SalesQuota)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesPerson>()
                .Property(e => e.Bonus)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesPerson>()
                .Property(e => e.CommissionPct)
                .HasPrecision(10, 4);

            modelBuilder.Entity<SalesPerson>()
                .Property(e => e.SalesYTD)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesPerson>()
                .Property(e => e.SalesLastYear)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesPerson>()
                .HasMany(e => e.SalesOrderHeader)
                .WithOptional(e => e.SalesPerson)
                .HasForeignKey(e => e.SalesPersonID);

            modelBuilder.Entity<SalesPerson>()
                .HasMany(e => e.SalesPersonQuotaHistory)
                .WithRequired(e => e.SalesPerson)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalesPerson>()
                .HasMany(e => e.SalesTerritoryHistory)
                .WithRequired(e => e.SalesPerson)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalesPerson>()
                .HasMany(e => e.Store)
                .WithOptional(e => e.SalesPerson)
                .HasForeignKey(e => e.SalesPersonID);

            modelBuilder.Entity<SalesPersonQuotaHistory>()
                .Property(e => e.SalesQuota)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesReason>()
                .HasMany(e => e.SalesOrderHeaderSalesReason)
                .WithRequired(e => e.SalesReason)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalesTaxRate>()
                .Property(e => e.TaxRate)
                .HasPrecision(10, 4);

            modelBuilder.Entity<SalesTerritory>()
                .Property(e => e.SalesYTD)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesTerritory>()
                .Property(e => e.SalesLastYear)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesTerritory>()
                .Property(e => e.CostYTD)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesTerritory>()
                .Property(e => e.CostLastYear)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesTerritory>()
                .HasMany(e => e.StateProvince)
                .WithRequired(e => e.SalesTerritory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalesTerritory>()
                .HasMany(e => e.SalesTerritoryHistory)
                .WithRequired(e => e.SalesTerritory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SpecialOffer>()
                .Property(e => e.DiscountPct)
                .HasPrecision(10, 4);

            modelBuilder.Entity<SpecialOffer>()
                .HasMany(e => e.SpecialOfferProduct)
                .WithRequired(e => e.SpecialOffer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SpecialOffer_inmem>()
                .Property(e => e.DiscountPct)
                .HasPrecision(10, 4);

            modelBuilder.Entity<SpecialOffer_inmem>()
                .HasMany(e => e.SpecialOfferProduct_inmem)
                .WithRequired(e => e.SpecialOffer_inmem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SpecialOffer_ondisk>()
                .Property(e => e.DiscountPct)
                .HasPrecision(10, 4);

            modelBuilder.Entity<SpecialOffer_ondisk>()
                .HasMany(e => e.SpecialOfferProduct_ondisk)
                .WithRequired(e => e.SpecialOffer_ondisk)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SpecialOfferProduct>()
                .HasMany(e => e.SalesOrderDetail)
                .WithRequired(e => e.SpecialOfferProduct)
                .HasForeignKey(e => new { e.SpecialOfferID, e.ProductID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SpecialOfferProduct_inmem>()
                .HasMany(e => e.SalesOrderDetail_inmem)
                .WithRequired(e => e.SpecialOfferProduct_inmem)
                .HasForeignKey(e => new { e.SpecialOfferID, e.ProductID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SpecialOfferProduct_ondisk>()
                .HasMany(e => e.SalesOrderDetail_ondisk)
                .WithRequired(e => e.SpecialOfferProduct_ondisk)
                .HasForeignKey(e => new { e.SpecialOfferID, e.ProductID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Store>()
                .HasMany(e => e.Customer)
                .WithOptional(e => e.Store)
                .HasForeignKey(e => e.StoreID);

            modelBuilder.Entity<Employee_Temporal_History>()
                .Property(e => e.MaritalStatus)
                .IsFixedLength();

            modelBuilder.Entity<Employee_Temporal_History>()
                .Property(e => e.Gender)
                .IsFixedLength();

            modelBuilder.Entity<Person_Temporal_History>()
                .Property(e => e.PersonType)
                .IsFixedLength();

            modelBuilder.Entity<vEmployeePersonTemporalInfo>()
                .Property(e => e.MaritalStatus)
                .IsFixedLength();

            modelBuilder.Entity<vEmployeePersonTemporalInfo>()
                .Property(e => e.Gender)
                .IsFixedLength();

            modelBuilder.Entity<vStateProvinceCountryRegion>()
                .Property(e => e.StateProvinceCode)
                .IsFixedLength();

            modelBuilder.Entity<vProductAndDescription>()
                .Property(e => e.CultureID)
                .IsFixedLength();

            modelBuilder.Entity<vProductModelInstructions>()
                .Property(e => e.SetupHours)
                .HasPrecision(9, 4);

            modelBuilder.Entity<vProductModelInstructions>()
                .Property(e => e.MachineHours)
                .HasPrecision(9, 4);

            modelBuilder.Entity<vProductModelInstructions>()
                .Property(e => e.LaborHours)
                .HasPrecision(9, 4);

            modelBuilder.Entity<vPersonDemographics>()
                .Property(e => e.TotalPurchaseYTD)
                .HasPrecision(19, 4);

            modelBuilder.Entity<vSalesPerson>()
                .Property(e => e.SalesQuota)
                .HasPrecision(19, 4);

            modelBuilder.Entity<vSalesPerson>()
                .Property(e => e.SalesYTD)
                .HasPrecision(19, 4);

            modelBuilder.Entity<vSalesPerson>()
                .Property(e => e.SalesLastYear)
                .HasPrecision(19, 4);

            modelBuilder.Entity<vSalesPersonSalesByFiscalYears>()
                .Property(e => e.C2002)
                .HasPrecision(19, 4);

            modelBuilder.Entity<vSalesPersonSalesByFiscalYears>()
                .Property(e => e.C2003)
                .HasPrecision(19, 4);

            modelBuilder.Entity<vSalesPersonSalesByFiscalYears>()
                .Property(e => e.C2004)
                .HasPrecision(19, 4);

            modelBuilder.Entity<vStoreWithDemographics>()
                .Property(e => e.AnnualSales)
                .HasPrecision(19, 4);

            modelBuilder.Entity<vStoreWithDemographics>()
                .Property(e => e.AnnualRevenue)
                .HasPrecision(19, 4);
        }
    }
}
