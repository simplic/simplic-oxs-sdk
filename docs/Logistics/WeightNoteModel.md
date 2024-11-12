# Simplic.OxS.SDK.Logistics.WeightNoteModel
Shared model of weight note.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the id.     Represents the unique identifier of the weight note.   | [optional] 
**IsDeleted** | **bool** | Gets or sets whether the weight note is deleted. | [optional] 
**Number** | **string** | Gets or sets the number.     The number is usually given by the scale operator/ scale document.   | [optional] 
**DocumentId** | **Guid?** | Gets or sets the document id.     References a document with the weight note.   | [optional] 
**Quantity** | [**QuantityModel**](QuantityModel.md) |  | [optional] 
**Type** | **WeightNoteType** |  | [optional] 
**CreateDateTime** | **DateTime** | Gets or sets the create date time. | [optional] 
**FirstWeight** | [**QuantityModel**](QuantityModel.md) |  | [optional] 
**SecondWeight** | [**QuantityModel**](QuantityModel.md) |  | [optional] 
**FirstDateTime** | **DateTime** | Gets or sets the first date time.     Represents the date and time of the first weighing.   | [optional] 
**SecondDateTime** | **DateTime** | Gets or sets the second date time.     Represents the date and time of the second weighing.   | [optional] 
**Reference** | **string** | Gets or sets the external reference. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

