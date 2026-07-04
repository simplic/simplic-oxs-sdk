# Simplic.OxS.SDK.Ai.AgentWorkspaceEntryDto
DTO representing a workspace entry returned by the session workspace endpoint.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TurnId** | **Guid?** | Gets or sets the turn identifier linking this entry to the assistant message that produced it. | [optional] 
**Label** | **string** | Gets or sets the human-readable label shown in the workspace file tree. | [optional] 
**FileContent** | **string** | Gets or sets the raw file content (e.g. pretty-printed JSON response body). | [optional] 
**FileLanguage** | **string** | Gets or sets the Monaco language identifier, e.g. \&quot;json\&quot;. | [optional] 
**Type** | **string** | Gets or sets the registry key for a dynamic component entry, e.g. \&quot;flow-editor\&quot;. | [optional] 
**DataJson** | **string** | Gets or sets the JSON-serialized data payload for dynamic component entries. | [optional] 
**NavigationUrl** | **string** | Gets or sets an optional navigation URL shown as a \&quot;Go to …\&quot; button. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

