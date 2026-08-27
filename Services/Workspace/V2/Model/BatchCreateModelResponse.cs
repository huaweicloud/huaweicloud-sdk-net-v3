using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class BatchCreateModelResponse : SdkResponse
    {

        /// <summary>
        /// 已创建的模型列表。
        /// </summary>
        [JsonProperty("created_models", NullValueHandling = NullValueHandling.Ignore)]
        public List<ModelItemResp> CreatedModels { get; set; }

        /// <summary>
        /// 创建总数。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchCreateModelResponse {\n");
            sb.Append("  createdModels: ").Append(CreatedModels).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchCreateModelResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchCreateModelResponse input)
        {
            if (input == null) return false;
            if (this.CreatedModels != input.CreatedModels || (this.CreatedModels != null && input.CreatedModels != null && !this.CreatedModels.SequenceEqual(input.CreatedModels))) return false;
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
                if (this.CreatedModels != null) hashCode = hashCode * 59 + this.CreatedModels.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
