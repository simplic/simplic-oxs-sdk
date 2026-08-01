# Simplic.OxS.SDK.Telematic.TelematicOrderResponse
Represents an order in a telematic place.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InternalId** | **Guid?** | Gets or sets the internal id. | [optional] 
**OrderNumber** | **string** | Gets or sets the order number. | [optional] 
**ArticleName** | **string** | Gets or sets the name of the article in the order. | [optional] 
**OrderType** | **string** | Gets or sets the order type. | [optional] 
**Quantity** | **double?** | Gets or sets the quantity of the order. | [optional] 
**QuantityUnit** | **string** | Gets or sets the quantity unit of the order. | [optional] 
**Weight** | **double?** | Gets or sets the weight of the order. | [optional] 
**LoadingMeter** | **double?** | Gets or sets the loading meters of the order. | [optional] 
**Reference** | **string** | Gets or sets the reference. | [optional] 
**DeliveryNumber** | **string** | Gets or sets the delivery number. | [optional] 
**LoadNumber** | **string** | Gets or sets the load number. | [optional] 
**AttachedResources** | [**List&lt;TelematicResourceResponse&gt;**](TelematicResourceResponse.md) | Gets or sets the attached resources. | [optional] 
**ExternalNotes** | **string** | Gets or sets the external notes associated with the order. | [optional] 
**OpeningHours** | [**List&lt;OpeningHoursResponse&gt;**](OpeningHoursResponse.md) | Gets or sets the opening hours. | [optional] 
**Attachments** | [**List&lt;OutgoingAttachmentResponse&gt;**](OutgoingAttachmentResponse.md) | Gets or sets the attachments. | [optional] 
**Workflow** | [**TelematicWorkflowResponse**](TelematicWorkflowResponse.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

