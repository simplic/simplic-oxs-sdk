# Simplic.OxS.SDK.ERP.OxQLQueryBody
A query: the entity it reads and the stages it reads it through.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EntityType** | **string** | The id of the entity, as the service&#39;s schema publishes it (&#x60;logistics.shipment&#x60;). | 
**Pipeline** | [**List&lt;OxQLStage&gt;**](OxQLStage.md) | The stages, executed as written. Each element is an object with exactly one stage. | 
**Variables** | **Dictionary&lt;string, Object&gt;** | Named values a condition refers to with &#x60;{ \&quot;$var\&quot;: \&quot;name\&quot; }&#x60;. | [optional] 
**Filter** | [**List&lt;OxQLFilterEntry&gt;**](OxQLFilterEntry.md) | Conditions the engine places where the pipeline has the paths they read; a row must meet all of them. | [optional] 
**Strict** | **bool?** | Refuses the request (422) where it would otherwise answer with less data than was asked for. | [optional] 
**OnMissing** | **string** | What a join does with a reference whose target is missing, unless the join says so itself: &#x60;null&#x60;, &#x60;report&#x60; or &#x60;refuse&#x60;. | [optional] 
**Timing** | **bool?** | Asks for the &#x60;timing&#x60; member of the answer. | [optional] 
**MaxTimeMs** | **int?** | A ceiling on this request&#39;s time in milliseconds, under the host&#39;s own. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

