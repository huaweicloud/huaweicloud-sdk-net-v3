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
    public class ListCustomerselfResourceRecordsRequest 
    {

        /// <summary>
        /// 语言：中文：zh_CN 英文：en_US。缺省为zh_CN
        /// </summary>
        [SDKProperty("X-Language", IsHeader = true)]
        [JsonProperty("X-Language", NullValueHandling = NullValueHandling.Ignore)]
        public string XLanguage { get; set; }

        /// <summary>
        /// 查询的资源消费记录所在账期，格式：YYYY-MM。
        /// </summary>
        [SDKProperty("cycle", IsQuery = true)]
        [JsonProperty("cycle", NullValueHandling = NullValueHandling.Ignore)]
        public string Cycle { get; set; }

        /// <summary>
        /// 云服务类型编码，例如OBS的云服务类型编码为“hws.service.type.obs”。您可以调用查询云服务类型列表接口获取。此参数不携带时，不作为筛选条件；携带值为空或携带值为空串时，作为筛选条件。
        /// </summary>
        [SDKProperty("cloud_service_type", IsQuery = true)]
        [JsonProperty("cloud_service_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudServiceType { get; set; }

        /// <summary>
        /// 云服务区编码，例如：“ap-southeast-1”。具体请参见地区和终端节点对应云服务的“区域”列的值。此参数不携带时，不作为筛选条件；携带值为空或携带值为空串时，作为筛选条件。
        /// </summary>
        [SDKProperty("region", IsQuery = true)]
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 计费模式。1：包年/包月3：按需10：预留实例11：节省计划。此参数不携带时，不作为筛选条件。
        /// </summary>
        [SDKProperty("charge_mode", IsQuery = true)]
        [JsonProperty("charge_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargeMode { get; set; }

        /// <summary>
        /// 账单类型。1：消费-新购2：消费-续订3：消费-变更4：退款-退订5：消费-使用8：消费-自动续订9：调账-补偿 12：消费-按时计费 14：消费-服务支持计划月末扣费15：消费-税金16：调账-扣费17：消费-保底差额 说明： 保底差额&#x3D;客户签约保底合同后，如果没有达到保底消费，客户需要补交的费用，仅限于直销或者伙伴顾问销售类子客户，且为后付费用户。18：消费-按月付费20：退款-变更100：退款-退订税金23：消费-节省计划抵扣 24：退款-包年/包月转按需101：调账-补偿税金102：调账-扣费税金。此参数不携带或携带值为空时，不作为筛选条件。
        /// </summary>
        [SDKProperty("bill_type", IsQuery = true)]
        [JsonProperty("bill_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? BillType { get; set; }

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
        /// 资源ID。此参数不携带时，不作为筛选条件；携带值为空或携带值为空串时，作为筛选条件。
        /// </summary>
        [SDKProperty("resource_id", IsQuery = true)]
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 企业项目标识（企业项目ID）。default项目对应ID：0未归集（表示该云服务不支持企业项目管理能力）项目对应ID：null。此参数不携带时，不作为筛选条件；携带值为空或携带值为空串时，作为筛选条件。
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 返回是否包含应付金额为0的记录。true：包含false：不包含。此参数不携带或携带值为空时，不作为筛选条件。
        /// </summary>
        [SDKProperty("include_zero_record", IsQuery = true)]
        [JsonProperty("include_zero_record", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeZeroRecord { get; set; }

        /// <summary>
        /// 查询资源消费记录的方式。oneself：客户自己sub_customer：企业子客户all：客户自己和企业子客户。此参数不携带或携带值为空时，默认值为“all”，如果没有企业子客户，取值为all时查询的是客户自己的资源消费记录。
        /// </summary>
        [SDKProperty("method", IsQuery = true)]
        [JsonProperty("method", NullValueHandling = NullValueHandling.Ignore)]
        public string Method { get; set; }

        /// <summary>
        /// 企业子账号ID。此参数携带值为空串时，不作为筛选条件。 说明： 如果method取值不为sub_customer，则该参数无效。如果method取值为sub_customer，则该参数不能为空。
        /// </summary>
        [SDKProperty("sub_customer_id", IsQuery = true)]
        [JsonProperty("sub_customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubCustomerId { get; set; }

        /// <summary>
        /// 订单ID或交易ID。账单类型为1、2、3、4和8时此处为订单ID。账单类型为其它场景时此处为交易ID，为扣费维度的唯一标识。例如非月末扣费时为应收ID；月末扣费时为账单ID。此参数不携带时，不作为筛选条件；携带值为空或携带值为空串时，作为筛选条件。
        /// </summary>
        [SDKProperty("trade_id", IsQuery = true)]
        [JsonProperty("trade_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeId { get; set; }

        /// <summary>
        /// 查询的资源消费记录的开始日期，格式为YYYY-MM-DD。 说明： 必须和cycle（即资源的消费账期）在同一个月。bill_date_begin和bill_date_end两个参数必须同时出现，否则仅按照cycle（即资源的消费账期）进行查询。
        /// </summary>
        [SDKProperty("bill_date_begin", IsQuery = true)]
        [JsonProperty("bill_date_begin", NullValueHandling = NullValueHandling.Ignore)]
        public string BillDateBegin { get; set; }

        /// <summary>
        /// 查询的资源消费记录的结束日期，格式为YYYY-MM-DD。 说明： 必须和cycle（即资源的消费账期）在同一个月。bill_date_begin和bill_date_end两个参数必须同时出现，否则仅按照cycle（即资源的消费账期）进行查询。
        /// </summary>
        [SDKProperty("bill_date_end", IsQuery = true)]
        [JsonProperty("bill_date_end", NullValueHandling = NullValueHandling.Ignore)]
        public string BillDateEnd { get; set; }

        /// <summary>
        /// |参数名称：统计类型。| |参数的约束及描述：统计类型。非必填，默认值为3。1：按账期 3：按明细|
        /// </summary>
        [SDKProperty("statistic_type", IsQuery = true)]
        [JsonProperty("statistic_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? StatisticType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListCustomerselfResourceRecordsRequest {\n");
            sb.Append("  xLanguage: ").Append(XLanguage).Append("\n");
            sb.Append("  cycle: ").Append(Cycle).Append("\n");
            sb.Append("  cloudServiceType: ").Append(CloudServiceType).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  chargeMode: ").Append(ChargeMode).Append("\n");
            sb.Append("  billType: ").Append(BillType).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  includeZeroRecord: ").Append(IncludeZeroRecord).Append("\n");
            sb.Append("  method: ").Append(Method).Append("\n");
            sb.Append("  subCustomerId: ").Append(SubCustomerId).Append("\n");
            sb.Append("  tradeId: ").Append(TradeId).Append("\n");
            sb.Append("  billDateBegin: ").Append(BillDateBegin).Append("\n");
            sb.Append("  billDateEnd: ").Append(BillDateEnd).Append("\n");
            sb.Append("  statisticType: ").Append(StatisticType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListCustomerselfResourceRecordsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListCustomerselfResourceRecordsRequest input)
        {
            if (input == null) return false;
            if (this.XLanguage != input.XLanguage || (this.XLanguage != null && !this.XLanguage.Equals(input.XLanguage))) return false;
            if (this.Cycle != input.Cycle || (this.Cycle != null && !this.Cycle.Equals(input.Cycle))) return false;
            if (this.CloudServiceType != input.CloudServiceType || (this.CloudServiceType != null && !this.CloudServiceType.Equals(input.CloudServiceType))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.ChargeMode != input.ChargeMode || (this.ChargeMode != null && !this.ChargeMode.Equals(input.ChargeMode))) return false;
            if (this.BillType != input.BillType || (this.BillType != null && !this.BillType.Equals(input.BillType))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.IncludeZeroRecord != input.IncludeZeroRecord || (this.IncludeZeroRecord != null && !this.IncludeZeroRecord.Equals(input.IncludeZeroRecord))) return false;
            if (this.Method != input.Method || (this.Method != null && !this.Method.Equals(input.Method))) return false;
            if (this.SubCustomerId != input.SubCustomerId || (this.SubCustomerId != null && !this.SubCustomerId.Equals(input.SubCustomerId))) return false;
            if (this.TradeId != input.TradeId || (this.TradeId != null && !this.TradeId.Equals(input.TradeId))) return false;
            if (this.BillDateBegin != input.BillDateBegin || (this.BillDateBegin != null && !this.BillDateBegin.Equals(input.BillDateBegin))) return false;
            if (this.BillDateEnd != input.BillDateEnd || (this.BillDateEnd != null && !this.BillDateEnd.Equals(input.BillDateEnd))) return false;
            if (this.StatisticType != input.StatisticType || (this.StatisticType != null && !this.StatisticType.Equals(input.StatisticType))) return false;

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
                if (this.Cycle != null) hashCode = hashCode * 59 + this.Cycle.GetHashCode();
                if (this.CloudServiceType != null) hashCode = hashCode * 59 + this.CloudServiceType.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.ChargeMode != null) hashCode = hashCode * 59 + this.ChargeMode.GetHashCode();
                if (this.BillType != null) hashCode = hashCode * 59 + this.BillType.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.ResourceId != null) hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.IncludeZeroRecord != null) hashCode = hashCode * 59 + this.IncludeZeroRecord.GetHashCode();
                if (this.Method != null) hashCode = hashCode * 59 + this.Method.GetHashCode();
                if (this.SubCustomerId != null) hashCode = hashCode * 59 + this.SubCustomerId.GetHashCode();
                if (this.TradeId != null) hashCode = hashCode * 59 + this.TradeId.GetHashCode();
                if (this.BillDateBegin != null) hashCode = hashCode * 59 + this.BillDateBegin.GetHashCode();
                if (this.BillDateEnd != null) hashCode = hashCode * 59 + this.BillDateEnd.GetHashCode();
                if (this.StatisticType != null) hashCode = hashCode * 59 + this.StatisticType.GetHashCode();
                return hashCode;
            }
        }
    }
}
