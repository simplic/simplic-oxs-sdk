# Simplic.OxS.SDK.ERP.TaxRequest
Represents the request object for a tax.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **TaxType** |  | [optional] 
**Category** | **TaxCategory** |  | [optional] 
**ExemptionReasonCode** | **TaxExemptionReasonCode** |  | [optional] 
**ExemptionReason** | **string** | Gets or sets the optional VAT exemption reason as free text. If neither this nor Simplic.OxS.ERP.Server.ElectronicInvoicing.TaxRequest.ExemptionReasonCode is provided, a default is derived from the tax category. | [optional] 
**Rate** | **double** | Gets or sets the tax rate in percent. | [optional] 
**AssignedItems** | **List&lt;string&gt;** | Gets or sets the billable invoice items assigned to the tax by ID. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

