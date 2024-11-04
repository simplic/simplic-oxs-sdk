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
using OpenAPIDateConverter = Simplic.OxS.SDK.OpenAPIDateConverter;

using Simplic.OxS.SDK;

namespace Simplic.OxS.SDK.Logistics
{
    /// <summary>
    /// Request to create a planning region.
    /// </summary>
    [DataContract(Name = "CreatePlanningRegionRequest")]
    public partial class CreatePlanningRegionRequest : IEquatable<CreatePlanningRegionRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePlanningRegionRequest" /> class.
        /// </summary>
        /// <param name="name">Gets or sets the name of the plannig region..</param>
        /// <param name="hexColor">Gets or sets the hex color of the planning region..</param>
        /// <param name="include">Gets or sets a list of country iso / zipcode tuples which are included from the plannig region..</param>
        /// <param name="exclude">Gets or sets a list of country iso / zipcode tuples which are excluded from the planning region..</param>
        /// <param name="functions">Gets or sets a list of functions for the region.  &lt;br&gt;  Currently planned are:  show_loadings,  show_unloading,  show_transits  .</param>
        public CreatePlanningRegionRequest(string name = default(string), string hexColor = default(string), List<RegionModel> include = default(List<RegionModel>), List<RegionModel> exclude = default(List<RegionModel>), List<string> functions = default(List<string>))
        {
            this.Name = name;
            this.HexColor = hexColor;
            this.Include = include;
            this.Exclude = exclude;
            this.Functions = functions;
        }

        /// <summary>
        /// Gets or sets the name of the plannig region.
        /// </summary>
        /// <value>Gets or sets the name of the plannig region.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the hex color of the planning region.
        /// </summary>
        /// <value>Gets or sets the hex color of the planning region.</value>
        [DataMember(Name = "hexColor", EmitDefaultValue = true)]
        public string HexColor { get; set; }

        /// <summary>
        /// Gets or sets a list of country iso / zipcode tuples which are included from the plannig region.
        /// </summary>
        /// <value>Gets or sets a list of country iso / zipcode tuples which are included from the plannig region.</value>
        [DataMember(Name = "include", EmitDefaultValue = true)]
        public List<RegionModel> Include { get; set; }

        /// <summary>
        /// Gets or sets a list of country iso / zipcode tuples which are excluded from the planning region.
        /// </summary>
        /// <value>Gets or sets a list of country iso / zipcode tuples which are excluded from the planning region.</value>
        [DataMember(Name = "exclude", EmitDefaultValue = true)]
        public List<RegionModel> Exclude { get; set; }

        /// <summary>
        /// Gets or sets a list of functions for the region.  &lt;br&gt;  Currently planned are:  show_loadings,  show_unloading,  show_transits  
        /// </summary>
        /// <value>Gets or sets a list of functions for the region.  &lt;br&gt;  Currently planned are:  show_loadings,  show_unloading,  show_transits  </value>
        [DataMember(Name = "functions", EmitDefaultValue = true)]
        public List<string> Functions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreatePlanningRegionRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  HexColor: ").Append(HexColor).Append("\n");
            sb.Append("  Include: ").Append(Include).Append("\n");
            sb.Append("  Exclude: ").Append(Exclude).Append("\n");
            sb.Append("  Functions: ").Append(Functions).Append("\n");
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
            return this.Equals(input as CreatePlanningRegionRequest);
        }

        /// <summary>
        /// Returns true if CreatePlanningRegionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreatePlanningRegionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreatePlanningRegionRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.HexColor == input.HexColor ||
                    (this.HexColor != null &&
                    this.HexColor.Equals(input.HexColor))
                ) && 
                (
                    this.Include == input.Include ||
                    this.Include != null &&
                    input.Include != null &&
                    this.Include.SequenceEqual(input.Include)
                ) && 
                (
                    this.Exclude == input.Exclude ||
                    this.Exclude != null &&
                    input.Exclude != null &&
                    this.Exclude.SequenceEqual(input.Exclude)
                ) && 
                (
                    this.Functions == input.Functions ||
                    this.Functions != null &&
                    input.Functions != null &&
                    this.Functions.SequenceEqual(input.Functions)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.HexColor != null)
                {
                    hashCode = (hashCode * 59) + this.HexColor.GetHashCode();
                }
                if (this.Include != null)
                {
                    hashCode = (hashCode * 59) + this.Include.GetHashCode();
                }
                if (this.Exclude != null)
                {
                    hashCode = (hashCode * 59) + this.Exclude.GetHashCode();
                }
                if (this.Functions != null)
                {
                    hashCode = (hashCode * 59) + this.Functions.GetHashCode();
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
