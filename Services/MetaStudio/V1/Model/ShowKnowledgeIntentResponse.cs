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
    public class ShowKnowledgeIntentResponse : SdkResponse
    {

        /// <summary>
        /// 意图ID。
        /// </summary>
        [JsonProperty("intent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IntentId { get; set; }

        /// <summary>
        /// 主题。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 意图标识。
        /// </summary>
        [JsonProperty("identify", NullValueHandling = NullValueHandling.Ignore)]
        public string Identify { get; set; }

        /// <summary>
        /// 问题答案。
        /// </summary>
        [JsonProperty("answer", NullValueHandling = NullValueHandling.Ignore)]
        public string Answer { get; set; }

        /// <summary>
        /// 创建时间，格式遵循：RFC 3339 如\&quot;2021-01-10T08:43:17Z\&quot;。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 更新时间，格式遵循：RFC 3339 如\&quot;2021-01-10T08:43:17Z\&quot;。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

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
            sb.Append("class ShowKnowledgeIntentResponse {\n");
            sb.Append("  intentId: ").Append(IntentId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  identify: ").Append(Identify).Append("\n");
            sb.Append("  answer: ").Append(Answer).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowKnowledgeIntentResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowKnowledgeIntentResponse input)
        {
            if (input == null) return false;
            if (this.IntentId != input.IntentId || (this.IntentId != null && !this.IntentId.Equals(input.IntentId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Identify != input.Identify || (this.Identify != null && !this.Identify.Equals(input.Identify))) return false;
            if (this.Answer != input.Answer || (this.Answer != null && !this.Answer.Equals(input.Answer))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
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
                if (this.IntentId != null) hashCode = hashCode * 59 + this.IntentId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Identify != null) hashCode = hashCode * 59 + this.Identify.GetHashCode();
                if (this.Answer != null) hashCode = hashCode * 59 + this.Answer.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
