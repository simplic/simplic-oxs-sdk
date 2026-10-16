# Simplic.OxS.SDK.ERP.OxSchemaLimits
The limits a request has to respect before it is submitted, each read from the query engine that enforces it.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MaxPageSize** | **int** | The largest page a request may ask for. | 
**DefaultPageSize** | **int** | The page size a request that names none gets. | 
**MaxPipelineStages** | **int** | The longest pipeline the engine accepts, counting every stage. | 
**MaxLookupStages** | **int** | How many lookup stages one pipeline may carry. | 
**MaxUnwindStages** | **int** | How many unwind stages one pipeline may carry. | 
**MaxGroupFields** | **int** | How many fields one group stage may carry. | 
**MaxProjectionFields** | **int** | How many fields one projection may name. | 
**RegexMaxLength** | **int** | The longest regex pattern a filter operand may carry, in characters. | 
**MaxOffset** | **int** | The largest &#x60;offset&#x60; a page may skip to; beyond it the caller pages by cursor. A grid decides where its jump stops on this. | 
**MaxResolveStages** | **int** | How many resolve stages one pipeline may carry. | 
**MaxBatchQueries** | **int** | The most queries one batch may carry. | 
**MaxLookupLimit** | **int** | The most rows one lookup returns per parent. | 
**MaxContinuedStages** | **int** | How many stages a keyed fetch may continue on the service that owns its target (format 1.1). | 
**MaxFlattenDepth** | **int** | How many levels an unwind&#39;s &#x60;flatten&#x60; descends below the unwound element (format 1.1). | 
**MaxReportPageSize** | **int** | The page size of a strict report request, which names neither a cursor nor an offset (format 1.1). Such a request may ask for the larger of this and &#x60;maxPageSize&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

