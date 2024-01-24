// <auto-generated>
/*
 * Simplic.OxS.Logistics
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

namespace Simplic.OxS.SDK.Logistics
{
    /// <summary>
    /// Request model for posting shifts.
    /// </summary>
    public partial class PostShiftRequest : IValidatableObject
    {

        /// <summary>
        /// Default constructor.
        /// </summary>
        [JsonConstructor]
        public PostShiftRequest()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostShiftRequest" /> class.
        /// </summary>
        /// <param name="endTime">Gets or sets the end time.</param>
        /// <param name="name">Gets or sets the name.</param>
        /// <param name="startTime">Gets or sets the start time.</param>
        //[JsonConstructor]
        public PostShiftRequest(Option<string> endTime = default, Option<string> name = default, Option<string> startTime = default)
        {
            EndTimeOption = endTime;
            NameOption = name;
            StartTimeOption = startTime;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of EndTime
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> EndTimeOption { get; private set; }

        /// <summary>
        /// Gets or sets the end time.
        /// </summary>
        /// <value>Gets or sets the end time.</value>
        [JsonPropertyName("endTime")]
        public string? EndTime { get { return this. EndTimeOption; } set { this.EndTimeOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Name
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> NameOption { get; private set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>Gets or sets the name.</value>
        [JsonPropertyName("name")]
        public string? Name { get { return this. NameOption; } set { this.NameOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of StartTime
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> StartTimeOption { get; private set; }

        /// <summary>
        /// Gets or sets the start time.
        /// </summary>
        /// <value>Gets or sets the start time.</value>
        [JsonPropertyName("startTime")]
        public string? StartTime { get { return this. StartTimeOption; } set { this.StartTimeOption = new Option<string>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PostShiftRequest {\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
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
    /// A Json converter for type <see cref="PostShiftRequest" />
    /// </summary>
    public class PostShiftRequestJsonConverter : JsonConverter<PostShiftRequest>
    {
        /// <summary>
        /// Deserializes json to <see cref="PostShiftRequest" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PostShiftRequest Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> endTime = default;
            Option<string> name = default;
            Option<string> startTime = default;

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
                        case "endTime":
                            endTime = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "name":
                            name = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "startTime":
                            startTime = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            //2return new PostShiftRequest(endTime, name, startTime);
            return new PostShiftRequest(endTime, name, startTime);
        }

        /// <summary>
        /// Serializes a <see cref="PostShiftRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="postShiftRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PostShiftRequest postShiftRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, postShiftRequest, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PostShiftRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="postShiftRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, PostShiftRequest postShiftRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            if (postShiftRequest.EndTimeOption.IsSet)
                if (postShiftRequest.EndTimeOption.Value != null)
                {
                    writer.WriteString("endTime", postShiftRequest.EndTime);
                    //var __value = postShiftRequest.EndTimeOption.Value;
                    //writer.WriteString("endTime", __value);
                }
                else
                    writer.WriteNull("endTime");

            if (postShiftRequest.NameOption.IsSet)
                if (postShiftRequest.NameOption.Value != null)
                {
                    writer.WriteString("name", postShiftRequest.Name);
                    //var __value = postShiftRequest.NameOption.Value;
                    //writer.WriteString("name", __value);
                }
                else
                    writer.WriteNull("name");

            if (postShiftRequest.StartTimeOption.IsSet)
                if (postShiftRequest.StartTimeOption.Value != null)
                {
                    writer.WriteString("startTime", postShiftRequest.StartTime);
                    //var __value = postShiftRequest.StartTimeOption.Value;
                    //writer.WriteString("startTime", __value);
                }
                else
                    writer.WriteNull("startTime");
        }
    }
}
