# Simplic.OxS.SDK.Logistics.TransitModel
Class to represent a transit.     A transit describes a movement of the primary resource from one place to another during a tour.    Transits will be automaically generated and updated from a service.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the id. | [optional] 
**StartAddress** | [**AddressModel**](AddressModel.md) |  | [optional] 
**StartDateTime** | **DateTime** | Gets or sets the start date time of the transit. | [optional] 
**EndAddress** | [**AddressModel**](AddressModel.md) |  | [optional] 
**EndDateTime** | **DateTime** | Gets or sets the end date time off the transit. | [optional] 
**StartActionId** | **Guid?** | Gets or sets the id of the start action.     When the guid is null the transit will start at the start of the tour.   | [optional] 
**GlobalStartActionId** | **Guid?** | Gets or sets the global id of the start action.     Will contain the tour id in case of the start of the tour.   | [optional] 
**EndActionId** | **Guid?** | Gets or sets the id of the end action.     When the guid is null the transit will end at the end of the tour.   | [optional] 
**GlobalEndActionId** | **Guid?** | Gets or sets the global id of the end action.     Will contain the tour id in case of the end of the tour.   | [optional] 
**Distance** | **int** | Gets or sets the distance in meter | [optional] 
**TollDistance** | **int** | Gets or sets the toll distance in meter | [optional] 
**TollCosts** | **double** | Gets or sets the toll cost in EUR.  If the value is -1, one of the addresses has no geo-coordinates  If the value is -2, Calculating the route throws an exception | [optional] 
**DrivingTime** | **string** | Gets or sets the estimated driving time. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

