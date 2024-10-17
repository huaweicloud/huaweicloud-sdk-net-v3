using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ims.V2.Model
{
    /// <summary>
    /// 批量添加镜像成员body
    /// </summary>
    public class BatchAddMembersRequestBody 
    {

        /// <summary>
        /// 镜像ID列表
        /// </summary>
        [JsonProperty("images", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Images { get; set; }

        /// <summary>
        /// 项目ID列表
        /// </summary>
        [JsonProperty("projects", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Projects { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchAddMembersRequestBody {\n");
            sb.Append("  images: ").Append(Images).Append("\n");
            sb.Append("  projects: ").Append(Projects).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchAddMembersRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchAddMembersRequestBody input)
        {
            if (input == null) return false;
            if (this.Images != input.Images || (this.Images != null && input.Images != null && !this.Images.SequenceEqual(input.Images))) return false;
            if (this.Projects != input.Projects || (this.Projects != null && input.Projects != null && !this.Projects.SequenceEqual(input.Projects))) return false;

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
                if (this.Images != null) hashCode = hashCode * 59 + this.Images.GetHashCode();
                if (this.Projects != null) hashCode = hashCode * 59 + this.Projects.GetHashCode();
                return hashCode;
            }
        }
    }
}
