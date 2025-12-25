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
    /// Response Object
    /// </summary>
    public class ShowResourceGroupResponse : SdkResponse
    {
        /// <summary>
        /// **参数解释** 资源添加/匹配方式。 **取值范围** 枚举值。 - EPS: 匹配企业项目 - TAG: 匹配标签 - NAME: 匹配实例名称 - COMB: 组合匹配 - Manual: 手动添加 
        /// </summary>
        /// <value>**参数解释** 资源添加/匹配方式。 **取值范围** 枚举值。 - EPS: 匹配企业项目 - TAG: 匹配标签 - NAME: 匹配实例名称 - COMB: 组合匹配 - Manual: 手动添加 </value>
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
            /// Enum NAME for value: NAME
            /// </summary>
            public static readonly TypeEnum NAME = new TypeEnum("NAME");

            /// <summary>
            /// Enum COMB for value: COMB
            /// </summary>
            public static readonly TypeEnum COMB = new TypeEnum("COMB");

            /// <summary>
            /// Enum MANUAL for value: Manual
            /// </summary>
            public static readonly TypeEnum MANUAL = new TypeEnum("Manual");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "EPS", EPS },
                { "TAG", TAG },
                { "NAME", NAME },
                { "COMB", COMB },
                { "Manual", MANUAL },
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
        /// **参数解释** 指标告警状态。 **取值范围** 枚举值。 - health: 告警中 - unhealthy: 已触发 - no_alarm_rule: 未设置告警规则 
        /// </summary>
        /// <value>**参数解释** 指标告警状态。 **取值范围** 枚举值。 - health: 告警中 - unhealthy: 已触发 - no_alarm_rule: 未设置告警规则 </value>
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
        /// **参数解释** 事件告警状态。 **取值范围** 枚举值。 - health: 告警中 - unhealthy: 已触发 - no_alarm_rule: 未设置告警规则 
        /// </summary>
        /// <value>**参数解释** 事件告警状态。 **取值范围** 枚举值。 - health: 告警中 - unhealthy: 已触发 - no_alarm_rule: 未设置告警规则 </value>
        [JsonConverter(typeof(EnumClassConverter<EventStatusEnum>))]
        public class EventStatusEnum
        {
            /// <summary>
            /// Enum HEALTH for value: health
            /// </summary>
            public static readonly EventStatusEnum HEALTH = new EventStatusEnum("health");

            /// <summary>
            /// Enum UNHEALTHY for value: unhealthy
            /// </summary>
            public static readonly EventStatusEnum UNHEALTHY = new EventStatusEnum("unhealthy");

            /// <summary>
            /// Enum NO_ALARM_RULE for value: no_alarm_rule
            /// </summary>
            public static readonly EventStatusEnum NO_ALARM_RULE = new EventStatusEnum("no_alarm_rule");

            private static readonly Dictionary<string, EventStatusEnum> StaticFields =
            new Dictionary<string, EventStatusEnum>()
            {
                { "health", HEALTH },
                { "unhealthy", UNHEALTHY },
                { "no_alarm_rule", NO_ALARM_RULE },
            };

            private string _value;

            public EventStatusEnum()
            {

            }

            public EventStatusEnum(string value)
            {
                _value = value;
            }

            public static EventStatusEnum FromValue(string value)
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

                if (this.Equals(obj as EventStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EventStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(EventStatusEnum a, EventStatusEnum b)
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

            public static bool operator !=(EventStatusEnum a, EventStatusEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释** 资源等级。 **取值范围** 枚举值。 - product: 云产品 - dimension: 子维度 
        /// </summary>
        /// <value>**参数解释** 资源等级。 **取值范围** 枚举值。 - product: 云产品 - dimension: 子维度 </value>
        [JsonConverter(typeof(EnumClassConverter<ResourceLevelEnum>))]
        public class ResourceLevelEnum
        {
            /// <summary>
            /// Enum DIMENSION for value: dimension
            /// </summary>
            public static readonly ResourceLevelEnum DIMENSION = new ResourceLevelEnum("dimension");

            /// <summary>
            /// Enum PRODUCT for value: product
            /// </summary>
            public static readonly ResourceLevelEnum PRODUCT = new ResourceLevelEnum("product");

            private static readonly Dictionary<string, ResourceLevelEnum> StaticFields =
            new Dictionary<string, ResourceLevelEnum>()
            {
                { "dimension", DIMENSION },
                { "product", PRODUCT },
            };

            private string _value;

            public ResourceLevelEnum()
            {

            }

            public ResourceLevelEnum(string value)
            {
                _value = value;
            }

            public static ResourceLevelEnum FromValue(string value)
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

                if (this.Equals(obj as ResourceLevelEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ResourceLevelEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ResourceLevelEnum a, ResourceLevelEnum b)
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

            public static bool operator !=(ResourceLevelEnum a, ResourceLevelEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释** 资源分组的名称。 **取值范围** 只能为字母、数字、汉字、-或_，长度为[1,128]个字符。 
        /// </summary>
        [JsonProperty("group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// **参数解释**： 资源分组ID。 **取值范围**： 以rg开头，后跟22位由字母或数字组成的字符串。长度为[2,24]个字符。 
        /// </summary>
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// **参数解释**： 资源分组的创建时间 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// **参数解释**： 资源分组的修改时间 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// **参数解释** 资源分组归属企业项目ID。 **取值范围** 由数字、字母和-组成，或者为0（默认企业项目ID）。 
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// **参数解释** 资源添加/匹配方式。 **取值范围** 枚举值。 - EPS: 匹配企业项目 - TAG: 匹配标签 - NAME: 匹配实例名称 - COMB: 组合匹配 - Manual: 手动添加 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 该资源分组内包含的资源来源的企业项目ID，type为EPS时必传
        /// </summary>
        [JsonProperty("association_ep_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AssociationEpIds { get; set; }

        /// <summary>
        /// 当资源匹配规则为匹配标签时,所指定的标签规则
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceGroupTagRelation> Tags { get; set; }

        /// <summary>
        /// 实例名称匹配参数
        /// </summary>
        [JsonProperty("instances", NullValueHandling = NullValueHandling.Ignore)]
        public List<Instance> Instances { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("comb_relation", NullValueHandling = NullValueHandling.Ignore)]
        public CombRelation CombRelation { get; set; }

        /// <summary>
        /// 当资源匹配规则为匹配企业项目时，指定的企业项目列表
        /// </summary>
        [JsonProperty("related_ep_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RelatedEpIds { get; set; }

        /// <summary>
        /// 匹配企业项目或匹配标签参数
        /// </summary>
        [JsonProperty("enterprise_project_id_and_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<EnterpriseProjectIdAndTags> EnterpriseProjectIdAndTags { get; set; }

        /// <summary>
        /// **参数解释** 指标告警状态。 **取值范围** 枚举值。 - health: 告警中 - unhealthy: 已触发 - no_alarm_rule: 未设置告警规则 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// **参数解释** 事件告警状态。 **取值范围** 枚举值。 - health: 告警中 - unhealthy: 已触发 - no_alarm_rule: 未设置告警规则 
        /// </summary>
        [JsonProperty("event_status", NullValueHandling = NullValueHandling.Ignore)]
        public EventStatusEnum EventStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("resource_statistics", NullValueHandling = NullValueHandling.Ignore)]
        public GetResourceGroupRespResourceStatistics ResourceStatistics { get; set; }

        /// <summary>
        /// **参数解释** 资源等级。 **取值范围** 枚举值。 - product: 云产品 - dimension: 子维度 
        /// </summary>
        [JsonProperty("resource_level", NullValueHandling = NullValueHandling.Ignore)]
        public ResourceLevelEnum ResourceLevel { get; set; }
        /// <summary>
        /// **参数解释** 创建资源层级为云产品时的云产品名称，一般由\&quot;服务命名空间,服务首层维度名称\&quot;组成，如\&quot;SYS.ECS,instance_id\&quot;。多个云产品则用“;”隔开，如\&quot;SERVICE.BMS,instance_id;SYS.ECS,instance_id\&quot;。 **取值范围** 长度[0,10240]个字符 
        /// </summary>
        [JsonProperty("product_names", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductNames { get; set; }

        /// <summary>
        /// 每个企业项目关联的资源状态
        /// </summary>
        [JsonProperty("ep_resource_statistics", NullValueHandling = NullValueHandling.Ignore)]
        public List<EpResourceStatistics> EpResourceStatistics { get; set; }

        /// <summary>
        /// 关联的告警模板列表
        /// </summary>
        [JsonProperty("association_alarm_templates", NullValueHandling = NullValueHandling.Ignore)]
        public List<AssociationAlarmTemplate> AssociationAlarmTemplates { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowResourceGroupResponse {\n");
            sb.Append("  groupName: ").Append(GroupName).Append("\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  associationEpIds: ").Append(AssociationEpIds).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  instances: ").Append(Instances).Append("\n");
            sb.Append("  combRelation: ").Append(CombRelation).Append("\n");
            sb.Append("  relatedEpIds: ").Append(RelatedEpIds).Append("\n");
            sb.Append("  enterpriseProjectIdAndTags: ").Append(EnterpriseProjectIdAndTags).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  eventStatus: ").Append(EventStatus).Append("\n");
            sb.Append("  resourceStatistics: ").Append(ResourceStatistics).Append("\n");
            sb.Append("  resourceLevel: ").Append(ResourceLevel).Append("\n");
            sb.Append("  productNames: ").Append(ProductNames).Append("\n");
            sb.Append("  epResourceStatistics: ").Append(EpResourceStatistics).Append("\n");
            sb.Append("  associationAlarmTemplates: ").Append(AssociationAlarmTemplates).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowResourceGroupResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowResourceGroupResponse input)
        {
            if (input == null) return false;
            if (this.GroupName != input.GroupName || (this.GroupName != null && !this.GroupName.Equals(input.GroupName))) return false;
            if (this.GroupId != input.GroupId || (this.GroupId != null && !this.GroupId.Equals(input.GroupId))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.Type != input.Type) return false;
            if (this.AssociationEpIds != input.AssociationEpIds || (this.AssociationEpIds != null && input.AssociationEpIds != null && !this.AssociationEpIds.SequenceEqual(input.AssociationEpIds))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.Instances != input.Instances || (this.Instances != null && input.Instances != null && !this.Instances.SequenceEqual(input.Instances))) return false;
            if (this.CombRelation != input.CombRelation || (this.CombRelation != null && !this.CombRelation.Equals(input.CombRelation))) return false;
            if (this.RelatedEpIds != input.RelatedEpIds || (this.RelatedEpIds != null && input.RelatedEpIds != null && !this.RelatedEpIds.SequenceEqual(input.RelatedEpIds))) return false;
            if (this.EnterpriseProjectIdAndTags != input.EnterpriseProjectIdAndTags || (this.EnterpriseProjectIdAndTags != null && input.EnterpriseProjectIdAndTags != null && !this.EnterpriseProjectIdAndTags.SequenceEqual(input.EnterpriseProjectIdAndTags))) return false;
            if (this.Status != input.Status) return false;
            if (this.EventStatus != input.EventStatus) return false;
            if (this.ResourceStatistics != input.ResourceStatistics || (this.ResourceStatistics != null && !this.ResourceStatistics.Equals(input.ResourceStatistics))) return false;
            if (this.ResourceLevel != input.ResourceLevel) return false;
            if (this.ProductNames != input.ProductNames || (this.ProductNames != null && !this.ProductNames.Equals(input.ProductNames))) return false;
            if (this.EpResourceStatistics != input.EpResourceStatistics || (this.EpResourceStatistics != null && input.EpResourceStatistics != null && !this.EpResourceStatistics.SequenceEqual(input.EpResourceStatistics))) return false;
            if (this.AssociationAlarmTemplates != input.AssociationAlarmTemplates || (this.AssociationAlarmTemplates != null && input.AssociationAlarmTemplates != null && !this.AssociationAlarmTemplates.SequenceEqual(input.AssociationAlarmTemplates))) return false;

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
                if (this.GroupName != null) hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.GroupId != null) hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.AssociationEpIds != null) hashCode = hashCode * 59 + this.AssociationEpIds.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Instances != null) hashCode = hashCode * 59 + this.Instances.GetHashCode();
                if (this.CombRelation != null) hashCode = hashCode * 59 + this.CombRelation.GetHashCode();
                if (this.RelatedEpIds != null) hashCode = hashCode * 59 + this.RelatedEpIds.GetHashCode();
                if (this.EnterpriseProjectIdAndTags != null) hashCode = hashCode * 59 + this.EnterpriseProjectIdAndTags.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.EventStatus.GetHashCode();
                if (this.ResourceStatistics != null) hashCode = hashCode * 59 + this.ResourceStatistics.GetHashCode();
                hashCode = hashCode * 59 + this.ResourceLevel.GetHashCode();
                if (this.ProductNames != null) hashCode = hashCode * 59 + this.ProductNames.GetHashCode();
                if (this.EpResourceStatistics != null) hashCode = hashCode * 59 + this.EpResourceStatistics.GetHashCode();
                if (this.AssociationAlarmTemplates != null) hashCode = hashCode * 59 + this.AssociationAlarmTemplates.GetHashCode();
                return hashCode;
            }
        }
    }
}
