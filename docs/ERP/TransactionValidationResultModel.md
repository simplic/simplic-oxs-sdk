# Simplic.OxS.SDK.ERP.TransactionValidationResultModel
Represents the shared model for the result of validating a transaction for financial accounting.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InputFieldValidationResults** | **Dictionary&lt;string, bool?&gt;** | Gets or sets the validation results for individual input fields.     true &#x3D; valid, false &#x3D; invalid, null &#x3D; not validated   | [optional] 
**Errors** | [**List&lt;LocalizableErrorModel&gt;**](LocalizableErrorModel.md) | Gets or sets the list of validation errors. | [optional] 
**IsValid** | **bool** | Gets or sets whether the transaction is valid for purposes of financial accounting. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

