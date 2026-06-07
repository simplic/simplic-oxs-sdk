# Simplic.OxS.SDK.Ai.ApprovalRequestDto
DTO representing a pending approval request returned by the API.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the approval request identifier. | [optional] 
**Message** | **string** | Gets or sets the message describing what is being approved. | [optional] 
**PlanId** | **Guid?** | Gets or sets the plan identifier. | [optional] 
**StepId** | **Guid?** | Gets or sets the step identifier requiring approval. | [optional] 
**ToolName** | **string** | Gets or sets the tool name requiring approval. | [optional] 
**RiskLevel** | **string** | Gets or sets the risk level of the action. | [optional] 
**Options** | **List&lt;string&gt;** | Gets or sets the available approval options. | [optional] 
**CreatedAt** | **DateTime** | Gets or sets when the approval was created. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

