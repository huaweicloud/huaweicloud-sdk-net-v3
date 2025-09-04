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
    /// 
    /// </summary>
    public class QueryResRecordsDetailReq 
    {

        /// <summary>
        /// 查询的资源详单所在账期，东八区时间，格式为YYYY-MM。 示例：2019-01。  说明： 不支持2019年1月份之前的资源详单。
        /// </summary>
        [JsonProperty("cycle", NullValueHandling = NullValueHandling.Ignore)]
        public string Cycle { get; set; }

        /// <summary>
        /// 云服务类型编码，例如OBS的云服务类型编码为“hws.service.type.obs”。您可以调用查询云服务类型列表接口获取。 此参数不携带或携带值为空串或携带值为null时，不作为筛选条件。
        /// </summary>
        [JsonProperty("cloud_service_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudServiceType { get; set; }

        /// <summary>
        /// 资源类型编码，例如ECS的VM为“hws.resource.type.vm”。您可以调用查询资源类型列表接口获取。 此参数不携带或携带值为空串或携带值为null时，不作为筛选条件。
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 云服务区编码，例如：“ap-southeast-1”。具体请参见地区和终端节点对应云服务的“区域”列的值。 此参数不携带或携带值为空串或携带值为null时，不作为筛选条件。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 资源实例ID。 此参数不携带或携带值为空串或携带值为null时，不作为筛选条件。
        /// </summary>
        [JsonProperty("res_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResInstanceId { get; set; }

        /// <summary>
        /// 计费模式。 1 : 包年/包月3：按需10：预留实例11：节省计划。 此参数不携带或者携带值为null时，返回所有计费模式的资源详单数据记录。
        /// </summary>
        [JsonProperty("charge_mode", NullValueHandling = NullValueHandling.Ignore)]
        public int? ChargeMode { get; set; }

        /// <summary>
        /// 账单类型： 1：消费-新购2：消费-续订3：消费-变更4：退款-退订5：消费-使用8：消费-自动续订9：调账-补偿14：消费-服务支持计划月末扣费15：消费-税金16：调账-扣费17：消费-保底差额 说明： 保底差额&#x3D;客户签约保底合同后，如果没有达到保底消费，客户需要补交的费用，仅限于直销或者伙伴顾问销售类子客户，且为后付费用户。 18：消费-按月付费20：退款-变更100：退款-退订税金23：消费-节省计划抵扣 24：退款-包年/包月转按需101：调账-补偿税金102：调账-扣费税金 此参数不携带或者携带值为null时，返回所有账单类型的资源详单数据记录。
        /// </summary>
        [JsonProperty("bill_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? BillType { get; set; }

        /// <summary>
        /// 企业项目标识（企业项目ID）。 default项目对应ID：0未归集（表示该云服务不支持企业项目管理能力）项目对应ID：null 此参数不携带或携带值为空串或携带值为null时，不作为筛选条件。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 返回是否包含应付金额为0的记录。 true: 包含false: 不包含 此参数不携带或携带值为空串或携带值为null时，不作为筛选条件。
        /// </summary>
        [JsonProperty("include_zero_record", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeZeroRecord { get; set; }

        /// <summary>
        /// 偏移量，从0开始。默认值为0。  说明： offset用于分页处理，如不涉及分页，请使用默认值0。offset表示相对于满足条件的第一个数据的偏移量。如offset &#x3D; 1，则返回满足条件的第二个数据至最后一个数据。 例如，满足查询条件的结果共10条数据，limit取值为10，offset取值为1，则返回的数据为2~10，第一条数据不返回。
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 页面大小。默认值为10。
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 查询方式。 oneself：客户自己sub_customer：企业子客户all：客户自己和企业子客户 此参数不携带或携带值为空串或携带值为null时，默认值为“all”，如果没有企业子客户，all的时候也是查询客户自己的数据。
        /// </summary>
        [JsonProperty("method", NullValueHandling = NullValueHandling.Ignore)]
        public string Method { get; set; }

        /// <summary>
        /// 企业子账号ID。  说明： 如果method取值不为sub_customer，则此参数无效。如果method取值为sub_customer，则此参数不能为空。
        /// </summary>
        [JsonProperty("sub_customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubCustomerId { get; set; }

        /// <summary>
        /// 统计类型。默认值为1。 1：按账期2：按天3：按明细
        /// </summary>
        [JsonProperty("statistic_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? StatisticType { get; set; }

        /// <summary>
        /// |参数名称：查询类型。默认值为BILLCYCLE。| |参数的约束及描述：默认值为BILLCYCLE。BILLCYCLE：按月 DAILY：按天 仅当statistic_type&#x3D;2或3时，支持传递query_type&#x3D;DAILY。该参数不携带或携带值为null或携带为空串时，取默认值BILLCYCLE。|
        /// </summary>
        [JsonProperty("query_type", NullValueHandling = NullValueHandling.Ignore)]
        public string QueryType { get; set; }

        /// <summary>
        /// |账期开始时间。格式为YYYY-MM-DD。| |参数的约束及描述：仅当query_type&#x3D;DAILY时，必须传递账期开始时间。该参数不携带或携带值为null或携带为空串时，不作为筛选条件。|
        /// </summary>
        [JsonProperty("bill_cycle_begin", NullValueHandling = NullValueHandling.Ignore)]
        public string BillCycleBegin { get; set; }

        /// <summary>
        /// |参数名称：账期结束时间。格式为YYYY-MM-DD。| |参数的约束及描述：仅当query_type&#x3D;DAILY时，必须传递账期结束时间。该参数不携带或携带值为null或携带为空串时，不作为筛选条件。|
        /// </summary>
        [JsonProperty("bill_cycle_end", NullValueHandling = NullValueHandling.Ignore)]
        public string BillCycleEnd { get; set; }

        /// <summary>
        /// |参数名称：支付账号ID。| |参数的约束及描述：普通客户、财务独立企业子客户查询消费记录，只能查询到客户自己的消费记录，该参数不携带或携带为自身ID时，查询的都只是自身的消费记录； 企业主客户查询消费记录，不携带时，查询的是自身的、财务托管企业子、财务独立企业子的消费记录；入参自身ID时，查询的是自身的、财务托管企业子的消费记录；也可入参其名下财务独立企业子的客户ID，只查询该财务独立企业子的消费记录； 财务托管企业子查询消费记录，入参自身ID时，查询的是未与企业主关联时的消费记录；入参企业主客户ID时，查询的是与企业主关联后的消费记录；不携带时查询以上全部消费记录|
        /// </summary>
        [JsonProperty("payer_account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PayerAccountId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryResRecordsDetailReq {\n");
            sb.Append("  cycle: ").Append(Cycle).Append("\n");
            sb.Append("  cloudServiceType: ").Append(CloudServiceType).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  resInstanceId: ").Append(ResInstanceId).Append("\n");
            sb.Append("  chargeMode: ").Append(ChargeMode).Append("\n");
            sb.Append("  billType: ").Append(BillType).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  includeZeroRecord: ").Append(IncludeZeroRecord).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  method: ").Append(Method).Append("\n");
            sb.Append("  subCustomerId: ").Append(SubCustomerId).Append("\n");
            sb.Append("  statisticType: ").Append(StatisticType).Append("\n");
            sb.Append("  queryType: ").Append(QueryType).Append("\n");
            sb.Append("  billCycleBegin: ").Append(BillCycleBegin).Append("\n");
            sb.Append("  billCycleEnd: ").Append(BillCycleEnd).Append("\n");
            sb.Append("  payerAccountId: ").Append(PayerAccountId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryResRecordsDetailReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryResRecordsDetailReq input)
        {
            if (input == null) return false;
            if (this.Cycle != input.Cycle || (this.Cycle != null && !this.Cycle.Equals(input.Cycle))) return false;
            if (this.CloudServiceType != input.CloudServiceType || (this.CloudServiceType != null && !this.CloudServiceType.Equals(input.CloudServiceType))) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && !this.ResourceType.Equals(input.ResourceType))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.ResInstanceId != input.ResInstanceId || (this.ResInstanceId != null && !this.ResInstanceId.Equals(input.ResInstanceId))) return false;
            if (this.ChargeMode != input.ChargeMode || (this.ChargeMode != null && !this.ChargeMode.Equals(input.ChargeMode))) return false;
            if (this.BillType != input.BillType || (this.BillType != null && !this.BillType.Equals(input.BillType))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.IncludeZeroRecord != input.IncludeZeroRecord || (this.IncludeZeroRecord != null && !this.IncludeZeroRecord.Equals(input.IncludeZeroRecord))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Method != input.Method || (this.Method != null && !this.Method.Equals(input.Method))) return false;
            if (this.SubCustomerId != input.SubCustomerId || (this.SubCustomerId != null && !this.SubCustomerId.Equals(input.SubCustomerId))) return false;
            if (this.StatisticType != input.StatisticType || (this.StatisticType != null && !this.StatisticType.Equals(input.StatisticType))) return false;
            if (this.QueryType != input.QueryType || (this.QueryType != null && !this.QueryType.Equals(input.QueryType))) return false;
            if (this.BillCycleBegin != input.BillCycleBegin || (this.BillCycleBegin != null && !this.BillCycleBegin.Equals(input.BillCycleBegin))) return false;
            if (this.BillCycleEnd != input.BillCycleEnd || (this.BillCycleEnd != null && !this.BillCycleEnd.Equals(input.BillCycleEnd))) return false;
            if (this.PayerAccountId != input.PayerAccountId || (this.PayerAccountId != null && !this.PayerAccountId.Equals(input.PayerAccountId))) return false;

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
                if (this.Cycle != null) hashCode = hashCode * 59 + this.Cycle.GetHashCode();
                if (this.CloudServiceType != null) hashCode = hashCode * 59 + this.CloudServiceType.GetHashCode();
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.ResInstanceId != null) hashCode = hashCode * 59 + this.ResInstanceId.GetHashCode();
                if (this.ChargeMode != null) hashCode = hashCode * 59 + this.ChargeMode.GetHashCode();
                if (this.BillType != null) hashCode = hashCode * 59 + this.BillType.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.IncludeZeroRecord != null) hashCode = hashCode * 59 + this.IncludeZeroRecord.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Method != null) hashCode = hashCode * 59 + this.Method.GetHashCode();
                if (this.SubCustomerId != null) hashCode = hashCode * 59 + this.SubCustomerId.GetHashCode();
                if (this.StatisticType != null) hashCode = hashCode * 59 + this.StatisticType.GetHashCode();
                if (this.QueryType != null) hashCode = hashCode * 59 + this.QueryType.GetHashCode();
                if (this.BillCycleBegin != null) hashCode = hashCode * 59 + this.BillCycleBegin.GetHashCode();
                if (this.BillCycleEnd != null) hashCode = hashCode * 59 + this.BillCycleEnd.GetHashCode();
                if (this.PayerAccountId != null) hashCode = hashCode * 59 + this.PayerAccountId.GetHashCode();
                return hashCode;
            }
        }
    }
}
