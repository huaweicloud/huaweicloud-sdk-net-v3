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
    /// Request Object
    /// </summary>
    public class ListSubCustomerBillDetailRequest 
    {

        /// <summary>
        /// 语言。忽略大小写，默认 zh_cn：中文 en_us：英文
        /// </summary>
        [SDKProperty("X-Language", IsHeader = true)]
        [JsonProperty("X-Language", NullValueHandling = NullValueHandling.Ignore)]
        public string XLanguage { get; set; }

        /// <summary>
        /// 账期所在月份。格式：YYYY-MM
        /// </summary>
        [SDKProperty("bill_cycle", IsQuery = true)]
        [JsonProperty("bill_cycle", NullValueHandling = NullValueHandling.Ignore)]
        public string BillCycle { get; set; }

        /// <summary>
        /// 客户账号ID。您可以调用[查询客户列表](https://support.huaweicloud.com/api-bpconsole/mc_00021.html)接口获取customer_id。
        /// </summary>
        [SDKProperty("customer_id", IsQuery = true)]
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerId { get; set; }

        /// <summary>
        /// 云服务类型编码，例如OBS的云服务类型编码为“hws.service.type.obs”。您可以调用[查询云服务类型列表](https://support.huaweicloud.com/api-bpconsole/zh-cn_topic_0000001256679455.html)接口获取。此参数不携带或携带值为空时，不作为筛选条件；携带值为空串或携带值为null时，作为筛选条件。
        /// </summary>
        [SDKProperty("service_type_code", IsQuery = true)]
        [JsonProperty("service_type_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceTypeCode { get; set; }

        /// <summary>
        /// 云服务区编码，例如：“cn-north-1”。具体请参见[地区和终端节点](https://developer.huaweicloud.com/endpoint)对应云服务的“区域”列的值。此参数不携带或携带值为空时，不作为筛选条件；携带值为空串或携带值为null时，作为筛选条件。
        /// </summary>
        [SDKProperty("region_code", IsQuery = true)]
        [JsonProperty("region_code", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionCode { get; set; }

        /// <summary>
        /// 计费模式。1：包周期3：按需10：预留实例11：节省计划此参数不携带或携带值为空或携带为null时，默认查询所有计费模式下的消费记录；不支持携带值为空串。
        /// </summary>
        [SDKProperty("charging_mode", IsQuery = true)]
        [JsonProperty("charging_mode", NullValueHandling = NullValueHandling.Ignore)]
        public int? ChargingMode { get; set; }

        /// <summary>
        /// 账单类型。1：消费-新购 2：消费-续订 3：消费-变更 4：退款-退订 5：消费-使用 8：消费-自动续订 9：调账-补偿 14：消费-服务支持计划月末扣费 16：调账-扣费 18：消费-按月付费 20：退款-变更 23：消费-节省计划抵扣 24：退款-包年/包月转按需 25：消费-抹零补扣 103：消费-按年付费 此参数不携带或携带值为空或携带值为null时，不作为筛选条件；不支持携带值为空串。
        /// </summary>
        [SDKProperty("bill_detail_type", IsQuery = true)]
        [JsonProperty("bill_detail_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? BillDetailType { get; set; }

        /// <summary>
        /// 资源标识。此参数不携带或携带值为空时，不作为筛选条件；携带值为null时，作为筛选条件；不支持携带值为空串。
        /// </summary>
        [SDKProperty("resource_id", IsQuery = true)]
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 资源名称。此参数不携带或携带值为空时，不作为筛选条件；携带值为null时，作为筛选条件；不支持携带值为空串。
        /// </summary>
        [SDKProperty("resource_name", IsQuery = true)]
        [JsonProperty("resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceName { get; set; }

        /// <summary>
        /// 订单ID或交易ID，扣费维度的唯一标识。账单类型为1，2，3，4，8时为订单ID。其它场景下为交易ID。非月末扣费：应收ID月末扣费：账单ID 此参数不携带或携带值为空时，不作为筛选条件；携带值为null时，作为筛选条件；不支持携带值为空串。
        /// </summary>
        [SDKProperty("trade_id", IsQuery = true)]
        [JsonProperty("trade_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeId { get; set; }

        /// <summary>
        /// 客户经理标识。此参数不携带或携带值为空时，不作为筛选条件；携带值为null时，作为筛选条件；不支持携带值为空串。
        /// </summary>
        [SDKProperty("account_manager_id", IsQuery = true)]
        [JsonProperty("account_manager_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountManagerId { get; set; }

        /// <summary>
        /// 子客户的关联类型：1：顾问销售2：代售 此参数不携带或携带值为空时，不作为筛选条件；不支持携带为null和空串。
        /// </summary>
        [SDKProperty("association_type", IsQuery = true)]
        [JsonProperty("association_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AssociationType { get; set; }

        /// <summary>
        /// 偏移量，从0开始。默认值为0。 说明： offset用于分页处理，如不涉及分页，请使用默认值0。offset表示相对于满足条件的第一个数据的偏移量。如offset &#x3D; 1，则返回满足条件的第二个数据至最后一个数据。例如，满足查询条件的结果共10条数据，limit取值为10，offset取值为1，则返回的数据为2~10，第一条数据不返回。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 每次查询的数量限制。默认值为10。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 云经销商ID。获取方法请参见[查询云经销商列表](https://support.huaweicloud.com/api-bpconsole/espp_00003.html)。  说明： 华为云总经销商可以查询名下所有子客户消费（包括云经销商子客户）。如果是普通经销商，那么此处可以为空。如果华为云总经销商需要查询客户在云经销商关联期间的消费，需要携带该字段；除此之外，此参数不做处理。否则只能查询该客户在与自己关联期间的消费。
        /// </summary>
        [SDKProperty("indirect_partner_id", IsQuery = true)]
        [JsonProperty("indirect_partner_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IndirectPartnerId { get; set; }

        /// <summary>
        /// 查询的资源消费记录的开始日期，格式为YYYY-MM-DD。此参数不携带或携带值为空时，不作为筛选条件；不支持携带值为空串。 说明： 必须和bill_cycle（即资源的消费账期）在同一个月。bill_date_begin需小于等于bill_date_end。
        /// </summary>
        [SDKProperty("bill_date_begin", IsQuery = true)]
        [JsonProperty("bill_date_begin", NullValueHandling = NullValueHandling.Ignore)]
        public string BillDateBegin { get; set; }

        /// <summary>
        /// 查询的资源消费记录的结束日期，格式为YYYY-MM-DD。此参数不携带或携带值为空时，不作为筛选条件；不支持携带值为空串。 说明： 必须和bill_cycle（即资源的消费账期）在同一个月。bill_date_begin和bill_date_end两个参数必须同时出现，否则仅按照bill_cycle（即资源的消费账期）进行查询。bill_date_begin需小于等于bill_date_end。
        /// </summary>
        [SDKProperty("bill_date_end", IsQuery = true)]
        [JsonProperty("bill_date_end", NullValueHandling = NullValueHandling.Ignore)]
        public string BillDateEnd { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSubCustomerBillDetailRequest {\n");
            sb.Append("  xLanguage: ").Append(XLanguage).Append("\n");
            sb.Append("  billCycle: ").Append(BillCycle).Append("\n");
            sb.Append("  customerId: ").Append(CustomerId).Append("\n");
            sb.Append("  serviceTypeCode: ").Append(ServiceTypeCode).Append("\n");
            sb.Append("  regionCode: ").Append(RegionCode).Append("\n");
            sb.Append("  chargingMode: ").Append(ChargingMode).Append("\n");
            sb.Append("  billDetailType: ").Append(BillDetailType).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  resourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  tradeId: ").Append(TradeId).Append("\n");
            sb.Append("  accountManagerId: ").Append(AccountManagerId).Append("\n");
            sb.Append("  associationType: ").Append(AssociationType).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  indirectPartnerId: ").Append(IndirectPartnerId).Append("\n");
            sb.Append("  billDateBegin: ").Append(BillDateBegin).Append("\n");
            sb.Append("  billDateEnd: ").Append(BillDateEnd).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSubCustomerBillDetailRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSubCustomerBillDetailRequest input)
        {
            if (input == null) return false;
            if (this.XLanguage != input.XLanguage || (this.XLanguage != null && !this.XLanguage.Equals(input.XLanguage))) return false;
            if (this.BillCycle != input.BillCycle || (this.BillCycle != null && !this.BillCycle.Equals(input.BillCycle))) return false;
            if (this.CustomerId != input.CustomerId || (this.CustomerId != null && !this.CustomerId.Equals(input.CustomerId))) return false;
            if (this.ServiceTypeCode != input.ServiceTypeCode || (this.ServiceTypeCode != null && !this.ServiceTypeCode.Equals(input.ServiceTypeCode))) return false;
            if (this.RegionCode != input.RegionCode || (this.RegionCode != null && !this.RegionCode.Equals(input.RegionCode))) return false;
            if (this.ChargingMode != input.ChargingMode || (this.ChargingMode != null && !this.ChargingMode.Equals(input.ChargingMode))) return false;
            if (this.BillDetailType != input.BillDetailType || (this.BillDetailType != null && !this.BillDetailType.Equals(input.BillDetailType))) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.ResourceName != input.ResourceName || (this.ResourceName != null && !this.ResourceName.Equals(input.ResourceName))) return false;
            if (this.TradeId != input.TradeId || (this.TradeId != null && !this.TradeId.Equals(input.TradeId))) return false;
            if (this.AccountManagerId != input.AccountManagerId || (this.AccountManagerId != null && !this.AccountManagerId.Equals(input.AccountManagerId))) return false;
            if (this.AssociationType != input.AssociationType || (this.AssociationType != null && !this.AssociationType.Equals(input.AssociationType))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.IndirectPartnerId != input.IndirectPartnerId || (this.IndirectPartnerId != null && !this.IndirectPartnerId.Equals(input.IndirectPartnerId))) return false;
            if (this.BillDateBegin != input.BillDateBegin || (this.BillDateBegin != null && !this.BillDateBegin.Equals(input.BillDateBegin))) return false;
            if (this.BillDateEnd != input.BillDateEnd || (this.BillDateEnd != null && !this.BillDateEnd.Equals(input.BillDateEnd))) return false;

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
                if (this.XLanguage != null) hashCode = hashCode * 59 + this.XLanguage.GetHashCode();
                if (this.BillCycle != null) hashCode = hashCode * 59 + this.BillCycle.GetHashCode();
                if (this.CustomerId != null) hashCode = hashCode * 59 + this.CustomerId.GetHashCode();
                if (this.ServiceTypeCode != null) hashCode = hashCode * 59 + this.ServiceTypeCode.GetHashCode();
                if (this.RegionCode != null) hashCode = hashCode * 59 + this.RegionCode.GetHashCode();
                if (this.ChargingMode != null) hashCode = hashCode * 59 + this.ChargingMode.GetHashCode();
                if (this.BillDetailType != null) hashCode = hashCode * 59 + this.BillDetailType.GetHashCode();
                if (this.ResourceId != null) hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.ResourceName != null) hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.TradeId != null) hashCode = hashCode * 59 + this.TradeId.GetHashCode();
                if (this.AccountManagerId != null) hashCode = hashCode * 59 + this.AccountManagerId.GetHashCode();
                if (this.AssociationType != null) hashCode = hashCode * 59 + this.AssociationType.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.IndirectPartnerId != null) hashCode = hashCode * 59 + this.IndirectPartnerId.GetHashCode();
                if (this.BillDateBegin != null) hashCode = hashCode * 59 + this.BillDateBegin.GetHashCode();
                if (this.BillDateEnd != null) hashCode = hashCode * 59 + this.BillDateEnd.GetHashCode();
                return hashCode;
            }
        }
    }
}
