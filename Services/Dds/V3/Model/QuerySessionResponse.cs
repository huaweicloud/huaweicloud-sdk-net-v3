using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// 会话详细信息列表。
    /// </summary>
    public class QuerySessionResponse 
    {

        /// <summary>
        /// 会话ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 当前会话是否活跃。 取值为“true”，表示活跃。 取值为“false”，表示不活跃。
        /// </summary>
        [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; }

        /// <summary>
        /// 操作。
        /// </summary>
        [JsonProperty("operation", NullValueHandling = NullValueHandling.Ignore)]
        public string Operation { get; set; }

        /// <summary>
        /// 操作类型。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 运行时间，单位为 us。
        /// </summary>
        [JsonProperty("cost_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CostTime { get; set; }

        /// <summary>
        /// 执行计划描述。
        /// </summary>
        [JsonProperty("plan_summary", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanSummary { get; set; }

        /// <summary>
        /// 主机。
        /// </summary>
        [JsonProperty("host", NullValueHandling = NullValueHandling.Ignore)]
        public string Host { get; set; }

        /// <summary>
        /// 客户端地址。
        /// </summary>
        [JsonProperty("client", NullValueHandling = NullValueHandling.Ignore)]
        public string Client { get; set; }

        /// <summary>
        /// 连接描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 命名空间。
        /// </summary>
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuerySessionResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  active: ").Append(Active).Append("\n");
            sb.Append("  operation: ").Append(Operation).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  costTime: ").Append(CostTime).Append("\n");
            sb.Append("  planSummary: ").Append(PlanSummary).Append("\n");
            sb.Append("  host: ").Append(Host).Append("\n");
            sb.Append("  _Client: ").Append(Client).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QuerySessionResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QuerySessionResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Active != input.Active || (this.Active != null && !this.Active.Equals(input.Active))) return false;
            if (this.Operation != input.Operation || (this.Operation != null && !this.Operation.Equals(input.Operation))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.CostTime != input.CostTime || (this.CostTime != null && !this.CostTime.Equals(input.CostTime))) return false;
            if (this.PlanSummary != input.PlanSummary || (this.PlanSummary != null && !this.PlanSummary.Equals(input.PlanSummary))) return false;
            if (this.Host != input.Host || (this.Host != null && !this.Host.Equals(input.Host))) return false;
            if (this.Client != input.Client || (this.Client != null && !this.Client.Equals(input.Client))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Namespace != input.Namespace || (this.Namespace != null && !this.Namespace.Equals(input.Namespace))) return false;

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
                if (this.Active != null) hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.Operation != null) hashCode = hashCode * 59 + this.Operation.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.CostTime != null) hashCode = hashCode * 59 + this.CostTime.GetHashCode();
                if (this.PlanSummary != null) hashCode = hashCode * 59 + this.PlanSummary.GetHashCode();
                if (this.Host != null) hashCode = hashCode * 59 + this.Host.GetHashCode();
                if (this.Client != null) hashCode = hashCode * 59 + this.Client.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Namespace != null) hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                return hashCode;
            }
        }
    }
}
