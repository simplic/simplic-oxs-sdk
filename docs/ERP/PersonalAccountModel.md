# Simplic.OxS.SDK.ERP.PersonalAccountModel
Represents the shared model for Simplic.OxS.ERP.PersonalAccount.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the ID. | [optional] 
**Number** | **string** | gets or sets the number. | [optional] 
**VatId** | **string** | Gets or sets the vat id. | [optional] 
**Type** | **string** | Gets or sets the personal account type. (creditor / debitor) | [optional] 
**CreditLimit** | [**CreditLimitModel**](CreditLimitModel.md) |  | [optional] 
**SaleTermsOfPayment** | [**TermsOfPaymentModel**](TermsOfPaymentModel.md) |  | [optional] 
**PurchaseTermsOfPayment** | [**TermsOfPaymentModel**](TermsOfPaymentModel.md) |  | [optional] 
**TaxGroup** | [**TaxGroupModel**](TaxGroupModel.md) |  | [optional] 
**Addresses** | [**List&lt;PersonalAccountAddressModel&gt;**](PersonalAccountAddressModel.md) | Gets or sets the addresses.  &lt;br&gt;  A personal account can contain multiple addresses.   | [optional] 
**CreateDateTime** | **DateTime** | Gets or sets the create date time. | [optional] 
**CreateUserId** | **Guid?** | Gets or sets the create user id. | [optional] 
**CreateUserName** | **string** | Gets or sets the create user name. | [optional] 
**UpdateDateTime** | **DateTime** | Gets or sets the update date time. | [optional] 
**UpdateUserId** | **Guid?** | Gets or sets the update user id. | [optional] 
**UpdateUserName** | **string** | Gets or sets the udate user name. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

