# Simplic.OxS.SDK.ERP.DistributeBillingLinesToDraftTransactionsRequest
Represents a request to distribute a set of billing lines onto existing draft transactions.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BillingLineIds** | **List&lt;Guid&gt;** | Gets or sets the set of billing line IDs to distribute. | [optional] 
**PinnedTransactionIds** | **Dictionary&lt;string, Guid&gt;** | Gets or sets an optional map of billing line ID to a pinned draft transaction ID.  When a billing line ID is present in this map its target transaction is used directly,  bypassing the split configuration matching. | [optional] 
**SplitConfigurationId** | **Guid** | Gets or sets the ID of the split configuration used to match unassigned billing lines  to existing draft transactions. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

