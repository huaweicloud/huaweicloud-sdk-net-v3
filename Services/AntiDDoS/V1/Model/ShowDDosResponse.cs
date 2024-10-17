using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.AntiDDoS.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowDDosResponse : SdkResponse
    {

        /// <summary>
        /// 是否开启L7层防护
        /// </summary>
        [JsonProperty("enable_L7", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableL7 { get; set; }

        /// <summary>
        /// 流量分段ID，取值范围：1～9
        /// </summary>
        [JsonProperty("traffic_pos_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? TrafficPosId { get; set; }

        /// <summary>
        /// HTTP请求数分段ID，取值范围：1～15
        /// </summary>
        [JsonProperty("http_request_pos_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? HttpRequestPosId { get; set; }

        /// <summary>
        /// 清洗时访问限制分段ID，取值范围：1～8
        /// </summary>
        [JsonProperty("cleaning_access_pos_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? CleaningAccessPosId { get; set; }

        /// <summary>
        /// 应用类型ID，可选取值： - 0 - 1
        /// </summary>
        [JsonProperty("app_type_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? AppTypeId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDDosResponse {\n");
            sb.Append("  enableL7: ").Append(EnableL7).Append("\n");
            sb.Append("  trafficPosId: ").Append(TrafficPosId).Append("\n");
            sb.Append("  httpRequestPosId: ").Append(HttpRequestPosId).Append("\n");
            sb.Append("  cleaningAccessPosId: ").Append(CleaningAccessPosId).Append("\n");
            sb.Append("  appTypeId: ").Append(AppTypeId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDDosResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDDosResponse input)
        {
            if (input == null) return false;
            if (this.EnableL7 != input.EnableL7 || (this.EnableL7 != null && !this.EnableL7.Equals(input.EnableL7))) return false;
            if (this.TrafficPosId != input.TrafficPosId || (this.TrafficPosId != null && !this.TrafficPosId.Equals(input.TrafficPosId))) return false;
            if (this.HttpRequestPosId != input.HttpRequestPosId || (this.HttpRequestPosId != null && !this.HttpRequestPosId.Equals(input.HttpRequestPosId))) return false;
            if (this.CleaningAccessPosId != input.CleaningAccessPosId || (this.CleaningAccessPosId != null && !this.CleaningAccessPosId.Equals(input.CleaningAccessPosId))) return false;
            if (this.AppTypeId != input.AppTypeId || (this.AppTypeId != null && !this.AppTypeId.Equals(input.AppTypeId))) return false;

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
                if (this.EnableL7 != null) hashCode = hashCode * 59 + this.EnableL7.GetHashCode();
                if (this.TrafficPosId != null) hashCode = hashCode * 59 + this.TrafficPosId.GetHashCode();
                if (this.HttpRequestPosId != null) hashCode = hashCode * 59 + this.HttpRequestPosId.GetHashCode();
                if (this.CleaningAccessPosId != null) hashCode = hashCode * 59 + this.CleaningAccessPosId.GetHashCode();
                if (this.AppTypeId != null) hashCode = hashCode * 59 + this.AppTypeId.GetHashCode();
                return hashCode;
            }
        }
    }
}
