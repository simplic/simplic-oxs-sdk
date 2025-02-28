# Simplic.OxS.SDK.Logistics.GetComposedResourceResponse
Response for a request that returns a composed resource.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or setsthe id of the composed resource. | [optional] 
**TractorUnit** | [**GetComposedTractorUnitResponse**](GetComposedTractorUnitResponse.md) |  | [optional] 
**Trailer** | [**List&lt;GetComposedTrailerResponse&gt;**](GetComposedTrailerResponse.md) | Gets or sets the trailer of a composed resource.     Usually only a single trailer will be added, but when attaching a trailer it should have an option to add   another one.   | [optional] 
**MainDriver** | [**GetComposedDriverResponse**](GetComposedDriverResponse.md) |  | [optional] 
**CoDriver** | [**GetComposedDriverResponse**](GetComposedDriverResponse.md) |  | [optional] 
**Location** | [**GetComposedLocationResponse**](GetComposedLocationResponse.md) |  | [optional] 
**LatestMessage** | [**GetComposedMessageResponse**](GetComposedMessageResponse.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

