# Simplic.OxS.SDK.Model.PlanningRegionModel
Represents the server model of a planning region.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the id. | [optional] 
**Name** | **string** | Gets or sets the name of the plannig region. | [optional] 
**HexColor** | **string** | Gets or sets the hex color of the planning region. | [optional] 
**Include** | [**List&lt;RegionModel&gt;**](RegionModel.md) | Gets or sets a list of country iso / zipcode tuples which are included from the plannig region. | [optional] 
**Exclude** | [**List&lt;RegionModel&gt;**](RegionModel.md) | Gets or sets a list of country iso / zipcode tuples which are excluded from the planning region. | [optional] 
**Functions** | **List&lt;string&gt;** | Gets or sets a list of functions for the region.  &lt;br&gt;  Currently planned are:  show_loading,  show_unloading,  show_transit   | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

