// <auto-generated>
/*
 * Simplic.OxS.TimeSlot
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using Simplic.OxS.SDK;

using Simplic.OxS.SDK;

namespace Simplic.OxS.SDK.TimeSlot
{
    /// <summary>
    /// Represents a bookable location
    /// </summary>
    public partial class UpdateSiteRequest : IValidatableObject
    {

        /// <summary>
        /// Default constructor.
        /// </summary>
        [JsonConstructor]
        public UpdateSiteRequest()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSiteRequest" /> class.
        /// </summary>
        /// <param name="adress">adress</param>
        /// <param name="assignments">assignments</param>
        /// <param name="logoUrl">logoUrl</param>
        /// <param name="name">name</param>
        /// <param name="organizationSiteId">organizationSiteId</param>
        //[JsonConstructor]
        public UpdateSiteRequest(Option<SiteAddressModel> adress = default, Option<List<SiteAssignment>> assignments = default, Option<string> logoUrl = default, Option<string> name = default, Option<Guid> organizationSiteId = default)
        {
            AdressOption = adress;
            AssignmentsOption = assignments;
            LogoUrlOption = logoUrl;
            NameOption = name;
            OrganizationSiteIdOption = organizationSiteId;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Adress
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<SiteAddressModel>))]
        public Option<SiteAddressModel> AdressOption { get; private set; }

        /// <summary>
        /// Gets or Sets Adress
        /// </summary>
        [JsonPropertyName("adress")]
        public SiteAddressModel? Adress { get { return this. AdressOption; } set { this.AdressOption = new Option<SiteAddressModel>(value); } }

        /// <summary>
        /// Used to track the state of Assignments
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<List<SiteAssignment>>))]
        public Option<List<SiteAssignment>> AssignmentsOption { get; private set; }

        /// <summary>
        /// Gets or Sets Assignments
        /// </summary>
        [JsonPropertyName("assignments")]
        public List<SiteAssignment>? Assignments { get { return this. AssignmentsOption; } set { this.AssignmentsOption = new Option<List<SiteAssignment>>(value); } }

        /// <summary>
        /// Used to track the state of LogoUrl
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> LogoUrlOption { get; private set; }

        /// <summary>
        /// Gets or Sets LogoUrl
        /// </summary>
        [JsonPropertyName("logoUrl")]
        public string? LogoUrl { get { return this. LogoUrlOption; } set { this.LogoUrlOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Name
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> NameOption { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get { return this. NameOption; } set { this.NameOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of OrganizationSiteId
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<Guid>))]
        public Option<Guid> OrganizationSiteIdOption { get; private set; }

        /// <summary>
        /// Gets or Sets OrganizationSiteId
        /// </summary>
        [JsonPropertyName("organizationSiteId")]
        public Guid? OrganizationSiteId { get { return this. OrganizationSiteIdOption; } set { this.OrganizationSiteIdOption = new Option<Guid>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateSiteRequest {\n");
            sb.Append("  Adress: ").Append(Adress).Append("\n");
            sb.Append("  Assignments: ").Append(Assignments).Append("\n");
            sb.Append("  LogoUrl: ").Append(LogoUrl).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OrganizationSiteId: ").Append(OrganizationSiteId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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

    /// <summary>
    /// A Json converter for type <see cref="UpdateSiteRequest" />
    /// </summary>
    public class UpdateSiteRequestJsonConverter : JsonConverter<UpdateSiteRequest>
    {
        /// <summary>
        /// Deserializes json to <see cref="UpdateSiteRequest" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override UpdateSiteRequest Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<SiteAddressModel> adress = default;
            Option<List<SiteAssignment>> assignments = default;
            Option<string> logoUrl = default;
            Option<string> name = default;
            Option<Guid> organizationSiteId = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "adress":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                adress = new Option<SiteAddressModel>(JsonSerializer.Deserialize<SiteAddressModel>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "assignments":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                assignments = new Option<List<SiteAssignment>>(JsonSerializer.Deserialize<List<SiteAssignment>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "logoUrl":
                            logoUrl = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "name":
                            name = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "organizationSiteId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                organizationSiteId = new Option<Guid>(utf8JsonReader.GetGuid());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (adress.IsSet && adress.Value == null)
                throw new ArgumentNullException(nameof(adress), "Property is not nullable for class UpdateSiteRequest.");

            //2return new UpdateSiteRequest(adress, assignments, logoUrl, name, organizationSiteId);
            return new UpdateSiteRequest(adress, assignments, logoUrl, name, organizationSiteId);
        }

        /// <summary>
        /// Serializes a <see cref="UpdateSiteRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="updateSiteRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, UpdateSiteRequest updateSiteRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, updateSiteRequest, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="UpdateSiteRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="updateSiteRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, UpdateSiteRequest updateSiteRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            if (updateSiteRequest.AdressOption.IsSet && updateSiteRequest.Adress == null)
                throw new ArgumentNullException(nameof(updateSiteRequest.Adress), "Property is required for class UpdateSiteRequest.");

            if (updateSiteRequest.AdressOption.IsSet)
            {
                writer.WritePropertyName("adress");
                JsonSerializer.Serialize(writer, updateSiteRequest.Adress, jsonSerializerOptions);
            }
            if (updateSiteRequest.AssignmentsOption.IsSet)
                if (updateSiteRequest.AssignmentsOption.Value != null)
                {
                    writer.WritePropertyName("assignments");
                    JsonSerializer.Serialize(writer, updateSiteRequest.Assignments, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("assignments");
            if (updateSiteRequest.LogoUrlOption.IsSet)
                if (updateSiteRequest.LogoUrlOption.Value != null)
                {
                    writer.WriteString("logoUrl", updateSiteRequest.LogoUrl);
                    //var __value = updateSiteRequest.LogoUrlOption.Value;
                    //writer.WriteString("logoUrl", __value);
                }
                else
                    writer.WriteNull("logoUrl");

            if (updateSiteRequest.NameOption.IsSet)
                if (updateSiteRequest.NameOption.Value != null)
                {
                    writer.WriteString("name", updateSiteRequest.Name);
                    //var __value = updateSiteRequest.NameOption.Value;
                    //writer.WriteString("name", __value);
                }
                else
                    writer.WriteNull("name");

            if (updateSiteRequest.OrganizationSiteIdOption.IsSet)
                if (updateSiteRequest.OrganizationSiteIdOption.Value != null)
                {
                    writer.WriteString("organizationSiteId", updateSiteRequest.OrganizationSiteIdOption!.Value);
                    //var __value = updateSiteRequest.OrganizationSiteIdOption.Value;
                    //writer.WriteString("organizationSiteId", __value);
                }
                else
                    writer.WriteNull("organizationSiteId");
        }
    }
}
