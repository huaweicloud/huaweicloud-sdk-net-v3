using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 创建对话结果上报配置请求。
    /// </summary>
    public class CreateDialogReportConfigReq 
    {

        /// <summary>
        /// **参数解释**： 接收对话结果上报的obs桶名。 **约束限制**： 不涉及 **取值范围**： 字符长度1-64 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("obs_bucket_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsBucketName { get; set; }

        /// <summary>
        /// **参数解释**： 接收对话结果上报的obs终端节点。 **约束限制**： 需要为obs合法终端节点。 **取值范围**： 字符长度1-64 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("obs_endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsEndpoint { get; set; }

        /// <summary>
        /// 对话结果上报开关
        /// </summary>
        [JsonProperty("enable_dialog_report", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableDialogReport { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDialogReportConfigReq {\n");
            sb.Append("  obsBucketName: ").Append(ObsBucketName).Append("\n");
            sb.Append("  obsEndpoint: ").Append(ObsEndpoint).Append("\n");
            sb.Append("  enableDialogReport: ").Append(EnableDialogReport).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateDialogReportConfigReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateDialogReportConfigReq input)
        {
            if (input == null) return false;
            if (this.ObsBucketName != input.ObsBucketName || (this.ObsBucketName != null && !this.ObsBucketName.Equals(input.ObsBucketName))) return false;
            if (this.ObsEndpoint != input.ObsEndpoint || (this.ObsEndpoint != null && !this.ObsEndpoint.Equals(input.ObsEndpoint))) return false;
            if (this.EnableDialogReport != input.EnableDialogReport || (this.EnableDialogReport != null && !this.EnableDialogReport.Equals(input.EnableDialogReport))) return false;

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
                if (this.ObsBucketName != null) hashCode = hashCode * 59 + this.ObsBucketName.GetHashCode();
                if (this.ObsEndpoint != null) hashCode = hashCode * 59 + this.ObsEndpoint.GetHashCode();
                if (this.EnableDialogReport != null) hashCode = hashCode * 59 + this.EnableDialogReport.GetHashCode();
                return hashCode;
            }
        }
    }
}
