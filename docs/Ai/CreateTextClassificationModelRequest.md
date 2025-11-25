# Simplic.OxS.SDK.Ai.CreateTextClassificationModelRequest
Represents an request to create a new model to text classification.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Gets or sets the name of the model base. | [optional] 
**Type** | **string** | Gets or sets the type of the model base. as example. aws-comprehend-multi-classification | [optional] 
**State** | **string** | Gets or sets the state of the base model. new, training, completed and failed.s | [optional] 
**TrainingFormatData** | **string** | Gets or sets the format of the training data. e.g. csv. | [optional] 
**Delimiter** | **string** | Gets or sets the delimiter for the data. | [optional] 
**LabelDelimiter** | **string** | Gets or sets the delimiter for the labels. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

