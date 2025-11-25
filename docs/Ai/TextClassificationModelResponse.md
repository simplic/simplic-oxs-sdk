# Simplic.OxS.SDK.Ai.TextClassificationModelResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the id of the text classification model. | [optional] 
**Name** | **string** | Gets or sets the name of the model base. | [optional] 
**Type** | **string** | Gets or sets the type of the model base. as example. aws-comprehend-multi-classification | [optional] 
**State** | **string** | Gets or sets the state of the base model. new, training, completed and failed.s | [optional] 
**StateText** | **string** | Gets or sets the current state text. Its a text with more information about the state. | [optional] 
**TrainingFormatData** | **string** | Gets or sets the format of the training data. e.g. csv. | [optional] 
**Delimiter** | **string** | Gets or sets the delimiter for the data. | [optional] 
**LabelDelimiter** | **string** | Gets or sets the delimiter for the labels. | [optional] 
**TrainingDataPath** | **string** | Gets or sets the actually trainings data. Its a path to a csv file in a aws bucket. | [optional] 
**VarVersion** | **int** | Gets or sets the current model version | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

