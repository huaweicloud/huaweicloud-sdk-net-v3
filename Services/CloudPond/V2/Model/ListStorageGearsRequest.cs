using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudPond.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListStorageGearsRequest 
    {

        /// <summary>
        /// 地区编码
        /// </summary>
        [SDKProperty("zone_code", IsQuery = true)]
        [JsonProperty("zone_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ZoneCode { get; set; }

        /// <summary>
        /// 付费模式
        /// </summary>
        [SDKProperty("pay_mode", IsQuery = true)]
        [JsonProperty("pay_mode", NullValueHandling = NullValueHandling.Ignore)]
        public List<PayMode> PayMode { get; set; }

        /// <summary>
        /// 购买时长
        /// </summary>
        [SDKProperty("period_num", IsQuery = true)]
        [JsonProperty("period_num", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> PeriodNum { get; set; }

        /// <summary>
        /// 每页的数量
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 分页标识
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListStorageGearsRequest {\n");
            sb.Append("  zoneCode: ").Append(ZoneCode).Append("\n");
            sb.Append("  payMode: ").Append(PayMode).Append("\n");
            sb.Append("  periodNum: ").Append(PeriodNum).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListStorageGearsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListStorageGearsRequest input)
        {
            if (input == null) return false;
            if (this.ZoneCode != input.ZoneCode || (this.ZoneCode != null && !this.ZoneCode.Equals(input.ZoneCode))) return false;
            if (this.PayMode != input.PayMode || (this.PayMode != null && input.PayMode != null && !this.PayMode.SequenceEqual(input.PayMode))) return false;
            if (this.PeriodNum != input.PeriodNum || (this.PeriodNum != null && input.PeriodNum != null && !this.PeriodNum.SequenceEqual(input.PeriodNum))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;

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
                if (this.ZoneCode != null) hashCode = hashCode * 59 + this.ZoneCode.GetHashCode();
                if (this.PayMode != null) hashCode = hashCode * 59 + this.PayMode.GetHashCode();
                if (this.PeriodNum != null) hashCode = hashCode * 59 + this.PeriodNum.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                return hashCode;
            }
        }
    }
}
