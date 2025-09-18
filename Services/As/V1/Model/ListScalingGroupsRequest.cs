using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.As.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListScalingGroupsRequest 
    {
        /// <summary>
        /// 伸缩组状态，取值如下：  - INSERVICE：正常状态 - PAUSED：停用状态 - ERROR：异常状态 - DELETING：删除中 - FREEZED：已冻结
        /// </summary>
        /// <value>伸缩组状态，取值如下：  - INSERVICE：正常状态 - PAUSED：停用状态 - ERROR：异常状态 - DELETING：删除中 - FREEZED：已冻结</value>
        [JsonConverter(typeof(EnumClassConverter<ScalingGroupStatusEnum>))]
        public class ScalingGroupStatusEnum
        {
            /// <summary>
            /// Enum INSERVICE for value: INSERVICE
            /// </summary>
            public static readonly ScalingGroupStatusEnum INSERVICE = new ScalingGroupStatusEnum("INSERVICE");

            /// <summary>
            /// Enum PAUSED for value: PAUSED
            /// </summary>
            public static readonly ScalingGroupStatusEnum PAUSED = new ScalingGroupStatusEnum("PAUSED");

            /// <summary>
            /// Enum ERROR for value: ERROR
            /// </summary>
            public static readonly ScalingGroupStatusEnum ERROR = new ScalingGroupStatusEnum("ERROR");

            /// <summary>
            /// Enum DELETING for value: DELETING
            /// </summary>
            public static readonly ScalingGroupStatusEnum DELETING = new ScalingGroupStatusEnum("DELETING");

            private static readonly Dictionary<string, ScalingGroupStatusEnum> StaticFields =
            new Dictionary<string, ScalingGroupStatusEnum>()
            {
                { "INSERVICE", INSERVICE },
                { "PAUSED", PAUSED },
                { "ERROR", ERROR },
                { "DELETING", DELETING },
            };

            private string _value;

            public ScalingGroupStatusEnum()
            {

            }

            public ScalingGroupStatusEnum(string value)
            {
                _value = value;
            }

            public static ScalingGroupStatusEnum FromValue(string value)
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

                if (this.Equals(obj as ScalingGroupStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ScalingGroupStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ScalingGroupStatusEnum a, ScalingGroupStatusEnum b)
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

            public static bool operator !=(ScalingGroupStatusEnum a, ScalingGroupStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 伸缩组名称
        /// </summary>
        [SDKProperty("scaling_group_name", IsQuery = true)]
        [JsonProperty("scaling_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalingGroupName { get; set; }

        /// <summary>
        /// 伸缩配置ID，通过查询弹性伸缩配置列表接口获取，详见[查询弹性伸缩配置列表](https://support.huaweicloud.com/api-as/as_06_0202.html)。
        /// </summary>
        [SDKProperty("scaling_configuration_id", IsQuery = true)]
        [JsonProperty("scaling_configuration_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalingConfigurationId { get; set; }

        /// <summary>
        /// 伸缩组状态，取值如下：  - INSERVICE：正常状态 - PAUSED：停用状态 - ERROR：异常状态 - DELETING：删除中 - FREEZED：已冻结
        /// </summary>
        [SDKProperty("scaling_group_status", IsQuery = true)]
        [JsonProperty("scaling_group_status", NullValueHandling = NullValueHandling.Ignore)]
        public ScalingGroupStatusEnum ScalingGroupStatus { get; set; }
        /// <summary>
        /// 查询的起始行号，默认为0。最小值为0，最大值没有限制。
        /// </summary>
        [SDKProperty("start_number", IsQuery = true)]
        [JsonProperty("start_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? StartNumber { get; set; }

        /// <summary>
        /// 查询的记录条数，默认为20。取值范围为：0~100。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 企业项目ID，当传入all_granted_eps时表示查询该用户所有授权的企业项目下的伸缩组列表，如何获取企业项目ID，请参考[查询企业项目列表](https://support.huaweicloud.com/api-em/zh-cn_topic_0121230880.html)。说明：华为云帐号和拥有全局权限的IAM用户可以查询该用户所有伸缩组列表。授予部分企业项目的IAM用户，如果拥有超过100个企业项目，则只能返回有权限的前100个企业项目对应的伸缩组列表。
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListScalingGroupsRequest {\n");
            sb.Append("  scalingGroupName: ").Append(ScalingGroupName).Append("\n");
            sb.Append("  scalingConfigurationId: ").Append(ScalingConfigurationId).Append("\n");
            sb.Append("  scalingGroupStatus: ").Append(ScalingGroupStatus).Append("\n");
            sb.Append("  startNumber: ").Append(StartNumber).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListScalingGroupsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListScalingGroupsRequest input)
        {
            if (input == null) return false;
            if (this.ScalingGroupName != input.ScalingGroupName || (this.ScalingGroupName != null && !this.ScalingGroupName.Equals(input.ScalingGroupName))) return false;
            if (this.ScalingConfigurationId != input.ScalingConfigurationId || (this.ScalingConfigurationId != null && !this.ScalingConfigurationId.Equals(input.ScalingConfigurationId))) return false;
            if (this.ScalingGroupStatus != input.ScalingGroupStatus) return false;
            if (this.StartNumber != input.StartNumber || (this.StartNumber != null && !this.StartNumber.Equals(input.StartNumber))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;

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
                if (this.ScalingGroupName != null) hashCode = hashCode * 59 + this.ScalingGroupName.GetHashCode();
                if (this.ScalingConfigurationId != null) hashCode = hashCode * 59 + this.ScalingConfigurationId.GetHashCode();
                hashCode = hashCode * 59 + this.ScalingGroupStatus.GetHashCode();
                if (this.StartNumber != null) hashCode = hashCode * 59 + this.StartNumber.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
