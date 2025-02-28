# Simplic.OxS.SDK.ERP.CreatePersonalAccountRequest
Represents a request to create a personal account.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddressContactIds** | **List&lt;Guid&gt;** | Gets or sets the contact id&#39;s for the addresses contained in the personal account. | [optional] 
**SaleTermsOfPaymentId** | **Guid?** | Gets or sets the id of the sale terms of payment. | [optional] 
**PurchaseTermsOfPaymentId** | **Guid?** | Gets or sets the id of the purchase terms of payment. | [optional] 
**TaxGroupId** | **Guid?** | Gets or sets the id of the tax group. | [optional] 
**Number** | **string** | gets or sets the number. | [optional] 
**VatId** | **string** | Gets or sets the vat id. | [optional] 
**Type** | **string** | Gets or sets the personal account type. (creditor / debitor) | [optional] 
**CreditLimit** | [**CreditLimitModel**](CreditLimitModel.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

