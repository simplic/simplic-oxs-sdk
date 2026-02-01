# Simplic.OxS.SDK.Organization.OrganizationModel
Represents an organization

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the organization id | [optional] 
**Name** | **string** | Gets or sets the organization name | [optional] 
**Address** | [**AddressModelResponse**](AddressModelResponse.md) |  | [optional] 
**BillingAddressModel** | [**BillingAddressModel**](BillingAddressModel.md) |  | [optional] 
**IsDummy** | **bool** | Whether this organization is used for testing purposes.  This allows for deleting it | [optional] 
**EntraTenantId** | **string** | Gets or set the entra tenant id | [optional] 
**EntraIdAdminConsent** | **bool** | Gets or sets a value indicating whether admin consent has been granted for the application in Azure Active  Directory. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

