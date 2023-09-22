# Simplic.OxS.SDK.Model.ShipmentStatusModel
Shared model of shipment status.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Gets or sets the namme of the status. | [optional] 
**Number** | **string** | Gets or sets the number of the status.  &lt;br&gt;  The number is a human readable short name or number of the shipment.   | [optional] 
**Roles** | **List&lt;string&gt;** | Gets or sets roles.  &lt;br&gt;  These roles will decide whether shipments with the status can or can not to certain things.    A list of available roles at the moment:  &lt;list type&#x3D;\&quot;bullet\&quot;&gt;&lt;item&gt;is_default&lt;/item&gt;&lt;item&gt;disable_edit&lt;/item&gt;&lt;item&gt;billable&lt;/item&gt;&lt;item&gt;disable_delete&lt;/item&gt;&lt;/list&gt; | [optional] 
**HexColor** | **string** | Gets or sets the hex color.  &lt;br&gt;  Will define the color of the status as hex code.   | [optional] 
**OrderNr** | **int** | Gets or sets the order number.  &lt;br&gt;  The order nr will define in which order the statuses are resolved.     The lowest value will always be resolved first. | [optional] 
**Resolver** | **string** | Gets or sets the resolver name.  &lt;br&gt;  The name of the resolver is also the name which the resolver is registererd.     Within the resolving of the status the service will try to find a resolver with the given name. | [optional] 
**Id** | **Guid** | Gets or sets the id of the status as guid.  &lt;br&gt;  This will define the unique identifier of the status.   | [optional] 
**IsDeleted** | **bool** | Gets or sets whether the status is deleted. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

