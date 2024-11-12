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
    /// ContractItemModel
    /// </summary>
    [DataContract(Name = "ContractItemModel")]
    public partial class ContractItemModel : IEquatable<ContractItemModel>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="ContractItemModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="text">text.</param>
        /// <param name="index">index.</param>
        /// <param name="positionNumber">positionNumber.</param>
        /// <param name="referenceNumber">referenceNumber.</param>
        /// <param name="supplierReferenceNumber">supplierReferenceNumber.</param>
        /// <param name="billingType">billingType.</param>
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
        /// <param name="isDiscount">isDiscount.</param>
        /// <param name="contractNumber">contractNumber.</param>
        /// <param name="supplier">supplier.</param>
        /// <param name="article">article.</param>
        /// <param name="loadingAddress">loadingAddress.</param>
        /// <param name="unloadingAddress">unloadingAddress.</param>
        public ContractItemModel(Guid id = default(Guid), string text = default(string), int index = default(int), int positionNumber = default(int), string referenceNumber = default(string), string supplierReferenceNumber = default(string), BillingType? billingType = default(BillingType?), QuantityModel quantity = default(QuantityModel), QuantityModel plannedQuantity = default(QuantityModel), List<CostObjectModel> costs = default(List<CostObjectModel>), double distance = default(double), double tollDistance = default(double), VehicleTypeModel vehicleType = default(VehicleTypeModel), bool cashDiscount = default(bool), AlternativeTypeModel? alternativeType = default(AlternativeTypeModel?), Guid? parentItem = default(Guid?), bool printToReporting = default(bool), bool useInDisposition = default(bool), string type = default(string), bool? isDiscount = default(bool?), string contractNumber = default(string), Address supplier = default(Address), ArticleModel article = default(ArticleModel), Address loadingAddress = default(Address), Address unloadingAddress = default(Address))
        {
            this.Id = id;
            this.Text = text;
            this.Index = index;
            this.PositionNumber = positionNumber;
            this.ReferenceNumber = referenceNumber;
            this.SupplierReferenceNumber = supplierReferenceNumber;
            this.BillingType = billingType;
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
            this.IsDiscount = isDiscount;
            this.ContractNumber = contractNumber;
            this.Supplier = supplier;
            this.Article = article;
            this.LoadingAddress = loadingAddress;
            this.UnloadingAddress = unloadingAddress;
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
        /// Gets or Sets IsDiscount
        /// </summary>
        [DataMember(Name = "isDiscount", EmitDefaultValue = true)]
        public bool? IsDiscount { get; set; }

        /// <summary>
        /// Gets or Sets ContractNumber
        /// </summary>
        [DataMember(Name = "contractNumber", EmitDefaultValue = true)]
        public string ContractNumber { get; set; }

        /// <summary>
        /// Gets or Sets Supplier
        /// </summary>
        [DataMember(Name = "supplier", EmitDefaultValue = false)]
        public Address Supplier { get; set; }

        /// <summary>
        /// Gets or Sets Article
        /// </summary>
        [DataMember(Name = "article", EmitDefaultValue = false)]
        public ArticleModel Article { get; set; }

        /// <summary>
        /// Gets or Sets LoadingAddress
        /// </summary>
        [DataMember(Name = "loadingAddress", EmitDefaultValue = false)]
        public Address LoadingAddress { get; set; }

        /// <summary>
        /// Gets or Sets UnloadingAddress
        /// </summary>
        [DataMember(Name = "unloadingAddress", EmitDefaultValue = false)]
        public Address UnloadingAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ContractItemModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  PositionNumber: ").Append(PositionNumber).Append("\n");
            sb.Append("  ReferenceNumber: ").Append(ReferenceNumber).Append("\n");
            sb.Append("  SupplierReferenceNumber: ").Append(SupplierReferenceNumber).Append("\n");
            sb.Append("  BillingType: ").Append(BillingType).Append("\n");
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
            sb.Append("  IsDiscount: ").Append(IsDiscount).Append("\n");
            sb.Append("  ContractNumber: ").Append(ContractNumber).Append("\n");
            sb.Append("  Supplier: ").Append(Supplier).Append("\n");
            sb.Append("  Article: ").Append(Article).Append("\n");
            sb.Append("  LoadingAddress: ").Append(LoadingAddress).Append("\n");
            sb.Append("  UnloadingAddress: ").Append(UnloadingAddress).Append("\n");
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
            return this.Equals(input as ContractItemModel);
        }

        /// <summary>
        /// Returns true if ContractItemModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ContractItemModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContractItemModel input)
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
                    this.IsDiscount == input.IsDiscount ||
                    (this.IsDiscount != null &&
                    this.IsDiscount.Equals(input.IsDiscount))
                ) && 
                (
                    this.ContractNumber == input.ContractNumber ||
                    (this.ContractNumber != null &&
                    this.ContractNumber.Equals(input.ContractNumber))
                ) && 
                (
                    this.Supplier == input.Supplier ||
                    (this.Supplier != null &&
                    this.Supplier.Equals(input.Supplier))
                ) && 
                (
                    this.Article == input.Article ||
                    (this.Article != null &&
                    this.Article.Equals(input.Article))
                ) && 
                (
                    this.LoadingAddress == input.LoadingAddress ||
                    (this.LoadingAddress != null &&
                    this.LoadingAddress.Equals(input.LoadingAddress))
                ) && 
                (
                    this.UnloadingAddress == input.UnloadingAddress ||
                    (this.UnloadingAddress != null &&
                    this.UnloadingAddress.Equals(input.UnloadingAddress))
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
                if (this.IsDiscount != null)
                {
                    hashCode = (hashCode * 59) + this.IsDiscount.GetHashCode();
                }
                if (this.ContractNumber != null)
                {
                    hashCode = (hashCode * 59) + this.ContractNumber.GetHashCode();
                }
                if (this.Supplier != null)
                {
                    hashCode = (hashCode * 59) + this.Supplier.GetHashCode();
                }
                if (this.Article != null)
                {
                    hashCode = (hashCode * 59) + this.Article.GetHashCode();
                }
                if (this.LoadingAddress != null)
                {
                    hashCode = (hashCode * 59) + this.LoadingAddress.GetHashCode();
                }
                if (this.UnloadingAddress != null)
                {
                    hashCode = (hashCode * 59) + this.UnloadingAddress.GetHashCode();
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
