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
**TokenUsage** | [**MessageTokenUsage**](MessageTokenUsage.md) |  | [optional] 
**Model** | **string** | Gets or sets the LLM model that effectively produced this message (assistant messages only), e.g. \&quot;claude-sonnet-5\&quot;. This is the resolved model actually used — the caller-requested model when supported, otherwise the provider&#39;s default model — not necessarily the raw request value. Null for user/tool messages or older messages recorded before this field existed. | [optional] 
**Effort** | **string** | Gets or sets the reasoning effort effectively used to produce this message (assistant messages only), one of \&quot;minimal\&quot;, \&quot;low\&quot;, \&quot;medium\&quot;, \&quot;high\&quot;, \&quot;xhigh\&quot;, \&quot;max\&quot; (see Simplic.OxS.AI.ReasoningEffort). This is cleared to null (rather than echoing the raw request) when the resolved model doesn&#39;t support the requested level, or for older messages recorded before this field existed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

