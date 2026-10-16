# Simplic.OxS.SDK.ERP.OxQLErrorDetail
One reason of a refusal.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The code; codes are stable, messages are not. | 
**Message** | **string** | A message for a person. | 
**Stage** | **int?** | The index of the stage of the pipeline the error belongs to. | [optional] 
**Filter** | **Object** | The entry of the request&#39;s &#x60;filter&#x60; the error belongs to: its &#x60;id&#x60;, or its index. | [optional] 
**Path** | **string** | The path of the entity the error is about. | [optional] 
**VarParams** | **Dictionary&lt;string, Object&gt;** | Values to render a message from, by code. | [optional] 
**Basis** | **string** | In an explain answer: what would have to change for the request to run. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

