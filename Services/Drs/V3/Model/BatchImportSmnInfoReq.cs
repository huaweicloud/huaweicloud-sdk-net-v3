using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// 录入、修改收件方式与信息请求体。
    /// </summary>
    public class BatchImportSmnInfoReq 
    {

        /// <summary>
        /// 任务信息
        /// </summary>
        [JsonProperty("jobs", NullValueHandling = NullValueHandling.Ignore)]
        public List<SelectedSetAlarmTaskReq> Jobs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("alarm_notify_info", NullValueHandling = NullValueHandling.Ignore)]
        public BatchSetAlarmNotifyInfo AlarmNotifyInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchImportSmnInfoReq {\n");
            sb.Append("  jobs: ").Append(Jobs).Append("\n");
            sb.Append("  alarmNotifyInfo: ").Append(AlarmNotifyInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchImportSmnInfoReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchImportSmnInfoReq input)
        {
            if (input == null) return false;
            if (this.Jobs != input.Jobs || (this.Jobs != null && input.Jobs != null && !this.Jobs.SequenceEqual(input.Jobs))) return false;
            if (this.AlarmNotifyInfo != input.AlarmNotifyInfo || (this.AlarmNotifyInfo != null && !this.AlarmNotifyInfo.Equals(input.AlarmNotifyInfo))) return false;

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
                if (this.Jobs != null) hashCode = hashCode * 59 + this.Jobs.GetHashCode();
                if (this.AlarmNotifyInfo != null) hashCode = hashCode * 59 + this.AlarmNotifyInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
