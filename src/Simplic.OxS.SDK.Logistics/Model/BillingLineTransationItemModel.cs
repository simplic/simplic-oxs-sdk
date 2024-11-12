/*
 * Simplic.OxS.Logistics
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

namespace Simplic.OxS.SDK.Logistics
{
    /// <summary>
    /// Shared model of billing line transaction.
    /// </summary>
    [DataContract(Name = "BillingLineTransationItemModel")]
    public partial class BillingLineTransationItemModel : IEquatable<BillingLineTransationItemModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingLineTransationItemModel" /> class.
        /// </summary>
        /// <param name="transactionId">Gets or sets the transaction id.     This represents the unique identifier of a Simplic.Erp.Transaction.  .</param>
        /// <param name="transactionItemId">Gets or sets the transaction item id.     This represents the unique identifier fo a Simplic.Erp.TransactionItem.  .</param>
        /// <param name="number">Gets or sets the transaction number.     This represents the number of a transaction, which is a human readable number to represent the transaction.  .</param>
        /// <param name="typeName">Gets or sets the type name.     Represents the name of the type of the transaction.  .</param>
        /// <param name="subtypeName">Gets or sets the subtype name.     Represents the name of the subtype of the transaction.  .</param>
        /// <param name="createDateTime">Gets or sets the create date time.     Represents the create date and time of the transaction.  .</param>
        /// <param name="singlePrice">Gets or sets the single price.     Represents the single price of the transaction item.  .</param>
        /// <param name="totalPrice">Gets or sets the total price.     Represents the total price of a transaction item.  .</param>
        /// <param name="quantity">quantity.</param>
        public BillingLineTransationItemModel(Guid transactionId = default(Guid), Guid transactionItemId = default(Guid), string number = default(string), string typeName = default(string), string subtypeName = default(string), DateTime createDateTime = default(DateTime), double singlePrice = default(double), double totalPrice = default(double), QuantityModel quantity = default(QuantityModel))
        {
            this.TransactionId = transactionId;
            this.TransactionItemId = transactionItemId;
            this.Number = number;
            this.TypeName = typeName;
            this.SubtypeName = subtypeName;
            this.CreateDateTime = createDateTime;
            this.SinglePrice = singlePrice;
            this.TotalPrice = totalPrice;
            this.Quantity = quantity;
        }

        /// <summary>
        /// Gets or sets the transaction id.     This represents the unique identifier of a Simplic.Erp.Transaction.  
        /// </summary>
        /// <value>Gets or sets the transaction id.     This represents the unique identifier of a Simplic.Erp.Transaction.  </value>
        [DataMember(Name = "transactionId", EmitDefaultValue = false)]
        public Guid TransactionId { get; set; }

        /// <summary>
        /// Gets or sets the transaction item id.     This represents the unique identifier fo a Simplic.Erp.TransactionItem.  
        /// </summary>
        /// <value>Gets or sets the transaction item id.     This represents the unique identifier fo a Simplic.Erp.TransactionItem.  </value>
        [DataMember(Name = "transactionItemId", EmitDefaultValue = false)]
        public Guid TransactionItemId { get; set; }

        /// <summary>
        /// Gets or sets the transaction number.     This represents the number of a transaction, which is a human readable number to represent the transaction.  
        /// </summary>
        /// <value>Gets or sets the transaction number.     This represents the number of a transaction, which is a human readable number to represent the transaction.  </value>
        [DataMember(Name = "number", EmitDefaultValue = true)]
        public string Number { get; set; }

        /// <summary>
        /// Gets or sets the type name.     Represents the name of the type of the transaction.  
        /// </summary>
        /// <value>Gets or sets the type name.     Represents the name of the type of the transaction.  </value>
        [DataMember(Name = "typeName", EmitDefaultValue = true)]
        public string TypeName { get; set; }

        /// <summary>
        /// Gets or sets the subtype name.     Represents the name of the subtype of the transaction.  
        /// </summary>
        /// <value>Gets or sets the subtype name.     Represents the name of the subtype of the transaction.  </value>
        [DataMember(Name = "subtypeName", EmitDefaultValue = true)]
        public string SubtypeName { get; set; }

        /// <summary>
        /// Gets or sets the create date time.     Represents the create date and time of the transaction.  
        /// </summary>
        /// <value>Gets or sets the create date time.     Represents the create date and time of the transaction.  </value>
        [DataMember(Name = "createDateTime", EmitDefaultValue = false)]
        public DateTime CreateDateTime { get; set; }

        /// <summary>
        /// Gets or sets the single price.     Represents the single price of the transaction item.  
        /// </summary>
        /// <value>Gets or sets the single price.     Represents the single price of the transaction item.  </value>
        [DataMember(Name = "singlePrice", EmitDefaultValue = false)]
        public double SinglePrice { get; set; }

        /// <summary>
        /// Gets or sets the total price.     Represents the total price of a transaction item.  
        /// </summary>
        /// <value>Gets or sets the total price.     Represents the total price of a transaction item.  </value>
        [DataMember(Name = "totalPrice", EmitDefaultValue = false)]
        public double TotalPrice { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public QuantityModel Quantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BillingLineTransationItemModel {\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  TransactionItemId: ").Append(TransactionItemId).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  TypeName: ").Append(TypeName).Append("\n");
            sb.Append("  SubtypeName: ").Append(SubtypeName).Append("\n");
            sb.Append("  CreateDateTime: ").Append(CreateDateTime).Append("\n");
            sb.Append("  SinglePrice: ").Append(SinglePrice).Append("\n");
            sb.Append("  TotalPrice: ").Append(TotalPrice).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
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
            return this.Equals(input as BillingLineTransationItemModel);
        }

        /// <summary>
        /// Returns true if BillingLineTransationItemModel instances are equal
        /// </summary>
        /// <param name="input">Instance of BillingLineTransationItemModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingLineTransationItemModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
                ) && 
                (
                    this.TransactionItemId == input.TransactionItemId ||
                    (this.TransactionItemId != null &&
                    this.TransactionItemId.Equals(input.TransactionItemId))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.TypeName == input.TypeName ||
                    (this.TypeName != null &&
                    this.TypeName.Equals(input.TypeName))
                ) && 
                (
                    this.SubtypeName == input.SubtypeName ||
                    (this.SubtypeName != null &&
                    this.SubtypeName.Equals(input.SubtypeName))
                ) && 
                (
                    this.CreateDateTime == input.CreateDateTime ||
                    (this.CreateDateTime != null &&
                    this.CreateDateTime.Equals(input.CreateDateTime))
                ) && 
                (
                    this.SinglePrice == input.SinglePrice ||
                    this.SinglePrice.Equals(input.SinglePrice)
                ) && 
                (
                    this.TotalPrice == input.TotalPrice ||
                    this.TotalPrice.Equals(input.TotalPrice)
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
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
                if (this.TransactionId != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionId.GetHashCode();
                }
                if (this.TransactionItemId != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionItemId.GetHashCode();
                }
                if (this.Number != null)
                {
                    hashCode = (hashCode * 59) + this.Number.GetHashCode();
                }
                if (this.TypeName != null)
                {
                    hashCode = (hashCode * 59) + this.TypeName.GetHashCode();
                }
                if (this.SubtypeName != null)
                {
                    hashCode = (hashCode * 59) + this.SubtypeName.GetHashCode();
                }
                if (this.CreateDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.CreateDateTime.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SinglePrice.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalPrice.GetHashCode();
                if (this.Quantity != null)
                {
                    hashCode = (hashCode * 59) + this.Quantity.GetHashCode();
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
