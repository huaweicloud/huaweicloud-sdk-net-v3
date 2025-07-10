using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListSmartChatJobResponse : SdkResponse
    {

        /// <summary>
        /// 数字人智能交互对话任务总数。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 数字人智能交互对话任务列表。
        /// </summary>
        [JsonProperty("smart_chat_jobs", NullValueHandling = NullValueHandling.Ignore)]
        public List<SmartChatJobBaseInfo> SmartChatJobs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-Request-Id", IsHeader = true)]
        [JsonProperty("X-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XRequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSmartChatJobResponse {\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  smartChatJobs: ").Append(SmartChatJobs).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSmartChatJobResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSmartChatJobResponse input)
        {
            if (input == null) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.SmartChatJobs != input.SmartChatJobs || (this.SmartChatJobs != null && input.SmartChatJobs != null && !this.SmartChatJobs.SequenceEqual(input.SmartChatJobs))) return false;
            if (this.XRequestId != input.XRequestId || (this.XRequestId != null && !this.XRequestId.Equals(input.XRequestId))) return false;

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
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.SmartChatJobs != null) hashCode = hashCode * 59 + this.SmartChatJobs.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
