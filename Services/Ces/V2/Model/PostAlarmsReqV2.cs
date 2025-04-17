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
    public class PostAlarmsReqV2 
    {
        /// <summary>
        /// 产品层级跨纬规则创建时需要指明为产品层级规则，resource_level取值为product即为产品层级跨纬规则，不填或者取值为dimension则为旧的规则类型
        /// </summary>
        /// <value>产品层级跨纬规则创建时需要指明为产品层级规则，resource_level取值为product即为产品层级跨纬规则，不填或者取值为dimension则为旧的规则类型</value>
        [JsonConverter(typeof(EnumClassConverter<ResourceLevelEnum>))]
        public class ResourceLevelEnum
        {
            /// <summary>
            /// Enum PRODUCT for value: product
            /// </summary>
            public static readonly ResourceLevelEnum PRODUCT = new ResourceLevelEnum("product");

            /// <summary>
            /// Enum DIMENSION for value: dimension
            /// </summary>
            public static readonly ResourceLevelEnum DIMENSION = new ResourceLevelEnum("dimension");

            private static readonly Dictionary<string, ResourceLevelEnum> StaticFields =
            new Dictionary<string, ResourceLevelEnum>()
            {
                { "product", PRODUCT },
                { "dimension", DIMENSION },
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

            public static bool operator !=(ResourceLevelEnum a, ResourceLevelEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 告警名称, 只能包含0-9/a-z/A-Z/_/-或汉字，长度1-128
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 告警描述，长度0-256
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 查询服务的命名空间，各服务命名空间请参考[服务命名空间](https://support.huaweicloud.com/usermanual-ces/zh-cn_topic_0202622212.html)
        /// </summary>
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// 资源分组ID，以rg开头，后跟22位由字母或数字组成的字符串
        /// </summary>
        [JsonProperty("resource_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// 资源列表，告警规则类型为全部资源、资源分组时，资源维度值传空；告警规则类型为指定资源时，资源维度值必填，可以同时指定监控多个资源。
        /// </summary>
        [JsonProperty("resources", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<Dimension>> Resources { get; set; }

        /// <summary>
        /// 告警策略，当alarm_template_id字段为空时必填，不为空时不填
        /// </summary>
        [JsonProperty("policies", NullValueHandling = NullValueHandling.Ignore)]
        public List<Policy> Policies { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public AlarmType Type { get; set; }
        /// <summary>
        /// 告警触发的动作
        /// </summary>
        [JsonProperty("alarm_notifications", NullValueHandling = NullValueHandling.Ignore)]
        public List<Notification> AlarmNotifications { get; set; }

        /// <summary>
        /// 告警恢复触发的动作
        /// </summary>
        [JsonProperty("ok_notifications", NullValueHandling = NullValueHandling.Ignore)]
        public List<Notification> OkNotifications { get; set; }

        /// <summary>
        /// 告警通知开启时间
        /// </summary>
        [JsonProperty("notification_begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public string NotificationBeginTime { get; set; }

        /// <summary>
        /// 告警通知关闭时间
        /// </summary>
        [JsonProperty("notification_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string NotificationEndTime { get; set; }

        /// <summary>
        /// 企业项目ID
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 告警开关
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 是否开启告警通知
        /// </summary>
        [JsonProperty("notification_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NotificationEnabled { get; set; }

        /// <summary>
        /// 告警规则关联告警模板ID，如果传了，告警规则关联的策略会和告警模板策略联动变化
        /// </summary>
        [JsonProperty("alarm_template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmTemplateId { get; set; }

        /// <summary>
        /// 租户标签列表
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceTag> Tags { get; set; }

        /// <summary>
        /// 产品层级跨纬规则创建时需要指明的规则产品名称，一般由\&quot;服务命名空间,服务首层维度名称\&quot;组成，如\&quot;SYS.ECS,instance_id\&quot;
        /// </summary>
        [JsonProperty("product_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductName { get; set; }

        /// <summary>
        /// 产品层级跨纬规则创建时需要指明为产品层级规则，resource_level取值为product即为产品层级跨纬规则，不填或者取值为dimension则为旧的规则类型
        /// </summary>
        [JsonProperty("resource_level", NullValueHandling = NullValueHandling.Ignore)]
        public ResourceLevelEnum ResourceLevel { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostAlarmsReqV2 {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  resourceGroupId: ").Append(ResourceGroupId).Append("\n");
            sb.Append("  resources: ").Append(Resources).Append("\n");
            sb.Append("  policies: ").Append(Policies).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  alarmNotifications: ").Append(AlarmNotifications).Append("\n");
            sb.Append("  okNotifications: ").Append(OkNotifications).Append("\n");
            sb.Append("  notificationBeginTime: ").Append(NotificationBeginTime).Append("\n");
            sb.Append("  notificationEndTime: ").Append(NotificationEndTime).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("  notificationEnabled: ").Append(NotificationEnabled).Append("\n");
            sb.Append("  alarmTemplateId: ").Append(AlarmTemplateId).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  productName: ").Append(ProductName).Append("\n");
            sb.Append("  resourceLevel: ").Append(ResourceLevel).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PostAlarmsReqV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PostAlarmsReqV2 input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Namespace != input.Namespace || (this.Namespace != null && !this.Namespace.Equals(input.Namespace))) return false;
            if (this.ResourceGroupId != input.ResourceGroupId || (this.ResourceGroupId != null && !this.ResourceGroupId.Equals(input.ResourceGroupId))) return false;
            if (this.Resources != input.Resources || (this.Resources != null && input.Resources != null && !this.Resources.SequenceEqual(input.Resources))) return false;
            if (this.Policies != input.Policies || (this.Policies != null && input.Policies != null && !this.Policies.SequenceEqual(input.Policies))) return false;
            if (this.Type != input.Type) return false;
            if (this.AlarmNotifications != input.AlarmNotifications || (this.AlarmNotifications != null && input.AlarmNotifications != null && !this.AlarmNotifications.SequenceEqual(input.AlarmNotifications))) return false;
            if (this.OkNotifications != input.OkNotifications || (this.OkNotifications != null && input.OkNotifications != null && !this.OkNotifications.SequenceEqual(input.OkNotifications))) return false;
            if (this.NotificationBeginTime != input.NotificationBeginTime || (this.NotificationBeginTime != null && !this.NotificationBeginTime.Equals(input.NotificationBeginTime))) return false;
            if (this.NotificationEndTime != input.NotificationEndTime || (this.NotificationEndTime != null && !this.NotificationEndTime.Equals(input.NotificationEndTime))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.Enabled != input.Enabled || (this.Enabled != null && !this.Enabled.Equals(input.Enabled))) return false;
            if (this.NotificationEnabled != input.NotificationEnabled || (this.NotificationEnabled != null && !this.NotificationEnabled.Equals(input.NotificationEnabled))) return false;
            if (this.AlarmTemplateId != input.AlarmTemplateId || (this.AlarmTemplateId != null && !this.AlarmTemplateId.Equals(input.AlarmTemplateId))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.ProductName != input.ProductName || (this.ProductName != null && !this.ProductName.Equals(input.ProductName))) return false;
            if (this.ResourceLevel != input.ResourceLevel) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Namespace != null) hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.ResourceGroupId != null) hashCode = hashCode * 59 + this.ResourceGroupId.GetHashCode();
                if (this.Resources != null) hashCode = hashCode * 59 + this.Resources.GetHashCode();
                if (this.Policies != null) hashCode = hashCode * 59 + this.Policies.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.AlarmNotifications != null) hashCode = hashCode * 59 + this.AlarmNotifications.GetHashCode();
                if (this.OkNotifications != null) hashCode = hashCode * 59 + this.OkNotifications.GetHashCode();
                if (this.NotificationBeginTime != null) hashCode = hashCode * 59 + this.NotificationBeginTime.GetHashCode();
                if (this.NotificationEndTime != null) hashCode = hashCode * 59 + this.NotificationEndTime.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Enabled != null) hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.NotificationEnabled != null) hashCode = hashCode * 59 + this.NotificationEnabled.GetHashCode();
                if (this.AlarmTemplateId != null) hashCode = hashCode * 59 + this.AlarmTemplateId.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.ProductName != null) hashCode = hashCode * 59 + this.ProductName.GetHashCode();
                hashCode = hashCode * 59 + this.ResourceLevel.GetHashCode();
                return hashCode;
            }
        }
    }
}
