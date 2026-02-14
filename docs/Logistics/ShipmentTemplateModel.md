# Simplic.OxS.SDK.Logistics.ShipmentTemplateModel
Shared Model of a Shipment Template

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the id. | [optional] 
**CreateUserId** | **Guid** | Gets or sets the create user id.     This is the user that created the shipment.   | [optional] 
**UpdateUserId** | **Guid** | Gets or sets the update user id.     This defines the user which made the last changes to the shipment.   | [optional] 
**LoadAddress** | [**AddressModel**](AddressModel.md) |  | [optional] 
**DeliveryAddress** | [**AddressModel**](AddressModel.md) |  | [optional] 
**Carrier** | [**BillableContactModel**](BillableContactModel.md) |  | [optional] 
**FreightPayer** | [**BillableContactModel**](BillableContactModel.md) |  | [optional] 
**Customer** | [**BillableContactModel**](BillableContactModel.md) |  | [optional] 
**RecipientAddress** | [**AddressModel**](AddressModel.md) |  | [optional] 
**InvoiceRecipient** | [**BillableContactModel**](BillableContactModel.md) |  | [optional] 
**SenderAddress** | [**AddressModel**](AddressModel.md) |  | [optional] 
**Supplier** | [**BillableContactModel**](BillableContactModel.md) |  | [optional] 
**ShipmentNumber** | **string** |  | [optional] 
**ReferenceNumber** | **string** | Gets or sets the reference number     This defines a number that references the same shipment in another programm or context.   | [optional] 
**LoadNumber** | **string** | Gets or sets the load number.     This defines a number that the driver might need to load this shipment   | [optional] 
**DeliveryNumber** | **string** | Gets or sets the delivery number.     This defines a number that the driber might need to deliver / unload this shipment.   | [optional] 
**IsTemplate** | **bool** | Gets or sets werther the shipment is a template.     Template shipments are used to create shipments with certain values preset.   | [optional] 
**TemplateName** | **string** | Gets or sets the template name.     A name for the template to give the user the option to find it easier   | [optional] 
**TransportOrder** | [**ShipmentTransportOrderModel**](ShipmentTransportOrderModel.md) |  | [optional] 
**Items** | [**List&lt;ShipmentItemModel&gt;**](ShipmentItemModel.md) | Gets or sets shipment items.     Represents a list of items of a shipment which will contain further information about the freight.   | [optional] 
**Documents** | [**List&lt;ShipmentDocumentModel&gt;**](ShipmentDocumentModel.md) | Gets or sets the documments.     These documents contain more information that just the shipment.   E.g. the shipment item id or weight note id.    Furthermore documents might be marked for invoices and ordered for them. | [optional] 
**Tags** | [**List&lt;ShipmentTagModel&gt;**](ShipmentTagModel.md) | Gets or sets the tags.     Tags are short texts to add information to a shipment without the need to add new properties.    These are e.g. used in the pricing module to add some additional conditions. | [optional] 
**Notes** | **string** | Gets or sets the nots.     This gives the user the possibillity to add some more sentences about this shipment.   | [optional] 
**IsDeleted** | **bool** | Gets or sets whether the shipment is deleted. | [optional] 
**LoadWorkflow** | [**ShipmentTelematicWorkflowModel**](ShipmentTelematicWorkflowModel.md) |  | [optional] 
**DeliveryWorkflow** | [**ShipmentTelematicWorkflowModel**](ShipmentTelematicWorkflowModel.md) |  | [optional] 
**ConstructionSite** | [**ConstructionSiteModel**](ConstructionSiteModel.md) |  | [optional] 
**Department** | [**DepartmentResponse**](DepartmentResponse.md) |  | [optional] 
**Addon** | **Dictionary&lt;string, Object&gt;** | Gets or sets a dictionary of addon properties.     Can be used to set customer exclusive properties for a shipment.   | [optional] 
**Tariff** | [**TariffModel**](TariffModel.md) |  | [optional] 
**CarrierTariff** | [**TariffModel**](TariffModel.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

