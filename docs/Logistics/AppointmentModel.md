# Simplic.OxS.SDK.Logistics.AppointmentModel
Represents the model of a Appointment.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the id. | [optional] 
**StartAddress** | [**AddressModel**](AddressModel.md) |  | [optional] 
**EndAddress** | [**AddressModel**](AddressModel.md) |  | [optional] 
**Resources** | [**List&lt;ResourceModel&gt;**](ResourceModel.md) | Gets or sets the resources of the appointment.  &lt;br&gt;  Each resource will have the same time and address for the whole appointment. Splitting these should be done  in other appointments.   | [optional] 
**Functions** | **List&lt;string&gt;** | Gets or sets a list of functinos for an appointment.  &lt;br&gt;  A function can change the behaviour of some methdos with the function added as string.  &lt;list type&#x3D;\&quot;bullet\&quot;&gt;&lt;item&gt;\&quot;blocking\&quot; : Will determine whether the appointment block other appointments or tours to be   scheduled at the same time for the contained resources.&lt;/item&gt;&lt;/list&gt; | [optional] 
**Title** | **string** | Gets or sets the title of the appointment. | [optional] 
**StartDateTime** | **DateTime** | Gets or sets the start date and time of the appointment. | [optional] 
**EndDateTime** | **DateTime** | Gets or sets the end date and time of the appointment. | [optional] 
**HexColor** | **string** | Gets or sets the hex color for the appointment.  &lt;br&gt;  Default color is light red.   | [optional] 
**IsDeleted** | **bool** | Gets or sets whether the Appointment is deleted. | [optional] 
**CreateDateTime** | **DateTime** | Gets or sets the create date time. | [optional] 
**CreateUserId** | **Guid?** | Gets or sets the create user id. | [optional] 
**UpdateDateTime** | **DateTime** | Gets or sets the update date time. | [optional] 
**UpdateUserId** | **Guid?** | Gets or sets the update user id. | [optional] 
**OrganizationId** | **Guid** | Gets or sets the organization id for the Appointment. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

