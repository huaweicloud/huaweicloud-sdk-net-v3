using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 资源配置。
    /// </summary>
    public class ChatResourceConfigInfo 
    {
        /// <summary>
        /// 资源来源。 * PURCHASED: 购买 * SP_ALLOCATED：SP分配 * ADMIN_ALLOCATED：系统管理员分配 &gt; * 开通按需；购买按需套餐包、一次性资源、包周期等都属于PURCHASED。
        /// </summary>
        /// <value>资源来源。 * PURCHASED: 购买 * SP_ALLOCATED：SP分配 * ADMIN_ALLOCATED：系统管理员分配 &gt; * 开通按需；购买按需套餐包、一次性资源、包周期等都属于PURCHASED。</value>
        [JsonConverter(typeof(EnumClassConverter<ResourceSourceEnum>))]
        public class ResourceSourceEnum
        {
            /// <summary>
            /// Enum PURCHASED for value: PURCHASED
            /// </summary>
            public static readonly ResourceSourceEnum PURCHASED = new ResourceSourceEnum("PURCHASED");

            /// <summary>
            /// Enum SP_ALLOCATED for value: SP_ALLOCATED
            /// </summary>
            public static readonly ResourceSourceEnum SP_ALLOCATED = new ResourceSourceEnum("SP_ALLOCATED");

            /// <summary>
            /// Enum ADMIN_ALLOCATED for value: ADMIN_ALLOCATED
            /// </summary>
            public static readonly ResourceSourceEnum ADMIN_ALLOCATED = new ResourceSourceEnum("ADMIN_ALLOCATED");

            private static readonly Dictionary<string, ResourceSourceEnum> StaticFields =
            new Dictionary<string, ResourceSourceEnum>()
            {
                { "PURCHASED", PURCHASED },
                { "SP_ALLOCATED", SP_ALLOCATED },
                { "ADMIN_ALLOCATED", ADMIN_ALLOCATED },
            };

            private string _value;

            public ResourceSourceEnum()
            {

            }

            public ResourceSourceEnum(string value)
            {
                _value = value;
            }

            public static ResourceSourceEnum FromValue(string value)
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

                if (this.Equals(obj as ResourceSourceEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ResourceSourceEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ResourceSourceEnum a, ResourceSourceEnum b)
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

            public static bool operator !=(ResourceSourceEnum a, ResourceSourceEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 资源计费类型。 * PERIODIC: 包周期 * ONE_TIME：一次性计费 * ON_DEMAND: 按需计费 &gt; * 一次性计费包括：租户订购的一次性资源，SP管理员分配给租户的一次性资源，SP管理员分配给租户的按需套餐包资源，系统管理员分配的资源（分钟数等）。
        /// </summary>
        /// <value>资源计费类型。 * PERIODIC: 包周期 * ONE_TIME：一次性计费 * ON_DEMAND: 按需计费 &gt; * 一次性计费包括：租户订购的一次性资源，SP管理员分配给租户的一次性资源，SP管理员分配给租户的按需套餐包资源，系统管理员分配的资源（分钟数等）。</value>
        [JsonConverter(typeof(EnumClassConverter<ChargeModeEnum>))]
        public class ChargeModeEnum
        {
            /// <summary>
            /// Enum PERIODIC for value: PERIODIC
            /// </summary>
            public static readonly ChargeModeEnum PERIODIC = new ChargeModeEnum("PERIODIC");

            /// <summary>
            /// Enum ONE_TIME for value: ONE_TIME
            /// </summary>
            public static readonly ChargeModeEnum ONE_TIME = new ChargeModeEnum("ONE_TIME");

            /// <summary>
            /// Enum ON_DEMAND for value: ON_DEMAND
            /// </summary>
            public static readonly ChargeModeEnum ON_DEMAND = new ChargeModeEnum("ON_DEMAND");

            private static readonly Dictionary<string, ChargeModeEnum> StaticFields =
            new Dictionary<string, ChargeModeEnum>()
            {
                { "PERIODIC", PERIODIC },
                { "ONE_TIME", ONE_TIME },
                { "ON_DEMAND", ON_DEMAND },
            };

            private string _value;

            public ChargeModeEnum()
            {

            }

            public ChargeModeEnum(string value)
            {
                _value = value;
            }

            public static ChargeModeEnum FromValue(string value)
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

                if (this.Equals(obj as ChargeModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ChargeModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ChargeModeEnum a, ChargeModeEnum b)
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

            public static bool operator !=(ChargeModeEnum a, ChargeModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 资源状态。 * ACTIVE: 正常 * FREEZE：冻结 * DELETED：退订或过期
        /// </summary>
        /// <value>资源状态。 * ACTIVE: 正常 * FREEZE：冻结 * DELETED：退订或过期</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            public static readonly StatusEnum ACTIVE = new StatusEnum("ACTIVE");

            /// <summary>
            /// Enum FREEZE for value: FREEZE
            /// </summary>
            public static readonly StatusEnum FREEZE = new StatusEnum("FREEZE");

            /// <summary>
            /// Enum DELETED for value: DELETED
            /// </summary>
            public static readonly StatusEnum DELETED = new StatusEnum("DELETED");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "ACTIVE", ACTIVE },
                { "FREEZE", FREEZE },
                { "DELETED", DELETED },
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
        /// 资源id
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 资源数量
        /// </summary>
        [JsonProperty("count_resource", NullValueHandling = NullValueHandling.Ignore)]
        public int? CountResource { get; set; }

        /// <summary>
        /// 资源来源。 * PURCHASED: 购买 * SP_ALLOCATED：SP分配 * ADMIN_ALLOCATED：系统管理员分配 &gt; * 开通按需；购买按需套餐包、一次性资源、包周期等都属于PURCHASED。
        /// </summary>
        [JsonProperty("resource_source", NullValueHandling = NullValueHandling.Ignore)]
        public ResourceSourceEnum ResourceSource { get; set; }
        /// <summary>
        /// 资源计费类型。 * PERIODIC: 包周期 * ONE_TIME：一次性计费 * ON_DEMAND: 按需计费 &gt; * 一次性计费包括：租户订购的一次性资源，SP管理员分配给租户的一次性资源，SP管理员分配给租户的按需套餐包资源，系统管理员分配的资源（分钟数等）。
        /// </summary>
        [JsonProperty("charge_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ChargeModeEnum ChargeMode { get; set; }
        /// <summary>
        /// 资源数量。智能交互并发路数。
        /// </summary>
        [JsonProperty("resource_nums", NullValueHandling = NullValueHandling.Ignore)]
        public int? ResourceNums { get; set; }

        /// <summary>
        /// 可用资源数量。智能交互并发路数。
        /// </summary>
        [JsonProperty("resource_available_nums", NullValueHandling = NullValueHandling.Ignore)]
        public int? ResourceAvailableNums { get; set; }

        /// <summary>
        /// 资源状态。 * ACTIVE: 正常 * FREEZE：冻结 * DELETED：退订或过期
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 资源过期时间，格式遵循：RFC 3339 如\&quot;2021-01-10T08:43:17Z\&quot;
        /// </summary>
        [JsonProperty("expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpireTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChatResourceConfigInfo {\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  countResource: ").Append(CountResource).Append("\n");
            sb.Append("  resourceSource: ").Append(ResourceSource).Append("\n");
            sb.Append("  chargeMode: ").Append(ChargeMode).Append("\n");
            sb.Append("  resourceNums: ").Append(ResourceNums).Append("\n");
            sb.Append("  resourceAvailableNums: ").Append(ResourceAvailableNums).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  expireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChatResourceConfigInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChatResourceConfigInfo input)
        {
            if (input == null) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.CountResource != input.CountResource || (this.CountResource != null && !this.CountResource.Equals(input.CountResource))) return false;
            if (this.ResourceSource != input.ResourceSource) return false;
            if (this.ChargeMode != input.ChargeMode) return false;
            if (this.ResourceNums != input.ResourceNums || (this.ResourceNums != null && !this.ResourceNums.Equals(input.ResourceNums))) return false;
            if (this.ResourceAvailableNums != input.ResourceAvailableNums || (this.ResourceAvailableNums != null && !this.ResourceAvailableNums.Equals(input.ResourceAvailableNums))) return false;
            if (this.Status != input.Status) return false;
            if (this.ExpireTime != input.ExpireTime || (this.ExpireTime != null && !this.ExpireTime.Equals(input.ExpireTime))) return false;

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
                if (this.ResourceId != null) hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.CountResource != null) hashCode = hashCode * 59 + this.CountResource.GetHashCode();
                hashCode = hashCode * 59 + this.ResourceSource.GetHashCode();
                hashCode = hashCode * 59 + this.ChargeMode.GetHashCode();
                if (this.ResourceNums != null) hashCode = hashCode * 59 + this.ResourceNums.GetHashCode();
                if (this.ResourceAvailableNums != null) hashCode = hashCode * 59 + this.ResourceAvailableNums.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ExpireTime != null) hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
