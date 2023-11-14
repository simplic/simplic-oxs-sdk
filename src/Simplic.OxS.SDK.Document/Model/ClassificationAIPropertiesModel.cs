/*
 * Simplic.OxS.Document
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

namespace Simplic.OxS.SDK.Document
{
    /// <summary>
    /// ClassificationAIPropertiesModel
    /// </summary>
    [DataContract(Name = "ClassificationAIPropertiesModel")]
    public partial class ClassificationAIPropertiesModel : IEquatable<ClassificationAIPropertiesModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationAIPropertiesModel" /> class.
        /// </summary>
        /// <param name="provider">provider.</param>
        /// <param name="enqueueMode">enqueueMode.</param>
        /// <param name="schema">schema.</param>
        public ClassificationAIPropertiesModel(string provider = default(string), string enqueueMode = default(string), string schema = default(string))
        {
            this.Provider = provider;
            this.EnqueueMode = enqueueMode;
            this.Schema = schema;
        }

        /// <summary>
        /// Gets or Sets Provider
        /// </summary>
        [DataMember(Name = "provider", EmitDefaultValue = true)]
        public string Provider { get; set; }

        /// <summary>
        /// Gets or Sets EnqueueMode
        /// </summary>
        [DataMember(Name = "enqueueMode", EmitDefaultValue = true)]
        public string EnqueueMode { get; set; }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = true)]
        public string Schema { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ClassificationAIPropertiesModel {\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  EnqueueMode: ").Append(EnqueueMode).Append("\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
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
            return this.Equals(input as ClassificationAIPropertiesModel);
        }

        /// <summary>
        /// Returns true if ClassificationAIPropertiesModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ClassificationAIPropertiesModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClassificationAIPropertiesModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Provider == input.Provider ||
                    (this.Provider != null &&
                    this.Provider.Equals(input.Provider))
                ) && 
                (
                    this.EnqueueMode == input.EnqueueMode ||
                    (this.EnqueueMode != null &&
                    this.EnqueueMode.Equals(input.EnqueueMode))
                ) && 
                (
                    this.Schema == input.Schema ||
                    (this.Schema != null &&
                    this.Schema.Equals(input.Schema))
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
                if (this.Provider != null)
                {
                    hashCode = (hashCode * 59) + this.Provider.GetHashCode();
                }
                if (this.EnqueueMode != null)
                {
                    hashCode = (hashCode * 59) + this.EnqueueMode.GetHashCode();
                }
                if (this.Schema != null)
                {
                    hashCode = (hashCode * 59) + this.Schema.GetHashCode();
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
