# Simplic.OxS.SDK.Contract.CreateContractStatusRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the id of the status. | [optional] 
**Name** | **string** | Gets or sets the name of the status. | [optional] 
**Number** | **string** | Gets or sets the number of the status.  The number is a human readable identifier of the status. | [optional] 
**Roles** | **List&lt;string&gt;** | Gets or sets the roles.  The roles will decide whether contracts with the status can be manipulated in certain ways. A list of available roles at the moment: &lt;list type&#x3D;\&quot;bullet\&quot;&gt;&lt;item&gt;disable_edit&lt;/item&gt; Will diable editing of the cotracts.&lt;item&gt;disable_delete&lt;/item&gt; The user should be unable to delete the contract if a status with this role is set.&lt;item&gt;update_instance_data&lt;/item&gt; If a status is set with this role the instance data, e.g. contact information will be automatically updated when updated in a contact.&lt;/list&gt; | [optional] 
**HexCode** | **string** | Gets or sets the color of the status as hexadicimal value. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

