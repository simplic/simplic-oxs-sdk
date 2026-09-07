# Simplic.OxS.SDK.Contract.UpdateOrderRequest
Represents a request to update an order.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Number** | **string** | Gets or sets the number. | [optional] 
**ContractId** | **Guid?** | Gets or sets the id of the referenced contract. | [optional] 
**ContractNumber** | **string** | Gets or sets the number of the referenced contract. | [optional] 
**Customer** | [**BillableContactRequestModel**](BillableContactRequestModel.md) |  | [optional] 
**StatusId** | **Guid?** | Gets or sets the id of the status.  If not set, the status with the role &#x60;is_default&#x60; will be used. | [optional] 
**Reference** | **string** | Gets or sets the reference of the order. | [optional] 
**Notes** | **string** | Gets or sets the notes of the order. | [optional] 
**SourceId** | **Guid?** | Gets or sets the id of the source. | [optional] 
**Items** | [**List&lt;OrderItemRequestModel&gt;**](OrderItemRequestModel.md) | Gets or sets the items of the order. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

