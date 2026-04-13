# Simplic.OxS.SDK.Contract.ExternalOrderingContractModel
Represents a subset of the contract for external ordering.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the contract id. | [optional] 
**Number** | **string** | Gets or sets the contract number. | [optional] 
**ValidFrom** | **DateTime?** | Gets or sets the valid from date. | [optional] 
**ValidTo** | **DateTime?** | Gets or sets the valid to date. | [optional] 
**Customer** | [**ExternalOrderingCustomerModel**](ExternalOrderingCustomerModel.md) |  | [optional] 
**ConstructionSite** | [**ExternalOrderingConstructionSiteModel**](ExternalOrderingConstructionSiteModel.md) |  | [optional] 
**Items** | [**List&lt;ExternalOrderingContractItemModel&gt;**](ExternalOrderingContractItemModel.md) | Gets or sets the contract items. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

