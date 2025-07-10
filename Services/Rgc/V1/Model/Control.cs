using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rgc.V1.Model
{
    /// <summary>
    /// 控制策略。
    /// </summary>
    public class Control 
    {

        /// <summary>
        /// 控制策略ID。
        /// </summary>
        [JsonProperty("identifier", NullValueHandling = NullValueHandling.Ignore)]
        public string Identifier { get; set; }

        /// <summary>
        /// 控制策略名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 控制策略描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 控制策略必须性。
        /// </summary>
        [JsonProperty("guidance", NullValueHandling = NullValueHandling.Ignore)]
        public string Guidance { get; set; }

        /// <summary>
        /// 治理资源。
        /// </summary>
        [JsonProperty("resource", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Resource { get; set; }

        /// <summary>
        /// 治理策略来自的框架。
        /// </summary>
        [JsonProperty("framework", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Framework { get; set; }

        /// <summary>
        /// 控制策略所属服务。
        /// </summary>
        [JsonProperty("service", NullValueHandling = NullValueHandling.Ignore)]
        public string Service { get; set; }

        /// <summary>
        /// 服务控制策略（SCP），配置规则。
        /// </summary>
        [JsonProperty("implementation", NullValueHandling = NullValueHandling.Ignore)]
        public string Implementation { get; set; }

        /// <summary>
        /// 控制策略类型。包括主动性控制策略Proactive、检测性控制策略Detective、预防性控制策略Preventive。
        /// </summary>
        [JsonProperty("behavior", NullValueHandling = NullValueHandling.Ignore)]
        public string Behavior { get; set; }

        /// <summary>
        /// 纳管账号的创建来源，包括CUSTOM和RGC。
        /// </summary>
        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public string Owner { get; set; }

        /// <summary>
        /// 控制策略严重性。
        /// </summary>
        [JsonProperty("severity", NullValueHandling = NullValueHandling.Ignore)]
        public string Severity { get; set; }

        /// <summary>
        /// 控制策略目标。
        /// </summary>
        [JsonProperty("control_objective", NullValueHandling = NullValueHandling.Ignore)]
        public string ControlObjective { get; set; }

        /// <summary>
        /// 控制策略版本。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 控制策略发布时间。
        /// </summary>
        [JsonProperty("release_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ReleaseDate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Control {\n");
            sb.Append("  identifier: ").Append(Identifier).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  guidance: ").Append(Guidance).Append("\n");
            sb.Append("  resource: ").Append(Resource).Append("\n");
            sb.Append("  framework: ").Append(Framework).Append("\n");
            sb.Append("  service: ").Append(Service).Append("\n");
            sb.Append("  implementation: ").Append(Implementation).Append("\n");
            sb.Append("  behavior: ").Append(Behavior).Append("\n");
            sb.Append("  owner: ").Append(Owner).Append("\n");
            sb.Append("  severity: ").Append(Severity).Append("\n");
            sb.Append("  controlObjective: ").Append(ControlObjective).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  releaseDate: ").Append(ReleaseDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Control);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Control input)
        {
            if (input == null) return false;
            if (this.Identifier != input.Identifier || (this.Identifier != null && !this.Identifier.Equals(input.Identifier))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Guidance != input.Guidance || (this.Guidance != null && !this.Guidance.Equals(input.Guidance))) return false;
            if (this.Resource != input.Resource || (this.Resource != null && input.Resource != null && !this.Resource.SequenceEqual(input.Resource))) return false;
            if (this.Framework != input.Framework || (this.Framework != null && input.Framework != null && !this.Framework.SequenceEqual(input.Framework))) return false;
            if (this.Service != input.Service || (this.Service != null && !this.Service.Equals(input.Service))) return false;
            if (this.Implementation != input.Implementation || (this.Implementation != null && !this.Implementation.Equals(input.Implementation))) return false;
            if (this.Behavior != input.Behavior || (this.Behavior != null && !this.Behavior.Equals(input.Behavior))) return false;
            if (this.Owner != input.Owner || (this.Owner != null && !this.Owner.Equals(input.Owner))) return false;
            if (this.Severity != input.Severity || (this.Severity != null && !this.Severity.Equals(input.Severity))) return false;
            if (this.ControlObjective != input.ControlObjective || (this.ControlObjective != null && !this.ControlObjective.Equals(input.ControlObjective))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.ReleaseDate != input.ReleaseDate || (this.ReleaseDate != null && !this.ReleaseDate.Equals(input.ReleaseDate))) return false;

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
                if (this.Identifier != null) hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Guidance != null) hashCode = hashCode * 59 + this.Guidance.GetHashCode();
                if (this.Resource != null) hashCode = hashCode * 59 + this.Resource.GetHashCode();
                if (this.Framework != null) hashCode = hashCode * 59 + this.Framework.GetHashCode();
                if (this.Service != null) hashCode = hashCode * 59 + this.Service.GetHashCode();
                if (this.Implementation != null) hashCode = hashCode * 59 + this.Implementation.GetHashCode();
                if (this.Behavior != null) hashCode = hashCode * 59 + this.Behavior.GetHashCode();
                if (this.Owner != null) hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Severity != null) hashCode = hashCode * 59 + this.Severity.GetHashCode();
                if (this.ControlObjective != null) hashCode = hashCode * 59 + this.ControlObjective.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.ReleaseDate != null) hashCode = hashCode * 59 + this.ReleaseDate.GetHashCode();
                return hashCode;
            }
        }
    }
}
