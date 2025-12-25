using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsArtifact.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SecGuardTaskDetail 
    {

        /// <summary>
        /// **参数解释**: 任务id。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// **参数解释**: 任务名。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("task_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskName { get; set; }

        /// <summary>
        /// **参数解释**: 文件扫描路径。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("scan_path", NullValueHandling = NullValueHandling.Ignore)]
        public string ScanPath { get; set; }

        /// <summary>
        /// **参数解释**: 文件名。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        /// <summary>
        /// **参数解释**: 展示名称。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// **参数解释**: 路径。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// **参数解释**: 创建时间。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("created_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("opensource", NullValueHandling = NullValueHandling.Ignore)]
        public OpensourceCount Opensource { get; set; }

        /// <summary>
        /// **参数解释**: 病毒文件数。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("virus", NullValueHandling = NullValueHandling.Ignore)]
        public int? Virus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("malware", NullValueHandling = NullValueHandling.Ignore)]
        public MalwareCount Malware { get; set; }

        /// <summary>
        /// **参数解释**: 状态。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecGuardTaskDetail {\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  taskName: ").Append(TaskName).Append("\n");
            sb.Append("  scanPath: ").Append(ScanPath).Append("\n");
            sb.Append("  fileName: ").Append(FileName).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  path: ").Append(Path).Append("\n");
            sb.Append("  createdTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  opensource: ").Append(Opensource).Append("\n");
            sb.Append("  virus: ").Append(Virus).Append("\n");
            sb.Append("  malware: ").Append(Malware).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SecGuardTaskDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SecGuardTaskDetail input)
        {
            if (input == null) return false;
            if (this.TaskId != input.TaskId || (this.TaskId != null && !this.TaskId.Equals(input.TaskId))) return false;
            if (this.TaskName != input.TaskName || (this.TaskName != null && !this.TaskName.Equals(input.TaskName))) return false;
            if (this.ScanPath != input.ScanPath || (this.ScanPath != null && !this.ScanPath.Equals(input.ScanPath))) return false;
            if (this.FileName != input.FileName || (this.FileName != null && !this.FileName.Equals(input.FileName))) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.Path != input.Path || (this.Path != null && !this.Path.Equals(input.Path))) return false;
            if (this.CreatedTime != input.CreatedTime || (this.CreatedTime != null && !this.CreatedTime.Equals(input.CreatedTime))) return false;
            if (this.Opensource != input.Opensource || (this.Opensource != null && !this.Opensource.Equals(input.Opensource))) return false;
            if (this.Virus != input.Virus || (this.Virus != null && !this.Virus.Equals(input.Virus))) return false;
            if (this.Malware != input.Malware || (this.Malware != null && !this.Malware.Equals(input.Malware))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;

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
                if (this.TaskId != null) hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.TaskName != null) hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                if (this.ScanPath != null) hashCode = hashCode * 59 + this.ScanPath.GetHashCode();
                if (this.FileName != null) hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Path != null) hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.CreatedTime != null) hashCode = hashCode * 59 + this.CreatedTime.GetHashCode();
                if (this.Opensource != null) hashCode = hashCode * 59 + this.Opensource.GetHashCode();
                if (this.Virus != null) hashCode = hashCode * 59 + this.Virus.GetHashCode();
                if (this.Malware != null) hashCode = hashCode * 59 + this.Malware.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
