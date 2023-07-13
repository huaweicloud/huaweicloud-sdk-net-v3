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
    public class ListAllScalingV2PoliciesRequest 
    {
        /// <summary>
        /// 伸缩资源类型：伸缩组：SCALING_GROUP；带宽：BANDWIDTH
        /// </summary>
        /// <value>伸缩资源类型：伸缩组：SCALING_GROUP；带宽：BANDWIDTH</value>
        [JsonConverter(typeof(EnumClassConverter<ScalingResourceTypeEnum>))]
        public class ScalingResourceTypeEnum
        {
            /// <summary>
            /// Enum SCALING_GROUP for value: SCALING_GROUP
            /// </summary>
            public static readonly ScalingResourceTypeEnum SCALING_GROUP = new ScalingResourceTypeEnum("SCALING_GROUP");

            /// <summary>
            /// Enum BANDWIDTH for value: BANDWIDTH
            /// </summary>
            public static readonly ScalingResourceTypeEnum BANDWIDTH = new ScalingResourceTypeEnum("BANDWIDTH");

            private static readonly Dictionary<string, ScalingResourceTypeEnum> StaticFields =
            new Dictionary<string, ScalingResourceTypeEnum>()
            {
                { "SCALING_GROUP", SCALING_GROUP },
                { "BANDWIDTH", BANDWIDTH },
            };

            private string _value;

            public ScalingResourceTypeEnum()
            {

            }

            public ScalingResourceTypeEnum(string value)
            {
                _value = value;
            }

            public static ScalingResourceTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ScalingResourceTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ScalingResourceTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ScalingResourceTypeEnum a, ScalingResourceTypeEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(ScalingResourceTypeEnum a, ScalingResourceTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 策略类型。  告警策略：ALARM ,定时策略：SCHEDULED, 周期策略：RECURRENCE
        /// </summary>
        /// <value>策略类型。  告警策略：ALARM ,定时策略：SCHEDULED, 周期策略：RECURRENCE</value>
        [JsonConverter(typeof(EnumClassConverter<ScalingPolicyTypeEnum>))]
        public class ScalingPolicyTypeEnum
        {
            /// <summary>
            /// Enum ALARM for value: ALARM
            /// </summary>
            public static readonly ScalingPolicyTypeEnum ALARM = new ScalingPolicyTypeEnum("ALARM");

            /// <summary>
            /// Enum SCHEDULED for value: SCHEDULED
            /// </summary>
            public static readonly ScalingPolicyTypeEnum SCHEDULED = new ScalingPolicyTypeEnum("SCHEDULED");

            /// <summary>
            /// Enum RECURRENCE for value: RECURRENCE
            /// </summary>
            public static readonly ScalingPolicyTypeEnum RECURRENCE = new ScalingPolicyTypeEnum("RECURRENCE");

            private static readonly Dictionary<string, ScalingPolicyTypeEnum> StaticFields =
            new Dictionary<string, ScalingPolicyTypeEnum>()
            {
                { "ALARM", ALARM },
                { "SCHEDULED", SCHEDULED },
                { "RECURRENCE", RECURRENCE },
            };

            private string _value;

            public ScalingPolicyTypeEnum()
            {

            }

            public ScalingPolicyTypeEnum(string value)
            {
                _value = value;
            }

            public static ScalingPolicyTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ScalingPolicyTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ScalingPolicyTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ScalingPolicyTypeEnum a, ScalingPolicyTypeEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(ScalingPolicyTypeEnum a, ScalingPolicyTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 排序方法POLICY_NAME：根据策略名称排序;TRIGGER_CONDITION：根据触发条件排序，如升序下，告警策略最先，其余根据最近一次触发时间升序排列;CREATE_TIME：根据策略的创建时间排序。
        /// </summary>
        /// <value>排序方法POLICY_NAME：根据策略名称排序;TRIGGER_CONDITION：根据触发条件排序，如升序下，告警策略最先，其余根据最近一次触发时间升序排列;CREATE_TIME：根据策略的创建时间排序。</value>
        [JsonConverter(typeof(EnumClassConverter<SortByEnum>))]
        public class SortByEnum
        {
            /// <summary>
            /// Enum POLICY_NAME for value: POLICY_NAME
            /// </summary>
            public static readonly SortByEnum POLICY_NAME = new SortByEnum("POLICY_NAME");

            /// <summary>
            /// Enum TRIGGER_CONDITION for value: TRIGGER_CONDITION
            /// </summary>
            public static readonly SortByEnum TRIGGER_CONDITION = new SortByEnum("TRIGGER_CONDITION");

            /// <summary>
            /// Enum CREATE_TIME for value: CREATE_TIME
            /// </summary>
            public static readonly SortByEnum CREATE_TIME = new SortByEnum("CREATE_TIME");

            private static readonly Dictionary<string, SortByEnum> StaticFields =
            new Dictionary<string, SortByEnum>()
            {
                { "POLICY_NAME", POLICY_NAME },
                { "TRIGGER_CONDITION", TRIGGER_CONDITION },
                { "CREATE_TIME", CREATE_TIME },
            };

            private string _value;

            public SortByEnum()
            {

            }

            public SortByEnum(string value)
            {
                _value = value;
            }

            public static SortByEnum FromValue(string value)
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

                if (this.Equals(obj as SortByEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SortByEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SortByEnum a, SortByEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(SortByEnum a, SortByEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 排序顺序ASC：升序；DESC：降序
        /// </summary>
        /// <value>排序顺序ASC：升序；DESC：降序</value>
        [JsonConverter(typeof(EnumClassConverter<OrderEnum>))]
        public class OrderEnum
        {
            /// <summary>
            /// Enum ASC for value: ASC
            /// </summary>
            public static readonly OrderEnum ASC = new OrderEnum("ASC");

            /// <summary>
            /// Enum DESC for value: DESC
            /// </summary>
            public static readonly OrderEnum DESC = new OrderEnum("DESC");

            private static readonly Dictionary<string, OrderEnum> StaticFields =
            new Dictionary<string, OrderEnum>()
            {
                { "ASC", ASC },
                { "DESC", DESC },
            };

            private string _value;

            public OrderEnum()
            {

            }

            public OrderEnum(string value)
            {
                _value = value;
            }

            public static OrderEnum FromValue(string value)
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

                if (this.Equals(obj as OrderEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OrderEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OrderEnum a, OrderEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(OrderEnum a, OrderEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 伸缩组ID。
        /// </summary>
        [SDKProperty("scaling_resource_id", IsQuery = true)]
        [JsonProperty("scaling_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalingResourceId { get; set; }

        /// <summary>
        /// 伸缩资源类型：伸缩组：SCALING_GROUP；带宽：BANDWIDTH
        /// </summary>
        [SDKProperty("scaling_resource_type", IsQuery = true)]
        [JsonProperty("scaling_resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public ScalingResourceTypeEnum ScalingResourceType { get; set; }
        /// <summary>
        /// 伸缩策略名称。
        /// </summary>
        [SDKProperty("scaling_policy_name", IsQuery = true)]
        [JsonProperty("scaling_policy_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalingPolicyName { get; set; }

        /// <summary>
        /// 策略类型。  告警策略：ALARM ,定时策略：SCHEDULED, 周期策略：RECURRENCE
        /// </summary>
        [SDKProperty("scaling_policy_type", IsQuery = true)]
        [JsonProperty("scaling_policy_type", NullValueHandling = NullValueHandling.Ignore)]
        public ScalingPolicyTypeEnum ScalingPolicyType { get; set; }
        /// <summary>
        /// 伸缩策略ID。
        /// </summary>
        [SDKProperty("scaling_policy_id", IsQuery = true)]
        [JsonProperty("scaling_policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalingPolicyId { get; set; }

        /// <summary>
        /// 查询的起始行号，默认为0。
        /// </summary>
        [SDKProperty("start_number", IsQuery = true)]
        [JsonProperty("start_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? StartNumber { get; set; }

        /// <summary>
        /// 查询记录数，默认20，最大100。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 排序方法POLICY_NAME：根据策略名称排序;TRIGGER_CONDITION：根据触发条件排序，如升序下，告警策略最先，其余根据最近一次触发时间升序排列;CREATE_TIME：根据策略的创建时间排序。
        /// </summary>
        [SDKProperty("sort_by", IsQuery = true)]
        [JsonProperty("sort_by", NullValueHandling = NullValueHandling.Ignore)]
        public SortByEnum SortBy { get; set; }
        /// <summary>
        /// 排序顺序ASC：升序；DESC：降序
        /// </summary>
        [SDKProperty("order", IsQuery = true)]
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public OrderEnum Order { get; set; }
        /// <summary>
        /// 企业项目ID。当scaling_resource_type指定为：SCALING_GROUP传入all_granted_eps时：华为云帐号和拥有全局权限的IAM用户可以查询该用户所有的伸缩组对应的伸缩策略。授予部分企业项目的IAM用户，可以查询该用户所有授权企业项目下的伸缩组对应的伸缩策略。说明：如果授予部分企业项目的IAM用户拥有超过100个企业项目，则只能返回有权限的前100个企业项目对应伸缩组的伸缩策略列表。当scaling_resource_type指定为：BANDWIDTH传入all_granted_eps时:华为云帐号和拥有全局权限的IAM用户可以查询该用户所有带宽对应的伸缩策略。授予部分企业项目的IAM用户，可以查询该用户所有授权企业项目下的带宽对应的伸缩策略，带宽在all_granted_eps场景下返回策略请参见[《EIP接口参口》查询带宽列表](https://support.huaweicloud.com/api-eip/eip_apiBandwidth_0002.html)。不指定scaling_resource_type当传入all_granted_eps时：华为云帐号和拥有全局权限的IAM用户可以查询该用户所有的伸缩组和带宽对应的伸缩策略。授予部分企业项目的IAM用户，可以查询该用户所有授权企业项目下的伸缩组和带宽对应的伸缩策略。说明：如果授予部分企业项目的IAM用户拥有超过100个企业项目，则只能返回有权限的前100个企业项目对应伸缩组的伸缩策略列表；带宽在all_granted_eps场景下返回策略请参见[《EIP接口参口》查询带宽列表](https://support.huaweicloud.com/api-eip/eip_apiBandwidth_0002.html)。
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 告警ID，即告警规则的ID。
        /// </summary>
        [SDKProperty("alarm_id", IsQuery = true)]
        [JsonProperty("alarm_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAllScalingV2PoliciesRequest {\n");
            sb.Append("  scalingResourceId: ").Append(ScalingResourceId).Append("\n");
            sb.Append("  scalingResourceType: ").Append(ScalingResourceType).Append("\n");
            sb.Append("  scalingPolicyName: ").Append(ScalingPolicyName).Append("\n");
            sb.Append("  scalingPolicyType: ").Append(ScalingPolicyType).Append("\n");
            sb.Append("  scalingPolicyId: ").Append(ScalingPolicyId).Append("\n");
            sb.Append("  startNumber: ").Append(StartNumber).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  sortBy: ").Append(SortBy).Append("\n");
            sb.Append("  order: ").Append(Order).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  alarmId: ").Append(AlarmId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAllScalingV2PoliciesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAllScalingV2PoliciesRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScalingResourceId == input.ScalingResourceId ||
                    (this.ScalingResourceId != null &&
                    this.ScalingResourceId.Equals(input.ScalingResourceId))
                ) && 
                (
                    this.ScalingResourceType == input.ScalingResourceType ||
                    (this.ScalingResourceType != null &&
                    this.ScalingResourceType.Equals(input.ScalingResourceType))
                ) && 
                (
                    this.ScalingPolicyName == input.ScalingPolicyName ||
                    (this.ScalingPolicyName != null &&
                    this.ScalingPolicyName.Equals(input.ScalingPolicyName))
                ) && 
                (
                    this.ScalingPolicyType == input.ScalingPolicyType ||
                    (this.ScalingPolicyType != null &&
                    this.ScalingPolicyType.Equals(input.ScalingPolicyType))
                ) && 
                (
                    this.ScalingPolicyId == input.ScalingPolicyId ||
                    (this.ScalingPolicyId != null &&
                    this.ScalingPolicyId.Equals(input.ScalingPolicyId))
                ) && 
                (
                    this.StartNumber == input.StartNumber ||
                    (this.StartNumber != null &&
                    this.StartNumber.Equals(input.StartNumber))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.SortBy == input.SortBy ||
                    (this.SortBy != null &&
                    this.SortBy.Equals(input.SortBy))
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.AlarmId == input.AlarmId ||
                    (this.AlarmId != null &&
                    this.AlarmId.Equals(input.AlarmId))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ScalingResourceId != null)
                    hashCode = hashCode * 59 + this.ScalingResourceId.GetHashCode();
                if (this.ScalingResourceType != null)
                    hashCode = hashCode * 59 + this.ScalingResourceType.GetHashCode();
                if (this.ScalingPolicyName != null)
                    hashCode = hashCode * 59 + this.ScalingPolicyName.GetHashCode();
                if (this.ScalingPolicyType != null)
                    hashCode = hashCode * 59 + this.ScalingPolicyType.GetHashCode();
                if (this.ScalingPolicyId != null)
                    hashCode = hashCode * 59 + this.ScalingPolicyId.GetHashCode();
                if (this.StartNumber != null)
                    hashCode = hashCode * 59 + this.StartNumber.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.SortBy != null)
                    hashCode = hashCode * 59 + this.SortBy.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.AlarmId != null)
                    hashCode = hashCode * 59 + this.AlarmId.GetHashCode();
                return hashCode;
            }
        }
    }
}
