# Simplic.OxS.SDK.Logistics.PatchBillingLineRequest
Request to patch a billing line.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FinancialPartner** | [**BillingLineContactRequest**](BillingLineContactRequest.md) |  | [optional] 
**Date** | **DateTime?** | Gets or sets the date associated with this billing line. | [optional] 
**DeliveryDate** | **DateTime?** | Gets or sets the delivery date associated with this billing line. | [optional] 
**Type** | **BillingLineType** |  | [optional] 
**StatusId** | **Guid?** | Gets or sets the status id. | [optional] 
**SinglePrice** | **double?** | Gets or sets the single price.     Represents the price of a single item.   | [optional] 
**TotalPrice** | **double?** | Gets or sets the total price.     Represents the price of all items.   | [optional] 
**IsGross** | **bool?** | Gets or sets a value indicating whether the billing line price is gross or net. | [optional] 
**CostCenters** | [**List&lt;BillingLineCostCenterAssignmentRequest&gt;**](BillingLineCostCenterAssignmentRequest.md) | Gets or sets the cost center assignments associated with this billing line. | [optional] 
**CostObjects** | [**List&lt;BillingLineCostCenterAssignmentRequest&gt;**](BillingLineCostCenterAssignmentRequest.md) | Gets or sets the cost object assignments associated with this billing line. | [optional] 
**TaxRateId** | **Guid?** | Gets or sets the tax rate for this billing line. | [optional] 
**GeneralLedgerAccountGroupId** | **Guid?** | Gets or sets the general ledger account group for this billing line.     The general ledger account group is used in the financial accounting process to  determine the general ledger account.   | [optional] 
**Reference** | **string** | Gets or sets the external reference. | [optional] 
**References** | [**List&lt;BillingLineReferenceRequest&gt;**](BillingLineReferenceRequest.md) | Gets or sets a set of additional references. | [optional] 
**Text** | **string** | Gets or sets the billing line text. | [optional] 
**IsManualBillingLine** | **bool?** | Gets or sets the flag indicating whether the billing line was created manually. | [optional] 
**Addon** | **Dictionary&lt;string, Object&gt;** | Gets or sets a dictionary of addon properties to store any additional   information related to a billing line. | [optional] 
**Id** | **Guid** | Gets or sets the id.     Represents the unique identifier of a billing line.   | [optional] 
**Quantity** | [**QuantityPatchRequest**](QuantityPatchRequest.md) |  | [optional] 
**Remove** | **bool?** | Remove flag for the patch helper. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

