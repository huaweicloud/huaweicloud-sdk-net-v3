using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// 创建Live2Vod任务
    /// </summary>
    public class CreateHarvestTaskInfoReq 
    {

        /// <summary>
        /// 频道推流域名
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// 组名或应用名
        /// </summary>
        [JsonProperty("app_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }

        /// <summary>
        /// 频道ID。频道唯一标识，为必填项。频道ID不建议输入下划线“_”，否则会影响转码和截图任务
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 开始时间。Unix时间戳：单位是秒
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? StartTime { get; set; }

        /// <summary>
        /// 结束时间。Unix时间戳：单位是秒
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? EndTime { get; set; }

        /// <summary>
        /// 事件名称。必选配置
        /// </summary>
        [JsonProperty("event_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EventName { get; set; }

        /// <summary>
        /// 任务描述，可选配置
        /// </summary>
        [JsonProperty("task_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskDesc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("package_info", NullValueHandling = NullValueHandling.Ignore)]
        public VodPackageInfo PackageInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateHarvestTaskInfoReq {\n");
            sb.Append("  domain: ").Append(Domain).Append("\n");
            sb.Append("  appName: ").Append(AppName).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  eventName: ").Append(EventName).Append("\n");
            sb.Append("  taskDesc: ").Append(TaskDesc).Append("\n");
            sb.Append("  packageInfo: ").Append(PackageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateHarvestTaskInfoReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateHarvestTaskInfoReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.AppName == input.AppName ||
                    (this.AppName != null &&
                    this.AppName.Equals(input.AppName))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.EventName == input.EventName ||
                    (this.EventName != null &&
                    this.EventName.Equals(input.EventName))
                ) && 
                (
                    this.TaskDesc == input.TaskDesc ||
                    (this.TaskDesc != null &&
                    this.TaskDesc.Equals(input.TaskDesc))
                ) && 
                (
                    this.PackageInfo == input.PackageInfo ||
                    (this.PackageInfo != null &&
                    this.PackageInfo.Equals(input.PackageInfo))
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
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.AppName != null)
                    hashCode = hashCode * 59 + this.AppName.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.TaskDesc != null)
                    hashCode = hashCode * 59 + this.TaskDesc.GetHashCode();
                if (this.PackageInfo != null)
                    hashCode = hashCode * 59 + this.PackageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
