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
    /// 
    /// </summary>
    public class PassengerTravelItemList 
    {

        /// <summary>
        /// 出行人。 
        /// </summary>
        [JsonProperty("traveler_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TravelerName { get; set; }

        /// <summary>
        /// 有效身份证件号。 
        /// </summary>
        [JsonProperty("id_number", NullValueHandling = NullValueHandling.Ignore)]
        public string IdNumber { get; set; }

        /// <summary>
        /// 出行日期。 
        /// </summary>
        [JsonProperty("travel_date", NullValueHandling = NullValueHandling.Ignore)]
        public string TravelDate { get; set; }

        /// <summary>
        /// 出发地。 
        /// </summary>
        [JsonProperty("departure_location", NullValueHandling = NullValueHandling.Ignore)]
        public string DepartureLocation { get; set; }

        /// <summary>
        /// 到达地。 
        /// </summary>
        [JsonProperty("arrival_location", NullValueHandling = NullValueHandling.Ignore)]
        public string ArrivalLocation { get; set; }

        /// <summary>
        /// 等级。 
        /// </summary>
        [JsonProperty("class", NullValueHandling = NullValueHandling.Ignore)]
        public string Class { get; set; }

        /// <summary>
        /// 交通工具类型。 
        /// </summary>
        [JsonProperty("transportation_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TransportationType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PassengerTravelItemList {\n");
            sb.Append("  travelerName: ").Append(TravelerName).Append("\n");
            sb.Append("  idNumber: ").Append(IdNumber).Append("\n");
            sb.Append("  travelDate: ").Append(TravelDate).Append("\n");
            sb.Append("  departureLocation: ").Append(DepartureLocation).Append("\n");
            sb.Append("  arrivalLocation: ").Append(ArrivalLocation).Append("\n");
            sb.Append("  Class: ").Append(Class).Append("\n");
            sb.Append("  transportationType: ").Append(TransportationType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PassengerTravelItemList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PassengerTravelItemList input)
        {
            if (input == null) return false;
            if (this.TravelerName != input.TravelerName || (this.TravelerName != null && !this.TravelerName.Equals(input.TravelerName))) return false;
            if (this.IdNumber != input.IdNumber || (this.IdNumber != null && !this.IdNumber.Equals(input.IdNumber))) return false;
            if (this.TravelDate != input.TravelDate || (this.TravelDate != null && !this.TravelDate.Equals(input.TravelDate))) return false;
            if (this.DepartureLocation != input.DepartureLocation || (this.DepartureLocation != null && !this.DepartureLocation.Equals(input.DepartureLocation))) return false;
            if (this.ArrivalLocation != input.ArrivalLocation || (this.ArrivalLocation != null && !this.ArrivalLocation.Equals(input.ArrivalLocation))) return false;
            if (this.Class != input.Class || (this.Class != null && !this.Class.Equals(input.Class))) return false;
            if (this.TransportationType != input.TransportationType || (this.TransportationType != null && !this.TransportationType.Equals(input.TransportationType))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.TravelerName != null) hashCode = hashCode * 59 + this.TravelerName.GetHashCode();
                if (this.IdNumber != null) hashCode = hashCode * 59 + this.IdNumber.GetHashCode();
                if (this.TravelDate != null) hashCode = hashCode * 59 + this.TravelDate.GetHashCode();
                if (this.DepartureLocation != null) hashCode = hashCode * 59 + this.DepartureLocation.GetHashCode();
                if (this.ArrivalLocation != null) hashCode = hashCode * 59 + this.ArrivalLocation.GetHashCode();
                if (this.Class != null) hashCode = hashCode * 59 + this.Class.GetHashCode();
                if (this.TransportationType != null) hashCode = hashCode * 59 + this.TransportationType.GetHashCode();
                return hashCode;
            }
        }
    }
}
