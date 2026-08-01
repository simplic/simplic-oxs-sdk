# Simplic.OxS.SDK.Telematic.CreateEmploymentConfigurationRequest
Request to create a employment configuration.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EmploymentId** | **Guid** | Gets or sets the employment identifer referencing OxS.Hr employment ids. | [optional] 
**MatchCode** | **string** | Gets or sets the matchcode. | [optional] 
**ProviderName** | **string** | Gets or sets the telematic provider by its name. E.g. &#39;spedion&#39;. | [optional] 
**ExternalDriverIdentifier** | **string** | Gets or sets the identifier from the telematic provider for the employment. | [optional] 
**ValidFrom** | **DateTime** | Gets or sets from when the configuration is valid. | [optional] 
**ValidTo** | **DateTime** | Gets or sets until when the configuration is valid. | [optional] 
**ActiveServices** | **List&lt;string&gt;** | Gets or sets a list of active services.  The full list of available services should be taken from the get available services endpoint. A * will mean all services are active for the configuration. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

