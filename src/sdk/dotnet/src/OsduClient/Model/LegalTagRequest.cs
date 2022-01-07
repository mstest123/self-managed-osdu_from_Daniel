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
    /// The model to retrieve multiple LegalTags in batch.
    /// </summary>
    [DataContract]
    public partial class LegalTagRequest :  IEquatable<LegalTagRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LegalTagRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LegalTagRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LegalTagRequest" /> class.
        /// </summary>
        /// <param name="names">The name of all the LegalTags to retrieve. (required).</param>
        public LegalTagRequest(List<string> names = default(List<string>))
        {
            // to ensure "names" is required (not null)
            if (names == null)
            {
                throw new InvalidDataException("names is a required property for LegalTagRequest and cannot be null");
            }
            else
            {
                this.Names = names;
            }
        }
        
        /// <summary>
        /// The name of all the LegalTags to retrieve.
        /// </summary>
        /// <value>The name of all the LegalTags to retrieve.</value>
        [DataMember(Name="names", EmitDefaultValue=false)]
        public List<string> Names { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LegalTagRequest {\n");
            sb.Append("  Names: ").Append(Names).Append("\n");
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
            return this.Equals(input as LegalTagRequest);
        }

        /// <summary>
        /// Returns true if LegalTagRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of LegalTagRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LegalTagRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Names == input.Names ||
                    this.Names != null &&
                    this.Names.SequenceEqual(input.Names)
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
                if (this.Names != null)
                    hashCode = hashCode * 59 + this.Names.GetHashCode();
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
