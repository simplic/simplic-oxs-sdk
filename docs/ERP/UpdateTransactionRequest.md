# Simplic.OxS.SDK.ERP.UpdateTransactionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Number** | **string** |  | [optional] 
**Reference** | **string** |  | [optional] 
**TypeId** | **Guid?** |  | [optional] 
**SubtypeId** | **Guid?** |  | [optional] 
**Date** | **DateTime?** |  | [optional] 
**DeliveryDate** | **DateTime?** |  | [optional] 
**TermsOfPaymentId** | **Guid?** |  | [optional] 
**PaymentMethodId** | **Guid?** |  | [optional] 
**CurrencyId** | **Guid?** |  | [optional] 
**Description** | **string** |  | [optional] 
**FinancialPartner** | [**TransactionContactRequest**](TransactionContactRequest.md) |  | [optional] 
**DeliveryAddress** | [**TransactionContactRequest**](TransactionContactRequest.md) |  | [optional] 
**InvoiceRecipient** | [**TransactionContactRequest**](TransactionContactRequest.md) |  | [optional] 
**Payer** | [**TransactionContactRequest**](TransactionContactRequest.md) |  | [optional] 
**Responsible** | [**TransactionContactRequest**](TransactionContactRequest.md) |  | [optional] 
**Representative** | [**TransactionContactRequest**](TransactionContactRequest.md) |  | [optional] 
**Items** | [**List&lt;TransactionItemRequest&gt;**](TransactionItemRequest.md) |  | [optional] 
**AlternativePaymentDeadline** | **DateTime?** |  | [optional] 
**Balance** | **double?** |  | [optional] 
**Barcode** | **string** |  | [optional] 
**BillToText** | **string** |  | [optional] 
**CashDiscountPercentValue** | **double?** |  | [optional] 
**CashDiscountTotal** | **double?** |  | [optional] 
**FinancialAccountingPeriodId** | **Guid?** |  | [optional] 
**PeriodId** | **Guid?** |  | [optional] 
**ManualVAT** | [**TransactionManualVatRequest**](TransactionManualVatRequest.md) |  | [optional] 
**Notes** | **string** |  | [optional] 
**DueDate** | **DateTime?** |  | [optional] 
**ReferenceNr** | **string** |  | [optional] 
**TaxGroupId** | **Guid?** |  | [optional] 
**OperationItemCombinationMode** | **OperationItemCombinationMode** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

