# Simplic.OxS.SDK.ERP.OxQLQueryAnswer
The answer to a query under contract 2: a page of rows and what is known of their count.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Items** | **List&lt;Dictionary&lt;string, Object&gt;&gt;** | The rows, each an object in the wire encoding of the entity (or &#x60;{ value, count }&#x60; for a &#x60;values&#x60; stage). | 
**PageInfo** | [**OxQLPageInfo**](OxQLPageInfo.md) |  | 
**Diagnostics** | [**List&lt;OxQLDiagnostic&gt;**](OxQLDiagnostic.md) | What the caller should know about the rows that did not refuse the request; absent when there is nothing. | [optional] 
**Timing** | **Dictionary&lt;string, Object&gt;** | Where the request&#39;s time went; only when the request asked for it. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

