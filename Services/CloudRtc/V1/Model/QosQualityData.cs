using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudRtc.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class QosQualityData 
    {

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

        /// <summary>
        /// 对端的用户ID，为0时表示本端上行数据
        /// </summary>
        [JsonProperty("peerid", NullValueHandling = NullValueHandling.Ignore)]
        public string Peerid { get; set; }

        /// <summary>
        /// 指标ID
        /// </summary>
        [JsonProperty("mid", NullValueHandling = NullValueHandling.Ignore)]
        public string Mid { get; set; }

        /// <summary>
        /// 时间戳及相应时间的指标数值列表
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<TimeFloatValueData> Data { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QosQualityData {\n");
            sb.Append("  uid: ").Append(Uid).Append("\n");
            sb.Append("  peerid: ").Append(Peerid).Append("\n");
            sb.Append("  mid: ").Append(Mid).Append("\n");
            sb.Append("  data: ").Append(Data).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QosQualityData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QosQualityData input)
        {
            if (input == null) return false;
            if (this.Uid != input.Uid || (this.Uid != null && !this.Uid.Equals(input.Uid))) return false;
            if (this.Peerid != input.Peerid || (this.Peerid != null && !this.Peerid.Equals(input.Peerid))) return false;
            if (this.Mid != input.Mid || (this.Mid != null && !this.Mid.Equals(input.Mid))) return false;
            if (this.Data != input.Data || (this.Data != null && input.Data != null && !this.Data.SequenceEqual(input.Data))) return false;

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
                if (this.Uid != null) hashCode = hashCode * 59 + this.Uid.GetHashCode();
                if (this.Peerid != null) hashCode = hashCode * 59 + this.Peerid.GetHashCode();
                if (this.Mid != null) hashCode = hashCode * 59 + this.Mid.GetHashCode();
                if (this.Data != null) hashCode = hashCode * 59 + this.Data.GetHashCode();
                return hashCode;
            }
        }
    }
}
