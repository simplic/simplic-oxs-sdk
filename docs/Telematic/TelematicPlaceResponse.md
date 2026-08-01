# Simplic.OxS.SDK.Telematic.TelematicPlaceResponse
Represents a place in a telematic tour with embedded workflow and step execution state.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InternalId** | **Guid?** | Gets or sets the internal id of the place. | [optional] 
**Name** | **string** | Gets or sets the place name | [optional] 
**Address** | [**AddressResponse**](AddressResponse.md) |  | [optional] 
**StartDateTimeUtc** | **DateTime?** | Gets or sets the start date time as utc. | [optional] 
**EndDateTimeUtc** | **DateTime?** | Gets or sets the end date time as utc. | [optional] 
**Latitude** | **double?** | Gets or sets the latitude of the place. | [optional] 
**Longitude** | **double?** | Gets or sets the longitude of the place. | [optional] 
**Reference** | **string** | Gets or sets a reference. | [optional] 
**Orders** | [**List&lt;TelematicOrderResponse&gt;**](TelematicOrderResponse.md) | Gets or sets the orders. | [optional] 
**Notes** | **string** | Gets or sets the job notes | [optional] 
**Workflow** | [**TelematicWorkflowResponse**](TelematicWorkflowResponse.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

