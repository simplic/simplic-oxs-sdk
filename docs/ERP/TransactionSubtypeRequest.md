# Simplic.OxS.SDK.ERP.TransactionSubtypeRequest
Represents a request to create or update a Simplic.OxS.ERP.Transaction.TransactionSubtype.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the ID. | [optional] 
**Code** | **string** | Stable code for subtype deployment/references. | [optional] 
**Report** | [**TransactionSubtypeReport**](TransactionSubtypeReport.md) |  | [optional] 
**SequenceNumberRange** | [**TransactionSequenceNumberRange**](TransactionSequenceNumberRange.md) |  | [optional] 
**OutputConfiguration** | [**TransactionSubtypeOutputConfiguration**](TransactionSubtypeOutputConfiguration.md) |  | [optional] 
**CancellationTransactionType** | [**TransactionSubtypeCancellationTransactionType**](TransactionSubtypeCancellationTransactionType.md) |  | [optional] 
**Number** | **int?** | Gets or sets a unique number. | [optional] 
**Name** | **string** | Gets or sets the subtype name. | [optional] 
**DocumentTitleTemplate** | **string** | Gets or sets the document title template. | [optional] 
**ArchiveMode** | **TransactionSubtypeArchiveMode** |  | [optional] 
**BarcodeTemplate** | **string** | Gets or sets the barcode template | [optional] 
**UseNumberReservation** | **bool?** | Gets or sets whether to use transaction number generation or not | [optional] 
**CustomField2Template** | **string** | Gets or sets the template for the custom field 2 in a financial export | [optional] 
**CustomField1Template** | **string** | Gets or sets the template for the custom field 1 in a financial export | [optional] 
**BookingTextTemplate** | **string** | Gets or sets the template for the booking text | [optional] 
**SummarizeBookings** | **bool?** | Gets or sets whether to summarize datev bookings | [optional] 
**AccountingExportGroup** | **string** | Gets or sets the accounting export group | [optional] 
**DueDateMode** | **DueDateMode** |  | [optional] 
**TransactionNumberDateSource** | **TransactionNumberDateSourceType** |  | [optional] 
**ExportCostQuantity** | **ExportCostQuantityType** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

