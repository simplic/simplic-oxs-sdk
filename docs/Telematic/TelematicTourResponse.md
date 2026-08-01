# Simplic.OxS.SDK.Telematic.TelematicTourResponse
Represents a telematic tour response with complete workflow information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InternalId** | **Guid?** | Gets or sets an internal reference to the source object. | [optional] 
**TourNumber** | **string** | Gets or sets a human readable identifier for the tour. | [optional] 
**Reference** | **string** | Gets or sets any other reference for the customer. | [optional] 
**InternalVehicleId** | **Guid?** | Gets or sets the simplic id of the vehicle. | [optional] 
**InternalDriverId** | **Guid?** | Gets or sets the simplic id of the driver (employment). | [optional] 
**StartDateTimeUtc** | **DateTime?** | Gets or sets the start date and time of the tour. | [optional] 
**EndDateTimeUtc** | **DateTime?** | Gets or sets the end date and time of the tour. | [optional] 
**Places** | [**List&lt;TelematicPlaceResponse&gt;**](TelematicPlaceResponse.md) | Gets or sets a list of places with their embedded workflows and execution state. | [optional] 
**PublicKey** | **string** | Gets or sets the public key used to identify or authenticate the tour. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

