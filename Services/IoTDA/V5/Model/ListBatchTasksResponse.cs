using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListBatchTasksResponse : SdkResponse
    {

        /// <summary>
        /// 批量任务列表。
        /// </summary>
        [JsonProperty("batchtasks", NullValueHandling = NullValueHandling.Ignore)]
        public List<Task> Batchtasks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public Page Page { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListBatchTasksResponse {\n");
            sb.Append("  batchtasks: ").Append(Batchtasks).Append("\n");
            sb.Append("  page: ").Append(Page).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListBatchTasksResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListBatchTasksResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Batchtasks == input.Batchtasks ||
                    this.Batchtasks != null &&
                    input.Batchtasks != null &&
                    this.Batchtasks.SequenceEqual(input.Batchtasks)
                ) && 
                (
                    this.Page == input.Page ||
                    (this.Page != null &&
                    this.Page.Equals(input.Page))
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
                if (this.Batchtasks != null)
                    hashCode = hashCode * 59 + this.Batchtasks.GetHashCode();
                if (this.Page != null)
                    hashCode = hashCode * 59 + this.Page.GetHashCode();
                return hashCode;
            }
        }
    }
}
