# Simplic.OxS.SDK.ERP.CreateTransactionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Creator** | [**TransactionContactRequest**](TransactionContactRequest.md) |  | 
**Number** | **string** |  | 
**Reference** | **string** |  | [optional] 
**TypeId** | **Guid** |  | 
**SubtypeId** | **Guid** |  | 
**Date** | **DateTime** |  | 
**DeliveryDate** | **DateTime?** |  | [optional] 
**TermsOfPaymentId** | **Guid** |  | 
**PaymentMethodId** | **Guid** |  | 
**CurrencyId** | **Guid** |  | 
**Description** | **string** |  | [optional] 
**FinancialPartner** | [**TransactionContactRequest**](TransactionContactRequest.md) |  | 
**DeliveryAddress** | [**TransactionContactRequest**](TransactionContactRequest.md) |  | [optional] 
**InvoiceRecipient** | [**TransactionContactRequest**](TransactionContactRequest.md) |  | 
**Payer** | [**TransactionContactRequest**](TransactionContactRequest.md) |  | 
**Responsible** | [**TransactionContactRequest**](TransactionContactRequest.md) |  | 
**Representative** | [**TransactionContactRequest**](TransactionContactRequest.md) |  | 
**Items** | [**List&lt;TransactionItemRequest&gt;**](TransactionItemRequest.md) |  | [optional] 
**AlternativePaymentDeadline** | **DateTime?** |  | [optional] 
**Balance** | **double?** |  | [optional] 
**Barcode** | **string** |  | [optional] 
**BillToText** | **string** |  | [optional] 
**CashDiscountPercentValue** | **double?** |  | [optional] 
**CashDiscountTotal** | **double?** |  | [optional] 
**FinancialAccountingPeriodId** | **Guid** |  | 
**PeriodId** | **Guid** |  | 
**ManualVAT** | [**TransactionManualVatRequest**](TransactionManualVatRequest.md) |  | [optional] 
**Notes** | **string** |  | [optional] 
**DueDate** | **DateTime?** |  | [optional] 
**ReferenceNr** | **string** |  | [optional] 
**TaxGroupId** | **Guid** |  | 
**OperationItemCombinationMode** | **OperationItemCombinationMode** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

