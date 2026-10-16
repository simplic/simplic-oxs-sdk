# Simplic.OxS.SDK.ERP.OxSchemaReferenceCondition
The condition of a reference case: either a sibling `path` holding one of `equals`, or the holding object being stored as one of `variant`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Path** | **string** | The sibling&#39;s wire name. Absent on a variant condition. | [optional] 
**PropertyEquals** | **List&lt;string&gt;** | The values the sibling is compared with, exactly. Absent on a variant condition. | [optional] 
**Variant** | **List&lt;string&gt;** | The variant names the holding object is tested against. Absent on a path condition. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

