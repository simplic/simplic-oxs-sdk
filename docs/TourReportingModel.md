# Simplic.OxS.SDK.Model.TourReportingModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the id.  &lt;br&gt;  Represents a unique identifier for a tour.   | [optional] 
**GlobalTourId** | **Guid** | Gets or sets the global tour id.  &lt;br&gt;  The global tour id is used to group tours that were generated from the same tour.   | [optional] 
**Number** | **string** | Gets or sets the number of the tour. | [optional] 
**Reference** | **string** | Gets or sets the reference number. | [optional] 
**StartAddress** | [**AddressModel**](AddressModel.md) |  | [optional] 
**EndAddress** | [**AddressModel**](AddressModel.md) |  | [optional] 
**StartDateTime** | **DateTime** | Gets or sets the start date time.  &lt;br&gt;  Represents the date and time when the resource should start it&#39;s trip.    This just represents the planned date and time, not the actual start. | [optional] 
**EndDateTime** | **DateTime** | Gets or sets the end date time.  &lt;br&gt;  Rerpresents the date and time when the resource should end it&#39;s trip.    This just represents the planned date and time, not the actual end. | [optional] 
**TractorUnit1** | [**ResourceModel**](ResourceModel.md) |  | [optional] 
**TractorUnit2** | [**ResourceModel**](ResourceModel.md) |  | [optional] 
**TractorUnit3** | [**ResourceModel**](ResourceModel.md) |  | [optional] 
**Trailer1** | [**ResourceModel**](ResourceModel.md) |  | [optional] 
**Trailer2** | [**ResourceModel**](ResourceModel.md) |  | [optional] 
**Driver1** | [**ResourceModel**](ResourceModel.md) |  | [optional] 
**Driver2** | [**ResourceModel**](ResourceModel.md) |  | [optional] 
**Carrier1** | [**ResourceModel**](ResourceModel.md) |  | [optional] 
**Carrier2** | [**ResourceModel**](ResourceModel.md) |  | [optional] 
**Container1** | [**ResourceModel**](ResourceModel.md) |  | [optional] 
**Container2** | [**ResourceModel**](ResourceModel.md) |  | [optional] 
**Shipments** | [**List&lt;ShipmentModel&gt;**](ShipmentModel.md) |  | [optional] 
**FirstShipment** | [**ShipmentModel**](ShipmentModel.md) |  | [optional] 
**LastShipment** | [**ShipmentModel**](ShipmentModel.md) |  | [optional] 
**ShipmentItems** | [**List&lt;ReportingShipmentItem&gt;**](ReportingShipmentItem.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

