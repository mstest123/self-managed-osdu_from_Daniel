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
import io.swagger.client.model.PartitionProperty;
import java.io.IOException;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * PartitionDto
 */
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2022-01-06T19:27:20.802Z")
public class PartitionDto {
  @SerializedName("properties")
  private Map<String, PartitionProperty> properties = new HashMap<String, PartitionProperty>();

  public PartitionDto properties(Map<String, PartitionProperty> properties) {
    this.properties = properties;
    return this;
  }

  public PartitionDto putPropertiesItem(String key, PartitionProperty propertiesItem) {
    this.properties.put(key, propertiesItem);
    return this;
  }

   /**
   * Free form key value pair object for any data partition specific values
   * @return properties
  **/
  @ApiModelProperty(required = true, value = "Free form key value pair object for any data partition specific values")
  public Map<String, PartitionProperty> getProperties() {
    return properties;
  }

  public void setProperties(Map<String, PartitionProperty> properties) {
    this.properties = properties;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    PartitionDto partitionDto = (PartitionDto) o;
    return Objects.equals(this.properties, partitionDto.properties);
  }

  @Override
  public int hashCode() {
    return Objects.hash(properties);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class PartitionDto {\n");
    
    sb.append("    properties: ").append(toIndentedString(properties)).append("\n");
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

