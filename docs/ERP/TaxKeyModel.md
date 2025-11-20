# Simplic.OxS.SDK.ERP.TaxKeyModel
Represents the shared model for Simplic.OxS.ERP.TaxKey.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the ID. | [optional] 
**Name** | **string** | Gets or sets the name. | [optional] 
**TaxGroup** | [**TaxGroupModel**](TaxGroupModel.md) |  | [optional] 
**TaxRate** | [**TaxRateModel**](TaxRateModel.md) |  | [optional] 
**Value** | **double** | Gets or sets the tax rate value given in percent. | [optional] 
**ValidFrom** | **DateTime** | Gets or sets the point in time this tax key is valid from. | [optional] 
**ValidTo** | **DateTime?** | Gets or sets the point in time this tax rate is valid to. | [optional] 
**CreateDateTime** | **DateTime** | Gets or sets the date and time the tax key is created. | [optional] 
**CreateUserId** | **Guid?** | Gets or sets the id of the user that created the tax key. | [optional] 
**CreateUserName** | **string** | Gets or sets the name of the user that created the tax key. | [optional] 
**UpdateDateTime** | **DateTime** | Gets or sets the date and time the tax key is updated. | [optional] 
**UpdateUserId** | **Guid?** | Gets or sets the id of the user that updated the tax key. | [optional] 
**UpdateUserName** | **string** | Gets or sets the name of the user that updated the tax key. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

