using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateAssetEditTaskResponse : SdkResponse
    {

        /// <summary>
        /// 编辑任务ID 
        /// </summary>
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// 媒资ID 
        /// </summary>
        [JsonProperty("asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAssetEditTaskResponse {\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateAssetEditTaskResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateAssetEditTaskResponse input)
        {
            if (input == null) return false;
            if (this.TaskId != input.TaskId || (this.TaskId != null && !this.TaskId.Equals(input.TaskId))) return false;
            if (this.AssetId != input.AssetId || (this.AssetId != null && !this.AssetId.Equals(input.AssetId))) return false;

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
                if (this.AssetId != null) hashCode = hashCode * 59 + this.AssetId.GetHashCode();
                return hashCode;
            }
        }
    }
}
