# Simplic.OxS.SDK.ERP.OxQLDiagnostic
Something a caller should know about an answer that did not refuse the request.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The code; codes are stable, messages are not. | 
**Message** | **string** | A message for a person. | 
**Stage** | **int?** | The index of the stage of the pipeline it belongs to. | [optional] 
**Path** | **string** | The path it is about. | [optional] 
**Filter** | **Object** | The entry of the request&#39;s &#x60;filter&#x60; it belongs to: its &#x60;id&#x60;, or its index. | [optional] 
**VarParams** | **Dictionary&lt;string, Object&gt;** | Values to render a message from, by code. | [optional] 
**Basis** | **string** | In an explain answer: what would have to change for it not to be said. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

