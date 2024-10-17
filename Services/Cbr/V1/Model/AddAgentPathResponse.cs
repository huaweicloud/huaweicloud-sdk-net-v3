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
    public class AddAgentPathResponse : SdkResponse
    {

        /// <summary>
        /// 新添加成功的路径列表
        /// </summary>
        [JsonProperty("added", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Added { get; set; }

        /// <summary>
        /// 已经存在的路径列表
        /// </summary>
        [JsonProperty("existed", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Existed { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddAgentPathResponse {\n");
            sb.Append("  added: ").Append(Added).Append("\n");
            sb.Append("  existed: ").Append(Existed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddAgentPathResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddAgentPathResponse input)
        {
            if (input == null) return false;
            if (this.Added != input.Added || (this.Added != null && input.Added != null && !this.Added.SequenceEqual(input.Added))) return false;
            if (this.Existed != input.Existed || (this.Existed != null && input.Existed != null && !this.Existed.SequenceEqual(input.Existed))) return false;

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
                if (this.Added != null) hashCode = hashCode * 59 + this.Added.GetHashCode();
                if (this.Existed != null) hashCode = hashCode * 59 + this.Existed.GetHashCode();
                return hashCode;
            }
        }
    }
}
