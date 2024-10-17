using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListQueryHttpCodeRequest 
    {

        /// <summary>
        /// 播放域名列表，最多支持查询100个域名，多个域名以逗号分隔。 
        /// </summary>
        [SDKProperty("play_domains", IsQuery = true)]
        [JsonProperty("play_domains", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PlayDomains { get; set; }

        /// <summary>
        /// 状态码。 
        /// </summary>
        [SDKProperty("code", IsQuery = true)]
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Code { get; set; }

        /// <summary>
        /// 区域列表。具体取值请参考[省份名称缩写](live_03_0043.xml)，不填写查询所有区域。 
        /// </summary>
        [SDKProperty("region", IsQuery = true)]
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Region { get; set; }

        /// <summary>
        /// 运营商列表，取值如下： - CMCC ：移动 - CTCC ： 电信 - CUCC ：联通 - OTHER ：其他  不填写查询所有运营商。 
        /// </summary>
        [SDKProperty("isp", IsQuery = true)]
        [JsonProperty("isp", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Isp { get; set; }

        /// <summary>
        /// 起始时间。日期格式按照ISO8601表示法，并使用UTC时间。  格式为：YYYY-MM-DDThh:mm:ssZ。若参数为空，默认查询最近1小时数据。  最大查询跨度1天，最大查询周期7天。 
        /// </summary>
        [SDKProperty("start_time", IsQuery = true)]
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 结束时间。日期格式按照ISO8601表示法，并使用UTC时间。  格式为：YYYY-MM-DDThh:mm:ssZ。  若参数为空，默认为当前时间。结束时间需大于起始时间。  最大查询跨度1天，最大查询周期7天。 
        /// </summary>
        [SDKProperty("end_time", IsQuery = true)]
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListQueryHttpCodeRequest {\n");
            sb.Append("  playDomains: ").Append(PlayDomains).Append("\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  isp: ").Append(Isp).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListQueryHttpCodeRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListQueryHttpCodeRequest input)
        {
            if (input == null) return false;
            if (this.PlayDomains != input.PlayDomains || (this.PlayDomains != null && input.PlayDomains != null && !this.PlayDomains.SequenceEqual(input.PlayDomains))) return false;
            if (this.Code != input.Code || (this.Code != null && input.Code != null && !this.Code.SequenceEqual(input.Code))) return false;
            if (this.Region != input.Region || (this.Region != null && input.Region != null && !this.Region.SequenceEqual(input.Region))) return false;
            if (this.Isp != input.Isp || (this.Isp != null && input.Isp != null && !this.Isp.SequenceEqual(input.Isp))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;

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
                if (this.PlayDomains != null) hashCode = hashCode * 59 + this.PlayDomains.GetHashCode();
                if (this.Code != null) hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.Isp != null) hashCode = hashCode * 59 + this.Isp.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
