# Simplic.OxS.SDK.ERP.PreviewTransactionItemRequest
Represents a request to preview a transaction item of a Simplic.OxS.ERP.Transaction.Transaction.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TemporaryId** | **Guid** | Gets or sets the temporary ID used for client-side identification in the preview response. | [optional] 
**Id** | **Guid** | Gets or sets the ID. | [optional] 
**Text** | **string** | Gets or sets the text. | [optional] 
**TypeId** | **Guid?** | Gets or sets the item type by ID. | [optional] 
**SortNumber** | **int?** | Gets or sets the sort number. | [optional] 
**DeserializationType** | **string** | Gets or sets an identifier for the type of the item for correct deserialization. | [optional] 
**ValueOperator** | **ValueOperator** |  | [optional] 
**AssignmentMode** | **AssignmentMode** |  | [optional] 
**BehaviorDefinitions** | [**List&lt;BehaviorDefinitionRequest&gt;**](BehaviorDefinitionRequest.md) | Gets or sets a set of Simplic.OxS.ERP.Server.BehaviorDefinitionRequest. | [optional] 
**Quantity** | [**QuantityRequest**](QuantityRequest.md) |  | [optional] 
**InputPrice** | **double?** | Gets or sets the price user input. | [optional] 
**InputPriceType** | **InputPriceType** |  | [optional] 
**TaxKeyId** | **Guid?** | Gets or sets the tax key given by ID if a specific tax key should be used for this item. | [optional] 
**TaxRateId** | **Guid?** | Gets or sets the tax rate given by ID. | [optional] 
**CostCenters** | [**List&lt;PreviewItemCostCenterAssignmentRequest&gt;**](PreviewItemCostCenterAssignmentRequest.md) | Gets or sets the assigned cost centers given by ID with their respective percentages. | [optional] 
**CostObjects** | [**List&lt;PreviewItemCostCenterAssignmentRequest&gt;**](PreviewItemCostCenterAssignmentRequest.md) | Gets or sets the assigned cost objects given by ID with their respective percentages. | [optional] 
**ArticleId** | **Guid?** | Gets or sets the article by ID. | [optional] 
**GeneralLedgerAccountId** | **Guid?** | Gets or sets the general ledger account by ID. | [optional] 
**PriceUnitId** | **Guid?** | Gets or sets the unit of measurement the price is based on by ID.  Example: Price could be measured per kg while the total quantity is measured in tons. | [optional] 
**Reference** | **string** | Gets or sets the main reference. | [optional] 
**References** | [**List&lt;BillingLineReferenceRequest&gt;**](BillingLineReferenceRequest.md) | Gets or sets a set of additional references. | [optional] 
**IsManualBillingLine** | **bool?** | Gets or sets the flag indicating whether the billing line was created manually. | [optional] 
**DeltaValue** | **double?** | Gets or sets the discount/surcharge value as an absolute price value or a percentage value depending on the value operator. | [optional] 
**Items** | [**List&lt;PreviewTransactionItemRequest&gt;**](PreviewTransactionItemRequest.md) | Gets or sets a set of transaction items that are part of the group. | [optional] 
**Remove** | **bool** | Remove flag for the patch helper. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

