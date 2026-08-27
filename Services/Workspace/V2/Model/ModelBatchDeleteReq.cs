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
    /// 批量删除模型请求。
    /// </summary>
    public class ModelBatchDeleteReq 
    {

        /// <summary>
        /// 模型id列表。
        /// </summary>
        [JsonProperty("model_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ModelIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelBatchDeleteReq {\n");
            sb.Append("  modelIds: ").Append(ModelIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModelBatchDeleteReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModelBatchDeleteReq input)
        {
            if (input == null) return false;
            if (this.ModelIds != input.ModelIds || (this.ModelIds != null && input.ModelIds != null && !this.ModelIds.SequenceEqual(input.ModelIds))) return false;

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
                if (this.ModelIds != null) hashCode = hashCode * 59 + this.ModelIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
