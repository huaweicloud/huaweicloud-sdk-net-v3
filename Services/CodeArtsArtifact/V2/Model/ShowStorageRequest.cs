using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsArtifact.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowStorageRequest 
    {

        /// <summary>
        /// 类型列表
        /// </summary>
        [SDKProperty("format_list", IsQuery = true)]
        [JsonProperty("format_list", NullValueHandling = NullValueHandling.Ignore)]
        public string FormatList { get; set; }

        /// <summary>
        /// 是否在项目中
        /// </summary>
        [SDKProperty("in_project", IsQuery = true)]
        [JsonProperty("in_project", NullValueHandling = NullValueHandling.Ignore)]
        public string InProject { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowStorageRequest {\n");
            sb.Append("  formatList: ").Append(FormatList).Append("\n");
            sb.Append("  inProject: ").Append(InProject).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowStorageRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowStorageRequest input)
        {
            if (input == null) return false;
            if (this.FormatList != input.FormatList || (this.FormatList != null && !this.FormatList.Equals(input.FormatList))) return false;
            if (this.InProject != input.InProject || (this.InProject != null && !this.InProject.Equals(input.InProject))) return false;

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
                if (this.FormatList != null) hashCode = hashCode * 59 + this.FormatList.GetHashCode();
                if (this.InProject != null) hashCode = hashCode * 59 + this.InProject.GetHashCode();
                return hashCode;
            }
        }
    }
}
