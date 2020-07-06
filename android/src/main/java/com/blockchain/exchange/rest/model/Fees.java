/**
 * Blockchain.com Exchange REST API
 * ## Introduction Welcome to Blockchain.com's Exchange API and developer documentation. These documents detail and give examples of various functionality offered by the API such as receiving real time market data, requesting balance information and performing trades. ## To Get Started Create or log into your existing Blockchain.com Exchange account Select API from the drop down menu Fill out form and click “Create New API Key Now” Once generated you can view your keys under API Settings 
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

package com.blockchain.exchange.rest.model;

import io.swagger.annotations.*;
import com.google.gson.annotations.SerializedName;

@ApiModel(description = "")
public class Fees {
  
  @SerializedName("makerRate")
  private Double makerRate = null;
  @SerializedName("takerRate")
  private Double takerRate = null;
  @SerializedName("volumeInUSD")
  private Double volumeInUSD = null;

  /**
   **/
  @ApiModelProperty(required = true, value = "")
  public Double getMakerRate() {
    return makerRate;
  }
  public void setMakerRate(Double makerRate) {
    this.makerRate = makerRate;
  }

  /**
   **/
  @ApiModelProperty(required = true, value = "")
  public Double getTakerRate() {
    return takerRate;
  }
  public void setTakerRate(Double takerRate) {
    this.takerRate = takerRate;
  }

  /**
   **/
  @ApiModelProperty(required = true, value = "")
  public Double getVolumeInUSD() {
    return volumeInUSD;
  }
  public void setVolumeInUSD(Double volumeInUSD) {
    this.volumeInUSD = volumeInUSD;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Fees fees = (Fees) o;
    return (this.makerRate == null ? fees.makerRate == null : this.makerRate.equals(fees.makerRate)) &&
        (this.takerRate == null ? fees.takerRate == null : this.takerRate.equals(fees.takerRate)) &&
        (this.volumeInUSD == null ? fees.volumeInUSD == null : this.volumeInUSD.equals(fees.volumeInUSD));
  }

  @Override
  public int hashCode() {
    int result = 17;
    result = 31 * result + (this.makerRate == null ? 0: this.makerRate.hashCode());
    result = 31 * result + (this.takerRate == null ? 0: this.takerRate.hashCode());
    result = 31 * result + (this.volumeInUSD == null ? 0: this.volumeInUSD.hashCode());
    return result;
  }

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class Fees {\n");
    
    sb.append("  makerRate: ").append(makerRate).append("\n");
    sb.append("  takerRate: ").append(takerRate).append("\n");
    sb.append("  volumeInUSD: ").append(volumeInUSD).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}
