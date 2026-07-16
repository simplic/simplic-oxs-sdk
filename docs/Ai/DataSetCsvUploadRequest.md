# Simplic.OxS.SDK.Ai.DataSetCsvUploadRequest
Request model for uploading CSV data to a data set.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DataSetId** | **Guid** | Gets or sets the target data set identifier. | 
**Delimiter** | **string** | Gets or sets the CSV delimiter character. | 
**HasHeaderRow** | **bool** | Gets or sets whether the CSV has a header row. | [optional] 
**Append** | **bool** | Gets or sets whether to append data to the existing data set. | [optional] 
**KeyColumnIndex** | **int** | Gets or sets the zero-based index of the key column. | [optional] 
**LabelColumnIndex** | **int** | Gets or sets the zero-based index of the label column. | [optional] 
**Data** | **byte[]** | Gets or sets the CSV file data as a byte array. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

