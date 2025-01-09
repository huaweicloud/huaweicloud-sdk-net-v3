using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListPolicyGroupRequest 
    {

        /// <summary>
        /// 用于分页查询，返回策略组数量的限制。如果不指定，则返回所有符合条件的策略组。范围0~100。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 用于分页查询，查询的起始记录序号，从0开始。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 根据策略组ID过滤结果。
        /// </summary>
        [SDKProperty("policy_group_id", IsQuery = true)]
        [JsonProperty("policy_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyGroupId { get; set; }

        /// <summary>
        /// 根据策略组名字过滤结果。
        /// </summary>
        [SDKProperty("policy_group_name", IsQuery = true)]
        [JsonProperty("policy_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyGroupName { get; set; }

        /// <summary>
        /// 根据优先级过滤结果。所带的值需要满足现有策略组已有最大优先级值
        /// </summary>
        [SDKProperty("priority", IsQuery = true)]
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        /// <summary>
        /// 根据更新时间过滤结果。时间格式满足：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [SDKProperty("update_time", IsQuery = true)]
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 策略组描述
        /// </summary>
        [SDKProperty("description", IsQuery = true)]
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 策略来源，取值范围0或者1
        /// </summary>
        [SDKProperty("scope_flag", IsQuery = true)]
        [JsonProperty("scope_flag", NullValueHandling = NullValueHandling.Ignore)]
        public int? ScopeFlag { get; set; }

        /// <summary>
        /// 策略组名字精确查询。
        /// </summary>
        [SDKProperty("is_group_name_accurate", IsQuery = true)]
        [JsonProperty("is_group_name_accurate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsGroupNameAccurate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPolicyGroupRequest {\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  policyGroupId: ").Append(PolicyGroupId).Append("\n");
            sb.Append("  policyGroupName: ").Append(PolicyGroupName).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  scopeFlag: ").Append(ScopeFlag).Append("\n");
            sb.Append("  isGroupNameAccurate: ").Append(IsGroupNameAccurate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPolicyGroupRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPolicyGroupRequest input)
        {
            if (input == null) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.PolicyGroupId != input.PolicyGroupId || (this.PolicyGroupId != null && !this.PolicyGroupId.Equals(input.PolicyGroupId))) return false;
            if (this.PolicyGroupName != input.PolicyGroupName || (this.PolicyGroupName != null && !this.PolicyGroupName.Equals(input.PolicyGroupName))) return false;
            if (this.Priority != input.Priority || (this.Priority != null && !this.Priority.Equals(input.Priority))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.ScopeFlag != input.ScopeFlag || (this.ScopeFlag != null && !this.ScopeFlag.Equals(input.ScopeFlag))) return false;
            if (this.IsGroupNameAccurate != input.IsGroupNameAccurate || (this.IsGroupNameAccurate != null && !this.IsGroupNameAccurate.Equals(input.IsGroupNameAccurate))) return false;

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
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.PolicyGroupId != null) hashCode = hashCode * 59 + this.PolicyGroupId.GetHashCode();
                if (this.PolicyGroupName != null) hashCode = hashCode * 59 + this.PolicyGroupName.GetHashCode();
                if (this.Priority != null) hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ScopeFlag != null) hashCode = hashCode * 59 + this.ScopeFlag.GetHashCode();
                if (this.IsGroupNameAccurate != null) hashCode = hashCode * 59 + this.IsGroupNameAccurate.GetHashCode();
                return hashCode;
            }
        }
    }
}
