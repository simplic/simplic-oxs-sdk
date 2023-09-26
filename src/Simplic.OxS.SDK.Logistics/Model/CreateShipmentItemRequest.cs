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
    /// Shared model of shipment item.
    /// </summary>
    [DataContract(Name = "CreateShipmentItemRequest")]
    public partial class CreateShipmentItemRequest : IEquatable<CreateShipmentItemRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateShipmentItemRequest" /> class.
        /// </summary>
        /// <param name="text">Gets or sets the text.  &lt;br&gt;  The text is a field for the user to give more context to the shipment item and the billing.  .</param>
        /// <param name="loadingMeters">Gets or sets the loading meters.  &lt;br&gt;  Loading meters define how many space a packed object will use on a trailer.  .</param>
        /// <param name="reference">Gets or sets the external reference..</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="weight">weight.</param>
        /// <param name="billingLines">Gets or sets the billing lines.  &lt;br&gt;  Billing lines determine which persons can be billed which amounts.  .</param>
        /// <param name="article">article.</param>
        /// <param name="weightNotes">Gets or sets the weight notes.  &lt;br&gt;  Weight notes are used to get the real amount of the driven freight.  .</param>
        /// <param name="status">status.</param>
        /// <param name="loadigAidId">Gets or sets the id of the loading aid..</param>
        public CreateShipmentItemRequest(string text = default(string), double loadingMeters = default(double), string reference = default(string), QuantityModel quantity = default(QuantityModel), QuantityModel weight = default(QuantityModel), List<BillingLineModel> billingLines = default(List<BillingLineModel>), ShipmentArticleModel article = default(ShipmentArticleModel), List<WeightNoteModel> weightNotes = default(List<WeightNoteModel>), ShipmentItemStatusModel status = default(ShipmentItemStatusModel), Guid? loadigAidId = default(Guid?))
        {
            this.Text = text;
            this.LoadingMeters = loadingMeters;
            this.Reference = reference;
            this.Quantity = quantity;
            this.Weight = weight;
            this.BillingLines = billingLines;
            this.Article = article;
            this.WeightNotes = weightNotes;
            this.Status = status;
            this.LoadigAidId = loadigAidId;
        }

        /// <summary>
        /// Gets or sets the text.  &lt;br&gt;  The text is a field for the user to give more context to the shipment item and the billing.  
        /// </summary>
        /// <value>Gets or sets the text.  &lt;br&gt;  The text is a field for the user to give more context to the shipment item and the billing.  </value>
        [DataMember(Name = "text", EmitDefaultValue = true)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the loading meters.  &lt;br&gt;  Loading meters define how many space a packed object will use on a trailer.  
        /// </summary>
        /// <value>Gets or sets the loading meters.  &lt;br&gt;  Loading meters define how many space a packed object will use on a trailer.  </value>
        [DataMember(Name = "loadingMeters", EmitDefaultValue = false)]
        public double LoadingMeters { get; set; }

        /// <summary>
        /// Gets or sets the external reference.
        /// </summary>
        /// <value>Gets or sets the external reference.</value>
        [DataMember(Name = "reference", EmitDefaultValue = true)]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public QuantityModel Quantity { get; set; }

        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        [DataMember(Name = "weight", EmitDefaultValue = false)]
        public QuantityModel Weight { get; set; }

        /// <summary>
        /// Gets or sets the billing lines.  &lt;br&gt;  Billing lines determine which persons can be billed which amounts.  
        /// </summary>
        /// <value>Gets or sets the billing lines.  &lt;br&gt;  Billing lines determine which persons can be billed which amounts.  </value>
        [DataMember(Name = "billingLines", EmitDefaultValue = true)]
        public List<BillingLineModel> BillingLines { get; set; }

        /// <summary>
        /// Gets or Sets Article
        /// </summary>
        [DataMember(Name = "article", EmitDefaultValue = false)]
        public ShipmentArticleModel Article { get; set; }

        /// <summary>
        /// Gets or sets the weight notes.  &lt;br&gt;  Weight notes are used to get the real amount of the driven freight.  
        /// </summary>
        /// <value>Gets or sets the weight notes.  &lt;br&gt;  Weight notes are used to get the real amount of the driven freight.  </value>
        [DataMember(Name = "weightNotes", EmitDefaultValue = true)]
        public List<WeightNoteModel> WeightNotes { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public ShipmentItemStatusModel Status { get; set; }

        /// <summary>
        /// Gets or sets the id of the loading aid.
        /// </summary>
        /// <value>Gets or sets the id of the loading aid.</value>
        [DataMember(Name = "loadigAidId", EmitDefaultValue = true)]
        public Guid? LoadigAidId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateShipmentItemRequest {\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  LoadingMeters: ").Append(LoadingMeters).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  BillingLines: ").Append(BillingLines).Append("\n");
            sb.Append("  Article: ").Append(Article).Append("\n");
            sb.Append("  WeightNotes: ").Append(WeightNotes).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  LoadigAidId: ").Append(LoadigAidId).Append("\n");
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
            return this.Equals(input as CreateShipmentItemRequest);
        }

        /// <summary>
        /// Returns true if CreateShipmentItemRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateShipmentItemRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateShipmentItemRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.LoadingMeters == input.LoadingMeters ||
                    this.LoadingMeters.Equals(input.LoadingMeters)
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.Weight == input.Weight ||
                    (this.Weight != null &&
                    this.Weight.Equals(input.Weight))
                ) && 
                (
                    this.BillingLines == input.BillingLines ||
                    this.BillingLines != null &&
                    input.BillingLines != null &&
                    this.BillingLines.SequenceEqual(input.BillingLines)
                ) && 
                (
                    this.Article == input.Article ||
                    (this.Article != null &&
                    this.Article.Equals(input.Article))
                ) && 
                (
                    this.WeightNotes == input.WeightNotes ||
                    this.WeightNotes != null &&
                    input.WeightNotes != null &&
                    this.WeightNotes.SequenceEqual(input.WeightNotes)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.LoadigAidId == input.LoadigAidId ||
                    (this.LoadigAidId != null &&
                    this.LoadigAidId.Equals(input.LoadigAidId))
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
                if (this.Text != null)
                {
                    hashCode = (hashCode * 59) + this.Text.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LoadingMeters.GetHashCode();
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                if (this.Quantity != null)
                {
                    hashCode = (hashCode * 59) + this.Quantity.GetHashCode();
                }
                if (this.Weight != null)
                {
                    hashCode = (hashCode * 59) + this.Weight.GetHashCode();
                }
                if (this.BillingLines != null)
                {
                    hashCode = (hashCode * 59) + this.BillingLines.GetHashCode();
                }
                if (this.Article != null)
                {
                    hashCode = (hashCode * 59) + this.Article.GetHashCode();
                }
                if (this.WeightNotes != null)
                {
                    hashCode = (hashCode * 59) + this.WeightNotes.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.LoadigAidId != null)
                {
                    hashCode = (hashCode * 59) + this.LoadigAidId.GetHashCode();
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
