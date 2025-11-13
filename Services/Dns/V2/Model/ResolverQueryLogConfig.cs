using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dns.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ResolverQueryLogConfig 
    {

        /// <summary>
        /// 解析器访问日志的ID，UUID形式的一个资源标识。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 日志组ID。
        /// </summary>
        [JsonProperty("lts_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LtsGroupId { get; set; }

        /// <summary>
        /// 日志流ID。
        /// </summary>
        [JsonProperty("lts_topic_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LtsTopicId { get; set; }

        /// <summary>
        /// 关联的VPC ID列表。
        /// </summary>
        [JsonProperty("vpc_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> VpcIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResolverQueryLogConfig {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  ltsGroupId: ").Append(LtsGroupId).Append("\n");
            sb.Append("  ltsTopicId: ").Append(LtsTopicId).Append("\n");
            sb.Append("  vpcIds: ").Append(VpcIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResolverQueryLogConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResolverQueryLogConfig input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.LtsGroupId != input.LtsGroupId || (this.LtsGroupId != null && !this.LtsGroupId.Equals(input.LtsGroupId))) return false;
            if (this.LtsTopicId != input.LtsTopicId || (this.LtsTopicId != null && !this.LtsTopicId.Equals(input.LtsTopicId))) return false;
            if (this.VpcIds != input.VpcIds || (this.VpcIds != null && input.VpcIds != null && !this.VpcIds.SequenceEqual(input.VpcIds))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LtsGroupId != null) hashCode = hashCode * 59 + this.LtsGroupId.GetHashCode();
                if (this.LtsTopicId != null) hashCode = hashCode * 59 + this.LtsTopicId.GetHashCode();
                if (this.VpcIds != null) hashCode = hashCode * 59 + this.VpcIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
