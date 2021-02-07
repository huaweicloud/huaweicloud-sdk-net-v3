using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class UpdateSubscriptionRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("Sp-Auth-Token", IsHeader = true)]
        [JsonProperty("Sp-Auth-Token", NullValueHandling = NullValueHandling.Ignore)]
        public string SpAuthToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("Stage-Auth-Token", IsHeader = true)]
        [JsonProperty("Stage-Auth-Token", NullValueHandling = NullValueHandling.Ignore)]
        public string StageAuthToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("Instance-Id", IsHeader = true)]
        [JsonProperty("Instance-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("subscription_id", IsPath = true)]
        [JsonProperty("subscription_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateSubReq Body { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateSubscriptionRequest {\n");
            sb.Append("  spAuthToken: ").Append(SpAuthToken).Append("\n");
            sb.Append("  stageAuthToken: ").Append(StageAuthToken).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  subscriptionId: ").Append(SubscriptionId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateSubscriptionRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateSubscriptionRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SpAuthToken == input.SpAuthToken ||
                    (this.SpAuthToken != null &&
                    this.SpAuthToken.Equals(input.SpAuthToken))
                ) && 
                (
                    this.StageAuthToken == input.StageAuthToken ||
                    (this.StageAuthToken != null &&
                    this.StageAuthToken.Equals(input.StageAuthToken))
                ) && 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.SubscriptionId == input.SubscriptionId ||
                    (this.SubscriptionId != null &&
                    this.SubscriptionId.Equals(input.SubscriptionId))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
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
                if (this.SpAuthToken != null)
                    hashCode = hashCode * 59 + this.SpAuthToken.GetHashCode();
                if (this.StageAuthToken != null)
                    hashCode = hashCode * 59 + this.StageAuthToken.GetHashCode();
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.SubscriptionId != null)
                    hashCode = hashCode * 59 + this.SubscriptionId.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
