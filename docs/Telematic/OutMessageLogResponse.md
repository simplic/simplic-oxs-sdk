# Simplic.OxS.SDK.Telematic.OutMessageLogResponse
Represents the entry of a send message log.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the id. | [optional] 
**MessageType** | **string** | Gets or sets which message type is send. E.g. SendTour or SendTextMessage. | [optional] 
**Provider** | **string** | Gets or set the provider name. | [optional] 
**SourceMessageJson** | **string** | Gets or sets the message before conversion as json. | [optional] 
**DestinationMessageJson** | **string** | Gets or sets the message after conversion as json.  This should be the direct message send to the provider system. | [optional] 
**ResponseJson** | **string** | Gets or sets the resonse of the provider system as json. | [optional] 
**InternalVehicleId** | **Guid?** | Gets or sets the id of the vehicle the message is send to. | [optional] 
**InternalDriverId** | **Guid?** | Gets or sets the id of the driver the message is send to. | [optional] 
**InternalTourId** | **Guid?** | Gets or sets a potential internal tour id. | [optional] 
**StartDateTime** | **DateTime** | Gets or sets the start date time. | [optional] 
**EndDateTime** | **DateTime** | Gets or sets the end date time. | [optional] 
**Success** | **bool** | Gets or sets whether the send was successfull. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

