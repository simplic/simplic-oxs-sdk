# Simplic.OxS.SDK.ERP.OxSchemaReference
A simple foreign key: one unconditional entity target, no item path, no key conversion. Every other reference is published as `referenceCases` and never here, because a format 1.0 reader maps every `references` to an entity join.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Entity** | **string** | The target entity id. | 
**Field** | **string** | The single path that is the target&#39;s key. Absent when the target is not an entity of this document or its key is not one path. | [optional] 
**Joinable** | **bool** | Whether a query may join on this reference. | 
**Inferred** | **bool** | True when the target was derived from the property name rather than declared. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

