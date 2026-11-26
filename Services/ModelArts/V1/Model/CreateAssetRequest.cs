using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class CreateAssetRequest 
    {

        /// <summary>
        /// 工作空间ID。[获取方法请参见[查询工作空间列表](ListWorkspace.xml)。](tag:hc)未创建工作空间时默认值为“0”，存在创建并使用的工作空间，以实际取值为准。
        /// </summary>
        [SDKProperty("workspace_id", IsQuery = true)]
        [JsonProperty("workspace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// **参数解释**： OBS属主租户token。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("X-Storage-Token", IsHeader = true)]
        [JsonProperty("X-Storage-Token", NullValueHandling = NullValueHandling.Ignore)]
        public string XStorageToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public CreateAssetReq Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAssetRequest {\n");
            sb.Append("  workspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("  xStorageToken: ").Append(XStorageToken).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateAssetRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateAssetRequest input)
        {
            if (input == null) return false;
            if (this.WorkspaceId != input.WorkspaceId || (this.WorkspaceId != null && !this.WorkspaceId.Equals(input.WorkspaceId))) return false;
            if (this.XStorageToken != input.XStorageToken || (this.XStorageToken != null && !this.XStorageToken.Equals(input.XStorageToken))) return false;
            if (this.Body != input.Body || (this.Body != null && !this.Body.Equals(input.Body))) return false;

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
                if (this.WorkspaceId != null) hashCode = hashCode * 59 + this.WorkspaceId.GetHashCode();
                if (this.XStorageToken != null) hashCode = hashCode * 59 + this.XStorageToken.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
