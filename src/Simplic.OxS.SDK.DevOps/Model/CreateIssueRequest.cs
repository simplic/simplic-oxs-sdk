// <auto-generated>
/*
 * Simplic.OxS.DevOps
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

namespace Simplic.OxS.SDK.DevOps
{
    /// <summary>
    /// CreateIssueRequest
    /// </summary>
    public partial class CreateIssueRequest : IValidatableObject
    {

        /// <summary>
        /// Default constructor.
        /// </summary>
        [JsonConstructor]
        public CreateIssueRequest()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIssueRequest" /> class.
        /// </summary>
        /// <param name="description">description</param>
        /// <param name="title">title</param>
        /// <param name="type">type</param>
        /// <param name="attachments">attachments</param>
        /// <param name="issuer">issuer</param>
        /// <param name="issuerEMail">issuerEMail</param>
        /// <param name="projectId">projectId</param>
        //[JsonConstructor]
        public CreateIssueRequest(string description, string title, string type, Option<List<AttachmentModel>> attachments = default, Option<string> issuer = default, Option<string> issuerEMail = default, Option<Guid> projectId = default)
        {
            Description = description;
            Title = title;
            Type = type;
            AttachmentsOption = attachments;
            IssuerOption = issuer;
            IssuerEMailOption = issuerEMail;
            ProjectIdOption = projectId;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Used to track the state of Attachments
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<List<AttachmentModel>>))]
        public Option<List<AttachmentModel>> AttachmentsOption { get; private set; }

        /// <summary>
        /// Gets or Sets Attachments
        /// </summary>
        [JsonPropertyName("attachments")]
        public List<AttachmentModel>? Attachments { get { return this. AttachmentsOption; } set { this.AttachmentsOption = new Option<List<AttachmentModel>>(value); } }

        /// <summary>
        /// Used to track the state of Issuer
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> IssuerOption { get; private set; }

        /// <summary>
        /// Gets or Sets Issuer
        /// </summary>
        [JsonPropertyName("issuer")]
        public string? Issuer { get { return this. IssuerOption; } set { this.IssuerOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of IssuerEMail
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> IssuerEMailOption { get; private set; }

        /// <summary>
        /// Gets or Sets IssuerEMail
        /// </summary>
        [JsonPropertyName("issuerEMail")]
        public string? IssuerEMail { get { return this. IssuerEMailOption; } set { this.IssuerEMailOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of ProjectId
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<Guid>))]
        public Option<Guid> ProjectIdOption { get; private set; }

        /// <summary>
        /// Gets or Sets ProjectId
        /// </summary>
        [JsonPropertyName("projectId")]
        public Guid? ProjectId { get { return this. ProjectIdOption; } set { this.ProjectIdOption = new Option<Guid>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateIssueRequest {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  Issuer: ").Append(Issuer).Append("\n");
            sb.Append("  IssuerEMail: ").Append(IssuerEMail).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
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
    /// A Json converter for type <see cref="CreateIssueRequest" />
    /// </summary>
    public class CreateIssueRequestJsonConverter : JsonConverter<CreateIssueRequest>
    {
        /// <summary>
        /// Deserializes json to <see cref="CreateIssueRequest" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override CreateIssueRequest Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> description = default;
            Option<string> title = default;
            Option<string> type = default;
            Option<List<AttachmentModel>> attachments = default;
            Option<string> issuer = default;
            Option<string> issuerEMail = default;
            Option<Guid> projectId = default;

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
                        case "description":
                            description = new Option<string>(utf8JsonReader.GetString()!);
                            break;
                        case "title":
                            title = new Option<string>(utf8JsonReader.GetString()!);
                            break;
                        case "type":
                            type = new Option<string>(utf8JsonReader.GetString()!);
                            break;
                        case "attachments":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                attachments = new Option<List<AttachmentModel>>(JsonSerializer.Deserialize<List<AttachmentModel>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "issuer":
                            issuer = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "issuerEMail":
                            issuerEMail = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "projectId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                projectId = new Option<Guid>(utf8JsonReader.GetGuid());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!description.IsSet)
                throw new ArgumentException("Property is required for class CreateIssueRequest.", nameof(description));

            if (!title.IsSet)
                throw new ArgumentException("Property is required for class CreateIssueRequest.", nameof(title));

            if (!type.IsSet)
                throw new ArgumentException("Property is required for class CreateIssueRequest.", nameof(type));

            if (description.IsSet && description.Value == null)
                throw new ArgumentNullException(nameof(description), "Property is not nullable for class CreateIssueRequest.");

            if (title.IsSet && title.Value == null)
                throw new ArgumentNullException(nameof(title), "Property is not nullable for class CreateIssueRequest.");

            if (type.IsSet && type.Value == null)
                throw new ArgumentNullException(nameof(type), "Property is not nullable for class CreateIssueRequest.");

            //2return new CreateIssueRequest(description.Value!, title.Value!, type.Value!, attachments, issuer, issuerEMail, projectId);
            return new CreateIssueRequest(description.Value!, title.Value!, type.Value!, attachments, issuer, issuerEMail, projectId);
        }

        /// <summary>
        /// Serializes a <see cref="CreateIssueRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="createIssueRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, CreateIssueRequest createIssueRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, createIssueRequest, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="CreateIssueRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="createIssueRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, CreateIssueRequest createIssueRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            if (createIssueRequest.Description == null)
                throw new ArgumentNullException(nameof(createIssueRequest.Description), "Property is required for class CreateIssueRequest.");

            if (createIssueRequest.Title == null)
                throw new ArgumentNullException(nameof(createIssueRequest.Title), "Property is required for class CreateIssueRequest.");

            if (createIssueRequest.Type == null)
                throw new ArgumentNullException(nameof(createIssueRequest.Type), "Property is required for class CreateIssueRequest.");

            writer.WriteString("description", createIssueRequest.Description);

            writer.WriteString("title", createIssueRequest.Title);

            writer.WriteString("type", createIssueRequest.Type);

            if (createIssueRequest.AttachmentsOption.IsSet)
                if (createIssueRequest.AttachmentsOption.Value != null)
                {
                    writer.WritePropertyName("attachments");
                    JsonSerializer.Serialize(writer, createIssueRequest.Attachments, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("attachments");
            if (createIssueRequest.IssuerOption.IsSet)
                if (createIssueRequest.IssuerOption.Value != null)
                {
                    writer.WriteString("issuer", createIssueRequest.Issuer);
                    //var __value = createIssueRequest.IssuerOption.Value;
                    //writer.WriteString("issuer", __value);
                }
                else
                    writer.WriteNull("issuer");

            if (createIssueRequest.IssuerEMailOption.IsSet)
                if (createIssueRequest.IssuerEMailOption.Value != null)
                {
                    writer.WriteString("issuerEMail", createIssueRequest.IssuerEMail);
                    //var __value = createIssueRequest.IssuerEMailOption.Value;
                    //writer.WriteString("issuerEMail", __value);
                }
                else
                    writer.WriteNull("issuerEMail");

            if (createIssueRequest.ProjectIdOption.IsSet)
                if (createIssueRequest.ProjectIdOption.Value != null)
                {
                    writer.WriteString("projectId", createIssueRequest.ProjectIdOption!.Value);
                    //var __value = createIssueRequest.ProjectIdOption.Value;
                    //writer.WriteString("projectId", __value);
                }
                else
                    writer.WriteNull("projectId");
        }
    }
}
