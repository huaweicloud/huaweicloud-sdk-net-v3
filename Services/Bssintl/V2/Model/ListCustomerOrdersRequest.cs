using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bssintl.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListCustomerOrdersRequest 
    {
        /// <summary>
        /// |参数名称：查询方式，oneself：客户自己订单sub_customer：客户给企业子代付订单。| |参数的约束及描述：默认为oneself。仅customer_id有值时生效。此参数不携带或携带值为空串或携带值为null时，默认值为“oneself”。|
        /// </summary>
        /// <value>|参数名称：查询方式，oneself：客户自己订单sub_customer：客户给企业子代付订单。| |参数的约束及描述：默认为oneself。仅customer_id有值时生效。此参数不携带或携带值为空串或携带值为null时，默认值为“oneself”。|</value>
        [JsonConverter(typeof(EnumClassConverter<MethodEnum>))]
        public class MethodEnum
        {
            /// <summary>
            /// Enum ONESELF for value: oneself
            /// </summary>
            public static readonly MethodEnum ONESELF = new MethodEnum("oneself");

            /// <summary>
            /// Enum SUB_CUSTOMER for value: sub_customer
            /// </summary>
            public static readonly MethodEnum SUB_CUSTOMER = new MethodEnum("sub_customer");

            private static readonly Dictionary<string, MethodEnum> StaticFields =
            new Dictionary<string, MethodEnum>()
            {
                { "oneself", ONESELF },
                { "sub_customer", SUB_CUSTOMER },
            };

            private string _value;

            public MethodEnum()
            {

            }

            public MethodEnum(string value)
            {
                _value = value;
            }

            public static MethodEnum FromValue(string value)
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

                if (this.Equals(obj as MethodEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(MethodEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(MethodEnum a, MethodEnum b)
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

            public static bool operator !=(MethodEnum a, MethodEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 订单ID。 说明： 使用特殊字符进行查询的时候，请注意进行URL编码转换，如“%”的转码应为“%25”。
        /// </summary>
        [SDKProperty("order_id", IsQuery = true)]
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        /// <summary>
        /// 客户账号ID。您可以调用[查询客户列表](https://support.huaweicloud.com/intl/zh-cn/api-bpconsole/mc_00021.html)接口获取customer_id。
        /// </summary>
        [SDKProperty("customer_id", IsQuery = true)]
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerId { get; set; }

        /// <summary>
        /// 订单创建开始时间。UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，如“2019-05-06T08:05:01Z”。其中，HH范围是0～23，mm和ss范围是0～59。
        /// </summary>
        [SDKProperty("create_time_begin", IsQuery = true)]
        [JsonProperty("create_time_begin", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTimeBegin { get; set; }

        /// <summary>
        /// 订单创建结束时间。UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，如“2019-05-06T08:05:01Z”。其中，HH范围是0～23，mm和ss范围是0～59。
        /// </summary>
        [SDKProperty("create_time_end", IsQuery = true)]
        [JsonProperty("create_time_end", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTimeEnd { get; set; }

        /// <summary>
        /// 云服务类型编码，例如OBS的云服务类型编码为“hws.service.type.obs”。您可以调用查询云服务类型列表接口获取。
        /// </summary>
        [SDKProperty("service_type_code", IsQuery = true)]
        [JsonProperty("service_type_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceTypeCode { get; set; }

        /// <summary>
        /// 订单状态：1：待审核3：处理中4：已取消5：已完成6：待支付9：待确认
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// 订单类型：1：开通2：续订3：变更4：退订11：按需转包年/包月13：试用14：转商用15：费用调整
        /// </summary>
        [SDKProperty("order_type", IsQuery = true)]
        [JsonProperty("order_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderType { get; set; }

        /// <summary>
        /// 每次查询的订单数量，默认值为10。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 偏移量，从0开始。默认值为0。 说明： offset用于分页处理，如不涉及分页，请使用默认值0。offset表示相对于满足条件的第一个数据的偏移量。如offset &#x3D; 1，则返回满足条件的第二个数据至最后一个数据。例如，满足查询条件的结果共10条数据，limit取值为10，offset取值为1，则返回的数据为2~10，第一条数据不返回。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 查询的订单列表排序。支持按照创建时间进行排序，带-表示倒序。创建时间：升序为createTime，倒序为-createTime。
        /// </summary>
        [SDKProperty("order_by", IsQuery = true)]
        [JsonProperty("order_by", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderBy { get; set; }

        /// <summary>
        /// 订单支付开始时间。UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，如“2019-05-06T08:05:01Z”。其中，HH范围是0～23，mm和ss范围是0～59。
        /// </summary>
        [SDKProperty("payment_time_begin", IsQuery = true)]
        [JsonProperty("payment_time_begin", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentTimeBegin { get; set; }

        /// <summary>
        /// 订单支付结束时间。UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，如“2019-05-06T08:05:01Z”。其中，HH范围是0～23，mm和ss范围是0～59。
        /// </summary>
        [SDKProperty("payment_time_end", IsQuery = true)]
        [JsonProperty("payment_time_end", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentTimeEnd { get; set; }

        /// <summary>
        /// 云经销商ID。华为云总经销商（一级经销商）查询云经销商的客户订单列表时，需要携带该参数；除此之外，此参数不做处理。否则只能查询自己客户的订单列表。
        /// </summary>
        [SDKProperty("indirect_partner_id", IsQuery = true)]
        [JsonProperty("indirect_partner_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IndirectPartnerId { get; set; }

        /// <summary>
        /// |参数名称：查询方式，oneself：客户自己订单sub_customer：客户给企业子代付订单。| |参数的约束及描述：默认为oneself。仅customer_id有值时生效。此参数不携带或携带值为空串或携带值为null时，默认值为“oneself”。|
        /// </summary>
        [SDKProperty("method", IsQuery = true)]
        [JsonProperty("method", NullValueHandling = NullValueHandling.Ignore)]
        public MethodEnum Method { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListCustomerOrdersRequest {\n");
            sb.Append("  orderId: ").Append(OrderId).Append("\n");
            sb.Append("  customerId: ").Append(CustomerId).Append("\n");
            sb.Append("  createTimeBegin: ").Append(CreateTimeBegin).Append("\n");
            sb.Append("  createTimeEnd: ").Append(CreateTimeEnd).Append("\n");
            sb.Append("  serviceTypeCode: ").Append(ServiceTypeCode).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  orderType: ").Append(OrderType).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  orderBy: ").Append(OrderBy).Append("\n");
            sb.Append("  paymentTimeBegin: ").Append(PaymentTimeBegin).Append("\n");
            sb.Append("  paymentTimeEnd: ").Append(PaymentTimeEnd).Append("\n");
            sb.Append("  indirectPartnerId: ").Append(IndirectPartnerId).Append("\n");
            sb.Append("  method: ").Append(Method).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListCustomerOrdersRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListCustomerOrdersRequest input)
        {
            if (input == null) return false;
            if (this.OrderId != input.OrderId || (this.OrderId != null && !this.OrderId.Equals(input.OrderId))) return false;
            if (this.CustomerId != input.CustomerId || (this.CustomerId != null && !this.CustomerId.Equals(input.CustomerId))) return false;
            if (this.CreateTimeBegin != input.CreateTimeBegin || (this.CreateTimeBegin != null && !this.CreateTimeBegin.Equals(input.CreateTimeBegin))) return false;
            if (this.CreateTimeEnd != input.CreateTimeEnd || (this.CreateTimeEnd != null && !this.CreateTimeEnd.Equals(input.CreateTimeEnd))) return false;
            if (this.ServiceTypeCode != input.ServiceTypeCode || (this.ServiceTypeCode != null && !this.ServiceTypeCode.Equals(input.ServiceTypeCode))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.OrderType != input.OrderType || (this.OrderType != null && !this.OrderType.Equals(input.OrderType))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.OrderBy != input.OrderBy || (this.OrderBy != null && !this.OrderBy.Equals(input.OrderBy))) return false;
            if (this.PaymentTimeBegin != input.PaymentTimeBegin || (this.PaymentTimeBegin != null && !this.PaymentTimeBegin.Equals(input.PaymentTimeBegin))) return false;
            if (this.PaymentTimeEnd != input.PaymentTimeEnd || (this.PaymentTimeEnd != null && !this.PaymentTimeEnd.Equals(input.PaymentTimeEnd))) return false;
            if (this.IndirectPartnerId != input.IndirectPartnerId || (this.IndirectPartnerId != null && !this.IndirectPartnerId.Equals(input.IndirectPartnerId))) return false;
            if (this.Method != input.Method) return false;

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
                if (this.OrderId != null) hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.CustomerId != null) hashCode = hashCode * 59 + this.CustomerId.GetHashCode();
                if (this.CreateTimeBegin != null) hashCode = hashCode * 59 + this.CreateTimeBegin.GetHashCode();
                if (this.CreateTimeEnd != null) hashCode = hashCode * 59 + this.CreateTimeEnd.GetHashCode();
                if (this.ServiceTypeCode != null) hashCode = hashCode * 59 + this.ServiceTypeCode.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.OrderType != null) hashCode = hashCode * 59 + this.OrderType.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.OrderBy != null) hashCode = hashCode * 59 + this.OrderBy.GetHashCode();
                if (this.PaymentTimeBegin != null) hashCode = hashCode * 59 + this.PaymentTimeBegin.GetHashCode();
                if (this.PaymentTimeEnd != null) hashCode = hashCode * 59 + this.PaymentTimeEnd.GetHashCode();
                if (this.IndirectPartnerId != null) hashCode = hashCode * 59 + this.IndirectPartnerId.GetHashCode();
                hashCode = hashCode * 59 + this.Method.GetHashCode();
                return hashCode;
            }
        }
    }
}
