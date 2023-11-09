# Simplic.OxS.SDK.Logistics.TransportOrderStatusModel
Shared model of transport order status.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the id of the status as guid.  &lt;br&gt;  This will define the unique identifier of the status.   | [optional] 
**Name** | **string** | Gets or sets the namme of the status. | [optional] 
**Number** | **string** | Gets or sets the number of the status.  &lt;br&gt;  The number is a human readable short name or number of the status.   | [optional] 
**Roles** | **List&lt;string&gt;** | Gets or sets roles.  &lt;br&gt;  These roles will decide whether transport orders with the status can or can not to certain things.    A list of available roles at the moment:  &lt;list type&#x3D;\&quot;bullet\&quot;&gt;&lt;item&gt;is_default&lt;/item&gt;&lt;br&gt;Will set the status as default, only one status should be a default status.&lt;item&gt;disable_edit&lt;/item&gt;&lt;br&gt;Will diable editing of the transport order.&lt;item&gt;disable_delete&lt;/item&gt;&lt;br&gt;The user should be unable to delete the billing line if a status with this role is set.&lt;item&gt;billable&lt;/item&gt;&lt;br&gt;Will set the transport order as billable.&lt;item&gt;update_instance_data&lt;/item&gt;&lt;br&gt;If a status is set with this role the instance data, e.g. contact information will be automatically  updated when updated in a contact.&lt;/list&gt; | [optional] 
**HexColor** | **string** | Gets or sets the hex color.  &lt;br&gt;  Will define the color of the status as hex code.   | [optional] 
**OrderNr** | **int** | Gets or sets the order number.  &lt;br&gt;  The order nr will define in which order the statuses are resolved.     The lowest value will always be resolved first. | [optional] 
**Resolver** | **string** | Gets or sets the resolver name.  &lt;br&gt;  The name of the resolver is also the name which the resolver is registererd.     Within the resolving of the status the service will try to find a resolver with the given name. | [optional] 
**IsDeleted** | **bool** | Gets or sets whether the status is deleted. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

