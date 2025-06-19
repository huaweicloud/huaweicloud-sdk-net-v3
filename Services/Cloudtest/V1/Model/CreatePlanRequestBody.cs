using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 创建计划请求体
    /// </summary>
    public class CreatePlanRequestBody 
    {

        /// <summary>
        /// 计划名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 处理者id，不填时默认使用当前用户
        /// </summary>
        [JsonProperty("assigned_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssignedId { get; set; }

        /// <summary>
        /// 计划下包含的用例类型，数组长度小于10个
        /// </summary>
        [JsonProperty("service_id_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> ServiceIdList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("plan_cycle", NullValueHandling = NullValueHandling.Ignore)]
        public PlanCycle PlanCycle { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePlanRequestBody {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  assignedId: ").Append(AssignedId).Append("\n");
            sb.Append("  serviceIdList: ").Append(ServiceIdList).Append("\n");
            sb.Append("  planCycle: ").Append(PlanCycle).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreatePlanRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreatePlanRequestBody input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.AssignedId != input.AssignedId || (this.AssignedId != null && !this.AssignedId.Equals(input.AssignedId))) return false;
            if (this.ServiceIdList != input.ServiceIdList || (this.ServiceIdList != null && input.ServiceIdList != null && !this.ServiceIdList.SequenceEqual(input.ServiceIdList))) return false;
            if (this.PlanCycle != input.PlanCycle || (this.PlanCycle != null && !this.PlanCycle.Equals(input.PlanCycle))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AssignedId != null) hashCode = hashCode * 59 + this.AssignedId.GetHashCode();
                if (this.ServiceIdList != null) hashCode = hashCode * 59 + this.ServiceIdList.GetHashCode();
                if (this.PlanCycle != null) hashCode = hashCode * 59 + this.PlanCycle.GetHashCode();
                return hashCode;
            }
        }
    }
}
