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
    /// Request to create an appointment.
    /// </summary>
    [DataContract(Name = "CreateAppointmentRequest")]
    public partial class CreateAppointmentRequest : IEquatable<CreateAppointmentRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAppointmentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateAppointmentRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAppointmentRequest" /> class.
        /// </summary>
        /// <param name="startAddressId">Gets or sets the id of the start address..</param>
        /// <param name="endAddressId">Gets or sets the id of the end address..</param>
        /// <param name="resources">Gets or sets the resources for the appointment..</param>
        /// <param name="functions">Gets or sets a list of functinos for an appointment.     A function can change the behaviour of some methdos with the function added as string.  &lt;list type&#x3D;\&quot;bullet\&quot;&gt;&lt;item&gt;\&quot;blocking\&quot; : Will determine whether the appointment block other appointments or tours to be   scheduled at the same time for the contained resources.&lt;/item&gt;&lt;/list&gt;.</param>
        /// <param name="title">Gets or sets the title of the appointment. (required).</param>
        /// <param name="startDateTime">Gets or sets the start date and time of the appointment. (required).</param>
        /// <param name="endDateTime">Gets or sets the end date and time of the appointment. (required).</param>
        /// <param name="hexColor">Gets or sets the hex color for the appointment.     Default color is light red.  .</param>
        public CreateAppointmentRequest(Guid? startAddressId = default(Guid?), Guid? endAddressId = default(Guid?), List<Guid> resources = default(List<Guid>), List<string> functions = default(List<string>), string title = default(string), DateTime startDateTime = default(DateTime), DateTime endDateTime = default(DateTime), string hexColor = default(string))
        {
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for CreateAppointmentRequest and cannot be null");
            }
            this.Title = title;
            this.StartDateTime = startDateTime;
            this.EndDateTime = endDateTime;
            this.StartAddressId = startAddressId;
            this.EndAddressId = endAddressId;
            this.Resources = resources;
            this.Functions = functions;
            this.HexColor = hexColor;
        }

        /// <summary>
        /// Gets or sets the id of the start address.
        /// </summary>
        /// <value>Gets or sets the id of the start address.</value>
        [DataMember(Name = "startAddressId", EmitDefaultValue = true)]
        public Guid? StartAddressId { get; set; }

        /// <summary>
        /// Gets or sets the id of the end address.
        /// </summary>
        /// <value>Gets or sets the id of the end address.</value>
        [DataMember(Name = "endAddressId", EmitDefaultValue = true)]
        public Guid? EndAddressId { get; set; }

        /// <summary>
        /// Gets or sets the resources for the appointment.
        /// </summary>
        /// <value>Gets or sets the resources for the appointment.</value>
        [DataMember(Name = "resources", EmitDefaultValue = true)]
        public List<Guid> Resources { get; set; }

        /// <summary>
        /// Gets or sets a list of functinos for an appointment.     A function can change the behaviour of some methdos with the function added as string.  &lt;list type&#x3D;\&quot;bullet\&quot;&gt;&lt;item&gt;\&quot;blocking\&quot; : Will determine whether the appointment block other appointments or tours to be   scheduled at the same time for the contained resources.&lt;/item&gt;&lt;/list&gt;
        /// </summary>
        /// <value>Gets or sets a list of functinos for an appointment.     A function can change the behaviour of some methdos with the function added as string.  &lt;list type&#x3D;\&quot;bullet\&quot;&gt;&lt;item&gt;\&quot;blocking\&quot; : Will determine whether the appointment block other appointments or tours to be   scheduled at the same time for the contained resources.&lt;/item&gt;&lt;/list&gt;</value>
        [DataMember(Name = "functions", EmitDefaultValue = true)]
        public List<string> Functions { get; set; }

        /// <summary>
        /// Gets or sets the title of the appointment.
        /// </summary>
        /// <value>Gets or sets the title of the appointment.</value>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the start date and time of the appointment.
        /// </summary>
        /// <value>Gets or sets the start date and time of the appointment.</value>
        [DataMember(Name = "startDateTime", IsRequired = true, EmitDefaultValue = true)]
        public DateTime StartDateTime { get; set; }

        /// <summary>
        /// Gets or sets the end date and time of the appointment.
        /// </summary>
        /// <value>Gets or sets the end date and time of the appointment.</value>
        [DataMember(Name = "endDateTime", IsRequired = true, EmitDefaultValue = true)]
        public DateTime EndDateTime { get; set; }

        /// <summary>
        /// Gets or sets the hex color for the appointment.     Default color is light red.  
        /// </summary>
        /// <value>Gets or sets the hex color for the appointment.     Default color is light red.  </value>
        [DataMember(Name = "hexColor", EmitDefaultValue = true)]
        public string HexColor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateAppointmentRequest {\n");
            sb.Append("  StartAddressId: ").Append(StartAddressId).Append("\n");
            sb.Append("  EndAddressId: ").Append(EndAddressId).Append("\n");
            sb.Append("  Resources: ").Append(Resources).Append("\n");
            sb.Append("  Functions: ").Append(Functions).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  StartDateTime: ").Append(StartDateTime).Append("\n");
            sb.Append("  EndDateTime: ").Append(EndDateTime).Append("\n");
            sb.Append("  HexColor: ").Append(HexColor).Append("\n");
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
            return this.Equals(input as CreateAppointmentRequest);
        }

        /// <summary>
        /// Returns true if CreateAppointmentRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateAppointmentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateAppointmentRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.StartAddressId == input.StartAddressId ||
                    (this.StartAddressId != null &&
                    this.StartAddressId.Equals(input.StartAddressId))
                ) && 
                (
                    this.EndAddressId == input.EndAddressId ||
                    (this.EndAddressId != null &&
                    this.EndAddressId.Equals(input.EndAddressId))
                ) && 
                (
                    this.Resources == input.Resources ||
                    this.Resources != null &&
                    input.Resources != null &&
                    this.Resources.SequenceEqual(input.Resources)
                ) && 
                (
                    this.Functions == input.Functions ||
                    this.Functions != null &&
                    input.Functions != null &&
                    this.Functions.SequenceEqual(input.Functions)
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.StartDateTime == input.StartDateTime ||
                    (this.StartDateTime != null &&
                    this.StartDateTime.Equals(input.StartDateTime))
                ) && 
                (
                    this.EndDateTime == input.EndDateTime ||
                    (this.EndDateTime != null &&
                    this.EndDateTime.Equals(input.EndDateTime))
                ) && 
                (
                    this.HexColor == input.HexColor ||
                    (this.HexColor != null &&
                    this.HexColor.Equals(input.HexColor))
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
                if (this.StartAddressId != null)
                {
                    hashCode = (hashCode * 59) + this.StartAddressId.GetHashCode();
                }
                if (this.EndAddressId != null)
                {
                    hashCode = (hashCode * 59) + this.EndAddressId.GetHashCode();
                }
                if (this.Resources != null)
                {
                    hashCode = (hashCode * 59) + this.Resources.GetHashCode();
                }
                if (this.Functions != null)
                {
                    hashCode = (hashCode * 59) + this.Functions.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.StartDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartDateTime.GetHashCode();
                }
                if (this.EndDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.EndDateTime.GetHashCode();
                }
                if (this.HexColor != null)
                {
                    hashCode = (hashCode * 59) + this.HexColor.GetHashCode();
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
            // Title (string) minLength
            if (this.Title != null && this.Title.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Title, length must be greater than 1.", new [] { "Title" });
            }

            yield break;
        }
    }

}
