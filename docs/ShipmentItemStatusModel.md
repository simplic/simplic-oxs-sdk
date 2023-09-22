# Simplic.OxS.SDK.Model.ShipmentItemStatusModel
Shared model of shipment item status.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the id.  &lt;br&gt;  The id is the unique identifier of the status.   | [optional] 
**Name** | **string** | Gets or sets the name. | [optional] 
**Number** | **string** | Gets or sets the number.  &lt;br&gt;  The number is a human readable identifier for the status.   | [optional] 
**Roles** | **List&lt;string&gt;** | Gets or sets roles.  &lt;br&gt;  These roles will decide whether shipments with the status can or can not to certain things.    A list of available roles at the moment:  &lt;list type&#x3D;\&quot;bullet\&quot;&gt;&lt;item&gt;is_default&lt;/item&gt;&lt;item&gt;disable_edit&lt;/item&gt;&lt;item&gt;disable_delete&lt;/item&gt;&lt;item&gt;billable&lt;/item&gt;&lt;/list&gt; | [optional] 
**HexColor** | **string** | Gets or sets the color as as hexadecimal value. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

