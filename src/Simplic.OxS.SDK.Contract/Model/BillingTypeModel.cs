// <auto-generated>
/*
 * Simplic.OxS.Contract
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

namespace Simplic.OxS.SDK.Contract
{
    /// <summary>
    /// Defines BillingTypeModel
    /// </summary>
    public enum BillingTypeModel
    {
        /// <summary>
        /// Enum NUMBER_0 for value: 0
        /// </summary>
        NUMBER_0 = 0,

        /// <summary>
        /// Enum NUMBER_1 for value: 1
        /// </summary>
        NUMBER_1 = 1
    }

    /// <summary>
    /// Converts <see cref="BillingTypeModel"/> to and from the JSON value
    /// </summary>
    public static class BillingTypeModelValueConverter
    {
        /// <summary>
        /// Parses a given value to <see cref="BillingTypeModel"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static BillingTypeModel FromString(string value)
        {
            if (value.Equals((0).ToString()))
                return BillingTypeModel.NUMBER_0;

            if (value.Equals((1).ToString()))
                return BillingTypeModel.NUMBER_1;

            throw new NotImplementedException($"Could not convert value to type BillingTypeModel: '{value}'");
        }

        /// <summary>
        /// Parses a given value to <see cref="BillingTypeModel"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static BillingTypeModel? FromStringOrDefault(string value)
        {
            if (value.Equals((0).ToString()))
                return BillingTypeModel.NUMBER_0;

            if (value.Equals((1).ToString()))
                return BillingTypeModel.NUMBER_1;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="BillingTypeModel"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static int ToJsonValue(BillingTypeModel value)
        {
            return (int) value;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="BillingTypeModel"/>
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public class BillingTypeModelJsonConverter : JsonConverter<BillingTypeModel>
    {
        /// <summary>
        /// Returns a  from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override BillingTypeModel Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            BillingTypeModel? result = rawValue == null
                ? null
                : BillingTypeModelValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the BillingTypeModel to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="billingTypeModel"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, BillingTypeModel billingTypeModel, JsonSerializerOptions options)
        {
            writer.WriteStringValue(billingTypeModel.ToString());
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="BillingTypeModel"/>
    /// </summary>
    public class BillingTypeModelNullableJsonConverter : JsonConverter<BillingTypeModel?>
    {
        /// <summary>
        /// Returns a BillingTypeModel from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override BillingTypeModel? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            BillingTypeModel? result = rawValue == null
                ? null
                : BillingTypeModelValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the DateTime to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="billingTypeModel"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, BillingTypeModel? billingTypeModel, JsonSerializerOptions options)
        {
            writer.WriteStringValue(billingTypeModel?.ToString() ?? "null");
        }
    }
}
