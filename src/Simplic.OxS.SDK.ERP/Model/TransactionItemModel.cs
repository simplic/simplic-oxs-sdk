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
    /// Represents the shared model for a transaction item.
    /// </summary>
    [DataContract(Name = "TransactionItemModel")]
    public partial class TransactionItemModel : IEquatable<TransactionItemModel>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ValueOperator
        /// </summary>
        [DataMember(Name = "valueOperator", EmitDefaultValue = false)]
        public ModelValueOperator? ValueOperator { get; set; }

        /// <summary>
        /// Gets or Sets AssignmentMode
        /// </summary>
        [DataMember(Name = "assignmentMode", EmitDefaultValue = false)]
        public ModelAssignmentMode? AssignmentMode { get; set; }

        /// <summary>
        /// Gets or Sets InputPriceType
        /// </summary>
        [DataMember(Name = "inputPriceType", EmitDefaultValue = false)]
        public InputPriceType? InputPriceType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionItemModel" /> class.
        /// </summary>
        /// <param name="id">Gets or sets the ID..</param>
        /// <param name="text">Gets or sets the text..</param>
        /// <param name="type">type.</param>
        /// <param name="bookedFromTransactionId">Gets or sets the transaction this item has been booked from by ID..</param>
        /// <param name="transactionItemCollectionId">Gets or sets the Simplic.OxS.ERP.TransactionItemCollection.TransactionItemCollection this transaction item is part of by ID..</param>
        /// <param name="sortNumber">Gets or sets the sort number..</param>
        /// <param name="deserializationType">Gets or sets an identifier for the type of the item for correct deserialization..</param>
        /// <param name="assignedTransactionItems">assignedTransactionItems.</param>
        /// <param name="valueOperator">valueOperator.</param>
        /// <param name="assignmentMode">assignmentMode.</param>
        /// <param name="amount">Gets the amount the operation item results in.  &lt;br&gt;  The amount can be positive or negative representing a surcharge or a discount.  .</param>
        /// <param name="behaviorDefinitions">Gets or sets a set of Simplic.OxS.ERP.Server.BehaviorDefinitionModel.</param>
        /// <param name="originalOperationItem">originalOperationItem.</param>
        /// <param name="inputPrice">Gets or sets the price user input..</param>
        /// <param name="inputPriceType">inputPriceType.</param>
        /// <param name="singlePrice">Gets or sets the resulting single price..</param>
        /// <param name="totalPrice">Gets or sets the resulting total price..</param>
        /// <param name="singlePriceNet">Gets or sets the resulting net single price..</param>
        /// <param name="totalPriceNet">Gets or sets the resulting net total price..</param>
        /// <param name="singlePriceGross">Gets or sets the gross single price..</param>
        /// <param name="totalPriceGross">Gets or sets the gross total price..</param>
        /// <param name="singlePriceVat">Gets or sets the VAT contained in the net single price..</param>
        /// <param name="totalPriceVat">Gets or sets the VAT contained in the net total price..</param>
        /// <param name="pricing">Gets or sets a set of Simplic.OxS.ERP.Server.TransactionPriceObjectModel representing the price development history.  &lt;br&gt;  Each tuple represents the transaction item pricing data resulting from a specific operation. The list contains the tuples in the order these operation are applied in.  .</param>
        /// <param name="quantity">Gets or sets the quantity..</param>
        /// <param name="unit">unit.</param>
        /// <param name="articleId">Gets or sets the article by ID..</param>
        /// <param name="deltaValue">Gets or sets the discount/surcharge value as an absolute price value or a percentage value depending on the value operator..</param>
        /// <param name="items">Gets or sets a set of transaction items that are part of the group..</param>
        public TransactionItemModel(Guid id = default(Guid), string text = default(string), TransactionItemTypeModel type = default(TransactionItemTypeModel), Guid? bookedFromTransactionId = default(Guid?), Guid? transactionItemCollectionId = default(Guid?), int sortNumber = default(int), string deserializationType = default(string), List<TransactionItemModel> assignedTransactionItems = default(List<TransactionItemModel>), ModelValueOperator? valueOperator = default(ModelValueOperator?), ModelAssignmentMode? assignmentMode = default(ModelAssignmentMode?), double? amount = default(double?), List<BehaviorDefinitionModel> behaviorDefinitions = default(List<BehaviorDefinitionModel>), TransactionItemModel originalOperationItem = default(TransactionItemModel), double? inputPrice = default(double?), InputPriceType? inputPriceType = default(InputPriceType?), double? singlePrice = default(double?), double? totalPrice = default(double?), double? singlePriceNet = default(double?), double? totalPriceNet = default(double?), double? singlePriceGross = default(double?), double? totalPriceGross = default(double?), double? singlePriceVat = default(double?), double? totalPriceVat = default(double?), List<StringTransactionPriceObjectModelKeyValuePair> pricing = default(List<StringTransactionPriceObjectModelKeyValuePair>), double? quantity = default(double?), QuantityUnitModel unit = default(QuantityUnitModel), Guid? articleId = default(Guid?), double? deltaValue = default(double?), List<TransactionItemModel> items = default(List<TransactionItemModel>))
        {
            this.Id = id;
            this.Text = text;
            this.Type = type;
            this.BookedFromTransactionId = bookedFromTransactionId;
            this.TransactionItemCollectionId = transactionItemCollectionId;
            this.SortNumber = sortNumber;
            this.DeserializationType = deserializationType;
            this.AssignedTransactionItems = assignedTransactionItems;
            this.ValueOperator = valueOperator;
            this.AssignmentMode = assignmentMode;
            this.Amount = amount;
            this.BehaviorDefinitions = behaviorDefinitions;
            this.OriginalOperationItem = originalOperationItem;
            this.InputPrice = inputPrice;
            this.InputPriceType = inputPriceType;
            this.SinglePrice = singlePrice;
            this.TotalPrice = totalPrice;
            this.SinglePriceNet = singlePriceNet;
            this.TotalPriceNet = totalPriceNet;
            this.SinglePriceGross = singlePriceGross;
            this.TotalPriceGross = totalPriceGross;
            this.SinglePriceVat = singlePriceVat;
            this.TotalPriceVat = totalPriceVat;
            this.Pricing = pricing;
            this.Quantity = quantity;
            this.Unit = unit;
            this.ArticleId = articleId;
            this.DeltaValue = deltaValue;
            this.Items = items;
        }

        /// <summary>
        /// Gets or sets the ID.
        /// </summary>
        /// <value>Gets or sets the ID.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>Gets or sets the text.</value>
        [DataMember(Name = "text", EmitDefaultValue = true)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TransactionItemTypeModel Type { get; set; }

        /// <summary>
        /// Gets or sets the transaction this item has been booked from by ID.
        /// </summary>
        /// <value>Gets or sets the transaction this item has been booked from by ID.</value>
        [DataMember(Name = "bookedFromTransactionId", EmitDefaultValue = true)]
        public Guid? BookedFromTransactionId { get; set; }

        /// <summary>
        /// Gets or sets the Simplic.OxS.ERP.TransactionItemCollection.TransactionItemCollection this transaction item is part of by ID.
        /// </summary>
        /// <value>Gets or sets the Simplic.OxS.ERP.TransactionItemCollection.TransactionItemCollection this transaction item is part of by ID.</value>
        [DataMember(Name = "transactionItemCollectionId", EmitDefaultValue = true)]
        public Guid? TransactionItemCollectionId { get; set; }

        /// <summary>
        /// Gets or sets the sort number.
        /// </summary>
        /// <value>Gets or sets the sort number.</value>
        [DataMember(Name = "sortNumber", EmitDefaultValue = false)]
        public int SortNumber { get; set; }

        /// <summary>
        /// Gets or sets an identifier for the type of the item for correct deserialization.
        /// </summary>
        /// <value>Gets or sets an identifier for the type of the item for correct deserialization.</value>
        [DataMember(Name = "deserializationType", EmitDefaultValue = true)]
        public string DeserializationType { get; set; }

        /// <summary>
        /// Gets or Sets AssignedTransactionItems
        /// </summary>
        [DataMember(Name = "assignedTransactionItems", EmitDefaultValue = true)]
        public List<TransactionItemModel> AssignedTransactionItems { get; set; }

        /// <summary>
        /// Gets the amount the operation item results in.  &lt;br&gt;  The amount can be positive or negative representing a surcharge or a discount.  
        /// </summary>
        /// <value>Gets the amount the operation item results in.  &lt;br&gt;  The amount can be positive or negative representing a surcharge or a discount.  </value>
        [DataMember(Name = "amount", EmitDefaultValue = true)]
        public double? Amount { get; set; }

        /// <summary>
        /// Gets or sets a set of Simplic.OxS.ERP.Server.BehaviorDefinitionModel
        /// </summary>
        /// <value>Gets or sets a set of Simplic.OxS.ERP.Server.BehaviorDefinitionModel</value>
        [DataMember(Name = "behaviorDefinitions", EmitDefaultValue = true)]
        public List<BehaviorDefinitionModel> BehaviorDefinitions { get; set; }

        /// <summary>
        /// Gets or Sets OriginalOperationItem
        /// </summary>
        [DataMember(Name = "originalOperationItem", EmitDefaultValue = false)]
        public TransactionItemModel OriginalOperationItem { get; set; }

        /// <summary>
        /// Gets or sets the price user input.
        /// </summary>
        /// <value>Gets or sets the price user input.</value>
        [DataMember(Name = "inputPrice", EmitDefaultValue = true)]
        public double? InputPrice { get; set; }

        /// <summary>
        /// Gets or sets the resulting single price.
        /// </summary>
        /// <value>Gets or sets the resulting single price.</value>
        [DataMember(Name = "singlePrice", EmitDefaultValue = true)]
        public double? SinglePrice { get; set; }

        /// <summary>
        /// Gets or sets the resulting total price.
        /// </summary>
        /// <value>Gets or sets the resulting total price.</value>
        [DataMember(Name = "totalPrice", EmitDefaultValue = true)]
        public double? TotalPrice { get; set; }

        /// <summary>
        /// Gets or sets the resulting net single price.
        /// </summary>
        /// <value>Gets or sets the resulting net single price.</value>
        [DataMember(Name = "singlePriceNet", EmitDefaultValue = true)]
        public double? SinglePriceNet { get; set; }

        /// <summary>
        /// Gets or sets the resulting net total price.
        /// </summary>
        /// <value>Gets or sets the resulting net total price.</value>
        [DataMember(Name = "totalPriceNet", EmitDefaultValue = true)]
        public double? TotalPriceNet { get; set; }

        /// <summary>
        /// Gets or sets the gross single price.
        /// </summary>
        /// <value>Gets or sets the gross single price.</value>
        [DataMember(Name = "singlePriceGross", EmitDefaultValue = true)]
        public double? SinglePriceGross { get; set; }

        /// <summary>
        /// Gets or sets the gross total price.
        /// </summary>
        /// <value>Gets or sets the gross total price.</value>
        [DataMember(Name = "totalPriceGross", EmitDefaultValue = true)]
        public double? TotalPriceGross { get; set; }

        /// <summary>
        /// Gets or sets the VAT contained in the net single price.
        /// </summary>
        /// <value>Gets or sets the VAT contained in the net single price.</value>
        [DataMember(Name = "singlePriceVat", EmitDefaultValue = true)]
        public double? SinglePriceVat { get; set; }

        /// <summary>
        /// Gets or sets the VAT contained in the net total price.
        /// </summary>
        /// <value>Gets or sets the VAT contained in the net total price.</value>
        [DataMember(Name = "totalPriceVat", EmitDefaultValue = true)]
        public double? TotalPriceVat { get; set; }

        /// <summary>
        /// Gets or sets a set of Simplic.OxS.ERP.Server.TransactionPriceObjectModel representing the price development history.  &lt;br&gt;  Each tuple represents the transaction item pricing data resulting from a specific operation. The list contains the tuples in the order these operation are applied in.  
        /// </summary>
        /// <value>Gets or sets a set of Simplic.OxS.ERP.Server.TransactionPriceObjectModel representing the price development history.  &lt;br&gt;  Each tuple represents the transaction item pricing data resulting from a specific operation. The list contains the tuples in the order these operation are applied in.  </value>
        [DataMember(Name = "pricing", EmitDefaultValue = true)]
        public List<StringTransactionPriceObjectModelKeyValuePair> Pricing { get; set; }

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        /// <value>Gets or sets the quantity.</value>
        [DataMember(Name = "quantity", EmitDefaultValue = true)]
        public double? Quantity { get; set; }

        /// <summary>
        /// Gets or Sets Unit
        /// </summary>
        [DataMember(Name = "unit", EmitDefaultValue = false)]
        public QuantityUnitModel Unit { get; set; }

        /// <summary>
        /// Gets or sets the article by ID.
        /// </summary>
        /// <value>Gets or sets the article by ID.</value>
        [DataMember(Name = "articleId", EmitDefaultValue = true)]
        public Guid? ArticleId { get; set; }

        /// <summary>
        /// Gets or sets the discount/surcharge value as an absolute price value or a percentage value depending on the value operator.
        /// </summary>
        /// <value>Gets or sets the discount/surcharge value as an absolute price value or a percentage value depending on the value operator.</value>
        [DataMember(Name = "deltaValue", EmitDefaultValue = true)]
        public double? DeltaValue { get; set; }

        /// <summary>
        /// Gets or sets a set of transaction items that are part of the group.
        /// </summary>
        /// <value>Gets or sets a set of transaction items that are part of the group.</value>
        [DataMember(Name = "items", EmitDefaultValue = true)]
        public List<TransactionItemModel> Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionItemModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  BookedFromTransactionId: ").Append(BookedFromTransactionId).Append("\n");
            sb.Append("  TransactionItemCollectionId: ").Append(TransactionItemCollectionId).Append("\n");
            sb.Append("  SortNumber: ").Append(SortNumber).Append("\n");
            sb.Append("  DeserializationType: ").Append(DeserializationType).Append("\n");
            sb.Append("  AssignedTransactionItems: ").Append(AssignedTransactionItems).Append("\n");
            sb.Append("  ValueOperator: ").Append(ValueOperator).Append("\n");
            sb.Append("  AssignmentMode: ").Append(AssignmentMode).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  BehaviorDefinitions: ").Append(BehaviorDefinitions).Append("\n");
            sb.Append("  OriginalOperationItem: ").Append(OriginalOperationItem).Append("\n");
            sb.Append("  InputPrice: ").Append(InputPrice).Append("\n");
            sb.Append("  InputPriceType: ").Append(InputPriceType).Append("\n");
            sb.Append("  SinglePrice: ").Append(SinglePrice).Append("\n");
            sb.Append("  TotalPrice: ").Append(TotalPrice).Append("\n");
            sb.Append("  SinglePriceNet: ").Append(SinglePriceNet).Append("\n");
            sb.Append("  TotalPriceNet: ").Append(TotalPriceNet).Append("\n");
            sb.Append("  SinglePriceGross: ").Append(SinglePriceGross).Append("\n");
            sb.Append("  TotalPriceGross: ").Append(TotalPriceGross).Append("\n");
            sb.Append("  SinglePriceVat: ").Append(SinglePriceVat).Append("\n");
            sb.Append("  TotalPriceVat: ").Append(TotalPriceVat).Append("\n");
            sb.Append("  Pricing: ").Append(Pricing).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  ArticleId: ").Append(ArticleId).Append("\n");
            sb.Append("  DeltaValue: ").Append(DeltaValue).Append("\n");
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
            return this.Equals(input as TransactionItemModel);
        }

        /// <summary>
        /// Returns true if TransactionItemModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionItemModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionItemModel input)
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
                ) && 
                (
                    this.AssignedTransactionItems == input.AssignedTransactionItems ||
                    this.AssignedTransactionItems != null &&
                    input.AssignedTransactionItems != null &&
                    this.AssignedTransactionItems.SequenceEqual(input.AssignedTransactionItems)
                ) && 
                (
                    this.ValueOperator == input.ValueOperator ||
                    this.ValueOperator.Equals(input.ValueOperator)
                ) && 
                (
                    this.AssignmentMode == input.AssignmentMode ||
                    this.AssignmentMode.Equals(input.AssignmentMode)
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.BehaviorDefinitions == input.BehaviorDefinitions ||
                    this.BehaviorDefinitions != null &&
                    input.BehaviorDefinitions != null &&
                    this.BehaviorDefinitions.SequenceEqual(input.BehaviorDefinitions)
                ) && 
                (
                    this.OriginalOperationItem == input.OriginalOperationItem ||
                    (this.OriginalOperationItem != null &&
                    this.OriginalOperationItem.Equals(input.OriginalOperationItem))
                ) && 
                (
                    this.InputPrice == input.InputPrice ||
                    (this.InputPrice != null &&
                    this.InputPrice.Equals(input.InputPrice))
                ) && 
                (
                    this.InputPriceType == input.InputPriceType ||
                    this.InputPriceType.Equals(input.InputPriceType)
                ) && 
                (
                    this.SinglePrice == input.SinglePrice ||
                    (this.SinglePrice != null &&
                    this.SinglePrice.Equals(input.SinglePrice))
                ) && 
                (
                    this.TotalPrice == input.TotalPrice ||
                    (this.TotalPrice != null &&
                    this.TotalPrice.Equals(input.TotalPrice))
                ) && 
                (
                    this.SinglePriceNet == input.SinglePriceNet ||
                    (this.SinglePriceNet != null &&
                    this.SinglePriceNet.Equals(input.SinglePriceNet))
                ) && 
                (
                    this.TotalPriceNet == input.TotalPriceNet ||
                    (this.TotalPriceNet != null &&
                    this.TotalPriceNet.Equals(input.TotalPriceNet))
                ) && 
                (
                    this.SinglePriceGross == input.SinglePriceGross ||
                    (this.SinglePriceGross != null &&
                    this.SinglePriceGross.Equals(input.SinglePriceGross))
                ) && 
                (
                    this.TotalPriceGross == input.TotalPriceGross ||
                    (this.TotalPriceGross != null &&
                    this.TotalPriceGross.Equals(input.TotalPriceGross))
                ) && 
                (
                    this.SinglePriceVat == input.SinglePriceVat ||
                    (this.SinglePriceVat != null &&
                    this.SinglePriceVat.Equals(input.SinglePriceVat))
                ) && 
                (
                    this.TotalPriceVat == input.TotalPriceVat ||
                    (this.TotalPriceVat != null &&
                    this.TotalPriceVat.Equals(input.TotalPriceVat))
                ) && 
                (
                    this.Pricing == input.Pricing ||
                    this.Pricing != null &&
                    input.Pricing != null &&
                    this.Pricing.SequenceEqual(input.Pricing)
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
                ) && 
                (
                    this.ArticleId == input.ArticleId ||
                    (this.ArticleId != null &&
                    this.ArticleId.Equals(input.ArticleId))
                ) && 
                (
                    this.DeltaValue == input.DeltaValue ||
                    (this.DeltaValue != null &&
                    this.DeltaValue.Equals(input.DeltaValue))
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
                if (this.AssignedTransactionItems != null)
                {
                    hashCode = (hashCode * 59) + this.AssignedTransactionItems.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ValueOperator.GetHashCode();
                hashCode = (hashCode * 59) + this.AssignmentMode.GetHashCode();
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.BehaviorDefinitions != null)
                {
                    hashCode = (hashCode * 59) + this.BehaviorDefinitions.GetHashCode();
                }
                if (this.OriginalOperationItem != null)
                {
                    hashCode = (hashCode * 59) + this.OriginalOperationItem.GetHashCode();
                }
                if (this.InputPrice != null)
                {
                    hashCode = (hashCode * 59) + this.InputPrice.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.InputPriceType.GetHashCode();
                if (this.SinglePrice != null)
                {
                    hashCode = (hashCode * 59) + this.SinglePrice.GetHashCode();
                }
                if (this.TotalPrice != null)
                {
                    hashCode = (hashCode * 59) + this.TotalPrice.GetHashCode();
                }
                if (this.SinglePriceNet != null)
                {
                    hashCode = (hashCode * 59) + this.SinglePriceNet.GetHashCode();
                }
                if (this.TotalPriceNet != null)
                {
                    hashCode = (hashCode * 59) + this.TotalPriceNet.GetHashCode();
                }
                if (this.SinglePriceGross != null)
                {
                    hashCode = (hashCode * 59) + this.SinglePriceGross.GetHashCode();
                }
                if (this.TotalPriceGross != null)
                {
                    hashCode = (hashCode * 59) + this.TotalPriceGross.GetHashCode();
                }
                if (this.SinglePriceVat != null)
                {
                    hashCode = (hashCode * 59) + this.SinglePriceVat.GetHashCode();
                }
                if (this.TotalPriceVat != null)
                {
                    hashCode = (hashCode * 59) + this.TotalPriceVat.GetHashCode();
                }
                if (this.Pricing != null)
                {
                    hashCode = (hashCode * 59) + this.Pricing.GetHashCode();
                }
                if (this.Quantity != null)
                {
                    hashCode = (hashCode * 59) + this.Quantity.GetHashCode();
                }
                if (this.Unit != null)
                {
                    hashCode = (hashCode * 59) + this.Unit.GetHashCode();
                }
                if (this.ArticleId != null)
                {
                    hashCode = (hashCode * 59) + this.ArticleId.GetHashCode();
                }
                if (this.DeltaValue != null)
                {
                    hashCode = (hashCode * 59) + this.DeltaValue.GetHashCode();
                }
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
