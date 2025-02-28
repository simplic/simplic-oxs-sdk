# Simplic.OxS.SDK.ERP.TransactionItemModel
Represents the shared model for a transaction item.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the ID. | [optional] 
**Text** | **string** | Gets or sets the text. | [optional] 
**Type** | [**TransactionItemTypeModel**](TransactionItemTypeModel.md) |  | [optional] 
**BookedFromTransactionId** | **Guid?** | Gets or sets the transaction this item has been booked from by ID. | [optional] 
**TransactionItemCollectionId** | **Guid?** | Gets or sets the Simplic.OxS.ERP.TransactionItemCollection.TransactionItemCollection this transaction item is part of by ID. | [optional] 
**SortNumber** | **int** | Gets or sets the sort number. | [optional] 
**DeserializationType** | **string** | Gets or sets an identifier for the type of the item for correct deserialization. | [optional] 
**AssignedTransactionItems** | [**List&lt;TransactionItemModel&gt;**](TransactionItemModel.md) |  | [optional] 
**ValueOperator** | **ModelValueOperator** |  | [optional] 
**AssignmentMode** | **ModelAssignmentMode** |  | [optional] 
**Amount** | **double?** | Gets the amount the operation item results in.  &lt;br&gt;  The amount can be positive or negative representing a surcharge or a discount.   | [optional] 
**BehaviorDefinitions** | [**List&lt;BehaviorDefinitionModel&gt;**](BehaviorDefinitionModel.md) | Gets or sets a set of Simplic.OxS.ERP.Server.BehaviorDefinitionModel | [optional] 
**OriginalOperationItem** | [**TransactionItemModel**](TransactionItemModel.md) |  | [optional] 
**InputPrice** | **double?** | Gets or sets the price user input. | [optional] 
**InputPriceType** | **InputPriceType** |  | [optional] 
**SinglePrice** | **double?** | Gets or sets the resulting single price. | [optional] 
**TotalPrice** | **double?** | Gets or sets the resulting total price. | [optional] 
**SinglePriceNet** | **double?** | Gets or sets the resulting net single price. | [optional] 
**TotalPriceNet** | **double?** | Gets or sets the resulting net total price. | [optional] 
**SinglePriceGross** | **double?** | Gets or sets the gross single price. | [optional] 
**TotalPriceGross** | **double?** | Gets or sets the gross total price. | [optional] 
**SinglePriceVat** | **double?** | Gets or sets the VAT contained in the net single price. | [optional] 
**TotalPriceVat** | **double?** | Gets or sets the VAT contained in the net total price. | [optional] 
**Pricing** | [**List&lt;StringTransactionPriceObjectModelKeyValuePair&gt;**](StringTransactionPriceObjectModelKeyValuePair.md) | Gets or sets a set of Simplic.OxS.ERP.Server.TransactionPriceObjectModel representing the price development history.  &lt;br&gt;  Each tuple represents the transaction item pricing data resulting from a specific operation. The list contains the tuples in the order these operation are applied in.   | [optional] 
**Quantity** | **double?** | Gets or sets the quantity. | [optional] 
**Unit** | [**QuantityUnitModel**](QuantityUnitModel.md) |  | [optional] 
**ArticleId** | **Guid?** | Gets or sets the article by ID. | [optional] 
**DeltaValue** | **double?** | Gets or sets the discount/surcharge value as an absolute price value or a percentage value depending on the value operator. | [optional] 
**Items** | [**List&lt;TransactionItemModel&gt;**](TransactionItemModel.md) | Gets or sets a set of transaction items that are part of the group. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

