using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V2.Model
{
    /// <summary>
    /// 带宽对象
    /// </summary>
    public class BatchBandwidthResp 
    {
        /// <summary>
        /// 功能说明：按流量计费,按带宽计费还是按增强型95计费。  取值范围：bandwidth，traffic，95peak_plus(按增强型95计费)不返回或者为空时表示是bandwidth。  约束：只有共享带宽支持95peak_plus（按增强型95计费），按增强型95计费时需要指定保底百分比，默认是20%。
        /// </summary>
        /// <value>功能说明：按流量计费,按带宽计费还是按增强型95计费。  取值范围：bandwidth，traffic，95peak_plus(按增强型95计费)不返回或者为空时表示是bandwidth。  约束：只有共享带宽支持95peak_plus（按增强型95计费），按增强型95计费时需要指定保底百分比，默认是20%。</value>
        [JsonConverter(typeof(EnumClassConverter<ChargeModeEnum>))]
        public class ChargeModeEnum
        {
            /// <summary>
            /// Enum BANDWIDTH for value: bandwidth
            /// </summary>
            public static readonly ChargeModeEnum BANDWIDTH = new ChargeModeEnum("bandwidth");

            /// <summary>
            /// Enum TRAFFIC for value: traffic
            /// </summary>
            public static readonly ChargeModeEnum TRAFFIC = new ChargeModeEnum("traffic");

            /// <summary>
            /// Enum _95PEAK_PLUS for value: 95peak_plus
            /// </summary>
            public static readonly ChargeModeEnum _95PEAK_PLUS = new ChargeModeEnum("95peak_plus");

            private static readonly Dictionary<string, ChargeModeEnum> StaticFields =
            new Dictionary<string, ChargeModeEnum>()
            {
                { "bandwidth", BANDWIDTH },
                { "traffic", TRAFFIC },
                { "95peak_plus", _95PEAK_PLUS },
            };

            private string Value;

            public ChargeModeEnum(string value)
            {
                Value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
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
        /// 功能说明：带宽类型，标识是否是共享带宽  取值范围：WHOLE，PER  WHOLE表示共享带宽；PER，表示独享带宽
        /// </summary>
        /// <value>功能说明：带宽类型，标识是否是共享带宽  取值范围：WHOLE，PER  WHOLE表示共享带宽；PER，表示独享带宽</value>
        [JsonConverter(typeof(EnumClassConverter<ShareTypeEnum>))]
        public class ShareTypeEnum
        {
            /// <summary>
            /// Enum WHOLE for value: WHOLE
            /// </summary>
            public static readonly ShareTypeEnum WHOLE = new ShareTypeEnum("WHOLE");

            /// <summary>
            /// Enum PER for value: PER
            /// </summary>
            public static readonly ShareTypeEnum PER = new ShareTypeEnum("PER");

            private static readonly Dictionary<string, ShareTypeEnum> StaticFields =
            new Dictionary<string, ShareTypeEnum>()
            {
                { "WHOLE", WHOLE },
                { "PER", PER },
            };

            private string Value;

            public ShareTypeEnum(string value)
            {
                Value = value;
            }

            public static ShareTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ShareTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ShareTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(ShareTypeEnum a, ShareTypeEnum b)
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

            public static bool operator !=(ShareTypeEnum a, ShareTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 功能说明：带宽的状态  取值范围：  FREEZED：冻结  NORMAL：正常
        /// </summary>
        /// <value>功能说明：带宽的状态  取值范围：  FREEZED：冻结  NORMAL：正常</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum FREEZED for value: FREEZED
            /// </summary>
            public static readonly StatusEnum FREEZED = new StatusEnum("FREEZED");

            /// <summary>
            /// Enum NORMAL for value: NORMAL
            /// </summary>
            public static readonly StatusEnum NORMAL = new StatusEnum("NORMAL");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "FREEZED", FREEZED },
                { "NORMAL", NORMAL },
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
        /// 功能说明：带宽类型，共享带宽默认为share。  取值范围：share，bgp，telcom，sbgp等。  share：共享带宽  bgp：动态bgp  telcom ：联通  sbgp：静态bgp
        /// </summary>
        [JsonProperty("bandwidth_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BandwidthType { get; set; }

        /// <summary>
        /// 功能说明：账单信息  如果billing_info不为空，说明是包周期的带宽
        /// </summary>
        [JsonProperty("billing_info", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingInfo { get; set; }

        /// <summary>
        /// 功能说明：按流量计费,按带宽计费还是按增强型95计费。  取值范围：bandwidth，traffic，95peak_plus(按增强型95计费)不返回或者为空时表示是bandwidth。  约束：只有共享带宽支持95peak_plus（按增强型95计费），按增强型95计费时需要指定保底百分比，默认是20%。
        /// </summary>
        [JsonProperty("charge_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ChargeModeEnum ChargeMode { get; set; }
        /// <summary>
        /// 功能说明：带宽唯一标识
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 功能说明：带宽名称  取值范围：1-64个字符，支持数字、字母、中文、_(下划线)、-（中划线）、.（点）
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 功能说明：带宽对应的弹性公网IP信息  约束：WHOLE类型的带宽支持多个弹性公网IP，PER类型的带宽只能对应一个弹性公网IP
        /// </summary>
        [JsonProperty("publicip_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<PublicipInfoResp> PublicipInfo { get; set; }

        /// <summary>
        /// 功能说明：带宽类型，标识是否是共享带宽  取值范围：WHOLE，PER  WHOLE表示共享带宽；PER，表示独享带宽
        /// </summary>
        [JsonProperty("share_type", NullValueHandling = NullValueHandling.Ignore)]
        public ShareTypeEnum ShareType { get; set; }
        /// <summary>
        /// 功能说明：带宽大小  取值范围：默认5Mbit/s~2000Mbit/s（具体范围以各区域配置为准，请参见控制台对应页面显示）。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// 功能说明：用户所属租户ID
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// 功能说明：带宽的状态  取值范围：  FREEZED：冻结  NORMAL：正常
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 功能说明：表示中心站点资源或者边缘站点资源 取值范围： center、边缘站点名称 约束：共享带宽只能插入与该字段相同的publicip
        /// </summary>
        [JsonProperty("public_border_group", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicBorderGroup { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchBandwidthResp {\n");
            sb.Append("  bandwidthType: ").Append(BandwidthType).Append("\n");
            sb.Append("  billingInfo: ").Append(BillingInfo).Append("\n");
            sb.Append("  chargeMode: ").Append(ChargeMode).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  publicipInfo: ").Append(PublicipInfo).Append("\n");
            sb.Append("  shareType: ").Append(ShareType).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  publicBorderGroup: ").Append(PublicBorderGroup).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchBandwidthResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchBandwidthResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BandwidthType == input.BandwidthType ||
                    (this.BandwidthType != null &&
                    this.BandwidthType.Equals(input.BandwidthType))
                ) && 
                (
                    this.BillingInfo == input.BillingInfo ||
                    (this.BillingInfo != null &&
                    this.BillingInfo.Equals(input.BillingInfo))
                ) && 
                (
                    this.ChargeMode == input.ChargeMode ||
                    (this.ChargeMode != null &&
                    this.ChargeMode.Equals(input.ChargeMode))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PublicipInfo == input.PublicipInfo ||
                    this.PublicipInfo != null &&
                    input.PublicipInfo != null &&
                    this.PublicipInfo.SequenceEqual(input.PublicipInfo)
                ) && 
                (
                    this.ShareType == input.ShareType ||
                    (this.ShareType != null &&
                    this.ShareType.Equals(input.ShareType))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.PublicBorderGroup == input.PublicBorderGroup ||
                    (this.PublicBorderGroup != null &&
                    this.PublicBorderGroup.Equals(input.PublicBorderGroup))
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
                if (this.BandwidthType != null)
                    hashCode = hashCode * 59 + this.BandwidthType.GetHashCode();
                if (this.BillingInfo != null)
                    hashCode = hashCode * 59 + this.BillingInfo.GetHashCode();
                if (this.ChargeMode != null)
                    hashCode = hashCode * 59 + this.ChargeMode.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PublicipInfo != null)
                    hashCode = hashCode * 59 + this.PublicipInfo.GetHashCode();
                if (this.ShareType != null)
                    hashCode = hashCode * 59 + this.ShareType.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.PublicBorderGroup != null)
                    hashCode = hashCode * 59 + this.PublicBorderGroup.GetHashCode();
                return hashCode;
            }
        }
    }
}
