# Simplic.OxS.SDK.ERP.OxSchemaDocument
The schema document a service publishes under `GET /schema`: the entities a query can read, every type reachable from them, and the limits a query is checked against.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SchemaVersion** | **string** | The format version of this document. | [optional] 
**Service** | **string** | The service name, lower-case. | 
**Api** | [**OxSchemaApi**](OxSchemaApi.md) |  | 
**Revision** | **string** | &#x60;sha256:&#x60; plus the digest of the canonical form with this member absent. It names the content of the document. | [optional] 
**Limits** | [**OxSchemaLimits**](OxSchemaLimits.md) |  | 
**Diagnostics** | [**List&lt;OxSchemaDiagnostic&gt;**](OxSchemaDiagnostic.md) | What the build could not describe. Absent on a clean build, so an incomplete document is distinguishable from an empty service. | [optional] 
**Types** | [**Dictionary&lt;string, OxSchemaType&gt;**](OxSchemaType.md) | The type pool, entities and structural types in one map keyed by id. The ordinal sort is a rule of the canonical form. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

