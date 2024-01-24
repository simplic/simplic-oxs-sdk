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
    /// Request model for patching shifted planning.
    /// </summary>
    public partial class PatchScheduledPlanningRequest : IValidatableObject
    {

        /// <summary>
        /// Default constructor.
        /// </summary>
        [JsonConstructor]
        public PatchScheduledPlanningRequest()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchScheduledPlanningRequest" /> class.
        /// </summary>
        /// <param name="assignments">Gets or sets the assignments.</param>
        /// <param name="endDate">Gets or sets the end date.</param>
        /// <param name="shiftId">Gets or sets the shift id.</param>
        /// <param name="startDate">Gets or sets the start date.</param>
        //[JsonConstructor]
        public PatchScheduledPlanningRequest(Option<List<ResourceAssignmentPatch>> assignments = default, Option<DateTime> endDate = default, Option<Guid> shiftId = default, Option<DateTime> startDate = default)
        {
            AssignmentsOption = assignments;
            EndDateOption = endDate;
            ShiftIdOption = shiftId;
            StartDateOption = startDate;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Assignments
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<List<ResourceAssignmentPatch>>))]
        public Option<List<ResourceAssignmentPatch>> AssignmentsOption { get; private set; }

        /// <summary>
        /// Gets or sets the assignments.
        /// </summary>
        /// <value>Gets or sets the assignments.</value>
        [JsonPropertyName("assignments")]
        public List<ResourceAssignmentPatch>? Assignments { get { return this. AssignmentsOption; } set { this.AssignmentsOption = new Option<List<ResourceAssignmentPatch>>(value); } }

        /// <summary>
        /// Used to track the state of EndDate
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<DateTime>))]
        public Option<DateTime> EndDateOption { get; private set; }

        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        /// <value>Gets or sets the end date.</value>
        [JsonPropertyName("endDate")]
        public DateTime? EndDate { get { return this. EndDateOption; } set { this.EndDateOption = new Option<DateTime>(value); } }

        /// <summary>
        /// Used to track the state of ShiftId
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<Guid>))]
        public Option<Guid> ShiftIdOption { get; private set; }

        /// <summary>
        /// Gets or sets the shift id.
        /// </summary>
        /// <value>Gets or sets the shift id.</value>
        [JsonPropertyName("shiftId")]
        public Guid? ShiftId { get { return this. ShiftIdOption; } set { this.ShiftIdOption = new Option<Guid>(value); } }

        /// <summary>
        /// Used to track the state of StartDate
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<DateTime>))]
        public Option<DateTime> StartDateOption { get; private set; }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        /// <value>Gets or sets the start date.</value>
        [JsonPropertyName("startDate")]
        public DateTime? StartDate { get { return this. StartDateOption; } set { this.StartDateOption = new Option<DateTime>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PatchScheduledPlanningRequest {\n");
            sb.Append("  Assignments: ").Append(Assignments).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  ShiftId: ").Append(ShiftId).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
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
    /// A Json converter for type <see cref="PatchScheduledPlanningRequest" />
    /// </summary>
    public class PatchScheduledPlanningRequestJsonConverter : JsonConverter<PatchScheduledPlanningRequest>
    {
        /// <summary>
        /// The format to use to serialize EndDate
        /// </summary>
        public static string EndDateFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// The format to use to serialize StartDate
        /// </summary>
        public static string StartDateFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="PatchScheduledPlanningRequest" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PatchScheduledPlanningRequest Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<ResourceAssignmentPatch>> assignments = default;
            Option<DateTime> endDate = default;
            Option<Guid> shiftId = default;
            Option<DateTime> startDate = default;

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
                        case "assignments":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                assignments = new Option<List<ResourceAssignmentPatch>>(JsonSerializer.Deserialize<List<ResourceAssignmentPatch>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "endDate":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                endDate = new Option<DateTime>(JsonSerializer.Deserialize<DateTime?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "shiftId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                shiftId = new Option<Guid>(utf8JsonReader.GetGuid());
                            break;
                        case "startDate":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                startDate = new Option<DateTime>(JsonSerializer.Deserialize<DateTime?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            //2return new PatchScheduledPlanningRequest(assignments, endDate, shiftId, startDate);
            return new PatchScheduledPlanningRequest(assignments, endDate, shiftId, startDate);
        }

        /// <summary>
        /// Serializes a <see cref="PatchScheduledPlanningRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="patchScheduledPlanningRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PatchScheduledPlanningRequest patchScheduledPlanningRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, patchScheduledPlanningRequest, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PatchScheduledPlanningRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="patchScheduledPlanningRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, PatchScheduledPlanningRequest patchScheduledPlanningRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            if (patchScheduledPlanningRequest.AssignmentsOption.IsSet)
                if (patchScheduledPlanningRequest.AssignmentsOption.Value != null)
                {
                    writer.WritePropertyName("assignments");
                    JsonSerializer.Serialize(writer, patchScheduledPlanningRequest.Assignments, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("assignments");
            if (patchScheduledPlanningRequest.EndDateOption.IsSet)
                if (patchScheduledPlanningRequest.EndDateOption.Value != null)
                {
                    writer.WriteString("endDate", patchScheduledPlanningRequest.EndDateOption!.Value.ToString(EndDateFormat));
                    //var __value = patchScheduledPlanningRequest.EndDateOption.Value;
                    //writer.WriteString("endDate", __value);
                }
                else
                    writer.WriteNull("endDate");

            if (patchScheduledPlanningRequest.ShiftIdOption.IsSet)
                if (patchScheduledPlanningRequest.ShiftIdOption.Value != null)
                {
                    writer.WriteString("shiftId", patchScheduledPlanningRequest.ShiftIdOption!.Value);
                    //var __value = patchScheduledPlanningRequest.ShiftIdOption.Value;
                    //writer.WriteString("shiftId", __value);
                }
                else
                    writer.WriteNull("shiftId");

            if (patchScheduledPlanningRequest.StartDateOption.IsSet)
                if (patchScheduledPlanningRequest.StartDateOption.Value != null)
                {
                    writer.WriteString("startDate", patchScheduledPlanningRequest.StartDateOption!.Value.ToString(StartDateFormat));
                    //var __value = patchScheduledPlanningRequest.StartDateOption.Value;
                    //writer.WriteString("startDate", __value);
                }
                else
                    writer.WriteNull("startDate");
        }
    }
}
