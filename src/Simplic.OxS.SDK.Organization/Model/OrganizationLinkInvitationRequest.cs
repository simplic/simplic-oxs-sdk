// <auto-generated>
/*
 * Simplic.OxS.Organization
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

namespace Simplic.OxS.SDK.Organization
{
    /// <summary>
    /// Containing all information for requesting an organization link invitation (one-time invitation)
    /// </summary>
    public partial class OrganizationLinkInvitationRequest : IValidatableObject
    {

        /// <summary>
        /// Default constructor.
        /// </summary>
        [JsonConstructor]
        public OrganizationLinkInvitationRequest()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationLinkInvitationRequest" /> class.
        /// </summary>
        /// <param name="email">Gets or sets the email address of the invited organization-user (for accepting the one-time link)</param>
        /// <param name="targetOrganization">Gets or sets the name of the target organization</param>
        /// <param name="modules">Gets or sets a list of modules that should be added to the organization link  when accepting the invitation.</param>
        /// <param name="sendAsMail">Gets or sets whether to send the one-time invitation as mail</param>
        //[JsonConstructor]
        public OrganizationLinkInvitationRequest(string email, string targetOrganization, Option<List<string>> modules = default, Option<bool> sendAsMail = default)
        {
            Email = email;
            TargetOrganization = targetOrganization;
            ModulesOption = modules;
            SendAsMailOption = sendAsMail;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or sets the email address of the invited organization-user (for accepting the one-time link)
        /// </summary>
        /// <value>Gets or sets the email address of the invited organization-user (for accepting the one-time link)</value>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the name of the target organization
        /// </summary>
        /// <value>Gets or sets the name of the target organization</value>
        [JsonPropertyName("targetOrganization")]
        public string TargetOrganization { get; set; }

        /// <summary>
        /// Used to track the state of Modules
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<List<string>>))]
        public Option<List<string>> ModulesOption { get; private set; }

        /// <summary>
        /// Gets or sets a list of modules that should be added to the organization link  when accepting the invitation.
        /// </summary>
        /// <value>Gets or sets a list of modules that should be added to the organization link  when accepting the invitation.</value>
        [JsonPropertyName("modules")]
        public List<string>? Modules { get { return this. ModulesOption; } set { this.ModulesOption = new Option<List<string>>(value); } }

        /// <summary>
        /// Used to track the state of SendAsMail
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<bool>))]
        public Option<bool> SendAsMailOption { get; private set; }

        /// <summary>
        /// Gets or sets whether to send the one-time invitation as mail
        /// </summary>
        /// <value>Gets or sets whether to send the one-time invitation as mail</value>
        [JsonPropertyName("sendAsMail")]
        public bool? SendAsMail { get { return this. SendAsMailOption; } set { this.SendAsMailOption = new Option<bool>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrganizationLinkInvitationRequest {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  TargetOrganization: ").Append(TargetOrganization).Append("\n");
            sb.Append("  Modules: ").Append(Modules).Append("\n");
            sb.Append("  SendAsMail: ").Append(SendAsMail).Append("\n");
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
    /// A Json converter for type <see cref="OrganizationLinkInvitationRequest" />
    /// </summary>
    public class OrganizationLinkInvitationRequestJsonConverter : JsonConverter<OrganizationLinkInvitationRequest>
    {
        /// <summary>
        /// Deserializes json to <see cref="OrganizationLinkInvitationRequest" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override OrganizationLinkInvitationRequest Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> email = default;
            Option<string> targetOrganization = default;
            Option<List<string>> modules = default;
            Option<bool> sendAsMail = default;

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
                        case "email":
                            email = new Option<string>(utf8JsonReader.GetString()!);
                            break;
                        case "targetOrganization":
                            targetOrganization = new Option<string>(utf8JsonReader.GetString()!);
                            break;
                        case "modules":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                modules = new Option<List<string>>(JsonSerializer.Deserialize<List<string>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "sendAsMail":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                sendAsMail = new Option<bool>(utf8JsonReader.GetBoolean());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!email.IsSet)
                throw new ArgumentException("Property is required for class OrganizationLinkInvitationRequest.", nameof(email));

            if (!targetOrganization.IsSet)
                throw new ArgumentException("Property is required for class OrganizationLinkInvitationRequest.", nameof(targetOrganization));

            if (email.IsSet && email.Value == null)
                throw new ArgumentNullException(nameof(email), "Property is not nullable for class OrganizationLinkInvitationRequest.");

            if (targetOrganization.IsSet && targetOrganization.Value == null)
                throw new ArgumentNullException(nameof(targetOrganization), "Property is not nullable for class OrganizationLinkInvitationRequest.");

            if (sendAsMail.IsSet && sendAsMail.Value == null)
                throw new ArgumentNullException(nameof(sendAsMail), "Property is not nullable for class OrganizationLinkInvitationRequest.");

            //2return new OrganizationLinkInvitationRequest(email.Value!, targetOrganization.Value!, modules, sendAsMail);
            return new OrganizationLinkInvitationRequest(email.Value!, targetOrganization.Value!, modules, sendAsMail);
        }

        /// <summary>
        /// Serializes a <see cref="OrganizationLinkInvitationRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="organizationLinkInvitationRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, OrganizationLinkInvitationRequest organizationLinkInvitationRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, organizationLinkInvitationRequest, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="OrganizationLinkInvitationRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="organizationLinkInvitationRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, OrganizationLinkInvitationRequest organizationLinkInvitationRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            if (organizationLinkInvitationRequest.Email == null)
                throw new ArgumentNullException(nameof(organizationLinkInvitationRequest.Email), "Property is required for class OrganizationLinkInvitationRequest.");

            if (organizationLinkInvitationRequest.TargetOrganization == null)
                throw new ArgumentNullException(nameof(organizationLinkInvitationRequest.TargetOrganization), "Property is required for class OrganizationLinkInvitationRequest.");

            writer.WriteString("email", organizationLinkInvitationRequest.Email);

            writer.WriteString("targetOrganization", organizationLinkInvitationRequest.TargetOrganization);

            if (organizationLinkInvitationRequest.ModulesOption.IsSet)
                if (organizationLinkInvitationRequest.ModulesOption.Value != null)
                {
                    writer.WritePropertyName("modules");
                    JsonSerializer.Serialize(writer, organizationLinkInvitationRequest.Modules, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("modules");
            if (organizationLinkInvitationRequest.SendAsMailOption.IsSet)
                writer.WriteBoolean("sendAsMail", organizationLinkInvitationRequest.SendAsMailOption!.Value);
        }
    }
}
