using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// 内存加速映射信息。
    /// </summary>
    public class QueryDBCacheMappingResponse 
    {

        /// <summary>
        /// 内存加速映射ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 内存加速映射名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 源实例ID。
        /// </summary>
        [JsonProperty("source_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceInstanceId { get; set; }

        /// <summary>
        /// 源实例名称。
        /// </summary>
        [JsonProperty("source_instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceInstanceName { get; set; }

        /// <summary>
        /// 目标实例ID。
        /// </summary>
        [JsonProperty("target_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetInstanceId { get; set; }

        /// <summary>
        /// 目标实例名称。
        /// </summary>
        [JsonProperty("target_instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetInstanceName { get; set; }

        /// <summary>
        /// 内存加速映射关系。  - normal： 表示内存加速映射正常。  - creating： 表示内存加速映射创建中。  - createfail： 表示内存加速映射创建失败。  - deleting： 表示内存加速映射解除中。  - stopped： 表示内存加速映射停止。  - deleted： 表示内存加速映射已解除。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 内存加速映射创建时间。
        /// </summary>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public string Created { get; set; }

        /// <summary>
        /// 内存加速映射最新变更的时间。
        /// </summary>
        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public string Updated { get; set; }

        /// <summary>
        /// 该内存加速映射下的规则数量。
        /// </summary>
        [JsonProperty("rule_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? RuleCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryDBCacheMappingResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  sourceInstanceId: ").Append(SourceInstanceId).Append("\n");
            sb.Append("  sourceInstanceName: ").Append(SourceInstanceName).Append("\n");
            sb.Append("  targetInstanceId: ").Append(TargetInstanceId).Append("\n");
            sb.Append("  targetInstanceName: ").Append(TargetInstanceName).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  created: ").Append(Created).Append("\n");
            sb.Append("  updated: ").Append(Updated).Append("\n");
            sb.Append("  ruleCount: ").Append(RuleCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryDBCacheMappingResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryDBCacheMappingResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.SourceInstanceId != input.SourceInstanceId || (this.SourceInstanceId != null && !this.SourceInstanceId.Equals(input.SourceInstanceId))) return false;
            if (this.SourceInstanceName != input.SourceInstanceName || (this.SourceInstanceName != null && !this.SourceInstanceName.Equals(input.SourceInstanceName))) return false;
            if (this.TargetInstanceId != input.TargetInstanceId || (this.TargetInstanceId != null && !this.TargetInstanceId.Equals(input.TargetInstanceId))) return false;
            if (this.TargetInstanceName != input.TargetInstanceName || (this.TargetInstanceName != null && !this.TargetInstanceName.Equals(input.TargetInstanceName))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Created != input.Created || (this.Created != null && !this.Created.Equals(input.Created))) return false;
            if (this.Updated != input.Updated || (this.Updated != null && !this.Updated.Equals(input.Updated))) return false;
            if (this.RuleCount != input.RuleCount || (this.RuleCount != null && !this.RuleCount.Equals(input.RuleCount))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SourceInstanceId != null) hashCode = hashCode * 59 + this.SourceInstanceId.GetHashCode();
                if (this.SourceInstanceName != null) hashCode = hashCode * 59 + this.SourceInstanceName.GetHashCode();
                if (this.TargetInstanceId != null) hashCode = hashCode * 59 + this.TargetInstanceId.GetHashCode();
                if (this.TargetInstanceName != null) hashCode = hashCode * 59 + this.TargetInstanceName.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Created != null) hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Updated != null) hashCode = hashCode * 59 + this.Updated.GetHashCode();
                if (this.RuleCount != null) hashCode = hashCode * 59 + this.RuleCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
