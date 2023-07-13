using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsDeploy.V2.Model
{
    /// <summary>
    /// 应用和AOM应用组件对应关系
    /// </summary>
    public class AppComponentDao 
    {

        /// <summary>
        /// 部署任务id
        /// </summary>
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// AOM应用id
        /// </summary>
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// AOM应用名称
        /// </summary>
        [JsonProperty("app_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }

        /// <summary>
        /// AOM应用组件id
        /// </summary>
        [JsonProperty("comp_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CompId { get; set; }

        /// <summary>
        /// AOM应用组件名称
        /// </summary>
        [JsonProperty("comp_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CompName { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 局点信息
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// AOM应用组件是否生效，0表示初始化，1表示执行成功，已生效
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppComponentDao {\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  appName: ").Append(AppName).Append("\n");
            sb.Append("  compId: ").Append(CompId).Append("\n");
            sb.Append("  compName: ").Append(CompName).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AppComponentDao);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AppComponentDao input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TaskId == input.TaskId ||
                    (this.TaskId != null &&
                    this.TaskId.Equals(input.TaskId))
                ) && 
                (
                    this.AppId == input.AppId ||
                    (this.AppId != null &&
                    this.AppId.Equals(input.AppId))
                ) && 
                (
                    this.AppName == input.AppName ||
                    (this.AppName != null &&
                    this.AppName.Equals(input.AppName))
                ) && 
                (
                    this.CompId == input.CompId ||
                    (this.CompId != null &&
                    this.CompId.Equals(input.CompId))
                ) && 
                (
                    this.CompName == input.CompName ||
                    (this.CompName != null &&
                    this.CompName.Equals(input.CompName))
                ) && 
                (
                    this.DomainId == input.DomainId ||
                    (this.DomainId != null &&
                    this.DomainId.Equals(input.DomainId))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
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
                if (this.TaskId != null)
                    hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.AppId != null)
                    hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.AppName != null)
                    hashCode = hashCode * 59 + this.AppName.GetHashCode();
                if (this.CompId != null)
                    hashCode = hashCode * 59 + this.CompId.GetHashCode();
                if (this.CompName != null)
                    hashCode = hashCode * 59 + this.CompName.GetHashCode();
                if (this.DomainId != null)
                    hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                return hashCode;
            }
        }
    }
}
