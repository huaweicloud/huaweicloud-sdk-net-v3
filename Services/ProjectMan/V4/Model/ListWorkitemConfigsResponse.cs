using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListWorkitemConfigsResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 已关闭工作项只读模式。 **取值范围：** true：无法进行编辑或修改。 false：可以进行编辑或修改。
        /// </summary>
        [JsonProperty("closed_workitem_readonly_mode", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ClosedWorkitemReadonlyMode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListWorkitemConfigsResponse {\n");
            sb.Append("  closedWorkitemReadonlyMode: ").Append(ClosedWorkitemReadonlyMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListWorkitemConfigsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListWorkitemConfigsResponse input)
        {
            if (input == null) return false;
            if (this.ClosedWorkitemReadonlyMode != input.ClosedWorkitemReadonlyMode || (this.ClosedWorkitemReadonlyMode != null && !this.ClosedWorkitemReadonlyMode.Equals(input.ClosedWorkitemReadonlyMode))) return false;

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
                if (this.ClosedWorkitemReadonlyMode != null) hashCode = hashCode * 59 + this.ClosedWorkitemReadonlyMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
