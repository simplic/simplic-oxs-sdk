# Simplic.OxS.SDK.ERP.OxQLHealthService
A service the host's model joins into, as last measured.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Service** | **string** | The name of the service. | 
**Configured** | **bool** | Whether the host has an address for it. | 
**Reachable** | **bool?** | Whether it answered the last measurement; null until the first has finished. | [optional] 
**Contract** | **int?** | The contract its engine speaks; contract 2 only. | [optional] 
**EngineVersion** | **string** | The version of its engine; contract 2 only. | [optional] 
**Usable** | **bool?** | Whether joins into it can run; contract 2 only. | [optional] 
**Reason** | **string** | Why it is not usable; contract 2 only. | [optional] 
**References** | **Dictionary&lt;string, Object&gt;** | What the host&#39;s check of its declared references into the service says; contract 2 only. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

