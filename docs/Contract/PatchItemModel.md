# Simplic.OxS.SDK.Contract.PatchItemModel
Represents the base model of a contract item.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the id. | [optional] 
**Text** | **string** | Gets or sets the text of the item. | [optional] 
**Index** | **int?** | Gets or sets the index.  Will set the index of the item in the list of items. | [optional] 
**PositionNumber** | **int?** | Gets or sets the position number of the contract item. | [optional] 
**ReferenceNumber** | **string** | Gets or sets the reference number. | [optional] 
**SupplierReferenceNumber** | **string** | Gets or sets the reference number for the supplier. | [optional] 
**BillingType** | **BillingType** |  | [optional] 
**ArticleId** | **Guid?** | Gets or sets the article id. | [optional] 
**Quantity** | [**QuantityRequest**](QuantityRequest.md) |  | [optional] 
**PlannedQuantity** | [**QuantityRequest**](QuantityRequest.md) |  | [optional] 
**Costs** | [**List&lt;PatchCostObject&gt;**](PatchCostObject.md) | Gets or sets the costs. | [optional] 
**Distance** | **double?** | Gets or sets the distance for the calculation in kilometers. | [optional] 
**TollDistance** | **double?** | Gets or sets the tollable distance for the calculation in kilometers. | [optional] 
**VehicleType** | [**VehicleTypeModel**](VehicleTypeModel.md) |  | [optional] 
**CashDiscount** | **bool?** | Gets or sets whether the item is cash discountable. | [optional] 
**AlternativeType** | **AlternativeTypeModel** |  | [optional] 
**ParentItem** | **Guid?** | Gets or sets the id of the parent item in case of an alternative item. | [optional] 
**PrintToReporting** | **bool?** | Gets or sets whether the item is added to the report. | [optional] 
**UseInDisposition** | **bool?** | Gets or sets whether the item is used for the disposition conversion. | [optional] 
**Type** | **string** | Gets the type of the contract item. | [optional] 
**SupplierContactId** | **Guid?** | Gets or sets the contact id of the supplier of the contract item. | [optional] 
**LoadingAddressId** | **Guid?** | Gets or sets the loading address id of the customer of the contract item. | [optional] 
**UnloadingAddressId** | **Guid?** | Gets or sets the unloading address id of the customer of the contract item. | [optional] 
**AlternativeLoadingAddressId** | **Guid?** | Gets or sets the alnternative loading address id of the customer of the contract item. | [optional] 
**AlternativeUnloadingAddressId** | **Guid?** | Gets or sets the alnternative unloading address id of the customer of the contract item. | [optional] 
**ContractNumber** | **string** |  | [optional] 
**DepartmentId** | **Guid?** | Gets or sets the department id | [optional] 
**Description** | **string** | Gets or sets the description. | [optional] 
**Certified** | **bool?** | Gets or sets whether the article is certified. | [optional] 
**EndDate** | **DateTime?** | Gets or sets the end date of the article item. | [optional] 
**Remove** | **bool** | Remove flag for the patch helper. | [optional] 
**Addon** | **Dictionary&lt;string, Object&gt;** | Gets or sets a dictionary of addon properties.  Can be used to set customer exclusive properties for a contract. | [optional] 
**AllowExternalOrdering** | **bool?** | Gets or sets whether external ordering is allowed for this item. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

