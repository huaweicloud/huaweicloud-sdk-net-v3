using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowPrecheckResultResponse : SdkResponse
    {

        /// <summary>
        /// 检查是否通过，0代表通过，1代表未通过
        /// </summary>
        [JsonProperty("result_code", NullValueHandling = NullValueHandling.Ignore)]
        public int? ResultCode { get; set; }

        /// <summary>
        /// 检查状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 检查结果更新时间
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// 是否展示数据库检查结果
        /// </summary>
        [JsonProperty("display", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Display { get; set; }

        /// <summary>
        /// 实例关联关系检查失败项
        /// </summary>
        [JsonProperty("instance_status_check_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InstanceStatusCheckList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("db_upgrade_precheck", NullValueHandling = NullValueHandling.Ignore)]
        public DBUpgradePrecheck DbUpgradePrecheck { get; set; }

        /// <summary>
        /// 检查结果下载链接
        /// </summary>
        [JsonProperty("download_link", NullValueHandling = NullValueHandling.Ignore)]
        public string DownloadLink { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-request-id", IsHeader = true)]
        [JsonProperty("X-request-id", NullValueHandling = NullValueHandling.Ignore)]
        public string XRequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowPrecheckResultResponse {\n");
            sb.Append("  resultCode: ").Append(ResultCode).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  display: ").Append(Display).Append("\n");
            sb.Append("  instanceStatusCheckList: ").Append(InstanceStatusCheckList).Append("\n");
            sb.Append("  dbUpgradePrecheck: ").Append(DbUpgradePrecheck).Append("\n");
            sb.Append("  downloadLink: ").Append(DownloadLink).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowPrecheckResultResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowPrecheckResultResponse input)
        {
            if (input == null) return false;
            if (this.ResultCode != input.ResultCode || (this.ResultCode != null && !this.ResultCode.Equals(input.ResultCode))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.Display != input.Display || (this.Display != null && !this.Display.Equals(input.Display))) return false;
            if (this.InstanceStatusCheckList != input.InstanceStatusCheckList || (this.InstanceStatusCheckList != null && input.InstanceStatusCheckList != null && !this.InstanceStatusCheckList.SequenceEqual(input.InstanceStatusCheckList))) return false;
            if (this.DbUpgradePrecheck != input.DbUpgradePrecheck || (this.DbUpgradePrecheck != null && !this.DbUpgradePrecheck.Equals(input.DbUpgradePrecheck))) return false;
            if (this.DownloadLink != input.DownloadLink || (this.DownloadLink != null && !this.DownloadLink.Equals(input.DownloadLink))) return false;
            if (this.XRequestId != input.XRequestId || (this.XRequestId != null && !this.XRequestId.Equals(input.XRequestId))) return false;

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
                if (this.ResultCode != null) hashCode = hashCode * 59 + this.ResultCode.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Display != null) hashCode = hashCode * 59 + this.Display.GetHashCode();
                if (this.InstanceStatusCheckList != null) hashCode = hashCode * 59 + this.InstanceStatusCheckList.GetHashCode();
                if (this.DbUpgradePrecheck != null) hashCode = hashCode * 59 + this.DbUpgradePrecheck.GetHashCode();
                if (this.DownloadLink != null) hashCode = hashCode * 59 + this.DownloadLink.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
