# Simplic.OxS.SDK.Organization.OrganizationLinkModel
Represents an organization link. A connection between two organizations

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ForeignOrganizationId** | **Guid** | Gets or sets the foreign organization id (organization-id - -&gt; foreign organization) | [optional] 
**OrganizationId** | **Guid** | Gets or sets the organization id of the owner of the connection | [optional] 
**Modules** | **List&lt;string&gt;** | Gets or sets the enabled modules | [optional] 
**State** | **OrganizationLinkState** |  | [optional] 
**CreateDateTime** | **DateTime** | Gets or sets the create date time of the link | [optional] 
**CreateUserId** | **Guid?** | Gets or sets the create user of the link | [optional] 
**CreateUserName** | **string** | Gets or sets the create user name of the link | [optional] 
**UpdateDateTime** | **DateTime** | Gets or sets the latest update date time of the link | [optional] 
**UpdateUserId** | **Guid?** | gets or sets the update user id of the link | [optional] 
**UpdateUserName** | **string** | Gets or sets the update user name of the link | [optional] 
**Originator** | **string** | Gets or sets the name of the member who created the initial invitation link | [optional] 
**AcceptedBy** | **string** | Gets or sets the name of the member who accepted the invitation | [optional] 
**InvitationId** | **Guid** | Gets or sets the id of the invitation that initiated the link | [optional] 
**OrganizationName** | **string** | Gets or sets the owner organization id (link owner) | [optional] 
**ForeignOrganizationName** | **string** | Gets or sets the organization name of the linked (foreign) organization | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

