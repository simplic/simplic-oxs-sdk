# Simplic.OxS.SDK.Contract.ContractModel
Represents the model of a contract.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Number** | **string** | Gets or sets the number.  A human readable identifier. | [optional] 
**Name** | **string** | Gets or sets the name. | [optional] 
**ReferenceNumber** | **string** | Gets or sets the reference number. | [optional] 
**OrderDate** | **DateTime?** | Gets or sets the order date.  Should only contain the date. | [optional] 
**StartDate** | **DateTime?** | Gets or sets the start date of the contract.  Should only contain the date. | [optional] 
**EndDate** | **DateTime?** | Gets or sets the end date of the contract.  Should only contain the date. | [optional] 
**BillingType** | **BillingTypeModel** |  | [optional] 
**ProjectId** | **Guid?** | Gets or sets the project id.  References projects like e.g. construction sites. | [optional] 
**TermOfPayment** | [**TermsOfPaymentModel**](TermsOfPaymentModel.md) |  | [optional] 
**SubmissionDate** | **string** | Gets or sets the submission date. | [optional] 
**Insurance** | **double?** | Gets the insurance amount. | [optional] 
**Creditworthiness** | **string** | Gets the creditworthiness of the customer. | [optional] 
**CreditLimit** | **string** | Gets the credit limit. | [optional] 
**InternalNote** | **string** | Gets or sets the internal note. | [optional] 
**IsDeleted** | **bool?** | Get or sets the is deleted flag | [optional] 
**Id** | **Guid** | Gets or sets the contract id. | [optional] 
**OrganizationId** | **Guid** | Gets or sets the organization id. | [optional] 
**Status** | [**ContractStatusModel**](ContractStatusModel.md) |  | [optional] 
**BusinessPartner** | [**BillableContactModel**](BillableContactModel.md) |  | [optional] 
**Customer** | [**BillableContactModel**](BillableContactModel.md) |  | [optional] 
**RepresentativeUser** | [**UserModel**](UserModel.md) |  | [optional] 
**ContactPerson** | [**AddressModel**](AddressModel.md) |  | [optional] 
**Items** | [**List&lt;ContractItemModel&gt;**](ContractItemModel.md) | Gets or sets the items of the contrat. | [optional] 
**CreateDateTime** | **DateTime** | Gets or sets the create date time. | [optional] 
**CreateUserId** | **Guid?** | Gets or sets the create user id. | [optional] 
**CreateUserName** | **string** | Gets or sets the create user name. | [optional] 
**UpdateDateTime** | **DateTime** | Gets or sets the update date time. | [optional] 
**UpdateUserId** | **Guid?** | Gets or sets the update user id. | [optional] 
**UpdateUserName** | **string** | Gets or sets the update user name. | [optional] 
**ExternalOrderLink** | **string** | Gets or sets the link for external ordering. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

