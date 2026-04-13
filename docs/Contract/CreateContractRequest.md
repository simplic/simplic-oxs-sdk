# Simplic.OxS.SDK.Contract.CreateContractRequest

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
**BusinessPartnerContactId** | **Guid?** | Gets or sets the contact id for the business partner. | [optional] 
**BusinessPartnerPersonalAccountId** | **Guid?** | Gets or sets the personal account id for the business partner. | [optional] 
**CustomerContactId** | **Guid?** | Gets or sets the contact id for the customer. | [optional] 
**CustomerPersonalAccountId** | **Guid?** | Gets or sets the personal account id for the customer. | [optional] 
**RepresentativeUserId** | **Guid?** | Gets or sets the id of the representative user. | [optional] 
**ContactPersonContactId** | **Guid?** | Gets or sets the contact id for the contact person. | [optional] 
**Items** | [**List&lt;CreateItemModel&gt;**](CreateItemModel.md) | Gets or sets the items of the contrat. | [optional] 
**StatusId** | **Guid?** | Gets or sets the contract status. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

