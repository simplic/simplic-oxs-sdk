# Simplic.OxS.SDK.Contract.BillableContactRequestModel
Represents a billable contact of an order request.  If Simplic.OxS.Contract.Server.Model.AddressModel.ContactId or Simplic.OxS.Contract.Server.Model.BillableContactRequestModel.PersonalAccountId is set, the contact will be resolved and the manually set fields are ignored. Otherwise the manually set fields are used directly, which allows creating an order for a not yet existing contact.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address** | [**AddressModel**](AddressModel.md) |  | [optional] 
**PersonalAccountId** | **Guid?** | Gets or sets the personal account id. | [optional] 
**AccountNumber** | **string** | Gets or sets the account number. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

