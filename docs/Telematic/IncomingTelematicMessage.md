# Simplic.OxS.SDK.Telematic.IncomingTelematicMessage

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] 
**OrganizationId** | **Guid** |  | [optional] 
**IsDeleted** | **bool** |  | [optional] 
**ProviderIdentifier** | **string** |  | [optional] 
**ProviderVehicleIdentifier** | **string** |  | [optional] 
**InternalVehicleIdentifier** | **Guid?** |  | [optional] 
**Text** | **string** |  | [optional] 
**Reference** | **string** |  | [optional] 
**Latitude** | **double** |  | [optional] 
**Longitude** | **double** |  | [optional] 
**Tour** | [**IncomingTour**](IncomingTour.md) |  | [optional] 
**Place** | [**IncomingPlace**](IncomingPlace.md) |  | [optional] 
**Order** | [**IncomingOrder**](IncomingOrder.md) |  | [optional] 
**FmsData** | [**FmsData**](FmsData.md) |  | [optional] 
**LocationInformation** | [**Address**](Address.md) |  | [optional] 
**Driver** | [**Driver**](Driver.md) |  | [optional] 
**MessageTimeUtc** | **DateTime?** |  | [optional] 
**MessageType** | [**List&lt;IncomingMessageType&gt;**](IncomingMessageType.md) |  | [optional] 
**QueueId** | **Guid?** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

