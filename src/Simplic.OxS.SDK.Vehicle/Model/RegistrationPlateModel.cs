/*
 * Simplic.OxS.Vehicle
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

namespace Simplic.OxS.SDK.Vehicle
{
    /// <summary>
    /// RegistrationPlateModel
    /// </summary>
    [DataContract(Name = "RegistrationPlateModel")]
    public partial class RegistrationPlateModel : IEquatable<RegistrationPlateModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrationPlateModel" /> class.
        /// </summary>
        /// <param name="countryIso">countryIso.</param>
        /// <param name="isSeaosnal">isSeaosnal.</param>
        /// <param name="registrationIdentifier">registrationIdentifier.</param>
        /// <param name="remark">remark.</param>
        public RegistrationPlateModel(string countryIso = default(string), bool? isSeaosnal = default(bool?), string registrationIdentifier = default(string), string remark = default(string))
        {
            this.CountryIso = countryIso;
            this.IsSeaosnal = isSeaosnal;
            this.RegistrationIdentifier = registrationIdentifier;
            this.Remark = remark;
        }

        /// <summary>
        /// Gets or Sets CountryIso
        /// </summary>
        [DataMember(Name = "countryIso", EmitDefaultValue = true)]
        public string CountryIso { get; set; }

        /// <summary>
        /// Gets or Sets IsSeaosnal
        /// </summary>
        [DataMember(Name = "isSeaosnal", EmitDefaultValue = true)]
        public bool? IsSeaosnal { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationIdentifier
        /// </summary>
        [DataMember(Name = "registrationIdentifier", EmitDefaultValue = true)]
        public string RegistrationIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets Remark
        /// </summary>
        [DataMember(Name = "remark", EmitDefaultValue = true)]
        public string Remark { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RegistrationPlateModel {\n");
            sb.Append("  CountryIso: ").Append(CountryIso).Append("\n");
            sb.Append("  IsSeaosnal: ").Append(IsSeaosnal).Append("\n");
            sb.Append("  RegistrationIdentifier: ").Append(RegistrationIdentifier).Append("\n");
            sb.Append("  Remark: ").Append(Remark).Append("\n");
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
            return this.Equals(input as RegistrationPlateModel);
        }

        /// <summary>
        /// Returns true if RegistrationPlateModel instances are equal
        /// </summary>
        /// <param name="input">Instance of RegistrationPlateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegistrationPlateModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CountryIso == input.CountryIso ||
                    (this.CountryIso != null &&
                    this.CountryIso.Equals(input.CountryIso))
                ) && 
                (
                    this.IsSeaosnal == input.IsSeaosnal ||
                    (this.IsSeaosnal != null &&
                    this.IsSeaosnal.Equals(input.IsSeaosnal))
                ) && 
                (
                    this.RegistrationIdentifier == input.RegistrationIdentifier ||
                    (this.RegistrationIdentifier != null &&
                    this.RegistrationIdentifier.Equals(input.RegistrationIdentifier))
                ) && 
                (
                    this.Remark == input.Remark ||
                    (this.Remark != null &&
                    this.Remark.Equals(input.Remark))
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
                if (this.CountryIso != null)
                {
                    hashCode = (hashCode * 59) + this.CountryIso.GetHashCode();
                }
                if (this.IsSeaosnal != null)
                {
                    hashCode = (hashCode * 59) + this.IsSeaosnal.GetHashCode();
                }
                if (this.RegistrationIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.RegistrationIdentifier.GetHashCode();
                }
                if (this.Remark != null)
                {
                    hashCode = (hashCode * 59) + this.Remark.GetHashCode();
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
