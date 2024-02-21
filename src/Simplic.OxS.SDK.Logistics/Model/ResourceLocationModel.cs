/*
 * Simplic.OxS.Logistics
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

namespace Simplic.OxS.SDK.Logistics
{
    /// <summary>
    /// Represents the server model for a resource location.
    /// </summary>
    [DataContract(Name = "ResourceLocationModel")]
    public partial class ResourceLocationModel : IEquatable<ResourceLocationModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceLocationModel" /> class.
        /// </summary>
        /// <param name="latitude">Gets or sets the latitude..</param>
        /// <param name="longitude">Gets or sets the longitude..</param>
        /// <param name="locationSetAt">Gets or sets when the location for the resource is set..</param>
        /// <param name="street">Gets or sets the street..</param>
        /// <param name="houseNumber">Gets or sets the house number..</param>
        /// <param name="zipcode">Gets or sets the zipcode..</param>
        /// <param name="district">Gets or sets the district.</param>
        /// <param name="federalState">Gets or sets the land. E.g. lower saxony or bavaria..</param>
        /// <param name="country">Gets or sets the country..</param>
        /// <param name="countryIso">Gets or sets the country..</param>
        /// <param name="city">Gets or sets the city..</param>
        public ResourceLocationModel(double latitude = default(double), double longitude = default(double), DateTime locationSetAt = default(DateTime), string street = default(string), string houseNumber = default(string), string zipcode = default(string), string district = default(string), string federalState = default(string), string country = default(string), string countryIso = default(string), string city = default(string))
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.LocationSetAt = locationSetAt;
            this.Street = street;
            this.HouseNumber = houseNumber;
            this.Zipcode = zipcode;
            this.District = district;
            this.FederalState = federalState;
            this.Country = country;
            this.CountryIso = countryIso;
            this.City = city;
        }

        /// <summary>
        /// Gets or sets the latitude.
        /// </summary>
        /// <value>Gets or sets the latitude.</value>
        [DataMember(Name = "latitude", EmitDefaultValue = false)]
        public double Latitude { get; set; }

        /// <summary>
        /// Gets or sets the longitude.
        /// </summary>
        /// <value>Gets or sets the longitude.</value>
        [DataMember(Name = "longitude", EmitDefaultValue = false)]
        public double Longitude { get; set; }

        /// <summary>
        /// Gets or sets when the location for the resource is set.
        /// </summary>
        /// <value>Gets or sets when the location for the resource is set.</value>
        [DataMember(Name = "locationSetAt", EmitDefaultValue = false)]
        public DateTime LocationSetAt { get; set; }

        /// <summary>
        /// Gets or sets the street.
        /// </summary>
        /// <value>Gets or sets the street.</value>
        [DataMember(Name = "street", EmitDefaultValue = true)]
        public string Street { get; set; }

        /// <summary>
        /// Gets or sets the house number.
        /// </summary>
        /// <value>Gets or sets the house number.</value>
        [DataMember(Name = "houseNumber", EmitDefaultValue = true)]
        public string HouseNumber { get; set; }

        /// <summary>
        /// Gets or sets the zipcode.
        /// </summary>
        /// <value>Gets or sets the zipcode.</value>
        [DataMember(Name = "zipcode", EmitDefaultValue = true)]
        public string Zipcode { get; set; }

        /// <summary>
        /// Gets or sets the district
        /// </summary>
        /// <value>Gets or sets the district</value>
        [DataMember(Name = "district", EmitDefaultValue = true)]
        public string District { get; set; }

        /// <summary>
        /// Gets or sets the land. E.g. lower saxony or bavaria.
        /// </summary>
        /// <value>Gets or sets the land. E.g. lower saxony or bavaria.</value>
        [DataMember(Name = "federalState", EmitDefaultValue = true)]
        public string FederalState { get; set; }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>Gets or sets the country.</value>
        [DataMember(Name = "country", EmitDefaultValue = true)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>Gets or sets the country.</value>
        [DataMember(Name = "countryIso", EmitDefaultValue = true)]
        public string CountryIso { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>Gets or sets the city.</value>
        [DataMember(Name = "city", EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ResourceLocationModel {\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  LocationSetAt: ").Append(LocationSetAt).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  HouseNumber: ").Append(HouseNumber).Append("\n");
            sb.Append("  Zipcode: ").Append(Zipcode).Append("\n");
            sb.Append("  District: ").Append(District).Append("\n");
            sb.Append("  FederalState: ").Append(FederalState).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  CountryIso: ").Append(CountryIso).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
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
            return this.Equals(input as ResourceLocationModel);
        }

        /// <summary>
        /// Returns true if ResourceLocationModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ResourceLocationModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResourceLocationModel input)
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
                    this.LocationSetAt == input.LocationSetAt ||
                    (this.LocationSetAt != null &&
                    this.LocationSetAt.Equals(input.LocationSetAt))
                ) && 
                (
                    this.Street == input.Street ||
                    (this.Street != null &&
                    this.Street.Equals(input.Street))
                ) && 
                (
                    this.HouseNumber == input.HouseNumber ||
                    (this.HouseNumber != null &&
                    this.HouseNumber.Equals(input.HouseNumber))
                ) && 
                (
                    this.Zipcode == input.Zipcode ||
                    (this.Zipcode != null &&
                    this.Zipcode.Equals(input.Zipcode))
                ) && 
                (
                    this.District == input.District ||
                    (this.District != null &&
                    this.District.Equals(input.District))
                ) && 
                (
                    this.FederalState == input.FederalState ||
                    (this.FederalState != null &&
                    this.FederalState.Equals(input.FederalState))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.CountryIso == input.CountryIso ||
                    (this.CountryIso != null &&
                    this.CountryIso.Equals(input.CountryIso))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
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
                if (this.LocationSetAt != null)
                {
                    hashCode = (hashCode * 59) + this.LocationSetAt.GetHashCode();
                }
                if (this.Street != null)
                {
                    hashCode = (hashCode * 59) + this.Street.GetHashCode();
                }
                if (this.HouseNumber != null)
                {
                    hashCode = (hashCode * 59) + this.HouseNumber.GetHashCode();
                }
                if (this.Zipcode != null)
                {
                    hashCode = (hashCode * 59) + this.Zipcode.GetHashCode();
                }
                if (this.District != null)
                {
                    hashCode = (hashCode * 59) + this.District.GetHashCode();
                }
                if (this.FederalState != null)
                {
                    hashCode = (hashCode * 59) + this.FederalState.GetHashCode();
                }
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                if (this.CountryIso != null)
                {
                    hashCode = (hashCode * 59) + this.CountryIso.GetHashCode();
                }
                if (this.City != null)
                {
                    hashCode = (hashCode * 59) + this.City.GetHashCode();
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