# Simplic.OxS.SDK.Organization.OrganizationSiteModel
Represents an organization site

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the unique id of the organization site | [optional] 
**Name** | **string** | Gets or sets the display name of the organization site | [optional] 
**Address** | [**AddressModelResponse**](AddressModelResponse.md) |  | [optional] 
**TimeZoneId** | **string** | Gets or sets the id of the time zone of the organization site, as used by  M:System.TimeZoneInfo.FindSystemTimeZoneById(System.String). Defaults to the IANA id  \&quot;Europe/Berlin\&quot; so it also resolves on Linux based microservices. | [optional] 
**IsDeleted** | **bool?** | Gets or sets a is deleted flag. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

