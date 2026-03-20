# Simplic.OxS.SDK.ERP.DistributeBillingLinesToDraftTransactionsResultModel
Represents the result model for distributing a set of billing lines to existing draft transactions.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DraftTransactionResults** | [**List&lt;AddBillingLinesToDraftTransactionResultModel&gt;**](AddBillingLinesToDraftTransactionResultModel.md) | Gets or sets one entry per draft transaction that received at least one billing line,  each carrying the Simplic.OxS.ERP.Server.DraftTransactionResultModel and the IDs of the billing lines added. | [optional] 
**AmbiguousAssignments** | [**List&lt;AmbiguousBillingLineAssignmentModel&gt;**](AmbiguousBillingLineAssignmentModel.md) | Gets or sets the set of billing lines whose assignment was ambiguous,  together with the eligible draft transactions per billing line. | [optional] 
**Errors** | [**List&lt;LocalizableErrorModel&gt;**](LocalizableErrorModel.md) | Gets or sets the set of errors that occurred during the operation. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

