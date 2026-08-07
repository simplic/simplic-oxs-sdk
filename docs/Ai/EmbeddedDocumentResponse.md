# Simplic.OxS.SDK.Ai.EmbeddedDocumentResponse
Response model for an embedded document. Excludes the embedding vector — callers only need the id/content/metadata, and the vector adds no value while inflating the payload.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the connected data id. | [optional] 
**Content** | **string** | Gets or sets the search result content. | 
**CreateDateTime** | **DateTime** | Gets or sets the create date time. | [optional] 
**DataType** | **string** | Gets or sets the data type. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

