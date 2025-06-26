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
    /// 新增或更新存储目录访问权限自定义策略(已存在自定义策略时会对已有策略更新)。
    /// </summary>
    public class CreateOrUpdateStoragePolicyStatementReq 
    {

        /// <summary>
        /// 客户端访问存储可操作的权限合集 允许为空，为空时配置了该策略的用户，通过云办公客户端接入后仅可查看文件列表，不可上传下载。 * &#x60;PutObject&#x60; -  上传、修改、重命名、移动。 * &#x60;DeleteObject&#x60; - 删除。 * &#x60;GetObject&#x60; - 下载。 注：PutObject和DeleteObject必须同时设置,不支持仅设置其中一个。
        /// </summary>
        [JsonProperty("actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Actions { get; set; }

        /// <summary>
        /// 云端访问存储可操作的权限合集，不允许为空。 * &#x60;PutObject&#x60; -  上传、修改、重命名、移动。 * &#x60;DeleteObject&#x60; - 删除。 * &#x60;GetObject&#x60; - 下载 。          注：PutObject和DeleteObject必须同时设置,不支持仅设置其中一个。
        /// </summary>
        [JsonProperty("roam_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RoamActions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateOrUpdateStoragePolicyStatementReq {\n");
            sb.Append("  actions: ").Append(Actions).Append("\n");
            sb.Append("  roamActions: ").Append(RoamActions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateOrUpdateStoragePolicyStatementReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateOrUpdateStoragePolicyStatementReq input)
        {
            if (input == null) return false;
            if (this.Actions != input.Actions || (this.Actions != null && input.Actions != null && !this.Actions.SequenceEqual(input.Actions))) return false;
            if (this.RoamActions != input.RoamActions || (this.RoamActions != null && input.RoamActions != null && !this.RoamActions.SequenceEqual(input.RoamActions))) return false;

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
                if (this.Actions != null) hashCode = hashCode * 59 + this.Actions.GetHashCode();
                if (this.RoamActions != null) hashCode = hashCode * 59 + this.RoamActions.GetHashCode();
                return hashCode;
            }
        }
    }
}
