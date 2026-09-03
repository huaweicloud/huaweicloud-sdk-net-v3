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
    /// 
    /// </summary>
    public class BasicInfoVo 
    {

        /// <summary>
        /// 采集间隔以秒为单位
        /// </summary>
        [JsonProperty("collect_interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? CollectInterval { get; set; }

        /// <summary>
        /// 子任务名称
        /// </summary>
        [JsonProperty("sub_task_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SubTaskName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BasicInfoVo {\n");
            sb.Append("  collectInterval: ").Append(CollectInterval).Append("\n");
            sb.Append("  subTaskName: ").Append(SubTaskName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BasicInfoVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BasicInfoVo input)
        {
            if (input == null) return false;
            if (this.CollectInterval != input.CollectInterval || (this.CollectInterval != null && !this.CollectInterval.Equals(input.CollectInterval))) return false;
            if (this.SubTaskName != input.SubTaskName || (this.SubTaskName != null && !this.SubTaskName.Equals(input.SubTaskName))) return false;

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
                if (this.CollectInterval != null) hashCode = hashCode * 59 + this.CollectInterval.GetHashCode();
                if (this.SubTaskName != null) hashCode = hashCode * 59 + this.SubTaskName.GetHashCode();
                return hashCode;
            }
        }
    }
}
