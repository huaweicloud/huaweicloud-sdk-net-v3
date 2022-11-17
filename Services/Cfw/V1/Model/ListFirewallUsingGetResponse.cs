using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListFirewallUsingGetResponse : SdkResponse
    {
        /// <summary>
        /// 防火墙状态列表，包括-1：等待支付，0：创建中，1，删除中，2：运行中，3：升级中，4：删除完成：5：冻结中，6：创建失败，7：删除失败，8：冻结失败，9：存储中，10：存储失败，11：升级失败
        /// </summary>
        /// <value>防火墙状态列表，包括-1：等待支付，0：创建中，1，删除中，2：运行中，3：升级中，4：删除完成：5：冻结中，6：创建失败，7：删除失败，8：冻结失败，9：存储中，10：存储失败，11：升级失败</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum NUMBER_MINUS_1 for value: -1
            /// </summary>
            public static readonly StatusEnum NUMBER_MINUS_1 = new StatusEnum(-1);

            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly StatusEnum NUMBER_0 = new StatusEnum(0);

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly StatusEnum NUMBER_1 = new StatusEnum(1);

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            public static readonly StatusEnum NUMBER_2 = new StatusEnum(2);

            /// <summary>
            /// Enum NUMBER_3 for value: 3
            /// </summary>
            public static readonly StatusEnum NUMBER_3 = new StatusEnum(3);

            /// <summary>
            /// Enum NUMBER_4 for value: 4
            /// </summary>
            public static readonly StatusEnum NUMBER_4 = new StatusEnum(4);

            /// <summary>
            /// Enum NUMBER_5 for value: 5
            /// </summary>
            public static readonly StatusEnum NUMBER_5 = new StatusEnum(5);

            /// <summary>
            /// Enum NUMBER_6 for value: 6
            /// </summary>
            public static readonly StatusEnum NUMBER_6 = new StatusEnum(6);

            /// <summary>
            /// Enum NUMBER_7 for value: 7
            /// </summary>
            public static readonly StatusEnum NUMBER_7 = new StatusEnum(7);

            /// <summary>
            /// Enum NUMBER_8 for value: 8
            /// </summary>
            public static readonly StatusEnum NUMBER_8 = new StatusEnum(8);

            /// <summary>
            /// Enum NUMBER_9 for value: 9
            /// </summary>
            public static readonly StatusEnum NUMBER_9 = new StatusEnum(9);

            /// <summary>
            /// Enum NUMBER_10 for value: 10
            /// </summary>
            public static readonly StatusEnum NUMBER_10 = new StatusEnum(10);

            /// <summary>
            /// Enum NUMBER_11 for value: 11
            /// </summary>
            public static readonly StatusEnum NUMBER_11 = new StatusEnum(11);

            private static readonly Dictionary<int?, StatusEnum> StaticFields =
            new Dictionary<int?, StatusEnum>()
            {
                { -1, NUMBER_MINUS_1 },
                { 0, NUMBER_0 },
                { 1, NUMBER_1 },
                { 2, NUMBER_2 },
                { 3, NUMBER_3 },
                { 4, NUMBER_4 },
                { 5, NUMBER_5 },
                { 6, NUMBER_6 },
                { 7, NUMBER_7 },
                { 8, NUMBER_8 },
                { 9, NUMBER_9 },
                { 10, NUMBER_10 },
                { 11, NUMBER_11 },
            };

            private int? Value;

            public StatusEnum(int? value)
            {
                Value = value;
            }

            public static StatusEnum FromValue(int? value)
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

            public int? GetValue()
            {
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 防火墙id
        /// </summary>
        [JsonProperty("fw_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FwInstanceId { get; set; }

        /// <summary>
        /// 资源id
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 防火墙名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 集群类型
        /// </summary>
        [JsonProperty("ha_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? HaType { get; set; }

        /// <summary>
        /// 计费模式 0：包年/包月 1：按需
        /// </summary>
        [JsonProperty("charge_mode", NullValueHandling = NullValueHandling.Ignore)]
        public int? ChargeMode { get; set; }

        /// <summary>
        /// 服务类型
        /// </summary>
        [JsonProperty("service_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? ServiceType { get; set; }

        /// <summary>
        /// 引擎类型
        /// </summary>
        [JsonProperty("engine_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("flavor", NullValueHandling = NullValueHandling.Ignore)]
        public Flavor Flavor { get; set; }

        /// <summary>
        /// 防护对象列表
        /// </summary>
        [JsonProperty("protect_objects", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProtectObjectVO> ProtectObjects { get; set; }

        /// <summary>
        /// 防火墙状态列表，包括-1：等待支付，0：创建中，1，删除中，2：运行中，3：升级中，4：删除完成：5：冻结中，6：创建失败，7：删除失败，8：冻结失败，9：存储中，10：存储失败，11：升级失败
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 是否为旧引擎，true表示是，false表示不是
        /// </summary>
        [JsonProperty("is_old_firewall_instance", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsOldFirewallInstance { get; set; }

        /// <summary>
        /// 是否支持ipv6，true表示是，false表示不是
        /// </summary>
        [JsonProperty("support_ipv6", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportIpv6 { get; set; }

        /// <summary>
        /// 特性开关，boolean值为true表示是，false表示否
        /// </summary>
        [JsonProperty("feature_toggle", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, bool?> FeatureToggle { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListFirewallUsingGetResponse {\n");
            sb.Append("  fwInstanceId: ").Append(FwInstanceId).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  haType: ").Append(HaType).Append("\n");
            sb.Append("  chargeMode: ").Append(ChargeMode).Append("\n");
            sb.Append("  serviceType: ").Append(ServiceType).Append("\n");
            sb.Append("  engineType: ").Append(EngineType).Append("\n");
            sb.Append("  flavor: ").Append(Flavor).Append("\n");
            sb.Append("  protectObjects: ").Append(ProtectObjects).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  isOldFirewallInstance: ").Append(IsOldFirewallInstance).Append("\n");
            sb.Append("  supportIpv6: ").Append(SupportIpv6).Append("\n");
            sb.Append("  featureToggle: ").Append(FeatureToggle).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListFirewallUsingGetResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListFirewallUsingGetResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FwInstanceId == input.FwInstanceId ||
                    (this.FwInstanceId != null &&
                    this.FwInstanceId.Equals(input.FwInstanceId))
                ) && 
                (
                    this.ResourceId == input.ResourceId ||
                    (this.ResourceId != null &&
                    this.ResourceId.Equals(input.ResourceId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.HaType == input.HaType ||
                    (this.HaType != null &&
                    this.HaType.Equals(input.HaType))
                ) && 
                (
                    this.ChargeMode == input.ChargeMode ||
                    (this.ChargeMode != null &&
                    this.ChargeMode.Equals(input.ChargeMode))
                ) && 
                (
                    this.ServiceType == input.ServiceType ||
                    (this.ServiceType != null &&
                    this.ServiceType.Equals(input.ServiceType))
                ) && 
                (
                    this.EngineType == input.EngineType ||
                    (this.EngineType != null &&
                    this.EngineType.Equals(input.EngineType))
                ) && 
                (
                    this.Flavor == input.Flavor ||
                    (this.Flavor != null &&
                    this.Flavor.Equals(input.Flavor))
                ) && 
                (
                    this.ProtectObjects == input.ProtectObjects ||
                    this.ProtectObjects != null &&
                    input.ProtectObjects != null &&
                    this.ProtectObjects.SequenceEqual(input.ProtectObjects)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.IsOldFirewallInstance == input.IsOldFirewallInstance ||
                    (this.IsOldFirewallInstance != null &&
                    this.IsOldFirewallInstance.Equals(input.IsOldFirewallInstance))
                ) && 
                (
                    this.SupportIpv6 == input.SupportIpv6 ||
                    (this.SupportIpv6 != null &&
                    this.SupportIpv6.Equals(input.SupportIpv6))
                ) && 
                (
                    this.FeatureToggle == input.FeatureToggle ||
                    this.FeatureToggle != null &&
                    input.FeatureToggle != null &&
                    this.FeatureToggle.SequenceEqual(input.FeatureToggle)
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
                if (this.FwInstanceId != null)
                    hashCode = hashCode * 59 + this.FwInstanceId.GetHashCode();
                if (this.ResourceId != null)
                    hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.HaType != null)
                    hashCode = hashCode * 59 + this.HaType.GetHashCode();
                if (this.ChargeMode != null)
                    hashCode = hashCode * 59 + this.ChargeMode.GetHashCode();
                if (this.ServiceType != null)
                    hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                if (this.EngineType != null)
                    hashCode = hashCode * 59 + this.EngineType.GetHashCode();
                if (this.Flavor != null)
                    hashCode = hashCode * 59 + this.Flavor.GetHashCode();
                if (this.ProtectObjects != null)
                    hashCode = hashCode * 59 + this.ProtectObjects.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.IsOldFirewallInstance != null)
                    hashCode = hashCode * 59 + this.IsOldFirewallInstance.GetHashCode();
                if (this.SupportIpv6 != null)
                    hashCode = hashCode * 59 + this.SupportIpv6.GetHashCode();
                if (this.FeatureToggle != null)
                    hashCode = hashCode * 59 + this.FeatureToggle.GetHashCode();
                return hashCode;
            }
        }
    }
}
