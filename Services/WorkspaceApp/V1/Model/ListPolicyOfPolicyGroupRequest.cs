using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListPolicyOfPolicyGroupRequest 
    {

        /// <summary>
        /// 策略组id。
        /// </summary>
        [SDKProperty("policy_group_id", IsPath = true)]
        [JsonProperty("policy_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyGroupId { get; set; }

        /// <summary>
        /// 根据策略类型过滤结果，不传则查询所有策略。 可选类型: - 外设：Peripherals; - 音频：Audio; - 客户端：Client; - 显示：Display; - 文件与剪切板：FileAndClip; - 接入控制：ClientAccessControl; - 会话：SessionAutoDisconnect; - 虚拟通道：VirtualChannel - 键盘鼠标：KeyboardAndMouse; - 通用音视频旁路：Seamless。
        /// </summary>
        [SDKProperty("policy_type", IsQuery = true)]
        [JsonProperty("policy_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPolicyOfPolicyGroupRequest {\n");
            sb.Append("  policyGroupId: ").Append(PolicyGroupId).Append("\n");
            sb.Append("  policyType: ").Append(PolicyType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPolicyOfPolicyGroupRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPolicyOfPolicyGroupRequest input)
        {
            if (input == null) return false;
            if (this.PolicyGroupId != input.PolicyGroupId || (this.PolicyGroupId != null && !this.PolicyGroupId.Equals(input.PolicyGroupId))) return false;
            if (this.PolicyType != input.PolicyType || (this.PolicyType != null && !this.PolicyType.Equals(input.PolicyType))) return false;

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
                if (this.PolicyGroupId != null) hashCode = hashCode * 59 + this.PolicyGroupId.GetHashCode();
                if (this.PolicyType != null) hashCode = hashCode * 59 + this.PolicyType.GetHashCode();
                return hashCode;
            }
        }
    }
}
