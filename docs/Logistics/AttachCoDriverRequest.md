# Simplic.OxS.SDK.Logistics.AttachCoDriverRequest
Reqeust to attach a co driver.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ComposedResourceId** | **Guid** | Gets or sets the id of the composed resource the driver is attached to. | 
**DriverResourceId** | **Guid** | Gets or sets the id of the driver resource to attach to the composed resource. | 
**MoveCurrentToMainDriverSeat** | **bool** | Gets or sets whether the current co driver should be moved to the main driver seat.     If set to false the current co driver will be detached from the given composed resource   and be attached to its own.   | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

