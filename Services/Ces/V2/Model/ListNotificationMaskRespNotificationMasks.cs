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
    /// 
    /// </summary>
    public class ListNotificationMaskRespNotificationMasks 
    {
        /// <summary>
        /// **参数解释**： 资源层级。 **取值范围**： 枚举值。 - product：资源层级为云产品 - dimension：资源层级为子维度 
        /// </summary>
        /// <value>**参数解释**： 资源层级。 **取值范围**： 枚举值。 - product：资源层级为云产品 - dimension：资源层级为子维度 </value>
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
        /// **参数解释**： 屏蔽规则ID **约束限制**： 不涉及 **取值范围**： 以nm开头，后跟[0,62]位字母或数字。 **默认取值**： 不涉及 
        /// </summary>
        [JsonProperty("notification_mask_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NotificationMaskId { get; set; }

        /// <summary>
        /// **参数解释**： 屏蔽规则名称。    **约束限制**： 不涉及。 **取值范围**： 只能为字母、数字、汉字、-、_，长度为[1,64]个字符。      **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("mask_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MaskName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("relation_type", NullValueHandling = NullValueHandling.Ignore)]
        public RelationType RelationType { get; set; }
        /// <summary>
        /// **参数解释**： 关联ID，为告警规则ID或者告警策略ID **约束限制**： 不涉及。 **取值范围**： 只能包含字母、数字、“-”，长度为[1,64]个字符。      **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("relation_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RelationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public MaskResourceType? ResourceType { get; set; }

        /// <summary>
        /// **参数解释**： 关联指标名称列表，relation_type为RESOURCE时存在该字段 
        /// </summary>
        [JsonProperty("metric_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> MetricNames { get; set; }

        /// <summary>
        /// **参数解释**： 按云产品维度屏蔽时的指标信息 
        /// </summary>
        [JsonProperty("product_metrics", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProductMetricResp> ProductMetrics { get; set; }

        /// <summary>
        /// **参数解释**： 资源层级。 **取值范围**： 枚举值。 - product：资源层级为云产品 - dimension：资源层级为子维度 
        /// </summary>
        [JsonProperty("resource_level", NullValueHandling = NullValueHandling.Ignore)]
        public ResourceLevelEnum ResourceLevel { get; set; }
        /// <summary>
        /// **参数解释**： 资源为云产品时的云产品名称 **取值范围**： 长度为[0,128]个字符。 
        /// </summary>
        [JsonProperty("product_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductName { get; set; }

        /// <summary>
        /// **参数解释**： 关联资源类型，relation_type为RESOURCE时存在该字段,只需要查询出资源的namespace+维度名即可 
        /// </summary>
        [JsonProperty("resources", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceCategoryResp> Resources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("mask_status", NullValueHandling = NullValueHandling.Ignore)]
        public MaskStatus MaskStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("mask_type", NullValueHandling = NullValueHandling.Ignore)]
        public MaskType MaskType { get; set; }
        /// <summary>
        /// **参数解释**： 告警屏蔽的创建时间，UNIX时间戳，单位毫秒。 **约束限制**： 不涉及。 **取值范围**: 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// **参数解释**： 告警屏蔽的更新时间，UNIX时间戳，单位毫秒。 **约束限制**： 不涉及。 **取值范围**: 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTime { get; set; }

        /// <summary>
        /// **参数解释**： 屏蔽起始日期。           **约束限制**： 不涉及。 **取值范围**： 字符长度为10，格式为：yyyy-MM-dd           **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("start_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// **参数解释**： 屏蔽起始时间。          **约束限制**： 不涉及。 **取值范围**： 字符长度为8，格式为：HH:mm:ss         **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// **参数解释**： 屏蔽截止日期。           **约束限制**： 不涉及。 **取值范围**： 字符长度为10，格式为：yyyy-MM-dd           **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("end_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// **参数解释**： 屏蔽截止时间。          **约束限制**： 不涉及。 **取值范围**： 字符长度为8，格式为：HH:mm:ss         **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// **参数解释**： 时区，形如：\&quot;GMT-08:00\&quot;、\&quot;GMT+08:00\&quot;、\&quot;GMT+0:00\&quot;。    **约束限制**： 不涉及。 **取值范围**： 长度为[1,16]个字符。           **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("effective_timezone", NullValueHandling = NullValueHandling.Ignore)]
        public string EffectiveTimezone { get; set; }

        /// <summary>
        /// **参数解释**： 告警策略列表。 
        /// </summary>
        [JsonProperty("policies", NullValueHandling = NullValueHandling.Ignore)]
        public List<PoliciesInListResp> Policies { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListNotificationMaskRespNotificationMasks {\n");
            sb.Append("  notificationMaskId: ").Append(NotificationMaskId).Append("\n");
            sb.Append("  maskName: ").Append(MaskName).Append("\n");
            sb.Append("  relationType: ").Append(RelationType).Append("\n");
            sb.Append("  relationId: ").Append(RelationId).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  metricNames: ").Append(MetricNames).Append("\n");
            sb.Append("  productMetrics: ").Append(ProductMetrics).Append("\n");
            sb.Append("  resourceLevel: ").Append(ResourceLevel).Append("\n");
            sb.Append("  productName: ").Append(ProductName).Append("\n");
            sb.Append("  resources: ").Append(Resources).Append("\n");
            sb.Append("  maskStatus: ").Append(MaskStatus).Append("\n");
            sb.Append("  maskType: ").Append(MaskType).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  startDate: ").Append(StartDate).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endDate: ").Append(EndDate).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  effectiveTimezone: ").Append(EffectiveTimezone).Append("\n");
            sb.Append("  policies: ").Append(Policies).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListNotificationMaskRespNotificationMasks);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListNotificationMaskRespNotificationMasks input)
        {
            if (input == null) return false;
            if (this.NotificationMaskId != input.NotificationMaskId || (this.NotificationMaskId != null && !this.NotificationMaskId.Equals(input.NotificationMaskId))) return false;
            if (this.MaskName != input.MaskName || (this.MaskName != null && !this.MaskName.Equals(input.MaskName))) return false;
            if (this.RelationType != input.RelationType) return false;
            if (this.RelationId != input.RelationId || (this.RelationId != null && !this.RelationId.Equals(input.RelationId))) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && !this.ResourceType.Equals(input.ResourceType))) return false;
            if (this.MetricNames != input.MetricNames || (this.MetricNames != null && input.MetricNames != null && !this.MetricNames.SequenceEqual(input.MetricNames))) return false;
            if (this.ProductMetrics != input.ProductMetrics || (this.ProductMetrics != null && input.ProductMetrics != null && !this.ProductMetrics.SequenceEqual(input.ProductMetrics))) return false;
            if (this.ResourceLevel != input.ResourceLevel) return false;
            if (this.ProductName != input.ProductName || (this.ProductName != null && !this.ProductName.Equals(input.ProductName))) return false;
            if (this.Resources != input.Resources || (this.Resources != null && input.Resources != null && !this.Resources.SequenceEqual(input.Resources))) return false;
            if (this.MaskStatus != input.MaskStatus) return false;
            if (this.MaskType != input.MaskType) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.StartDate != input.StartDate || (this.StartDate != null && !this.StartDate.Equals(input.StartDate))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndDate != input.EndDate || (this.EndDate != null && !this.EndDate.Equals(input.EndDate))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.EffectiveTimezone != input.EffectiveTimezone || (this.EffectiveTimezone != null && !this.EffectiveTimezone.Equals(input.EffectiveTimezone))) return false;
            if (this.Policies != input.Policies || (this.Policies != null && input.Policies != null && !this.Policies.SequenceEqual(input.Policies))) return false;

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
                if (this.NotificationMaskId != null) hashCode = hashCode * 59 + this.NotificationMaskId.GetHashCode();
                if (this.MaskName != null) hashCode = hashCode * 59 + this.MaskName.GetHashCode();
                hashCode = hashCode * 59 + this.RelationType.GetHashCode();
                if (this.RelationId != null) hashCode = hashCode * 59 + this.RelationId.GetHashCode();
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.MetricNames != null) hashCode = hashCode * 59 + this.MetricNames.GetHashCode();
                if (this.ProductMetrics != null) hashCode = hashCode * 59 + this.ProductMetrics.GetHashCode();
                hashCode = hashCode * 59 + this.ResourceLevel.GetHashCode();
                if (this.ProductName != null) hashCode = hashCode * 59 + this.ProductName.GetHashCode();
                if (this.Resources != null) hashCode = hashCode * 59 + this.Resources.GetHashCode();
                hashCode = hashCode * 59 + this.MaskStatus.GetHashCode();
                hashCode = hashCode * 59 + this.MaskType.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.StartDate != null) hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndDate != null) hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.EffectiveTimezone != null) hashCode = hashCode * 59 + this.EffectiveTimezone.GetHashCode();
                if (this.Policies != null) hashCode = hashCode * 59 + this.Policies.GetHashCode();
                return hashCode;
            }
        }
    }
}
