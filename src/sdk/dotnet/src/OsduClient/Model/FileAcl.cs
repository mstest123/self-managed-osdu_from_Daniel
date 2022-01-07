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
    /// FileAcl
    /// </summary>
    [DataContract]
    public partial class FileAcl :  IEquatable<FileAcl>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileAcl" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FileAcl() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileAcl" /> class.
        /// </summary>
        /// <param name="viewers">List of valid groups which will have view/read privileges over the record. (required).</param>
        /// <param name="owners">List of valid groups which will have write privileges over the record. (required).</param>
        public FileAcl(List<string> viewers = default(List<string>), List<string> owners = default(List<string>))
        {
            // to ensure "viewers" is required (not null)
            if (viewers == null)
            {
                throw new InvalidDataException("viewers is a required property for FileAcl and cannot be null");
            }
            else
            {
                this.Viewers = viewers;
            }
            // to ensure "owners" is required (not null)
            if (owners == null)
            {
                throw new InvalidDataException("owners is a required property for FileAcl and cannot be null");
            }
            else
            {
                this.Owners = owners;
            }
        }
        
        /// <summary>
        /// List of valid groups which will have view/read privileges over the record.
        /// </summary>
        /// <value>List of valid groups which will have view/read privileges over the record.</value>
        [DataMember(Name="viewers", EmitDefaultValue=false)]
        public List<string> Viewers { get; set; }

        /// <summary>
        /// List of valid groups which will have write privileges over the record.
        /// </summary>
        /// <value>List of valid groups which will have write privileges over the record.</value>
        [DataMember(Name="owners", EmitDefaultValue=false)]
        public List<string> Owners { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileAcl {\n");
            sb.Append("  Viewers: ").Append(Viewers).Append("\n");
            sb.Append("  Owners: ").Append(Owners).Append("\n");
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
            return this.Equals(input as FileAcl);
        }

        /// <summary>
        /// Returns true if FileAcl instances are equal
        /// </summary>
        /// <param name="input">Instance of FileAcl to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileAcl input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Viewers == input.Viewers ||
                    this.Viewers != null &&
                    this.Viewers.SequenceEqual(input.Viewers)
                ) && 
                (
                    this.Owners == input.Owners ||
                    this.Owners != null &&
                    this.Owners.SequenceEqual(input.Owners)
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
                if (this.Viewers != null)
                    hashCode = hashCode * 59 + this.Viewers.GetHashCode();
                if (this.Owners != null)
                    hashCode = hashCode * 59 + this.Owners.GetHashCode();
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
