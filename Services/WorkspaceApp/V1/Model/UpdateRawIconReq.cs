using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 更新应用图标
    /// </summary>
    public class UpdateRawIconReq 
    {

        /// <summary>
        /// 待更新的应用图标
        /// </summary>
        [JsonProperty("icon_content", NullValueHandling = NullValueHandling.Ignore)]
        public string IconContent { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateRawIconReq {\n");
            sb.Append("  iconContent: ").Append(IconContent).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateRawIconReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateRawIconReq input)
        {
            if (input == null) return false;
            if (this.IconContent != input.IconContent || (this.IconContent != null && !this.IconContent.Equals(input.IconContent))) return false;

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
                if (this.IconContent != null) hashCode = hashCode * 59 + this.IconContent.GetHashCode();
                return hashCode;
            }
        }
    }
}
