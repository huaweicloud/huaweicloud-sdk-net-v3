using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowKafkaTopicQuotaRequest 
    {

        /// <summary>
        /// **参数解释**： 实例ID。获取方法如下：登录Kafka控制台，在Kafka实例详情页面查找实例ID。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("instance_id", IsPath = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数解释**： 查询类型。 **约束限制**： 查询类型必须以字母开头且只支持大小写字母、中横线、下划线以及数字。 **取值范围**： 默认为topic **默认取值**： topic
        /// </summary>
        [SDKProperty("type", IsQuery = true)]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释**： 每一页显示的流控数量。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public string Limit { get; set; }

        /// <summary>
        /// **参数解释**： 页数。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public string Offset { get; set; }

        /// <summary>
        /// **参数解释**： 查询关键字。 **约束限制**： 查询关键字必须以字母开头且只支持大小写字母、中横线、下划线以及数字。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("keyword", IsQuery = true)]
        [JsonProperty("keyword", NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowKafkaTopicQuotaRequest {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  keyword: ").Append(Keyword).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowKafkaTopicQuotaRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowKafkaTopicQuotaRequest input)
        {
            if (input == null) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Keyword != input.Keyword || (this.Keyword != null && !this.Keyword.Equals(input.Keyword))) return false;

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
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Keyword != null) hashCode = hashCode * 59 + this.Keyword.GetHashCode();
                return hashCode;
            }
        }
    }
}
