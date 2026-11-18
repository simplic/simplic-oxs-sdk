# Simplic.OxS.SDK.ERP.TaxKeyRequest
Represents a request to create a Simplic.OxS.ERP.TaxKey.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** |  | 
**TaxGroupId** | **Guid?** | Gets or sets the tax group given by ID. | [optional] 
**TaxRateId** | **Guid?** | Gets or sets the tax rate given by ID. | [optional] 
**Value** | **double** | Gets or sets the tax rate value given in percent. | 
**ValidFrom** | **DateTime** | Gets or sets the point in time this tax rate is valid from. | 
**ValidTo** | **DateTime?** | Gets or sets the point in time this tax rate is valid to. | [optional] 
**BuNumber** | **int?** | Gets or sets the BU number. This number is important for tax keys in germany. | [optional] 
**EInvoiceTaxCategoryCode** | **string** | Gets or sets the e-invoice tax category code. | [optional] 
**EInvoiceTaxExemptionReasonCode** | **string** | Gets or sets the e-invoice tax exemption reason code. | [optional] 
**EInvoiceTaxExemptionReasonText** | **string** | Gets or sets the e-invoice free-text tax exemption reason. | [optional] 
**EInvoiceTaxExemptionReasonIsFreeText** | **bool** | Gets or sets whether the tax exemption reason is entered as free text. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

