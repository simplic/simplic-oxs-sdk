# Simplic.OxS.SDK.ERP.OxQLExplainAnswer
The answer to an explain. The members that describe stages, types and plans are objects whose form is in the OxQL documentation.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Valid** | **bool** | Whether the query binds and this host can run it. | 
**Executable** | **string** | Whether the request can run: &#x60;yes&#x60;, &#x60;never&#x60; or &#x60;unknown&#x60;. | [optional] 
**Contract** | **int** | The contract the request was read as. | 
**Engine** | **Dictionary&lt;string, Object&gt;** | The engine&#39;s version, contract and the capabilities of this host. | 
**Etag** | **string** | The validator of the answer, also sent as the &#x60;ETag&#x60; header. | [optional] 
**Revision** | **Dictionary&lt;string, Object&gt;** | The revisions of the models the answer was bound against. | [optional] 
**Cache** | **Dictionary&lt;string, Object&gt;** | How long the answer may be kept and whether it is complete. | [optional] 
**Errors** | [**List&lt;OxQLErrorDetail&gt;**](OxQLErrorDetail.md) | Every error of the query; empty when it is valid. | 
**Diagnostics** | [**List&lt;OxQLDiagnostic&gt;**](OxQLDiagnostic.md) | The diagnostics a run of the query would carry, as far as binding knows them. | 
**Notes** | [**List&lt;OxQLDiagnostic&gt;**](OxQLDiagnostic.md) | Notes on how the engine reads the query. | 
**Entry** | **Dictionary&lt;string, Object&gt;** | The entity the query starts at. | [optional] 
**Stages** | **List&lt;Dictionary&lt;string, Object&gt;&gt;** | Per stage of the pipeline: its kind, its status, what it reads and the shape after it. | 
**Filter** | **List&lt;Dictionary&lt;string, Object&gt;&gt;** | Per entry of the request&#39;s &#x60;filter&#x60;: where it was placed. | [optional] 
**Aliases** | **Dictionary&lt;string, Object&gt;** | The aliases the joins and unwinds of the query create. | [optional] 
**Types** | **Dictionary&lt;string, Object&gt;** | The types the shapes refer to. | [optional] 
**Rules** | **Dictionary&lt;string, Object&gt;** | The rules by which a member can be filtered, sorted, grouped or listed. | [optional] 
**FlagSets** | **Dictionary&lt;string, Object&gt;** | The sets of such flags the types refer to. | [optional] 
**Result** | **Dictionary&lt;string, Object&gt;** | The columns of the rows a run answers. | [optional] 
**ColumnFlags** | **Dictionary&lt;string, Object&gt;** | The flags of the result&#39;s columns. | [optional] 
**Owners** | **List&lt;Dictionary&lt;string, Object&gt;&gt;** | The services asked for the parts of the query they own, and how each answered. | [optional] 
**Catalog** | **List&lt;Dictionary&lt;string, Object&gt;&gt;** | The entries of the request&#39;s &#x60;catalog&#x60;, described. | [optional] 
**Plan** | **Dictionary&lt;string, Object&gt;** | The bound form and the stages sent to the database; only with &#x60;include: [\&quot;plan\&quot;]&#x60;. | [optional] 
**Advisory** | **Dictionary&lt;string, Object&gt;** | What the indexes of the collection do for the query; only with &#x60;include: [\&quot;indexes\&quot;]&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

