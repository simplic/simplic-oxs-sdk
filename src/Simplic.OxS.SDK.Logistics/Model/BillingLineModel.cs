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
using OpenAPIDateConverter = Simplic.OxS.SDK.Client.OpenAPIDateConverter;

namespace Simplic.OxS.SDK.Logistics.Model
{
    /// <summary>
    /// Shared model of billing line.
    /// </summary>
    [DataContract(Name = "BillingLineModel")]
    public partial class BillingLineModel : IEquatable<BillingLineModel>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public BillingLineType? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingLineModel" /> class.
        /// </summary>
        /// <param name="id">Gets or sets the id.  &lt;br&gt;  Represents the unique identifier of a billing line.  .</param>
        /// <param name="type">type.</param>
        /// <param name="billableContact">billableContact.</param>
        /// <param name="pricing">pricing.</param>
        /// <param name="status">status.</param>
        /// <param name="singlePrice">Gets or sets the single price.  &lt;br&gt;  Represents the price of a single item.  .</param>
        /// <param name="totalPrice">Gets or sets the total price.  &lt;br&gt;  Represents the price of all items.  .</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="transactionItems">Gets or sets the transaction items where the billing line is present in.  &lt;br&gt;  The list will be filled during the billing process.  .</param>
        /// <param name="article">article.</param>
        /// <param name="weightNoteId">Gets or sets the weight note id that will be billed.</param>
        /// <param name="reference">Gets or sets the external reference..</param>
        public BillingLineModel(Guid id = default(Guid), BillingLineType? type = default(BillingLineType?), BillableContactModel billableContact = default(BillableContactModel), BillingLinePricingModel pricing = default(BillingLinePricingModel), BillingLineStatusModel status = default(BillingLineStatusModel), double singlePrice = default(double), double totalPrice = default(double), QuantityModel quantity = default(QuantityModel), List<BillingLineTransationItemModel> transactionItems = default(List<BillingLineTransationItemModel>), ShipmentArticleModel article = default(ShipmentArticleModel), Guid? weightNoteId = default(Guid?), string reference = default(string))
        {
            this.Id = id;
            this.Type = type;
            this.BillableContact = billableContact;
            this.Pricing = pricing;
            this.Status = status;
            this.SinglePrice = singlePrice;
            this.TotalPrice = totalPrice;
            this.Quantity = quantity;
            this.TransactionItems = transactionItems;
            this.Article = article;
            this.WeightNoteId = weightNoteId;
            this.Reference = reference;
        }

        /// <summary>
        /// Gets or sets the id.  &lt;br&gt;  Represents the unique identifier of a billing line.  
        /// </summary>
        /// <value>Gets or sets the id.  &lt;br&gt;  Represents the unique identifier of a billing line.  </value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets BillableContact
        /// </summary>
        [DataMember(Name = "billableContact", EmitDefaultValue = false)]
        public BillableContactModel BillableContact { get; set; }

        /// <summary>
        /// Gets or Sets Pricing
        /// </summary>
        [DataMember(Name = "pricing", EmitDefaultValue = false)]
        public BillingLinePricingModel Pricing { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public BillingLineStatusModel Status { get; set; }

        /// <summary>
        /// Gets or sets the single price.  &lt;br&gt;  Represents the price of a single item.  
        /// </summary>
        /// <value>Gets or sets the single price.  &lt;br&gt;  Represents the price of a single item.  </value>
        [DataMember(Name = "singlePrice", EmitDefaultValue = false)]
        public double SinglePrice { get; set; }

        /// <summary>
        /// Gets or sets the total price.  &lt;br&gt;  Represents the price of all items.  
        /// </summary>
        /// <value>Gets or sets the total price.  &lt;br&gt;  Represents the price of all items.  </value>
        [DataMember(Name = "totalPrice", EmitDefaultValue = false)]
        public double TotalPrice { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public QuantityModel Quantity { get; set; }

        /// <summary>
        /// Gets or sets the transaction items where the billing line is present in.  &lt;br&gt;  The list will be filled during the billing process.  
        /// </summary>
        /// <value>Gets or sets the transaction items where the billing line is present in.  &lt;br&gt;  The list will be filled during the billing process.  </value>
        [DataMember(Name = "transactionItems", EmitDefaultValue = true)]
        public List<BillingLineTransationItemModel> TransactionItems { get; set; }

        /// <summary>
        /// Gets or Sets Article
        /// </summary>
        [DataMember(Name = "article", EmitDefaultValue = false)]
        public ShipmentArticleModel Article { get; set; }

        /// <summary>
        /// Gets or sets the weight note id that will be billed
        /// </summary>
        /// <value>Gets or sets the weight note id that will be billed</value>
        [DataMember(Name = "weightNoteId", EmitDefaultValue = true)]
        public Guid? WeightNoteId { get; set; }

        /// <summary>
        /// Gets or sets the external reference.
        /// </summary>
        /// <value>Gets or sets the external reference.</value>
        [DataMember(Name = "reference", EmitDefaultValue = true)]
        public string Reference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BillingLineModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  BillableContact: ").Append(BillableContact).Append("\n");
            sb.Append("  Pricing: ").Append(Pricing).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SinglePrice: ").Append(SinglePrice).Append("\n");
            sb.Append("  TotalPrice: ").Append(TotalPrice).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  TransactionItems: ").Append(TransactionItems).Append("\n");
            sb.Append("  Article: ").Append(Article).Append("\n");
            sb.Append("  WeightNoteId: ").Append(WeightNoteId).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
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
            return this.Equals(input as BillingLineModel);
        }

        /// <summary>
        /// Returns true if BillingLineModel instances are equal
        /// </summary>
        /// <param name="input">Instance of BillingLineModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingLineModel input)
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
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.BillableContact == input.BillableContact ||
                    (this.BillableContact != null &&
                    this.BillableContact.Equals(input.BillableContact))
                ) && 
                (
                    this.Pricing == input.Pricing ||
                    (this.Pricing != null &&
                    this.Pricing.Equals(input.Pricing))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                ) && 
                (
                    this.TransactionItems == input.TransactionItems ||
                    this.TransactionItems != null &&
                    input.TransactionItems != null &&
                    this.TransactionItems.SequenceEqual(input.TransactionItems)
                ) && 
                (
                    this.Article == input.Article ||
                    (this.Article != null &&
                    this.Article.Equals(input.Article))
                ) && 
                (
                    this.WeightNoteId == input.WeightNoteId ||
                    (this.WeightNoteId != null &&
                    this.WeightNoteId.Equals(input.WeightNoteId))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.BillableContact != null)
                {
                    hashCode = (hashCode * 59) + this.BillableContact.GetHashCode();
                }
                if (this.Pricing != null)
                {
                    hashCode = (hashCode * 59) + this.Pricing.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SinglePrice.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalPrice.GetHashCode();
                if (this.Quantity != null)
                {
                    hashCode = (hashCode * 59) + this.Quantity.GetHashCode();
                }
                if (this.TransactionItems != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionItems.GetHashCode();
                }
                if (this.Article != null)
                {
                    hashCode = (hashCode * 59) + this.Article.GetHashCode();
                }
                if (this.WeightNoteId != null)
                {
                    hashCode = (hashCode * 59) + this.WeightNoteId.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
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
