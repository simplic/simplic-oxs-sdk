# Simplic.OxS.SDK.ERP.CreateElectronicInvoiceRequest
Represents the request containing configuration and invoice data for creating a hybrid electronic invoice according to the ZUGFeRD standard.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Pdf** | **byte[]** | Gets or sets the input PDF invoice file.     This is only required if ElectronicInvoiceType is set to ZUGFeRD.   | [optional] 
**Profile** | **Profile** |  | [optional] 
**VarVersion** | **ZUGFeRDVersion** |  | [optional] 
**RoundingMode** | **RoundingMode** |  | [optional] 
**ElectronicInvoiceType** | **ElectronicInvoiceType** |  | [optional] 
**AddPeppolAddress** | **bool** | Gets or sets whether to add a PEPPOL address for buyer and seller. | [optional] 
**LeitwegIdRequired** | **bool** | Gets or sets a flag indicating if the Leitweg ID (for invoices addressed to German public institution) is required.     If true the buyer reference field is validated. Currently it is only checked if the buyer reference contains a value at all.   See https://en.e-rechnung-bund.de/e-invoicing-faq/buyer-reference   | [optional] [default to false]
**InvoiceData** | [**InvoiceDataRequest**](InvoiceDataRequest.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

