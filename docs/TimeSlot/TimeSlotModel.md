# Simplic.OxS.SDK.TimeSlot.TimeSlotModel
Represents a timeslot model

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the timeslot id | [optional] 
**OrganizationId** | **Guid** | Gets or sets the timeslot orgaization id | [optional] 
**SiteId** | **Guid** | Gets or sets the organization site id | [optional] 
**SiteName** | **string** | Gets or sets the organization site name | [optional] 
**Start** | **DateTime** | Gets or sets the start datetime | [optional] 
**End** | **DateTime** | Gets or sets the end datetime | [optional] 
**Location** | **string** | Gets or sets the locaiton name | [optional] 
**State** | **BookingState** |  | [optional] 
**ForeignOrganizationId** | **Guid?** | Gets or sets the organization, that has booked the time slot | [optional] 
**BookingDetails** | [**BookingDetailsModel**](BookingDetailsModel.md) |  | [optional] 
**CreateDateTime** | **DateTime** | Gets or sets the date and time the TimeSlot is created. | [optional] 
**CreateUserId** | **Guid?** | Gets or sets the id of the user that created the timeslot. | [optional] 
**CreateUserName** | **string** | Gets or sets the name of the user taht created the timeslot. | [optional] 
**UpdateDateTime** | **DateTime** | Gets or sets the date and time the TimeSlot is updated. | [optional] 
**UpdateUserId** | **Guid?** | Gets or sets the id of the user taht updated the timeslot. | [optional] 
**UpdateUserName** | **string** | Gets or sets the name of the user that updated the timeslot. | [optional] 
**TimeOfArrival** | **DateTime?** | Gets or sets the time pf arrival. | [optional] 
**LoadingStartTime** | **DateTime?** | Gets or sets the starting time of loading. | [optional] 
**LoadingEndTime** | **DateTime?** | Gets or sets the ending time of loading. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

