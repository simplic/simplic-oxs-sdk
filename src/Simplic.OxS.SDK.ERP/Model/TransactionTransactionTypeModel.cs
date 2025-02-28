/*
 * Simplic.OxS.ERP
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

namespace Simplic.OxS.SDK.ERP
{
    /// <summary>
    /// Represents the shared model for a transaction type in a transaction.
    /// </summary>
    [DataContract(Name = "TransactionTransactionTypeModel")]
    public partial class TransactionTransactionTypeModel : IEquatable<TransactionTransactionTypeModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionTransactionTypeModel" /> class.
        /// </summary>
        /// <param name="id">Gets or sets the ID..</param>
        /// <param name="name">Gets or sets the name..</param>
        /// <param name="number">Gets or sets the number..</param>
        /// <param name="reportName">Gets or sets the report title..</param>
        /// <param name="shortName">Gets or sets the short name..</param>
        /// <param name="functions">Gets or sets a set of functions the transaction type has.  &lt;br&gt;  Examples for functions are: credit, debit, cancellation, incoming, outgoing, accounting_exportable, standing_order, workshop_order  .</param>
        /// <param name="subtype">subtype.</param>
        public TransactionTransactionTypeModel(Guid id = default(Guid), string name = default(string), int number = default(int), string reportName = default(string), string shortName = default(string), List<string> functions = default(List<string>), TransactionSubtypeModel subtype = default(TransactionSubtypeModel))
        {
            this.Id = id;
            this.Name = name;
            this.Number = number;
            this.ReportName = reportName;
            this.ShortName = shortName;
            this.Functions = functions;
            this.Subtype = subtype;
        }

        /// <summary>
        /// Gets or sets the ID.
        /// </summary>
        /// <value>Gets or sets the ID.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>Gets or sets the name.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        /// <value>Gets or sets the number.</value>
        [DataMember(Name = "number", EmitDefaultValue = false)]
        public int Number { get; set; }

        /// <summary>
        /// Gets or sets the report title.
        /// </summary>
        /// <value>Gets or sets the report title.</value>
        [DataMember(Name = "reportName", EmitDefaultValue = true)]
        public string ReportName { get; set; }

        /// <summary>
        /// Gets or sets the short name.
        /// </summary>
        /// <value>Gets or sets the short name.</value>
        [DataMember(Name = "shortName", EmitDefaultValue = true)]
        public string ShortName { get; set; }

        /// <summary>
        /// Gets or sets a set of functions the transaction type has.  &lt;br&gt;  Examples for functions are: credit, debit, cancellation, incoming, outgoing, accounting_exportable, standing_order, workshop_order  
        /// </summary>
        /// <value>Gets or sets a set of functions the transaction type has.  &lt;br&gt;  Examples for functions are: credit, debit, cancellation, incoming, outgoing, accounting_exportable, standing_order, workshop_order  </value>
        [DataMember(Name = "functions", EmitDefaultValue = true)]
        public List<string> Functions { get; set; }

        /// <summary>
        /// Gets or Sets Subtype
        /// </summary>
        [DataMember(Name = "subtype", EmitDefaultValue = false)]
        public TransactionSubtypeModel Subtype { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionTransactionTypeModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  ReportName: ").Append(ReportName).Append("\n");
            sb.Append("  ShortName: ").Append(ShortName).Append("\n");
            sb.Append("  Functions: ").Append(Functions).Append("\n");
            sb.Append("  Subtype: ").Append(Subtype).Append("\n");
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
            return this.Equals(input as TransactionTransactionTypeModel);
        }

        /// <summary>
        /// Returns true if TransactionTransactionTypeModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionTransactionTypeModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionTransactionTypeModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Number == input.Number ||
                    this.Number.Equals(input.Number)
                ) && 
                (
                    this.ReportName == input.ReportName ||
                    (this.ReportName != null &&
                    this.ReportName.Equals(input.ReportName))
                ) && 
                (
                    this.ShortName == input.ShortName ||
                    (this.ShortName != null &&
                    this.ShortName.Equals(input.ShortName))
                ) && 
                (
                    this.Functions == input.Functions ||
                    this.Functions != null &&
                    input.Functions != null &&
                    this.Functions.SequenceEqual(input.Functions)
                ) && 
                (
                    this.Subtype == input.Subtype ||
                    (this.Subtype != null &&
                    this.Subtype.Equals(input.Subtype))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Number.GetHashCode();
                if (this.ReportName != null)
                {
                    hashCode = (hashCode * 59) + this.ReportName.GetHashCode();
                }
                if (this.ShortName != null)
                {
                    hashCode = (hashCode * 59) + this.ShortName.GetHashCode();
                }
                if (this.Functions != null)
                {
                    hashCode = (hashCode * 59) + this.Functions.GetHashCode();
                }
                if (this.Subtype != null)
                {
                    hashCode = (hashCode * 59) + this.Subtype.GetHashCode();
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
