# Simplic.OxS.SDK.ERP.OxQLLookupStage
The `lookup` stage.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**From** | **string** | The id of the entity whose records reference the row. | 
**Path** | **string** | The member of that entity that holds the reference. | 
**VarAs** | **string** | The name the joined records stand under in the row. | 
**On** | **string** | The alias of an earlier join whose rows are the parents, instead of the row itself. | [optional] 
**Filter** | **Dictionary&lt;string, Object&gt;** | A condition the joined records must meet. | [optional] 
**Sort** | **List&lt;Dictionary&lt;string, Object&gt;&gt;** | The order of the joined records, as a &#x60;sort&#x60; stage takes it. | [optional] 
**Limit** | **int?** | The most records joined per row. | [optional] 
**First** | **bool?** | Joins the first record as an object instead of an array. | [optional] 
**ForTarget** | **string** | The target of a reference with several targets that this stage continues under. | [optional] 
**ParentAs** | **string** | The name the parent of a joined item stands under. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

