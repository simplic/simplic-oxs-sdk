# Simplic.OxS.SDK.Ai.AgentMessageResponse
DTO representing a single message in an agent session, returned by the API.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the stable identifier for this message. | [optional] 
**TurnId** | **Guid?** | Gets or sets the turn identifier shared by the assistant message and all workspace entries produced during the same request turn. | [optional] 
**Role** | **string** | Gets or sets the message role (user, assistant, system, tool). | [optional] 
**Content** | **string** | Gets or sets the message content. | [optional] 
**Timestamp** | **DateTime** | Gets or sets the timestamp of the message. | [optional] 
**ToolName** | **string** | Gets or sets the tool name, if this is a tool message. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

