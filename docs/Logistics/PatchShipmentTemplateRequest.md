# Simplic.OxS.SDK.Logistics.PatchShipmentTemplateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LoadAddressId** | **Guid?** |  | [optional] 
**DeliveryAddressId** | **Guid?** |  | [optional] 
**RecipientAddressId** | **Guid?** |  | [optional] 
**SenderAddressId** | **Guid?** |  | [optional] 
**CarrierPersonalAccountId** | **Guid?** |  | [optional] 
**CarrierAddressId** | **Guid?** |  | [optional] 
**FreightPayerPersonalAccountId** | **Guid?** |  | [optional] 
**FreightPayerAddressId** | **Guid?** |  | [optional] 
**CustomerPersonalAccountId** | **Guid?** |  | [optional] 
**CustomerAddressId** | **Guid?** |  | [optional] 
**InvoiceRecipientPersonalAccountId** | **Guid?** |  | [optional] 
**InvoiceRecipientAddressId** | **Guid?** |  | [optional] 
**SupplierPersonalAccountId** | **Guid?** |  | [optional] 
**SupplierAddressId** | **Guid?** |  | [optional] 
**ShipmentNumber** | **string** | Gets or sets the shipment number.     This defines a number to identify the shipment as the user.   | [optional] 
**ReferenceNumber** | **string** | Gets or sets the reference number     This defines a number that references the same shipment in another programm or context.   | [optional] 
**LoadNumber** | **string** | Gets or sets the load number.     This defines a number that the driver might need to load this shipment   | [optional] 
**DeliveryNumber** | **string** | Gets or sets the delivery number.     This defines a number that the driber might need to deliver / unload this shipment.   | [optional] 
**IsTemplate** | **bool** | Gets or sets werther the shipment is a template.     Template shipments are used to create shipments with certain values preset.   | [optional] 
**TemplateName** | **string** | Gets or sets the template name.     A name for the template to give the user the option to find it easier   | [optional] 
**TransportOrder** | [**ShipmentTransportOrderModel**](ShipmentTransportOrderModel.md) |  | [optional] 
**Documents** | [**List&lt;ShipmentDocumentModel&gt;**](ShipmentDocumentModel.md) | Gets or sets the documments.     These documents contain more information that just the shipment.   E.g. the shipment item id or weight note id.    Furthermore documents might be marked for invoices and ordered for them. | [optional] 
**Tags** | [**List&lt;ShipmentTagModel&gt;**](ShipmentTagModel.md) | Gets or sets the tags.     Tags are short texts to add information to a shipment without the need to add new properties.    These are e.g. used in the pricing module to add some additional conditions. | [optional] 
**Notes** | **string** | Gets or sets the notes.     This gives the user the possibillity to add some more sentences about this shipment.   | [optional] 
**IsDeleted** | **bool** | Gets or sets whether the shipment is deleted. | [optional] 
**LoadWorkflow** | [**ShipmentTelematicWorkflowModel**](ShipmentTelematicWorkflowModel.md) |  | [optional] 
**DeliveryWorkflow** | [**ShipmentTelematicWorkflowModel**](ShipmentTelematicWorkflowModel.md) |  | [optional] 
**ConstructionSiteId** | **Guid?** | Gets or sets a construction site id.     The id will be resolved by the construction site api.   | [optional] 
**DepartmentId** | **Guid?** | Gets or sets the department id. | [optional] 
**Addon** | **Dictionary&lt;string, Object&gt;** | Gets or sets a dictionary of addon properties.     Can be used to set customer exclusive properties for a shipment.   | [optional] 
**Tariff** | [**TariffModel**](TariffModel.md) |  | [optional] 
**CarrierTariff** | [**TariffModel**](TariffModel.md) |  | [optional] 
**Items** | [**List&lt;PatchShipmentItemRequest&gt;**](PatchShipmentItemRequest.md) | Gets or sets shipment template items.     Represents a list of items of a shipment which will contain further information about the freight.   | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

