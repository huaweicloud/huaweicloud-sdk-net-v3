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
    public class ListNotificationMaskRequestBody 
    {
        /// <summary>
        /// dimension: 子维度,product: 云产品
        /// </summary>
        /// <value>dimension: 子维度,product: 云产品</value>
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
        /// 屏蔽状态,可选。MASK_EFFECTIVE：已生效，MASK_INEFFECTIVE：未生效。
        /// </summary>
        /// <value>屏蔽状态,可选。MASK_EFFECTIVE：已生效，MASK_INEFFECTIVE：未生效。</value>
        [JsonConverter(typeof(EnumClassConverter<MaskStatusEnum>))]
        public class MaskStatusEnum
        {
            /// <summary>
            /// Enum MASK_EFFECTIVE for value: MASK_EFFECTIVE
            /// </summary>
            public static readonly MaskStatusEnum MASK_EFFECTIVE = new MaskStatusEnum("MASK_EFFECTIVE");

            /// <summary>
            /// Enum MASK_INEFFECTIVE for value: MASK_INEFFECTIVE
            /// </summary>
            public static readonly MaskStatusEnum MASK_INEFFECTIVE = new MaskStatusEnum("MASK_INEFFECTIVE");

            private static readonly Dictionary<string, MaskStatusEnum> StaticFields =
            new Dictionary<string, MaskStatusEnum>()
            {
                { "MASK_EFFECTIVE", MASK_EFFECTIVE },
                { "MASK_INEFFECTIVE", MASK_INEFFECTIVE },
            };

            private string _value;

            public MaskStatusEnum()
            {

            }

            public MaskStatusEnum(string value)
            {
                _value = value;
            }

            public static MaskStatusEnum FromValue(string value)
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

                if (this.Equals(obj as MaskStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(MaskStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(MaskStatusEnum a, MaskStatusEnum b)
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

            public static bool operator !=(MaskStatusEnum a, MaskStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("relation_type", NullValueHandling = NullValueHandling.Ignore)]
        public ListRelationType RelationType { get; set; }
        /// <summary>
        /// 关联编号（目前是告警规则ID）
        /// </summary>
        [JsonProperty("relation_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RelationIds { get; set; }

        /// <summary>
        /// **参数解释**： 资源的监控指标名称，各服务的指标名称可查看：“[服务指标名称](ces_03_0059.xml)”。 **约束限制**： 不涉及。 **取值范围**： 必须以字母开头，只能包含0-9/a-z/A-Z/_/-。字符长度最短为1，最大为96。如：弹性云服务器中的监控指标cpu_util，表示弹性服务器的CPU使用率；文档数据库中的指标mongo001_command_ps，表示command执行频率。         **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("metric_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricName { get; set; }

        /// <summary>
        /// dimension: 子维度,product: 云产品
        /// </summary>
        [JsonProperty("resource_level", NullValueHandling = NullValueHandling.Ignore)]
        public ResourceLevelEnum ResourceLevel { get; set; }
        /// <summary>
        /// 屏蔽规则ID,可选
        /// </summary>
        [JsonProperty("mask_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MaskId { get; set; }

        /// <summary>
        /// 屏蔽规则名称,可选，只能为字母、数字、汉字、-、_，最大长度为64
        /// </summary>
        [JsonProperty("mask_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MaskName { get; set; }

        /// <summary>
        /// 屏蔽状态,可选。MASK_EFFECTIVE：已生效，MASK_INEFFECTIVE：未生效。
        /// </summary>
        [JsonProperty("mask_status", NullValueHandling = NullValueHandling.Ignore)]
        public MaskStatusEnum MaskStatus { get; set; }
        /// <summary>
        /// 资源维度值,提供一个维度的资源ID即可,可选
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// **参数解释**： 查询服务的命名空间，各服务命名空间请参考“[服务命名空间](ces_03_0059.xml)”。 **约束限制**： 不涉及。 **取值范围**： 格式为service.item；service和item必须是字符串，必须以字母开头，只能包含0-9/a-z/A-Z/_。字符串的长度必须在 3 到 32个字符之间。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// 资源的维度信息
        /// </summary>
        [JsonProperty("dimensions", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceDimension> Dimensions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListNotificationMaskRequestBody {\n");
            sb.Append("  relationType: ").Append(RelationType).Append("\n");
            sb.Append("  relationIds: ").Append(RelationIds).Append("\n");
            sb.Append("  metricName: ").Append(MetricName).Append("\n");
            sb.Append("  resourceLevel: ").Append(ResourceLevel).Append("\n");
            sb.Append("  maskId: ").Append(MaskId).Append("\n");
            sb.Append("  maskName: ").Append(MaskName).Append("\n");
            sb.Append("  maskStatus: ").Append(MaskStatus).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  dimensions: ").Append(Dimensions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListNotificationMaskRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListNotificationMaskRequestBody input)
        {
            if (input == null) return false;
            if (this.RelationType != input.RelationType) return false;
            if (this.RelationIds != input.RelationIds || (this.RelationIds != null && input.RelationIds != null && !this.RelationIds.SequenceEqual(input.RelationIds))) return false;
            if (this.MetricName != input.MetricName || (this.MetricName != null && !this.MetricName.Equals(input.MetricName))) return false;
            if (this.ResourceLevel != input.ResourceLevel) return false;
            if (this.MaskId != input.MaskId || (this.MaskId != null && !this.MaskId.Equals(input.MaskId))) return false;
            if (this.MaskName != input.MaskName || (this.MaskName != null && !this.MaskName.Equals(input.MaskName))) return false;
            if (this.MaskStatus != input.MaskStatus) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.Namespace != input.Namespace || (this.Namespace != null && !this.Namespace.Equals(input.Namespace))) return false;
            if (this.Dimensions != input.Dimensions || (this.Dimensions != null && input.Dimensions != null && !this.Dimensions.SequenceEqual(input.Dimensions))) return false;

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
                hashCode = hashCode * 59 + this.RelationType.GetHashCode();
                if (this.RelationIds != null) hashCode = hashCode * 59 + this.RelationIds.GetHashCode();
                if (this.MetricName != null) hashCode = hashCode * 59 + this.MetricName.GetHashCode();
                hashCode = hashCode * 59 + this.ResourceLevel.GetHashCode();
                if (this.MaskId != null) hashCode = hashCode * 59 + this.MaskId.GetHashCode();
                if (this.MaskName != null) hashCode = hashCode * 59 + this.MaskName.GetHashCode();
                hashCode = hashCode * 59 + this.MaskStatus.GetHashCode();
                if (this.ResourceId != null) hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.Namespace != null) hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.Dimensions != null) hashCode = hashCode * 59 + this.Dimensions.GetHashCode();
                return hashCode;
            }
        }
    }
}
