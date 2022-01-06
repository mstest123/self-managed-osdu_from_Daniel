/*
 * self-managed-osdu
 * Rest API Documentation for Self Managed OSDU
 *
 * OpenAPI spec version: 0.11.0
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */


package io.swagger.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import io.swagger.client.model.SchemaIdentity;
import java.io.IOException;
import org.threeten.bp.OffsetDateTime;

/**
 * Schema info including status, creation and schemaIdentity
 */
@ApiModel(description = "Schema info including status, creation and schemaIdentity")
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2022-01-06T19:27:20.802Z")
public class SchemaInfo {
  @SerializedName("createdBy")
  private String createdBy = null;

  @SerializedName("dateCreated")
  private OffsetDateTime dateCreated = null;

  @SerializedName("schemaIdentity")
  private SchemaIdentity schemaIdentity = null;

  /**
   * Schema Scope - is it internal or shared. This is a system defined attribute based on partition-id passed.
   */
  @JsonAdapter(ScopeEnum.Adapter.class)
  public enum ScopeEnum {
    INTERNAL("INTERNAL"),
    
    SHARED("SHARED");

    private String value;

    ScopeEnum(String value) {
      this.value = value;
    }

    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static ScopeEnum fromValue(String text) {
      for (ScopeEnum b : ScopeEnum.values()) {
        if (String.valueOf(b.value).equals(text)) {
          return b;
        }
      }
      return null;
    }

    public static class Adapter extends TypeAdapter<ScopeEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final ScopeEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public ScopeEnum read(final JsonReader jsonReader) throws IOException {
        String value = jsonReader.nextString();
        return ScopeEnum.fromValue(String.valueOf(value));
      }
    }
  }

  @SerializedName("scope")
  private ScopeEnum scope = null;

  /**
   * Schema lifecycle status
   */
  @JsonAdapter(StatusEnum.Adapter.class)
  public enum StatusEnum {
    PUBLISHED("PUBLISHED"),
    
    OBSOLETE("OBSOLETE"),
    
    DEVELOPMENT("DEVELOPMENT");

    private String value;

    StatusEnum(String value) {
      this.value = value;
    }

    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static StatusEnum fromValue(String text) {
      for (StatusEnum b : StatusEnum.values()) {
        if (String.valueOf(b.value).equals(text)) {
          return b;
        }
      }
      return null;
    }

    public static class Adapter extends TypeAdapter<StatusEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final StatusEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public StatusEnum read(final JsonReader jsonReader) throws IOException {
        String value = jsonReader.nextString();
        return StatusEnum.fromValue(String.valueOf(value));
      }
    }
  }

  @SerializedName("status")
  private StatusEnum status = null;

  @SerializedName("supersededBy")
  private SchemaIdentity supersededBy = null;

  public SchemaInfo createdBy(String createdBy) {
    this.createdBy = createdBy;
    return this;
  }

   /**
   * The user who created the schema. This value is taken from API caller token.
   * @return createdBy
  **/
  @ApiModelProperty(example = "user@opendes.com", value = "The user who created the schema. This value is taken from API caller token.")
  public String getCreatedBy() {
    return createdBy;
  }

  public void setCreatedBy(String createdBy) {
    this.createdBy = createdBy;
  }

  public SchemaInfo dateCreated(OffsetDateTime dateCreated) {
    this.dateCreated = dateCreated;
    return this;
  }

   /**
   * The UTC date time of the entity creation
   * @return dateCreated
  **/
  @ApiModelProperty(example = "2019-05-23T11:16:03.000+0000", value = "The UTC date time of the entity creation")
  public OffsetDateTime getDateCreated() {
    return dateCreated;
  }

  public void setDateCreated(OffsetDateTime dateCreated) {
    this.dateCreated = dateCreated;
  }

  public SchemaInfo schemaIdentity(SchemaIdentity schemaIdentity) {
    this.schemaIdentity = schemaIdentity;
    return this;
  }

   /**
   * Get schemaIdentity
   * @return schemaIdentity
  **/
  @ApiModelProperty(required = true, value = "")
  public SchemaIdentity getSchemaIdentity() {
    return schemaIdentity;
  }

  public void setSchemaIdentity(SchemaIdentity schemaIdentity) {
    this.schemaIdentity = schemaIdentity;
  }

  public SchemaInfo scope(ScopeEnum scope) {
    this.scope = scope;
    return this;
  }

   /**
   * Schema Scope - is it internal or shared. This is a system defined attribute based on partition-id passed.
   * @return scope
  **/
  @ApiModelProperty(example = "INTERNAL", value = "Schema Scope - is it internal or shared. This is a system defined attribute based on partition-id passed.")
  public ScopeEnum getScope() {
    return scope;
  }

  public void setScope(ScopeEnum scope) {
    this.scope = scope;
  }

  public SchemaInfo status(StatusEnum status) {
    this.status = status;
    return this;
  }

   /**
   * Schema lifecycle status
   * @return status
  **/
  @ApiModelProperty(required = true, value = "Schema lifecycle status")
  public StatusEnum getStatus() {
    return status;
  }

  public void setStatus(StatusEnum status) {
    this.status = status;
  }

  public SchemaInfo supersededBy(SchemaIdentity supersededBy) {
    this.supersededBy = supersededBy;
    return this;
  }

   /**
   * Get supersededBy
   * @return supersededBy
  **/
  @ApiModelProperty(value = "")
  public SchemaIdentity getSupersededBy() {
    return supersededBy;
  }

  public void setSupersededBy(SchemaIdentity supersededBy) {
    this.supersededBy = supersededBy;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    SchemaInfo schemaInfo = (SchemaInfo) o;
    return Objects.equals(this.createdBy, schemaInfo.createdBy) &&
        Objects.equals(this.dateCreated, schemaInfo.dateCreated) &&
        Objects.equals(this.schemaIdentity, schemaInfo.schemaIdentity) &&
        Objects.equals(this.scope, schemaInfo.scope) &&
        Objects.equals(this.status, schemaInfo.status) &&
        Objects.equals(this.supersededBy, schemaInfo.supersededBy);
  }

  @Override
  public int hashCode() {
    return Objects.hash(createdBy, dateCreated, schemaIdentity, scope, status, supersededBy);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class SchemaInfo {\n");
    
    sb.append("    createdBy: ").append(toIndentedString(createdBy)).append("\n");
    sb.append("    dateCreated: ").append(toIndentedString(dateCreated)).append("\n");
    sb.append("    schemaIdentity: ").append(toIndentedString(schemaIdentity)).append("\n");
    sb.append("    scope: ").append(toIndentedString(scope)).append("\n");
    sb.append("    status: ").append(toIndentedString(status)).append("\n");
    sb.append("    supersededBy: ").append(toIndentedString(supersededBy)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}

