# Simplic.OxS.SDK.ERP.InvoiceItemRequest
Represents the request object for an electronic invoice item.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Gets or sets the ID. | [optional] 
**Text** | **string** | Gets or sets the text. | [optional] 
**QuantityUnit** | **QuantityCode** |  | [optional] 
**ArticleName** | **string** | Gets or sets the article name. | [optional] 
**SinglePriceNetBase** | **double?** | Gets or sets the single price excluding discounts and surcharges. | [optional] 
**TotalPriceNetBase** | **double?** | Gets or sets the total price excluding discounts and surcharges.     TotalPriceBase corresponds to the ZUGFeRD property GrossPriceProductTradePrice.   | [optional] 
**Quantity** | **double?** | Gets or sets the quantity. | [optional] 
**TaxType** | **TaxType** |  | [optional] 
**TaxCategory** | **TaxCategory** |  | [optional] 
**DiscountsSurcharges** | [**List&lt;DiscountSurchargeRequest&gt;**](DiscountSurchargeRequest.md) | Gets or sets the item level discounts and surcharges. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

