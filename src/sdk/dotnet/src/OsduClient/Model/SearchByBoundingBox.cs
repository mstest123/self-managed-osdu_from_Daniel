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
    /// A spatial filter criteria to allow to filter documents based on a point location within a bounding box.
    /// </summary>
    [DataContract]
    public partial class SearchByBoundingBox :  IEquatable<SearchByBoundingBox>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchByBoundingBox" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SearchByBoundingBox() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchByBoundingBox" /> class.
        /// </summary>
        /// <param name="topLeft">topLeft (required).</param>
        /// <param name="bottomRight">bottomRight (required).</param>
        public SearchByBoundingBox(SearchPoint topLeft = default(SearchPoint), SearchPoint bottomRight = default(SearchPoint))
        {
            // to ensure "topLeft" is required (not null)
            if (topLeft == null)
            {
                throw new InvalidDataException("topLeft is a required property for SearchByBoundingBox and cannot be null");
            }
            else
            {
                this.TopLeft = topLeft;
            }
            // to ensure "bottomRight" is required (not null)
            if (bottomRight == null)
            {
                throw new InvalidDataException("bottomRight is a required property for SearchByBoundingBox and cannot be null");
            }
            else
            {
                this.BottomRight = bottomRight;
            }
        }
        
        /// <summary>
        /// Gets or Sets TopLeft
        /// </summary>
        [DataMember(Name="topLeft", EmitDefaultValue=false)]
        public SearchPoint TopLeft { get; set; }

        /// <summary>
        /// Gets or Sets BottomRight
        /// </summary>
        [DataMember(Name="bottomRight", EmitDefaultValue=false)]
        public SearchPoint BottomRight { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchByBoundingBox {\n");
            sb.Append("  TopLeft: ").Append(TopLeft).Append("\n");
            sb.Append("  BottomRight: ").Append(BottomRight).Append("\n");
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
            return this.Equals(input as SearchByBoundingBox);
        }

        /// <summary>
        /// Returns true if SearchByBoundingBox instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchByBoundingBox to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchByBoundingBox input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TopLeft == input.TopLeft ||
                    (this.TopLeft != null &&
                    this.TopLeft.Equals(input.TopLeft))
                ) && 
                (
                    this.BottomRight == input.BottomRight ||
                    (this.BottomRight != null &&
                    this.BottomRight.Equals(input.BottomRight))
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
                if (this.TopLeft != null)
                    hashCode = hashCode * 59 + this.TopLeft.GetHashCode();
                if (this.BottomRight != null)
                    hashCode = hashCode * 59 + this.BottomRight.GetHashCode();
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
