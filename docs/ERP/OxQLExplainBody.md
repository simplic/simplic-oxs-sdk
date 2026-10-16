# Simplic.OxS.SDK.ERP.OxQLExplainBody
The body of an explain in its envelope form. A plain query (a body with `entityType` at the top) is accepted as well and is this envelope with its defaults.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Query** | [**OxQLQueryBody**](OxQLQueryBody.md) |  | 
**Include** | **List&lt;string&gt;** | What the answer carries beyond the verdict: any of &#x60;shape&#x60;, &#x60;notes&#x60;, &#x60;types&#x60;, &#x60;docs&#x60;, &#x60;plan&#x60;, &#x60;indexes&#x60;. | [optional] 
**Shape** | [**OxQLExplainShape**](OxQLExplainShape.md) |  | [optional] 
**Remote** | **string** | &#x60;check&#x60; asks the other services a join reaches; &#x60;cached&#x60; answers from what is already known. | [optional] 
**Catalog** | **List&lt;Dictionary&lt;string, Object&gt;&gt;** | Entities to describe beside the query: objects of &#x60;id&#x60;, &#x60;entity&#x60; and optional &#x60;prefix&#x60;, &#x60;depth&#x60;, &#x60;referencing&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

