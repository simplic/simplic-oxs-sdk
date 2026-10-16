# Simplic.OxS.SDK.ERP.OxQLUnwindStage
The `unwind` stage.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Path** | **string** | The collection whose elements become rows. | 
**VarAs** | **string** | The name the element stands under in the row. | 
**PreserveNull** | **bool?** | Keeps a row whose collection is empty or absent, once, without an element. | [optional] 
**IncludeIndex** | **string** | The name of a member that holds the element&#39;s position in the collection. | [optional] 
**Flatten** | **string** | A member of the element that nests elements of the same kind: they become rows too. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

