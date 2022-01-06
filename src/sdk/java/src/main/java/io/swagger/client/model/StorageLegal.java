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
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

/**
 * StorageLegal
 */
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2022-01-06T19:27:20.802Z")
public class StorageLegal {
  @SerializedName("legaltags")
  private List<String> legaltags = null;

  @SerializedName("otherRelevantDataCountries")
  private List<String> otherRelevantDataCountries = null;

  public StorageLegal legaltags(List<String> legaltags) {
    this.legaltags = legaltags;
    return this;
  }

  public StorageLegal addLegaltagsItem(String legaltagsItem) {
    if (this.legaltags == null) {
      this.legaltags = new ArrayList<String>();
    }
    this.legaltags.add(legaltagsItem);
    return this;
  }

   /**
   * List of legaltag names associated with the record.
   * @return legaltags
  **/
  @ApiModelProperty(value = "List of legaltag names associated with the record.")
  public List<String> getLegaltags() {
    return legaltags;
  }

  public void setLegaltags(List<String> legaltags) {
    this.legaltags = legaltags;
  }

  public StorageLegal otherRelevantDataCountries(List<String> otherRelevantDataCountries) {
    this.otherRelevantDataCountries = otherRelevantDataCountries;
    return this;
  }

  public StorageLegal addOtherRelevantDataCountriesItem(String otherRelevantDataCountriesItem) {
    if (this.otherRelevantDataCountries == null) {
      this.otherRelevantDataCountries = new ArrayList<String>();
    }
    this.otherRelevantDataCountries.add(otherRelevantDataCountriesItem);
    return this;
  }

   /**
   * List of other relevant data countries. Must have 2 values: where the data was ingested from and where Data Lake stores the data.
   * @return otherRelevantDataCountries
  **/
  @ApiModelProperty(value = "List of other relevant data countries. Must have 2 values: where the data was ingested from and where Data Lake stores the data.")
  public List<String> getOtherRelevantDataCountries() {
    return otherRelevantDataCountries;
  }

  public void setOtherRelevantDataCountries(List<String> otherRelevantDataCountries) {
    this.otherRelevantDataCountries = otherRelevantDataCountries;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    StorageLegal storageLegal = (StorageLegal) o;
    return Objects.equals(this.legaltags, storageLegal.legaltags) &&
        Objects.equals(this.otherRelevantDataCountries, storageLegal.otherRelevantDataCountries);
  }

  @Override
  public int hashCode() {
    return Objects.hash(legaltags, otherRelevantDataCountries);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class StorageLegal {\n");
    
    sb.append("    legaltags: ").append(toIndentedString(legaltags)).append("\n");
    sb.append("    otherRelevantDataCountries: ").append(toIndentedString(otherRelevantDataCountries)).append("\n");
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

