# Simplic.OxS.SDK.ERP.OxQLHealthAnswer
The answer of the health route. A caller without the contract header reads `status`, `service`, `engine`, `capabilities`, `limits` and, per service, `service`, `configured` and `reachable`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | &#x60;healthy&#x60;, or &#x60;degraded&#x60; while a service the model joins into is not usable or the model is degraded. | 
**Service** | **string** | Always &#x60;oxql&#x60;. | 
**Engine** | [**OxQLHealthEngine**](OxQLHealthEngine.md) |  | 
**Capabilities** | **List&lt;string&gt;** | What depends on the host: joins into other services, explain, contract 1. | 
**Limits** | **Dictionary&lt;string, int&gt;** | The limits a request is checked against, by name, with the values in force on this host. | 
**Remote** | [**List&lt;OxQLHealthService&gt;**](OxQLHealthService.md) | The services the host&#39;s model joins into; absent with &#x60;?shallow&#x3D;true&#x60; and on a host without any. | [optional] 
**Model** | [**OxQLHealthModel**](OxQLHealthModel.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

