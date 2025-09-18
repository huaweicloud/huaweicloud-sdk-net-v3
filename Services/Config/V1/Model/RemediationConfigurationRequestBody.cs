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
    /// 合规规则修正配置的请求体。
    /// </summary>
    public class RemediationConfigurationRequestBody 
    {
        /// <summary>
        /// 合规规则修正执行的方式。
        /// </summary>
        /// <value>合规规则修正执行的方式。</value>
        [JsonConverter(typeof(EnumClassConverter<TargetTypeEnum>))]
        public class TargetTypeEnum
        {
            /// <summary>
            /// Enum FGS for value: fgs
            /// </summary>
            public static readonly TargetTypeEnum FGS = new TargetTypeEnum("fgs");

            /// <summary>
            /// Enum RFS for value: rfs
            /// </summary>
            public static readonly TargetTypeEnum RFS = new TargetTypeEnum("rfs");

            private static readonly Dictionary<string, TargetTypeEnum> StaticFields =
            new Dictionary<string, TargetTypeEnum>()
            {
                { "fgs", FGS },
                { "rfs", RFS },
            };

            private string _value;

            public TargetTypeEnum()
            {

            }

            public TargetTypeEnum(string value)
            {
                _value = value;
            }

            public static TargetTypeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as TargetTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TargetTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TargetTypeEnum a, TargetTypeEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(TargetTypeEnum a, TargetTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 合规规则修正配置的权限方式。
        /// </summary>
        /// <value>合规规则修正配置的权限方式。</value>
        [JsonConverter(typeof(EnumClassConverter<AuthTypeEnum>))]
        public class AuthTypeEnum
        {
            /// <summary>
            /// Enum AGENCY for value: agency
            /// </summary>
            public static readonly AuthTypeEnum AGENCY = new AuthTypeEnum("agency");

            /// <summary>
            /// Enum TRUSTAGENCY for value: trustAgency
            /// </summary>
            public static readonly AuthTypeEnum TRUSTAGENCY = new AuthTypeEnum("trustAgency");

            private static readonly Dictionary<string, AuthTypeEnum> StaticFields =
            new Dictionary<string, AuthTypeEnum>()
            {
                { "agency", AGENCY },
                { "trustAgency", TRUSTAGENCY },
            };

            private string _value;

            public AuthTypeEnum()
            {

            }

            public AuthTypeEnum(string value)
            {
                _value = value;
            }

            public static AuthTypeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as AuthTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AuthTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AuthTypeEnum a, AuthTypeEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(AuthTypeEnum a, AuthTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 是否为自动修正。
        /// </summary>
        [JsonProperty("automatic", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Automatic { get; set; }

        /// <summary>
        /// 合规规则修正执行的方式。
        /// </summary>
        [JsonProperty("target_type", NullValueHandling = NullValueHandling.Ignore)]
        public TargetTypeEnum TargetType { get; set; }
        /// <summary>
        /// 修正执行的目标ID。如果修正方式为fgs，则该值为函数工作流的函数urn；如果修正方式为rfs，则该值为资源编排服务的模板name与版本号，两者以/分割，如果没有指定默认V1。
        /// </summary>
        [JsonProperty("target_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetId { get; set; }

        /// <summary>
        /// 修正执行的目标的regionId。如果修正方式为RFS，该字段为空则Config服务会默认配置北京四（中国站）或香港一（国际站）的regionId；如果修正方式为FGS，该字段为空则Config服务会根据实例urn自动配置。
        /// </summary>
        [JsonProperty("target_region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetRegionId { get; set; }

        /// <summary>
        /// 修正执行的目标的projectId。如果修正方式为RFS，该字段为空则Config服务会默认配置北京四（中国站）或香港一（国际站）的主projectId；如果修正方式为FGS，该字段为空则Config服务会根据实例urn自动配置。指定target_region_id字段则该字段必选。
        /// </summary>
        [JsonProperty("target_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetProjectId { get; set; }

        /// <summary>
        /// 修正执行的静态参数。
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
        public AuthTypeEnum AuthType { get; set; }
        /// <summary>
        /// 合规规则修正配置的权限信息。
        /// </summary>
        [JsonProperty("auth_value", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemediationConfigurationRequestBody {\n");
            sb.Append("  automatic: ").Append(Automatic).Append("\n");
            sb.Append("  targetType: ").Append(TargetType).Append("\n");
            sb.Append("  targetId: ").Append(TargetId).Append("\n");
            sb.Append("  targetRegionId: ").Append(TargetRegionId).Append("\n");
            sb.Append("  targetProjectId: ").Append(TargetProjectId).Append("\n");
            sb.Append("  staticParameter: ").Append(StaticParameter).Append("\n");
            sb.Append("  resourceParameter: ").Append(ResourceParameter).Append("\n");
            sb.Append("  maximumAttempts: ").Append(MaximumAttempts).Append("\n");
            sb.Append("  retryAttemptSeconds: ").Append(RetryAttemptSeconds).Append("\n");
            sb.Append("  authType: ").Append(AuthType).Append("\n");
            sb.Append("  authValue: ").Append(AuthValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RemediationConfigurationRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RemediationConfigurationRequestBody input)
        {
            if (input == null) return false;
            if (this.Automatic != input.Automatic || (this.Automatic != null && !this.Automatic.Equals(input.Automatic))) return false;
            if (this.TargetType != input.TargetType) return false;
            if (this.TargetId != input.TargetId || (this.TargetId != null && !this.TargetId.Equals(input.TargetId))) return false;
            if (this.TargetRegionId != input.TargetRegionId || (this.TargetRegionId != null && !this.TargetRegionId.Equals(input.TargetRegionId))) return false;
            if (this.TargetProjectId != input.TargetProjectId || (this.TargetProjectId != null && !this.TargetProjectId.Equals(input.TargetProjectId))) return false;
            if (this.StaticParameter != input.StaticParameter || (this.StaticParameter != null && input.StaticParameter != null && !this.StaticParameter.SequenceEqual(input.StaticParameter))) return false;
            if (this.ResourceParameter != input.ResourceParameter || (this.ResourceParameter != null && !this.ResourceParameter.Equals(input.ResourceParameter))) return false;
            if (this.MaximumAttempts != input.MaximumAttempts || (this.MaximumAttempts != null && !this.MaximumAttempts.Equals(input.MaximumAttempts))) return false;
            if (this.RetryAttemptSeconds != input.RetryAttemptSeconds || (this.RetryAttemptSeconds != null && !this.RetryAttemptSeconds.Equals(input.RetryAttemptSeconds))) return false;
            if (this.AuthType != input.AuthType) return false;
            if (this.AuthValue != input.AuthValue || (this.AuthValue != null && !this.AuthValue.Equals(input.AuthValue))) return false;

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
                hashCode = hashCode * 59 + this.TargetType.GetHashCode();
                if (this.TargetId != null) hashCode = hashCode * 59 + this.TargetId.GetHashCode();
                if (this.TargetRegionId != null) hashCode = hashCode * 59 + this.TargetRegionId.GetHashCode();
                if (this.TargetProjectId != null) hashCode = hashCode * 59 + this.TargetProjectId.GetHashCode();
                if (this.StaticParameter != null) hashCode = hashCode * 59 + this.StaticParameter.GetHashCode();
                if (this.ResourceParameter != null) hashCode = hashCode * 59 + this.ResourceParameter.GetHashCode();
                if (this.MaximumAttempts != null) hashCode = hashCode * 59 + this.MaximumAttempts.GetHashCode();
                if (this.RetryAttemptSeconds != null) hashCode = hashCode * 59 + this.RetryAttemptSeconds.GetHashCode();
                hashCode = hashCode * 59 + this.AuthType.GetHashCode();
                if (this.AuthValue != null) hashCode = hashCode * 59 + this.AuthValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
