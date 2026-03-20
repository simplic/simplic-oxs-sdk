# Simplic.OxS.SDK.ERP.CreateDraftTransactionsRequest
Represents a request to create a set of draft transactions from a set of billing lines.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BillingLineIds** | **List&lt;Guid&gt;** | Gets or sets the set of billing line IDs to convert into draft transactions. | [optional] 
**Target** | **SplitTarget** |  | [optional] 
**SplitConfigurationId** | **Guid?** | Gets or sets the split configuration ID to use for the split operation if split mode is set to configuration-based. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

