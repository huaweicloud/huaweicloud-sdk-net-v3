using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aad.V1.Model
{
    /// <summary>
    /// 包列表响应体
    /// </summary>
    public class PackageResponse 
    {
        /// <summary>
        /// 实例类型。cnad_pro：专业版；cnad_ip：标准版；cnad_ep：铂金版；cnad_full_high：全力防高级版；cnad_vic：按需版；cnad_intl_ep：国际站铂金版
        /// </summary>
        /// <value>实例类型。cnad_pro：专业版；cnad_ip：标准版；cnad_ep：铂金版；cnad_full_high：全力防高级版；cnad_vic：按需版；cnad_intl_ep：国际站铂金版</value>
        [JsonConverter(typeof(EnumClassConverter<InstanceTypeEnum>))]
        public class InstanceTypeEnum
        {
            /// <summary>
            /// Enum CNAD_PRO for value: cnad_pro
            /// </summary>
            public static readonly InstanceTypeEnum CNAD_PRO = new InstanceTypeEnum("cnad_pro");

            /// <summary>
            /// Enum CNAD_IP for value: cnad_ip
            /// </summary>
            public static readonly InstanceTypeEnum CNAD_IP = new InstanceTypeEnum("cnad_ip");

            /// <summary>
            /// Enum CNAD_EP for value: cnad_ep
            /// </summary>
            public static readonly InstanceTypeEnum CNAD_EP = new InstanceTypeEnum("cnad_ep");

            /// <summary>
            /// Enum CNAD_FULL_HIGH for value: cnad_full_high
            /// </summary>
            public static readonly InstanceTypeEnum CNAD_FULL_HIGH = new InstanceTypeEnum("cnad_full_high");

            /// <summary>
            /// Enum CNAD_VIC for value: cnad_vic
            /// </summary>
            public static readonly InstanceTypeEnum CNAD_VIC = new InstanceTypeEnum("cnad_vic");

            /// <summary>
            /// Enum CNAD_INTL_EP for value: cnad_intl_ep
            /// </summary>
            public static readonly InstanceTypeEnum CNAD_INTL_EP = new InstanceTypeEnum("cnad_intl_ep");

            private static readonly Dictionary<string, InstanceTypeEnum> StaticFields =
            new Dictionary<string, InstanceTypeEnum>()
            {
                { "cnad_pro", CNAD_PRO },
                { "cnad_ip", CNAD_IP },
                { "cnad_ep", CNAD_EP },
                { "cnad_full_high", CNAD_FULL_HIGH },
                { "cnad_vic", CNAD_VIC },
                { "cnad_intl_ep", CNAD_INTL_EP },
            };

            private string _value;

            public InstanceTypeEnum()
            {

            }

            public InstanceTypeEnum(string value)
            {
                _value = value;
            }

            public static InstanceTypeEnum FromValue(string value)
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

                if (this.Equals(obj as InstanceTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(InstanceTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(InstanceTypeEnum a, InstanceTypeEnum b)
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

            public static bool operator !=(InstanceTypeEnum a, InstanceTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 实例id
        /// </summary>
        [JsonProperty("package_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PackageId { get; set; }

        /// <summary>
        /// 实例名
        /// </summary>
        [JsonProperty("package_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PackageName { get; set; }

        /// <summary>
        /// 资源所属region
        /// </summary>
        [JsonProperty("region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionId { get; set; }

        /// <summary>
        /// 防护类型
        /// </summary>
        [JsonProperty("protection_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProtectionType { get; set; }

        /// <summary>
        /// 实例类型。cnad_pro：专业版；cnad_ip：标准版；cnad_ep：铂金版；cnad_full_high：全力防高级版；cnad_vic：按需版；cnad_intl_ep：国际站铂金版
        /// </summary>
        [JsonProperty("instance_type", NullValueHandling = NullValueHandling.Ignore)]
        public InstanceTypeEnum InstanceType { get; set; }
        /// <summary>
        /// 资源id
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 倒计时相关信息
        /// </summary>
        [JsonProperty("count_down_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CountDownCode { get; set; }

        /// <summary>
        /// 倒计时相关信息
        /// </summary>
        [JsonProperty("count_down_infos", NullValueHandling = NullValueHandling.Ignore)]
        public string CountDownInfos { get; set; }

        /// <summary>
        /// 倒计时相关信息
        /// </summary>
        [JsonProperty("count_down_tips", NullValueHandling = NullValueHandling.Ignore)]
        public string CountDownTips { get; set; }

        /// <summary>
        /// 订单id
        /// </summary>
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        /// <summary>
        /// 续费用的id
        /// </summary>
        [JsonProperty("subscription_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// ip数
        /// </summary>
        [JsonProperty("ip_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? IpNum { get; set; }

        /// <summary>
        /// 当前IP数
        /// </summary>
        [JsonProperty("ip_num_now", NullValueHandling = NullValueHandling.Ignore)]
        public int? IpNumNow { get; set; }

        /// <summary>
        /// 当前防护次数
        /// </summary>
        [JsonProperty("protection_num_now", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProtectionNumNow { get; set; }

        /// <summary>
        /// 防护次数，9999为无限次
        /// </summary>
        [JsonProperty("protection_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProtectionNum { get; set; }

        /// <summary>
        /// 保底带宽
        /// </summary>
        [JsonProperty("basic_bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? BasicBandwidth { get; set; }

        /// <summary>
        /// 弹性带宽
        /// </summary>
        [JsonProperty("elastic_bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? ElasticBandwidth { get; set; }

        /// <summary>
        /// 业务带宽
        /// </summary>
        [JsonProperty("service_bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? ServiceBandwidth { get; set; }

        /// <summary>
        /// 回源带宽
        /// </summary>
        [JsonProperty("clean_bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? CleanBandwidth { get; set; }

        /// <summary>
        /// 策略模板数
        /// </summary>
        [JsonProperty("policy_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? PolicyNum { get; set; }

        /// <summary>
        /// 是否旧实例（旧实例不支持升级规格）,默认不传为否
        /// </summary>
        [JsonProperty("is_old", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsOld { get; set; }

        /// <summary>
        /// 专业版铂金版合并之后购买的专业版和铂金版均标识为true
        /// </summary>
        [JsonProperty("new_flag", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NewFlag { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PackageResponse {\n");
            sb.Append("  packageId: ").Append(PackageId).Append("\n");
            sb.Append("  packageName: ").Append(PackageName).Append("\n");
            sb.Append("  regionId: ").Append(RegionId).Append("\n");
            sb.Append("  protectionType: ").Append(ProtectionType).Append("\n");
            sb.Append("  instanceType: ").Append(InstanceType).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  countDownCode: ").Append(CountDownCode).Append("\n");
            sb.Append("  countDownInfos: ").Append(CountDownInfos).Append("\n");
            sb.Append("  countDownTips: ").Append(CountDownTips).Append("\n");
            sb.Append("  orderId: ").Append(OrderId).Append("\n");
            sb.Append("  subscriptionId: ").Append(SubscriptionId).Append("\n");
            sb.Append("  ipNum: ").Append(IpNum).Append("\n");
            sb.Append("  ipNumNow: ").Append(IpNumNow).Append("\n");
            sb.Append("  protectionNumNow: ").Append(ProtectionNumNow).Append("\n");
            sb.Append("  protectionNum: ").Append(ProtectionNum).Append("\n");
            sb.Append("  basicBandwidth: ").Append(BasicBandwidth).Append("\n");
            sb.Append("  elasticBandwidth: ").Append(ElasticBandwidth).Append("\n");
            sb.Append("  serviceBandwidth: ").Append(ServiceBandwidth).Append("\n");
            sb.Append("  cleanBandwidth: ").Append(CleanBandwidth).Append("\n");
            sb.Append("  policyNum: ").Append(PolicyNum).Append("\n");
            sb.Append("  isOld: ").Append(IsOld).Append("\n");
            sb.Append("  newFlag: ").Append(NewFlag).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PackageResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PackageResponse input)
        {
            if (input == null) return false;
            if (this.PackageId != input.PackageId || (this.PackageId != null && !this.PackageId.Equals(input.PackageId))) return false;
            if (this.PackageName != input.PackageName || (this.PackageName != null && !this.PackageName.Equals(input.PackageName))) return false;
            if (this.RegionId != input.RegionId || (this.RegionId != null && !this.RegionId.Equals(input.RegionId))) return false;
            if (this.ProtectionType != input.ProtectionType || (this.ProtectionType != null && !this.ProtectionType.Equals(input.ProtectionType))) return false;
            if (this.InstanceType != input.InstanceType) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.CountDownCode != input.CountDownCode || (this.CountDownCode != null && !this.CountDownCode.Equals(input.CountDownCode))) return false;
            if (this.CountDownInfos != input.CountDownInfos || (this.CountDownInfos != null && !this.CountDownInfos.Equals(input.CountDownInfos))) return false;
            if (this.CountDownTips != input.CountDownTips || (this.CountDownTips != null && !this.CountDownTips.Equals(input.CountDownTips))) return false;
            if (this.OrderId != input.OrderId || (this.OrderId != null && !this.OrderId.Equals(input.OrderId))) return false;
            if (this.SubscriptionId != input.SubscriptionId || (this.SubscriptionId != null && !this.SubscriptionId.Equals(input.SubscriptionId))) return false;
            if (this.IpNum != input.IpNum || (this.IpNum != null && !this.IpNum.Equals(input.IpNum))) return false;
            if (this.IpNumNow != input.IpNumNow || (this.IpNumNow != null && !this.IpNumNow.Equals(input.IpNumNow))) return false;
            if (this.ProtectionNumNow != input.ProtectionNumNow || (this.ProtectionNumNow != null && !this.ProtectionNumNow.Equals(input.ProtectionNumNow))) return false;
            if (this.ProtectionNum != input.ProtectionNum || (this.ProtectionNum != null && !this.ProtectionNum.Equals(input.ProtectionNum))) return false;
            if (this.BasicBandwidth != input.BasicBandwidth || (this.BasicBandwidth != null && !this.BasicBandwidth.Equals(input.BasicBandwidth))) return false;
            if (this.ElasticBandwidth != input.ElasticBandwidth || (this.ElasticBandwidth != null && !this.ElasticBandwidth.Equals(input.ElasticBandwidth))) return false;
            if (this.ServiceBandwidth != input.ServiceBandwidth || (this.ServiceBandwidth != null && !this.ServiceBandwidth.Equals(input.ServiceBandwidth))) return false;
            if (this.CleanBandwidth != input.CleanBandwidth || (this.CleanBandwidth != null && !this.CleanBandwidth.Equals(input.CleanBandwidth))) return false;
            if (this.PolicyNum != input.PolicyNum || (this.PolicyNum != null && !this.PolicyNum.Equals(input.PolicyNum))) return false;
            if (this.IsOld != input.IsOld || (this.IsOld != null && !this.IsOld.Equals(input.IsOld))) return false;
            if (this.NewFlag != input.NewFlag || (this.NewFlag != null && !this.NewFlag.Equals(input.NewFlag))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;

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
                if (this.PackageId != null) hashCode = hashCode * 59 + this.PackageId.GetHashCode();
                if (this.PackageName != null) hashCode = hashCode * 59 + this.PackageName.GetHashCode();
                if (this.RegionId != null) hashCode = hashCode * 59 + this.RegionId.GetHashCode();
                if (this.ProtectionType != null) hashCode = hashCode * 59 + this.ProtectionType.GetHashCode();
                hashCode = hashCode * 59 + this.InstanceType.GetHashCode();
                if (this.ResourceId != null) hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.CountDownCode != null) hashCode = hashCode * 59 + this.CountDownCode.GetHashCode();
                if (this.CountDownInfos != null) hashCode = hashCode * 59 + this.CountDownInfos.GetHashCode();
                if (this.CountDownTips != null) hashCode = hashCode * 59 + this.CountDownTips.GetHashCode();
                if (this.OrderId != null) hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.SubscriptionId != null) hashCode = hashCode * 59 + this.SubscriptionId.GetHashCode();
                if (this.IpNum != null) hashCode = hashCode * 59 + this.IpNum.GetHashCode();
                if (this.IpNumNow != null) hashCode = hashCode * 59 + this.IpNumNow.GetHashCode();
                if (this.ProtectionNumNow != null) hashCode = hashCode * 59 + this.ProtectionNumNow.GetHashCode();
                if (this.ProtectionNum != null) hashCode = hashCode * 59 + this.ProtectionNum.GetHashCode();
                if (this.BasicBandwidth != null) hashCode = hashCode * 59 + this.BasicBandwidth.GetHashCode();
                if (this.ElasticBandwidth != null) hashCode = hashCode * 59 + this.ElasticBandwidth.GetHashCode();
                if (this.ServiceBandwidth != null) hashCode = hashCode * 59 + this.ServiceBandwidth.GetHashCode();
                if (this.CleanBandwidth != null) hashCode = hashCode * 59 + this.CleanBandwidth.GetHashCode();
                if (this.PolicyNum != null) hashCode = hashCode * 59 + this.PolicyNum.GetHashCode();
                if (this.IsOld != null) hashCode = hashCode * 59 + this.IsOld.GetHashCode();
                if (this.NewFlag != null) hashCode = hashCode * 59 + this.NewFlag.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
