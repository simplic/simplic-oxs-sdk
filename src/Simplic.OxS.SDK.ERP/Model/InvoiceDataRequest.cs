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
    /// Represents the request object for the data contained in an electronic invoice.
    /// </summary>
    [DataContract(Name = "InvoiceDataRequest")]
    public partial class InvoiceDataRequest : IEquatable<InvoiceDataRequest>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public CurrencyCode? Currency { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public InvoiceType? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceDataRequest" /> class.
        /// </summary>
        /// <param name="number">Gets or sets the invoice number..</param>
        /// <param name="invoiceDate">Gets or sets the invoice date..</param>
        /// <param name="deliveryDate">Gets or sets the delivery date..</param>
        /// <param name="billingPeriod">billingPeriod.</param>
        /// <param name="currency">currency.</param>
        /// <param name="businessProcess">Gets or sets the business process..</param>
        /// <param name="referenceNumber">Gets or sets the reference number..</param>
        /// <param name="buyerReference">Gets or sets the buyer reference.  &lt;br&gt;  This is where the Leitweg-ID for German public institution invoices needs to be passed.   See https://en.e-rechnung-bund.de/e-invoicing-faq/buyer-reference  .</param>
        /// <param name="buyer">buyer.</param>
        /// <param name="seller">seller.</param>
        /// <param name="debitorBankAccounts">Gets or sets the debitor bank accounts..</param>
        /// <param name="creditorBankAccounts">Gets or sets the creditor bank accounts..</param>
        /// <param name="notes">Gets or sets the notes..</param>
        /// <param name="paymentMethod">paymentMethod.</param>
        /// <param name="termsOfPayment">termsOfPayment.</param>
        /// <param name="taxes">Gets or sets the taxes..</param>
        /// <param name="type">type.</param>
        /// <param name="items">Gets or sets the set of invoice items..</param>
        public InvoiceDataRequest(string number = default(string), DateTime invoiceDate = default(DateTime), DateTime deliveryDate = default(DateTime), BillingPeriodRequest billingPeriod = default(BillingPeriodRequest), CurrencyCode? currency = default(CurrencyCode?), string businessProcess = default(string), string referenceNumber = default(string), string buyerReference = default(string), PartyRequest buyer = default(PartyRequest), PartyRequest seller = default(PartyRequest), List<BankAccountRequest> debitorBankAccounts = default(List<BankAccountRequest>), List<BankAccountRequest> creditorBankAccounts = default(List<BankAccountRequest>), List<string> notes = default(List<string>), ElectronicInvoicingPaymentMethodRequest paymentMethod = default(ElectronicInvoicingPaymentMethodRequest), ElectronicInvoicingTermsOfPaymentRequest termsOfPayment = default(ElectronicInvoicingTermsOfPaymentRequest), List<TaxRequest> taxes = default(List<TaxRequest>), InvoiceType? type = default(InvoiceType?), List<InvoiceItemRequest> items = default(List<InvoiceItemRequest>))
        {
            this.Number = number;
            this.InvoiceDate = invoiceDate;
            this.DeliveryDate = deliveryDate;
            this.BillingPeriod = billingPeriod;
            this.Currency = currency;
            this.BusinessProcess = businessProcess;
            this.ReferenceNumber = referenceNumber;
            this.BuyerReference = buyerReference;
            this.Buyer = buyer;
            this.Seller = seller;
            this.DebitorBankAccounts = debitorBankAccounts;
            this.CreditorBankAccounts = creditorBankAccounts;
            this.Notes = notes;
            this.PaymentMethod = paymentMethod;
            this.TermsOfPayment = termsOfPayment;
            this.Taxes = taxes;
            this.Type = type;
            this.Items = items;
        }

        /// <summary>
        /// Gets or sets the invoice number.
        /// </summary>
        /// <value>Gets or sets the invoice number.</value>
        [DataMember(Name = "number", EmitDefaultValue = true)]
        public string Number { get; set; }

        /// <summary>
        /// Gets or sets the invoice date.
        /// </summary>
        /// <value>Gets or sets the invoice date.</value>
        [DataMember(Name = "invoiceDate", EmitDefaultValue = false)]
        public DateTime InvoiceDate { get; set; }

        /// <summary>
        /// Gets or sets the delivery date.
        /// </summary>
        /// <value>Gets or sets the delivery date.</value>
        [DataMember(Name = "deliveryDate", EmitDefaultValue = false)]
        public DateTime DeliveryDate { get; set; }

        /// <summary>
        /// Gets or Sets BillingPeriod
        /// </summary>
        [DataMember(Name = "billingPeriod", EmitDefaultValue = false)]
        public BillingPeriodRequest BillingPeriod { get; set; }

        /// <summary>
        /// Gets or sets the business process.
        /// </summary>
        /// <value>Gets or sets the business process.</value>
        [DataMember(Name = "businessProcess", EmitDefaultValue = true)]
        public string BusinessProcess { get; set; }

        /// <summary>
        /// Gets or sets the reference number.
        /// </summary>
        /// <value>Gets or sets the reference number.</value>
        [DataMember(Name = "referenceNumber", EmitDefaultValue = true)]
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// Gets or sets the buyer reference.  &lt;br&gt;  This is where the Leitweg-ID for German public institution invoices needs to be passed.   See https://en.e-rechnung-bund.de/e-invoicing-faq/buyer-reference  
        /// </summary>
        /// <value>Gets or sets the buyer reference.  &lt;br&gt;  This is where the Leitweg-ID for German public institution invoices needs to be passed.   See https://en.e-rechnung-bund.de/e-invoicing-faq/buyer-reference  </value>
        [DataMember(Name = "buyerReference", EmitDefaultValue = true)]
        public string BuyerReference { get; set; }

        /// <summary>
        /// Gets or Sets Buyer
        /// </summary>
        [DataMember(Name = "buyer", EmitDefaultValue = false)]
        public PartyRequest Buyer { get; set; }

        /// <summary>
        /// Gets or Sets Seller
        /// </summary>
        [DataMember(Name = "seller", EmitDefaultValue = false)]
        public PartyRequest Seller { get; set; }

        /// <summary>
        /// Gets or sets the debitor bank accounts.
        /// </summary>
        /// <value>Gets or sets the debitor bank accounts.</value>
        [DataMember(Name = "debitorBankAccounts", EmitDefaultValue = true)]
        public List<BankAccountRequest> DebitorBankAccounts { get; set; }

        /// <summary>
        /// Gets or sets the creditor bank accounts.
        /// </summary>
        /// <value>Gets or sets the creditor bank accounts.</value>
        [DataMember(Name = "creditorBankAccounts", EmitDefaultValue = true)]
        public List<BankAccountRequest> CreditorBankAccounts { get; set; }

        /// <summary>
        /// Gets or sets the notes.
        /// </summary>
        /// <value>Gets or sets the notes.</value>
        [DataMember(Name = "notes", EmitDefaultValue = true)]
        public List<string> Notes { get; set; }

        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name = "paymentMethod", EmitDefaultValue = false)]
        public ElectronicInvoicingPaymentMethodRequest PaymentMethod { get; set; }

        /// <summary>
        /// Gets or Sets TermsOfPayment
        /// </summary>
        [DataMember(Name = "termsOfPayment", EmitDefaultValue = false)]
        public ElectronicInvoicingTermsOfPaymentRequest TermsOfPayment { get; set; }

        /// <summary>
        /// Gets or sets the taxes.
        /// </summary>
        /// <value>Gets or sets the taxes.</value>
        [DataMember(Name = "taxes", EmitDefaultValue = true)]
        public List<TaxRequest> Taxes { get; set; }

        /// <summary>
        /// Gets or sets the set of invoice items.
        /// </summary>
        /// <value>Gets or sets the set of invoice items.</value>
        [DataMember(Name = "items", EmitDefaultValue = true)]
        public List<InvoiceItemRequest> Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InvoiceDataRequest {\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  InvoiceDate: ").Append(InvoiceDate).Append("\n");
            sb.Append("  DeliveryDate: ").Append(DeliveryDate).Append("\n");
            sb.Append("  BillingPeriod: ").Append(BillingPeriod).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  BusinessProcess: ").Append(BusinessProcess).Append("\n");
            sb.Append("  ReferenceNumber: ").Append(ReferenceNumber).Append("\n");
            sb.Append("  BuyerReference: ").Append(BuyerReference).Append("\n");
            sb.Append("  Buyer: ").Append(Buyer).Append("\n");
            sb.Append("  Seller: ").Append(Seller).Append("\n");
            sb.Append("  DebitorBankAccounts: ").Append(DebitorBankAccounts).Append("\n");
            sb.Append("  CreditorBankAccounts: ").Append(CreditorBankAccounts).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  TermsOfPayment: ").Append(TermsOfPayment).Append("\n");
            sb.Append("  Taxes: ").Append(Taxes).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
            return this.Equals(input as InvoiceDataRequest);
        }

        /// <summary>
        /// Returns true if InvoiceDataRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceDataRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceDataRequest input)
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
                    this.InvoiceDate == input.InvoiceDate ||
                    (this.InvoiceDate != null &&
                    this.InvoiceDate.Equals(input.InvoiceDate))
                ) && 
                (
                    this.DeliveryDate == input.DeliveryDate ||
                    (this.DeliveryDate != null &&
                    this.DeliveryDate.Equals(input.DeliveryDate))
                ) && 
                (
                    this.BillingPeriod == input.BillingPeriod ||
                    (this.BillingPeriod != null &&
                    this.BillingPeriod.Equals(input.BillingPeriod))
                ) && 
                (
                    this.Currency == input.Currency ||
                    this.Currency.Equals(input.Currency)
                ) && 
                (
                    this.BusinessProcess == input.BusinessProcess ||
                    (this.BusinessProcess != null &&
                    this.BusinessProcess.Equals(input.BusinessProcess))
                ) && 
                (
                    this.ReferenceNumber == input.ReferenceNumber ||
                    (this.ReferenceNumber != null &&
                    this.ReferenceNumber.Equals(input.ReferenceNumber))
                ) && 
                (
                    this.BuyerReference == input.BuyerReference ||
                    (this.BuyerReference != null &&
                    this.BuyerReference.Equals(input.BuyerReference))
                ) && 
                (
                    this.Buyer == input.Buyer ||
                    (this.Buyer != null &&
                    this.Buyer.Equals(input.Buyer))
                ) && 
                (
                    this.Seller == input.Seller ||
                    (this.Seller != null &&
                    this.Seller.Equals(input.Seller))
                ) && 
                (
                    this.DebitorBankAccounts == input.DebitorBankAccounts ||
                    this.DebitorBankAccounts != null &&
                    input.DebitorBankAccounts != null &&
                    this.DebitorBankAccounts.SequenceEqual(input.DebitorBankAccounts)
                ) && 
                (
                    this.CreditorBankAccounts == input.CreditorBankAccounts ||
                    this.CreditorBankAccounts != null &&
                    input.CreditorBankAccounts != null &&
                    this.CreditorBankAccounts.SequenceEqual(input.CreditorBankAccounts)
                ) && 
                (
                    this.Notes == input.Notes ||
                    this.Notes != null &&
                    input.Notes != null &&
                    this.Notes.SequenceEqual(input.Notes)
                ) && 
                (
                    this.PaymentMethod == input.PaymentMethod ||
                    (this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(input.PaymentMethod))
                ) && 
                (
                    this.TermsOfPayment == input.TermsOfPayment ||
                    (this.TermsOfPayment != null &&
                    this.TermsOfPayment.Equals(input.TermsOfPayment))
                ) && 
                (
                    this.Taxes == input.Taxes ||
                    this.Taxes != null &&
                    input.Taxes != null &&
                    this.Taxes.SequenceEqual(input.Taxes)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
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
                if (this.InvoiceDate != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceDate.GetHashCode();
                }
                if (this.DeliveryDate != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryDate.GetHashCode();
                }
                if (this.BillingPeriod != null)
                {
                    hashCode = (hashCode * 59) + this.BillingPeriod.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                if (this.BusinessProcess != null)
                {
                    hashCode = (hashCode * 59) + this.BusinessProcess.GetHashCode();
                }
                if (this.ReferenceNumber != null)
                {
                    hashCode = (hashCode * 59) + this.ReferenceNumber.GetHashCode();
                }
                if (this.BuyerReference != null)
                {
                    hashCode = (hashCode * 59) + this.BuyerReference.GetHashCode();
                }
                if (this.Buyer != null)
                {
                    hashCode = (hashCode * 59) + this.Buyer.GetHashCode();
                }
                if (this.Seller != null)
                {
                    hashCode = (hashCode * 59) + this.Seller.GetHashCode();
                }
                if (this.DebitorBankAccounts != null)
                {
                    hashCode = (hashCode * 59) + this.DebitorBankAccounts.GetHashCode();
                }
                if (this.CreditorBankAccounts != null)
                {
                    hashCode = (hashCode * 59) + this.CreditorBankAccounts.GetHashCode();
                }
                if (this.Notes != null)
                {
                    hashCode = (hashCode * 59) + this.Notes.GetHashCode();
                }
                if (this.PaymentMethod != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentMethod.GetHashCode();
                }
                if (this.TermsOfPayment != null)
                {
                    hashCode = (hashCode * 59) + this.TermsOfPayment.GetHashCode();
                }
                if (this.Taxes != null)
                {
                    hashCode = (hashCode * 59) + this.Taxes.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Items != null)
                {
                    hashCode = (hashCode * 59) + this.Items.GetHashCode();
                }
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
            yield break;
        }
    }

}
