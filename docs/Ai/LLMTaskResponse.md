# Simplic.OxS.SDK.Ai.LLMTaskResponse
Represents an llm task

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the id of the task | [optional] 
**Name** | **string** | Gets or sets the name of the task | [optional] 
**Reason** | **string** | Gets or sets the reason that will be used from a llm, to use this task | [optional] 
**Requires** | **string** | Gets or sets the required information, to use this task | [optional] 
**Definition** | [**LLMTaskDefinitionModel**](LLMTaskDefinitionModel.md) |  | [optional] 
**OptionalSubtask** | **List&lt;string&gt;** | Gets or sets subtask, which should be included automatically | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

