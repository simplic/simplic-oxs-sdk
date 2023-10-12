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
    /// TransactionItem
    /// </summary>
    [DataContract(Name = "TransactionItem")]
    public partial class TransactionItem : IEquatable<TransactionItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionItem" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="text">text.</param>
        /// <param name="type">type.</param>
        /// <param name="bookedFromTransactionId">bookedFromTransactionId.</param>
        /// <param name="transactionItemCollectionId">transactionItemCollectionId.</param>
        /// <param name="sortNumber">sortNumber.</param>
        public TransactionItem(Guid id = default(Guid), string text = default(string), TransactionItemType type = default(TransactionItemType), Guid? bookedFromTransactionId = default(Guid?), Guid transactionItemCollectionId = default(Guid), int sortNumber = default(int))
        {
            this.Id = id;
            this.Text = text;
            this.Type = type;
            this.BookedFromTransactionId = bookedFromTransactionId;
            this.TransactionItemCollectionId = transactionItemCollectionId;
            this.SortNumber = sortNumber;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name = "text", EmitDefaultValue = true)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TransactionItemType Type { get; set; }

        /// <summary>
        /// Gets or Sets BookedFromTransactionId
        /// </summary>
        [DataMember(Name = "bookedFromTransactionId", EmitDefaultValue = true)]
        public Guid? BookedFromTransactionId { get; set; }

        /// <summary>
        /// Gets or Sets TransactionItemCollectionId
        /// </summary>
        [DataMember(Name = "transactionItemCollectionId", EmitDefaultValue = false)]
        public Guid TransactionItemCollectionId { get; set; }

        /// <summary>
        /// Gets or Sets SortNumber
        /// </summary>
        [DataMember(Name = "sortNumber", EmitDefaultValue = false)]
        public int SortNumber { get; set; }

        /// <summary>
        /// Gets or Sets DeserializationType
        /// </summary>
        [DataMember(Name = "deserializationType", EmitDefaultValue = true)]
        public string DeserializationType { get; private set; }

        /// <summary>
        /// Returns false as DeserializationType should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDeserializationType()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  BookedFromTransactionId: ").Append(BookedFromTransactionId).Append("\n");
            sb.Append("  TransactionItemCollectionId: ").Append(TransactionItemCollectionId).Append("\n");
            sb.Append("  SortNumber: ").Append(SortNumber).Append("\n");
            sb.Append("  DeserializationType: ").Append(DeserializationType).Append("\n");
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
            return this.Equals(input as TransactionItem);
        }

        /// <summary>
        /// Returns true if TransactionItem instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionItem input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.BookedFromTransactionId == input.BookedFromTransactionId ||
                    (this.BookedFromTransactionId != null &&
                    this.BookedFromTransactionId.Equals(input.BookedFromTransactionId))
                ) && 
                (
                    this.TransactionItemCollectionId == input.TransactionItemCollectionId ||
                    (this.TransactionItemCollectionId != null &&
                    this.TransactionItemCollectionId.Equals(input.TransactionItemCollectionId))
                ) && 
                (
                    this.SortNumber == input.SortNumber ||
                    this.SortNumber.Equals(input.SortNumber)
                ) && 
                (
                    this.DeserializationType == input.DeserializationType ||
                    (this.DeserializationType != null &&
                    this.DeserializationType.Equals(input.DeserializationType))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Text != null)
                {
                    hashCode = (hashCode * 59) + this.Text.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.BookedFromTransactionId != null)
                {
                    hashCode = (hashCode * 59) + this.BookedFromTransactionId.GetHashCode();
                }
                if (this.TransactionItemCollectionId != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionItemCollectionId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SortNumber.GetHashCode();
                if (this.DeserializationType != null)
                {
                    hashCode = (hashCode * 59) + this.DeserializationType.GetHashCode();
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
