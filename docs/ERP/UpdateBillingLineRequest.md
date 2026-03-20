# Simplic.OxS.SDK.ERP.UpdateBillingLineRequest
Represents a patch request for a Simplic.OxS.ERP.BillingLine.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FinancialPartner** | [**TransactionContactRequest**](TransactionContactRequest.md) |  | [optional] 
**Date** | **DateTime?** | Gets or sets the date associated with this billing line.     A billing line stores all necessary information to create a transaction based on itself or a   set of billing lines.   | [optional] 
**DeliveryDate** | **DateTime?** | Gets or sets the delivery date associated with this billing line. | [optional] 
**Text** | **string** | Gets or sets the text describing this billing line. | [optional] 
**Quantity** | **double?** | Gets or sets the quantity of the item or service. | [optional] 
**QuantityUnitId** | **Guid?** | Gets or sets the unit of measurement for the total quantity by ID. | [optional] 
**PriceUnitId** | **Guid?** | Gets or sets the unit of measurement the price is based on by ID.     Example: Price could be measured per kg while the total quantity is measured   in tons.   | [optional] 
**SinglePrice** | **double?** | Gets or sets the price for a single unit of the item or service described   by this billing line. | [optional] 
**TotalPrice** | **double?** | Gets or sets the total price of the item or service described by this billing line. | [optional] 
**IsGross** | **bool?** | Gets or sets a value indicating whether the billing line price is gross or net. | [optional] 
**CostCenters** | [**List&lt;CostCenterAssignmentRequest&gt;**](CostCenterAssignmentRequest.md) | Gets or sets the cost center assignments associated with this billing line. | [optional] 
**CostObjects** | [**List&lt;CostCenterAssignmentRequest&gt;**](CostCenterAssignmentRequest.md) | Gets or sets the cost object assignments associated with this billing line. | [optional] 
**GeneralLedgerAccountGroupId** | **Guid?** | Gets or sets the general ledger account group for this billing line by ID.     The general ledger account group is used in the financial accounting process to   determine the general ledger account.   | [optional] 
**Reference** | **string** | Gets or sets the main reference. | [optional] 
**IsManualBillingLine** | **bool?** | Gets or sets the flag indicating whether the billing line was created manually. | [optional] 
**Addon** | **Dictionary&lt;string, Object&gt;** | Gets or sets a set of additional properties that can be used to store any   additional information related to this billing line. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

