// <auto-generated>
/*
 * Simplic.OxS.ERP
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

namespace Simplic.OxS.SDK.ERP
{
    /// <summary>
    /// Defines ExportCostQuantityType
    /// </summary>
    public enum ExportCostQuantityType
    {
        /// <summary>
        /// Enum NUMBER_0 for value: 0
        /// </summary>
        NUMBER_0 = 0,

        /// <summary>
        /// Enum NUMBER_1 for value: 1
        /// </summary>
        NUMBER_1 = 1,

        /// <summary>
        /// Enum NUMBER_2 for value: 2
        /// </summary>
        NUMBER_2 = 2
    }

    /// <summary>
    /// Converts <see cref="ExportCostQuantityType"/> to and from the JSON value
    /// </summary>
    public static class ExportCostQuantityTypeValueConverter
    {
        /// <summary>
        /// Parses a given value to <see cref="ExportCostQuantityType"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static ExportCostQuantityType FromString(string value)
        {
            if (value.Equals((0).ToString()))
                return ExportCostQuantityType.NUMBER_0;

            if (value.Equals((1).ToString()))
                return ExportCostQuantityType.NUMBER_1;

            if (value.Equals((2).ToString()))
                return ExportCostQuantityType.NUMBER_2;

            throw new NotImplementedException($"Could not convert value to type ExportCostQuantityType: '{value}'");
        }

        /// <summary>
        /// Parses a given value to <see cref="ExportCostQuantityType"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static ExportCostQuantityType? FromStringOrDefault(string value)
        {
            if (value.Equals((0).ToString()))
                return ExportCostQuantityType.NUMBER_0;

            if (value.Equals((1).ToString()))
                return ExportCostQuantityType.NUMBER_1;

            if (value.Equals((2).ToString()))
                return ExportCostQuantityType.NUMBER_2;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="ExportCostQuantityType"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static int ToJsonValue(ExportCostQuantityType value)
        {
            return (int) value;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="ExportCostQuantityType"/>
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public class ExportCostQuantityTypeJsonConverter : JsonConverter<ExportCostQuantityType>
    {
        /// <summary>
        /// Returns a  from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override ExportCostQuantityType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            ExportCostQuantityType? result = rawValue == null
                ? null
                : ExportCostQuantityTypeValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the ExportCostQuantityType to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="exportCostQuantityType"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, ExportCostQuantityType exportCostQuantityType, JsonSerializerOptions options)
        {
            writer.WriteStringValue(exportCostQuantityType.ToString());
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="ExportCostQuantityType"/>
    /// </summary>
    public class ExportCostQuantityTypeNullableJsonConverter : JsonConverter<ExportCostQuantityType?>
    {
        /// <summary>
        /// Returns a ExportCostQuantityType from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override ExportCostQuantityType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            ExportCostQuantityType? result = rawValue == null
                ? null
                : ExportCostQuantityTypeValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the DateTime to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="exportCostQuantityType"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, ExportCostQuantityType? exportCostQuantityType, JsonSerializerOptions options)
        {
            writer.WriteStringValue(exportCostQuantityType?.ToString() ?? "null");
        }
    }
}
