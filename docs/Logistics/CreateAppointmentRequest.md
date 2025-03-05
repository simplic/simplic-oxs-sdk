# Simplic.OxS.SDK.Logistics.CreateAppointmentRequest
Request to create an appointment.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StartAddressId** | **Guid?** | Gets or sets the id of the start address. | [optional] 
**EndAddressId** | **Guid?** | Gets or sets the id of the end address. | [optional] 
**Resources** | **List&lt;Guid&gt;** | Gets or sets the resources for the appointment. | [optional] 
**Functions** | **List&lt;string&gt;** | Gets or sets a list of functinos for an appointment.     A function can change the behaviour of some methdos with the function added as string.  &lt;list type&#x3D;\&quot;bullet\&quot;&gt;&lt;item&gt;\&quot;blocking\&quot; : Will determine whether the appointment block other appointments or tours to be   scheduled at the same time for the contained resources.&lt;/item&gt;&lt;/list&gt; | [optional] 
**Title** | **string** | Gets or sets the title of the appointment. | 
**StartDateTime** | **DateTime** | Gets or sets the start date and time of the appointment. | 
**EndDateTime** | **DateTime** | Gets or sets the end date and time of the appointment. | 
**HexColor** | **string** | Gets or sets the hex color for the appointment.     Default color is light red.   | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

