# Simplic.OxS.SDK.ERP.TaxGroupModel
Represents the shared model for Simplic.OxS.ERP.TaxGroup.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] 
**OrganizationId** | **Guid** |  | [optional] 
**IsDeleted** | **bool** |  | [optional] 
**Number** | **int** | Gets or sets the number. | [optional] 
**Name** | **string** | Gets or sets the name. | [optional] 
**Countries** | [**List&lt;TaxGroupCountryModel&gt;**](TaxGroupCountryModel.md) | Gets or sets the set of countries. | [optional] 
**TaxRates** | [**List&lt;TaxRateModel&gt;**](TaxRateModel.md) | Gets or sets the tax rates for this tax group. | [optional] 
**CreateDateTime** | **DateTime** | Gets or sets the date and time the tax group is created. | [optional] 
**CreateUserId** | **Guid?** | Gets or sets the id of the user that created the tax group. | [optional] 
**CreateUserName** | **string** | Gets or sets the name of the user that created the tax group. | [optional] 
**UpdateDateTime** | **DateTime** | Gets or sets the date and time the tax group is updated. | [optional] 
**UpdateUserId** | **Guid?** | Gets or sets the id of the user that updated the tax group. | [optional] 
**UpdateUserName** | **string** | Gets or sets the name of the user that updated the tax group. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

