# Simplic.OxS.SDK.Storage.Management.BookingModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] 
**IsDeleted** | **bool** |  | [optional] 
**OrganizationId** | **Guid** |  | [optional] 
**Customer** | [**AddressModel**](AddressModel.md) |  | [optional] 
**Location** | [**AddressModel**](AddressModel.md) |  | [optional] 
**Driver** | [**AddressModel**](AddressModel.md) |  | [optional] 
**Vehicle** | [**BookingVehicleModel**](BookingVehicleModel.md) |  | [optional] 
**Carrier** | [**AddressModel**](AddressModel.md) |  | [optional] 
**ExternalVehicle** | **string** |  | [optional] 
**ExternalCarrier** | **string** |  | [optional] 
**ExternalDriver** | **string** |  | [optional] 
**Date** | **DateTime?** |  | [optional] 
**SignatureUser** | [**SignatureUserModel**](SignatureUserModel.md) |  | [optional] 
**SignatureDriver** | [**SignatureUserModel**](SignatureUserModel.md) |  | [optional] 
**EcoNumber** | **string** |  | [optional] 
**DeliveryNote** | **string** |  | [optional] 
**LoadingAids** | [**List&lt;LoadingAidModel&gt;**](LoadingAidModel.md) |  | [optional] 
**Images** | **List&lt;Guid&gt;** |  | [optional] 
**CreateDateTime** | **DateTime** |  | [optional] 
**CreateUserId** | **Guid?** |  | [optional] 
**CreateUserName** | **string** |  | [optional] 
**UpdateDateTime** | **DateTime** |  | [optional] 
**UpdateUserId** | **Guid?** |  | [optional] 
**UpdateUserName** | **string** |  | [optional] 
**SealsArrival** | **List&lt;string&gt;** |  | [optional] 
**SealsDeparture** | **List&lt;string&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

