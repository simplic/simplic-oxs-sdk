# Simplic.OxS.SDK.ERP.OxQLResolveStage
The `resolve` stage.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Path** | **string** | The member of the row that holds the reference. | [optional] 
**VarAs** | **string** | The name the joined record stands under in the row. | 
**Filter** | **Dictionary&lt;string, Object&gt;** | A condition the target must meet. | [optional] 
**Elements** | **string** | Through a collection: &#x60;first&#x60; joins one target, &#x60;all&#x60; one per element. | [optional] 
**Target** | **string** | The target to join, of a reference that declares several. | [optional] 
**ParentAs** | **string** | The name the parent of a joined item stands under. | [optional] 
**OnMissing** | **string** | What to do with a reference whose target is missing: &#x60;null&#x60;, &#x60;report&#x60; or &#x60;refuse&#x60;. | [optional] 
**ForTarget** | **string** | The target of a reference with several targets that this stage continues under. | [optional] 
**ByTarget** | **Dictionary&lt;string, Object&gt;** | One path per target, for a join that continues under a reference with several targets. | [optional] 
**OutcomeAs** | **string** | The name of a member that says how the join ended for the row. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

