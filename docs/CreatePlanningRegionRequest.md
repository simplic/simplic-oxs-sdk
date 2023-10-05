# Simplic.OxS.SDK.Logistics.CreatePlanningRegionRequest
Request to create a planning region.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Gets or sets the name of the plannig region. | [optional] 
**HexColor** | **string** | Gets or sets the hex color of the planning region. | [optional] 
**Include** | [**List&lt;RegionModel&gt;**](RegionModel.md) | Gets or sets a list of country iso / zipcode tuples which are included from the plannig region. | [optional] 
**Exclude** | [**List&lt;RegionModel&gt;**](RegionModel.md) | Gets or sets a list of country iso / zipcode tuples which are excluded from the planning region. | [optional] 
**Functions** | **List&lt;string&gt;** | Gets or sets a list of functions for the region.  &lt;br&gt;  Currently planned are:  show_loadings,  show_unloading,  show_transits   | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

