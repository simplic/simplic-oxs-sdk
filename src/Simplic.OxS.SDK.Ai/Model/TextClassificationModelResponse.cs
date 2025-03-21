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
    /// TextClassificationModelResponse
    /// </summary>
    [DataContract(Name = "TextClassificationModelResponse")]
    public partial class TextClassificationModelResponse : IEquatable<TextClassificationModelResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TextClassificationModelResponse" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="type">type.</param>
        /// <param name="state">state.</param>
        /// <param name="stateText">stateText.</param>
        /// <param name="trainingFormatData">trainingFormatData.</param>
        /// <param name="delimiter">delimiter.</param>
        /// <param name="labelDelimiter">labelDelimiter.</param>
        /// <param name="trainingDataPath">trainingDataPath.</param>
        /// <param name="varVersion">varVersion.</param>
        public TextClassificationModelResponse(Guid id = default(Guid), string name = default(string), string type = default(string), string state = default(string), string stateText = default(string), string trainingFormatData = default(string), string delimiter = default(string), string labelDelimiter = default(string), string trainingDataPath = default(string), int varVersion = default(int))
        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.State = state;
            this.StateText = stateText;
            this.TrainingFormatData = trainingFormatData;
            this.Delimiter = delimiter;
            this.LabelDelimiter = labelDelimiter;
            this.TrainingDataPath = trainingDataPath;
            this.VarVersion = varVersion;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

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
        /// Gets or Sets TrainingFormatData
        /// </summary>
        [DataMember(Name = "trainingFormatData", EmitDefaultValue = true)]
        public string TrainingFormatData { get; set; }

        /// <summary>
        /// Gets or Sets Delimiter
        /// </summary>
        [DataMember(Name = "delimiter", EmitDefaultValue = true)]
        public string Delimiter { get; set; }

        /// <summary>
        /// Gets or Sets LabelDelimiter
        /// </summary>
        [DataMember(Name = "labelDelimiter", EmitDefaultValue = true)]
        public string LabelDelimiter { get; set; }

        /// <summary>
        /// Gets or Sets TrainingDataPath
        /// </summary>
        [DataMember(Name = "trainingDataPath", EmitDefaultValue = true)]
        public string TrainingDataPath { get; set; }

        /// <summary>
        /// Gets or Sets VarVersion
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public int VarVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TextClassificationModelResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  StateText: ").Append(StateText).Append("\n");
            sb.Append("  TrainingFormatData: ").Append(TrainingFormatData).Append("\n");
            sb.Append("  Delimiter: ").Append(Delimiter).Append("\n");
            sb.Append("  LabelDelimiter: ").Append(LabelDelimiter).Append("\n");
            sb.Append("  TrainingDataPath: ").Append(TrainingDataPath).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
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
            return this.Equals(input as TextClassificationModelResponse);
        }

        /// <summary>
        /// Returns true if TextClassificationModelResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TextClassificationModelResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TextClassificationModelResponse input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                    this.TrainingFormatData == input.TrainingFormatData ||
                    (this.TrainingFormatData != null &&
                    this.TrainingFormatData.Equals(input.TrainingFormatData))
                ) && 
                (
                    this.Delimiter == input.Delimiter ||
                    (this.Delimiter != null &&
                    this.Delimiter.Equals(input.Delimiter))
                ) && 
                (
                    this.LabelDelimiter == input.LabelDelimiter ||
                    (this.LabelDelimiter != null &&
                    this.LabelDelimiter.Equals(input.LabelDelimiter))
                ) && 
                (
                    this.TrainingDataPath == input.TrainingDataPath ||
                    (this.TrainingDataPath != null &&
                    this.TrainingDataPath.Equals(input.TrainingDataPath))
                ) && 
                (
                    this.VarVersion == input.VarVersion ||
                    this.VarVersion.Equals(input.VarVersion)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
                }
                if (this.StateText != null)
                {
                    hashCode = (hashCode * 59) + this.StateText.GetHashCode();
                }
                if (this.TrainingFormatData != null)
                {
                    hashCode = (hashCode * 59) + this.TrainingFormatData.GetHashCode();
                }
                if (this.Delimiter != null)
                {
                    hashCode = (hashCode * 59) + this.Delimiter.GetHashCode();
                }
                if (this.LabelDelimiter != null)
                {
                    hashCode = (hashCode * 59) + this.LabelDelimiter.GetHashCode();
                }
                if (this.TrainingDataPath != null)
                {
                    hashCode = (hashCode * 59) + this.TrainingDataPath.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.VarVersion.GetHashCode();
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
