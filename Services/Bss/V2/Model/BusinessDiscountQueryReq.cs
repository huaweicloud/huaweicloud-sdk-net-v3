using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bss.V2.Model
{
    /// <summary>
    /// 查询商务折扣信息请求体
    /// </summary>
    public class BusinessDiscountQueryReq 
    {
        /// <summary>
        /// 报价项类型，必填，PRODUCT_ITEM（产品报价项）/ CATEGORY_ITEM（分类报价项）
        /// </summary>
        /// <value>报价项类型，必填，PRODUCT_ITEM（产品报价项）/ CATEGORY_ITEM（分类报价项）</value>
        [JsonConverter(typeof(EnumClassConverter<QuotingItemTypeEnum>))]
        public class QuotingItemTypeEnum
        {
            /// <summary>
            /// Enum PRODUCT_ITEM for value: PRODUCT_ITEM
            /// </summary>
            public static readonly QuotingItemTypeEnum PRODUCT_ITEM = new QuotingItemTypeEnum("PRODUCT_ITEM");

            /// <summary>
            /// Enum CATEGORY_ITEM for value: CATEGORY_ITEM
            /// </summary>
            public static readonly QuotingItemTypeEnum CATEGORY_ITEM = new QuotingItemTypeEnum("CATEGORY_ITEM");

            private static readonly Dictionary<string, QuotingItemTypeEnum> StaticFields =
            new Dictionary<string, QuotingItemTypeEnum>()
            {
                { "PRODUCT_ITEM", PRODUCT_ITEM },
                { "CATEGORY_ITEM", CATEGORY_ITEM },
            };

            private string _value;

            public QuotingItemTypeEnum()
            {

            }

            public QuotingItemTypeEnum(string value)
            {
                _value = value;
            }

            public static QuotingItemTypeEnum FromValue(string value)
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

                if (this.Equals(obj as QuotingItemTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(QuotingItemTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(QuotingItemTypeEnum a, QuotingItemTypeEnum b)
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

            public static bool operator !=(QuotingItemTypeEnum a, QuotingItemTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 报价项类型，必填，PRODUCT_ITEM（产品报价项）/ CATEGORY_ITEM（分类报价项）
        /// </summary>
        [JsonProperty("quoting_item_type", NullValueHandling = NullValueHandling.Ignore)]
        public QuotingItemTypeEnum QuotingItemType { get; set; }
        /// <summary>
        /// 云服务类型编码列表，非必填，大小写不敏感，数组范围限制:0-100，字符长度限制1-64。此参数不携带或携带值为空列表或携带值为null时，不作为筛选条件。
        /// </summary>
        [JsonProperty("cloud_service_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CloudServiceTypes { get; set; }

        /// <summary>
        /// 计费模式列表，非必填，大小写不敏感，数组范围限制:0-20，字符长度限制1-64。此参数不携带或携带值为空列表或携带值为null时，不作为筛选条件。
        /// </summary>
        [JsonProperty("charging_modes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ChargingModes { get; set; }

        /// <summary>
        /// 运营站点编码，非必填，大小写不敏感，字符长度限制1-64。此参数不携带或携带值为null时，不作为筛选条件。
        /// </summary>
        [JsonProperty("site_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SiteCode { get; set; }

        /// <summary>
        /// 分页偏移量，非必填，取值范围0-2147483647，默认值0
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 查询条数，非必填，取值范围1-1000，默认值20
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessDiscountQueryReq {\n");
            sb.Append("  quotingItemType: ").Append(QuotingItemType).Append("\n");
            sb.Append("  cloudServiceTypes: ").Append(CloudServiceTypes).Append("\n");
            sb.Append("  chargingModes: ").Append(ChargingModes).Append("\n");
            sb.Append("  siteCode: ").Append(SiteCode).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BusinessDiscountQueryReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BusinessDiscountQueryReq input)
        {
            if (input == null) return false;
            if (this.QuotingItemType != input.QuotingItemType) return false;
            if (this.CloudServiceTypes != input.CloudServiceTypes || (this.CloudServiceTypes != null && input.CloudServiceTypes != null && !this.CloudServiceTypes.SequenceEqual(input.CloudServiceTypes))) return false;
            if (this.ChargingModes != input.ChargingModes || (this.ChargingModes != null && input.ChargingModes != null && !this.ChargingModes.SequenceEqual(input.ChargingModes))) return false;
            if (this.SiteCode != input.SiteCode || (this.SiteCode != null && !this.SiteCode.Equals(input.SiteCode))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;

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
                hashCode = hashCode * 59 + this.QuotingItemType.GetHashCode();
                if (this.CloudServiceTypes != null) hashCode = hashCode * 59 + this.CloudServiceTypes.GetHashCode();
                if (this.ChargingModes != null) hashCode = hashCode * 59 + this.ChargingModes.GetHashCode();
                if (this.SiteCode != null) hashCode = hashCode * 59 + this.SiteCode.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
