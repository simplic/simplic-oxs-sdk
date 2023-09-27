# Simplic.OxS.SDK.Logistics.Model.TourStatusModel
Represents the status of a tour.  <br>  The tour status will define what actions the user can and can not do with the tour and in which state the tour  currently is.  

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the id of the status as guid.  &lt;br&gt;  This will define the unique identifier of the status.   | [optional] 
**Name** | **string** | Gets or sets the namme of the status. | [optional] 
**Number** | **string** | Gets or sets the number of the status.  &lt;br&gt;  The number is a human readable short name or number of the status.   | [optional] 
**Roles** | **List&lt;string&gt;** | Gets or sets roles.  &lt;br&gt;  These roles will decide whether shipments with the status can or can not to certain things.    A list of available roles at the moment:  &lt;list type&#x3D;\&quot;bullet\&quot;&gt;&lt;item&gt;is_default&lt;/item&gt;&lt;item&gt;disable_edit&lt;/item&gt;&lt;item&gt;disable_delete&lt;/item&gt;&lt;/list&gt; | [optional] 
**HexColor** | **string** | Gets or sets the hex color.  &lt;br&gt;  Will define the color of the status as hex code.   | [optional] 
**OrderNr** | **int** | Gets or sets the order number.  &lt;br&gt;  The order nr will define in which order the statuses are resolved.     The lowest value will always be resolved first. | [optional] 
**Resolver** | **string** | Gets or sets the resolver name.  &lt;br&gt;  The name of the resolver is also the name which the resolver is registererd.     Within the resolving of the status the service will try to find a resolver with the given name. | [optional] 
**IsDeleted** | **bool** | Gets or sets whether the status is deleted. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

