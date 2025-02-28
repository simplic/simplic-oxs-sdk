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
    /// Represents a request to create a Simplic.OxS.ERP.TaxGroup.
    /// </summary>
    [DataContract(Name = "TaxGroupRequest")]
    public partial class TaxGroupRequest : IEquatable<TaxGroupRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxGroupRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TaxGroupRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxGroupRequest" /> class.
        /// </summary>
        /// <param name="number">Gets or sets the number. (required).</param>
        /// <param name="name">Gets or sets the name. (required).</param>
        /// <param name="countryIsoCodes">Gets or sets the set of countries given by ISO code. (required).</param>
        /// <param name="taxRates">Gets or sets the tax rates for this tax group. (required).</param>
        public TaxGroupRequest(int number = default(int), string name = default(string), List<string> countryIsoCodes = default(List<string>), List<TaxRateRequest> taxRates = default(List<TaxRateRequest>))
        {
            this.Number = number;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for TaxGroupRequest and cannot be null");
            }
            this.Name = name;
            // to ensure "countryIsoCodes" is required (not null)
            if (countryIsoCodes == null)
            {
                throw new ArgumentNullException("countryIsoCodes is a required property for TaxGroupRequest and cannot be null");
            }
            this.CountryIsoCodes = countryIsoCodes;
            // to ensure "taxRates" is required (not null)
            if (taxRates == null)
            {
                throw new ArgumentNullException("taxRates is a required property for TaxGroupRequest and cannot be null");
            }
            this.TaxRates = taxRates;
        }

        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        /// <value>Gets or sets the number.</value>
        [DataMember(Name = "number", IsRequired = true, EmitDefaultValue = true)]
        public int Number { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>Gets or sets the name.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the set of countries given by ISO code.
        /// </summary>
        /// <value>Gets or sets the set of countries given by ISO code.</value>
        [DataMember(Name = "countryIsoCodes", IsRequired = true, EmitDefaultValue = true)]
        public List<string> CountryIsoCodes { get; set; }

        /// <summary>
        /// Gets or sets the tax rates for this tax group.
        /// </summary>
        /// <value>Gets or sets the tax rates for this tax group.</value>
        [DataMember(Name = "taxRates", IsRequired = true, EmitDefaultValue = true)]
        public List<TaxRateRequest> TaxRates { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TaxGroupRequest {\n");
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
            return this.Equals(input as TaxGroupRequest);
        }

        /// <summary>
        /// Returns true if TaxGroupRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TaxGroupRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxGroupRequest input)
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
                hashCode = (hashCode * 59) + this.Number.GetHashCode();
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 100.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 2.", new [] { "Name" });
            }

            yield break;
        }
    }

}
