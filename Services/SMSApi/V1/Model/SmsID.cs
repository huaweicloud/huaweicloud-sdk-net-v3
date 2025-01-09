using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.SMSApi.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SmsID 
    {

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("createTime", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 发送短信号码
        /// </summary>
        [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
        public string From { get; set; }

        /// <summary>
        /// 接收短信号码
        /// </summary>
        [JsonProperty("originTo", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginTo { get; set; }

        /// <summary>
        /// 短信id
        /// </summary>
        [JsonProperty("smsMsgId", NullValueHandling = NullValueHandling.Ignore)]
        public string SmsMsgId { get; set; }

        /// <summary>
        /// 短信当前状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 国家码
        /// </summary>
        [JsonProperty("countryId", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryId { get; set; }

        /// <summary>
        /// 短信拆分条数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmsID {\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  from: ").Append(From).Append("\n");
            sb.Append("  originTo: ").Append(OriginTo).Append("\n");
            sb.Append("  smsMsgId: ").Append(SmsMsgId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  countryId: ").Append(CountryId).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SmsID);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SmsID input)
        {
            if (input == null) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.From != input.From || (this.From != null && !this.From.Equals(input.From))) return false;
            if (this.OriginTo != input.OriginTo || (this.OriginTo != null && !this.OriginTo.Equals(input.OriginTo))) return false;
            if (this.SmsMsgId != input.SmsMsgId || (this.SmsMsgId != null && !this.SmsMsgId.Equals(input.SmsMsgId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.CountryId != input.CountryId || (this.CountryId != null && !this.CountryId.Equals(input.CountryId))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;

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
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.From != null) hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.OriginTo != null) hashCode = hashCode * 59 + this.OriginTo.GetHashCode();
                if (this.SmsMsgId != null) hashCode = hashCode * 59 + this.SmsMsgId.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CountryId != null) hashCode = hashCode * 59 + this.CountryId.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
