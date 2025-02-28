# Simplic.OxS.SDK.ERP.BehaviorDefinitionModel
Represents the shared model for a behavior definition. A behavior definition is a pair of an expression and a target that is modified by the expression result.  <br>  Using behavior definitions the operation performed by applying an operation item can depend on the set of items assigned to it. For example if a discount only applies if the price of all assigned items is above a minimum threshold.  A target can be a property whose value is set as the expression result.  The set of items the operation item applies to can be filtered. If the assigned items are targeted, the expression is interpreted as a condition to filter the items by.  

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the ID. | [optional] 
**Target** | **string** | Gets or sets the targeted variable. | [optional] 
**Expression** | **string** | Gets or sets the behavior defining expression. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

