# Simplic.OxS.SDK.ERP.ValidateItemCostCenterAssignmentRequest
Represents a request to validate an item cost center assignment.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TemporaryItemId** | **Guid?** | Gets or sets the temporary ID of the transaction item.     This is just a workaround and is overwritten internally anyway. Leave out this property when sending the request.   | [optional] 
**CostCenterId** | **Guid** | Gets or sets the cost center to assign by ID. | [optional] 
**Percentage** | **double** | Gets or sets the percentage to assign. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

