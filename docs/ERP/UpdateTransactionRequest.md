# Simplic.OxS.SDK.ERP.UpdateTransactionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** |  | 
**Number** | **string** |  | 
**Reference** | **string** |  | [optional] 
**TypeId** | **Guid** |  | 
**SubtypeId** | **Guid** |  | 
**Date** | **DateTime** |  | 
**DeliveryDate** | **DateTime?** |  | [optional] 
**TermsOfPaymentId** | **Guid** |  | 
**PaymentMethod** | [**TransactionPaymentMethod**](TransactionPaymentMethod.md) |  | 
**CurrencyId** | **Guid** |  | 
**Description** | **string** |  | [optional] 
**FinancialPartner** | [**TransactionContact**](TransactionContact.md) |  | 
**DeliveryAddress** | [**TransactionContact**](TransactionContact.md) |  | [optional] 
**InvoiceRecipient** | [**TransactionContact**](TransactionContact.md) |  | 
**Payer** | [**TransactionContact**](TransactionContact.md) |  | 
**Responsible** | [**TransactionContact**](TransactionContact.md) |  | 
**Representative** | [**TransactionContact**](TransactionContact.md) |  | [optional] 
**Items** | [**List&lt;TransactionItem&gt;**](TransactionItem.md) |  | [optional] 
**ConvertState** | **TransactionConvertState** |  | [optional] 
**AlternativePaymentDeadline** | **DateTime?** |  | [optional] 
**Balance** | **double** |  | [optional] 
**Barcode** | **string** |  | [optional] 
**BillToText** | **string** |  | [optional] 
**CashDiscountPercentValue** | **double** |  | [optional] 
**CashDiscountTotal** | **double** |  | [optional] 
**Document** | [**TransactionDocument**](TransactionDocument.md) |  | [optional] 
**FinancialAccountingPeriod** | [**TransactionPeriod**](TransactionPeriod.md) |  | [optional] 
**Period** | [**TransactionPeriod**](TransactionPeriod.md) |  | [optional] 
**States** | **List&lt;string&gt;** |  | [optional] 
**ManualVAT** | [**TransactionManualVat**](TransactionManualVat.md) |  | [optional] 
**Notes** | **string** |  | [optional] 
**DueDate** | **DateTime?** |  | [optional] 
**ReferenceNr** | **string** |  | [optional] 
**StandingOrder** | [**TransactionStandingOrder**](TransactionStandingOrder.md) |  | [optional] 
**TaxGroupId** | **Guid** |  | [optional] 
**TotalPrice** | **double** |  | [optional] 
**TotalPriceGross** | **double** |  | [optional] 
**TotalPriceNet** | **double** |  | [optional] 
**TotalPriceTax** | **double** |  | [optional] 
**TransactionYear** | **int** |  | [optional] 
**UpdateUser** | [**TransactionUser**](TransactionUser.md) |  | 
**SignedTotalPriceNet** | **double** |  | [optional] 
**SignedTotalPriceGross** | **double** |  | [optional] 
**SignedTotalPrice** | **double** |  | [optional] 
**SignedTotalPriceTax** | **double** |  | [optional] 
**Sign** | **int** |  | [optional] 
**ItemGroupTermsOfPayments** | [**List&lt;TransactionItemGroupTermsOfPayment&gt;**](TransactionItemGroupTermsOfPayment.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

