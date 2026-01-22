using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.RocketMQ.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowQuotasRequest 
    {

        /// <summary>
        /// **参数解释**： 是否包含标签配额标志。 **约束限制**： 不涉及。 **取值范围**： - true：包含配额。 - false：不包含配额。 **默认取值**： true。
        /// </summary>
        [SDKProperty("includeTagsQuota", IsQuery = true)]
        [JsonProperty("includeTagsQuota", NullValueHandling = NullValueHandling.Ignore)]
        public string IncludeTagsQuota { get; set; }

        /// <summary>
        /// **参数解释**： 查询指定配额引擎。 **约束限制**： 不涉及。 **取值范围**： - reliability：RocketMQ消息引擎别称。 - kafka：kafka消息引擎别称。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("onlyQuota", IsQuery = true)]
        [JsonProperty("onlyQuota", NullValueHandling = NullValueHandling.Ignore)]
        public string OnlyQuota { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowQuotasRequest {\n");
            sb.Append("  includeTagsQuota: ").Append(IncludeTagsQuota).Append("\n");
            sb.Append("  onlyQuota: ").Append(OnlyQuota).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowQuotasRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowQuotasRequest input)
        {
            if (input == null) return false;
            if (this.IncludeTagsQuota != input.IncludeTagsQuota || (this.IncludeTagsQuota != null && !this.IncludeTagsQuota.Equals(input.IncludeTagsQuota))) return false;
            if (this.OnlyQuota != input.OnlyQuota || (this.OnlyQuota != null && !this.OnlyQuota.Equals(input.OnlyQuota))) return false;

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
                if (this.IncludeTagsQuota != null) hashCode = hashCode * 59 + this.IncludeTagsQuota.GetHashCode();
                if (this.OnlyQuota != null) hashCode = hashCode * 59 + this.OnlyQuota.GetHashCode();
                return hashCode;
            }
        }
    }
}
