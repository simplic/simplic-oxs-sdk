/*
 * Simplic.OxS.sensor
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

namespace Simplic.OxS.SDK.Sensor
{
    /// <summary>
    /// PostSensorRequest
    /// </summary>
    [DataContract(Name = "PostSensorRequest")]
    public partial class PostSensorRequest : IEquatable<PostSensorRequest>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public State? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostSensorRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostSensorRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostSensorRequest" /> class.
        /// </summary>
        /// <param name="tagId">tagId (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="typeId">typeId (required).</param>
        /// <param name="organizationSiteId">organizationSiteId (required).</param>
        /// <param name="location">location.</param>
        /// <param name="state">state.</param>
        /// <param name="properties">properties.</param>
        /// <param name="manufacturer">manufacturer.</param>
        /// <param name="notes">notes.</param>
        /// <param name="notificationTeamId">notificationTeamId.</param>
        public PostSensorRequest(string tagId = default(string), string name = default(string), Guid typeId = default(Guid), Guid organizationSiteId = default(Guid), Location location = default(Location), State? state = default(State?), List<Property> properties = default(List<Property>), string manufacturer = default(string), string notes = default(string), Guid? notificationTeamId = default(Guid?))
        {
            // to ensure "tagId" is required (not null)
            if (tagId == null)
            {
                throw new ArgumentNullException("tagId is a required property for PostSensorRequest and cannot be null");
            }
            this.TagId = tagId;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for PostSensorRequest and cannot be null");
            }
            this.Name = name;
            this.TypeId = typeId;
            this.OrganizationSiteId = organizationSiteId;
            this.Location = location;
            this.State = state;
            this.Properties = properties;
            this.Manufacturer = manufacturer;
            this.Notes = notes;
            this.NotificationTeamId = notificationTeamId;
        }

        /// <summary>
        /// Gets or Sets TagId
        /// </summary>
        [DataMember(Name = "tagId", IsRequired = true, EmitDefaultValue = true)]
        public string TagId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets TypeId
        /// </summary>
        [DataMember(Name = "typeId", IsRequired = true, EmitDefaultValue = true)]
        public Guid TypeId { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationSiteId
        /// </summary>
        [DataMember(Name = "organizationSiteId", IsRequired = true, EmitDefaultValue = true)]
        public Guid OrganizationSiteId { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name = "location", EmitDefaultValue = false)]
        public Location Location { get; set; }

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name = "properties", EmitDefaultValue = true)]
        public List<Property> Properties { get; set; }

        /// <summary>
        /// Gets or Sets Manufacturer
        /// </summary>
        [DataMember(Name = "manufacturer", EmitDefaultValue = true)]
        public string Manufacturer { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name = "notes", EmitDefaultValue = true)]
        public string Notes { get; set; }

        /// <summary>
        /// Gets or Sets NotificationTeamId
        /// </summary>
        [DataMember(Name = "notificationTeamId", EmitDefaultValue = true)]
        public Guid? NotificationTeamId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PostSensorRequest {\n");
            sb.Append("  TagId: ").Append(TagId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TypeId: ").Append(TypeId).Append("\n");
            sb.Append("  OrganizationSiteId: ").Append(OrganizationSiteId).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Manufacturer: ").Append(Manufacturer).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  NotificationTeamId: ").Append(NotificationTeamId).Append("\n");
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
            return this.Equals(input as PostSensorRequest);
        }

        /// <summary>
        /// Returns true if PostSensorRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PostSensorRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostSensorRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TagId == input.TagId ||
                    (this.TagId != null &&
                    this.TagId.Equals(input.TagId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.TypeId == input.TypeId ||
                    (this.TypeId != null &&
                    this.TypeId.Equals(input.TypeId))
                ) && 
                (
                    this.OrganizationSiteId == input.OrganizationSiteId ||
                    (this.OrganizationSiteId != null &&
                    this.OrganizationSiteId.Equals(input.OrganizationSiteId))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.State == input.State ||
                    this.State.Equals(input.State)
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.Manufacturer == input.Manufacturer ||
                    (this.Manufacturer != null &&
                    this.Manufacturer.Equals(input.Manufacturer))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.NotificationTeamId == input.NotificationTeamId ||
                    (this.NotificationTeamId != null &&
                    this.NotificationTeamId.Equals(input.NotificationTeamId))
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
                if (this.TagId != null)
                {
                    hashCode = (hashCode * 59) + this.TagId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.TypeId != null)
                {
                    hashCode = (hashCode * 59) + this.TypeId.GetHashCode();
                }
                if (this.OrganizationSiteId != null)
                {
                    hashCode = (hashCode * 59) + this.OrganizationSiteId.GetHashCode();
                }
                if (this.Location != null)
                {
                    hashCode = (hashCode * 59) + this.Location.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.State.GetHashCode();
                if (this.Properties != null)
                {
                    hashCode = (hashCode * 59) + this.Properties.GetHashCode();
                }
                if (this.Manufacturer != null)
                {
                    hashCode = (hashCode * 59) + this.Manufacturer.GetHashCode();
                }
                if (this.Notes != null)
                {
                    hashCode = (hashCode * 59) + this.Notes.GetHashCode();
                }
                if (this.NotificationTeamId != null)
                {
                    hashCode = (hashCode * 59) + this.NotificationTeamId.GetHashCode();
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
            // TagId (string) minLength
            if (this.TagId != null && this.TagId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TagId, length must be greater than 1.", new [] { "TagId" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            yield break;
        }
    }

}
