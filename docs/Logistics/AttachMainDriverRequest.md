# Simplic.OxS.SDK.Logistics.AttachMainDriverRequest
Request to attach a driver as main driver.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ComposedResourceId** | **Guid** | Gets or sets the id of the composed resource the main driver is attached to. | 
**DriverResourceId** | **Guid** | Gets or sets the id of the driver to attach as the main driver. | 
**MoveCurrentToCoDriverSeat** | **bool** | Gets or sets whether the current main driver will be moved to the co driver seat.     If set to false the current main driver will be detached from the composed resource and will be attached  to its own composed resource.   | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

