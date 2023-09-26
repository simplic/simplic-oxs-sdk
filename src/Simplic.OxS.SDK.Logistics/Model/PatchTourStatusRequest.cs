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
using OpenAPIDateConverter = Simplic.OxS.SDK.Client.OpenAPIDateConverter;

namespace Simplic.OxS.SDK.Logistics.Model
{
    /// <summary>
    /// Represents a request to create a tour status.
    /// </summary>
    [DataContract(Name = "PatchTourStatusRequest")]
    public partial class PatchTourStatusRequest : IEquatable<PatchTourStatusRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTourStatusRequest" /> class.
        /// </summary>
        /// <param name="name">Gets or sets the namme of the status..</param>
        /// <param name="number">Gets or sets the number of the status.  &lt;br&gt;  The number is a human readable short name or number of the status.  .</param>
        /// <param name="roles">Gets or sets roles.  &lt;br&gt;  These roles will decide whether tours with the status can or can not to certain things.    A list of available roles at the moment:  &lt;list type&#x3D;\&quot;bullet\&quot;&gt;&lt;item&gt;is_default&lt;/item&gt;&lt;item&gt;disable_edit&lt;/item&gt;&lt;item&gt;disable_delete&lt;/item&gt;&lt;/list&gt;.</param>
        /// <param name="hexColor">Gets or sets the hex color.  &lt;br&gt;  Will define the color of the status as hex code.  .</param>
        /// <param name="orderNr">Gets or sets the order number.  &lt;br&gt;  The order nr will define in which order the statuses are resolved.     The lowest value will always be resolved first..</param>
        /// <param name="resolver">Gets or sets the resolver name.  &lt;br&gt;  The name of the resolver is also the name which the resolver is registererd.     Within the resolving of the status the service will try to find a resolver with the given name..</param>
        public PatchTourStatusRequest(string name = default(string), string number = default(string), List<string> roles = default(List<string>), string hexColor = default(string), int? orderNr = default(int?), string resolver = default(string))
        {
            this.Name = name;
            this.Number = number;
            this.Roles = roles;
            this.HexColor = hexColor;
            this.OrderNr = orderNr;
            this.Resolver = resolver;
        }

        /// <summary>
        /// Gets or sets the namme of the status.
        /// </summary>
        /// <value>Gets or sets the namme of the status.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the number of the status.  &lt;br&gt;  The number is a human readable short name or number of the status.  
        /// </summary>
        /// <value>Gets or sets the number of the status.  &lt;br&gt;  The number is a human readable short name or number of the status.  </value>
        [DataMember(Name = "number", EmitDefaultValue = true)]
        public string Number { get; set; }

        /// <summary>
        /// Gets or sets roles.  &lt;br&gt;  These roles will decide whether tours with the status can or can not to certain things.    A list of available roles at the moment:  &lt;list type&#x3D;\&quot;bullet\&quot;&gt;&lt;item&gt;is_default&lt;/item&gt;&lt;item&gt;disable_edit&lt;/item&gt;&lt;item&gt;disable_delete&lt;/item&gt;&lt;/list&gt;
        /// </summary>
        /// <value>Gets or sets roles.  &lt;br&gt;  These roles will decide whether tours with the status can or can not to certain things.    A list of available roles at the moment:  &lt;list type&#x3D;\&quot;bullet\&quot;&gt;&lt;item&gt;is_default&lt;/item&gt;&lt;item&gt;disable_edit&lt;/item&gt;&lt;item&gt;disable_delete&lt;/item&gt;&lt;/list&gt;</value>
        [DataMember(Name = "roles", EmitDefaultValue = true)]
        public List<string> Roles { get; set; }

        /// <summary>
        /// Gets or sets the hex color.  &lt;br&gt;  Will define the color of the status as hex code.  
        /// </summary>
        /// <value>Gets or sets the hex color.  &lt;br&gt;  Will define the color of the status as hex code.  </value>
        [DataMember(Name = "hexColor", EmitDefaultValue = true)]
        public string HexColor { get; set; }

        /// <summary>
        /// Gets or sets the order number.  &lt;br&gt;  The order nr will define in which order the statuses are resolved.     The lowest value will always be resolved first.
        /// </summary>
        /// <value>Gets or sets the order number.  &lt;br&gt;  The order nr will define in which order the statuses are resolved.     The lowest value will always be resolved first.</value>
        [DataMember(Name = "orderNr", EmitDefaultValue = true)]
        public int? OrderNr { get; set; }

        /// <summary>
        /// Gets or sets the resolver name.  &lt;br&gt;  The name of the resolver is also the name which the resolver is registererd.     Within the resolving of the status the service will try to find a resolver with the given name.
        /// </summary>
        /// <value>Gets or sets the resolver name.  &lt;br&gt;  The name of the resolver is also the name which the resolver is registererd.     Within the resolving of the status the service will try to find a resolver with the given name.</value>
        [DataMember(Name = "resolver", EmitDefaultValue = true)]
        public string Resolver { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PatchTourStatusRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  HexColor: ").Append(HexColor).Append("\n");
            sb.Append("  OrderNr: ").Append(OrderNr).Append("\n");
            sb.Append("  Resolver: ").Append(Resolver).Append("\n");
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
            return this.Equals(input as PatchTourStatusRequest);
        }

        /// <summary>
        /// Returns true if PatchTourStatusRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PatchTourStatusRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatchTourStatusRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    input.Roles != null &&
                    this.Roles.SequenceEqual(input.Roles)
                ) && 
                (
                    this.HexColor == input.HexColor ||
                    (this.HexColor != null &&
                    this.HexColor.Equals(input.HexColor))
                ) && 
                (
                    this.OrderNr == input.OrderNr ||
                    (this.OrderNr != null &&
                    this.OrderNr.Equals(input.OrderNr))
                ) && 
                (
                    this.Resolver == input.Resolver ||
                    (this.Resolver != null &&
                    this.Resolver.Equals(input.Resolver))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Number != null)
                {
                    hashCode = (hashCode * 59) + this.Number.GetHashCode();
                }
                if (this.Roles != null)
                {
                    hashCode = (hashCode * 59) + this.Roles.GetHashCode();
                }
                if (this.HexColor != null)
                {
                    hashCode = (hashCode * 59) + this.HexColor.GetHashCode();
                }
                if (this.OrderNr != null)
                {
                    hashCode = (hashCode * 59) + this.OrderNr.GetHashCode();
                }
                if (this.Resolver != null)
                {
                    hashCode = (hashCode * 59) + this.Resolver.GetHashCode();
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
