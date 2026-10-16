# Simplic.OxS.SDK.ERP.AddonDefinitionResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | The id of the definition. | [optional] 
**Entity** | **string** | The id of the entity the property belongs to: the entity&#39;s current id, also where the definition was stored under an id the entity had before. | [optional] 
**Path** | **string** | The key of the property under the entity&#39;s &#x60;addon&#x60; member. | [optional] 
**Kind** | **string** | The kind the property is filtered and sorted as: &#x60;string&#x60;, &#x60;int&#x60;, &#x60;long&#x60;, &#x60;double&#x60;, &#x60;decimal&#x60;, &#x60;bool&#x60;, &#x60;date&#x60;, &#x60;dateTime&#x60;, &#x60;guid&#x60; or &#x60;object&#x60;. | [optional] 
**Values** | [**List&lt;AddonDefinitionValueResponse&gt;**](AddonDefinitionValueResponse.md) | The values the property takes, where it takes no other; absent or &#x60;null&#x60; otherwise. | [optional] 
**DisplayName** | **string** | The label the property is shown with. | [optional] 
**Description** | **string** | What the property means. | [optional] 
**Retired** | **bool** | Whether the definition is retired: it is stored, and its key is no property of the entity any more. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

