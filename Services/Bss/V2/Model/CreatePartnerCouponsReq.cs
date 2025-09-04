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
    /// 
    /// </summary>
    public class CreatePartnerCouponsReq 
    {

        /// <summary>
        /// 优惠券额度ID。该值在查询优惠券额度接口的响应参数中获取。
        /// </summary>
        [JsonProperty("quota_id", NullValueHandling = NullValueHandling.Ignore)]
        public string QuotaId { get; set; }

        /// <summary>
        /// 客户账号ID。您可以调用[查询客户列表](https://support.huaweicloud.com/api-bpconsole/mc_00021.html)接口获取customer_id。
        /// </summary>
        [JsonProperty("customer_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CustomerIds { get; set; }

        /// <summary>
        /// 代金券面值。 单位：元。取值大于0且精确到小数点后2位。
        /// </summary>
        [JsonProperty("face_value", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FaceValue { get; set; }

        /// <summary>
        /// 生效时间。 UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，如“2019-05-06T08:05:01Z”。 此参数不携带或携带值为null时，赋值为发放优惠券额度的生效时间。
        /// </summary>
        [JsonProperty("valid_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ValidTime { get; set; }

        /// <summary>
        /// 失效时间。 UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，如“2019-05-06T08:05:01Z”。 此参数不携带或携带值为null时，赋值为发放优惠券额度的失效时间。
        /// </summary>
        [JsonProperty("expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 允许使用的云服务列表，您可以调用查询云服务类型列表接口获取。 多个云服务产品以“,”隔开，最多支持10个。 默认：空（继承额度上的限制）  说明： 如果额度上有限制云服务类型列表，则优惠券上的限制不能超过额度的限制。如果额度上没有限制，则优惠券上可以随意指定云服务类型。
        /// </summary>
        [JsonProperty("cloud_service_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CloudServiceTypes { get; set; }

        /// <summary>
        /// 允许使用的产品列表。 多个产品以“,”隔开，最多支持10个。 默认：空（继承额度上的限制）  说明： 如果额度上有限制产品列表，则优惠券上的限制不能超过额度的限制。如果额度上没有限制，则优惠券上可以随意指定产品ID。 产品ID需要合作伙伴通过线下获得。
        /// </summary>
        [JsonProperty("product_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ProductIds { get; set; }

        /// <summary>
        /// 发券时的备注信息。 此参数不携带或携带值为null时，不赋值；携带值为空串时，赋值空串。
        /// </summary>
        [JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        /// 云经销商ID。获取方法请参见[查询云经销商列表](https://support.huaweicloud.com/api-bpconsole/espp_00003.html)。云经销商给子客户发放优惠券时，需要携带该参数。除此之外，此参数不做处理。
        /// </summary>
        [JsonProperty("indirect_partner_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IndirectPartnerId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePartnerCouponsReq {\n");
            sb.Append("  quotaId: ").Append(QuotaId).Append("\n");
            sb.Append("  customerIds: ").Append(CustomerIds).Append("\n");
            sb.Append("  faceValue: ").Append(FaceValue).Append("\n");
            sb.Append("  validTime: ").Append(ValidTime).Append("\n");
            sb.Append("  expireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("  cloudServiceTypes: ").Append(CloudServiceTypes).Append("\n");
            sb.Append("  productIds: ").Append(ProductIds).Append("\n");
            sb.Append("  memo: ").Append(Memo).Append("\n");
            sb.Append("  indirectPartnerId: ").Append(IndirectPartnerId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreatePartnerCouponsReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreatePartnerCouponsReq input)
        {
            if (input == null) return false;
            if (this.QuotaId != input.QuotaId || (this.QuotaId != null && !this.QuotaId.Equals(input.QuotaId))) return false;
            if (this.CustomerIds != input.CustomerIds || (this.CustomerIds != null && input.CustomerIds != null && !this.CustomerIds.SequenceEqual(input.CustomerIds))) return false;
            if (this.FaceValue != input.FaceValue || (this.FaceValue != null && !this.FaceValue.Equals(input.FaceValue))) return false;
            if (this.ValidTime != input.ValidTime || (this.ValidTime != null && !this.ValidTime.Equals(input.ValidTime))) return false;
            if (this.ExpireTime != input.ExpireTime || (this.ExpireTime != null && !this.ExpireTime.Equals(input.ExpireTime))) return false;
            if (this.CloudServiceTypes != input.CloudServiceTypes || (this.CloudServiceTypes != null && input.CloudServiceTypes != null && !this.CloudServiceTypes.SequenceEqual(input.CloudServiceTypes))) return false;
            if (this.ProductIds != input.ProductIds || (this.ProductIds != null && input.ProductIds != null && !this.ProductIds.SequenceEqual(input.ProductIds))) return false;
            if (this.Memo != input.Memo || (this.Memo != null && !this.Memo.Equals(input.Memo))) return false;
            if (this.IndirectPartnerId != input.IndirectPartnerId || (this.IndirectPartnerId != null && !this.IndirectPartnerId.Equals(input.IndirectPartnerId))) return false;

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
                if (this.QuotaId != null) hashCode = hashCode * 59 + this.QuotaId.GetHashCode();
                if (this.CustomerIds != null) hashCode = hashCode * 59 + this.CustomerIds.GetHashCode();
                if (this.FaceValue != null) hashCode = hashCode * 59 + this.FaceValue.GetHashCode();
                if (this.ValidTime != null) hashCode = hashCode * 59 + this.ValidTime.GetHashCode();
                if (this.ExpireTime != null) hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                if (this.CloudServiceTypes != null) hashCode = hashCode * 59 + this.CloudServiceTypes.GetHashCode();
                if (this.ProductIds != null) hashCode = hashCode * 59 + this.ProductIds.GetHashCode();
                if (this.Memo != null) hashCode = hashCode * 59 + this.Memo.GetHashCode();
                if (this.IndirectPartnerId != null) hashCode = hashCode * 59 + this.IndirectPartnerId.GetHashCode();
                return hashCode;
            }
        }
    }
}
