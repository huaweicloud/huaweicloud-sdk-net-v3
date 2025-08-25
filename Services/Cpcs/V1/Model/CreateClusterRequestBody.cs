using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cpcs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateClusterRequestBody 
    {
        /// <summary>
        /// 计费模式  - 0：包年/包月。
        /// </summary>
        /// <value>计费模式  - 0：包年/包月。</value>
        [JsonConverter(typeof(EnumClassConverter<ChargingModeEnum>))]
        public class ChargingModeEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly ChargingModeEnum NUMBER_0 = new ChargingModeEnum(0);

            private static readonly Dictionary<int?, ChargingModeEnum> StaticFields =
            new Dictionary<int?, ChargingModeEnum>()
            {
                { 0, NUMBER_0 },
            };

            private int? _value;

            public ChargingModeEnum()
            {

            }

            public ChargingModeEnum(int? value)
            {
                _value = value;
            }

            public static ChargingModeEnum FromValue(int? value)
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

                if (this.Equals(obj as ChargingModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ChargingModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ChargingModeEnum a, ChargingModeEnum b)
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

            public static bool operator !=(ChargingModeEnum a, ChargingModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 周期类型  - 2：月。  - 3：年。
        /// </summary>
        /// <value>周期类型  - 2：月。  - 3：年。</value>
        [JsonConverter(typeof(EnumClassConverter<PeriodTypeEnum>))]
        public class PeriodTypeEnum
        {
            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            public static readonly PeriodTypeEnum NUMBER_2 = new PeriodTypeEnum(2);

            /// <summary>
            /// Enum NUMBER_3 for value: 3
            /// </summary>
            public static readonly PeriodTypeEnum NUMBER_3 = new PeriodTypeEnum(3);

            private static readonly Dictionary<int?, PeriodTypeEnum> StaticFields =
            new Dictionary<int?, PeriodTypeEnum>()
            {
                { 2, NUMBER_2 },
                { 3, NUMBER_3 },
            };

            private int? _value;

            public PeriodTypeEnum()
            {

            }

            public PeriodTypeEnum(int? value)
            {
                _value = value;
            }

            public static PeriodTypeEnum FromValue(int? value)
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

                if (this.Equals(obj as PeriodTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PeriodTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PeriodTypeEnum a, PeriodTypeEnum b)
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

            public static bool operator !=(PeriodTypeEnum a, PeriodTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 共享类型  - EXCLUSIVE：应用独享。  - SHARED：应用共享。
        /// </summary>
        /// <value>共享类型  - EXCLUSIVE：应用独享。  - SHARED：应用共享。</value>
        [JsonConverter(typeof(EnumClassConverter<ShareTypeEnum>))]
        public class ShareTypeEnum
        {
            /// <summary>
            /// Enum EXCLUSIVE for value: EXCLUSIVE
            /// </summary>
            public static readonly ShareTypeEnum EXCLUSIVE = new ShareTypeEnum("EXCLUSIVE");

            /// <summary>
            /// Enum SHARED for value: SHARED
            /// </summary>
            public static readonly ShareTypeEnum SHARED = new ShareTypeEnum("SHARED");

            private static readonly Dictionary<string, ShareTypeEnum> StaticFields =
            new Dictionary<string, ShareTypeEnum>()
            {
                { "EXCLUSIVE", EXCLUSIVE },
                { "SHARED", SHARED },
            };

            private string _value;

            public ShareTypeEnum()
            {

            }

            public ShareTypeEnum(string value)
            {
                _value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
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
        /// 实例类型  - SINGLE：单机。  - STANDBY：主备。
        /// </summary>
        /// <value>实例类型  - SINGLE：单机。  - STANDBY：主备。</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum SINGLE for value: SINGLE
            /// </summary>
            public static readonly TypeEnum SINGLE = new TypeEnum("SINGLE");

            /// <summary>
            /// Enum STANDBY for value: STANDBY
            /// </summary>
            public static readonly TypeEnum STANDBY = new TypeEnum("STANDBY");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "SINGLE", SINGLE },
                { "STANDBY", STANDBY },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 计费模式  - 0：包年/包月。
        /// </summary>
        [JsonProperty("charging_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ChargingModeEnum ChargingMode { get; set; }
        /// <summary>
        /// 局点ID
        /// </summary>
        [JsonProperty("region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionId { get; set; }

        /// <summary>
        /// 周期类型  - 2：月。  - 3：年。
        /// </summary>
        [JsonProperty("period_type", NullValueHandling = NullValueHandling.Ignore)]
        public PeriodTypeEnum PeriodType { get; set; }
        /// <summary>
        /// 周期数量
        /// </summary>
        [JsonProperty("period_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodNum { get; set; }

        /// <summary>
        /// 实例数量
        /// </summary>
        [JsonProperty("subscription_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubscriptionNum { get; set; }

        /// <summary>
        /// 产品id
        /// </summary>
        [JsonProperty("period_product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PeriodProductId { get; set; }

        /// <summary>
        /// 产品规格code
        /// </summary>
        [JsonProperty("period_resource_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string PeriodResourceSpecCode { get; set; }

        /// <summary>
        /// 集群名称
        /// </summary>
        [JsonProperty("cluster_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterName { get; set; }

        /// <summary>
        /// 服务类型  - ENCRYPT_DECRYPT：加解密服务。  - SIGN_VERIFY：签名验签服务。  - KMS：密钥管理服务。  - TIMESTAMP：时间戳服务。  - COLLA_SIGN：协同签名服务。  - OTP：动态令牌服务。  - DB_ENCRYPT：数据库加密服务。  - FILE_ENCRYPT：文件加密服务。  - DIGIT_SEAL：电子签章服务。  - SSL_VPN：SSL_VPN服务。  - IAS：身份认证服务。
        /// </summary>
        [JsonProperty("service_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceType { get; set; }

        /// <summary>
        /// 共享类型  - EXCLUSIVE：应用独享。  - SHARED：应用共享。
        /// </summary>
        [JsonProperty("share_type", NullValueHandling = NullValueHandling.Ignore)]
        public ShareTypeEnum ShareType { get; set; }
        /// <summary>
        /// 镜像id
        /// </summary>
        [JsonProperty("image_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageId { get; set; }

        /// <summary>
        /// 是否自动续费
        /// </summary>
        [JsonProperty("is_auto_renew", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsAutoRenew { get; set; }

        /// <summary>
        /// 折扣
        /// </summary>
        [JsonProperty("promotion_info", NullValueHandling = NullValueHandling.Ignore)]
        public string PromotionInfo { get; set; }

        /// <summary>
        /// 应用id
        /// </summary>
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// 企业项目id
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 实例类型  - SINGLE：单机。  - STANDBY：主备。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// az
        /// </summary>
        [JsonProperty("az", NullValueHandling = NullValueHandling.Ignore)]
        public string Az { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateClusterRequestBody {\n");
            sb.Append("  chargingMode: ").Append(ChargingMode).Append("\n");
            sb.Append("  regionId: ").Append(RegionId).Append("\n");
            sb.Append("  periodType: ").Append(PeriodType).Append("\n");
            sb.Append("  periodNum: ").Append(PeriodNum).Append("\n");
            sb.Append("  subscriptionNum: ").Append(SubscriptionNum).Append("\n");
            sb.Append("  periodProductId: ").Append(PeriodProductId).Append("\n");
            sb.Append("  periodResourceSpecCode: ").Append(PeriodResourceSpecCode).Append("\n");
            sb.Append("  clusterName: ").Append(ClusterName).Append("\n");
            sb.Append("  serviceType: ").Append(ServiceType).Append("\n");
            sb.Append("  shareType: ").Append(ShareType).Append("\n");
            sb.Append("  imageId: ").Append(ImageId).Append("\n");
            sb.Append("  isAutoRenew: ").Append(IsAutoRenew).Append("\n");
            sb.Append("  promotionInfo: ").Append(PromotionInfo).Append("\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  az: ").Append(Az).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateClusterRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateClusterRequestBody input)
        {
            if (input == null) return false;
            if (this.ChargingMode != input.ChargingMode) return false;
            if (this.RegionId != input.RegionId || (this.RegionId != null && !this.RegionId.Equals(input.RegionId))) return false;
            if (this.PeriodType != input.PeriodType) return false;
            if (this.PeriodNum != input.PeriodNum || (this.PeriodNum != null && !this.PeriodNum.Equals(input.PeriodNum))) return false;
            if (this.SubscriptionNum != input.SubscriptionNum || (this.SubscriptionNum != null && !this.SubscriptionNum.Equals(input.SubscriptionNum))) return false;
            if (this.PeriodProductId != input.PeriodProductId || (this.PeriodProductId != null && !this.PeriodProductId.Equals(input.PeriodProductId))) return false;
            if (this.PeriodResourceSpecCode != input.PeriodResourceSpecCode || (this.PeriodResourceSpecCode != null && !this.PeriodResourceSpecCode.Equals(input.PeriodResourceSpecCode))) return false;
            if (this.ClusterName != input.ClusterName || (this.ClusterName != null && !this.ClusterName.Equals(input.ClusterName))) return false;
            if (this.ServiceType != input.ServiceType || (this.ServiceType != null && !this.ServiceType.Equals(input.ServiceType))) return false;
            if (this.ShareType != input.ShareType) return false;
            if (this.ImageId != input.ImageId || (this.ImageId != null && !this.ImageId.Equals(input.ImageId))) return false;
            if (this.IsAutoRenew != input.IsAutoRenew || (this.IsAutoRenew != null && !this.IsAutoRenew.Equals(input.IsAutoRenew))) return false;
            if (this.PromotionInfo != input.PromotionInfo || (this.PromotionInfo != null && !this.PromotionInfo.Equals(input.PromotionInfo))) return false;
            if (this.AppId != input.AppId || (this.AppId != null && !this.AppId.Equals(input.AppId))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.Type != input.Type) return false;
            if (this.Az != input.Az || (this.Az != null && !this.Az.Equals(input.Az))) return false;

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
                hashCode = hashCode * 59 + this.ChargingMode.GetHashCode();
                if (this.RegionId != null) hashCode = hashCode * 59 + this.RegionId.GetHashCode();
                hashCode = hashCode * 59 + this.PeriodType.GetHashCode();
                if (this.PeriodNum != null) hashCode = hashCode * 59 + this.PeriodNum.GetHashCode();
                if (this.SubscriptionNum != null) hashCode = hashCode * 59 + this.SubscriptionNum.GetHashCode();
                if (this.PeriodProductId != null) hashCode = hashCode * 59 + this.PeriodProductId.GetHashCode();
                if (this.PeriodResourceSpecCode != null) hashCode = hashCode * 59 + this.PeriodResourceSpecCode.GetHashCode();
                if (this.ClusterName != null) hashCode = hashCode * 59 + this.ClusterName.GetHashCode();
                if (this.ServiceType != null) hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                hashCode = hashCode * 59 + this.ShareType.GetHashCode();
                if (this.ImageId != null) hashCode = hashCode * 59 + this.ImageId.GetHashCode();
                if (this.IsAutoRenew != null) hashCode = hashCode * 59 + this.IsAutoRenew.GetHashCode();
                if (this.PromotionInfo != null) hashCode = hashCode * 59 + this.PromotionInfo.GetHashCode();
                if (this.AppId != null) hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Az != null) hashCode = hashCode * 59 + this.Az.GetHashCode();
                return hashCode;
            }
        }
    }
}
