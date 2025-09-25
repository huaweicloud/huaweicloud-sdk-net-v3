using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsPipeline.V2.Model
{
    /// <summary>
    /// 创建流水线接口入参
    /// </summary>
    public class TemplateCddl 
    {

        /// <summary>
        /// **参数解释**： 编排flow详情，描述流水线内各阶段任务的串并行关系。map类型数据，key为阶段名字，默认第一阶段initial，最后阶段为final，其余名字以&#39;state_数字&#39;标识。value为该阶段内任务 (以&#39;Task_数字&#39;标识)以及后续阶段的标识。本字段为描述流水线基础编排数据之一，建议可通过流水线真实界面基于模板创建接口中获取。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("flow", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Dictionary<string, string>> Flow { get; set; }

        /// <summary>
        /// **参数解释**： 编排State详情，map类型数据。本字段为描述流水线基础编排数据之一，建议可通过流水线真实界面基于模板创建接口中获取 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("states", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, TemplateState> States { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("workflow", NullValueHandling = NullValueHandling.Ignore)]
        public Workflow Workflow { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateCddl {\n");
            sb.Append("  flow: ").Append(Flow).Append("\n");
            sb.Append("  states: ").Append(States).Append("\n");
            sb.Append("  workflow: ").Append(Workflow).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TemplateCddl);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TemplateCddl input)
        {
            if (input == null) return false;
            if (this.Flow != input.Flow || (this.Flow != null && input.Flow != null && !this.Flow.SequenceEqual(input.Flow))) return false;
            if (this.States != input.States || (this.States != null && input.States != null && !this.States.SequenceEqual(input.States))) return false;
            if (this.Workflow != input.Workflow || (this.Workflow != null && !this.Workflow.Equals(input.Workflow))) return false;

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
                if (this.Flow != null) hashCode = hashCode * 59 + this.Flow.GetHashCode();
                if (this.States != null) hashCode = hashCode * 59 + this.States.GetHashCode();
                if (this.Workflow != null) hashCode = hashCode * 59 + this.Workflow.GetHashCode();
                return hashCode;
            }
        }
    }
}
