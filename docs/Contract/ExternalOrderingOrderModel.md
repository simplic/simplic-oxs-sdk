# Simplic.OxS.SDK.Contract.ExternalOrderingOrderModel
Represents an external order response.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the order id. | [optional] 
**ContractId** | **Guid** | Gets or sets the contract id. | [optional] 
**Date** | **DateTime** | Gets or sets the requested delivery/order date. | [optional] 
**OrderPersonName** | **string** | Gets or sets the name of the person who placed the order. | [optional] 
**OrderPersonSignature** | **string** | Gets or sets the signature of the person who placed the order. | [optional] 
**Status** | **string** | Gets or sets the order status. | [optional] 
**Items** | [**List&lt;ExternalOrderingOrderItemModel&gt;**](ExternalOrderingOrderItemModel.md) | Gets or sets the ordered items. | [optional] 
**CreateDateTime** | **DateTime** | Gets or sets the create date time. | [optional] 
**Notes** | **string** | Gets or sets optional notes for the order. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

