using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V2.Model
{
    /// <summary>
    /// 负载均衡器对象，用于负载均衡器状态树中
    /// </summary>
    public class LoadbalancerV2InStatusResp 
    {
        /// <summary>
        /// 负载均衡器的操作状态；该字段为预留字段，暂未启用。默认为ONLINE。
        /// </summary>
        /// <value>负载均衡器的操作状态；该字段为预留字段，暂未启用。默认为ONLINE。</value>
        [JsonConverter(typeof(EnumClassConverter<OperatingStatusEnum>))]
        public class OperatingStatusEnum
        {
            /// <summary>
            /// Enum ONLINE for value: ONLINE
            /// </summary>
            public static readonly OperatingStatusEnum ONLINE = new OperatingStatusEnum("ONLINE");

            /// <summary>
            /// Enum OFFLINE for value: OFFLINE
            /// </summary>
            public static readonly OperatingStatusEnum OFFLINE = new OperatingStatusEnum("OFFLINE");

            /// <summary>
            /// Enum DEGRADED for value: DEGRADED
            /// </summary>
            public static readonly OperatingStatusEnum DEGRADED = new OperatingStatusEnum("DEGRADED");

            /// <summary>
            /// Enum DISABLED for value: DISABLED
            /// </summary>
            public static readonly OperatingStatusEnum DISABLED = new OperatingStatusEnum("DISABLED");

            /// <summary>
            /// Enum NO_MONITOR for value: NO_MONITOR
            /// </summary>
            public static readonly OperatingStatusEnum NO_MONITOR = new OperatingStatusEnum("NO_MONITOR");

            private static readonly Dictionary<string, OperatingStatusEnum> StaticFields =
            new Dictionary<string, OperatingStatusEnum>()
            {
                { "ONLINE", ONLINE },
                { "OFFLINE", OFFLINE },
                { "DEGRADED", DEGRADED },
                { "DISABLED", DISABLED },
                { "NO_MONITOR", NO_MONITOR },
            };

            private string Value;

            public OperatingStatusEnum(string value)
            {
                Value = value;
            }

            public static OperatingStatusEnum FromValue(string value)
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

                if (this.Equals(obj as OperatingStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OperatingStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(OperatingStatusEnum a, OperatingStatusEnum b)
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

            public static bool operator !=(OperatingStatusEnum a, OperatingStatusEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 负载均衡器的配置状态；该字段为预留字段，暂未启用。默认为ACTIVE。
        /// </summary>
        /// <value>负载均衡器的配置状态；该字段为预留字段，暂未启用。默认为ACTIVE。</value>
        [JsonConverter(typeof(EnumClassConverter<ProvisioningStatusEnum>))]
        public class ProvisioningStatusEnum
        {
            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            public static readonly ProvisioningStatusEnum ACTIVE = new ProvisioningStatusEnum("ACTIVE");

            /// <summary>
            /// Enum PENDING_CREATE for value: PENDING_CREATE
            /// </summary>
            public static readonly ProvisioningStatusEnum PENDING_CREATE = new ProvisioningStatusEnum("PENDING_CREATE");

            /// <summary>
            /// Enum ERROR for value: ERROR
            /// </summary>
            public static readonly ProvisioningStatusEnum ERROR = new ProvisioningStatusEnum("ERROR");

            private static readonly Dictionary<string, ProvisioningStatusEnum> StaticFields =
            new Dictionary<string, ProvisioningStatusEnum>()
            {
                { "ACTIVE", ACTIVE },
                { "PENDING_CREATE", PENDING_CREATE },
                { "ERROR", ERROR },
            };

            private string Value;

            public ProvisioningStatusEnum(string value)
            {
                Value = value;
            }

            public static ProvisioningStatusEnum FromValue(string value)
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

                if (this.Equals(obj as ProvisioningStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ProvisioningStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(ProvisioningStatusEnum a, ProvisioningStatusEnum b)
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

            public static bool operator !=(ProvisioningStatusEnum a, ProvisioningStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 负载均衡器名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 负载均衡器ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 负载均衡器关联的监听器列表
        /// </summary>
        [JsonProperty("listeners", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListenersV2InStatusResp> Listeners { get; set; }

        /// <summary>
        /// 负载均衡器关联的后端云服务器组列表
        /// </summary>
        [JsonProperty("pools", NullValueHandling = NullValueHandling.Ignore)]
        public List<PoolsV2InStatusResp> Pools { get; set; }

        /// <summary>
        /// 负载均衡器的操作状态；该字段为预留字段，暂未启用。默认为ONLINE。
        /// </summary>
        [JsonProperty("operating_status", NullValueHandling = NullValueHandling.Ignore)]
        public OperatingStatusEnum OperatingStatus { get; set; }
        /// <summary>
        /// 负载均衡器的配置状态；该字段为预留字段，暂未启用。默认为ACTIVE。
        /// </summary>
        [JsonProperty("provisioning_status", NullValueHandling = NullValueHandling.Ignore)]
        public ProvisioningStatusEnum ProvisioningStatus { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoadbalancerV2InStatusResp {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  listeners: ").Append(Listeners).Append("\n");
            sb.Append("  pools: ").Append(Pools).Append("\n");
            sb.Append("  operatingStatus: ").Append(OperatingStatus).Append("\n");
            sb.Append("  provisioningStatus: ").Append(ProvisioningStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LoadbalancerV2InStatusResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LoadbalancerV2InStatusResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Listeners == input.Listeners ||
                    this.Listeners != null &&
                    input.Listeners != null &&
                    this.Listeners.SequenceEqual(input.Listeners)
                ) && 
                (
                    this.Pools == input.Pools ||
                    this.Pools != null &&
                    input.Pools != null &&
                    this.Pools.SequenceEqual(input.Pools)
                ) && 
                (
                    this.OperatingStatus == input.OperatingStatus ||
                    (this.OperatingStatus != null &&
                    this.OperatingStatus.Equals(input.OperatingStatus))
                ) && 
                (
                    this.ProvisioningStatus == input.ProvisioningStatus ||
                    (this.ProvisioningStatus != null &&
                    this.ProvisioningStatus.Equals(input.ProvisioningStatus))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Listeners != null)
                    hashCode = hashCode * 59 + this.Listeners.GetHashCode();
                if (this.Pools != null)
                    hashCode = hashCode * 59 + this.Pools.GetHashCode();
                if (this.OperatingStatus != null)
                    hashCode = hashCode * 59 + this.OperatingStatus.GetHashCode();
                if (this.ProvisioningStatus != null)
                    hashCode = hashCode * 59 + this.ProvisioningStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
