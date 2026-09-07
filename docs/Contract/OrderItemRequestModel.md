# Simplic.OxS.SDK.Contract.OrderItemRequestModel
Represents a request to create or update an order item.  Addresses can either be set by id or manually. If an id is given, the resolved address will override the manually set address.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the id of the order item. | [optional] 
**Index** | **int** | Gets or sets the index of the item. | [optional] 
**ContractItemId** | **Guid?** | Gets or sets the id of the referenced contract item. | [optional] 
**ContractItemReference** | **string** | Gets or sets the reference of the referenced contract item. | [optional] 
**ArticleId** | **Guid?** | Gets or sets the id of the article.  If set, the article will be resolved and override Simplic.OxS.Contract.Server.Model.OrderItemRequestModel.ArticleName. | [optional] 
**ArticleName** | **string** | Gets or sets the name of the article. | [optional] 
**Text** | **string** | Gets or sets the text of the item. | [optional] 
**TransportationQuantity** | [**QuantityRequest**](QuantityRequest.md) |  | [optional] 
**Quantity** | [**QuantityRequest**](QuantityRequest.md) |  | [optional] 
**BookedQuantity** | [**QuantityRequest**](QuantityRequest.md) |  | [optional] 
**Reference** | **string** | Gets or sets the reference of the item. | [optional] 
**LoadNumber** | **string** | Gets or sets the load number. | [optional] 
**DeliveryNumber** | **string** | Gets or sets the delivery number. | [optional] 
**Notes** | **string** | Gets or sets the internal notes. | [optional] 
**ExternalNotes** | **string** | Gets or sets the notes visible for externals. | [optional] 
**LoadAddress** | [**AddressModel**](AddressModel.md) |  | [optional] 
**DeliveryAddress** | [**AddressModel**](AddressModel.md) |  | [optional] 
**UnitPrice** | **double?** | Gets or sets the price for a single unit. | [optional] 
**TotalPrice** | **double?** | Gets or sets the total price. | [optional] 
**PriceUnitId** | **Guid?** | Gets or sets the id of the unit the price refers to. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

