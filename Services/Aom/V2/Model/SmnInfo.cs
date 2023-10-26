using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// SMN信息
    /// </summary>
    public class SmnInfo 
    {

        /// <summary>
        /// smn发送消息的内容
        /// </summary>
        [JsonProperty("smn_notified_content", NullValueHandling = NullValueHandling.Ignore)]
        public string SmnNotifiedContent { get; set; }

        /// <summary>
        /// smn的订阅的状态
        /// </summary>
        [JsonProperty("smn_subscription_status", NullValueHandling = NullValueHandling.Ignore)]
        public string SmnSubscriptionStatus { get; set; }

        /// <summary>
        /// smn的订阅类型
        /// </summary>
        [JsonProperty("smn_subscription_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SmnSubscriptionType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmnInfo {\n");
            sb.Append("  smnNotifiedContent: ").Append(SmnNotifiedContent).Append("\n");
            sb.Append("  smnSubscriptionStatus: ").Append(SmnSubscriptionStatus).Append("\n");
            sb.Append("  smnSubscriptionType: ").Append(SmnSubscriptionType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SmnInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SmnInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SmnNotifiedContent == input.SmnNotifiedContent ||
                    (this.SmnNotifiedContent != null &&
                    this.SmnNotifiedContent.Equals(input.SmnNotifiedContent))
                ) && 
                (
                    this.SmnSubscriptionStatus == input.SmnSubscriptionStatus ||
                    (this.SmnSubscriptionStatus != null &&
                    this.SmnSubscriptionStatus.Equals(input.SmnSubscriptionStatus))
                ) && 
                (
                    this.SmnSubscriptionType == input.SmnSubscriptionType ||
                    (this.SmnSubscriptionType != null &&
                    this.SmnSubscriptionType.Equals(input.SmnSubscriptionType))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.SmnNotifiedContent != null)
                    hashCode = hashCode * 59 + this.SmnNotifiedContent.GetHashCode();
                if (this.SmnSubscriptionStatus != null)
                    hashCode = hashCode * 59 + this.SmnSubscriptionStatus.GetHashCode();
                if (this.SmnSubscriptionType != null)
                    hashCode = hashCode * 59 + this.SmnSubscriptionType.GetHashCode();
                return hashCode;
            }
        }
    }
}
