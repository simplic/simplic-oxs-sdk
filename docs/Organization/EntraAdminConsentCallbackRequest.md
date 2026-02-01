# Simplic.OxS.SDK.Organization.EntraAdminConsentCallbackRequest
Represents the callback request from Entra ID after admin consent is granted or denied.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdminConsent** | **string** | Gets or sets whether admin consent was granted (should be \&quot;True\&quot; if granted). | [optional] 
**Tenant** | **string** | Gets or sets the Entra tenant ID. | [optional] 
**State** | **string** | Gets or sets the state parameter that was passed in the initial request. | [optional] 
**Error** | **string** | Gets or sets the error code if consent was denied or failed. | [optional] 
**ErrorDescription** | **string** | Gets or sets the error description if consent was denied or failed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

