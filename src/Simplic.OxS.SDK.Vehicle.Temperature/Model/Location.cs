/*
 * Simplic.OxS.vehicle-temperature
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Simplic.OxS.SDK.OpenAPIDateConverter;

using Simplic.OxS.SDK;

namespace Simplic.OxS.SDK.Vehicle.Temperature
{
    /// <summary>
    /// Location
    /// </summary>
    [DataContract(Name = "Location")]
    public partial class Location : IEquatable<Location>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Location" /> class.
        /// </summary>
        /// <param name="latitude">latitude.</param>
        /// <param name="longitude">longitude.</param>
        /// <param name="street">street.</param>
        /// <param name="zipCode">zipCode.</param>
        /// <param name="city">city.</param>
        /// <param name="countryIso">countryIso.</param>
        /// <param name="houseNumber">houseNumber.</param>
        public Location(double latitude = default(double), double longitude = default(double), string street = default(string), string zipCode = default(string), string city = default(string), string countryIso = default(string), string houseNumber = default(string))
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Street = street;
            this.ZipCode = zipCode;
            this.City = city;
            this.CountryIso = countryIso;
            this.HouseNumber = houseNumber;
        }

        /// <summary>
        /// Gets or Sets Latitude
        /// </summary>
        [DataMember(Name = "latitude", EmitDefaultValue = false)]
        public double Latitude { get; set; }

        /// <summary>
        /// Gets or Sets Longitude
        /// </summary>
        [DataMember(Name = "longitude", EmitDefaultValue = false)]
        public double Longitude { get; set; }

        /// <summary>
        /// Gets or Sets Street
        /// </summary>
        [DataMember(Name = "street", EmitDefaultValue = true)]
        public string Street { get; set; }

        /// <summary>
        /// Gets or Sets ZipCode
        /// </summary>
        [DataMember(Name = "zipCode", EmitDefaultValue = true)]
        public string ZipCode { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name = "city", EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets CountryIso
        /// </summary>
        [DataMember(Name = "countryIso", EmitDefaultValue = true)]
        public string CountryIso { get; set; }

        /// <summary>
        /// Gets or Sets HouseNumber
        /// </summary>
        [DataMember(Name = "houseNumber", EmitDefaultValue = true)]
        public string HouseNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Location {\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  ZipCode: ").Append(ZipCode).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  CountryIso: ").Append(CountryIso).Append("\n");
            sb.Append("  HouseNumber: ").Append(HouseNumber).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Location);
        }

        /// <summary>
        /// Returns true if Location instances are equal
        /// </summary>
        /// <param name="input">Instance of Location to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Location input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Latitude == input.Latitude ||
                    this.Latitude.Equals(input.Latitude)
                ) && 
                (
                    this.Longitude == input.Longitude ||
                    this.Longitude.Equals(input.Longitude)
                ) && 
                (
                    this.Street == input.Street ||
                    (this.Street != null &&
                    this.Street.Equals(input.Street))
                ) && 
                (
                    this.ZipCode == input.ZipCode ||
                    (this.ZipCode != null &&
                    this.ZipCode.Equals(input.ZipCode))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.CountryIso == input.CountryIso ||
                    (this.CountryIso != null &&
                    this.CountryIso.Equals(input.CountryIso))
                ) && 
                (
                    this.HouseNumber == input.HouseNumber ||
                    (this.HouseNumber != null &&
                    this.HouseNumber.Equals(input.HouseNumber))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.Latitude.GetHashCode();
                hashCode = (hashCode * 59) + this.Longitude.GetHashCode();
                if (this.Street != null)
                {
                    hashCode = (hashCode * 59) + this.Street.GetHashCode();
                }
                if (this.ZipCode != null)
                {
                    hashCode = (hashCode * 59) + this.ZipCode.GetHashCode();
                }
                if (this.City != null)
                {
                    hashCode = (hashCode * 59) + this.City.GetHashCode();
                }
                if (this.CountryIso != null)
                {
                    hashCode = (hashCode * 59) + this.CountryIso.GetHashCode();
                }
                if (this.HouseNumber != null)
                {
                    hashCode = (hashCode * 59) + this.HouseNumber.GetHashCode();
                }
                return hashCode;
            }
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

}