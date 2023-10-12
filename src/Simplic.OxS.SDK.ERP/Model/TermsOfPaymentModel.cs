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
using OpenAPIDateConverter = Simplic.OxS.SDK.ERP.OpenAPIDateConverter;

namespace Simplic.OxS.SDK.ERP
{
    /// <summary>
    /// TermsOfPaymentModel
    /// </summary>
    [DataContract(Name = "TermsOfPaymentModel")]
    public partial class TermsOfPaymentModel : IEquatable<TermsOfPaymentModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TermsOfPaymentModel" /> class.
        /// </summary>
        /// <param name="number">number.</param>
        /// <param name="name">name.</param>
        /// <param name="cashDiscount">cashDiscount.</param>
        /// <param name="cashDiscountDays">cashDiscountDays.</param>
        /// <param name="paymentDeadlineDays">paymentDeadlineDays.</param>
        /// <param name="states">states.</param>
        /// <param name="formattedText">formattedText.</param>
        /// <param name="id">id.</param>
        /// <param name="isDeleted">isDeleted.</param>
        /// <param name="createDateTime">createDateTime.</param>
        /// <param name="createUserId">createUserId.</param>
        /// <param name="createUserName">createUserName.</param>
        /// <param name="updateDateTime">updateDateTime.</param>
        /// <param name="updateUserId">updateUserId.</param>
        /// <param name="updateUserName">updateUserName.</param>
        /// <param name="organizationId">organizationId.</param>
        public TermsOfPaymentModel(int number = default(int), string name = default(string), double cashDiscount = default(double), int cashDiscountDays = default(int), int paymentDeadlineDays = default(int), List<string> states = default(List<string>), string formattedText = default(string), Guid id = default(Guid), bool isDeleted = default(bool), DateTime createDateTime = default(DateTime), Guid? createUserId = default(Guid?), string createUserName = default(string), DateTime updateDateTime = default(DateTime), Guid? updateUserId = default(Guid?), string updateUserName = default(string), Guid organizationId = default(Guid))
        {
            this.Number = number;
            this.Name = name;
            this.CashDiscount = cashDiscount;
            this.CashDiscountDays = cashDiscountDays;
            this.PaymentDeadlineDays = paymentDeadlineDays;
            this.States = states;
            this.FormattedText = formattedText;
            this.Id = id;
            this.IsDeleted = isDeleted;
            this.CreateDateTime = createDateTime;
            this.CreateUserId = createUserId;
            this.CreateUserName = createUserName;
            this.UpdateDateTime = updateDateTime;
            this.UpdateUserId = updateUserId;
            this.UpdateUserName = updateUserName;
            this.OrganizationId = organizationId;
        }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name = "number", EmitDefaultValue = false)]
        public int Number { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
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
        [DataMember(Name = "paymentDeadlineDays", EmitDefaultValue = false)]
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
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets IsDeleted
        /// </summary>
        [DataMember(Name = "isDeleted", EmitDefaultValue = true)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets or Sets CreateDateTime
        /// </summary>
        [DataMember(Name = "createDateTime", EmitDefaultValue = false)]
        public DateTime CreateDateTime { get; set; }

        /// <summary>
        /// Gets or Sets CreateUserId
        /// </summary>
        [DataMember(Name = "createUserId", EmitDefaultValue = true)]
        public Guid? CreateUserId { get; set; }

        /// <summary>
        /// Gets or Sets CreateUserName
        /// </summary>
        [DataMember(Name = "createUserName", EmitDefaultValue = true)]
        public string CreateUserName { get; set; }

        /// <summary>
        /// Gets or Sets UpdateDateTime
        /// </summary>
        [DataMember(Name = "updateDateTime", EmitDefaultValue = false)]
        public DateTime UpdateDateTime { get; set; }

        /// <summary>
        /// Gets or Sets UpdateUserId
        /// </summary>
        [DataMember(Name = "updateUserId", EmitDefaultValue = true)]
        public Guid? UpdateUserId { get; set; }

        /// <summary>
        /// Gets or Sets UpdateUserName
        /// </summary>
        [DataMember(Name = "updateUserName", EmitDefaultValue = true)]
        public string UpdateUserName { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationId
        /// </summary>
        [DataMember(Name = "organizationId", EmitDefaultValue = false)]
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TermsOfPaymentModel {\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CashDiscount: ").Append(CashDiscount).Append("\n");
            sb.Append("  CashDiscountDays: ").Append(CashDiscountDays).Append("\n");
            sb.Append("  PaymentDeadlineDays: ").Append(PaymentDeadlineDays).Append("\n");
            sb.Append("  States: ").Append(States).Append("\n");
            sb.Append("  FormattedText: ").Append(FormattedText).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  CreateDateTime: ").Append(CreateDateTime).Append("\n");
            sb.Append("  CreateUserId: ").Append(CreateUserId).Append("\n");
            sb.Append("  CreateUserName: ").Append(CreateUserName).Append("\n");
            sb.Append("  UpdateDateTime: ").Append(UpdateDateTime).Append("\n");
            sb.Append("  UpdateUserId: ").Append(UpdateUserId).Append("\n");
            sb.Append("  UpdateUserName: ").Append(UpdateUserName).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
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
            return this.Equals(input as TermsOfPaymentModel);
        }

        /// <summary>
        /// Returns true if TermsOfPaymentModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TermsOfPaymentModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TermsOfPaymentModel input)
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
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IsDeleted == input.IsDeleted ||
                    this.IsDeleted.Equals(input.IsDeleted)
                ) && 
                (
                    this.CreateDateTime == input.CreateDateTime ||
                    (this.CreateDateTime != null &&
                    this.CreateDateTime.Equals(input.CreateDateTime))
                ) && 
                (
                    this.CreateUserId == input.CreateUserId ||
                    (this.CreateUserId != null &&
                    this.CreateUserId.Equals(input.CreateUserId))
                ) && 
                (
                    this.CreateUserName == input.CreateUserName ||
                    (this.CreateUserName != null &&
                    this.CreateUserName.Equals(input.CreateUserName))
                ) && 
                (
                    this.UpdateDateTime == input.UpdateDateTime ||
                    (this.UpdateDateTime != null &&
                    this.UpdateDateTime.Equals(input.UpdateDateTime))
                ) && 
                (
                    this.UpdateUserId == input.UpdateUserId ||
                    (this.UpdateUserId != null &&
                    this.UpdateUserId.Equals(input.UpdateUserId))
                ) && 
                (
                    this.UpdateUserName == input.UpdateUserName ||
                    (this.UpdateUserName != null &&
                    this.UpdateUserName.Equals(input.UpdateUserName))
                ) && 
                (
                    this.OrganizationId == input.OrganizationId ||
                    (this.OrganizationId != null &&
                    this.OrganizationId.Equals(input.OrganizationId))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsDeleted.GetHashCode();
                if (this.CreateDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.CreateDateTime.GetHashCode();
                }
                if (this.CreateUserId != null)
                {
                    hashCode = (hashCode * 59) + this.CreateUserId.GetHashCode();
                }
                if (this.CreateUserName != null)
                {
                    hashCode = (hashCode * 59) + this.CreateUserName.GetHashCode();
                }
                if (this.UpdateDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.UpdateDateTime.GetHashCode();
                }
                if (this.UpdateUserId != null)
                {
                    hashCode = (hashCode * 59) + this.UpdateUserId.GetHashCode();
                }
                if (this.UpdateUserName != null)
                {
                    hashCode = (hashCode * 59) + this.UpdateUserName.GetHashCode();
                }
                if (this.OrganizationId != null)
                {
                    hashCode = (hashCode * 59) + this.OrganizationId.GetHashCode();
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
