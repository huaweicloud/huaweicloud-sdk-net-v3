using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ocr.V1.Model
{
    /// <summary>
    /// 机票行程列表。
    /// </summary>
    public class ItineraryList 
    {

        /// <summary>
        /// 始发站。 
        /// </summary>
        [JsonProperty("departure_station", NullValueHandling = NullValueHandling.Ignore)]
        public string DepartureStation { get; set; }

        /// <summary>
        /// 目的站。 
        /// </summary>
        [JsonProperty("destination_station", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationStation { get; set; }

        /// <summary>
        /// 承运人。 
        /// </summary>
        [JsonProperty("carrier", NullValueHandling = NullValueHandling.Ignore)]
        public string Carrier { get; set; }

        /// <summary>
        /// 航班号。 
        /// </summary>
        [JsonProperty("flight", NullValueHandling = NullValueHandling.Ignore)]
        public string Flight { get; set; }

        /// <summary>
        /// 座位等级。 
        /// </summary>
        [JsonProperty("cabin_class", NullValueHandling = NullValueHandling.Ignore)]
        public string CabinClass { get; set; }

        /// <summary>
        /// 日期。 
        /// </summary>
        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public string Date { get; set; }

        /// <summary>
        /// 时间。 
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public string Time { get; set; }

        /// <summary>
        /// 客票类别。 
        /// </summary>
        [JsonProperty("fare_basis", NullValueHandling = NullValueHandling.Ignore)]
        public string FareBasis { get; set; }

        /// <summary>
        /// 客票生效日期。 
        /// </summary>
        [JsonProperty("effective_date", NullValueHandling = NullValueHandling.Ignore)]
        public string EffectiveDate { get; set; }

        /// <summary>
        /// 有效截止日期。 
        /// </summary>
        [JsonProperty("expiry_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpiryDate { get; set; }

        /// <summary>
        /// 免费行李。 
        /// </summary>
        [JsonProperty("baggage_allowance", NullValueHandling = NullValueHandling.Ignore)]
        public string BaggageAllowance { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItineraryList {\n");
            sb.Append("  departureStation: ").Append(DepartureStation).Append("\n");
            sb.Append("  destinationStation: ").Append(DestinationStation).Append("\n");
            sb.Append("  carrier: ").Append(Carrier).Append("\n");
            sb.Append("  flight: ").Append(Flight).Append("\n");
            sb.Append("  cabinClass: ").Append(CabinClass).Append("\n");
            sb.Append("  date: ").Append(Date).Append("\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("  fareBasis: ").Append(FareBasis).Append("\n");
            sb.Append("  effectiveDate: ").Append(EffectiveDate).Append("\n");
            sb.Append("  expiryDate: ").Append(ExpiryDate).Append("\n");
            sb.Append("  baggageAllowance: ").Append(BaggageAllowance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ItineraryList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ItineraryList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DepartureStation == input.DepartureStation ||
                    (this.DepartureStation != null &&
                    this.DepartureStation.Equals(input.DepartureStation))
                ) && 
                (
                    this.DestinationStation == input.DestinationStation ||
                    (this.DestinationStation != null &&
                    this.DestinationStation.Equals(input.DestinationStation))
                ) && 
                (
                    this.Carrier == input.Carrier ||
                    (this.Carrier != null &&
                    this.Carrier.Equals(input.Carrier))
                ) && 
                (
                    this.Flight == input.Flight ||
                    (this.Flight != null &&
                    this.Flight.Equals(input.Flight))
                ) && 
                (
                    this.CabinClass == input.CabinClass ||
                    (this.CabinClass != null &&
                    this.CabinClass.Equals(input.CabinClass))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.FareBasis == input.FareBasis ||
                    (this.FareBasis != null &&
                    this.FareBasis.Equals(input.FareBasis))
                ) && 
                (
                    this.EffectiveDate == input.EffectiveDate ||
                    (this.EffectiveDate != null &&
                    this.EffectiveDate.Equals(input.EffectiveDate))
                ) && 
                (
                    this.ExpiryDate == input.ExpiryDate ||
                    (this.ExpiryDate != null &&
                    this.ExpiryDate.Equals(input.ExpiryDate))
                ) && 
                (
                    this.BaggageAllowance == input.BaggageAllowance ||
                    (this.BaggageAllowance != null &&
                    this.BaggageAllowance.Equals(input.BaggageAllowance))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.DepartureStation != null)
                    hashCode = hashCode * 59 + this.DepartureStation.GetHashCode();
                if (this.DestinationStation != null)
                    hashCode = hashCode * 59 + this.DestinationStation.GetHashCode();
                if (this.Carrier != null)
                    hashCode = hashCode * 59 + this.Carrier.GetHashCode();
                if (this.Flight != null)
                    hashCode = hashCode * 59 + this.Flight.GetHashCode();
                if (this.CabinClass != null)
                    hashCode = hashCode * 59 + this.CabinClass.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.FareBasis != null)
                    hashCode = hashCode * 59 + this.FareBasis.GetHashCode();
                if (this.EffectiveDate != null)
                    hashCode = hashCode * 59 + this.EffectiveDate.GetHashCode();
                if (this.ExpiryDate != null)
                    hashCode = hashCode * 59 + this.ExpiryDate.GetHashCode();
                if (this.BaggageAllowance != null)
                    hashCode = hashCode * 59 + this.BaggageAllowance.GetHashCode();
                return hashCode;
            }
        }
    }
}
