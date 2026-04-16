# Simplic.OxS.SDK.ERP.AmbiguousBillingLineAssignmentModel
Represents the model for a group of billing lines whose split-configuration-based assignment  is ambiguous because they all matched the same set of multiple eligible draft transactions.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BillingLineIds** | **List&lt;Guid&gt;** | Gets or sets the IDs of the billing lines that share this ambiguous assignment. | [optional] 
**EligibleTransactions** | [**List&lt;TransactionModel&gt;**](TransactionModel.md) | Gets or sets the set of draft transactions eligible to receive these billing lines. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

