using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListImmediateJobsRequest 
    {

        /// <summary>
        /// 语言。
        /// </summary>
        [SDKProperty("X-Language", IsHeader = true)]
        [JsonProperty("X-Language", NullValueHandling = NullValueHandling.Ignore)]
        public string XLanguage { get; set; }

        /// <summary>
        /// 任务执行状态。 取值： - 值为“Running”，表示任务正在执行。 - 值为“Completed”，表示任务执行成功。 - 值为“Failed”，表示任务执行失败。 - 值为“Pending”，表示任务未执行。
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 任务名称。取值有：  - \&quot;CreateGaussDBforMySQLInstance\&quot;表示创建实例。  - \&quot;RestoreGaussDBforMySQLNewInstance\&quot;表示恢复新实例。  - \&quot;AddGaussDBforMySQLNodes\&quot;表示添加节点。  - \&quot;DeleteGaussDBforMySQLNode\&quot;表示删除节点。  - \&quot;RebootGaussDBforMySQLInstance\&quot;表示重启实例。  - \&quot;ModifyGaussDBforMySQLPort\&quot;表示修改实例端口。  - \&quot;ModifyGaussDBforMySQLSecurityGroup\&quot;表示修改实例安全组。  - \&quot;ResizeGaussDBforMySQLFlavor\&quot;表示实例规格变更。  - \&quot;SwitchoverGaussDBforMySQLMasterNode\&quot;表示只读升主。  - \&quot;GaussDBforMySQLBindEIP\&quot;表示绑定弹性公网IP。  - \&quot;GaussDBforMySQLUnbindEIP\&quot;表示解绑弹性公网IP。  - \&quot;RenameGaussDBforMySQLInstance\&quot;表示修改实例名称。  - \&quot;DeleteGaussDBforMySQLInstance\&quot;表示删除实例集群。  - \&quot;UpgradeGaussDBforMySQLDatabaseVersion\&quot;表示版本升级。  - \&quot;EnlargeGaussDBforMySQLProxy\&quot;表示实例的数据库代理节点扩容。  - \&quot;OpenGaussDBforMySQLProxy\&quot;表示开启实例的数据库代理。  - \&quot;CloseGaussDBforMySQLProxy\&quot;表示关闭实例的数据库代理。  - \&quot;GaussdbforMySQLModifyProxyIp\&quot;表示修改数据库代理ip。  - \&quot;ScaleGaussDBforMySQLProxy\&quot;表示实例的数据库代理节点规格变更。  - \&quot;GaussDBforMySQLModifyInstanceMetricExtend\&quot;表示实例秒级监控。  - \&quot;GaussDBforMySQLModifyInstanceDataVip\&quot;表示修改实例数据Vip。  - \&quot;GaussDBforMySQLSwitchSSL\&quot;表示切换实例SSL开关。  - \&quot;GaussDBforMySQLModifyProxyConsist\&quot;表示修改代理一致性。  - \&quot;GaussDBforMySQLModifyProxyWeight\&quot;表示修改代理权重。
        /// </summary>
        [SDKProperty("job_name", IsQuery = true)]
        [JsonProperty("job_name", NullValueHandling = NullValueHandling.Ignore)]
        public string JobName { get; set; }

        /// <summary>
        /// 任务ID。
        /// </summary>
        [SDKProperty("job_id", IsQuery = true)]
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 索引位置，偏移量。从第一条数据偏移offset条数据后开始查询，默认为1，必须为数字，不能为负数。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public string Offset { get; set; }

        /// <summary>
        /// 查询记录数。默认为10，取值为10、20、50。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public string Limit { get; set; }

        /// <summary>
        /// 起始时间，格式为\&quot;yyyy-mm-ddThh:mm:ssZ\&quot;。 其中，T指某个时间的开始；Z指时区偏移量，例如偏移1个小时显示为+0100。
        /// </summary>
        [SDKProperty("start_time", IsQuery = true)]
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 结束时间，格式为\&quot;yyyy-mm-ddThh:mm:ssZ\&quot;。 其中，T指某个时间的开始；Z指时区偏移量，例如偏移1个小时显示为+0100。
        /// </summary>
        [SDKProperty("end_time", IsQuery = true)]
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListImmediateJobsRequest {\n");
            sb.Append("  xLanguage: ").Append(XLanguage).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  jobName: ").Append(JobName).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListImmediateJobsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListImmediateJobsRequest input)
        {
            if (input == null) return false;
            if (this.XLanguage != input.XLanguage || (this.XLanguage != null && !this.XLanguage.Equals(input.XLanguage))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.JobName != input.JobName || (this.JobName != null && !this.JobName.Equals(input.JobName))) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.JobName != null) hashCode = hashCode * 59 + this.JobName.GetHashCode();
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
