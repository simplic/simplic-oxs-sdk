# Simplic.OxS.SDK.ERP.OxSchemaRelation
The name of a relation (format 1.1): see `relation`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the reference, a wire segment that is unique among the relation names of its type: it lies on the member that carries the reference, or, where &#x60;member&#x60; is present, on the slot one level above, and is then the name of the reference the slot&#39;s key member carries. | 
**Member** | **string** | Absent when the name is that of the reference the member itself carries. Otherwise the member is a slot and the name is that of the reference its key member carries: &#x60;id&#x60; or &#x60;referenceId&#x60;, written here. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

