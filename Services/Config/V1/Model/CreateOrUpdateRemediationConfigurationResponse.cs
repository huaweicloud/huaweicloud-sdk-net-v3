using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateOrUpdateRemediationConfigurationResponse : SdkResponse
    {

        /// <summary>
        /// 是否为自动修正。
        /// </summary>
        [JsonProperty("automatic", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Automatic { get; set; }

        /// <summary>
        /// 合规规则修正执行的方式。
        /// </summary>
        [JsonProperty("target_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetType { get; set; }

        /// <summary>
        /// 修正执行的目标ID。如果修正方式为fgs，则该值为函数工作流的函数urn；如果修正方式为rfs，则该值为资源编排服务的模板name与版本号，两者以/分割，如果没有指定默认V1。
        /// </summary>
        [JsonProperty("target_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetId { get; set; }

        /// <summary>
        /// 修正执行的参数。
        /// </summary>
        [JsonProperty("static_parameter", NullValueHandling = NullValueHandling.Ignore)]
        public List<RemediationStaticParameter> StaticParameter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("resource_parameter", NullValueHandling = NullValueHandling.Ignore)]
        public RemediationResourceParameter ResourceParameter { get; set; }

        /// <summary>
        /// 指定时间内修正的最大尝试次数。
        /// </summary>
        [JsonProperty("maximum_attempts", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaximumAttempts { get; set; }

        /// <summary>
        /// 用于防止循环修正的时间窗口，如果在指定时间内进行了自动修正的最大尝试次数，则将资源添加至修正例外。
        /// </summary>
        [JsonProperty("retry_attempt_seconds", NullValueHandling = NullValueHandling.Ignore)]
        public int? RetryAttemptSeconds { get; set; }

        /// <summary>
        /// 合规规则修正配置的权限方式。
        /// </summary>
        [JsonProperty("auth_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthType { get; set; }

        /// <summary>
        /// 合规规则修正配置的权限信息。
        /// </summary>
        [JsonProperty("auth_value", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthValue { get; set; }

        /// <summary>
        /// 修正配置的创建时间。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 修正配置的更新时间。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// 创建者。
        /// </summary>
        [JsonProperty("created_by", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateOrUpdateRemediationConfigurationResponse {\n");
            sb.Append("  automatic: ").Append(Automatic).Append("\n");
            sb.Append("  targetType: ").Append(TargetType).Append("\n");
            sb.Append("  targetId: ").Append(TargetId).Append("\n");
            sb.Append("  staticParameter: ").Append(StaticParameter).Append("\n");
            sb.Append("  resourceParameter: ").Append(ResourceParameter).Append("\n");
            sb.Append("  maximumAttempts: ").Append(MaximumAttempts).Append("\n");
            sb.Append("  retryAttemptSeconds: ").Append(RetryAttemptSeconds).Append("\n");
            sb.Append("  authType: ").Append(AuthType).Append("\n");
            sb.Append("  authValue: ").Append(AuthValue).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  createdBy: ").Append(CreatedBy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateOrUpdateRemediationConfigurationResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateOrUpdateRemediationConfigurationResponse input)
        {
            if (input == null) return false;
            if (this.Automatic != input.Automatic || (this.Automatic != null && !this.Automatic.Equals(input.Automatic))) return false;
            if (this.TargetType != input.TargetType || (this.TargetType != null && !this.TargetType.Equals(input.TargetType))) return false;
            if (this.TargetId != input.TargetId || (this.TargetId != null && !this.TargetId.Equals(input.TargetId))) return false;
            if (this.StaticParameter != input.StaticParameter || (this.StaticParameter != null && input.StaticParameter != null && !this.StaticParameter.SequenceEqual(input.StaticParameter))) return false;
            if (this.ResourceParameter != input.ResourceParameter || (this.ResourceParameter != null && !this.ResourceParameter.Equals(input.ResourceParameter))) return false;
            if (this.MaximumAttempts != input.MaximumAttempts || (this.MaximumAttempts != null && !this.MaximumAttempts.Equals(input.MaximumAttempts))) return false;
            if (this.RetryAttemptSeconds != input.RetryAttemptSeconds || (this.RetryAttemptSeconds != null && !this.RetryAttemptSeconds.Equals(input.RetryAttemptSeconds))) return false;
            if (this.AuthType != input.AuthType || (this.AuthType != null && !this.AuthType.Equals(input.AuthType))) return false;
            if (this.AuthValue != input.AuthValue || (this.AuthValue != null && !this.AuthValue.Equals(input.AuthValue))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.CreatedBy != input.CreatedBy || (this.CreatedBy != null && !this.CreatedBy.Equals(input.CreatedBy))) return false;

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
                if (this.Automatic != null) hashCode = hashCode * 59 + this.Automatic.GetHashCode();
                if (this.TargetType != null) hashCode = hashCode * 59 + this.TargetType.GetHashCode();
                if (this.TargetId != null) hashCode = hashCode * 59 + this.TargetId.GetHashCode();
                if (this.StaticParameter != null) hashCode = hashCode * 59 + this.StaticParameter.GetHashCode();
                if (this.ResourceParameter != null) hashCode = hashCode * 59 + this.ResourceParameter.GetHashCode();
                if (this.MaximumAttempts != null) hashCode = hashCode * 59 + this.MaximumAttempts.GetHashCode();
                if (this.RetryAttemptSeconds != null) hashCode = hashCode * 59 + this.RetryAttemptSeconds.GetHashCode();
                if (this.AuthType != null) hashCode = hashCode * 59 + this.AuthType.GetHashCode();
                if (this.AuthValue != null) hashCode = hashCode * 59 + this.AuthValue.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.CreatedBy != null) hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                return hashCode;
            }
        }
    }
}
