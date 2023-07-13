using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class RemoveAgentPathResponse : SdkResponse
    {

        /// <summary>
        /// 移除的路径列表 
        /// </summary>
        [JsonProperty("removed", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Removed { get; set; }

        /// <summary>
        /// 不存在的路径
        /// </summary>
        [JsonProperty("not_existed", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NotExisted { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemoveAgentPathResponse {\n");
            sb.Append("  removed: ").Append(Removed).Append("\n");
            sb.Append("  notExisted: ").Append(NotExisted).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RemoveAgentPathResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RemoveAgentPathResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Removed == input.Removed ||
                    this.Removed != null &&
                    input.Removed != null &&
                    this.Removed.SequenceEqual(input.Removed)
                ) && 
                (
                    this.NotExisted == input.NotExisted ||
                    this.NotExisted != null &&
                    input.NotExisted != null &&
                    this.NotExisted.SequenceEqual(input.NotExisted)
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
                if (this.Removed != null)
                    hashCode = hashCode * 59 + this.Removed.GetHashCode();
                if (this.NotExisted != null)
                    hashCode = hashCode * 59 + this.NotExisted.GetHashCode();
                return hashCode;
            }
        }
    }
}
