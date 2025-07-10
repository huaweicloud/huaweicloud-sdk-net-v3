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
    /// 批量桌面删除标签。
    /// </summary>
    public class BatchDeleteDesktopsTagsReq 
    {

        /// <summary>
        /// 桌面（桌面携带标签列表）列表。批量操作时非法桌面ID会过滤不做处理。
        /// </summary>
        [JsonProperty("desktops", NullValueHandling = NullValueHandling.Ignore)]
        public List<DesktopTagsInfo> Desktops { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteDesktopsTagsReq {\n");
            sb.Append("  desktops: ").Append(Desktops).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteDesktopsTagsReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteDesktopsTagsReq input)
        {
            if (input == null) return false;
            if (this.Desktops != input.Desktops || (this.Desktops != null && input.Desktops != null && !this.Desktops.SequenceEqual(input.Desktops))) return false;

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
                if (this.Desktops != null) hashCode = hashCode * 59 + this.Desktops.GetHashCode();
                return hashCode;
            }
        }
    }
}
