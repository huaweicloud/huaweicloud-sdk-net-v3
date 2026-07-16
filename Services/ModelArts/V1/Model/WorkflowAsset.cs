using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// Workflow资产。
    /// </summary>
    public class WorkflowAsset 
    {

        /// <summary>
        /// 资产名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 资产类型，枚举如下: - algorithm：算法 - algorithm2：新算法 - model：模型算法
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 资产ID，可在AI Gallery中获取。
        /// </summary>
        [JsonProperty("content_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentId { get; set; }

        /// <summary>
        /// 订阅ID，可在AI Gallery中获取。
        /// </summary>
        [JsonProperty("subscription_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// 超期时间。
        /// </summary>
        [JsonProperty("expired_at", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpiredAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkflowAsset {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  contentId: ").Append(ContentId).Append("\n");
            sb.Append("  subscriptionId: ").Append(SubscriptionId).Append("\n");
            sb.Append("  expiredAt: ").Append(ExpiredAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkflowAsset);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkflowAsset input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.ContentId != input.ContentId || (this.ContentId != null && !this.ContentId.Equals(input.ContentId))) return false;
            if (this.SubscriptionId != input.SubscriptionId || (this.SubscriptionId != null && !this.SubscriptionId.Equals(input.SubscriptionId))) return false;
            if (this.ExpiredAt != input.ExpiredAt || (this.ExpiredAt != null && !this.ExpiredAt.Equals(input.ExpiredAt))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ContentId != null) hashCode = hashCode * 59 + this.ContentId.GetHashCode();
                if (this.SubscriptionId != null) hashCode = hashCode * 59 + this.SubscriptionId.GetHashCode();
                if (this.ExpiredAt != null) hashCode = hashCode * 59 + this.ExpiredAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
