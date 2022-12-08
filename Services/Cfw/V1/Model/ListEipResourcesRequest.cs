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
    /// Request Object
    /// </summary>
    public class ListEipResourcesRequest 
    {
        /// <summary>
        /// 防护状态 null-全部 0-开启防护 1-关闭防护
        /// </summary>
        /// <value>防护状态 null-全部 0-开启防护 1-关闭防护</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum NULL for value: null
            /// </summary>
            public static readonly StatusEnum NULL = new StatusEnum("null");

            /// <summary>
            /// Enum _0 for value: 0
            /// </summary>
            public static readonly StatusEnum _0 = new StatusEnum("0");

            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            public static readonly StatusEnum _1 = new StatusEnum("1");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "null", NULL },
                { "0", _0 },
                { "1", _1 },
            };

            private string Value;

            public StatusEnum(string value)
            {
                Value = value;
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
        /// 是否同步租户EIP数据 0-不同步 1-同步
        /// </summary>
        /// <value>是否同步租户EIP数据 0-不同步 1-同步</value>
        [JsonConverter(typeof(EnumClassConverter<SyncEnum>))]
        public class SyncEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly SyncEnum NUMBER_0 = new SyncEnum(0);

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly SyncEnum NUMBER_1 = new SyncEnum(1);

            private static readonly Dictionary<int?, SyncEnum> StaticFields =
            new Dictionary<int?, SyncEnum>()
            {
                { 0, NUMBER_0 },
                { 1, NUMBER_1 },
            };

            private int? Value;

            public SyncEnum(int? value)
            {
                Value = value;
            }

            public static SyncEnum FromValue(int? value)
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

                if (this.Equals(obj as SyncEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SyncEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(SyncEnum a, SyncEnum b)
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

            public static bool operator !=(SyncEnum a, SyncEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 防护对象ID
        /// </summary>
        [SDKProperty("object_id", IsQuery = true)]
        [JsonProperty("object_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectId { get; set; }

        /// <summary>
        /// 弹性公网ID/弹性公网IP
        /// </summary>
        [SDKProperty("key_word", IsQuery = true)]
        [JsonProperty("key_word", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyWord { get; set; }

        /// <summary>
        /// 防护状态 null-全部 0-开启防护 1-关闭防护
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 是否同步租户EIP数据 0-不同步 1-同步
        /// </summary>
        [SDKProperty("sync", IsQuery = true)]
        [JsonProperty("sync", NullValueHandling = NullValueHandling.Ignore)]
        public SyncEnum Sync { get; set; }
        /// <summary>
        /// 每页显示个数
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 偏移量：指定返回记录的开始位置，必须为数字，取值范围为大于或等于0，默认0
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 企业项目id
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 设备键
        /// </summary>
        [SDKProperty("device_key", IsQuery = true)]
        [JsonProperty("device_key", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceKey { get; set; }

        /// <summary>
        /// 地址类型0 ipv4,1 ipv6
        /// </summary>
        [SDKProperty("address_type", IsQuery = true)]
        [JsonProperty("address_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? AddressType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEipResourcesRequest {\n");
            sb.Append("  objectId: ").Append(ObjectId).Append("\n");
            sb.Append("  keyWord: ").Append(KeyWord).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  sync: ").Append(Sync).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  deviceKey: ").Append(DeviceKey).Append("\n");
            sb.Append("  addressType: ").Append(AddressType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListEipResourcesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListEipResourcesRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjectId == input.ObjectId ||
                    (this.ObjectId != null &&
                    this.ObjectId.Equals(input.ObjectId))
                ) && 
                (
                    this.KeyWord == input.KeyWord ||
                    (this.KeyWord != null &&
                    this.KeyWord.Equals(input.KeyWord))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Sync == input.Sync ||
                    (this.Sync != null &&
                    this.Sync.Equals(input.Sync))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.DeviceKey == input.DeviceKey ||
                    (this.DeviceKey != null &&
                    this.DeviceKey.Equals(input.DeviceKey))
                ) && 
                (
                    this.AddressType == input.AddressType ||
                    (this.AddressType != null &&
                    this.AddressType.Equals(input.AddressType))
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
                if (this.ObjectId != null)
                    hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                if (this.KeyWord != null)
                    hashCode = hashCode * 59 + this.KeyWord.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Sync != null)
                    hashCode = hashCode * 59 + this.Sync.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.DeviceKey != null)
                    hashCode = hashCode * 59 + this.DeviceKey.GetHashCode();
                if (this.AddressType != null)
                    hashCode = hashCode * 59 + this.AddressType.GetHashCode();
                return hashCode;
            }
        }
    }
}