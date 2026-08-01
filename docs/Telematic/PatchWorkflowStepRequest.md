# Simplic.OxS.SDK.Telematic.PatchWorkflowStepRequest
Represents a request to patch a workflow step.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Gets or sets the name. | [optional] 
**Localizations** | [**List&lt;WorkflowStepLocalizationModel&gt;**](WorkflowStepLocalizationModel.md) | Gets or sets the localizations. | [optional] 
**DataFields** | [**List&lt;WorkflowStepDataFieldSet&gt;**](WorkflowStepDataFieldSet.md) | Gets or sets the list of attached data fields. | [optional] 
**StepOrder** | **int?** | Gets or sets the step order. | [optional] 
**Roles** | **List&lt;string&gt;** | Gets or sets the roles this step fulfills within the order lifecycle. Allowed values: \&quot;order_started\&quot;, \&quot;order_completed\&quot;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

