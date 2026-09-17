using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 删除测试套件参数
    /// </summary>
    public class DeleteTaskInfo 
    {

        /// <summary>
        /// 分支/迭代id
        /// </summary>
        [JsonProperty("version_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionUri { get; set; }

        /// <summary>
        /// 任务id数组
        /// </summary>
        [JsonProperty("task_uris", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TaskUris { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteTaskInfo {\n");
            sb.Append("  versionUri: ").Append(VersionUri).Append("\n");
            sb.Append("  taskUris: ").Append(TaskUris).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteTaskInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteTaskInfo input)
        {
            if (input == null) return false;
            if (this.VersionUri != input.VersionUri || (this.VersionUri != null && !this.VersionUri.Equals(input.VersionUri))) return false;
            if (this.TaskUris != input.TaskUris || (this.TaskUris != null && input.TaskUris != null && !this.TaskUris.SequenceEqual(input.TaskUris))) return false;

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
                if (this.VersionUri != null) hashCode = hashCode * 59 + this.VersionUri.GetHashCode();
                if (this.TaskUris != null) hashCode = hashCode * 59 + this.TaskUris.GetHashCode();
                return hashCode;
            }
        }
    }
}
