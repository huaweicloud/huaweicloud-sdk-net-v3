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
    /// 
    /// </summary>
    public class VoiceTrainingResource 
    {
        /// <summary>
        /// 资源操作类型。 * ADD: 新增资源 * UPDATE：更新资源 * FREEZE：停用资源 * UNFREEZE：启用资源 * REBIND: 重新绑定资源
        /// </summary>
        /// <value>资源操作类型。 * ADD: 新增资源 * UPDATE：更新资源 * FREEZE：停用资源 * UNFREEZE：启用资源 * REBIND: 重新绑定资源</value>
        [JsonConverter(typeof(EnumClassConverter<OperationTypeEnum>))]
        public class OperationTypeEnum
        {
            /// <summary>
            /// Enum ADD for value: ADD
            /// </summary>
            public static readonly OperationTypeEnum ADD = new OperationTypeEnum("ADD");

            /// <summary>
            /// Enum UPDATE for value: UPDATE
            /// </summary>
            public static readonly OperationTypeEnum UPDATE = new OperationTypeEnum("UPDATE");

            /// <summary>
            /// Enum FREEZE for value: FREEZE
            /// </summary>
            public static readonly OperationTypeEnum FREEZE = new OperationTypeEnum("FREEZE");

            /// <summary>
            /// Enum UNFREEZE for value: UNFREEZE
            /// </summary>
            public static readonly OperationTypeEnum UNFREEZE = new OperationTypeEnum("UNFREEZE");

            /// <summary>
            /// Enum REBIND for value: REBIND
            /// </summary>
            public static readonly OperationTypeEnum REBIND = new OperationTypeEnum("REBIND");

            private static readonly Dictionary<string, OperationTypeEnum> StaticFields =
            new Dictionary<string, OperationTypeEnum>()
            {
                { "ADD", ADD },
                { "UPDATE", UPDATE },
                { "FREEZE", FREEZE },
                { "UNFREEZE", UNFREEZE },
                { "REBIND", REBIND },
            };

            private string _value;

            public OperationTypeEnum()
            {

            }

            public OperationTypeEnum(string value)
            {
                _value = value;
            }

            public static OperationTypeEnum FromValue(string value)
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

                if (this.Equals(obj as OperationTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OperationTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OperationTypeEnum a, OperationTypeEnum b)
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

            public static bool operator !=(OperationTypeEnum a, OperationTypeEnum b)
            {
                return !(a == b);
            }
        }

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

            public static bool operator !=(ResourceSourceEnum a, ResourceSourceEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 资源类型。 * BASIC: 基础版 * MIDDLE: 进阶版 * ADVANCE：高级版 * THIRD_PARTY：第三方出门问问 * THIRD_PARTY_LJZN: 第三方逻辑智能 * TTS_CMWW：TTS资源 * TTS_LJZN: 逻辑智能TTS资源 * FLEXUS: Flexus版资源
        /// </summary>
        /// <value>资源类型。 * BASIC: 基础版 * MIDDLE: 进阶版 * ADVANCE：高级版 * THIRD_PARTY：第三方出门问问 * THIRD_PARTY_LJZN: 第三方逻辑智能 * TTS_CMWW：TTS资源 * TTS_LJZN: 逻辑智能TTS资源 * FLEXUS: Flexus版资源</value>
        [JsonConverter(typeof(EnumClassConverter<ResourceTypeEnum>))]
        public class ResourceTypeEnum
        {
            /// <summary>
            /// Enum BASIC for value: BASIC
            /// </summary>
            public static readonly ResourceTypeEnum BASIC = new ResourceTypeEnum("BASIC");

            /// <summary>
            /// Enum MIDDLE for value: MIDDLE
            /// </summary>
            public static readonly ResourceTypeEnum MIDDLE = new ResourceTypeEnum("MIDDLE");

            /// <summary>
            /// Enum ADVANCE for value: ADVANCE
            /// </summary>
            public static readonly ResourceTypeEnum ADVANCE = new ResourceTypeEnum("ADVANCE");

            /// <summary>
            /// Enum THIRD_PARTY for value: THIRD_PARTY
            /// </summary>
            public static readonly ResourceTypeEnum THIRD_PARTY = new ResourceTypeEnum("THIRD_PARTY");

            /// <summary>
            /// Enum THIRD_PARTY_LJZN for value: THIRD_PARTY_LJZN
            /// </summary>
            public static readonly ResourceTypeEnum THIRD_PARTY_LJZN = new ResourceTypeEnum("THIRD_PARTY_LJZN");

            /// <summary>
            /// Enum TTS_CMWW for value: TTS_CMWW
            /// </summary>
            public static readonly ResourceTypeEnum TTS_CMWW = new ResourceTypeEnum("TTS_CMWW");

            /// <summary>
            /// Enum TTS_LJZN for value: TTS_LJZN
            /// </summary>
            public static readonly ResourceTypeEnum TTS_LJZN = new ResourceTypeEnum("TTS_LJZN");

            /// <summary>
            /// Enum FLEXUS for value: FLEXUS
            /// </summary>
            public static readonly ResourceTypeEnum FLEXUS = new ResourceTypeEnum("FLEXUS");

            private static readonly Dictionary<string, ResourceTypeEnum> StaticFields =
            new Dictionary<string, ResourceTypeEnum>()
            {
                { "BASIC", BASIC },
                { "MIDDLE", MIDDLE },
                { "ADVANCE", ADVANCE },
                { "THIRD_PARTY", THIRD_PARTY },
                { "THIRD_PARTY_LJZN", THIRD_PARTY_LJZN },
                { "TTS_CMWW", TTS_CMWW },
                { "TTS_LJZN", TTS_LJZN },
                { "FLEXUS", FLEXUS },
            };

            private string _value;

            public ResourceTypeEnum()
            {

            }

            public ResourceTypeEnum(string value)
            {
                _value = value;
            }

            public static ResourceTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ResourceTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ResourceTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ResourceTypeEnum a, ResourceTypeEnum b)
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

            public static bool operator !=(ResourceTypeEnum a, ResourceTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 资源操作类型。 * ADD: 新增资源 * UPDATE：更新资源 * FREEZE：停用资源 * UNFREEZE：启用资源 * REBIND: 重新绑定资源
        /// </summary>
        [JsonProperty("operation_type", NullValueHandling = NullValueHandling.Ignore)]
        public OperationTypeEnum OperationType { get; set; }
        /// <summary>
        /// 资源来源。 * PURCHASED: 购买 * SP_ALLOCATED：SP分配 * ADMIN_ALLOCATED：系统管理员分配 &gt; * 开通按需；购买按需套餐包、一次性资源、包周期等都属于PURCHASED。
        /// </summary>
        [JsonProperty("resource_source", NullValueHandling = NullValueHandling.Ignore)]
        public ResourceSourceEnum ResourceSource { get; set; }
        /// <summary>
        /// 资产ID。
        /// </summary>
        [JsonProperty("asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetId { get; set; }

        /// <summary>
        /// 资源ID。
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 资源数量。声音模型训练个数。
        /// </summary>
        [JsonProperty("resource_nums", NullValueHandling = NullValueHandling.Ignore)]
        public int? ResourceNums { get; set; }

        /// <summary>
        /// 可用资源数量。可用声音模型训练个数。
        /// </summary>
        [JsonProperty("resource_available_nums", NullValueHandling = NullValueHandling.Ignore)]
        public int? ResourceAvailableNums { get; set; }

        /// <summary>
        /// 资源类型。 * BASIC: 基础版 * MIDDLE: 进阶版 * ADVANCE：高级版 * THIRD_PARTY：第三方出门问问 * THIRD_PARTY_LJZN: 第三方逻辑智能 * TTS_CMWW：TTS资源 * TTS_LJZN: 逻辑智能TTS资源 * FLEXUS: Flexus版资源
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public ResourceTypeEnum ResourceType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("charge_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ChardMode? ChargeMode { get; set; }

        /// <summary>
        /// 资源过期时间，格式遵循：RFC 3339 如\&quot;2021-01-10T08:43:17Z\&quot;
        /// </summary>
        [JsonProperty("expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 资源状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VoiceTrainingResource {\n");
            sb.Append("  operationType: ").Append(OperationType).Append("\n");
            sb.Append("  resourceSource: ").Append(ResourceSource).Append("\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  resourceNums: ").Append(ResourceNums).Append("\n");
            sb.Append("  resourceAvailableNums: ").Append(ResourceAvailableNums).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  chargeMode: ").Append(ChargeMode).Append("\n");
            sb.Append("  expireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VoiceTrainingResource);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VoiceTrainingResource input)
        {
            if (input == null) return false;
            if (this.OperationType != input.OperationType) return false;
            if (this.ResourceSource != input.ResourceSource) return false;
            if (this.AssetId != input.AssetId || (this.AssetId != null && !this.AssetId.Equals(input.AssetId))) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.ResourceNums != input.ResourceNums || (this.ResourceNums != null && !this.ResourceNums.Equals(input.ResourceNums))) return false;
            if (this.ResourceAvailableNums != input.ResourceAvailableNums || (this.ResourceAvailableNums != null && !this.ResourceAvailableNums.Equals(input.ResourceAvailableNums))) return false;
            if (this.ResourceType != input.ResourceType) return false;
            if (this.ChargeMode != input.ChargeMode || (this.ChargeMode != null && !this.ChargeMode.Equals(input.ChargeMode))) return false;
            if (this.ExpireTime != input.ExpireTime || (this.ExpireTime != null && !this.ExpireTime.Equals(input.ExpireTime))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;

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
                hashCode = hashCode * 59 + this.OperationType.GetHashCode();
                hashCode = hashCode * 59 + this.ResourceSource.GetHashCode();
                if (this.AssetId != null) hashCode = hashCode * 59 + this.AssetId.GetHashCode();
                if (this.ResourceId != null) hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.ResourceNums != null) hashCode = hashCode * 59 + this.ResourceNums.GetHashCode();
                if (this.ResourceAvailableNums != null) hashCode = hashCode * 59 + this.ResourceAvailableNums.GetHashCode();
                hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.ChargeMode != null) hashCode = hashCode * 59 + this.ChargeMode.GetHashCode();
                if (this.ExpireTime != null) hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
