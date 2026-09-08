# Simplic.OxS.SDK.Contract.OrderItemModel
Represents an item of an order.  Addresses can either be set by id or manually. If an id is given, the resolved address will override the manually set address.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the id of the order item. | [optional] 
**Index** | **int** | Gets or sets the index of the item. | [optional] 
**ContractItemId** | **Guid?** | Gets or sets the id of the referenced contract item. | [optional] 
**ContractItemReference** | **string** | Gets or sets the reference of the referenced contract item. | [optional] 
**ArticleId** | **Guid?** | Gets or sets the id of the article. | [optional] 
**ArticleName** | **string** | Gets or sets the name of the article. | [optional] 
**Text** | **string** | Gets or sets the text of the item. | [optional] 
**TransportationQuantity** | [**OrderQuantityModel**](OrderQuantityModel.md) |  | [optional] 
**Quantity** | [**OrderQuantityModel**](OrderQuantityModel.md) |  | [optional] 
**BookedQuantity** | [**OrderQuantityModel**](OrderQuantityModel.md) |  | [optional] 
**Reference** | **string** | Gets or sets the reference of the item. | [optional] 
**LoadNumber** | **string** | Gets or sets the load number. | [optional] 
**DeliveryNumber** | **string** | Gets or sets the delivery number. | [optional] 
**Notes** | **string** | Gets or sets the internal notes. | [optional] 
**ExternalNotes** | **string** | Gets or sets the notes visible for externals. | [optional] 
**LoadAddress** | [**AddressModel**](AddressModel.md) |  | [optional] 
**DeliveryAddress** | [**AddressModel**](AddressModel.md) |  | [optional] 
**UnitPrice** | **double?** | Gets or sets the price for a single unit. | [optional] 
**TotalPrice** | **double?** | Gets or sets the total price. | [optional] 
**PriceUnit** | [**QuantityUnitModel**](QuantityUnitModel.md) |  | [optional] 
**Approved** | **bool** | Gets or sets a value indicating whether the item has been approved. | [optional] 
**StartLoadDateTime** | **DateTime?** | Gets or sets the start date and time of the load. | [optional] 
**EndLoadDateTime** | **DateTime?** | Gets or sets the end date and time of the load. | [optional] 
**StartDeliveryDateTime** | **DateTime?** | Gets or sets the start date and time of the delivery. | [optional] 
**EndDeliveryDateTime** | **DateTime?** | Gets or sets the end date and time of the delivery. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

