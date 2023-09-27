# Simplic.OxS.SDK.Logistics.Model.ShipmentTransportOrderModel
Shared model of shipment transport order.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the id.  &lt;br&gt;  Represents the primary identifier of a transport order.   | [optional] 
**CustomerAddress** | [**AddressModel**](AddressModel.md) |  | [optional] 
**OverriceCustomerAddress** | **bool** | Gets or sets whether the customer address will be overwritten.  &lt;br&gt;  If this one is set to true the customer address of all contained shipments will be set to the same  cusomer address as the one in this transport order.   | [optional] 
**CarrierAddress** | [**AddressModel**](AddressModel.md) |  | [optional] 
**OverrideCarrierAddress** | **bool** | Gets or sets whether the carrier address will be overwritten.  &lt;br&gt;  If this is set to true the carrier address of all contained shipments will be set to the same carrier  address as the one in this transport order.   | [optional] 
**FreightPayerAddress** | [**AddressModel**](AddressModel.md) |  | [optional] 
**OverrideFreightPayerAddress** | **bool** | Gets or sets whether the freight payer address will be overwritten.  &lt;br&gt;  If ths is set to true the freight payer address of all contained shipments will be set to the same   freight payer address as the one in this transport order.   | [optional] 
**Number** | **string** | Gets or sets the number.  &lt;br&gt;  The number is a human readable identifier for this transport order.    A number should be  unique within a tenant and is usually set by the sequence manager. | [optional] 
**ReferenceNumber** | **string** | Gets or sets the reference number.  &lt;br&gt;  Usually represents the number of another programm or the customer number for this object.   | [optional] 
**InternalNumber** | **string** | Gets or sets the number. | [optional] 
**OrderDate** | **DateTime?** | Gets or sets the order date.  &lt;br&gt;  This represents the date on which the order is ordered.   | [optional] 
**IsDeleted** | **bool** | Gets or sets whether the transport order is deleted. | [optional] 
**BeginDate** | **DateTime?** | Gets or sets the begin date.  &lt;br&gt;  Represents the date the transport order will begin.   | [optional] 
**EndDate** | **DateTime?** | Gets or sets the end date.  &lt;br&gt;  Represents the date the transport order should end.   | [optional] 
**CustomCustomerPrice** | **double** | Gets or sets the custom customer price.  &lt;br&gt;  This field is to hold a custom price for the customer.   E.g. when he has to pay a specific amount which will not be calculted from the shipments.   | [optional] 
**CalculatedCustomerPrice** | **double** | Gets or sets the calculated customet price.  &lt;br&gt;  This field is for a calculated price for the customer.   | [optional] 
**Status** | [**TransportOrderStatusModel**](TransportOrderStatusModel.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

