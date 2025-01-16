using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Smn.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeleteNotifyPolicyRequest 
    {

        /// <summary>
        /// Topic的唯一的资源标识，可通过[查询主题列表](smn_api_51004.xml)获取该标识。
        /// </summary>
        [SDKProperty("topic_urn", IsPath = true)]
        [JsonProperty("topic_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string TopicUrn { get; set; }

        /// <summary>
        /// 通知策略ID。
        /// </summary>
        [SDKProperty("notify_policy_id", IsPath = true)]
        [JsonProperty("notify_policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NotifyPolicyId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteNotifyPolicyRequest {\n");
            sb.Append("  topicUrn: ").Append(TopicUrn).Append("\n");
            sb.Append("  notifyPolicyId: ").Append(NotifyPolicyId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteNotifyPolicyRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteNotifyPolicyRequest input)
        {
            if (input == null) return false;
            if (this.TopicUrn != input.TopicUrn || (this.TopicUrn != null && !this.TopicUrn.Equals(input.TopicUrn))) return false;
            if (this.NotifyPolicyId != input.NotifyPolicyId || (this.NotifyPolicyId != null && !this.NotifyPolicyId.Equals(input.NotifyPolicyId))) return false;

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
                if (this.TopicUrn != null) hashCode = hashCode * 59 + this.TopicUrn.GetHashCode();
                if (this.NotifyPolicyId != null) hashCode = hashCode * 59 + this.NotifyPolicyId.GetHashCode();
                return hashCode;
            }
        }
    }
}
