# Simplic.OxS.SDK.Ai.AgentAttachmentResponse
Attachment metadata without storage keys or public download URLs.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Opaque attachment identifier. | [optional] 
**FileName** | **string** | Original upload name. | [optional] 
**ContentType** | **string** | Validated content type. | [optional] 
**SizeBytes** | **long** | Original byte count. | [optional] 
**UploadedAt** | **DateTime** | Time of the original upload. | [optional] 
**ExpiresAt** | **DateTime** | Fixed access deadline; never renewed by conversation activity. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

