# Simplic.OxS.SDK.ERP.CreateAddonDefinitionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Entity** | **string** | The id of the extendable entity the property is added to, as the schema document names it (&#x60;parcel.parcel&#x60;). | 
**Path** | **string** | The key of the property under the entity&#39;s &#x60;addon&#x60; member, as it is stored; dots separate the segments of a nested key (&#x60;handling&#x60;, &#x60;customs.code&#x60;). It does not change afterwards. | 
**Kind** | **string** | The kind the property is filtered and sorted as: &#x60;string&#x60;, &#x60;int&#x60;, &#x60;long&#x60;, &#x60;double&#x60;, &#x60;decimal&#x60;, &#x60;bool&#x60;, &#x60;date&#x60;, &#x60;dateTime&#x60;, &#x60;guid&#x60; or &#x60;object&#x60;. It does not change afterwards. | 
**Values** | [**List&lt;AddonDefinitionValueRequest&gt;**](AddonDefinitionValueRequest.md) | The values the property takes, where it takes no other: only for a &#x60;string&#x60; or an &#x60;int&#x60; property. Left out, the property takes every value of its kind. | [optional] 
**DisplayName** | **string** | The label the property is shown with. | [optional] 
**Description** | **string** | What the property means, for the people who use it. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

