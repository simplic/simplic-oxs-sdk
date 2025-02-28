# Simplic.OxS.SDK.Logistics.TourTagModel
Represents the server model of a tag for tours.     Tags are short texts to add information to a tour without the need to add new properties.    These are e.g. used in the pricing module to add some additional conditions.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the unique identifier of the tour tag. | [optional] 
**Name** | **string** | Gets or sets the name. | [optional] 
**InternalName** | **string** | Gets or sets an internal tag name | [optional] 
**GroupName** | **string** | Gets or sets the group name.     Group names are a possibillity to group tags.   E.g. when just a single tag from a certain pool should be used.   | [optional] 
**HexColor** | **string** | Gets or sets the hex color of the string. | [optional] 
**OrganizationId** | **Guid** | Gets or sets the organization id. | [optional] 
**IsDeleted** | **bool** | Gets or sets whether the tour tag is deleted. | [optional] 
**Functions** | **List&lt;string&gt;** | Gets or sets the functions of the tour tag.     Functions are used to add additional functionalities to a tour tag.  &lt;list type&#x3D;\&quot;bullet\&quot;&gt;&lt;item&gt;disable_edit: Disables editing the tour or action the tag is attached to.&lt;/item&gt;&lt;/list&gt; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

