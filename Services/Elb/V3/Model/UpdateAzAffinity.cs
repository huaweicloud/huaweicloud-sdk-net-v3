using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// 参数解释：后端服务器组可用区亲和策略配置。
    /// </summary>
    public class UpdateAzAffinity 
    {

        /// <summary>
        /// 参数解释：后端服务器组可用区亲和开关。  约束限制： - 当后端服务器组中有未设置availability_zone属性的iptarget类型的后端服务器时无法开启可用区亲和。 - 当后端服务器绑定TLS监听器时无法开启可用区亲和。 - 仅IP、UDP、TCP类型的后端服务器组支持开启可用区亲和。 - 当开启可用区亲和后，原本的pool_health配置失效。  取值范围：true或false，true表示开启，false表示关闭。
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable { get; set; }

        /// <summary>
        /// 参数解释：后端服务器组单可用区百分比健康度最小阈值，当“后端服务器组单可用区百分比健康度”小于该阈值时，触发可用区异常退避策略。“后端服务器组单可用区百分比健康度”是指在一个后端服务器组中，同可用区中健康检查结果正常的服务器数量与该后端服务器组中属于该可用区的后端服务器总数量的比值，百分比结果向上取整。例如：后端服务器组中属于可用区A的后端服务器总数量为3，设置后端服务器组单可用区百分比健康度最小阈值为66时，3x0.66&#x3D;1.98向上取整为数量阈值2台，即属于可用区A的健康后端数小于2台时触发退避策略；设置后端服务器组单可用区百分比健康度最小阈值为67时，3x0.67&#x3D;2.01向上取整为数量阈值3台，即属于可用区A的健康后端数小于3台时触发退避策略。  约束限制： - enable为true时，az_minimum_healthy_member_percentage与az_minimum_healthy_member_count不能同时为-1 - enable为true时，az_minimum_healthy_member_percentage与az_minimum_healthy_member_count不能同时不为-1  取值范围：-1至100的整数，0-100为百分比范围，-1表示采用数量阈值。
        /// </summary>
        [JsonProperty("az_minimum_healthy_member_percentage", NullValueHandling = NullValueHandling.Ignore)]
        public int? AzMinimumHealthyMemberPercentage { get; set; }

        /// <summary>
        /// 参数解释：后端服务器组单可用区中数量健康度最小阈值，当“后端服务器组单可用区中数量健康度”小于该阈值时，触发可用区异常退避策略。“后端服务器组单可用区中数量健康度”是指在一个后端服务器组中，属于同一个可用区的健康检查结果正常的服务器数量。  约束限制： - enable为true时，az_minimum_healthy_member_percentage与az_minimum_healthy_member_count不能同时为-1 - enable为true时，az_minimum_healthy_member_percentage与az_minimum_healthy_member_count不能同时不为-1  取值范围：-1至10000的整数，0-10000为数量范围，-1表示采用百分比阈值。
        /// </summary>
        [JsonProperty("az_minimum_healthy_member_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? AzMinimumHealthyMemberCount { get; set; }

        /// <summary>
        /// 参数解释：后端服务器组单可用区异常退避策略。后端服务器组的健康度小于所配置的最小阈值时，触发该退避策略。 forward_to_all_member_of_local_az：转发至同可用区的所有后端服务器，无论健康检查结果是否正常；forward_to_healthy_member_of_remote_az：转发至非同可用区中所有健康检查结果正常的后端服务器；forward_to_all_healthy_member：转发至所有可用区中健康检查结果正常的后端服务器；forward_to_all_member：转发至所有可用区中的所有后端服务器，无论健康检查结果是否正常  取值范围：forward_to_all_member_of_local_az，forward_to_healthy_member_of_remote_az，forward_to_all_healthy_member，forward_to_all_member。 默认值：forward_to_all_member_of_local_az
        /// </summary>
        [JsonProperty("az_unhealthy_fallback_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public string AzUnhealthyFallbackStrategy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAzAffinity {\n");
            sb.Append("  enable: ").Append(Enable).Append("\n");
            sb.Append("  azMinimumHealthyMemberPercentage: ").Append(AzMinimumHealthyMemberPercentage).Append("\n");
            sb.Append("  azMinimumHealthyMemberCount: ").Append(AzMinimumHealthyMemberCount).Append("\n");
            sb.Append("  azUnhealthyFallbackStrategy: ").Append(AzUnhealthyFallbackStrategy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateAzAffinity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateAzAffinity input)
        {
            if (input == null) return false;
            if (this.Enable != input.Enable || (this.Enable != null && !this.Enable.Equals(input.Enable))) return false;
            if (this.AzMinimumHealthyMemberPercentage != input.AzMinimumHealthyMemberPercentage || (this.AzMinimumHealthyMemberPercentage != null && !this.AzMinimumHealthyMemberPercentage.Equals(input.AzMinimumHealthyMemberPercentage))) return false;
            if (this.AzMinimumHealthyMemberCount != input.AzMinimumHealthyMemberCount || (this.AzMinimumHealthyMemberCount != null && !this.AzMinimumHealthyMemberCount.Equals(input.AzMinimumHealthyMemberCount))) return false;
            if (this.AzUnhealthyFallbackStrategy != input.AzUnhealthyFallbackStrategy || (this.AzUnhealthyFallbackStrategy != null && !this.AzUnhealthyFallbackStrategy.Equals(input.AzUnhealthyFallbackStrategy))) return false;

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
                if (this.Enable != null) hashCode = hashCode * 59 + this.Enable.GetHashCode();
                if (this.AzMinimumHealthyMemberPercentage != null) hashCode = hashCode * 59 + this.AzMinimumHealthyMemberPercentage.GetHashCode();
                if (this.AzMinimumHealthyMemberCount != null) hashCode = hashCode * 59 + this.AzMinimumHealthyMemberCount.GetHashCode();
                if (this.AzUnhealthyFallbackStrategy != null) hashCode = hashCode * 59 + this.AzUnhealthyFallbackStrategy.GetHashCode();
                return hashCode;
            }
        }
    }
}
