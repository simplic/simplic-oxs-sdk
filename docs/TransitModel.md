# Simplic.OxS.SDK.Model.TransitModel
Class to represent a transit.  <br>  A transit describes a movement of the primary resource from one place to another during a tour.    Transits will be automaically generated and updated from a service.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the id. | [optional] 
**StartAddress** | [**AddressModel**](AddressModel.md) |  | [optional] 
**StartDateTime** | **DateTime** | Gets or sets the start date time of the transit. | [optional] 
**EndAddress** | [**AddressModel**](AddressModel.md) |  | [optional] 
**EndDateTime** | **DateTime** | Gets or sets the end date time off the transit. | [optional] 
**StartActionId** | **Guid?** | Gets or sets the id of the start action.  &lt;br&gt;  When the guid is null the transit will start at the start of the tour.   | [optional] 
**EndActionId** | **Guid?** | Gets or sets the id of the end action.  &lt;br&gt;  When the guid is null the transit will end at the end of the tour.   | [optional] 
**Distance** | **int** | Gets or sets the distance in meter | [optional] 
**TollDistance** | **int** | Gets or sets the toll distance in meter | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

