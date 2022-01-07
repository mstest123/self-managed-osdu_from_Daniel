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
    /// Further information about File being uploaded.
    /// </summary>
    [DataContract]
    public partial class FileDetails :  IEquatable<FileDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileDetails" /> class.
        /// </summary>
        /// <param name="targetKind">The target kind or schema ID which is to be used by the parser..</param>
        /// <param name="fileType">Type of File to decide what kind of ingestion to be triggered.</param>
        /// <param name="frameOfReference">The list metaItem definitions which maps a named frame of reference symbol or name to the self-contained persistableReference..</param>
        /// <param name="extensionProperties">extensionProperties.</param>
        /// <param name="parentReference">The parent reference for this file..</param>
        public FileDetails(string targetKind = default(string), string fileType = default(string), List<FileMetaItem> frameOfReference = default(List<FileMetaItem>), FileExtensionProperties extensionProperties = default(FileExtensionProperties), string parentReference = default(string))
        {
            this.TargetKind = targetKind;
            this.FileType = fileType;
            this.FrameOfReference = frameOfReference;
            this.ExtensionProperties = extensionProperties;
            this.ParentReference = parentReference;
        }
        
        /// <summary>
        /// The target kind or schema ID which is to be used by the parser.
        /// </summary>
        /// <value>The target kind or schema ID which is to be used by the parser.</value>
        [DataMember(Name="TargetKind", EmitDefaultValue=false)]
        public string TargetKind { get; set; }

        /// <summary>
        /// Type of File to decide what kind of ingestion to be triggered
        /// </summary>
        /// <value>Type of File to decide what kind of ingestion to be triggered</value>
        [DataMember(Name="FileType", EmitDefaultValue=false)]
        public string FileType { get; set; }

        /// <summary>
        /// The list metaItem definitions which maps a named frame of reference symbol or name to the self-contained persistableReference.
        /// </summary>
        /// <value>The list metaItem definitions which maps a named frame of reference symbol or name to the self-contained persistableReference.</value>
        [DataMember(Name="FrameOfReference", EmitDefaultValue=false)]
        public List<FileMetaItem> FrameOfReference { get; set; }

        /// <summary>
        /// Gets or Sets ExtensionProperties
        /// </summary>
        [DataMember(Name="ExtensionProperties", EmitDefaultValue=false)]
        public FileExtensionProperties ExtensionProperties { get; set; }

        /// <summary>
        /// The parent reference for this file.
        /// </summary>
        /// <value>The parent reference for this file.</value>
        [DataMember(Name="ParentReference", EmitDefaultValue=false)]
        public string ParentReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileDetails {\n");
            sb.Append("  TargetKind: ").Append(TargetKind).Append("\n");
            sb.Append("  FileType: ").Append(FileType).Append("\n");
            sb.Append("  FrameOfReference: ").Append(FrameOfReference).Append("\n");
            sb.Append("  ExtensionProperties: ").Append(ExtensionProperties).Append("\n");
            sb.Append("  ParentReference: ").Append(ParentReference).Append("\n");
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
            return this.Equals(input as FileDetails);
        }

        /// <summary>
        /// Returns true if FileDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of FileDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TargetKind == input.TargetKind ||
                    (this.TargetKind != null &&
                    this.TargetKind.Equals(input.TargetKind))
                ) && 
                (
                    this.FileType == input.FileType ||
                    (this.FileType != null &&
                    this.FileType.Equals(input.FileType))
                ) && 
                (
                    this.FrameOfReference == input.FrameOfReference ||
                    this.FrameOfReference != null &&
                    this.FrameOfReference.SequenceEqual(input.FrameOfReference)
                ) && 
                (
                    this.ExtensionProperties == input.ExtensionProperties ||
                    (this.ExtensionProperties != null &&
                    this.ExtensionProperties.Equals(input.ExtensionProperties))
                ) && 
                (
                    this.ParentReference == input.ParentReference ||
                    (this.ParentReference != null &&
                    this.ParentReference.Equals(input.ParentReference))
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
                if (this.TargetKind != null)
                    hashCode = hashCode * 59 + this.TargetKind.GetHashCode();
                if (this.FileType != null)
                    hashCode = hashCode * 59 + this.FileType.GetHashCode();
                if (this.FrameOfReference != null)
                    hashCode = hashCode * 59 + this.FrameOfReference.GetHashCode();
                if (this.ExtensionProperties != null)
                    hashCode = hashCode * 59 + this.ExtensionProperties.GetHashCode();
                if (this.ParentReference != null)
                    hashCode = hashCode * 59 + this.ParentReference.GetHashCode();
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
