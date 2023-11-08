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
    /// TermsOfPaymentRequest
    /// </summary>
    [DataContract(Name = "TermsOfPaymentRequest")]
    public partial class TermsOfPaymentRequest : IEquatable<TermsOfPaymentRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TermsOfPaymentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TermsOfPaymentRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TermsOfPaymentRequest" /> class.
        /// </summary>
        /// <param name="number">number (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="cashDiscount">cashDiscount.</param>
        /// <param name="cashDiscountDays">cashDiscountDays.</param>
        /// <param name="paymentDeadlineDays">paymentDeadlineDays (required).</param>
        /// <param name="states">states.</param>
        /// <param name="formattedText">formattedText.</param>
        public TermsOfPaymentRequest(int number = default(int), string name = default(string), double cashDiscount = default(double), int cashDiscountDays = default(int), int paymentDeadlineDays = default(int), List<string> states = default(List<string>), string formattedText = default(string))
        {
            this.Number = number;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for TermsOfPaymentRequest and cannot be null");
            }
            this.Name = name;
            this.PaymentDeadlineDays = paymentDeadlineDays;
            this.CashDiscount = cashDiscount;
            this.CashDiscountDays = cashDiscountDays;
            this.States = states;
            this.FormattedText = formattedText;
        }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name = "number", IsRequired = true, EmitDefaultValue = true)]
        public int Number { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets CashDiscount
        /// </summary>
        [DataMember(Name = "cashDiscount", EmitDefaultValue = false)]
        public double CashDiscount { get; set; }

        /// <summary>
        /// Gets or Sets CashDiscountDays
        /// </summary>
        [DataMember(Name = "cashDiscountDays", EmitDefaultValue = false)]
        public int CashDiscountDays { get; set; }

        /// <summary>
        /// Gets or Sets PaymentDeadlineDays
        /// </summary>
        [DataMember(Name = "paymentDeadlineDays", IsRequired = true, EmitDefaultValue = true)]
        public int PaymentDeadlineDays { get; set; }

        /// <summary>
        /// Gets or Sets States
        /// </summary>
        [DataMember(Name = "states", EmitDefaultValue = true)]
        public List<string> States { get; set; }

        /// <summary>
        /// Gets or Sets FormattedText
        /// </summary>
        [DataMember(Name = "formattedText", EmitDefaultValue = true)]
        public string FormattedText { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TermsOfPaymentRequest {\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CashDiscount: ").Append(CashDiscount).Append("\n");
            sb.Append("  CashDiscountDays: ").Append(CashDiscountDays).Append("\n");
            sb.Append("  PaymentDeadlineDays: ").Append(PaymentDeadlineDays).Append("\n");
            sb.Append("  States: ").Append(States).Append("\n");
            sb.Append("  FormattedText: ").Append(FormattedText).Append("\n");
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
            return this.Equals(input as TermsOfPaymentRequest);
        }

        /// <summary>
        /// Returns true if TermsOfPaymentRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TermsOfPaymentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TermsOfPaymentRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Number == input.Number ||
                    this.Number.Equals(input.Number)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.CashDiscount == input.CashDiscount ||
                    this.CashDiscount.Equals(input.CashDiscount)
                ) && 
                (
                    this.CashDiscountDays == input.CashDiscountDays ||
                    this.CashDiscountDays.Equals(input.CashDiscountDays)
                ) && 
                (
                    this.PaymentDeadlineDays == input.PaymentDeadlineDays ||
                    this.PaymentDeadlineDays.Equals(input.PaymentDeadlineDays)
                ) && 
                (
                    this.States == input.States ||
                    this.States != null &&
                    input.States != null &&
                    this.States.SequenceEqual(input.States)
                ) && 
                (
                    this.FormattedText == input.FormattedText ||
                    (this.FormattedText != null &&
                    this.FormattedText.Equals(input.FormattedText))
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
                hashCode = (hashCode * 59) + this.Number.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CashDiscount.GetHashCode();
                hashCode = (hashCode * 59) + this.CashDiscountDays.GetHashCode();
                hashCode = (hashCode * 59) + this.PaymentDeadlineDays.GetHashCode();
                if (this.States != null)
                {
                    hashCode = (hashCode * 59) + this.States.GetHashCode();
                }
                if (this.FormattedText != null)
                {
                    hashCode = (hashCode * 59) + this.FormattedText.GetHashCode();
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 100.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 2.", new [] { "Name" });
            }

            // FormattedText (string) maxLength
            if (this.FormattedText != null && this.FormattedText.Length > 10000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FormattedText, length must be less than 10000.", new [] { "FormattedText" });
            }

            // FormattedText (string) minLength
            if (this.FormattedText != null && this.FormattedText.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FormattedText, length must be greater than 1.", new [] { "FormattedText" });
            }

            yield break;
        }
    }

}
