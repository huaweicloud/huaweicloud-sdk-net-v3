using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListResourceGroupsRequest 
    {
        /// <summary>
        /// **参数解释** 资源分组添加资源方式，不传代表查询所有资源分组类型。 **约束限制** 不涉及。 **取值范围** - EPS: 表示匹配企业项目 - TAG: 表示匹配标签 - Manual: 表示手动添加 - COMB: 表示组合匹配 - NAME: 表示匹配实例名称 **默认取值** 不涉及。
        /// </summary>
        /// <value>**参数解释** 资源分组添加资源方式，不传代表查询所有资源分组类型。 **约束限制** 不涉及。 **取值范围** - EPS: 表示匹配企业项目 - TAG: 表示匹配标签 - Manual: 表示手动添加 - COMB: 表示组合匹配 - NAME: 表示匹配实例名称 **默认取值** 不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum EPS for value: EPS
            /// </summary>
            public static readonly TypeEnum EPS = new TypeEnum("EPS");

            /// <summary>
            /// Enum TAG for value: TAG
            /// </summary>
            public static readonly TypeEnum TAG = new TypeEnum("TAG");

            /// <summary>
            /// Enum MANUAL for value: Manual
            /// </summary>
            public static readonly TypeEnum MANUAL = new TypeEnum("Manual");

            /// <summary>
            /// Enum COMB for value: COMB
            /// </summary>
            public static readonly TypeEnum COMB = new TypeEnum("COMB");

            /// <summary>
            /// Enum NAME for value: NAME
            /// </summary>
            public static readonly TypeEnum NAME = new TypeEnum("NAME");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "EPS", EPS },
                { "TAG", TAG },
                { "Manual", MANUAL },
                { "COMB", COMB },
                { "NAME", NAME },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释** 资源分组健康状态。 **约束限制** 不涉及。 **取值范围** - health: 表示健康 - unhealthy: 表示不健康 - no_alarm_rule: 表示未配置告警规则 **默认取值** 不涉及。
        /// </summary>
        /// <value>**参数解释** 资源分组健康状态。 **约束限制** 不涉及。 **取值范围** - health: 表示健康 - unhealthy: 表示不健康 - no_alarm_rule: 表示未配置告警规则 **默认取值** 不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum HEALTH for value: health
            /// </summary>
            public static readonly StatusEnum HEALTH = new StatusEnum("health");

            /// <summary>
            /// Enum UNHEALTHY for value: unhealthy
            /// </summary>
            public static readonly StatusEnum UNHEALTHY = new StatusEnum("unhealthy");

            /// <summary>
            /// Enum NO_ALARM_RULE for value: no_alarm_rule
            /// </summary>
            public static readonly StatusEnum NO_ALARM_RULE = new StatusEnum("no_alarm_rule");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "health", HEALTH },
                { "unhealthy", UNHEALTHY },
                { "no_alarm_rule", NO_ALARM_RULE },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(string value)
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

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**: 归属企业项目ID。 **约束限制**: 不涉及。 **取值范围**: 只能包含小写字母、数字、“-”、“_”，长度为36个字符。或者为0（代表默认企业项目ID），或者为all_granted_eps（代表所有企业项目ID）。 **默认取值**: 不涉及。
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// **参数解释** 资源分组名称，支持模糊查询。 **约束限制** 不涉及。 **取值范围** 包含字母、数字、_、-或汉字，长度为[1,128]个字符。 **默认取值** 不涉及。
        /// </summary>
        [SDKProperty("group_name", IsQuery = true)]
        [JsonProperty("group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// **参数解释** 资源分组ID。 **约束限制** 不涉及。 **取值范围** 以\&quot;rg\&quot;开头，后跟22位由字母或数字组成的字符串。 **默认取值** 不涉及。
        /// </summary>
        [SDKProperty("group_id", IsQuery = true)]
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// **参数解释** 分页起始值。 **约束限制** 不涉及。 **取值范围** 在[0,10000]区间内。 **默认取值** 0
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// **参数解释** 分页查询时每页的条目数。 **约束限制** 不涉及。 **取值范围** 在[1,100]区间内。 **默认取值** 100
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// **参数解释** 资源分组添加资源方式，不传代表查询所有资源分组类型。 **约束限制** 不涉及。 **取值范围** - EPS: 表示匹配企业项目 - TAG: 表示匹配标签 - Manual: 表示手动添加 - COMB: 表示组合匹配 - NAME: 表示匹配实例名称 **默认取值** 不涉及。
        /// </summary>
        [SDKProperty("type", IsQuery = true)]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// **参数解释** 资源分组健康状态。 **约束限制** 不涉及。 **取值范围** - health: 表示健康 - unhealthy: 表示不健康 - no_alarm_rule: 表示未配置告警规则 **默认取值** 不涉及。
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListResourceGroupsRequest {\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  groupName: ").Append(GroupName).Append("\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListResourceGroupsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListResourceGroupsRequest input)
        {
            if (input == null) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.GroupName != input.GroupName || (this.GroupName != null && !this.GroupName.Equals(input.GroupName))) return false;
            if (this.GroupId != input.GroupId || (this.GroupId != null && !this.GroupId.Equals(input.GroupId))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Type != input.Type) return false;
            if (this.Status != input.Status) return false;

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
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.GroupName != null) hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.GroupId != null) hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
