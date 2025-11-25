# Simplic.OxS.SDK.ERP.TransactionItemRequest
Represents a request to create or update a transaction item of a Simplic.OxS.ERP.Transaction.Transaction.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the ID. | [optional] 
**Text** | **string** | Gets or sets the text. | [optional] 
**TypeId** | **Guid?** | Gets or sets the item type by ID. | [optional] 
**SortNumber** | **int?** | Gets or sets the sort number. | [optional] 
**DeserializationType** | **string** | Gets or sets an identifier for the type of the item for correct deserialization. | [optional] 
**ValueOperator** | **ValueOperator** |  | [optional] 
**AssignmentMode** | **AssignmentMode** |  | [optional] 
**Amount** | **double?** | Gets the amount the operation item results in.     The amount can be positive or negative representing a surcharge or a discount.   | [optional] 
**BehaviorDefinitions** | [**List&lt;BehaviorDefinitionRequest&gt;**](BehaviorDefinitionRequest.md) | Gets or sets a set of Simplic.OxS.ERP.Server.BehaviorDefinitionRequest. | [optional] 
**Quantity** | **double?** | Gets or sets the quantity. | [optional] 
**UnitId** | **Guid?** | Gets or sets the unit the quantity is measured in by ID. | [optional] 
**InputPrice** | **double?** | Gets or sets the price user input. | [optional] 
**InputPriceType** | **InputPriceType** |  | [optional] 
**TaxKeyId** | **Guid?** | Gets or sets the tax key given by ID if a specific tax key should be used for this item. | [optional] 
**CostCenters** | **Dictionary&lt;string, double&gt;** | Gets or sets the assigned cost centers given by ID with their respective percentages. | [optional] 
**CostObjects** | **Dictionary&lt;string, double&gt;** | Gets or sets the assigned cost objects given by ID with their respective percentages. | [optional] 
**ArticleId** | **Guid?** | Gets or sets the article by ID. | [optional] 
**GeneralLedgerAccountId** | **Guid?** | Gets or sets the general ledger account by ID. | [optional] 
**DeltaValue** | **double?** | Gets or sets the discount/surcharge value as an absolute price value or a percentage value depending on the value operator. | [optional] 
**Items** | [**List&lt;TransactionItemRequest&gt;**](TransactionItemRequest.md) | Gets or sets a set of transaction items that are part of the group. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

