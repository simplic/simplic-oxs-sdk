# Simplic.OxS.SDK.Contract.ContractItemModel
Represents an contract item.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the id of the contract item. | [optional] 
**Text** | **string** | Gets or sets the text of the item. | [optional] 
**Index** | **int** | Gets or sets the index.  Will set the index of the item in the list of items. | [optional] 
**PositionNumber** | **int** | Gets or sets the position number of the contract item. | [optional] 
**ReferenceNumber** | **string** | Gets or sets the reference number. | [optional] 
**SupplierReferenceNumber** | **string** | Gets or sets the reference number for the supplier. | [optional] 
**BillingType** | **BillingType** |  | [optional] 
**Quantity** | [**QuantityModel**](QuantityModel.md) |  | [optional] 
**PlannedQuantity** | [**QuantityModel**](QuantityModel.md) |  | [optional] 
**Costs** | [**List&lt;CostObjectModel&gt;**](CostObjectModel.md) | Gets or sets the costs. | [optional] 
**Distance** | **double** | Gets or sets the distance for the calculation in kilometers. | [optional] 
**TollDistance** | **double** | Gets or sets the tollable distance for the calculation in kilometers. | [optional] 
**VehicleType** | [**VehicleTypeModel**](VehicleTypeModel.md) |  | [optional] 
**CashDiscount** | **bool** | Gets or sets whether the item is cash discountable. | [optional] 
**AlternativeType** | **AlternativeTypeModel** |  | [optional] 
**ParentItem** | **Guid?** | Gets or sets the id of the parent item in case of an alternative item. | [optional] 
**PrintToReporting** | **bool** | Gets or sets whether the item is added to the report. | [optional] 
**UseInDisposition** | **bool** | Gets or sets whether the item is used for the disposition conversion. | [optional] 
**Type** | **string** | Gets the type of the contract item. | [optional] 
**IsDiscount** | **bool?** | Gets or sets if the item is a discount. | [optional] 
**ContractNumber** | **string** | Gets or sets the contract number. | [optional] 
**Addon** | **Dictionary&lt;string, Object&gt;** | Gets or sets a dictionary of addon properties.  Can be used to set customer exclusive properties for a contract. | [optional] 
**AllowExternalOrdering** | **bool** | Gets or sets whether external ordering is allowed for this item. | [optional] 
**Supplier** | [**Address**](Address.md) |  | [optional] 
**Article** | [**ArticleModel**](ArticleModel.md) |  | [optional] 
**LoadingAddress** | [**Address**](Address.md) |  | [optional] 
**UnloadingAddress** | [**Address**](Address.md) |  | [optional] 
**AlternativeLoadingAddress** | [**Address**](Address.md) |  | [optional] 
**AlternativeUnloadingAddress** | [**Address**](Address.md) |  | [optional] 
**Department** | [**DepartmentModel**](DepartmentModel.md) |  | [optional] 
**Description** | **string** | Gets or sets the description. | [optional] 
**Certified** | **bool?** | Gets or sets whether the article is certified. | [optional] 
**EndDate** | **DateTime?** | Gets or sets the end date of the article item. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

