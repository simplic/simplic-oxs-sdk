# Simplic.OxS.SDK.Logistics.BillingLineModel
Shared model of billing line.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the id.     Represents the unique identifier of a billing line.   | [optional] 
**FinancialPartner** | [**BillingLineContactModel**](BillingLineContactModel.md) |  | [optional] 
**Date** | **DateTime** | Gets or sets the date associated with this billing line. | [optional] 
**DeliveryDate** | **DateTime?** | Gets or sets the delivery date associated with this billing line. | [optional] 
**Type** | **BillingLineType** |  | [optional] 
**Status** | [**BillingLineStatusModel**](BillingLineStatusModel.md) |  | [optional] 
**SinglePrice** | **double** | Gets or sets the single price.     Represents the price of a single item.   | [optional] 
**TotalPrice** | **double** | Gets or sets the total price.     Represents the price of all items.   | [optional] 
**IsGross** | **bool** | Gets or sets a value indicating whether the billing line price is gross or net. | [optional] 
**CostCenters** | [**List&lt;BillingLineCostCenterAssignmentModel&gt;**](BillingLineCostCenterAssignmentModel.md) | Gets or sets the cost center assignments associated with this billing line. | [optional] 
**CostObjects** | [**List&lt;BillingLineCostCenterAssignmentModel&gt;**](BillingLineCostCenterAssignmentModel.md) | Gets or sets the cost object assignments associated with this billing line. | [optional] 
**TaxRate** | [**BillingLineTaxRateModel**](BillingLineTaxRateModel.md) |  | [optional] 
**GeneralLedgerAccountGroup** | [**BillingLineGeneralLedgerAccountGroupModel**](BillingLineGeneralLedgerAccountGroupModel.md) |  | [optional] 
**Quantity** | [**QuantityModel**](QuantityModel.md) |  | [optional] 
**Reference** | **string** | Gets or sets the external reference. | [optional] 
**References** | [**List&lt;BillingLineReferenceModel&gt;**](BillingLineReferenceModel.md) | Gets or sets a set of additional references. | [optional] 
**Text** | **string** | Gets or sets the billing line text. | [optional] 
**IsManualBillingLine** | **bool** | Gets or sets the flag indicating whether the billing line was created manually. | [optional] 
**Addon** | **Dictionary&lt;string, Object&gt;** | Gets or sets a set of additional properties that can be used to store any  additional information related to this billing line. | [optional] 
**AssignedTransactionId** | **Guid?** | Gets or sets the transaction this billing line has been assigned to (either draft or finalized). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

