# Simplic.OxS.SDK.ERP.OxQLContract1QueryBody
A contract 1 query (legacy): what a caller without the contract header writes. The entity and the paths are written as they are stored, and the stages take the members of that contract. New callers write OxQL.AspNetCore.OpenApi.OxQLQueryBody and send the header.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EntityType** | **string** | The entity, as the first contract named it. | 
**Variables** | **Dictionary&lt;string, Object&gt;** | Named values a condition refers to. | [optional] 
**Pipeline** | **List&lt;Dictionary&lt;string, Object&gt;&gt;** | The stages of the first contract, each an object with one stage. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

