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
    /// Schema info including status, creation and schemaIdentity
    /// </summary>
    [DataContract]
    public partial class SchemaInfo :  IEquatable<SchemaInfo>, IValidatableObject
    {
        /// <summary>
        /// Schema Scope - is it internal or shared. This is a system defined attribute based on partition-id passed.
        /// </summary>
        /// <value>Schema Scope - is it internal or shared. This is a system defined attribute based on partition-id passed.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ScopeEnum
        {
            
            /// <summary>
            /// Enum INTERNAL for value: INTERNAL
            /// </summary>
            [EnumMember(Value = "INTERNAL")]
            INTERNAL = 1,
            
            /// <summary>
            /// Enum SHARED for value: SHARED
            /// </summary>
            [EnumMember(Value = "SHARED")]
            SHARED = 2
        }

        /// <summary>
        /// Schema Scope - is it internal or shared. This is a system defined attribute based on partition-id passed.
        /// </summary>
        /// <value>Schema Scope - is it internal or shared. This is a system defined attribute based on partition-id passed.</value>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public ScopeEnum? Scope { get; set; }
        /// <summary>
        /// Schema lifecycle status
        /// </summary>
        /// <value>Schema lifecycle status</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum PUBLISHED for value: PUBLISHED
            /// </summary>
            [EnumMember(Value = "PUBLISHED")]
            PUBLISHED = 1,
            
            /// <summary>
            /// Enum OBSOLETE for value: OBSOLETE
            /// </summary>
            [EnumMember(Value = "OBSOLETE")]
            OBSOLETE = 2,
            
            /// <summary>
            /// Enum DEVELOPMENT for value: DEVELOPMENT
            /// </summary>
            [EnumMember(Value = "DEVELOPMENT")]
            DEVELOPMENT = 3
        }

        /// <summary>
        /// Schema lifecycle status
        /// </summary>
        /// <value>Schema lifecycle status</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SchemaInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaInfo" /> class.
        /// </summary>
        /// <param name="createdBy">The user who created the schema. This value is taken from API caller token..</param>
        /// <param name="dateCreated">The UTC date time of the entity creation.</param>
        /// <param name="schemaIdentity">schemaIdentity (required).</param>
        /// <param name="scope">Schema Scope - is it internal or shared. This is a system defined attribute based on partition-id passed..</param>
        /// <param name="status">Schema lifecycle status (required).</param>
        /// <param name="supersededBy">supersededBy.</param>
        public SchemaInfo(string createdBy = default(string), DateTime? dateCreated = default(DateTime?), SchemaIdentity schemaIdentity = default(SchemaIdentity), ScopeEnum? scope = default(ScopeEnum?), StatusEnum status = default(StatusEnum), SchemaIdentity supersededBy = default(SchemaIdentity))
        {
            // to ensure "schemaIdentity" is required (not null)
            if (schemaIdentity == null)
            {
                throw new InvalidDataException("schemaIdentity is a required property for SchemaInfo and cannot be null");
            }
            else
            {
                this.SchemaIdentity = schemaIdentity;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for SchemaInfo and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            this.CreatedBy = createdBy;
            this.DateCreated = dateCreated;
            this.Scope = scope;
            this.SupersededBy = supersededBy;
        }
        
        /// <summary>
        /// The user who created the schema. This value is taken from API caller token.
        /// </summary>
        /// <value>The user who created the schema. This value is taken from API caller token.</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// The UTC date time of the entity creation
        /// </summary>
        /// <value>The UTC date time of the entity creation</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// Gets or Sets SchemaIdentity
        /// </summary>
        [DataMember(Name="schemaIdentity", EmitDefaultValue=false)]
        public SchemaIdentity SchemaIdentity { get; set; }



        /// <summary>
        /// Gets or Sets SupersededBy
        /// </summary>
        [DataMember(Name="supersededBy", EmitDefaultValue=false)]
        public SchemaIdentity SupersededBy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SchemaInfo {\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  SchemaIdentity: ").Append(SchemaIdentity).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SupersededBy: ").Append(SupersededBy).Append("\n");
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
            return this.Equals(input as SchemaInfo);
        }

        /// <summary>
        /// Returns true if SchemaInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of SchemaInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SchemaInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.DateCreated == input.DateCreated ||
                    (this.DateCreated != null &&
                    this.DateCreated.Equals(input.DateCreated))
                ) && 
                (
                    this.SchemaIdentity == input.SchemaIdentity ||
                    (this.SchemaIdentity != null &&
                    this.SchemaIdentity.Equals(input.SchemaIdentity))
                ) && 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.SupersededBy == input.SupersededBy ||
                    (this.SupersededBy != null &&
                    this.SupersededBy.Equals(input.SupersededBy))
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
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.DateCreated != null)
                    hashCode = hashCode * 59 + this.DateCreated.GetHashCode();
                if (this.SchemaIdentity != null)
                    hashCode = hashCode * 59 + this.SchemaIdentity.GetHashCode();
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.SupersededBy != null)
                    hashCode = hashCode * 59 + this.SupersededBy.GetHashCode();
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
