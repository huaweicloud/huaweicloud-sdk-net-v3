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
    /// 桌面池状态统计。
    /// </summary>
    public class DesktopPoolStatistics 
    {

        /// <summary>
        /// 桌面池id。
        /// </summary>
        [JsonProperty("desktop_pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopPoolId { get; set; }

        /// <summary>
        /// 桌面池名称。
        /// </summary>
        [JsonProperty("desktop_pool_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopPoolName { get; set; }

        /// <summary>
        /// 桌面总数。
        /// </summary>
        [JsonProperty("total_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("attach_statistics", NullValueHandling = NullValueHandling.Ignore)]
        public AttachStatistics AttachStatistics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("run_state_statistics", NullValueHandling = NullValueHandling.Ignore)]
        public DesktopRunStatisticsRsp RunStateStatistics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("login_state_statistics", NullValueHandling = NullValueHandling.Ignore)]
        public DesktopLoginStatisticsRsp LoginStateStatistics { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DesktopPoolStatistics {\n");
            sb.Append("  desktopPoolId: ").Append(DesktopPoolId).Append("\n");
            sb.Append("  desktopPoolName: ").Append(DesktopPoolName).Append("\n");
            sb.Append("  totalNum: ").Append(TotalNum).Append("\n");
            sb.Append("  attachStatistics: ").Append(AttachStatistics).Append("\n");
            sb.Append("  runStateStatistics: ").Append(RunStateStatistics).Append("\n");
            sb.Append("  loginStateStatistics: ").Append(LoginStateStatistics).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DesktopPoolStatistics);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DesktopPoolStatistics input)
        {
            if (input == null) return false;
            if (this.DesktopPoolId != input.DesktopPoolId || (this.DesktopPoolId != null && !this.DesktopPoolId.Equals(input.DesktopPoolId))) return false;
            if (this.DesktopPoolName != input.DesktopPoolName || (this.DesktopPoolName != null && !this.DesktopPoolName.Equals(input.DesktopPoolName))) return false;
            if (this.TotalNum != input.TotalNum || (this.TotalNum != null && !this.TotalNum.Equals(input.TotalNum))) return false;
            if (this.AttachStatistics != input.AttachStatistics || (this.AttachStatistics != null && !this.AttachStatistics.Equals(input.AttachStatistics))) return false;
            if (this.RunStateStatistics != input.RunStateStatistics || (this.RunStateStatistics != null && !this.RunStateStatistics.Equals(input.RunStateStatistics))) return false;
            if (this.LoginStateStatistics != input.LoginStateStatistics || (this.LoginStateStatistics != null && !this.LoginStateStatistics.Equals(input.LoginStateStatistics))) return false;

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
                if (this.DesktopPoolId != null) hashCode = hashCode * 59 + this.DesktopPoolId.GetHashCode();
                if (this.DesktopPoolName != null) hashCode = hashCode * 59 + this.DesktopPoolName.GetHashCode();
                if (this.TotalNum != null) hashCode = hashCode * 59 + this.TotalNum.GetHashCode();
                if (this.AttachStatistics != null) hashCode = hashCode * 59 + this.AttachStatistics.GetHashCode();
                if (this.RunStateStatistics != null) hashCode = hashCode * 59 + this.RunStateStatistics.GetHashCode();
                if (this.LoginStateStatistics != null) hashCode = hashCode * 59 + this.LoginStateStatistics.GetHashCode();
                return hashCode;
            }
        }
    }
}
