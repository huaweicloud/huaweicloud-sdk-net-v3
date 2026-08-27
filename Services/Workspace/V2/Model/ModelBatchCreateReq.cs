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
    /// 批量新增模型请求。
    /// </summary>
    public class ModelBatchCreateReq 
    {

        /// <summary>
        /// 模型列表。
        /// </summary>
        [JsonProperty("models", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateModelReq> Models { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelBatchCreateReq {\n");
            sb.Append("  models: ").Append(Models).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModelBatchCreateReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModelBatchCreateReq input)
        {
            if (input == null) return false;
            if (this.Models != input.Models || (this.Models != null && input.Models != null && !this.Models.SequenceEqual(input.Models))) return false;

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
                if (this.Models != null) hashCode = hashCode * 59 + this.Models.GetHashCode();
                return hashCode;
            }
        }
    }
}
