using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// 删除agent入参。
    /// </summary>
    public class AgentDeleteParam 
    {

        /// <summary>
        /// 实例列表。
        /// </summary>
        [JsonProperty("instance_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<long?> InstanceList { get; set; }

        /// <summary>
        /// region英文名称。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 应用id。
        /// </summary>
        [JsonProperty("business_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? BusinessId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentDeleteParam {\n");
            sb.Append("  instanceList: ").Append(InstanceList).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  businessId: ").Append(BusinessId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AgentDeleteParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AgentDeleteParam input)
        {
            if (input == null) return false;
            if (this.InstanceList != input.InstanceList || (this.InstanceList != null && input.InstanceList != null && !this.InstanceList.SequenceEqual(input.InstanceList))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.BusinessId != input.BusinessId || (this.BusinessId != null && !this.BusinessId.Equals(input.BusinessId))) return false;

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
                if (this.InstanceList != null) hashCode = hashCode * 59 + this.InstanceList.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.BusinessId != null) hashCode = hashCode * 59 + this.BusinessId.GetHashCode();
                return hashCode;
            }
        }
    }
}
