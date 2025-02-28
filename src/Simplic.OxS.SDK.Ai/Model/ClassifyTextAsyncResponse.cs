/*
 * Simplic.OxS.ai
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

namespace Simplic.OxS.SDK.Ai
{
    /// <summary>
    /// ClassifyTextAsyncResponse
    /// </summary>
    [DataContract(Name = "ClassifyTextAsyncResponse")]
    public partial class ClassifyTextAsyncResponse : IEquatable<ClassifyTextAsyncResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyTextAsyncResponse" /> class.
        /// </summary>
        /// <param name="jobId">jobId.</param>
        /// <param name="state">state.</param>
        /// <param name="stateText">stateText.</param>
        /// <param name="results">results.</param>
        public ClassifyTextAsyncResponse(string jobId = default(string), string state = default(string), string stateText = default(string), List<TextClassificationResultResponse> results = default(List<TextClassificationResultResponse>))
        {
            this.JobId = jobId;
            this.State = state;
            this.StateText = stateText;
            this.Results = results;
        }

        /// <summary>
        /// Gets or Sets JobId
        /// </summary>
        [DataMember(Name = "jobId", EmitDefaultValue = true)]
        public string JobId { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = true)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets StateText
        /// </summary>
        [DataMember(Name = "stateText", EmitDefaultValue = true)]
        public string StateText { get; set; }

        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name = "results", EmitDefaultValue = true)]
        public List<TextClassificationResultResponse> Results { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ClassifyTextAsyncResponse {\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  StateText: ").Append(StateText).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
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
            return this.Equals(input as ClassifyTextAsyncResponse);
        }

        /// <summary>
        /// Returns true if ClassifyTextAsyncResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ClassifyTextAsyncResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClassifyTextAsyncResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.StateText == input.StateText ||
                    (this.StateText != null &&
                    this.StateText.Equals(input.StateText))
                ) && 
                (
                    this.Results == input.Results ||
                    this.Results != null &&
                    input.Results != null &&
                    this.Results.SequenceEqual(input.Results)
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
                if (this.JobId != null)
                {
                    hashCode = (hashCode * 59) + this.JobId.GetHashCode();
                }
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
                }
                if (this.StateText != null)
                {
                    hashCode = (hashCode * 59) + this.StateText.GetHashCode();
                }
                if (this.Results != null)
                {
                    hashCode = (hashCode * 59) + this.Results.GetHashCode();
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
