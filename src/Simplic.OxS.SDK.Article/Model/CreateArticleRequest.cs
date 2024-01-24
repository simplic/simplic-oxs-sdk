// <auto-generated>
/*
 * Simplic.OxS.Article
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

namespace Simplic.OxS.SDK.Article
{
    /// <summary>
    /// CreateArticleRequest
    /// </summary>
    public partial class CreateArticleRequest : IValidatableObject
    {

        /// <summary>
        /// Default constructor.
        /// </summary>
        [JsonConstructor]
        public CreateArticleRequest()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateArticleRequest" /> class.
        /// </summary>
        /// <param name="articleGroupId">articleGroupId</param>
        /// <param name="ean">ean</param>
        /// <param name="fullName">fullName</param>
        /// <param name="number">number</param>
        /// <param name="shortName">shortName</param>
        //[JsonConstructor]
        public CreateArticleRequest(Option<Guid> articleGroupId = default, Option<string> ean = default, Option<string> fullName = default, Option<string> number = default, Option<string> shortName = default)
        {
            ArticleGroupIdOption = articleGroupId;
            EanOption = ean;
            FullNameOption = fullName;
            NumberOption = number;
            ShortNameOption = shortName;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of ArticleGroupId
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<Guid>))]
        public Option<Guid> ArticleGroupIdOption { get; private set; }

        /// <summary>
        /// Gets or Sets ArticleGroupId
        /// </summary>
        [JsonPropertyName("articleGroupId")]
        public Guid? ArticleGroupId { get { return this. ArticleGroupIdOption; } set { this.ArticleGroupIdOption = new Option<Guid>(value); } }

        /// <summary>
        /// Used to track the state of Ean
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> EanOption { get; private set; }

        /// <summary>
        /// Gets or Sets Ean
        /// </summary>
        [JsonPropertyName("ean")]
        public string? Ean { get { return this. EanOption; } set { this.EanOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of FullName
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> FullNameOption { get; private set; }

        /// <summary>
        /// Gets or Sets FullName
        /// </summary>
        [JsonPropertyName("fullName")]
        public string? FullName { get { return this. FullNameOption; } set { this.FullNameOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Number
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> NumberOption { get; private set; }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [JsonPropertyName("number")]
        public string? Number { get { return this. NumberOption; } set { this.NumberOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of ShortName
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> ShortNameOption { get; private set; }

        /// <summary>
        /// Gets or Sets ShortName
        /// </summary>
        [JsonPropertyName("shortName")]
        public string? ShortName { get { return this. ShortNameOption; } set { this.ShortNameOption = new Option<string>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateArticleRequest {\n");
            sb.Append("  ArticleGroupId: ").Append(ArticleGroupId).Append("\n");
            sb.Append("  Ean: ").Append(Ean).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  ShortName: ").Append(ShortName).Append("\n");
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
    /// A Json converter for type <see cref="CreateArticleRequest" />
    /// </summary>
    public class CreateArticleRequestJsonConverter : JsonConverter<CreateArticleRequest>
    {
        /// <summary>
        /// Deserializes json to <see cref="CreateArticleRequest" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override CreateArticleRequest Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<Guid> articleGroupId = default;
            Option<string> ean = default;
            Option<string> fullName = default;
            Option<string> number = default;
            Option<string> shortName = default;

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
                        case "articleGroupId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                articleGroupId = new Option<Guid>(utf8JsonReader.GetGuid());
                            break;
                        case "ean":
                            ean = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "fullName":
                            fullName = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "number":
                            number = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "shortName":
                            shortName = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            //2return new CreateArticleRequest(articleGroupId, ean, fullName, number, shortName);
            return new CreateArticleRequest(articleGroupId, ean, fullName, number, shortName);
        }

        /// <summary>
        /// Serializes a <see cref="CreateArticleRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="createArticleRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, CreateArticleRequest createArticleRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, createArticleRequest, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="CreateArticleRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="createArticleRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, CreateArticleRequest createArticleRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            if (createArticleRequest.ArticleGroupIdOption.IsSet)
                if (createArticleRequest.ArticleGroupIdOption.Value != null)
                {
                    writer.WriteString("articleGroupId", createArticleRequest.ArticleGroupIdOption!.Value);
                    //var __value = createArticleRequest.ArticleGroupIdOption.Value;
                    //writer.WriteString("articleGroupId", __value);
                }
                else
                    writer.WriteNull("articleGroupId");

            if (createArticleRequest.EanOption.IsSet)
                if (createArticleRequest.EanOption.Value != null)
                {
                    writer.WriteString("ean", createArticleRequest.Ean);
                    //var __value = createArticleRequest.EanOption.Value;
                    //writer.WriteString("ean", __value);
                }
                else
                    writer.WriteNull("ean");

            if (createArticleRequest.FullNameOption.IsSet)
                if (createArticleRequest.FullNameOption.Value != null)
                {
                    writer.WriteString("fullName", createArticleRequest.FullName);
                    //var __value = createArticleRequest.FullNameOption.Value;
                    //writer.WriteString("fullName", __value);
                }
                else
                    writer.WriteNull("fullName");

            if (createArticleRequest.NumberOption.IsSet)
                if (createArticleRequest.NumberOption.Value != null)
                {
                    writer.WriteString("number", createArticleRequest.Number);
                    //var __value = createArticleRequest.NumberOption.Value;
                    //writer.WriteString("number", __value);
                }
                else
                    writer.WriteNull("number");

            if (createArticleRequest.ShortNameOption.IsSet)
                if (createArticleRequest.ShortNameOption.Value != null)
                {
                    writer.WriteString("shortName", createArticleRequest.ShortName);
                    //var __value = createArticleRequest.ShortNameOption.Value;
                    //writer.WriteString("shortName", __value);
                }
                else
                    writer.WriteNull("shortName");
        }
    }
}
