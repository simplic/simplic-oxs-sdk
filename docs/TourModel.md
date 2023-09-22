# Simplic.OxS.SDK.Model.TourModel
Shared model of tour.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the id.  &lt;br&gt;  Represents a unique identifier for a tour.   | [optional] 
**GlobalTourId** | **Guid** | Gets or sets the global tour id.  &lt;br&gt;  The global tour id is used to group tours that were generated from the same tour.   | [optional] 
**Number** | **string** | Gets or sets the number of the tour. | [optional] 
**Reference** | **string** | Gets or sets the reference number. | [optional] 
**Resource** | [**ResourceModel**](ResourceModel.md) |  | [optional] 
**StartAddress** | [**AddressModel**](AddressModel.md) |  | [optional] 
**EndAddress** | [**AddressModel**](AddressModel.md) |  | [optional] 
**StartDateTime** | **DateTime** | Gets or sets the start date time.  &lt;br&gt;  Represents the date and time when the resource should start it&#39;s trip.    This just represents the planned date and time, not the actual start. | [optional] 
**EndDateTime** | **DateTime** | Gets or sets the end date time.  &lt;br&gt;  Rerpresents the date and time when the resource should end it&#39;s trip.    This just represents the planned date and time, not the actual end. | [optional] 
**ActualStartDateTime** | **DateTime?** | Gets or sets the actual start date and time.  &lt;br&gt;  This represents the time the resource actually started it&#39;s trip, not the planned start.   | [optional] 
**ActualEndDateTime** | **DateTime?** | Gets or sets the actual end date and time.  &lt;br&gt;  This represents the time the resource actually ended it&#39;s trip, not the planned end.   | [optional] 
**CalculatedStartDateTime** | **DateTime?** | Gets or sets the calculated start date and time.  &lt;br&gt;  This value should be calculated by a service and not set by the user in most cases.   | [optional] 
**CalculatedEndDateTime** | **DateTime?** | Gets or sets the calculated end date and time.  &lt;br&gt;  This value should be calculated by a service and not set by the user in most cases.   | [optional] 
**Actions** | [**List&lt;TourActionModel&gt;**](TourActionModel.md) | Gets or sets the tour actions.  &lt;br&gt;  This list contains a list of actions which define single events during the trip.    This list will be the primary resource for the generation of attached resources and entities.  &lt;br&gt;  Some of these actoins might be e.g.: \&quot;Add trailer\&quot;, \&quot;Change tractor unit\&quot; or \&quot;Load shipment\&quot;.   | [optional] 
**AttachedResources** | [**List&lt;AttachedResourceModel&gt;**](AttachedResourceModel.md) | Gets or sets the attached resources.  &lt;br&gt;  Each attached resource will be generetad from a attaching and detaching action.    The user should not be able to add data to this list directly. | [optional] 
**AttachedEntities** | [**List&lt;AttachedEntityModel&gt;**](AttachedEntityModel.md) | Gets or sets the attached entities.  &lt;br&gt;  Each attached entity will be generated from a attaching and detaching action.    The user should not be able to add data to this list directly. | [optional] 
**Tags** | [**List&lt;TourTagModel&gt;**](TourTagModel.md) | Gets or sets tour tags.  &lt;br&gt;  Tags are shorts additional information that can be added to a tour.   | [optional] 
**Transits** | [**List&lt;TransitModel&gt;**](TransitModel.md) | Gets or sets transits.  &lt;br&gt;  A transit is a trip/movement of the primary resource from one place to another.   | [optional] 
**Status** | [**TourStatusModel**](TourStatusModel.md) |  | [optional] 
**IsMirroredTour** | **bool?** | Gets or sets whether the tour is mirrored. | [optional] 
**Notes** | **string** | Gets or sets a note to the tour. | [optional] 
**IsDeleted** | **bool** | Gets or sets werther the tour is deleted. | [optional] 
**CreateDateTime** | **DateTime** | Gets or sets the tour create date time | [optional] 
**UpdateDateTime** | **DateTime** | Gets or sets the tour update date time | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

