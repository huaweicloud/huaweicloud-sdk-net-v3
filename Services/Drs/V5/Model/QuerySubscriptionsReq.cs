using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 查询订阅任务列表请求体
    /// </summary>
    public class QuerySubscriptionsReq 
    {

        /// <summary>
        /// 任务场景
        /// </summary>
        [JsonProperty("job_type", NullValueHandling = NullValueHandling.Ignore)]
        public string JobType { get; set; }

        /// <summary>
        /// 引擎类型。
        /// </summary>
        [JsonProperty("engine_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineType { get; set; }

        /// <summary>
        /// 网络类型。
        /// </summary>
        [JsonProperty("net_type", NullValueHandling = NullValueHandling.Ignore)]
        public string NetType { get; set; }

        /// <summary>
        /// 任务ID或名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 任务状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 企业项目ID。 缺省值：\&quot;\&quot;，表示查询所有企业项目任务。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 返回结果按该关键字排序，默认为“create_time”。
        /// </summary>
        [JsonProperty("sort_key", NullValueHandling = NullValueHandling.Ignore)]
        public string SortKey { get; set; }

        /// <summary>
        /// 降序或升序（分别对应desc和asc，默认为“desc”）。
        /// </summary>
        [JsonProperty("sort_dir", NullValueHandling = NullValueHandling.Ignore)]
        public string SortDir { get; set; }

        /// <summary>
        /// 数据库实例ID列表，最多支持10个。
        /// </summary>
        [JsonProperty("instance_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// 数据库实例IP
        /// </summary>
        [JsonProperty("instance_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceIp { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Tags { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [JsonProperty("service_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceName { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 计费模式，包括是、否以及全部三种情况，不填默认为全部
        /// </summary>
        [JsonProperty("is_billing", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsBilling { get; set; }

        /// <summary>
        /// 消费时间
        /// </summary>
        [JsonProperty("begin_at", NullValueHandling = NullValueHandling.Ignore)]
        public string BeginAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuerySubscriptionsReq {\n");
            sb.Append("  jobType: ").Append(JobType).Append("\n");
            sb.Append("  engineType: ").Append(EngineType).Append("\n");
            sb.Append("  netType: ").Append(NetType).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  sortKey: ").Append(SortKey).Append("\n");
            sb.Append("  sortDir: ").Append(SortDir).Append("\n");
            sb.Append("  instanceIds: ").Append(InstanceIds).Append("\n");
            sb.Append("  instanceIp: ").Append(InstanceIp).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  serviceName: ").Append(ServiceName).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  isBilling: ").Append(IsBilling).Append("\n");
            sb.Append("  beginAt: ").Append(BeginAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QuerySubscriptionsReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QuerySubscriptionsReq input)
        {
            if (input == null) return false;
            if (this.JobType != input.JobType || (this.JobType != null && !this.JobType.Equals(input.JobType))) return false;
            if (this.EngineType != input.EngineType || (this.EngineType != null && !this.EngineType.Equals(input.EngineType))) return false;
            if (this.NetType != input.NetType || (this.NetType != null && !this.NetType.Equals(input.NetType))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.SortKey != input.SortKey || (this.SortKey != null && !this.SortKey.Equals(input.SortKey))) return false;
            if (this.SortDir != input.SortDir || (this.SortDir != null && !this.SortDir.Equals(input.SortDir))) return false;
            if (this.InstanceIds != input.InstanceIds || (this.InstanceIds != null && input.InstanceIds != null && !this.InstanceIds.SequenceEqual(input.InstanceIds))) return false;
            if (this.InstanceIp != input.InstanceIp || (this.InstanceIp != null && !this.InstanceIp.Equals(input.InstanceIp))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.ServiceName != input.ServiceName || (this.ServiceName != null && !this.ServiceName.Equals(input.ServiceName))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.IsBilling != input.IsBilling || (this.IsBilling != null && !this.IsBilling.Equals(input.IsBilling))) return false;
            if (this.BeginAt != input.BeginAt || (this.BeginAt != null && !this.BeginAt.Equals(input.BeginAt))) return false;

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
                if (this.JobType != null) hashCode = hashCode * 59 + this.JobType.GetHashCode();
                if (this.EngineType != null) hashCode = hashCode * 59 + this.EngineType.GetHashCode();
                if (this.NetType != null) hashCode = hashCode * 59 + this.NetType.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.SortKey != null) hashCode = hashCode * 59 + this.SortKey.GetHashCode();
                if (this.SortDir != null) hashCode = hashCode * 59 + this.SortDir.GetHashCode();
                if (this.InstanceIds != null) hashCode = hashCode * 59 + this.InstanceIds.GetHashCode();
                if (this.InstanceIp != null) hashCode = hashCode * 59 + this.InstanceIp.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.ServiceName != null) hashCode = hashCode * 59 + this.ServiceName.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.IsBilling != null) hashCode = hashCode * 59 + this.IsBilling.GetHashCode();
                if (this.BeginAt != null) hashCode = hashCode * 59 + this.BeginAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
