# Simplic.OxS.SDK.Logistics.CreateBillingLineStatusRequest
Represents a request to create a billing line status.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Gets or sets the name. | [optional] 
**Number** | **string** | Gets or sets the number.     The number is a human readable identifier for the status.   | [optional] 
**Roles** | **List&lt;string&gt;** | Gets or sets roles.     These roles will decide whether billing lines with the status can or can not to certain things.    A list of available roles at the moment:  &lt;list type&#x3D;\&quot;bullet\&quot;&gt;&lt;item&gt;is_default&lt;/item&gt; Will set the status as default, only one status should be a default status.&lt;item&gt;disable_edit&lt;/item&gt; Will diable editing of the billing lines.&lt;item&gt;billable&lt;/item&gt; Will set the billing line as billable.&lt;item&gt;disable_delete&lt;/item&gt; The user should be unable to delete the billing line if a status with this role is set.&lt;item&gt;billed&lt;/item&gt; If a status with this role is set the item is shown as billed.&lt;item&gt;update_instance_data&lt;/item&gt; If a status is set with this role the instance data, e.g. contact information will be automatically  updated when updated in a contact.&lt;/list&gt; | [optional] 
**HexColor** | **string** | Gets or sets the color as as hexadecimal value. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

