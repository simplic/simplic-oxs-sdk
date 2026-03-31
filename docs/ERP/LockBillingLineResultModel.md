# Simplic.OxS.SDK.ERP.LockBillingLineResultModel
Represents the result model of a lock operation on a Simplic.OxS.ERP.BillingLine.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Locked** | **bool** | Gets or sets whether the billing line is locked after the operation.   &#x60;true&#x60; if the operation succeeded or the billing line was already locked;  &#x60;false&#x60; if the billing line was in an illegal state for locking.   | [optional] 
**Errors** | [**List&lt;LocalizableErrorModel&gt;**](LocalizableErrorModel.md) | Gets or sets the set of errors that occurred during the operation. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

