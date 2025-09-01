# Simplic.OxS.SDK.Ai.ConversationModel
Represents a LLM conversation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the conversation id | [optional] 
**UserId** | **Guid?** | Gets or sets the user the llm conversation is attached to | [optional] 
**Model** | **string** | Gets or sets the LLM model, e.g. gpt-4o-mini, gpt-4 | [optional] 
**Context** | [**ConversationContextModel**](ConversationContextModel.md) |  | [optional] 
**Messages** | [**List&lt;MessageModel&gt;**](MessageModel.md) | Gets or sets the messages inside the conversation | [optional] 
**CreateDateTime** | **DateTime** | Gets or sets the creation date time | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

