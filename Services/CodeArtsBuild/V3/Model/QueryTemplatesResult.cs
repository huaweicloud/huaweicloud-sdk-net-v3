using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class QueryTemplatesResult 
    {

        /// <summary>
        /// 返回模板数量
        /// </summary>
        [JsonProperty("total_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalSize { get; set; }

        /// <summary>
        /// 模板信息列表
        /// </summary>
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<QueryTemplatesItems> Items { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryTemplatesResult {\n");
            sb.Append("  totalSize: ").Append(TotalSize).Append("\n");
            sb.Append("  items: ").Append(Items).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryTemplatesResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryTemplatesResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TotalSize == input.TotalSize ||
                    (this.TotalSize != null &&
                    this.TotalSize.Equals(input.TotalSize))
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
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
                if (this.TotalSize != null)
                    hashCode = hashCode * 59 + this.TotalSize.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                return hashCode;
            }
        }
    }
}
