# Simplic.OxS.SDK.Logistics.EstimatedTimeOfArrivalResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TourId** | **Guid** | Gets or sets the tour id. | [optional] 
**ResourceId** | **Guid** | Gets or sets the id of the main resource of the tour. | [optional] 
**StartActionId** | **Guid?** | Gets or sets the id of the action that starts the eta.  &lt;br&gt;  When the start action id is null the tour start will be the start of the eta.   | [optional] 
**GlobalStartActionId** | **Guid?** | Gets or sets the global id of the start action. | [optional] 
**EndActionId** | **Guid?** | Gets er sets the id of the action that ends the eta.  &lt;br&gt;  When the end action id is null the tour end will be the end of the eta.   | [optional] 
**GlobalEndActionId** | **Guid?** | Gets or sets the global id of the end action. | [optional] 
**StartDateTime** | **DateTime?** | Gets or sets the date and time when the eta will start. | [optional] 
**StartLongitude** | **double** | Gets or sets the longitude of the start of the eta. | [optional] 
**StartLatitude** | **double** | Gets or sets the latitude of the start of the eta. | [optional] 
**CurrentLongitude** | **double** | Gets or sets the longitude of the current position of the resource. | [optional] 
**CurrentLatitude** | **double** | Gets or sets the latitude of the current position of the resource. | [optional] 
**EndLongitude** | **double** | Gets or sets the longitude of the end of th eta. | [optional] 
**EndLatitude** | **double** | Gets or sets the latitude of the end of the eta. | [optional] 
**RemainingMinutes** | **int** | Gets or sets the remaining time in minutes. | [optional] 
**RemainingDistanceMeters** | **int** | Gets or sets the remaining distance in meters. | [optional] 
**RemainingTimePercent** | **int** | Gets or sets the percentage of the time remaining. | [optional] 
**RemainingDistancePercent** | **int** | Gets or sets the percentage of the distance remaining. | [optional] 
**CalculatedEndDateTime** | **DateTime** | Gets or sets the calculated end date time. | [optional] 
**PlannedEndDateTime** | **DateTime** | Gets or sets the planned end date and time.   &lt;br&gt;The State will be calculated by comparing the calculated end date time with the planned and the tolerance. | [optional] 
**ToleranceMinutes** | **int** | Gets or sets the tolerance for a delay in minutes. | [optional] 
**LastCalculation** | **DateTime** | Gets or sets the date and time of the last calculation. | [optional] 
**State** | **ETAState** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

