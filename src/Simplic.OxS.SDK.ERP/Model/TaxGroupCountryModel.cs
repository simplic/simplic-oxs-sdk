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
    /// Represents the shared model for Simplic.OxS.ERP.TaxGroupCountry.
    /// </summary>
    [DataContract(Name = "TaxGroupCountryModel")]
    public partial class TaxGroupCountryModel : IEquatable<TaxGroupCountryModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxGroupCountryModel" /> class.
        /// </summary>
        /// <param name="isoCode">Gets or sets the ISO code..</param>
        public TaxGroupCountryModel(string isoCode = default(string))
        {
            this.IsoCode = isoCode;
        }

        /// <summary>
        /// Gets or sets the ISO code.
        /// </summary>
        /// <value>Gets or sets the ISO code.</value>
        [DataMember(Name = "isoCode", EmitDefaultValue = true)]
        public string IsoCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TaxGroupCountryModel {\n");
            sb.Append("  IsoCode: ").Append(IsoCode).Append("\n");
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
            return this.Equals(input as TaxGroupCountryModel);
        }

        /// <summary>
        /// Returns true if TaxGroupCountryModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TaxGroupCountryModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxGroupCountryModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IsoCode == input.IsoCode ||
                    (this.IsoCode != null &&
                    this.IsoCode.Equals(input.IsoCode))
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
                if (this.IsoCode != null)
                {
                    hashCode = (hashCode * 59) + this.IsoCode.GetHashCode();
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
