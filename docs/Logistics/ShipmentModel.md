# Simplic.OxS.SDK.Logistics.ShipmentModel
Shared model of shipment.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the id. | [optional] 
**CreateDateTime** | **DateTime** | Gets or sets the create date time  &lt;br&gt;  This defines the point of time the shipment is created.   | [optional] 
**UpdateDateTime** | **DateTime** | Get or sets the update date time.  &lt;br&gt;  This defines the last point of time the shipment was updated.   | [optional] 
**CreateUserId** | **Guid** | Gets or sets the create user id.  &lt;br&gt;  This is the user that created the shipment.   | [optional] 
**UpdateUserId** | **Guid** | Gets or sets the update user id.  &lt;br&gt;  This defines the user which made the last changes to the shipment.   | [optional] 
**LoadAddress** | [**AddressModel**](AddressModel.md) |  | [optional] 
**DeliveryAddress** | [**AddressModel**](AddressModel.md) |  | [optional] 
**Carrier** | [**BillableContactModel**](BillableContactModel.md) |  | [optional] 
**FreightPayer** | [**BillableContactModel**](BillableContactModel.md) |  | [optional] 
**Customer** | [**BillableContactModel**](BillableContactModel.md) |  | [optional] 
**RecipientAddress** | [**AddressModel**](AddressModel.md) |  | [optional] 
**InvoiceRecipient** | [**BillableContactModel**](BillableContactModel.md) |  | [optional] 
**SenderAddress** | [**AddressModel**](AddressModel.md) |  | [optional] 
**Supplier** | [**BillableContactModel**](BillableContactModel.md) |  | [optional] 
**LoadStart** | **DateTime** | Gets or sets the load time slot start with date and time  &lt;br&gt;  This will define the start of the time range the driver could start the loading process.    This will usually be set by the user or an api based on the values he gets from customer. | [optional] 
**LoadEnd** | **DateTime** | Gets or sets the load time slot end with date and time.  &lt;br&gt;  This will define the end of the time range the driver could end the loading process.    This will usually be set by the user or an api based on the values he gets from the customer. | [optional] 
**PlannedLoadStart** | **DateTime?** | Gets or sets the planned laod start with date and time.  &lt;br&gt;  This will define the planned start of the loading process.    This will usually be set by the user based on his dayplan for the resource. | [optional] 
**PlannedLoadEnd** | **DateTime?** | Gets or sets the planned load end with date and time.  &lt;br&gt;  This will define the planned end of the loading process.    This will usually be set by the user based on his dayplan for the resource. | [optional] 
**CalculatedLoadStart** | **DateTime?** | Gets or sets the calculated load start with date and time.  &lt;br&gt;  This will define the calculated / theoretical start of the loading process.    This will usually be set by an api based on data given by the telematics. | [optional] 
**CalculatedLoadEnd** | **DateTime?** | Gets or sets the calculated load end with date and time.  &lt;br&gt;  This will define the calculated / theoretical end of the laoding process.    This will usually be set by an api based on data given by the telematics. | [optional] 
**ActualLoadStart** | **DateTime?** | Gets or sets the actual laod start with date and time.  &lt;br&gt;  This will define the actual start of the loading process.    This will usually be set by an api based on the data given by the telematics. | [optional] 
**ActualLoadEnd** | **DateTime?** | Gets or sets the actual load end with date and time.  &lt;br&gt;  This will define the actual end of the loading process.    This will usually be set by an api based on the data given by the telematics | [optional] 
**LoadingTimeType** | **LoadingDateTimeType** |  | [optional] 
**DeliveryStart** | **DateTime** | Gets or sets the delivery time slot start with date and time.  &lt;br&gt;  This will define the start of the time range when the driver could deliver the shipment.    This will usually be set by the user or an api based on the values he gets from the customer. | [optional] 
**DeliveryEnd** | **DateTime** | Gets or sets the delivery time slot end with date and time.  &lt;br&gt;  This will define the end of the time range when the driver could deliver the shipment.    This will usually be set by the user or an api based on the values he gets from the customer. | [optional] 
**PlannedDeliveryStart** | **DateTime?** | Gets or sets the planned delivery start with date and time.  &lt;br&gt;  This defines the planned start of the delivery / unloading process.    This will usually be set by the user based on his dayplan of the resource. | [optional] 
**PlannedDeliveryEnd** | **DateTime?** | Gets or sets the planned delivery end with date and time.  &lt;br&gt;  This defines the planned end off the delivery / unlaoding process.    This will usually be set by the user based on his dayplan of the resource. | [optional] 
**CalculatedDeliveryStart** | **DateTime?** | Gets or sets the calculated delivery start with date and time.  &lt;br&gt;  This defines the calculated start of the delivery / unlaoding process.    This will usually be set by an api based on telematics data. | [optional] 
**CalculatedDeliveryEnd** | **DateTime?** | Gets or sets the calculated delivery end with date and time.  &lt;br&gt;  This defines the calculated end of the delivery / unlaoding process.    This will usually be set by an api based on telematics data. | [optional] 
**ActualDeliveryStart** | **DateTime?** | Gets or sets the actual delivery start with date and time.  &lt;br&gt;  This defines the actual start of the delivery / unlaoding process.    This will usually be set by an api based on telematics data. | [optional] 
**ActualDeliveryEnd** | **DateTime?** | Gets or sets the actual delivery end with date and time.  &lt;br&gt;  This defines the actual end of the delivery / unlaoding process.    This will usually be set by an api based on telematics data. | [optional] 
**DeliveryTimeType** | **LoadingDateTimeType** |  | [optional] 
**OrderDate** | **DateTime** | Gets or sets the order date.  &lt;br&gt;  This defines the date the shipment is ordered at.  This is a relevant information for the billing process and needs to be set.   | [optional] 
**ShipmentNumber** | **string** | Gets or sets the shipment number.  &lt;br&gt;  This defines a number to identify the shipment as the user.   | [optional] 
**ReferenceNumber** | **string** | Gets or sets the reference number  &lt;br&gt;  This defines a number that references the same shipment in another programm or context.   | [optional] 
**LoadNumber** | **string** | Gets or sets the load number.  &lt;br&gt;  This defines a number that the driver might need to load this shipment   | [optional] 
**DeliveryNumber** | **string** | Gets or sets the delivery number.  &lt;br&gt;  This defines a number that the driber might need to deliver / unload this shipment.   | [optional] 
**IsTemplate** | **bool** | Gets or sets werther the shipment is a template.  &lt;br&gt;  Template shipments are used to create shipments with certain values preset.   | [optional] 
**TemplateName** | **string** | Gets or sets the template name.  &lt;br&gt;  A name for the template to give the user the option to find it easier   | [optional] 
**Status** | [**ShipmentStatusModel**](ShipmentStatusModel.md) |  | [optional] 
**TransportOrder** | [**ShipmentTransportOrderModel**](ShipmentTransportOrderModel.md) |  | [optional] 
**Items** | [**List&lt;ShipmentItemModel&gt;**](ShipmentItemModel.md) | Gets or sets shipment items.  &lt;br&gt;  Represents a list of items of a shipment which will contain further information about the freight.   | [optional] 
**Documents** | [**List&lt;ShipmentDocumentModel&gt;**](ShipmentDocumentModel.md) | Gets or sets the documments.  &lt;br&gt;  These documents contain more information that just the shipment.   E.g. the shipment item id or weight note id.    Furthermore documents might be marked for invoices and ordered for them. | [optional] 
**Tags** | [**List&lt;ShipmentTagModel&gt;**](ShipmentTagModel.md) | Gets or sets the tags.  &lt;br&gt;  Tags are short texts to add information to a shipment without the need to add new properties.    These are e.g. used in the pricing module to add some additional conditions. | [optional] 
**Notes** | **string** | Gets or sets the nots.  &lt;br&gt;  This gives the user the possibillity to add some more sentences about this shipment.   | [optional] 
**IsDeleted** | **bool** | Gets or sets whether the shipment is deleted. | [optional] 
**LoadWorkflow** | [**ShipmentTelematicWorkflowModel**](ShipmentTelematicWorkflowModel.md) |  | [optional] 
**DeliveryWorkflow** | [**ShipmentTelematicWorkflowModel**](ShipmentTelematicWorkflowModel.md) |  | [optional] 
**Tours** | [**List&lt;ShipmentTourModel&gt;**](ShipmentTourModel.md) | Gets or sets a list of tour shipments.  &lt;br&gt;  This collection will be filled when creating or updating tour objects.   | [optional] 
**ConstructionSite** | [**ConstructionSiteModel**](ConstructionSiteModel.md) |  | [optional] 
**Addon** | **Dictionary&lt;string, Object&gt;** | Gets or sets a dictionary of addon properties.  &lt;br&gt;  Can be used to set customer exclusive properties for a shipment.   | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
