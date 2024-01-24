// <auto-generated>
/*
 * Simplic.OxS.Document
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

namespace Simplic.OxS.SDK.Document
{
    /// <summary>
    /// DocumentVersionResponse
    /// </summary>
    public partial class DocumentVersionResponse : IValidatableObject
    {

        /// <summary>
        /// Default constructor.
        /// </summary>
        [JsonConstructor]
        public DocumentVersionResponse()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentVersionResponse" /> class.
        /// </summary>
        /// <param name="comment">comment</param>
        /// <param name="fileExtension">fileExtension</param>
        /// <param name="fileSize">fileSize</param>
        /// <param name="id">id</param>
        /// <param name="mimeType">mimeType</param>
        /// <param name="number">number</param>
        /// <param name="url">url</param>
        //[JsonConstructor]
        public DocumentVersionResponse(Option<string> comment = default, Option<string> fileExtension = default, Option<long> fileSize = default, Option<Guid> id = default, Option<string> mimeType = default, Option<int> number = default, Option<string> url = default)
        {
            CommentOption = comment;
            FileExtensionOption = fileExtension;
            FileSizeOption = fileSize;
            IdOption = id;
            MimeTypeOption = mimeType;
            NumberOption = number;
            UrlOption = url;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Comment
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> CommentOption { get; private set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [JsonPropertyName("comment")]
        public string? Comment { get { return this. CommentOption; } set { this.CommentOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of FileExtension
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> FileExtensionOption { get; private set; }

        /// <summary>
        /// Gets or Sets FileExtension
        /// </summary>
        [JsonPropertyName("fileExtension")]
        public string? FileExtension { get { return this. FileExtensionOption; } set { this.FileExtensionOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of FileSize
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<long>))]
        public Option<long> FileSizeOption { get; private set; }

        /// <summary>
        /// Gets or Sets FileSize
        /// </summary>
        [JsonPropertyName("fileSize")]
        public long? FileSize { get { return this. FileSizeOption; } set { this.FileSizeOption = new Option<long>(value); } }

        /// <summary>
        /// Used to track the state of Id
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<Guid>))]
        public Option<Guid> IdOption { get; private set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public Guid? Id { get { return this. IdOption; } set { this.IdOption = new Option<Guid>(value); } }

        /// <summary>
        /// Used to track the state of MimeType
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> MimeTypeOption { get; private set; }

        /// <summary>
        /// Gets or Sets MimeType
        /// </summary>
        [JsonPropertyName("mimeType")]
        public string? MimeType { get { return this. MimeTypeOption; } set { this.MimeTypeOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Number
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<int>))]
        public Option<int> NumberOption { get; private set; }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [JsonPropertyName("number")]
        public int? Number { get { return this. NumberOption; } set { this.NumberOption = new Option<int>(value); } }

        /// <summary>
        /// Used to track the state of Url
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> UrlOption { get; private set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get { return this. UrlOption; } set { this.UrlOption = new Option<string>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DocumentVersionResponse {\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  FileExtension: ").Append(FileExtension).Append("\n");
            sb.Append("  FileSize: ").Append(FileSize).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MimeType: ").Append(MimeType).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
    /// A Json converter for type <see cref="DocumentVersionResponse" />
    /// </summary>
    public class DocumentVersionResponseJsonConverter : JsonConverter<DocumentVersionResponse>
    {
        /// <summary>
        /// Deserializes json to <see cref="DocumentVersionResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override DocumentVersionResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> comment = default;
            Option<string> fileExtension = default;
            Option<long> fileSize = default;
            Option<Guid> id = default;
            Option<string> mimeType = default;
            Option<int> number = default;
            Option<string> url = default;

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
                        case "comment":
                            comment = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "fileExtension":
                            fileExtension = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "fileSize":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                fileSize = new Option<long>(utf8JsonReader.GetInt64());
                            break;
                        case "id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                id = new Option<Guid>(utf8JsonReader.GetGuid());
                            break;
                        case "mimeType":
                            mimeType = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "number":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                number = new Option<int>(utf8JsonReader.GetInt32());
                            break;
                        case "url":
                            url = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (fileSize.IsSet && fileSize.Value == null)
                throw new ArgumentNullException(nameof(fileSize), "Property is not nullable for class DocumentVersionResponse.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class DocumentVersionResponse.");

            if (number.IsSet && number.Value == null)
                throw new ArgumentNullException(nameof(number), "Property is not nullable for class DocumentVersionResponse.");

            //2return new DocumentVersionResponse(comment, fileExtension, fileSize, id, mimeType, number, url);
            return new DocumentVersionResponse(comment, fileExtension, fileSize, id, mimeType, number, url);
        }

        /// <summary>
        /// Serializes a <see cref="DocumentVersionResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="documentVersionResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, DocumentVersionResponse documentVersionResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, documentVersionResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="DocumentVersionResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="documentVersionResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, DocumentVersionResponse documentVersionResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (documentVersionResponse.CommentOption.IsSet)
                if (documentVersionResponse.CommentOption.Value != null)
                {
                    writer.WriteString("comment", documentVersionResponse.Comment);
                    //var __value = documentVersionResponse.CommentOption.Value;
                    //writer.WriteString("comment", __value);
                }
                else
                    writer.WriteNull("comment");

            if (documentVersionResponse.FileExtensionOption.IsSet)
                if (documentVersionResponse.FileExtensionOption.Value != null)
                {
                    writer.WriteString("fileExtension", documentVersionResponse.FileExtension);
                    //var __value = documentVersionResponse.FileExtensionOption.Value;
                    //writer.WriteString("fileExtension", __value);
                }
                else
                    writer.WriteNull("fileExtension");

            if (documentVersionResponse.FileSizeOption.IsSet)
                writer.WriteNumber("fileSize", documentVersionResponse.FileSizeOption!.Value);

            if (documentVersionResponse.IdOption.IsSet)
                writer.WriteString("id", documentVersionResponse.IdOption!.Value);

            if (documentVersionResponse.MimeTypeOption.IsSet)
                if (documentVersionResponse.MimeTypeOption.Value != null)
                {
                    writer.WriteString("mimeType", documentVersionResponse.MimeType);
                    //var __value = documentVersionResponse.MimeTypeOption.Value;
                    //writer.WriteString("mimeType", __value);
                }
                else
                    writer.WriteNull("mimeType");

            if (documentVersionResponse.NumberOption.IsSet)
                writer.WriteNumber("number", documentVersionResponse.NumberOption!.Value);

            if (documentVersionResponse.UrlOption.IsSet)
                if (documentVersionResponse.UrlOption.Value != null)
                {
                    writer.WriteString("url", documentVersionResponse.Url);
                    //var __value = documentVersionResponse.UrlOption.Value;
                    //writer.WriteString("url", __value);
                }
                else
                    writer.WriteNull("url");
        }
    }
}
