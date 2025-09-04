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
    public class ListCustomerBillsFeeRecordsRequest 
    {

        /// <summary>
        /// 语言。zh_CN：中文 en_US：英文。默认为zh_CN：中文。
        /// </summary>
        [SDKProperty("X-Language", IsHeader = true)]
        [JsonProperty("X-Language", NullValueHandling = NullValueHandling.Ignore)]
        public string XLanguage { get; set; }

        /// <summary>
        /// 查询的流水账单所在账期，东八区时间，格式为YYYY-MM。
        /// </summary>
        [SDKProperty("bill_cycle", IsQuery = true)]
        [JsonProperty("bill_cycle", NullValueHandling = NullValueHandling.Ignore)]
        public string BillCycle { get; set; }

        /// <summary>
        /// 服务商。1：华为云2：云商店为空时查询包含华为云和云商店在内的全部服务商。此参数不携带或携带值为空时，不作为筛选条件。
        /// </summary>
        [SDKProperty("provider_type", IsQuery = true)]
        [JsonProperty("provider_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProviderType { get; set; }

        /// <summary>
        /// 云服务类型编码，例如OBS的云服务类型编码为“hws.service.type.obs”。您可以调用[查询云服务类型列表](https://support.huaweicloud.com/api-oce/zh-cn_topic_0000001256679455.html)接口获取。此参数不携带或携带值为空时，不作为筛选条件。
        /// </summary>
        [SDKProperty("service_type_code", IsQuery = true)]
        [JsonProperty("service_type_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceTypeCode { get; set; }

        /// <summary>
        /// 资源类型编码，例如ECS的VM为“hws.resource.type.vm”。您可以调用[查询资源类型列表](https://support.huaweicloud.com/api-oce/zh-cn_topic_0000001256519451.html)接口获取。此参数不携带或携带值为空时，不作为筛选条件。
        /// </summary>
        [SDKProperty("resource_type_code", IsQuery = true)]
        [JsonProperty("resource_type_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceTypeCode { get; set; }

        /// <summary>
        /// 云服务区编码，例如：“cn-north-1”。具体请参见[地区和终端节点](https://developer.huaweicloud.com/endpoint)对应云服务的“区域”列的值。此参数不携带或携带值为空时，不作为筛选条件。
        /// </summary>
        [SDKProperty("region_code", IsQuery = true)]
        [JsonProperty("region_code", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionCode { get; set; }

        /// <summary>
        /// 计费模式：1 : 包年/包月3：按需10：预留实例11：节省计划 此参数不携带或携带值为空时，不作为筛选条件。
        /// </summary>
        [SDKProperty("charging_mode", IsQuery = true)]
        [JsonProperty("charging_mode", NullValueHandling = NullValueHandling.Ignore)]
        public int? ChargingMode { get; set; }

        /// <summary>
        /// 账单类型。1：消费-新购 2：消费-续订 3：消费-变更 4：退款-退订 5：消费-使用 8：消费-自动续订 9：调账-补偿 14：消费-服务支持计划月末扣费 16：调账-扣费 18：消费-按月付费 20：退款-变更 23：消费-节省计划抵扣 24：退款-包年/包月转按需 25：消费-抹零补扣 103：消费-按年付费 此参数不携带或携带值为空时，不作为筛选条件。
        /// </summary>
        [SDKProperty("bill_type", IsQuery = true)]
        [JsonProperty("bill_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? BillType { get; set; }

        /// <summary>
        /// 订单ID或交易ID。账单类型为1、2、3、4和8时此处为订单ID。账单类型为其它场景时此处为交易ID，为扣费维度的唯一标识。例如非月末扣费时为应收ID；月末扣费时为账单ID。此参数不携带或携带值为空时，不作为筛选条件。
        /// </summary>
        [SDKProperty("trade_id", IsQuery = true)]
        [JsonProperty("trade_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeId { get; set; }

        /// <summary>
        /// 企业项目标识（企业项目ID）。default项目对应ID：0未归集（表示该云服务不支持企业项目管理能力）项目对应ID：null其余项目对应ID获取方法请参见[如何获取企业项目ID](https://support.huaweicloud.com/usermanual-em/zh-cn_topic_0126101490.html)。此参数不携带或携带值为空时，不作为筛选条件。
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 返回是否包含应付金额为0的记录。true：包含false：不包含此参数不携带或携带值为空时，不作为筛选条件。
        /// </summary>
        [SDKProperty("include_zero_record", IsQuery = true)]
        [JsonProperty("include_zero_record", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeZeroRecord { get; set; }

        /// <summary>
        /// 支付状态。1：已支付2：未结清3：未出账此参数不携带或携带值为空时，不作为筛选条件。
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// 查询流水账单的方式。oneself：客户自己sub_customer：企业子客户all：客户自己和企业子客户 此参数不携带或携带值为空时，默认值为“all”，如果没有企业子客户，取值为all时查询的是客户自己的流水账单。
        /// </summary>
        [SDKProperty("method", IsQuery = true)]
        [JsonProperty("method", NullValueHandling = NullValueHandling.Ignore)]
        public string Method { get; set; }

        /// <summary>
        /// 企业子账号ID。 说明： 如果method取值不为sub_customer，则该参数无效。如果method取值为sub_customer，则该参数不能为空。
        /// </summary>
        [SDKProperty("sub_customer_id", IsQuery = true)]
        [JsonProperty("sub_customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubCustomerId { get; set; }

        /// <summary>
        /// 偏移量，从0开始。默认值为0。 说明： offset用于分页处理，如不涉及分页，请使用默认值0。offset表示相对于满足条件的第一个数据的偏移量。如offset &#x3D; 1，则返回满足条件的第二个数据至最后一个数据。例如，满足查询条件的结果共10条数据，limit取值为10，offset取值为1，则返回的数据为2~10，第一条数据不返回。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 页面大小。默认值为10。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 查询的流水账单的开始日期，东八区时间，格式为YYYY-MM-DD。此参数不携带或携带值为空时，不作为筛选条件。 说明： 必须和bill_cycle（即流水账单的所在账期）在同一个月。bill_date_begin和bill_date_end两个参数必须同时出现，否则仅按照bill_cycle（即流水账单的所在账期）进行查询。
        /// </summary>
        [SDKProperty("bill_date_begin", IsQuery = true)]
        [JsonProperty("bill_date_begin", NullValueHandling = NullValueHandling.Ignore)]
        public string BillDateBegin { get; set; }

        /// <summary>
        /// 查询的流水账单的结束日期，东八区时间，格式为YYYY-MM-DD。此参数不携带或携带值为空时，不作为筛选条件。 说明： 必须和bill_cycle（即流水账单的所在账期）在同一个月。bill_date_begin和bill_date_end两个参数必须同时出现，否则仅按照bill_cycle（即流水账单的所在账期）进行查询。
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
            sb.Append("class ListCustomerBillsFeeRecordsRequest {\n");
            sb.Append("  xLanguage: ").Append(XLanguage).Append("\n");
            sb.Append("  billCycle: ").Append(BillCycle).Append("\n");
            sb.Append("  providerType: ").Append(ProviderType).Append("\n");
            sb.Append("  serviceTypeCode: ").Append(ServiceTypeCode).Append("\n");
            sb.Append("  resourceTypeCode: ").Append(ResourceTypeCode).Append("\n");
            sb.Append("  regionCode: ").Append(RegionCode).Append("\n");
            sb.Append("  chargingMode: ").Append(ChargingMode).Append("\n");
            sb.Append("  billType: ").Append(BillType).Append("\n");
            sb.Append("  tradeId: ").Append(TradeId).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  includeZeroRecord: ").Append(IncludeZeroRecord).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  method: ").Append(Method).Append("\n");
            sb.Append("  subCustomerId: ").Append(SubCustomerId).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
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
            return this.Equals(input as ListCustomerBillsFeeRecordsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListCustomerBillsFeeRecordsRequest input)
        {
            if (input == null) return false;
            if (this.XLanguage != input.XLanguage || (this.XLanguage != null && !this.XLanguage.Equals(input.XLanguage))) return false;
            if (this.BillCycle != input.BillCycle || (this.BillCycle != null && !this.BillCycle.Equals(input.BillCycle))) return false;
            if (this.ProviderType != input.ProviderType || (this.ProviderType != null && !this.ProviderType.Equals(input.ProviderType))) return false;
            if (this.ServiceTypeCode != input.ServiceTypeCode || (this.ServiceTypeCode != null && !this.ServiceTypeCode.Equals(input.ServiceTypeCode))) return false;
            if (this.ResourceTypeCode != input.ResourceTypeCode || (this.ResourceTypeCode != null && !this.ResourceTypeCode.Equals(input.ResourceTypeCode))) return false;
            if (this.RegionCode != input.RegionCode || (this.RegionCode != null && !this.RegionCode.Equals(input.RegionCode))) return false;
            if (this.ChargingMode != input.ChargingMode || (this.ChargingMode != null && !this.ChargingMode.Equals(input.ChargingMode))) return false;
            if (this.BillType != input.BillType || (this.BillType != null && !this.BillType.Equals(input.BillType))) return false;
            if (this.TradeId != input.TradeId || (this.TradeId != null && !this.TradeId.Equals(input.TradeId))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.IncludeZeroRecord != input.IncludeZeroRecord || (this.IncludeZeroRecord != null && !this.IncludeZeroRecord.Equals(input.IncludeZeroRecord))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Method != input.Method || (this.Method != null && !this.Method.Equals(input.Method))) return false;
            if (this.SubCustomerId != input.SubCustomerId || (this.SubCustomerId != null && !this.SubCustomerId.Equals(input.SubCustomerId))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
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
                if (this.ProviderType != null) hashCode = hashCode * 59 + this.ProviderType.GetHashCode();
                if (this.ServiceTypeCode != null) hashCode = hashCode * 59 + this.ServiceTypeCode.GetHashCode();
                if (this.ResourceTypeCode != null) hashCode = hashCode * 59 + this.ResourceTypeCode.GetHashCode();
                if (this.RegionCode != null) hashCode = hashCode * 59 + this.RegionCode.GetHashCode();
                if (this.ChargingMode != null) hashCode = hashCode * 59 + this.ChargingMode.GetHashCode();
                if (this.BillType != null) hashCode = hashCode * 59 + this.BillType.GetHashCode();
                if (this.TradeId != null) hashCode = hashCode * 59 + this.TradeId.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.IncludeZeroRecord != null) hashCode = hashCode * 59 + this.IncludeZeroRecord.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Method != null) hashCode = hashCode * 59 + this.Method.GetHashCode();
                if (this.SubCustomerId != null) hashCode = hashCode * 59 + this.SubCustomerId.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.BillDateBegin != null) hashCode = hashCode * 59 + this.BillDateBegin.GetHashCode();
                if (this.BillDateEnd != null) hashCode = hashCode * 59 + this.BillDateEnd.GetHashCode();
                return hashCode;
            }
        }
    }
}
