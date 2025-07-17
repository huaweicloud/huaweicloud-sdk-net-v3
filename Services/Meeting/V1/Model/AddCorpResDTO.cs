using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 企业的资源信息。
    /// </summary>
    public class AddCorpResDTO 
    {

        /// <summary>
        /// 企业待添加的资源列表。
        /// </summary>
        [JsonProperty("resource", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceDTO> Resource { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddCorpResDTO {\n");
            sb.Append("  resource: ").Append(Resource).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddCorpResDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddCorpResDTO input)
        {
            if (input == null) return false;
            if (this.Resource != input.Resource || (this.Resource != null && input.Resource != null && !this.Resource.SequenceEqual(input.Resource))) return false;

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
                if (this.Resource != null) hashCode = hashCode * 59 + this.Resource.GetHashCode();
                return hashCode;
            }
        }
    }
}
