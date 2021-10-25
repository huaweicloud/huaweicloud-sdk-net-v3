using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V3.Model
{
    /// <summary>
    /// 公网IP元数据, EIP服务内部使用，不对外开放
    /// </summary>
    public class ProfileInfo 
    {
        /// <summary>
        /// 云服务标识公网IP创建进度, EIP服务内部使用。
        /// </summary>
        /// <value>云服务标识公网IP创建进度, EIP服务内部使用。</value>
        [JsonConverter(typeof(EnumClassConverter<NotifyStatusEnum>))]
        public class NotifyStatusEnum
        {
            /// <summary>
            /// Enum PENDING_CREATE for value: PENDING_CREATE
            /// </summary>
            public static readonly NotifyStatusEnum PENDING_CREATE = new NotifyStatusEnum("PENDING_CREATE");

            /// <summary>
            /// Enum PENDING_UPDATE for value: PENDING_UPDATE
            /// </summary>
            public static readonly NotifyStatusEnum PENDING_UPDATE = new NotifyStatusEnum("PENDING_UPDATE");

            /// <summary>
            /// Enum NOTIFYING for value: NOTIFYING
            /// </summary>
            public static readonly NotifyStatusEnum NOTIFYING = new NotifyStatusEnum("NOTIFYING");

            /// <summary>
            /// Enum NOTIFYED for value: NOTIFYED
            /// </summary>
            public static readonly NotifyStatusEnum NOTIFYED = new NotifyStatusEnum("NOTIFYED");

            /// <summary>
            /// Enum NOTIFY_DELETE for value: NOTIFY_DELETE
            /// </summary>
            public static readonly NotifyStatusEnum NOTIFY_DELETE = new NotifyStatusEnum("NOTIFY_DELETE");

            private static readonly Dictionary<string, NotifyStatusEnum> StaticFields =
            new Dictionary<string, NotifyStatusEnum>()
            {
                { "PENDING_CREATE", PENDING_CREATE },
                { "PENDING_UPDATE", PENDING_UPDATE },
                { "NOTIFYING", NOTIFYING },
                { "NOTIFYED", NOTIFYED },
                { "NOTIFY_DELETE", NOTIFY_DELETE },
            };

            private string Value;

            public NotifyStatusEnum(string value)
            {
                Value = value;
            }

            public static NotifyStatusEnum FromValue(string value)
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

                if (this.Equals(obj as NotifyStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(NotifyStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(NotifyStatusEnum a, NotifyStatusEnum b)
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

            public static bool operator !=(NotifyStatusEnum a, NotifyStatusEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 标识IP是和哪类资源一起购买的
        /// </summary>
        /// <value>标识IP是和哪类资源一起购买的</value>
        [JsonConverter(typeof(EnumClassConverter<CreateSourceEnum>))]
        public class CreateSourceEnum
        {
            /// <summary>
            /// Enum ECS for value: ecs
            /// </summary>
            public static readonly CreateSourceEnum ECS = new CreateSourceEnum("ecs");

            private static readonly Dictionary<string, CreateSourceEnum> StaticFields =
            new Dictionary<string, CreateSourceEnum>()
            {
                { "ecs", ECS },
            };

            private string Value;

            public CreateSourceEnum(string value)
            {
                Value = value;
            }

            public static CreateSourceEnum FromValue(string value)
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

                if (this.Equals(obj as CreateSourceEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CreateSourceEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(CreateSourceEnum a, CreateSourceEnum b)
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

            public static bool operator !=(CreateSourceEnum a, CreateSourceEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 公网IP冻结状态。
        /// </summary>
        /// <value>公网IP冻结状态。</value>
        [JsonConverter(typeof(EnumClassConverter<FreezedStatusEnum>))]
        public class FreezedStatusEnum
        {
            /// <summary>
            /// Enum FREEZED for value: FREEZED
            /// </summary>
            public static readonly FreezedStatusEnum FREEZED = new FreezedStatusEnum("FREEZED");

            /// <summary>
            /// Enum UNFREEZED for value: UNFREEZED
            /// </summary>
            public static readonly FreezedStatusEnum UNFREEZED = new FreezedStatusEnum("UNFREEZED");

            private static readonly Dictionary<string, FreezedStatusEnum> StaticFields =
            new Dictionary<string, FreezedStatusEnum>()
            {
                { "FREEZED", FREEZED },
                { "UNFREEZED", UNFREEZED },
            };

            private string Value;

            public FreezedStatusEnum(string value)
            {
                Value = value;
            }

            public static FreezedStatusEnum FromValue(string value)
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

                if (this.Equals(obj as FreezedStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(FreezedStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(FreezedStatusEnum a, FreezedStatusEnum b)
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

            public static bool operator !=(FreezedStatusEnum a, FreezedStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 公网IP附属的5_xxx网络（如5_bgp）中的port_id
        /// </summary>
        [JsonProperty("local_network_port", NullValueHandling = NullValueHandling.Ignore)]
        public string LocalNetworkPort { get; set; }

        /// <summary>
        /// 标识公网IP是否是和虚机一起创建的。true-独立创建；false-和虚机一起创建
        /// </summary>
        [JsonProperty("standalone", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Standalone { get; set; }

        /// <summary>
        /// 云服务标识公网IP创建进度, EIP服务内部使用。
        /// </summary>
        [JsonProperty("notify_status", NullValueHandling = NullValueHandling.Ignore)]
        public NotifyStatusEnum NotifyStatus { get; set; }
        /// <summary>
        /// 公网IP创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 该字段仅仅用于表示eip的bgp类型是否是真实的静态sbgp * 1. 如果为true，则该eip可以切换bgp类型 * 2. 如果为false，则该eip不可以切换bgp类型
        /// </summary>
        [JsonProperty("fake_network_type", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FakeNetworkType { get; set; }

        /// <summary>
        /// 标识IP是和哪类资源一起购买的
        /// </summary>
        [JsonProperty("create_source", NullValueHandling = NullValueHandling.Ignore)]
        public CreateSourceEnum CreateSource { get; set; }
        /// <summary>
        /// 标识和公网IP一起购买的ecs的id
        /// </summary>
        [JsonProperty("ecs_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EcsId { get; set; }

        /// <summary>
        /// 公网IP加锁状态, eg:\&quot;POLICE,LOCKED\&quot;。POLICE-公安冻结；LOCKED-普通冻结；普通冻结细分状态：ARREAR-欠费；DELABLE-可删除；
        /// </summary>
        [JsonProperty("lock_status", NullValueHandling = NullValueHandling.Ignore)]
        public string LockStatus { get; set; }

        /// <summary>
        /// 公网IP冻结状态。
        /// </summary>
        [JsonProperty("freezed_status", NullValueHandling = NullValueHandling.Ignore)]
        public FreezedStatusEnum FreezedStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bandwith_info", NullValueHandling = NullValueHandling.Ignore)]
        public BandwidthInfoResp BandwithInfo { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProfileInfo {\n");
            sb.Append("  localNetworkPort: ").Append(LocalNetworkPort).Append("\n");
            sb.Append("  standalone: ").Append(Standalone).Append("\n");
            sb.Append("  notifyStatus: ").Append(NotifyStatus).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  fakeNetworkType: ").Append(FakeNetworkType).Append("\n");
            sb.Append("  createSource: ").Append(CreateSource).Append("\n");
            sb.Append("  ecsId: ").Append(EcsId).Append("\n");
            sb.Append("  lockStatus: ").Append(LockStatus).Append("\n");
            sb.Append("  freezedStatus: ").Append(FreezedStatus).Append("\n");
            sb.Append("  bandwithInfo: ").Append(BandwithInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProfileInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProfileInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LocalNetworkPort == input.LocalNetworkPort ||
                    (this.LocalNetworkPort != null &&
                    this.LocalNetworkPort.Equals(input.LocalNetworkPort))
                ) && 
                (
                    this.Standalone == input.Standalone ||
                    (this.Standalone != null &&
                    this.Standalone.Equals(input.Standalone))
                ) && 
                (
                    this.NotifyStatus == input.NotifyStatus ||
                    (this.NotifyStatus != null &&
                    this.NotifyStatus.Equals(input.NotifyStatus))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.FakeNetworkType == input.FakeNetworkType ||
                    (this.FakeNetworkType != null &&
                    this.FakeNetworkType.Equals(input.FakeNetworkType))
                ) && 
                (
                    this.CreateSource == input.CreateSource ||
                    (this.CreateSource != null &&
                    this.CreateSource.Equals(input.CreateSource))
                ) && 
                (
                    this.EcsId == input.EcsId ||
                    (this.EcsId != null &&
                    this.EcsId.Equals(input.EcsId))
                ) && 
                (
                    this.LockStatus == input.LockStatus ||
                    (this.LockStatus != null &&
                    this.LockStatus.Equals(input.LockStatus))
                ) && 
                (
                    this.FreezedStatus == input.FreezedStatus ||
                    (this.FreezedStatus != null &&
                    this.FreezedStatus.Equals(input.FreezedStatus))
                ) && 
                (
                    this.BandwithInfo == input.BandwithInfo ||
                    (this.BandwithInfo != null &&
                    this.BandwithInfo.Equals(input.BandwithInfo))
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
                if (this.LocalNetworkPort != null)
                    hashCode = hashCode * 59 + this.LocalNetworkPort.GetHashCode();
                if (this.Standalone != null)
                    hashCode = hashCode * 59 + this.Standalone.GetHashCode();
                if (this.NotifyStatus != null)
                    hashCode = hashCode * 59 + this.NotifyStatus.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.FakeNetworkType != null)
                    hashCode = hashCode * 59 + this.FakeNetworkType.GetHashCode();
                if (this.CreateSource != null)
                    hashCode = hashCode * 59 + this.CreateSource.GetHashCode();
                if (this.EcsId != null)
                    hashCode = hashCode * 59 + this.EcsId.GetHashCode();
                if (this.LockStatus != null)
                    hashCode = hashCode * 59 + this.LockStatus.GetHashCode();
                if (this.FreezedStatus != null)
                    hashCode = hashCode * 59 + this.FreezedStatus.GetHashCode();
                if (this.BandwithInfo != null)
                    hashCode = hashCode * 59 + this.BandwithInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
