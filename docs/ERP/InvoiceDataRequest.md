# Simplic.OxS.SDK.ERP.InvoiceDataRequest
Represents the request object for the data contained in an electronic invoice.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Number** | **string** | Gets or sets the invoice number. | [optional] 
**InvoiceDate** | **DateTime** | Gets or sets the invoice date. | [optional] 
**DeliveryDate** | **DateTime** | Gets or sets the delivery date. | [optional] 
**BillingPeriod** | [**BillingPeriodRequest**](BillingPeriodRequest.md) |  | [optional] 
**Currency** | **CurrencyCode** |  | [optional] 
**BusinessProcess** | **string** | Gets or sets the business process. | [optional] 
**ReferenceNumber** | **string** | Gets or sets the reference number. | [optional] 
**Buyer** | [**PartyRequest**](PartyRequest.md) |  | [optional] 
**Seller** | [**PartyRequest**](PartyRequest.md) |  | [optional] 
**DebitorBankAccounts** | [**List&lt;BankAccountRequest&gt;**](BankAccountRequest.md) | Gets or sets the debitor bank accounts. | [optional] 
**CreditorBankAccounts** | [**List&lt;BankAccountRequest&gt;**](BankAccountRequest.md) | Gets or sets the creditor bank accounts. | [optional] 
**Notes** | **List&lt;string&gt;** | Gets or sets the notes. | [optional] 
**PaymentMethod** | [**ElectronicInvoicingPaymentMethodRequest**](ElectronicInvoicingPaymentMethodRequest.md) |  | [optional] 
**TermsOfPayment** | [**ElectronicInvoicingTermsOfPaymentRequest**](ElectronicInvoicingTermsOfPaymentRequest.md) |  | [optional] 
**Taxes** | [**List&lt;TaxRequest&gt;**](TaxRequest.md) | Gets or sets the taxes. | [optional] 
**Type** | **InvoiceType** |  | [optional] 
**Items** | [**List&lt;InvoiceItemRequest&gt;**](InvoiceItemRequest.md) | Gets or sets the set of invoice items. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

