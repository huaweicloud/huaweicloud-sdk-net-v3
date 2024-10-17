using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Mpc.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListQualityEnhanceDefaultTemplateResponse : SdkResponse
    {

        /// <summary>
        /// 任务列表
        /// </summary>
        [JsonProperty("task_array", NullValueHandling = NullValueHandling.Ignore)]
        public List<QualityEnhanceTemplateInfo> TaskArray { get; set; }

        /// <summary>
        /// 查询结果数量
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListQualityEnhanceDefaultTemplateResponse {\n");
            sb.Append("  taskArray: ").Append(TaskArray).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListQualityEnhanceDefaultTemplateResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListQualityEnhanceDefaultTemplateResponse input)
        {
            if (input == null) return false;
            if (this.TaskArray != input.TaskArray || (this.TaskArray != null && input.TaskArray != null && !this.TaskArray.SequenceEqual(input.TaskArray))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;

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
                if (this.TaskArray != null) hashCode = hashCode * 59 + this.TaskArray.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
