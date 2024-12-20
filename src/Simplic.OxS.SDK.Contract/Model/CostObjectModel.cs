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
    /// CostObjectModel
    /// </summary>
    [DataContract(Name = "CostObjectModel")]
    public partial class CostObjectModel : IEquatable<CostObjectModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CostObjectModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="isDefault">isDefault.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="purchasePrice">purchasePrice.</param>
        /// <param name="freightPrice">freightPrice.</param>
        /// <param name="salePrice">salePrice.</param>
        /// <param name="tollPrice">tollPrice.</param>
        /// <param name="pricePerKilometer">pricePerKilometer.</param>
        /// <param name="minimumDistance">minimumDistance.</param>
        /// <param name="additionalMaterialCost">additionalMaterialCost.</param>
        /// <param name="additionalFreightCost">additionalFreightCost.</param>
        public CostObjectModel(Guid id = default(Guid), bool isDefault = default(bool), DateTime startDate = default(DateTime), DateTime endDate = default(DateTime), double purchasePrice = default(double), double freightPrice = default(double), double salePrice = default(double), double tollPrice = default(double), double pricePerKilometer = default(double), double minimumDistance = default(double), double additionalMaterialCost = default(double), double additionalFreightCost = default(double))
        {
            this.Id = id;
            this.IsDefault = isDefault;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.PurchasePrice = purchasePrice;
            this.FreightPrice = freightPrice;
            this.SalePrice = salePrice;
            this.TollPrice = tollPrice;
            this.PricePerKilometer = pricePerKilometer;
            this.MinimumDistance = minimumDistance;
            this.AdditionalMaterialCost = additionalMaterialCost;
            this.AdditionalFreightCost = additionalFreightCost;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets IsDefault
        /// </summary>
        [DataMember(Name = "isDefault", EmitDefaultValue = true)]
        public bool IsDefault { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name = "startDate", EmitDefaultValue = false)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name = "endDate", EmitDefaultValue = false)]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or Sets PurchasePrice
        /// </summary>
        [DataMember(Name = "purchasePrice", EmitDefaultValue = false)]
        public double PurchasePrice { get; set; }

        /// <summary>
        /// Gets or Sets FreightPrice
        /// </summary>
        [DataMember(Name = "freightPrice", EmitDefaultValue = false)]
        public double FreightPrice { get; set; }

        /// <summary>
        /// Gets or Sets SalePrice
        /// </summary>
        [DataMember(Name = "salePrice", EmitDefaultValue = false)]
        public double SalePrice { get; set; }

        /// <summary>
        /// Gets or Sets TollPrice
        /// </summary>
        [DataMember(Name = "tollPrice", EmitDefaultValue = false)]
        public double TollPrice { get; set; }

        /// <summary>
        /// Gets or Sets PricePerKilometer
        /// </summary>
        [DataMember(Name = "pricePerKilometer", EmitDefaultValue = false)]
        public double PricePerKilometer { get; set; }

        /// <summary>
        /// Gets or Sets MinimumDistance
        /// </summary>
        [DataMember(Name = "minimumDistance", EmitDefaultValue = false)]
        public double MinimumDistance { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalMaterialCost
        /// </summary>
        [DataMember(Name = "additionalMaterialCost", EmitDefaultValue = false)]
        public double AdditionalMaterialCost { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalFreightCost
        /// </summary>
        [DataMember(Name = "additionalFreightCost", EmitDefaultValue = false)]
        public double AdditionalFreightCost { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CostObjectModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  PurchasePrice: ").Append(PurchasePrice).Append("\n");
            sb.Append("  FreightPrice: ").Append(FreightPrice).Append("\n");
            sb.Append("  SalePrice: ").Append(SalePrice).Append("\n");
            sb.Append("  TollPrice: ").Append(TollPrice).Append("\n");
            sb.Append("  PricePerKilometer: ").Append(PricePerKilometer).Append("\n");
            sb.Append("  MinimumDistance: ").Append(MinimumDistance).Append("\n");
            sb.Append("  AdditionalMaterialCost: ").Append(AdditionalMaterialCost).Append("\n");
            sb.Append("  AdditionalFreightCost: ").Append(AdditionalFreightCost).Append("\n");
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
            return this.Equals(input as CostObjectModel);
        }

        /// <summary>
        /// Returns true if CostObjectModel instances are equal
        /// </summary>
        /// <param name="input">Instance of CostObjectModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CostObjectModel input)
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
                    this.IsDefault == input.IsDefault ||
                    this.IsDefault.Equals(input.IsDefault)
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.PurchasePrice == input.PurchasePrice ||
                    this.PurchasePrice.Equals(input.PurchasePrice)
                ) && 
                (
                    this.FreightPrice == input.FreightPrice ||
                    this.FreightPrice.Equals(input.FreightPrice)
                ) && 
                (
                    this.SalePrice == input.SalePrice ||
                    this.SalePrice.Equals(input.SalePrice)
                ) && 
                (
                    this.TollPrice == input.TollPrice ||
                    this.TollPrice.Equals(input.TollPrice)
                ) && 
                (
                    this.PricePerKilometer == input.PricePerKilometer ||
                    this.PricePerKilometer.Equals(input.PricePerKilometer)
                ) && 
                (
                    this.MinimumDistance == input.MinimumDistance ||
                    this.MinimumDistance.Equals(input.MinimumDistance)
                ) && 
                (
                    this.AdditionalMaterialCost == input.AdditionalMaterialCost ||
                    this.AdditionalMaterialCost.Equals(input.AdditionalMaterialCost)
                ) && 
                (
                    this.AdditionalFreightCost == input.AdditionalFreightCost ||
                    this.AdditionalFreightCost.Equals(input.AdditionalFreightCost)
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
                hashCode = (hashCode * 59) + this.IsDefault.GetHashCode();
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PurchasePrice.GetHashCode();
                hashCode = (hashCode * 59) + this.FreightPrice.GetHashCode();
                hashCode = (hashCode * 59) + this.SalePrice.GetHashCode();
                hashCode = (hashCode * 59) + this.TollPrice.GetHashCode();
                hashCode = (hashCode * 59) + this.PricePerKilometer.GetHashCode();
                hashCode = (hashCode * 59) + this.MinimumDistance.GetHashCode();
                hashCode = (hashCode * 59) + this.AdditionalMaterialCost.GetHashCode();
                hashCode = (hashCode * 59) + this.AdditionalFreightCost.GetHashCode();
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
