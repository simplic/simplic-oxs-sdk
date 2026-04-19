# Simplic.OxS.SDK.Ai.MessageModel
Represents a conversation message

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the message id | [optional] 
**SenderId** | **Guid?** | Gets or sets the sender. Ox user id, null for llm model | [optional] 
**DateTime** | **DateTime** | Gets or sets the datetime the message was created | [optional] 
**Body** | **string** | Gets or sets the message body | [optional] 
**ModelReference** | **string** | Gets or sets an optional model reference for the message | [optional] 
**Type** | **MessageType** |  | [optional] 
**Blobs** | [**List&lt;MessageBlobModel&gt;**](MessageBlobModel.md) | Gets or sets binary blobs attached to this message | [optional] 
**Reasoning** | **string** | Gets or sets reasoning/thinking content from the LLM (if supported) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

