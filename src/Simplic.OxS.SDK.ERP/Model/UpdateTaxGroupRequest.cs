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
    /// Represents a request to update a Simplic.OxS.ERP.TaxGroup.
    /// </summary>
    [DataContract(Name = "UpdateTaxGroupRequest")]
    public partial class UpdateTaxGroupRequest : IEquatable<UpdateTaxGroupRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTaxGroupRequest" /> class.
        /// </summary>
        /// <param name="number">Gets or sets the number..</param>
        /// <param name="name">Gets or sets the name..</param>
        /// <param name="countryIsoCodes">Gets or sets the set of countries given by ISO code..</param>
        /// <param name="taxRates">Gets or sets the tax rates for this tax group..</param>
        public UpdateTaxGroupRequest(int? number = default(int?), string name = default(string), List<string> countryIsoCodes = default(List<string>), List<TaxRateRequest> taxRates = default(List<TaxRateRequest>))
        {
            this.Number = number;
            this.Name = name;
            this.CountryIsoCodes = countryIsoCodes;
            this.TaxRates = taxRates;
        }

        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        /// <value>Gets or sets the number.</value>
        [DataMember(Name = "number", EmitDefaultValue = true)]
        public int? Number { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>Gets or sets the name.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the set of countries given by ISO code.
        /// </summary>
        /// <value>Gets or sets the set of countries given by ISO code.</value>
        [DataMember(Name = "countryIsoCodes", EmitDefaultValue = true)]
        public List<string> CountryIsoCodes { get; set; }

        /// <summary>
        /// Gets or sets the tax rates for this tax group.
        /// </summary>
        /// <value>Gets or sets the tax rates for this tax group.</value>
        [DataMember(Name = "taxRates", EmitDefaultValue = true)]
        public List<TaxRateRequest> TaxRates { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateTaxGroupRequest {\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CountryIsoCodes: ").Append(CountryIsoCodes).Append("\n");
            sb.Append("  TaxRates: ").Append(TaxRates).Append("\n");
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
            return this.Equals(input as UpdateTaxGroupRequest);
        }

        /// <summary>
        /// Returns true if UpdateTaxGroupRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateTaxGroupRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateTaxGroupRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.CountryIsoCodes == input.CountryIsoCodes ||
                    this.CountryIsoCodes != null &&
                    input.CountryIsoCodes != null &&
                    this.CountryIsoCodes.SequenceEqual(input.CountryIsoCodes)
                ) && 
                (
                    this.TaxRates == input.TaxRates ||
                    this.TaxRates != null &&
                    input.TaxRates != null &&
                    this.TaxRates.SequenceEqual(input.TaxRates)
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
                if (this.Number != null)
                {
                    hashCode = (hashCode * 59) + this.Number.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.CountryIsoCodes != null)
                {
                    hashCode = (hashCode * 59) + this.CountryIsoCodes.GetHashCode();
                }
                if (this.TaxRates != null)
                {
                    hashCode = (hashCode * 59) + this.TaxRates.GetHashCode();
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
