# Simplic.OxS.SDK.Telematic.WorkflowStepResponse
Represents the response of a workflow step request.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the id. | [optional] 
**Name** | **string** | Gets or sets the name. | [optional] 
**Localizations** | [**List&lt;WorkflowStepLocalizationModel&gt;**](WorkflowStepLocalizationModel.md) | Gets or sets the localizations. | [optional] 
**DataFields** | [**List&lt;WorkflowStepDataFieldModel&gt;**](WorkflowStepDataFieldModel.md) | Gets or sets the list of attached data fields. | [optional] 
**StepOrder** | **int** | Gets or sets the step order. | [optional] 
**Roles** | **List&lt;string&gt;** | Gets or sets the roles this step fulfills within the order lifecycle. Allowed values: \&quot;order_started\&quot;, \&quot;order_completed\&quot;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

