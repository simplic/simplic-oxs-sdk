# Simplic.OxS.SDK.ERP.OxQLCount
What an answer knows of how many rows match.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**State** | **string** | &#x60;exact&#x60;: &#x60;value&#x60; is the count. &#x60;atLeast&#x60;: &#x60;value&#x60; is a proven lower bound. &#x60;unknown&#x60;: the count that was asked for did not finish. | 
**Value** | **long?** | The count, or the lower bound; absent when unknown. | [optional] 
**StoppedBy** | **string** | With &#x60;atLeast&#x60;, why counting stopped: &#x60;page&#x60;, &#x60;step&#x60;, &#x60;cap&#x60;, &#x60;budget&#x60; or &#x60;time&#x60;. | [optional] 
**Reason** | **string** | With &#x60;unknown&#x60;, why: &#x60;timeout&#x60; or &#x60;failed&#x60;. | [optional] 
**Ms** | **long?** | The time the count took in milliseconds, when one was waited for. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

