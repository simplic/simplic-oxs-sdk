# Simplic.OxS.SDK.Organization.OrganizationLinkInvitationModel
Represents an invitation for an organization to a foreign organization

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the id of the invitation | [optional] 
**OrganizationId** | **Guid** | Gets or sets the id of the originator organization | [optional] 
**Email** | **string** | Gets or sets an e-mail address as recipient for the invitation | [optional] 
**Domain** | **string** | Gets or sets the domain to which the invitation belongs. (one-time invitation) | [optional] 
**Token** | **string** | Gets or sets the unique invitation token | [optional] 
**State** | **OrganizationLinkState** |  | [optional] 
**Modules** | **List&lt;string&gt;** | Gets or sets a list of modules that belongs to the invitation and will be added  to the list of available modules when accepting the invitation. | [optional] 
**ExpireDate** | **DateTime** | Gets or sets the expire date of the invitation | [optional] 
**OrganizationName** | **string** | Gets or sets the name of the organization who has initiated the invitation | [optional] 
**Originator** | **string** | Gets or sets the member name of the invitation creator | [optional] 
**Type** | **OrganizationInvitaitonType** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

