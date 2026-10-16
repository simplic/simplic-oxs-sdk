# Simplic.OxS.SDK.ERP.OxQLStage
One stage of a pipeline: exactly one of the members is written.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Match** | **Dictionary&lt;string, Object&gt;** | A condition on the rows: paths with operators, nested with &#x60;and&#x60;, &#x60;or&#x60;, &#x60;not&#x60; and &#x60;any&#x60;. | [optional] 
**Lookup** | [**OxQLLookupStage**](OxQLLookupStage.md) |  | [optional] 
**Resolve** | [**OxQLResolveStage**](OxQLResolveStage.md) |  | [optional] 
**Unwind** | [**OxQLUnwindStage**](OxQLUnwindStage.md) |  | [optional] 
**Group** | [**OxQLGroupStage**](OxQLGroupStage.md) |  | [optional] 
**Project** | **Dictionary&lt;string, Object&gt;** | The members a row keeps (&#x60;1&#x60;) or leaves out (&#x60;0&#x60;), by path; a nested object is a dotted path. | [optional] 
**Sort** | **List&lt;Dictionary&lt;string, Object&gt;&gt;** | The order of the rows: objects of one path each, with &#x60;asc&#x60; or &#x60;desc&#x60;. | [optional] 
**Page** | [**OxQLPageStage**](OxQLPageStage.md) |  | [optional] 
**Values** | [**OxQLValuesStage**](OxQLValuesStage.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

