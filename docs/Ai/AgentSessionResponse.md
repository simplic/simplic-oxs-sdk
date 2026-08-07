# Simplic.OxS.SDK.Ai.AgentSessionResponse
DTO representing an agent session returned by the API.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the session identifier. | [optional] 
**UserId** | **Guid?** | Gets or sets the user identifier. | [optional] 
**OrganizationId** | **Guid?** | Gets or sets the organization identifier. | [optional] 
**CreatedAt** | **DateTime** | Gets or sets the session creation time. | [optional] 
**LastActivityAt** | **DateTime** | Gets or sets the last activity time. | [optional] 
**Title** | **string** | Gets or sets the short, LLM-generated conversation title, or &#x60;null&#x60; if not yet generated (e.g. before the first exchange completes). | [optional] 
**IsActive** | **bool** | Gets or sets whether the session is active. | [optional] 
**MessageCount** | **int** | Gets or sets the message count. | [optional] 
**PendingApprovalCount** | **int** | Gets or sets pending approval count. | [optional] 
**TotalTokens** | **int** | Gets or sets the cumulative token usage (input + output) across all assistant turns in this session, for providers that report usage. | [optional] 
**TotalInputTokens** | **int** | Gets or sets the cumulative input/prompt token usage across all assistant turns in this session, for providers that report usage. | [optional] 
**TotalOutputTokens** | **int** | Gets or sets the cumulative output/completion token usage across all assistant turns in this session, for providers that report usage. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

