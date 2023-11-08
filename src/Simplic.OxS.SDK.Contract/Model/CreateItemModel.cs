/*
 * Simplic.OxS.Contract
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

namespace Simplic.OxS.SDK.Contract
{
    /// <summary>
    /// CreateItemModel
    /// </summary>
    [DataContract(Name = "CreateItemModel")]
    public partial class CreateItemModel : IEquatable<CreateItemModel>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets BillingType
        /// </summary>
        [DataMember(Name = "billingType", EmitDefaultValue = false)]
        public BillingType? BillingType { get; set; }

        /// <summary>
        /// Gets or Sets AlternativeType
        /// </summary>
        [DataMember(Name = "alternativeType", EmitDefaultValue = false)]
        public AlternativeTypeModel? AlternativeType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateItemModel" /> class.
        /// </summary>
        /// <param name="text">text.</param>
        /// <param name="index">index.</param>
        /// <param name="positionNumber">positionNumber.</param>
        /// <param name="referenceNumber">referenceNumber.</param>
        /// <param name="supplierReferenceNumber">supplierReferenceNumber.</param>
        /// <param name="billingType">billingType.</param>
        /// <param name="articleId">articleId.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="plannedQuantity">plannedQuantity.</param>
        /// <param name="costs">costs.</param>
        /// <param name="distance">distance.</param>
        /// <param name="tollDistance">tollDistance.</param>
        /// <param name="vehicleType">vehicleType.</param>
        /// <param name="cashDiscount">cashDiscount.</param>
        /// <param name="alternativeType">alternativeType.</param>
        /// <param name="parentItem">parentItem.</param>
        /// <param name="printToReporting">printToReporting.</param>
        /// <param name="useInDisposition">useInDisposition.</param>
        /// <param name="type">type.</param>
        /// <param name="supplierContactId">supplierContactId.</param>
        /// <param name="loadingAddressId">loadingAddressId.</param>
        /// <param name="unloadingAddressId">unloadingAddressId.</param>
        public CreateItemModel(string text = default(string), int index = default(int), int positionNumber = default(int), string referenceNumber = default(string), string supplierReferenceNumber = default(string), BillingType? billingType = default(BillingType?), Guid? articleId = default(Guid?), QuantityModel quantity = default(QuantityModel), QuantityModel plannedQuantity = default(QuantityModel), List<CostObjectModel> costs = default(List<CostObjectModel>), double distance = default(double), double tollDistance = default(double), VehicleTypeModel vehicleType = default(VehicleTypeModel), bool cashDiscount = default(bool), AlternativeTypeModel? alternativeType = default(AlternativeTypeModel?), Guid? parentItem = default(Guid?), bool printToReporting = default(bool), bool useInDisposition = default(bool), string type = default(string), Guid? supplierContactId = default(Guid?), Guid? loadingAddressId = default(Guid?), Guid? unloadingAddressId = default(Guid?))
        {
            this.Text = text;
            this.Index = index;
            this.PositionNumber = positionNumber;
            this.ReferenceNumber = referenceNumber;
            this.SupplierReferenceNumber = supplierReferenceNumber;
            this.BillingType = billingType;
            this.ArticleId = articleId;
            this.Quantity = quantity;
            this.PlannedQuantity = plannedQuantity;
            this.Costs = costs;
            this.Distance = distance;
            this.TollDistance = tollDistance;
            this.VehicleType = vehicleType;
            this.CashDiscount = cashDiscount;
            this.AlternativeType = alternativeType;
            this.ParentItem = parentItem;
            this.PrintToReporting = printToReporting;
            this.UseInDisposition = useInDisposition;
            this.Type = type;
            this.SupplierContactId = supplierContactId;
            this.LoadingAddressId = loadingAddressId;
            this.UnloadingAddressId = unloadingAddressId;
        }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name = "text", EmitDefaultValue = true)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets Index
        /// </summary>
        [DataMember(Name = "index", EmitDefaultValue = false)]
        public int Index { get; set; }

        /// <summary>
        /// Gets or Sets PositionNumber
        /// </summary>
        [DataMember(Name = "positionNumber", EmitDefaultValue = false)]
        public int PositionNumber { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceNumber
        /// </summary>
        [DataMember(Name = "referenceNumber", EmitDefaultValue = true)]
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// Gets or Sets SupplierReferenceNumber
        /// </summary>
        [DataMember(Name = "supplierReferenceNumber", EmitDefaultValue = true)]
        public string SupplierReferenceNumber { get; set; }

        /// <summary>
        /// Gets or Sets ArticleId
        /// </summary>
        [DataMember(Name = "articleId", EmitDefaultValue = true)]
        public Guid? ArticleId { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public QuantityModel Quantity { get; set; }

        /// <summary>
        /// Gets or Sets PlannedQuantity
        /// </summary>
        [DataMember(Name = "plannedQuantity", EmitDefaultValue = false)]
        public QuantityModel PlannedQuantity { get; set; }

        /// <summary>
        /// Gets or Sets Costs
        /// </summary>
        [DataMember(Name = "costs", EmitDefaultValue = true)]
        public List<CostObjectModel> Costs { get; set; }

        /// <summary>
        /// Gets or Sets Distance
        /// </summary>
        [DataMember(Name = "distance", EmitDefaultValue = false)]
        public double Distance { get; set; }

        /// <summary>
        /// Gets or Sets TollDistance
        /// </summary>
        [DataMember(Name = "tollDistance", EmitDefaultValue = false)]
        public double TollDistance { get; set; }

        /// <summary>
        /// Gets or Sets VehicleType
        /// </summary>
        [DataMember(Name = "vehicleType", EmitDefaultValue = false)]
        public VehicleTypeModel VehicleType { get; set; }

        /// <summary>
        /// Gets or Sets CashDiscount
        /// </summary>
        [DataMember(Name = "cashDiscount", EmitDefaultValue = true)]
        public bool CashDiscount { get; set; }

        /// <summary>
        /// Gets or Sets ParentItem
        /// </summary>
        [DataMember(Name = "parentItem", EmitDefaultValue = true)]
        public Guid? ParentItem { get; set; }

        /// <summary>
        /// Gets or Sets PrintToReporting
        /// </summary>
        [DataMember(Name = "printToReporting", EmitDefaultValue = true)]
        public bool PrintToReporting { get; set; }

        /// <summary>
        /// Gets or Sets UseInDisposition
        /// </summary>
        [DataMember(Name = "useInDisposition", EmitDefaultValue = true)]
        public bool UseInDisposition { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets SupplierContactId
        /// </summary>
        [DataMember(Name = "supplierContactId", EmitDefaultValue = true)]
        public Guid? SupplierContactId { get; set; }

        /// <summary>
        /// Gets or Sets LoadingAddressId
        /// </summary>
        [DataMember(Name = "loadingAddressId", EmitDefaultValue = true)]
        public Guid? LoadingAddressId { get; set; }

        /// <summary>
        /// Gets or Sets UnloadingAddressId
        /// </summary>
        [DataMember(Name = "unloadingAddressId", EmitDefaultValue = true)]
        public Guid? UnloadingAddressId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateItemModel {\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  PositionNumber: ").Append(PositionNumber).Append("\n");
            sb.Append("  ReferenceNumber: ").Append(ReferenceNumber).Append("\n");
            sb.Append("  SupplierReferenceNumber: ").Append(SupplierReferenceNumber).Append("\n");
            sb.Append("  BillingType: ").Append(BillingType).Append("\n");
            sb.Append("  ArticleId: ").Append(ArticleId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  PlannedQuantity: ").Append(PlannedQuantity).Append("\n");
            sb.Append("  Costs: ").Append(Costs).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  TollDistance: ").Append(TollDistance).Append("\n");
            sb.Append("  VehicleType: ").Append(VehicleType).Append("\n");
            sb.Append("  CashDiscount: ").Append(CashDiscount).Append("\n");
            sb.Append("  AlternativeType: ").Append(AlternativeType).Append("\n");
            sb.Append("  ParentItem: ").Append(ParentItem).Append("\n");
            sb.Append("  PrintToReporting: ").Append(PrintToReporting).Append("\n");
            sb.Append("  UseInDisposition: ").Append(UseInDisposition).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SupplierContactId: ").Append(SupplierContactId).Append("\n");
            sb.Append("  LoadingAddressId: ").Append(LoadingAddressId).Append("\n");
            sb.Append("  UnloadingAddressId: ").Append(UnloadingAddressId).Append("\n");
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
            return this.Equals(input as CreateItemModel);
        }

        /// <summary>
        /// Returns true if CreateItemModel instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateItemModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateItemModel input)
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
                    this.Index == input.Index ||
                    this.Index.Equals(input.Index)
                ) && 
                (
                    this.PositionNumber == input.PositionNumber ||
                    this.PositionNumber.Equals(input.PositionNumber)
                ) && 
                (
                    this.ReferenceNumber == input.ReferenceNumber ||
                    (this.ReferenceNumber != null &&
                    this.ReferenceNumber.Equals(input.ReferenceNumber))
                ) && 
                (
                    this.SupplierReferenceNumber == input.SupplierReferenceNumber ||
                    (this.SupplierReferenceNumber != null &&
                    this.SupplierReferenceNumber.Equals(input.SupplierReferenceNumber))
                ) && 
                (
                    this.BillingType == input.BillingType ||
                    this.BillingType.Equals(input.BillingType)
                ) && 
                (
                    this.ArticleId == input.ArticleId ||
                    (this.ArticleId != null &&
                    this.ArticleId.Equals(input.ArticleId))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.PlannedQuantity == input.PlannedQuantity ||
                    (this.PlannedQuantity != null &&
                    this.PlannedQuantity.Equals(input.PlannedQuantity))
                ) && 
                (
                    this.Costs == input.Costs ||
                    this.Costs != null &&
                    input.Costs != null &&
                    this.Costs.SequenceEqual(input.Costs)
                ) && 
                (
                    this.Distance == input.Distance ||
                    this.Distance.Equals(input.Distance)
                ) && 
                (
                    this.TollDistance == input.TollDistance ||
                    this.TollDistance.Equals(input.TollDistance)
                ) && 
                (
                    this.VehicleType == input.VehicleType ||
                    (this.VehicleType != null &&
                    this.VehicleType.Equals(input.VehicleType))
                ) && 
                (
                    this.CashDiscount == input.CashDiscount ||
                    this.CashDiscount.Equals(input.CashDiscount)
                ) && 
                (
                    this.AlternativeType == input.AlternativeType ||
                    this.AlternativeType.Equals(input.AlternativeType)
                ) && 
                (
                    this.ParentItem == input.ParentItem ||
                    (this.ParentItem != null &&
                    this.ParentItem.Equals(input.ParentItem))
                ) && 
                (
                    this.PrintToReporting == input.PrintToReporting ||
                    this.PrintToReporting.Equals(input.PrintToReporting)
                ) && 
                (
                    this.UseInDisposition == input.UseInDisposition ||
                    this.UseInDisposition.Equals(input.UseInDisposition)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.SupplierContactId == input.SupplierContactId ||
                    (this.SupplierContactId != null &&
                    this.SupplierContactId.Equals(input.SupplierContactId))
                ) && 
                (
                    this.LoadingAddressId == input.LoadingAddressId ||
                    (this.LoadingAddressId != null &&
                    this.LoadingAddressId.Equals(input.LoadingAddressId))
                ) && 
                (
                    this.UnloadingAddressId == input.UnloadingAddressId ||
                    (this.UnloadingAddressId != null &&
                    this.UnloadingAddressId.Equals(input.UnloadingAddressId))
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
                hashCode = (hashCode * 59) + this.Index.GetHashCode();
                hashCode = (hashCode * 59) + this.PositionNumber.GetHashCode();
                if (this.ReferenceNumber != null)
                {
                    hashCode = (hashCode * 59) + this.ReferenceNumber.GetHashCode();
                }
                if (this.SupplierReferenceNumber != null)
                {
                    hashCode = (hashCode * 59) + this.SupplierReferenceNumber.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.BillingType.GetHashCode();
                if (this.ArticleId != null)
                {
                    hashCode = (hashCode * 59) + this.ArticleId.GetHashCode();
                }
                if (this.Quantity != null)
                {
                    hashCode = (hashCode * 59) + this.Quantity.GetHashCode();
                }
                if (this.PlannedQuantity != null)
                {
                    hashCode = (hashCode * 59) + this.PlannedQuantity.GetHashCode();
                }
                if (this.Costs != null)
                {
                    hashCode = (hashCode * 59) + this.Costs.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Distance.GetHashCode();
                hashCode = (hashCode * 59) + this.TollDistance.GetHashCode();
                if (this.VehicleType != null)
                {
                    hashCode = (hashCode * 59) + this.VehicleType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CashDiscount.GetHashCode();
                hashCode = (hashCode * 59) + this.AlternativeType.GetHashCode();
                if (this.ParentItem != null)
                {
                    hashCode = (hashCode * 59) + this.ParentItem.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PrintToReporting.GetHashCode();
                hashCode = (hashCode * 59) + this.UseInDisposition.GetHashCode();
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.SupplierContactId != null)
                {
                    hashCode = (hashCode * 59) + this.SupplierContactId.GetHashCode();
                }
                if (this.LoadingAddressId != null)
                {
                    hashCode = (hashCode * 59) + this.LoadingAddressId.GetHashCode();
                }
                if (this.UnloadingAddressId != null)
                {
                    hashCode = (hashCode * 59) + this.UnloadingAddressId.GetHashCode();
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
