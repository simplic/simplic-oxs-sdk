# Simplic.OxS.SDK.ERP.TransactionModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] 
**OrganizationId** | **Guid** |  | [optional] 
**IsDeleted** | **bool** |  | [optional] 
**Number** | **string** |  | [optional] 
**Reference** | **string** |  | [optional] 
**Type** | [**TransactionType**](TransactionType.md) |  | [optional] 
**Date** | **DateTime** |  | [optional] 
**DeliveryDate** | **DateTime?** |  | [optional] 
**TermsOfPayment** | [**TermsOfPaymentModel**](TermsOfPaymentModel.md) |  | [optional] 
**PaymentMethod** | [**TransactionPaymentMethodModel**](TransactionPaymentMethodModel.md) |  | [optional] 
**Currency** | [**TransactionCurrencyModel**](TransactionCurrencyModel.md) |  | [optional] 
**Description** | **string** |  | [optional] 
**FinancialPartner** | [**TransactionContactModel**](TransactionContactModel.md) |  | [optional] 
**DeliveryAddress** | [**TransactionContactModel**](TransactionContactModel.md) |  | [optional] 
**InvoiceRecipient** | [**TransactionContactModel**](TransactionContactModel.md) |  | [optional] 
**Payer** | [**TransactionContactModel**](TransactionContactModel.md) |  | [optional] 
**Creator** | [**TransactionContactModel**](TransactionContactModel.md) |  | [optional] 
**Responsible** | [**TransactionContactModel**](TransactionContactModel.md) |  | [optional] 
**Representative** | [**TransactionContactModel**](TransactionContactModel.md) |  | [optional] 
**Items** | [**List&lt;TransactionItemModel&gt;**](TransactionItemModel.md) |  | [optional] 
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
**ManualVat** | [**TransactionManualVat**](TransactionManualVat.md) |  | [optional] 
**Notes** | **string** |  | [optional] 
**DueDate** | **DateTime?** |  | [optional] 
**ReferenceNr** | **string** |  | [optional] 
**StandingOrder** | [**TransactionStandingOrder**](TransactionStandingOrder.md) |  | [optional] 
**TaxGroup** | [**TaxGroup**](TaxGroup.md) |  | [optional] 
**TotalPrice** | **double** |  | [optional] 
**TotalPriceGross** | **double** |  | [optional] 
**TotalPriceNet** | **double** |  | [optional] 
**TotalPriceTax** | **double** |  | [optional] 
**TransactionYear** | **int** |  | [optional] 
**UpdateUser** | [**TransactionUser**](TransactionUser.md) |  | [optional] 
**SignedTotalPriceNet** | **double** |  | [optional] 
**SignedTotalPriceGross** | **double** |  | [optional] 
**SignedTotalPrice** | **double** |  | [optional] 
**SignedTotalPriceTax** | **double** |  | [optional] 
**Sign** | **int** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

