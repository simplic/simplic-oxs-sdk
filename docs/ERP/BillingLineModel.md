# Simplic.OxS.SDK.ERP.BillingLineModel
Represents the response model for Simplic.OxS.ERP.BillingLine.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] 
**OrganizationId** | **Guid** |  | [optional] 
**IsDeleted** | **bool** |  | [optional] 
**FinancialPartner** | [**TransactionContact**](TransactionContact.md) |  | [optional] 
**Text** | **string** | Gets or sets the text describing this billing line. | [optional] 
**Quantity** | **double** | Gets or sets the quantity of the item or service described by this billing line. | [optional] 
**QuantityUnit** | [**QuantityUnit**](QuantityUnit.md) |  | [optional] 
**PriceUnit** | [**QuantityUnit**](QuantityUnit.md) |  | [optional] 
**SinglePrice** | **double?** | Gets or sets the price for a single unit. | [optional] 
**TotalPrice** | **double?** | Gets or sets the total price. | [optional] 
**IsGross** | **bool** | Gets or sets a value indicating whether the billing line price is gross or net. | [optional] 
**CostCenters** | [**List&lt;CostCenterAssignment&gt;**](CostCenterAssignment.md) | Gets or sets the cost center assignments associated with this billing line. | [optional] 
**CostObjects** | [**List&lt;CostCenterAssignment&gt;**](CostCenterAssignment.md) | Gets or sets the cost object assignments associated with this billing line. | [optional] 
**TaxRate** | [**TaxRateModel**](TaxRateModel.md) |  | [optional] 
**GeneralLedgerAccountGroup** | [**TransactionGeneralLedgerAccountGroup**](TransactionGeneralLedgerAccountGroup.md) |  | [optional] 
**Reference** | **string** | Gets or sets the main reference. | [optional] 
**References** | [**List&lt;BillingLineReference&gt;**](BillingLineReference.md) | Gets or sets a set of additional references. | [optional] 
**IsManualBillingLine** | **bool** | Gets or sets the flag indicating whether the billing line was created manually. | [optional] 
**State** | **BillingLineState** |  | [optional] 
**Addon** | **Dictionary&lt;string, Object&gt;** | Gets or sets a set of additional properties. | [optional] 
**AssignedTransactionId** | **Guid?** | Gets or sets the transaction this billing line has been assigned to (either draft or finalized).     This information is used to easily determine whether the billing line is assigned to a particular draft transaction.   | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

