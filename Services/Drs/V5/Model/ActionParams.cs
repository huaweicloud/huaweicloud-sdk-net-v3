using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 操作任务动作参数。
    /// </summary>
    public class ActionParams 
    {

        /// <summary>
        /// 测试连接数据库信息。
        /// </summary>
        [JsonProperty("endpoints", NullValueHandling = NullValueHandling.Ignore)]
        public List<JobEndpointInfo> Endpoints { get; set; }

        /// <summary>
        /// 预检查模式。
        /// </summary>
        [JsonProperty("precheck_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string PrecheckMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("skip_precheck_info", NullValueHandling = NullValueHandling.Ignore)]
        public SkipPreCheckInfo SkipPrecheckInfo { get; set; }

        /// <summary>
        /// 任务暂停模式。
        /// </summary>
        [JsonProperty("pause_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string PauseMode { get; set; }

        /// <summary>
        /// 任务定时启动时间。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("compare_task_param", NullValueHandling = NullValueHandling.Ignore)]
        public CompareTaskParams CompareTaskParam { get; set; }

        /// <summary>
        /// 再编辑任务启动时取值true。
        /// </summary>
        [JsonProperty("is_sync_re_edit", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSyncReEdit { get; set; }

        /// <summary>
        /// 强制结束任务时取值true。
        /// </summary>
        [JsonProperty("force_delete", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ForceDelete { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActionParams {\n");
            sb.Append("  endpoints: ").Append(Endpoints).Append("\n");
            sb.Append("  precheckMode: ").Append(PrecheckMode).Append("\n");
            sb.Append("  skipPrecheckInfo: ").Append(SkipPrecheckInfo).Append("\n");
            sb.Append("  pauseMode: ").Append(PauseMode).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  compareTaskParam: ").Append(CompareTaskParam).Append("\n");
            sb.Append("  isSyncReEdit: ").Append(IsSyncReEdit).Append("\n");
            sb.Append("  forceDelete: ").Append(ForceDelete).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ActionParams);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ActionParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Endpoints == input.Endpoints ||
                    this.Endpoints != null &&
                    input.Endpoints != null &&
                    this.Endpoints.SequenceEqual(input.Endpoints)
                ) && 
                (
                    this.PrecheckMode == input.PrecheckMode ||
                    (this.PrecheckMode != null &&
                    this.PrecheckMode.Equals(input.PrecheckMode))
                ) && 
                (
                    this.SkipPrecheckInfo == input.SkipPrecheckInfo ||
                    (this.SkipPrecheckInfo != null &&
                    this.SkipPrecheckInfo.Equals(input.SkipPrecheckInfo))
                ) && 
                (
                    this.PauseMode == input.PauseMode ||
                    (this.PauseMode != null &&
                    this.PauseMode.Equals(input.PauseMode))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.CompareTaskParam == input.CompareTaskParam ||
                    (this.CompareTaskParam != null &&
                    this.CompareTaskParam.Equals(input.CompareTaskParam))
                ) && 
                (
                    this.IsSyncReEdit == input.IsSyncReEdit ||
                    (this.IsSyncReEdit != null &&
                    this.IsSyncReEdit.Equals(input.IsSyncReEdit))
                ) && 
                (
                    this.ForceDelete == input.ForceDelete ||
                    (this.ForceDelete != null &&
                    this.ForceDelete.Equals(input.ForceDelete))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Endpoints != null)
                    hashCode = hashCode * 59 + this.Endpoints.GetHashCode();
                if (this.PrecheckMode != null)
                    hashCode = hashCode * 59 + this.PrecheckMode.GetHashCode();
                if (this.SkipPrecheckInfo != null)
                    hashCode = hashCode * 59 + this.SkipPrecheckInfo.GetHashCode();
                if (this.PauseMode != null)
                    hashCode = hashCode * 59 + this.PauseMode.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.CompareTaskParam != null)
                    hashCode = hashCode * 59 + this.CompareTaskParam.GetHashCode();
                if (this.IsSyncReEdit != null)
                    hashCode = hashCode * 59 + this.IsSyncReEdit.GetHashCode();
                if (this.ForceDelete != null)
                    hashCode = hashCode * 59 + this.ForceDelete.GetHashCode();
                return hashCode;
            }
        }
    }
}
