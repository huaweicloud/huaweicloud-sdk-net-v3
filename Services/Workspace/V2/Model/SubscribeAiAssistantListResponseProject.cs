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
    /// 订阅项目信息。
    /// </summary>
    public class SubscribeAiAssistantListResponseProject 
    {

        /// <summary>
        /// 项目ID。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// ai 功能是否启用。 * true： 启用 * false： 不启用
        /// </summary>
        [JsonProperty("ai_func", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AiFunc { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscribeAiAssistantListResponseProject {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  aiFunc: ").Append(AiFunc).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubscribeAiAssistantListResponseProject);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SubscribeAiAssistantListResponseProject input)
        {
            if (input == null) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.AiFunc != input.AiFunc || (this.AiFunc != null && !this.AiFunc.Equals(input.AiFunc))) return false;

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
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.AiFunc != null) hashCode = hashCode * 59 + this.AiFunc.GetHashCode();
                return hashCode;
            }
        }
    }
}
