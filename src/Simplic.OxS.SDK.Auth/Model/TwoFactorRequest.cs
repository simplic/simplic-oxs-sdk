// <auto-generated>
/*
 * Simplic.OxS.Auth
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

namespace Simplic.OxS.SDK.Auth
{
    /// <summary>
    /// TwoFactorRequest
    /// </summary>
    public partial class TwoFactorRequest : IValidatableObject
    {

        /// <summary>
        /// Default constructor.
        /// </summary>
        [JsonConstructor]
        public TwoFactorRequest()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TwoFactorRequest" /> class.
        /// </summary>
        /// <param name="code">Gets or sets the verification code</param>
        /// <param name="tokenId">Gets or sets the token to verify</param>
        //[JsonConstructor]
        public TwoFactorRequest(Option<string> code = default, Option<Guid> tokenId = default)
        {
            CodeOption = code;
            TokenIdOption = tokenId;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Code
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> CodeOption { get; private set; }

        /// <summary>
        /// Gets or sets the verification code
        /// </summary>
        /// <value>Gets or sets the verification code</value>
        [JsonPropertyName("code")]
        public string? Code { get { return this. CodeOption; } set { this.CodeOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of TokenId
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<Guid>))]
        public Option<Guid> TokenIdOption { get; private set; }

        /// <summary>
        /// Gets or sets the token to verify
        /// </summary>
        /// <value>Gets or sets the token to verify</value>
        [JsonPropertyName("tokenId")]
        public Guid? TokenId { get { return this. TokenIdOption; } set { this.TokenIdOption = new Option<Guid>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TwoFactorRequest {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  TokenId: ").Append(TokenId).Append("\n");
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
    /// A Json converter for type <see cref="TwoFactorRequest" />
    /// </summary>
    public class TwoFactorRequestJsonConverter : JsonConverter<TwoFactorRequest>
    {
        /// <summary>
        /// Deserializes json to <see cref="TwoFactorRequest" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TwoFactorRequest Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> code = default;
            Option<Guid> tokenId = default;

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
                        case "code":
                            code = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "tokenId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                tokenId = new Option<Guid>(utf8JsonReader.GetGuid());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (tokenId.IsSet && tokenId.Value == null)
                throw new ArgumentNullException(nameof(tokenId), "Property is not nullable for class TwoFactorRequest.");

            //2return new TwoFactorRequest(code, tokenId);
            return new TwoFactorRequest(code, tokenId);
        }

        /// <summary>
        /// Serializes a <see cref="TwoFactorRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="twoFactorRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TwoFactorRequest twoFactorRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, twoFactorRequest, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TwoFactorRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="twoFactorRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, TwoFactorRequest twoFactorRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            if (twoFactorRequest.CodeOption.IsSet)
                if (twoFactorRequest.CodeOption.Value != null)
                {
                    writer.WriteString("code", twoFactorRequest.Code);
                    //var __value = twoFactorRequest.CodeOption.Value;
                    //writer.WriteString("code", __value);
                }
                else
                    writer.WriteNull("code");

            if (twoFactorRequest.TokenIdOption.IsSet)
                writer.WriteString("tokenId", twoFactorRequest.TokenIdOption!.Value);
        }
    }
}
