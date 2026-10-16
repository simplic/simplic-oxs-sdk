# Simplic.OxS.SDK.ERP.OxQLError
A refusal: why a request was not answered.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The class of the refusal: &#x60;validation_error&#x60;, &#x60;access_denied&#x60;, &#x60;not_executable&#x60;, &#x60;timeout&#x60;, &#x60;rate_limited&#x60; or &#x60;internal_error&#x60;. | 
**Title** | **string** | A summary for a person. | 
**Errors** | [**List&lt;OxQLErrorDetail&gt;**](OxQLErrorDetail.md) | The reasons, each with a code. | [optional] 
**Status** | **int?** | The HTTP status repeated in the body; only in an answer to a contract 1 request (legacy). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

