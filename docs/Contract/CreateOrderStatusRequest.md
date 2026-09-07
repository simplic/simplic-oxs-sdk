# Simplic.OxS.SDK.Contract.CreateOrderStatusRequest
Represents a request to create an order status.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the id of the status. | [optional] 
**Name** | **string** | Gets or sets the name of the status. | [optional] 
**Number** | **string** | Gets or sets the number of the status. | [optional] 
**Roles** | **List&lt;string&gt;** | Gets or sets the roles of the status.  Available values: &#x60;is_default&#x60;, &#x60;disable_edit&#x60;, &#x60;disable_delete&#x60;. | [optional] 
**Index** | **int** | Gets or sets the order of the status in a status list. | [optional] 
**HexCode** | **string** | Gets or sets the color of the status as hexadecimal value. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

