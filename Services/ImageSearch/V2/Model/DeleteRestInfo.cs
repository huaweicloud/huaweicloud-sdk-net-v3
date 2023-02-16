using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ImageSearch.V2.Model
{
    /// <summary>
    /// 删除数据的相关信息。
    /// </summary>
    public class DeleteRestInfo 
    {

        /// <summary>
        /// 删除数据列表。
        /// </summary>
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<DeleteRestInfoItems> Items { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("delete_info", NullValueHandling = NullValueHandling.Ignore)]
        public DeleteInfo DeleteInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteRestInfo {\n");
            sb.Append("  items: ").Append(Items).Append("\n");
            sb.Append("  deleteInfo: ").Append(DeleteInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteRestInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteRestInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
                (
                    this.DeleteInfo == input.DeleteInfo ||
                    (this.DeleteInfo != null &&
                    this.DeleteInfo.Equals(input.DeleteInfo))
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
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.DeleteInfo != null)
                    hashCode = hashCode * 59 + this.DeleteInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
