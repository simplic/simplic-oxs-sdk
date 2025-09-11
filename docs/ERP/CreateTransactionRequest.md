# Simplic.OxS.SDK.ERP.CreateTransactionRequest
Represents a request to create a Simplic.OxS.ERP.Transaction.Transaction.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Creator** | [**TransactionContactRequest**](TransactionContactRequest.md) |  | 
**Number** | **string** | Gets or sets the transaction number. | 
**Reference** | **string** | Gets or sets the reference. | [optional] 
**TypeId** | **Guid** | Gets or sets the type by ID. | 
**SubtypeId** | **Guid** | Gets or sets the subtype by ID. | 
**Date** | **DateTime** | Gets or sets the time of the underlying transaction. | 
**DeliveryDate** | **DateTime?** | Gets or sets the time of delivery. | [optional] 
**TermsOfPaymentId** | **Guid** | Gets or sets the terms of payment by ID.     The terms of payment include the payment deadline, a potential cash discount and the number of days the discount applies.   | 
**PaymentMethodId** | **Guid** | Gets or sets the payment method for this transaction given by ID. | 
**CurrencyId** | **Guid** | Gets or sets the currency used to quantify this transaction by ID. | 
**Description** | **string** | Gets or sets the description. | [optional] 
**FinancialPartner** | [**TransactionContactRequest**](TransactionContactRequest.md) |  | 
**DeliveryAddress** | [**TransactionContactRequest**](TransactionContactRequest.md) |  | [optional] 
**InvoiceRecipient** | [**TransactionContactRequest**](TransactionContactRequest.md) |  | 
**Payer** | [**TransactionContactRequest**](TransactionContactRequest.md) |  | 
**Responsible** | [**TransactionContactRequest**](TransactionContactRequest.md) |  | 
**Representative** | [**TransactionContactRequest**](TransactionContactRequest.md) |  | 
**Items** | [**List&lt;TransactionItemRequest&gt;**](TransactionItemRequest.md) | Gets or sets the items of this transaction. | [optional] 
**AlternativePaymentDeadline** | **DateTime?** | Gets or sets an alternative payment deadline to the one defined in the terms of payment. | [optional] 
**Balance** | **double?** |  | [optional] 
**Barcode** | **string** | Gets or sets the barcode. | [optional] 
**BillToText** | **string** | Gets or sets the bill as a text. | [optional] 
**CashDiscountPercentValue** | **double?** | Gets or sets the relative cash discount. | [optional] 
**CashDiscountTotal** | **double?** | Gets or sets the total cash discount. | [optional] 
**FinancialAccountingPeriodId** | **Guid** | Gets or sets the financial year period of this transaction given by ID. | 
**PeriodId** | **Guid** | Gets or sets the financial year period of this transaction for inventory management given by ID. | 
**ManualVAT** | [**TransactionManualVatRequest**](TransactionManualVatRequest.md) |  | [optional] 
**Notes** | **string** | Gets or sets notes. | [optional] 
**DueDate** | **DateTime?** | Gets or sets the due date. | [optional] 
**ReferenceNr** | **string** | Gets or sets the reference number. | [optional] 
**TaxGroupId** | **Guid** | Gets or sets the tax group by ID. | 
**OperationItemCombinationMode** | **OperationItemCombinationMode** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

