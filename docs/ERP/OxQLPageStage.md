# Simplic.OxS.SDK.ERP.OxQLPageStage
The `page` stage.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Limit** | **int?** | The most rows of the page; the host&#39;s default when absent. &#x60;0&#x60; with &#x60;count&#x60; asks for the count alone. | [optional] 
**Cursor** | **string** | The &#x60;nextCursor&#x60; of the page before, to continue after it. | [optional] 
**Count** | **Object** | Whether to count the matching rows: &#x60;true&#x60;, &#x60;false&#x60;, or an object &#x60;{ \&quot;upTo\&quot;: n, \&quot;budgetMs\&quot;: ms }&#x60; that bounds the count. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

