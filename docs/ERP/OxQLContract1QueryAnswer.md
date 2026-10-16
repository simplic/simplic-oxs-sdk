# Simplic.OxS.SDK.ERP.OxQLContract1QueryAnswer
The answer to a contract 1 query (legacy): what a caller without the contract header reads. The rows are as they are stored. New callers send the header and read OxQL.AspNetCore.OpenApi.OxQLQueryAnswer.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Items** | **List&lt;Dictionary&lt;string, Object&gt;&gt;** | The rows, as stored. | 
**PageInfo** | [**OxQLContract1PageInfo**](OxQLContract1PageInfo.md) |  | 
**Diagnostics** | [**List&lt;OxQLDiagnostic&gt;**](OxQLDiagnostic.md) | What the caller should know about the rows. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

