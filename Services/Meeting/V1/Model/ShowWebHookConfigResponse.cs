using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowWebHookConfigResponse : SdkResponse
    {

        /// <summary>
        /// 结果码。
        /// </summary>
        [JsonProperty("returnCode", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReturnCode { get; set; }

        /// <summary>
        /// 结果描述。
        /// </summary>
        [JsonProperty("returnDesc", NullValueHandling = NullValueHandling.Ignore)]
        public string ReturnDesc { get; set; }

        /// <summary>
        /// 订阅配置记录ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 订阅ID。
        /// </summary>
        [JsonProperty("subscriberId", NullValueHandling = NullValueHandling.Ignore)]
        public string SubscriberId { get; set; }

        /// <summary>
        /// 订阅url。
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// 事件推送状态。 * 0：已启用 * 1：未启动 * 2：已锁定 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowWebHookConfigResponse {\n");
            sb.Append("  returnCode: ").Append(ReturnCode).Append("\n");
            sb.Append("  returnDesc: ").Append(ReturnDesc).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  subscriberId: ").Append(SubscriberId).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowWebHookConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowWebHookConfigResponse input)
        {
            if (input == null) return false;
            if (this.ReturnCode != input.ReturnCode || (this.ReturnCode != null && !this.ReturnCode.Equals(input.ReturnCode))) return false;
            if (this.ReturnDesc != input.ReturnDesc || (this.ReturnDesc != null && !this.ReturnDesc.Equals(input.ReturnDesc))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.SubscriberId != input.SubscriberId || (this.SubscriberId != null && !this.SubscriberId.Equals(input.SubscriberId))) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;

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
                if (this.ReturnCode != null) hashCode = hashCode * 59 + this.ReturnCode.GetHashCode();
                if (this.ReturnDesc != null) hashCode = hashCode * 59 + this.ReturnDesc.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.SubscriberId != null) hashCode = hashCode * 59 + this.SubscriberId.GetHashCode();
                if (this.Url != null) hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
