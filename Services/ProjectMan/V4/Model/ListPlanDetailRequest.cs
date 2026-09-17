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
    /// Request Object
    /// </summary>
    public class ListPlanDetailRequest 
    {

        /// <summary>
        /// 项目32位ID，项目唯一标识。通过查询IPD项目列表获取，响应消息体中的id字段的值就是项目ID。
        /// </summary>
        [SDKProperty("project_id", IsPath = true)]
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// **参数解释**： 发布/迭代唯一ID。可以通过[发布/迭代计划列表查询](ListPlan.xml)接口获取，响应消息体中的**id**字段的值就是发布/迭代ID。 **约束限制**： 长度为18-19位的数字字符串。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("plan_id", IsPath = true)]
        [JsonProperty("plan_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPlanDetailRequest {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  planId: ").Append(PlanId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPlanDetailRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPlanDetailRequest input)
        {
            if (input == null) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.PlanId != input.PlanId || (this.PlanId != null && !this.PlanId.Equals(input.PlanId))) return false;

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
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.PlanId != null) hashCode = hashCode * 59 + this.PlanId.GetHashCode();
                return hashCode;
            }
        }
    }
}
