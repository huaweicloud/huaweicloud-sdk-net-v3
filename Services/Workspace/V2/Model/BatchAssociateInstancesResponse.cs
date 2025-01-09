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
    /// Response Object
    /// </summary>
    public class BatchAssociateInstancesResponse : SdkResponse
    {

        /// <summary>
        /// 分配的维度，当前支持“用户为维度”、“桌面为维度”两种。
        /// </summary>
        [JsonProperty("assign_dimension", NullValueHandling = NullValueHandling.Ignore)]
        public string AssignDimension { get; set; }

        /// <summary>
        /// 桌面维度结果，如果assign_dimension为DEKSTOP，那么取这个结果。
        /// </summary>
        [JsonProperty("desktop", NullValueHandling = NullValueHandling.Ignore)]
        public List<DesktopDimensionAttachInfo> Desktop { get; set; }

        /// <summary>
        /// 用户维度结果，如果assign_dimension为USER，那么取这个结果。
        /// </summary>
        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserDimensionAttachInfo> User { get; set; }

        /// <summary>
        /// 桌面分配关系。
        /// </summary>
        [JsonProperty("desktops_attach_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<AttachInstancesDesktopInfo> DesktopsAttachInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchAssociateInstancesResponse {\n");
            sb.Append("  assignDimension: ").Append(AssignDimension).Append("\n");
            sb.Append("  desktop: ").Append(Desktop).Append("\n");
            sb.Append("  user: ").Append(User).Append("\n");
            sb.Append("  desktopsAttachInfos: ").Append(DesktopsAttachInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchAssociateInstancesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchAssociateInstancesResponse input)
        {
            if (input == null) return false;
            if (this.AssignDimension != input.AssignDimension || (this.AssignDimension != null && !this.AssignDimension.Equals(input.AssignDimension))) return false;
            if (this.Desktop != input.Desktop || (this.Desktop != null && input.Desktop != null && !this.Desktop.SequenceEqual(input.Desktop))) return false;
            if (this.User != input.User || (this.User != null && input.User != null && !this.User.SequenceEqual(input.User))) return false;
            if (this.DesktopsAttachInfos != input.DesktopsAttachInfos || (this.DesktopsAttachInfos != null && input.DesktopsAttachInfos != null && !this.DesktopsAttachInfos.SequenceEqual(input.DesktopsAttachInfos))) return false;

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
                if (this.AssignDimension != null) hashCode = hashCode * 59 + this.AssignDimension.GetHashCode();
                if (this.Desktop != null) hashCode = hashCode * 59 + this.Desktop.GetHashCode();
                if (this.User != null) hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.DesktopsAttachInfos != null) hashCode = hashCode * 59 + this.DesktopsAttachInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
