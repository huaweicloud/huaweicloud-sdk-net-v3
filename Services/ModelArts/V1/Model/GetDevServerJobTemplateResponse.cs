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
    /// Response Object
    /// </summary>
    public class GetDevServerJobTemplateResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：模板id。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**：模板名称。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**：模板描述。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**：容器启动命令。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("cmd", NullValueHandling = NullValueHandling.Ignore)]
        public string Cmd { get; set; }

        /// <summary>
        /// **参数解释**：任务镜像。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("swr_path", NullValueHandling = NullValueHandling.Ignore)]
        public string SwrPath { get; set; }

        /// <summary>
        /// **参数解释**：任务规格。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("resources", NullValueHandling = NullValueHandling.Ignore)]
        public string Resources { get; set; }

        /// <summary>
        /// **参数解释**：卷。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("volumes", NullValueHandling = NullValueHandling.Ignore)]
        public string Volumes { get; set; }

        /// <summary>
        /// **参数解释**：卷挂载。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("volumes_mount", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumesMount { get; set; }

        /// <summary>
        /// **参数解释**：规格类型。 **取值范围**：-ASCEND_SNT9B   -ASCEND_SNT9C   -ASCEND_GENERIC。
        /// </summary>
        [JsonProperty("flavor_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorType { get; set; }

        /// <summary>
        /// **参数解释**：任务超时时间。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("timeout", NullValueHandling = NullValueHandling.Ignore)]
        public string Timeout { get; set; }

        /// <summary>
        /// **参数解释**：任务的轮询周期。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("check_interval", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckInterval { get; set; }

        /// <summary>
        /// **参数解释**：任务类型。 **取值范围**：-LOG_COLLECT  -COMMON 等
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释**：模板状态。 **取值范围**：ACTIVE。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释**：模板的其他参数。
        /// </summary>
        [JsonProperty("params", NullValueHandling = NullValueHandling.Ignore)]
        public List<TemplateParam> Params { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetDevServerJobTemplateResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  cmd: ").Append(Cmd).Append("\n");
            sb.Append("  swrPath: ").Append(SwrPath).Append("\n");
            sb.Append("  resources: ").Append(Resources).Append("\n");
            sb.Append("  volumes: ").Append(Volumes).Append("\n");
            sb.Append("  volumesMount: ").Append(VolumesMount).Append("\n");
            sb.Append("  flavorType: ").Append(FlavorType).Append("\n");
            sb.Append("  timeout: ").Append(Timeout).Append("\n");
            sb.Append("  checkInterval: ").Append(CheckInterval).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  Params: ").Append(Params).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetDevServerJobTemplateResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetDevServerJobTemplateResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Cmd != input.Cmd || (this.Cmd != null && !this.Cmd.Equals(input.Cmd))) return false;
            if (this.SwrPath != input.SwrPath || (this.SwrPath != null && !this.SwrPath.Equals(input.SwrPath))) return false;
            if (this.Resources != input.Resources || (this.Resources != null && !this.Resources.Equals(input.Resources))) return false;
            if (this.Volumes != input.Volumes || (this.Volumes != null && !this.Volumes.Equals(input.Volumes))) return false;
            if (this.VolumesMount != input.VolumesMount || (this.VolumesMount != null && !this.VolumesMount.Equals(input.VolumesMount))) return false;
            if (this.FlavorType != input.FlavorType || (this.FlavorType != null && !this.FlavorType.Equals(input.FlavorType))) return false;
            if (this.Timeout != input.Timeout || (this.Timeout != null && !this.Timeout.Equals(input.Timeout))) return false;
            if (this.CheckInterval != input.CheckInterval || (this.CheckInterval != null && !this.CheckInterval.Equals(input.CheckInterval))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Params != input.Params || (this.Params != null && input.Params != null && !this.Params.SequenceEqual(input.Params))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Cmd != null) hashCode = hashCode * 59 + this.Cmd.GetHashCode();
                if (this.SwrPath != null) hashCode = hashCode * 59 + this.SwrPath.GetHashCode();
                if (this.Resources != null) hashCode = hashCode * 59 + this.Resources.GetHashCode();
                if (this.Volumes != null) hashCode = hashCode * 59 + this.Volumes.GetHashCode();
                if (this.VolumesMount != null) hashCode = hashCode * 59 + this.VolumesMount.GetHashCode();
                if (this.FlavorType != null) hashCode = hashCode * 59 + this.FlavorType.GetHashCode();
                if (this.Timeout != null) hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                if (this.CheckInterval != null) hashCode = hashCode * 59 + this.CheckInterval.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Params != null) hashCode = hashCode * 59 + this.Params.GetHashCode();
                return hashCode;
            }
        }
    }
}
