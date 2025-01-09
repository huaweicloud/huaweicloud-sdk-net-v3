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
    /// 桌面运行状态。
    /// </summary>
    public class DesktopRunStatisticsRsp 
    {

        /// <summary>
        /// 停止个数。
        /// </summary>
        [JsonProperty("stop_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? StopNum { get; set; }

        /// <summary>
        /// 运行中个数。
        /// </summary>
        [JsonProperty("active_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? ActiveNum { get; set; }

        /// <summary>
        /// 故障个数。
        /// </summary>
        [JsonProperty("error_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? ErrorNum { get; set; }

        /// <summary>
        /// 休眠个数。
        /// </summary>
        [JsonProperty("hibernated_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? HibernatedNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DesktopRunStatisticsRsp {\n");
            sb.Append("  stopNum: ").Append(StopNum).Append("\n");
            sb.Append("  activeNum: ").Append(ActiveNum).Append("\n");
            sb.Append("  errorNum: ").Append(ErrorNum).Append("\n");
            sb.Append("  hibernatedNum: ").Append(HibernatedNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DesktopRunStatisticsRsp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DesktopRunStatisticsRsp input)
        {
            if (input == null) return false;
            if (this.StopNum != input.StopNum || (this.StopNum != null && !this.StopNum.Equals(input.StopNum))) return false;
            if (this.ActiveNum != input.ActiveNum || (this.ActiveNum != null && !this.ActiveNum.Equals(input.ActiveNum))) return false;
            if (this.ErrorNum != input.ErrorNum || (this.ErrorNum != null && !this.ErrorNum.Equals(input.ErrorNum))) return false;
            if (this.HibernatedNum != input.HibernatedNum || (this.HibernatedNum != null && !this.HibernatedNum.Equals(input.HibernatedNum))) return false;

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
                if (this.StopNum != null) hashCode = hashCode * 59 + this.StopNum.GetHashCode();
                if (this.ActiveNum != null) hashCode = hashCode * 59 + this.ActiveNum.GetHashCode();
                if (this.ErrorNum != null) hashCode = hashCode * 59 + this.ErrorNum.GetHashCode();
                if (this.HibernatedNum != null) hashCode = hashCode * 59 + this.HibernatedNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
