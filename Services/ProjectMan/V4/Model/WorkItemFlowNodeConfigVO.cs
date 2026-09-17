using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// 工作流节点配置
    /// </summary>
    public class WorkItemFlowNodeConfigVO 
    {

        /// <summary>
        /// 节点编码
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 节点描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 是否为结束节点
        /// </summary>
        [JsonProperty("end", NullValueHandling = NullValueHandling.Ignore)]
        public bool? End { get; set; }

        /// <summary>
        /// 是否为最末节点
        /// </summary>
        [JsonProperty("last", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Last { get; set; }

        /// <summary>
        /// 是否为开始节点
        /// </summary>
        [JsonProperty("start", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Start { get; set; }

        /// <summary>
        /// 是否允许挂起
        /// </summary>
        [JsonProperty("enable_suspend", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableSuspend { get; set; }

        /// <summary>
        /// 节点扩展配置
        /// </summary>
        [JsonProperty("extra_config", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> ExtraConfig { get; set; }

        /// <summary>
        /// 静态规则列表
        /// </summary>
        [JsonProperty("static_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<Dictionary<string, Object>> StaticRules { get; set; }

        /// <summary>
        /// 静态动作配置
        /// </summary>
        [JsonProperty("static_actions", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> StaticActions { get; set; }

        /// <summary>
        /// 是否任意状态可流转
        /// </summary>
        [JsonProperty("any_status", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AnyStatus { get; set; }

        /// <summary>
        /// 提交时是否可操作
        /// </summary>
        [JsonProperty("submit_can_operate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SubmitCanOperate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkItemFlowNodeConfigVO {\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  end: ").Append(End).Append("\n");
            sb.Append("  last: ").Append(Last).Append("\n");
            sb.Append("  start: ").Append(Start).Append("\n");
            sb.Append("  enableSuspend: ").Append(EnableSuspend).Append("\n");
            sb.Append("  extraConfig: ").Append(ExtraConfig).Append("\n");
            sb.Append("  staticRules: ").Append(StaticRules).Append("\n");
            sb.Append("  staticActions: ").Append(StaticActions).Append("\n");
            sb.Append("  anyStatus: ").Append(AnyStatus).Append("\n");
            sb.Append("  submitCanOperate: ").Append(SubmitCanOperate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkItemFlowNodeConfigVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkItemFlowNodeConfigVO input)
        {
            if (input == null) return false;
            if (this.Code != input.Code || (this.Code != null && !this.Code.Equals(input.Code))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.End != input.End || (this.End != null && !this.End.Equals(input.End))) return false;
            if (this.Last != input.Last || (this.Last != null && !this.Last.Equals(input.Last))) return false;
            if (this.Start != input.Start || (this.Start != null && !this.Start.Equals(input.Start))) return false;
            if (this.EnableSuspend != input.EnableSuspend || (this.EnableSuspend != null && !this.EnableSuspend.Equals(input.EnableSuspend))) return false;
            if (this.ExtraConfig != input.ExtraConfig || (this.ExtraConfig != null && input.ExtraConfig != null && !this.ExtraConfig.SequenceEqual(input.ExtraConfig))) return false;
            if (this.StaticRules != input.StaticRules || (this.StaticRules != null && input.StaticRules != null && !this.StaticRules.SequenceEqual(input.StaticRules))) return false;
            if (this.StaticActions != input.StaticActions || (this.StaticActions != null && input.StaticActions != null && !this.StaticActions.SequenceEqual(input.StaticActions))) return false;
            if (this.AnyStatus != input.AnyStatus || (this.AnyStatus != null && !this.AnyStatus.Equals(input.AnyStatus))) return false;
            if (this.SubmitCanOperate != input.SubmitCanOperate || (this.SubmitCanOperate != null && !this.SubmitCanOperate.Equals(input.SubmitCanOperate))) return false;

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
                if (this.Code != null) hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.End != null) hashCode = hashCode * 59 + this.End.GetHashCode();
                if (this.Last != null) hashCode = hashCode * 59 + this.Last.GetHashCode();
                if (this.Start != null) hashCode = hashCode * 59 + this.Start.GetHashCode();
                if (this.EnableSuspend != null) hashCode = hashCode * 59 + this.EnableSuspend.GetHashCode();
                if (this.ExtraConfig != null) hashCode = hashCode * 59 + this.ExtraConfig.GetHashCode();
                if (this.StaticRules != null) hashCode = hashCode * 59 + this.StaticRules.GetHashCode();
                if (this.StaticActions != null) hashCode = hashCode * 59 + this.StaticActions.GetHashCode();
                if (this.AnyStatus != null) hashCode = hashCode * 59 + this.AnyStatus.GetHashCode();
                if (this.SubmitCanOperate != null) hashCode = hashCode * 59 + this.SubmitCanOperate.GetHashCode();
                return hashCode;
            }
        }
    }
}
