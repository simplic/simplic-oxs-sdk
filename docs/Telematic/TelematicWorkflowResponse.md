# Simplic.OxS.SDK.Telematic.TelematicWorkflowResponse
Represents a workflow snapshot embedded in a telematic message.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the workflow id. | [optional] 
**Name** | **string** | Gets or sets the name of the workflow. | [optional] 
**Value** | **string** | Gets or sets the value that will be send towards the telematic system. | [optional] 
**Description** | **string** | Gets or sets the description. | [optional] 
**Steps** | [**List&lt;TelematicWorkflowStepResponse&gt;**](TelematicWorkflowStepResponse.md) | Gets or sets the list of workflow steps with their embedded definitions. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

