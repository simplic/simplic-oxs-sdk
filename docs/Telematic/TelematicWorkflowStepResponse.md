# Simplic.OxS.SDK.Telematic.TelematicWorkflowStepResponse
Represents a workflow step within a telematic workflow with execution state.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WorkflowStepId** | **Guid** | Gets or sets the workflow step id. | [optional] 
**Order** | **int** | Gets or sets the order of this step in the workflow. | [optional] 
**Name** | **string** | Gets or sets the name of the step. | [optional] 
**Localizations** | [**List&lt;WorkflowStepLocalizationResponse&gt;**](WorkflowStepLocalizationResponse.md) | Gets or sets the localizations for the step. | [optional] 
**DataFields** | [**List&lt;TelematicDataFieldResponse&gt;**](TelematicDataFieldResponse.md) | Gets or sets the list of data fields for this step with their definitions. | [optional] 
**IsCompleted** | **bool** | Gets or sets whether this step has been completed. | [optional] 
**CompletedAtUtc** | **DateTime?** | Gets or sets the timestamp when the step was completed (UTC). | [optional] 
**Roles** | **List&lt;string&gt;** | Gets or sets the roles this step fulfills within the order lifecycle. Allowed values: \&quot;order_started\&quot;, \&quot;order_completed\&quot;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

