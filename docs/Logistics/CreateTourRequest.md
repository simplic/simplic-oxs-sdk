# Simplic.OxS.SDK.Logistics.CreateTourRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Number** | **string** | Gets or sets the number of the tour. | [optional] 
**Reference** | **string** | Gets or sets the reference number. | [optional] 
**ResourceId** | **Guid?** | Gets or sets the resource id.  &lt;br&gt;  Will be resolved as resouce.   | [optional] 
**StartAddressId** | **Guid?** | Gets or sets the start address id.  &lt;br&gt;  Will be resolved to the start address.   | [optional] 
**EndAddressId** | **Guid?** | Gets or sets the end address id.  &lt;br&gt;  Will be resolved to the end address.   | [optional] 
**StartDateTime** | **DateTime?** | Gets or sets the start date time.  &lt;br&gt;  Represents the date and time when the resource should start it&#39;s trip.    This just represents the planned date and time, not the actual start. | [optional] 
**EndDateTime** | **DateTime?** | Gets or sets the end date time.  &lt;br&gt;  Rerpresents the date and time when the resource should end it&#39;s trip.    This just represents the planned date and time, not the actual end. | [optional] 
**ActualStartDateTime** | **DateTime?** | Gets or sets the actual start date and time.  &lt;br&gt;  This represents the time the resource actually started it&#39;s trip, not the planned start.   | [optional] 
**ActualEndDateTime** | **DateTime?** | Gets or sets the actual end date and time.  &lt;br&gt;  This represents the time the resource actually ended it&#39;s trip, not the planned end.   | [optional] 
**CalculatedStartDateTime** | **DateTime?** | Gets or sets the calculated start date and time.  &lt;br&gt;  This value should be calculated by a service and not set by the user in most cases.   | [optional] 
**CalculatedEndDateTime** | **DateTime?** | Gets or sets the calculated end date and time.  &lt;br&gt;  This value should be calculated by a service and not set by the user in most cases.   | [optional] 
**Notes** | **string** | Gets or sets a note. | [optional] 
**Tags** | **List&lt;Guid&gt;** | Sets the tags of the tour. | [optional] 
**Actions** | [**List&lt;CreateTourActionRequest&gt;**](CreateTourActionRequest.md) | Gets or sets the tour actions.  &lt;br&gt;  This list contains a list of actions which define single events during the trip.    This list will be the primary resource for the generation of attached resources and entities.  &lt;br&gt;  Some of these actoins might be e.g.: \&quot;Add trailer\&quot;, \&quot;Change tractor unit\&quot; or \&quot;Load shipment\&quot;.   | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

