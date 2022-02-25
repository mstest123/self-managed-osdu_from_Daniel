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


package osdu.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;

/**
 * Represents a single invalid LegalTag.
 */
@ApiModel(description = "Represents a single invalid LegalTag.")
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2022-01-08T01:37:46.955Z")
public class LegalTagInvalidResponse {
  @SerializedName("name")
  private String name = null;

  @SerializedName("reason")
  private String reason = null;

  public LegalTagInvalidResponse name(String name) {
    this.name = name;
    return this;
  }

   /**
   * The name of the LegalTag.
   * @return name
  **/
  @ApiModelProperty(value = "The name of the LegalTag.")
  public String getName() {
    return name;
  }

  public void setName(String name) {
    this.name = name;
  }

  public LegalTagInvalidResponse reason(String reason) {
    this.reason = reason;
    return this;
  }

   /**
   * The reason the LegalTag is currently invalid.
   * @return reason
  **/
  @ApiModelProperty(value = "The reason the LegalTag is currently invalid.")
  public String getReason() {
    return reason;
  }

  public void setReason(String reason) {
    this.reason = reason;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    LegalTagInvalidResponse legalTagInvalidResponse = (LegalTagInvalidResponse) o;
    return Objects.equals(this.name, legalTagInvalidResponse.name) &&
        Objects.equals(this.reason, legalTagInvalidResponse.reason);
  }

  @Override
  public int hashCode() {
    return Objects.hash(name, reason);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class LegalTagInvalidResponse {\n");
    
    sb.append("    name: ").append(toIndentedString(name)).append("\n");
    sb.append("    reason: ").append(toIndentedString(reason)).append("\n");
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
