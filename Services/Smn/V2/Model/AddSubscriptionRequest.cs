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
    public class AddSubscriptionRequest 
    {

        /// <summary>
        /// Topic的唯一的资源标识，可通过[查询主题列表](https://support.huaweicloud.com/api-smn/smn_api_51004.html)获取该标识。
        /// </summary>
        [SDKProperty("topic_urn", IsPath = true)]
        [JsonProperty("topic_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string TopicUrn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public AddSubscriptionRequestBody Body { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddSubscriptionRequest {\n");
            sb.Append("  topicUrn: ").Append(TopicUrn).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddSubscriptionRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddSubscriptionRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TopicUrn == input.TopicUrn ||
                    (this.TopicUrn != null &&
                    this.TopicUrn.Equals(input.TopicUrn))
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
                if (this.TopicUrn != null)
                    hashCode = hashCode * 59 + this.TopicUrn.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
