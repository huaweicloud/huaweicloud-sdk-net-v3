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
    /// 支持的访问策略。
    /// </summary>
    public class PolicyStatement 
    {

        /// <summary>
        /// 支持的访问策略，内置如下四种策略: * &#x60;DEFAULT_1&#x60;：&#x60;客户端访问存储&#x60; - 上传、下载; &#x60;云端访问存储&#x60; - 读写。   - action: PutObject、DeleteObject、GetObject   - roam_action: PutObject、DeleteObject、GetObject * &#x60;DEFAULT_2&#x60;：&#x60;客户端访问存储&#x60; - 下载; &#x60;云端访问存储&#x60; - 读写。   - action: GetObject   - roam_action: PutObject、DeleteObject、GetObject * &#x60;DEFAULT_3&#x60;：&#x60;客户端访问存储&#x60; - 上传; &#x60;云端访问存储&#x60; - 读写。   - action: PutObject、DeleteObject   - roam_action: PutObject、DeleteObject、GetObject * &#x60;DEFAULT_4&#x60;：&#x60;客户端访问存储&#x60; - 仅可查看列表,不允许上传下载; &#x60;云端访问存储&#x60; - 只读。   - action:    - roam_action: GetObject
        /// </summary>
        [JsonProperty("policy_statement_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyStatementId { get; set; }

        /// <summary>
        /// 客户端访问存储可操作的权限合集。 * &#x60;PutObject&#x60; -  上传、修改、重命名、移动。 * &#x60;GetObject&#x60; - 下载。 * &#x60;DeleteObject&#x60; - 删除。
        /// </summary>
        [JsonProperty("actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Actions { get; set; }

        /// <summary>
        /// 云端访问存储可操作的权限合集。 * &#x60;PutObject&#x60; -  上传、修改、重命名、移动。 * &#x60;GetObject&#x60; - 下载。 * &#x60;DeleteObject&#x60; - 删除。
        /// </summary>
        [JsonProperty("roam_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RoamActions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyStatement {\n");
            sb.Append("  policyStatementId: ").Append(PolicyStatementId).Append("\n");
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
            return this.Equals(input as PolicyStatement);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PolicyStatement input)
        {
            if (input == null) return false;
            if (this.PolicyStatementId != input.PolicyStatementId || (this.PolicyStatementId != null && !this.PolicyStatementId.Equals(input.PolicyStatementId))) return false;
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
                if (this.PolicyStatementId != null) hashCode = hashCode * 59 + this.PolicyStatementId.GetHashCode();
                if (this.Actions != null) hashCode = hashCode * 59 + this.Actions.GetHashCode();
                if (this.RoamActions != null) hashCode = hashCode * 59 + this.RoamActions.GetHashCode();
                return hashCode;
            }
        }
    }
}
