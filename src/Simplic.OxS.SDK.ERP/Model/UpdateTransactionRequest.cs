/*
 * Simplic.OxS.ERP
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Simplic.OxS.SDK.OpenAPIDateConverter;

using Simplic.OxS.SDK;

namespace Simplic.OxS.SDK.ERP
{
    /// <summary>
    /// UpdateTransactionRequest
    /// </summary>
    [DataContract(Name = "UpdateTransactionRequest")]
    public partial class UpdateTransactionRequest : IEquatable<UpdateTransactionRequest>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets OperationItemCombinationMode
        /// </summary>
        [DataMember(Name = "operationItemCombinationMode", EmitDefaultValue = false)]
        public OperationItemCombinationMode? OperationItemCombinationMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTransactionRequest" /> class.
        /// </summary>
        /// <param name="number">number.</param>
        /// <param name="reference">reference.</param>
        /// <param name="typeId">typeId.</param>
        /// <param name="subtypeId">subtypeId.</param>
        /// <param name="date">date.</param>
        /// <param name="deliveryDate">deliveryDate.</param>
        /// <param name="termsOfPaymentId">termsOfPaymentId.</param>
        /// <param name="paymentMethodId">paymentMethodId.</param>
        /// <param name="currencyId">currencyId.</param>
        /// <param name="description">description.</param>
        /// <param name="financialPartner">financialPartner.</param>
        /// <param name="deliveryAddress">deliveryAddress.</param>
        /// <param name="invoiceRecipient">invoiceRecipient.</param>
        /// <param name="payer">payer.</param>
        /// <param name="responsible">responsible.</param>
        /// <param name="representative">representative.</param>
        /// <param name="items">items.</param>
        /// <param name="alternativePaymentDeadline">alternativePaymentDeadline.</param>
        /// <param name="balance">balance.</param>
        /// <param name="barcode">barcode.</param>
        /// <param name="billToText">billToText.</param>
        /// <param name="cashDiscountPercentValue">cashDiscountPercentValue.</param>
        /// <param name="cashDiscountTotal">cashDiscountTotal.</param>
        /// <param name="financialAccountingPeriodId">financialAccountingPeriodId.</param>
        /// <param name="periodId">periodId.</param>
        /// <param name="manualVAT">manualVAT.</param>
        /// <param name="notes">notes.</param>
        /// <param name="dueDate">dueDate.</param>
        /// <param name="referenceNr">referenceNr.</param>
        /// <param name="taxGroupId">taxGroupId.</param>
        /// <param name="operationItemCombinationMode">operationItemCombinationMode.</param>
        public UpdateTransactionRequest(string number = default(string), string reference = default(string), Guid? typeId = default(Guid?), Guid? subtypeId = default(Guid?), DateTime? date = default(DateTime?), DateTime? deliveryDate = default(DateTime?), Guid? termsOfPaymentId = default(Guid?), Guid? paymentMethodId = default(Guid?), Guid? currencyId = default(Guid?), string description = default(string), TransactionContactRequest financialPartner = default(TransactionContactRequest), TransactionContactRequest deliveryAddress = default(TransactionContactRequest), TransactionContactRequest invoiceRecipient = default(TransactionContactRequest), TransactionContactRequest payer = default(TransactionContactRequest), TransactionContactRequest responsible = default(TransactionContactRequest), TransactionContactRequest representative = default(TransactionContactRequest), List<TransactionItemRequest> items = default(List<TransactionItemRequest>), DateTime? alternativePaymentDeadline = default(DateTime?), double? balance = default(double?), string barcode = default(string), string billToText = default(string), double? cashDiscountPercentValue = default(double?), double? cashDiscountTotal = default(double?), Guid? financialAccountingPeriodId = default(Guid?), Guid? periodId = default(Guid?), TransactionManualVatRequest manualVAT = default(TransactionManualVatRequest), string notes = default(string), DateTime? dueDate = default(DateTime?), string referenceNr = default(string), Guid? taxGroupId = default(Guid?), OperationItemCombinationMode? operationItemCombinationMode = default(OperationItemCombinationMode?))
        {
            this.Number = number;
            this.Reference = reference;
            this.TypeId = typeId;
            this.SubtypeId = subtypeId;
            this.Date = date;
            this.DeliveryDate = deliveryDate;
            this.TermsOfPaymentId = termsOfPaymentId;
            this.PaymentMethodId = paymentMethodId;
            this.CurrencyId = currencyId;
            this.Description = description;
            this.FinancialPartner = financialPartner;
            this.DeliveryAddress = deliveryAddress;
            this.InvoiceRecipient = invoiceRecipient;
            this.Payer = payer;
            this.Responsible = responsible;
            this.Representative = representative;
            this.Items = items;
            this.AlternativePaymentDeadline = alternativePaymentDeadline;
            this.Balance = balance;
            this.Barcode = barcode;
            this.BillToText = billToText;
            this.CashDiscountPercentValue = cashDiscountPercentValue;
            this.CashDiscountTotal = cashDiscountTotal;
            this.FinancialAccountingPeriodId = financialAccountingPeriodId;
            this.PeriodId = periodId;
            this.ManualVAT = manualVAT;
            this.Notes = notes;
            this.DueDate = dueDate;
            this.ReferenceNr = referenceNr;
            this.TaxGroupId = taxGroupId;
            this.OperationItemCombinationMode = operationItemCombinationMode;
        }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name = "number", EmitDefaultValue = true)]
        public string Number { get; set; }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name = "reference", EmitDefaultValue = true)]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or Sets TypeId
        /// </summary>
        [DataMember(Name = "typeId", EmitDefaultValue = true)]
        public Guid? TypeId { get; set; }

        /// <summary>
        /// Gets or Sets SubtypeId
        /// </summary>
        [DataMember(Name = "subtypeId", EmitDefaultValue = true)]
        public Guid? SubtypeId { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name = "date", EmitDefaultValue = true)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryDate
        /// </summary>
        [DataMember(Name = "deliveryDate", EmitDefaultValue = true)]
        public DateTime? DeliveryDate { get; set; }

        /// <summary>
        /// Gets or Sets TermsOfPaymentId
        /// </summary>
        [DataMember(Name = "termsOfPaymentId", EmitDefaultValue = true)]
        public Guid? TermsOfPaymentId { get; set; }

        /// <summary>
        /// Gets or Sets PaymentMethodId
        /// </summary>
        [DataMember(Name = "paymentMethodId", EmitDefaultValue = true)]
        public Guid? PaymentMethodId { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyId
        /// </summary>
        [DataMember(Name = "currencyId", EmitDefaultValue = true)]
        public Guid? CurrencyId { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets FinancialPartner
        /// </summary>
        [DataMember(Name = "financialPartner", EmitDefaultValue = false)]
        public TransactionContactRequest FinancialPartner { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryAddress
        /// </summary>
        [DataMember(Name = "deliveryAddress", EmitDefaultValue = false)]
        public TransactionContactRequest DeliveryAddress { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceRecipient
        /// </summary>
        [DataMember(Name = "invoiceRecipient", EmitDefaultValue = false)]
        public TransactionContactRequest InvoiceRecipient { get; set; }

        /// <summary>
        /// Gets or Sets Payer
        /// </summary>
        [DataMember(Name = "payer", EmitDefaultValue = false)]
        public TransactionContactRequest Payer { get; set; }

        /// <summary>
        /// Gets or Sets Responsible
        /// </summary>
        [DataMember(Name = "responsible", EmitDefaultValue = false)]
        public TransactionContactRequest Responsible { get; set; }

        /// <summary>
        /// Gets or Sets Representative
        /// </summary>
        [DataMember(Name = "representative", EmitDefaultValue = false)]
        public TransactionContactRequest Representative { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name = "items", EmitDefaultValue = true)]
        public List<TransactionItemRequest> Items { get; set; }

        /// <summary>
        /// Gets or Sets AlternativePaymentDeadline
        /// </summary>
        [DataMember(Name = "alternativePaymentDeadline", EmitDefaultValue = true)]
        public DateTime? AlternativePaymentDeadline { get; set; }

        /// <summary>
        /// Gets or Sets Balance
        /// </summary>
        [DataMember(Name = "balance", EmitDefaultValue = true)]
        public double? Balance { get; set; }

        /// <summary>
        /// Gets or Sets Barcode
        /// </summary>
        [DataMember(Name = "barcode", EmitDefaultValue = true)]
        public string Barcode { get; set; }

        /// <summary>
        /// Gets or Sets BillToText
        /// </summary>
        [DataMember(Name = "billToText", EmitDefaultValue = true)]
        public string BillToText { get; set; }

        /// <summary>
        /// Gets or Sets CashDiscountPercentValue
        /// </summary>
        [DataMember(Name = "cashDiscountPercentValue", EmitDefaultValue = true)]
        public double? CashDiscountPercentValue { get; set; }

        /// <summary>
        /// Gets or Sets CashDiscountTotal
        /// </summary>
        [DataMember(Name = "cashDiscountTotal", EmitDefaultValue = true)]
        public double? CashDiscountTotal { get; set; }

        /// <summary>
        /// Gets or Sets FinancialAccountingPeriodId
        /// </summary>
        [DataMember(Name = "financialAccountingPeriodId", EmitDefaultValue = true)]
        public Guid? FinancialAccountingPeriodId { get; set; }

        /// <summary>
        /// Gets or Sets PeriodId
        /// </summary>
        [DataMember(Name = "periodId", EmitDefaultValue = true)]
        public Guid? PeriodId { get; set; }

        /// <summary>
        /// Gets or Sets ManualVAT
        /// </summary>
        [DataMember(Name = "manualVAT", EmitDefaultValue = false)]
        public TransactionManualVatRequest ManualVAT { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name = "notes", EmitDefaultValue = true)]
        public string Notes { get; set; }

        /// <summary>
        /// Gets or Sets DueDate
        /// </summary>
        [DataMember(Name = "dueDate", EmitDefaultValue = true)]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceNr
        /// </summary>
        [DataMember(Name = "referenceNr", EmitDefaultValue = true)]
        public string ReferenceNr { get; set; }

        /// <summary>
        /// Gets or Sets TaxGroupId
        /// </summary>
        [DataMember(Name = "taxGroupId", EmitDefaultValue = true)]
        public Guid? TaxGroupId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateTransactionRequest {\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  TypeId: ").Append(TypeId).Append("\n");
            sb.Append("  SubtypeId: ").Append(SubtypeId).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  DeliveryDate: ").Append(DeliveryDate).Append("\n");
            sb.Append("  TermsOfPaymentId: ").Append(TermsOfPaymentId).Append("\n");
            sb.Append("  PaymentMethodId: ").Append(PaymentMethodId).Append("\n");
            sb.Append("  CurrencyId: ").Append(CurrencyId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  FinancialPartner: ").Append(FinancialPartner).Append("\n");
            sb.Append("  DeliveryAddress: ").Append(DeliveryAddress).Append("\n");
            sb.Append("  InvoiceRecipient: ").Append(InvoiceRecipient).Append("\n");
            sb.Append("  Payer: ").Append(Payer).Append("\n");
            sb.Append("  Responsible: ").Append(Responsible).Append("\n");
            sb.Append("  Representative: ").Append(Representative).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  AlternativePaymentDeadline: ").Append(AlternativePaymentDeadline).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  Barcode: ").Append(Barcode).Append("\n");
            sb.Append("  BillToText: ").Append(BillToText).Append("\n");
            sb.Append("  CashDiscountPercentValue: ").Append(CashDiscountPercentValue).Append("\n");
            sb.Append("  CashDiscountTotal: ").Append(CashDiscountTotal).Append("\n");
            sb.Append("  FinancialAccountingPeriodId: ").Append(FinancialAccountingPeriodId).Append("\n");
            sb.Append("  PeriodId: ").Append(PeriodId).Append("\n");
            sb.Append("  ManualVAT: ").Append(ManualVAT).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  ReferenceNr: ").Append(ReferenceNr).Append("\n");
            sb.Append("  TaxGroupId: ").Append(TaxGroupId).Append("\n");
            sb.Append("  OperationItemCombinationMode: ").Append(OperationItemCombinationMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateTransactionRequest);
        }

        /// <summary>
        /// Returns true if UpdateTransactionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateTransactionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateTransactionRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.TypeId == input.TypeId ||
                    (this.TypeId != null &&
                    this.TypeId.Equals(input.TypeId))
                ) && 
                (
                    this.SubtypeId == input.SubtypeId ||
                    (this.SubtypeId != null &&
                    this.SubtypeId.Equals(input.SubtypeId))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.DeliveryDate == input.DeliveryDate ||
                    (this.DeliveryDate != null &&
                    this.DeliveryDate.Equals(input.DeliveryDate))
                ) && 
                (
                    this.TermsOfPaymentId == input.TermsOfPaymentId ||
                    (this.TermsOfPaymentId != null &&
                    this.TermsOfPaymentId.Equals(input.TermsOfPaymentId))
                ) && 
                (
                    this.PaymentMethodId == input.PaymentMethodId ||
                    (this.PaymentMethodId != null &&
                    this.PaymentMethodId.Equals(input.PaymentMethodId))
                ) && 
                (
                    this.CurrencyId == input.CurrencyId ||
                    (this.CurrencyId != null &&
                    this.CurrencyId.Equals(input.CurrencyId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.FinancialPartner == input.FinancialPartner ||
                    (this.FinancialPartner != null &&
                    this.FinancialPartner.Equals(input.FinancialPartner))
                ) && 
                (
                    this.DeliveryAddress == input.DeliveryAddress ||
                    (this.DeliveryAddress != null &&
                    this.DeliveryAddress.Equals(input.DeliveryAddress))
                ) && 
                (
                    this.InvoiceRecipient == input.InvoiceRecipient ||
                    (this.InvoiceRecipient != null &&
                    this.InvoiceRecipient.Equals(input.InvoiceRecipient))
                ) && 
                (
                    this.Payer == input.Payer ||
                    (this.Payer != null &&
                    this.Payer.Equals(input.Payer))
                ) && 
                (
                    this.Responsible == input.Responsible ||
                    (this.Responsible != null &&
                    this.Responsible.Equals(input.Responsible))
                ) && 
                (
                    this.Representative == input.Representative ||
                    (this.Representative != null &&
                    this.Representative.Equals(input.Representative))
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
                (
                    this.AlternativePaymentDeadline == input.AlternativePaymentDeadline ||
                    (this.AlternativePaymentDeadline != null &&
                    this.AlternativePaymentDeadline.Equals(input.AlternativePaymentDeadline))
                ) && 
                (
                    this.Balance == input.Balance ||
                    (this.Balance != null &&
                    this.Balance.Equals(input.Balance))
                ) && 
                (
                    this.Barcode == input.Barcode ||
                    (this.Barcode != null &&
                    this.Barcode.Equals(input.Barcode))
                ) && 
                (
                    this.BillToText == input.BillToText ||
                    (this.BillToText != null &&
                    this.BillToText.Equals(input.BillToText))
                ) && 
                (
                    this.CashDiscountPercentValue == input.CashDiscountPercentValue ||
                    (this.CashDiscountPercentValue != null &&
                    this.CashDiscountPercentValue.Equals(input.CashDiscountPercentValue))
                ) && 
                (
                    this.CashDiscountTotal == input.CashDiscountTotal ||
                    (this.CashDiscountTotal != null &&
                    this.CashDiscountTotal.Equals(input.CashDiscountTotal))
                ) && 
                (
                    this.FinancialAccountingPeriodId == input.FinancialAccountingPeriodId ||
                    (this.FinancialAccountingPeriodId != null &&
                    this.FinancialAccountingPeriodId.Equals(input.FinancialAccountingPeriodId))
                ) && 
                (
                    this.PeriodId == input.PeriodId ||
                    (this.PeriodId != null &&
                    this.PeriodId.Equals(input.PeriodId))
                ) && 
                (
                    this.ManualVAT == input.ManualVAT ||
                    (this.ManualVAT != null &&
                    this.ManualVAT.Equals(input.ManualVAT))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.DueDate == input.DueDate ||
                    (this.DueDate != null &&
                    this.DueDate.Equals(input.DueDate))
                ) && 
                (
                    this.ReferenceNr == input.ReferenceNr ||
                    (this.ReferenceNr != null &&
                    this.ReferenceNr.Equals(input.ReferenceNr))
                ) && 
                (
                    this.TaxGroupId == input.TaxGroupId ||
                    (this.TaxGroupId != null &&
                    this.TaxGroupId.Equals(input.TaxGroupId))
                ) && 
                (
                    this.OperationItemCombinationMode == input.OperationItemCombinationMode ||
                    this.OperationItemCombinationMode.Equals(input.OperationItemCombinationMode)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Number != null)
                {
                    hashCode = (hashCode * 59) + this.Number.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                if (this.TypeId != null)
                {
                    hashCode = (hashCode * 59) + this.TypeId.GetHashCode();
                }
                if (this.SubtypeId != null)
                {
                    hashCode = (hashCode * 59) + this.SubtypeId.GetHashCode();
                }
                if (this.Date != null)
                {
                    hashCode = (hashCode * 59) + this.Date.GetHashCode();
                }
                if (this.DeliveryDate != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryDate.GetHashCode();
                }
                if (this.TermsOfPaymentId != null)
                {
                    hashCode = (hashCode * 59) + this.TermsOfPaymentId.GetHashCode();
                }
                if (this.PaymentMethodId != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentMethodId.GetHashCode();
                }
                if (this.CurrencyId != null)
                {
                    hashCode = (hashCode * 59) + this.CurrencyId.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.FinancialPartner != null)
                {
                    hashCode = (hashCode * 59) + this.FinancialPartner.GetHashCode();
                }
                if (this.DeliveryAddress != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryAddress.GetHashCode();
                }
                if (this.InvoiceRecipient != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceRecipient.GetHashCode();
                }
                if (this.Payer != null)
                {
                    hashCode = (hashCode * 59) + this.Payer.GetHashCode();
                }
                if (this.Responsible != null)
                {
                    hashCode = (hashCode * 59) + this.Responsible.GetHashCode();
                }
                if (this.Representative != null)
                {
                    hashCode = (hashCode * 59) + this.Representative.GetHashCode();
                }
                if (this.Items != null)
                {
                    hashCode = (hashCode * 59) + this.Items.GetHashCode();
                }
                if (this.AlternativePaymentDeadline != null)
                {
                    hashCode = (hashCode * 59) + this.AlternativePaymentDeadline.GetHashCode();
                }
                if (this.Balance != null)
                {
                    hashCode = (hashCode * 59) + this.Balance.GetHashCode();
                }
                if (this.Barcode != null)
                {
                    hashCode = (hashCode * 59) + this.Barcode.GetHashCode();
                }
                if (this.BillToText != null)
                {
                    hashCode = (hashCode * 59) + this.BillToText.GetHashCode();
                }
                if (this.CashDiscountPercentValue != null)
                {
                    hashCode = (hashCode * 59) + this.CashDiscountPercentValue.GetHashCode();
                }
                if (this.CashDiscountTotal != null)
                {
                    hashCode = (hashCode * 59) + this.CashDiscountTotal.GetHashCode();
                }
                if (this.FinancialAccountingPeriodId != null)
                {
                    hashCode = (hashCode * 59) + this.FinancialAccountingPeriodId.GetHashCode();
                }
                if (this.PeriodId != null)
                {
                    hashCode = (hashCode * 59) + this.PeriodId.GetHashCode();
                }
                if (this.ManualVAT != null)
                {
                    hashCode = (hashCode * 59) + this.ManualVAT.GetHashCode();
                }
                if (this.Notes != null)
                {
                    hashCode = (hashCode * 59) + this.Notes.GetHashCode();
                }
                if (this.DueDate != null)
                {
                    hashCode = (hashCode * 59) + this.DueDate.GetHashCode();
                }
                if (this.ReferenceNr != null)
                {
                    hashCode = (hashCode * 59) + this.ReferenceNr.GetHashCode();
                }
                if (this.TaxGroupId != null)
                {
                    hashCode = (hashCode * 59) + this.TaxGroupId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.OperationItemCombinationMode.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Notes (string) maxLength
            if (this.Notes != null && this.Notes.Length > 10000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Notes, length must be less than 10000.", new [] { "Notes" });
            }

            // Notes (string) minLength
            if (this.Notes != null && this.Notes.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Notes, length must be greater than 1.", new [] { "Notes" });
            }

            // ReferenceNr (string) maxLength
            if (this.ReferenceNr != null && this.ReferenceNr.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReferenceNr, length must be less than 100.", new [] { "ReferenceNr" });
            }

            // ReferenceNr (string) minLength
            if (this.ReferenceNr != null && this.ReferenceNr.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReferenceNr, length must be greater than 1.", new [] { "ReferenceNr" });
            }

            yield break;
        }
    }

}
