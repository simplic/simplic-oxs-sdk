# Simplic.OxS.SDK.Ai.StartConversationRequest
Model for starting conversation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Model** | **string** | Gets or sets the LLM model, e.g. gpt-4o-mini, gpt-4 | 
**Context** | [**ConversationContextModel**](ConversationContextModel.md) |  | [optional] 
**Embedding** | [**EmbeddingModel**](EmbeddingModel.md) |  | [optional] 
**Message** | **string** | Gets or sets the initial message | 
**Blobs** | [**List&lt;MessageBlobModel&gt;**](MessageBlobModel.md) | Gets or sets optional binary blobs (e.g. images) to attach to the message | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

