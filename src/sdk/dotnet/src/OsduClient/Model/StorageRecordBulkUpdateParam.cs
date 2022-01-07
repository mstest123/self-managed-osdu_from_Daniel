/* 
 * self-managed-osdu
 *
 * Rest API Documentation for Self Managed OSDU
 *
 * OpenAPI spec version: 0.11.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = OsduClient.Client.SwaggerDateConverter;

namespace OsduClient.Model
{
    /// <summary>
    /// Patch update input information
    /// </summary>
    [DataContract]
    public partial class StorageRecordBulkUpdateParam :  IEquatable<StorageRecordBulkUpdateParam>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageRecordBulkUpdateParam" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StorageRecordBulkUpdateParam() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageRecordBulkUpdateParam" /> class.
        /// </summary>
        /// <param name="query">Patch update query information (required).</param>
        /// <param name="ops">List of operations for records pathc update (required).</param>
        public StorageRecordBulkUpdateParam(StorageRecordQuery query = default(StorageRecordQuery), List<StoragePatchOperation> ops = default(List<StoragePatchOperation>))
        {
            // to ensure "query" is required (not null)
            if (query == null)
            {
                throw new InvalidDataException("query is a required property for StorageRecordBulkUpdateParam and cannot be null");
            }
            else
            {
                this.Query = query;
            }
            // to ensure "ops" is required (not null)
            if (ops == null)
            {
                throw new InvalidDataException("ops is a required property for StorageRecordBulkUpdateParam and cannot be null");
            }
            else
            {
                this.Ops = ops;
            }
        }
        
        /// <summary>
        /// Patch update query information
        /// </summary>
        /// <value>Patch update query information</value>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public StorageRecordQuery Query { get; set; }

        /// <summary>
        /// List of operations for records pathc update
        /// </summary>
        /// <value>List of operations for records pathc update</value>
        [DataMember(Name="ops", EmitDefaultValue=false)]
        public List<StoragePatchOperation> Ops { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StorageRecordBulkUpdateParam {\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  Ops: ").Append(Ops).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as StorageRecordBulkUpdateParam);
        }

        /// <summary>
        /// Returns true if StorageRecordBulkUpdateParam instances are equal
        /// </summary>
        /// <param name="input">Instance of StorageRecordBulkUpdateParam to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StorageRecordBulkUpdateParam input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Query == input.Query ||
                    (this.Query != null &&
                    this.Query.Equals(input.Query))
                ) && 
                (
                    this.Ops == input.Ops ||
                    this.Ops != null &&
                    this.Ops.SequenceEqual(input.Ops)
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
                if (this.Query != null)
                    hashCode = hashCode * 59 + this.Query.GetHashCode();
                if (this.Ops != null)
                    hashCode = hashCode * 59 + this.Ops.GetHashCode();
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
