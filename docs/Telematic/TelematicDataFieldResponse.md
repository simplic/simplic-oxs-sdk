# Simplic.OxS.SDK.Telematic.TelematicDataFieldResponse
Represents a data field within a telematic workflow step with collected value.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DataFieldId** | **Guid** | Gets or sets the data field id. | [optional] 
**IsRequired** | **bool** | Gets or sets whether the field is required. | [optional] 
**Name** | **string** | Gets or sets the name of the field. | [optional] 
**Localizations** | [**List&lt;DataFieldLocalizationResponse&gt;**](DataFieldLocalizationResponse.md) | Gets or sets the localizations for the field. | [optional] 
**Type** | **string** | Gets or sets the type of the data field. | [optional] 
**Value** | **string** | Gets or sets the collected value for this field. | [optional] 
**CollectedAtUtc** | **DateTime?** | Gets or sets the timestamp when the value was collected (UTC). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

