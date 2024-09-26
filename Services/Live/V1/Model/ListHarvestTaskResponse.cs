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
    /// Response Object
    /// </summary>
    public class ListHarvestTaskResponse : SdkResponse
    {

        /// <summary>
        /// 总任务数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 任务信息
        /// </summary>
        [JsonProperty("harvest_tasks", NullValueHandling = NullValueHandling.Ignore)]
        public List<HarvestTaskCreateSucRsp> HarvestTasks { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListHarvestTaskResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  harvestTasks: ").Append(HarvestTasks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListHarvestTaskResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListHarvestTaskResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.HarvestTasks == input.HarvestTasks ||
                    this.HarvestTasks != null &&
                    input.HarvestTasks != null &&
                    this.HarvestTasks.SequenceEqual(input.HarvestTasks)
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
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.HarvestTasks != null)
                    hashCode = hashCode * 59 + this.HarvestTasks.GetHashCode();
                return hashCode;
            }
        }
    }
}
