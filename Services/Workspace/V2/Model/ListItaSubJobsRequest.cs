using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListItaSubJobsRequest 
    {

        /// <summary>
        /// 任务状态 - SUCCESS：成功。 - RUNNING：运行中。 - FAILED：失败。 - WAITING：等待。
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 任务ID。 “job_type”与“job_id”建议至少填写一个
        /// </summary>
        [SDKProperty("job_id", IsQuery = true)]
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 任务类型。 “job_type”与“job_id”建议至少填写一个  - createDesktops：创建桌面任务。  - applyWorkspace：开通云桌面服务。  - cancelWorkspace：注销云桌面服务。  - expandVolumes: 扩容磁盘。  - addVolumes: 添加磁盘。  - rebuildDesktops：重建桌面系统盘。  - createSnapshot：创建磁盘快照。  - deleteSnapshot：删除磁盘快照。  - deleteDesktops：删除桌面。  - desktopRejoinDomain：桌面重新加域。  - operateDesktops：操作桌面。  - restoreDesktopBySnapshot：使用快照恢复桌面。  - desktopToImage：桌面转镜像。  - attachDesktops：分配桌面。  - deleteVolumes：删除桌面磁盘（数据盘）。  - createWksSnapshot：创建快照。  - deleteWksSnapshot：删除快照。    - createDesktopPool：创建桌面池。  - expandDesktopPool：扩容桌面池。   - deleteDesktopPoolVolumes：桌面池删除桌面磁盘（数据盘）。  - rebuildDesktopPool：桌面池重建系统盘。  - addDesktopPoolVolumes：桌面池添加磁盘。  - detachDesktops：解绑桌面池桌面。  - attachDesktopPool：分配桌面池桌面。  - batchDetachDesktops：批量解绑桌面用户。  - executeDesktopsAction：桌面操作。  - changeDesktopNetwork：桌面切换网络。  - batchChangeDesktopNetwork：桌面切换网络。
        /// </summary>
        [SDKProperty("job_type", IsQuery = true)]
        [JsonProperty("job_type", NullValueHandling = NullValueHandling.Ignore)]
        public string JobType { get; set; }

        /// <summary>
        /// 桌面池ID。
        /// </summary>
        [SDKProperty("desktop_pool_id", IsQuery = true)]
        [JsonProperty("desktop_pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopPoolId { get; set; }

        /// <summary>
        /// 用于分页查询，取值范围0~1000，默认1000。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 用于分页查询，查询的起始记录序号，从0开始。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListItaSubJobsRequest {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  jobType: ").Append(JobType).Append("\n");
            sb.Append("  desktopPoolId: ").Append(DesktopPoolId).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListItaSubJobsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListItaSubJobsRequest input)
        {
            if (input == null) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.JobType != input.JobType || (this.JobType != null && !this.JobType.Equals(input.JobType))) return false;
            if (this.DesktopPoolId != input.DesktopPoolId || (this.DesktopPoolId != null && !this.DesktopPoolId.Equals(input.DesktopPoolId))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.JobType != null) hashCode = hashCode * 59 + this.JobType.GetHashCode();
                if (this.DesktopPoolId != null) hashCode = hashCode * 59 + this.DesktopPoolId.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                return hashCode;
            }
        }
    }
}
