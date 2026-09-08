# Simplic.OxS.SDK.Contract.OrderModel
Represents the model of an order.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the order id. | [optional] 
**OrganizationId** | **Guid** | Gets or sets the organization id. | [optional] 
**Number** | **string** | Gets or sets the number. | [optional] 
**ContractId** | **Guid?** | Gets or sets the id of the referenced contract. | [optional] 
**ContractNumber** | **string** | Gets or sets the number of the referenced contract. | [optional] 
**Customer** | [**BillableContactModel**](BillableContactModel.md) |  | [optional] 
**Status** | [**OrderStatusModel**](OrderStatusModel.md) |  | [optional] 
**Reference** | **string** | Gets or sets the reference of the order. | [optional] 
**Notes** | **string** | Gets or sets the notes of the order. | [optional] 
**Source** | [**OrderSourceModel**](OrderSourceModel.md) |  | [optional] 
**Items** | [**List&lt;OrderItemModel&gt;**](OrderItemModel.md) | Gets or sets the items of the order. | [optional] 
**CreateDateTime** | **DateTime** | Gets or sets the create date time. | [optional] 
**CreateUserId** | **Guid?** | Gets or sets the create user id. | [optional] 
**CreateUserName** | **string** | Gets or sets the create user name. | [optional] 
**UpdateDateTime** | **DateTime** | Gets or sets the update date time. | [optional] 
**UpdateUserId** | **Guid?** | Gets or sets the update user id. | [optional] 
**UpdateUserName** | **string** | Gets or sets the update user name. | [optional] 
**ContactPerson** | [**OrderContactPersonModel**](OrderContactPersonModel.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

