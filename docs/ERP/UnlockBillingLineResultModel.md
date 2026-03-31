# Simplic.OxS.SDK.ERP.UnlockBillingLineResultModel
Represents the result model of an unlock operation on a Simplic.OxS.ERP.BillingLine.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Unlocked** | **bool** | Gets or sets whether the billing line is unlocked after the operation.   &#x60;true&#x60; if the billing line was unlocked or was already in a non-locked state;  &#x60;false&#x60; if the required resource lock or state check failed.   | [optional] 
**Errors** | [**List&lt;LocalizableErrorModel&gt;**](LocalizableErrorModel.md) | Gets or sets the set of errors that occurred during the operation. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

