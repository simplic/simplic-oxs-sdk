# Simplic.OxS.SDK.ERP.AmbiguousBillingLineAssignmentModel
Represents the model for a billing line whose split-configuration-based assignment  is ambiguous because multiple eligible draft transactions were found.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BillingLineId** | **Guid** | Gets or sets the ID of the billing line with an ambiguous assignment. | [optional] 
**EligibleTransactions** | [**List&lt;TransactionModel&gt;**](TransactionModel.md) | Gets or sets the set of draft transactions eligible to receive this billing line. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

